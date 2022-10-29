/*
Universidad Mariano Gálvez
Ingeniería en sistemas de información y ciencias de la comunicación
Arquitectura de computadoras II
Ramiro José López Velásquez
0903-18-15570
*/

#include <Wire.h> 
#include <LiquidCrystal_I2C.h>
#include <Keypad.h>
#include <DHT.h>

bool estadoAlerta = false;
byte pinVentilador = 24; //Se activa en bajo
byte pinBuzzer = 25; //Se activa en alto
byte pinLedTemp = 26; // Se activa en alto
byte pinLedDist = 27; // Se activa en alto
const byte limitDistancia = 10; //Limite de distancia para la alerta
const byte limitTemperatura = 25; //Limite de temperatura para la alerta
 
//Crear el objeto lcd  dirección  0x27 y 16 columnas x 2 filas
LiquidCrystal_I2C lcd(0x27,16,2);  //

//Sensor de temperatura
#define DHTPIN 10 // Definimos el pin digital donde se conecta el sensor
#define DHTTYPE DHT11 // Dependiendo del tipo de sensor
DHT dht(DHTPIN, DHTTYPE); // Inicializamos el sensor DHT11

//Sensor ultrasónico
const byte Trigger = 11;   //Pin digital 2 para el Trigger del sensor
const byte Echo = 12;   //Pin digital 3 para el echo del sensor

//Teclado Matricial
const byte FILAS = 4;
const byte COLUMNAS = 4;
char keys[FILAS][COLUMNAS] = {
  {'1','2','3','A'},
  {'4','5','6','B'},
  {'7','8','9','C'},
  {'*','0','#','D'}
};

byte pinesFilas[FILAS] = {9,8,7,6};
byte pinesColumnas[COLUMNAS] = {5,4,3,2};

Keypad teclado = Keypad(makeKeymap(keys), pinesFilas, pinesColumnas, FILAS, COLUMNAS);  // crea objeto

//Clave de acceso
const char miClave[4] = {"633"};
char claveIngresada[4];
byte contador=0;
byte contFallos=0;

char caracter;

byte pinInterrupt = 2;

void setup()
{
    Serial.begin(9600); //Inicializar el monitor serial

    //Configuración del LCD
    lcd.init();    // Inicializar el LCD    
    lcd.backlight(); //Encender la luz de fondo.
    lcd.setCursor(0,0);
    
    pinMode(pinVentilador, OUTPUT);
    digitalWrite(pinVentilador, HIGH); //Apagado - Activación en Bajo
    
    pinMode(pinLedTemp, OUTPUT);
    pinMode(pinLedDist, OUTPUT);
    pinMode(pinBuzzer, OUTPUT);
    digitalWrite(pinBuzzer, LOW);

    dht.begin(); // Comenzamos el sensor DHT

    //Configuración de pines para sensor ultrasónico
    pinMode(Trigger, OUTPUT); //pin como salida
    pinMode(Echo, INPUT);  //pin como entrada
    digitalWrite(Trigger, LOW);//Inicializamos el pin con 0

    pinMode(pinInterrupt, OUTPUT);
    attachInterrupt(digitalPinToInterrupt(pinInterrupt), ingresarCodigo, RISING); //Programación de interrupciones
}

void loop()
{
    if (estadoAlerta)
    {
        ingresarCodigo();
        delay(200);
    }else{
        delay(500);
        medirTemperatura();
        medirDistancia();
    }
    
}

void medirTemperatura()
{
    float h = dht.readHumidity(); // Leemos la humedad relativa
    float t = dht.readTemperature(); // Leemos la temperatura en grados centígrados (por defecto)
    float f = dht.readTemperature(true); // Leemos la temperatura en grados Fahreheit
    
    // Comprobamos si ha habido algún error en la lectura
    if (isnan(h) || isnan(t) || isnan(f)) {
        Serial.println("Error obteniendo los datos del sensor DHT11");
        return;
    }
    
    float hif = dht.computeHeatIndex(f, h); // Calcular el índice de calor en Fahreheit
    float hic = dht.computeHeatIndex(t, h, false); // Calcular el índice de calor en grados centígrados
    
    if (t>limitTemperatura)
    {
        digitalWrite(pinVentilador, LOW); //Encendido - Activación en Bajo
        digitalWrite(pinLedTemp, HIGH); //Encendido - Activación en alto
    }else if(t<(limitTemperatura-5)){
        digitalWrite(pinVentilador, HIGH); //Apagado - Activación en Bajo
        digitalWrite(pinLedTemp, LOW); //Apagado
    }
    
    Serial.print("temp:");
    Serial.println(t);
    lcd.setCursor(1,1);
    lcd.print("Temperatura: ");
    if (t<10){
        lcd.print("0");
    }
    lcd.print(t);
}

void medirDistancia()
{
    long t; //timepo que demora en llegar el eco
    long d; //distancia en centimetros

    digitalWrite(Trigger, HIGH);
    delayMicroseconds(10);          //Enviamos un pulso de 10us
    digitalWrite(Trigger, LOW);
    
    t = pulseIn(Echo, HIGH); //obtenemos el ancho del pulso
    d = t/59;             //escalamos el tiempo a una distancia en cm
    
    if (d<100)
    {
        Serial.print("dist:");
        Serial.println(d);      //Enviamos serialmente el valor de la distancia
        lcd.setCursor(1,0);
        lcd.print("Distancia: ");
        if (d<10)
        {
            lcd.print("0");
        }
        lcd.print(d);
        
        if (d<limitDistancia && d != 0)
        {
            alertar(true);
            Serial.println("code:3"); //Alerta de objeto cerca
        }else{
            Serial.println("code:1");
        }
    }
    
    
    delay(100);          //Hacemos una pausa de 100ms
}

void ingresarCodigo()
{
    String dato;
    if(Serial.available()){
        dato = Serial.readStringUntil('\n');
        if(dato.toInt() > 0){
            if (dato == miClave)
            {
                contFallos = 0;
                Serial.print("code:");
                Serial.println("1"); // Mensaje de Bienvenido al sistema
                alertar(false);
            }
            
        }
    }
    
    caracter=teclado.getKey();
        if (caracter){
            claveIngresada[contador]=caracter;
            contador ++;
            Serial.println(caracter);
            
            if (contador==3){
                if (!strcmp(claveIngresada,miClave)){
                    contFallos = 0;
                    Serial.print("code:");
                    Serial.println("1"); // Mensaje de Bienvenido al sistema
                    alertar(false);
                }
                else{
                    contFallos+=1;
                    if (contFallos == 3){
                        Serial.print("code:");
                        Serial.println("3"); // Mensaje de Alerta codigo equivocado 3 veces
                        contFallos = 0;
                    }else{
                        Serial.print("code:");
                        Serial.println("2"); // Mensaje de codigo error
                    }
                }
                contador=0;
            }
        }
    
}

void alertar(bool state){
    estadoAlerta = state;
    if (state)
    {
        digitalWrite(pinLedDist, HIGH);
        digitalWrite(pinBuzzer, HIGH);
    }else{
        digitalWrite(pinLedDist, LOW);
        digitalWrite(pinBuzzer, LOW);
    }
    
}
#include "HID-Project.h"

//serial output consts
const byte OUTPUT_START = 2;
const byte OUTPUT_END = 3;
const byte OUTPUT_MOD = 17;
const byte OUTPUT_KEY = 18;
const byte OUTPUT_CONSUMER = 19;



const byte READING_NOT = 0;
const byte READING_CONSUMER = 1;
const byte READING_TEXT = 2;
const byte READING_KEY = 3;

byte reading = 0;
byte pos = 0;

byte str[100] = {0}; 

void setup() {
  // Start the Serial1 which is connected with the IO MCU.
  // Make sure both baud rates are the same
  // you can go up to 2000000 for very fast data transmission.
  Serial1.begin(115200);

  // Sends a clean report to the host. This is important on any Arduino type.
  Keyboard.begin();
  Consumer.begin();
  Serial.begin(115200);
}

byte readSerial1(){
  byte c = Serial1.read();
  //Serial.write(c);
  //Serial.write(' ');
  //Serial.print(c);
  //Serial.println();
  return c;
}

void sendOutput(byte readType){
  byte c;
  Serial.println(readType);
  if(readType == READING_CONSUMER){
    for(int i = 1; i < pos; i++){
      c = str[i];
      if(c==OUTPUT_END){
        break;
      }
      Consumer.write(c);
    }
  }
  else if(readType == READING_TEXT){
    Serial.println(F("sending text"));
    c = str[1];
    Serial.println(c, BIN);
    byte mod = c;
    if(c&0b00001000){
      Serial.println(F("pressed shift"));
      Keyboard.press(KEY_LEFT_SHIFT);
    }
    if(c&0b00000100){
      Serial.println(F("pressed ctrl"));
      Keyboard.press(KEY_LEFT_CTRL);
    }
    if(c&0b00000010){
      Serial.println(F("pressed gui"));
      Keyboard.press(KEY_LEFT_GUI);
    }
    if(c&0b00000001){
      Serial.println(F("pressed alt"));
      Keyboard.press(KEY_LEFT_ALT);
    }
    for(int i = 3; i < pos; i++){
      c = str[i];
      if(c==OUTPUT_END){
        break;
      }
      Serial.write(c);

      if(c&0b10000000){
        Keyboard.press(KeyboardKeycode(c&0b01111111));
        Keyboard.release(KeyboardKeycode(c&0b01111111));
      }
      else{
        Keyboard.press(c);
        Keyboard.release(c);
      }
    }
    Serial.println();
    Serial.println(F("released all"));
    Keyboard.releaseAll();
    
  }
  else if(readType == READING_KEY){
    if(str[1] == 0){
      Keyboard.release(str[2]);
    }
    else{
      Keyboard.press(str[2]);
    }
  }

}

void loop() {
  // Check if any Serial data from the IO MCaaaaU was received
  if(Serial.available() > 0){
    Serial1.write(Serial.read());
  }
  while(Serial1.available() > 0){
    byte c = readSerial1();
    if((reading == READING_NOT) && (c == OUTPUT_MOD)){
      reading = READING_TEXT;
      pos = 0;
    }
    else if((reading == READING_NOT) && (c == OUTPUT_CONSUMER)){
      reading = READING_CONSUMER;
      pos = 0;
    }
    else if((reading == READING_NOT) && (c == OUTPUT_KEY)){
      reading = READING_KEY;
      pos = 0;
    }
    if((reading == READING_CONSUMER) || (reading == READING_TEXT) || (reading == READING_KEY)){
      str[pos]=c;
      pos++;
    }
    else{
      Serial.write(c);
    }
    if((reading) && (c==OUTPUT_END)){
      Serial.println(F("ended"));
      sendOutput(reading);
      reading = READING_NOT;
    }
  }
 
  

  
}

#include <EEPROM.h>
#include <SPI.h>
#include <Wire.h>
#include <Adafruit_GFX.h>
#include <Adafruit_SSD1306.h>

typedef struct{
  int loopInterval;
} keyboardOptions;

typedef struct {
  byte loopingCommand;
  byte profileKey;
  byte modifiers;
  int stringLoc;
  byte stringLength;
} Action;

typedef struct {
  Action a;
  unsigned long timeToExecute;
} ActionQueue;

const byte ZERO = 0; 

//i2c consts
const byte OLED_ADDRESS = 0x3c;
const byte SCREEN_WIDTH = 128; // OLED display width, in pixels
const byte SCREEN_HEIGHT = 32; // OLED display height, in pixels

const byte FUNCTION_START = 0b10110000;

//keyboard consts
const byte PROFILE_KEY = 0;
const byte FN_KEY = 3;


//const byte ROWS = 2; 
//const byte COLS = 2;
//
//const byte KEYS = 4;
//
//int rows[ROWS] = {2, 3};
//int cols[COLS] = {8, 9};
//bool states[KEYS] = {};
//
//byte keymaps[ROWS][COLS] = {
//{0, 1},
//{2, 3}
//};

const byte ROWS = 6;
const byte COLS = 4; 

const byte KEYS = 24;

byte rows[ROWS] = {2, 3, 4, 5, 6, 7};
byte cols[COLS] = {8, 9, 10, 11};

bool states[KEYS] = {};

byte keymaps[ROWS][COLS] = {
{0, 1, 2, 3},
{4, 5, 6, 7},
{8, 9, 10, -1},
{11, 12, 13, 14},
{15, 16, 17, -1},
{18, -1, 19, 20}
};

const byte COMMAND_TEXT = 0;
//serial input consts
const byte INPUT_TYPE_COMMAND = 0xff;
const byte INPUT_TYPE_ACTION = 0x00;
const byte INPUT_COMMAND_RESET = 0;
const byte INPUT_COMMAND_RELOAD = 1;
const byte INPUT_COMMAND_OPTIONS = 2;
const byte INPUT_COMMAND_LOAD = 3;

const byte INPUT_TYPE = 0;
const byte INPUT_LOOP_COMMAND = 1;
const byte INPUT_PROFILE = 2;
const byte INPUT_KEY = 3;
const byte INPUT_MOD = 4;
const byte INPUT_STRING = 5;

const byte INPUT_END = 0xfe;

//serial output consts
const byte OUTPUT_START = 2;
const byte OUTPUT_END = 3;
const byte OUTPUT_MOD = 17;
const byte OUTPUT_KEY = 18;
const byte OUTPUT_CONSUMER = 19;

//display vars
Adafruit_SSD1306 display(SCREEN_WIDTH, SCREEN_HEIGHT, &Wire, -1);
unsigned long clearTime = 0;
bool clearScreen = false;

//memory vars:
int nextStringMem = EEPROM.length()-1;
int nextActionMem = 0;

//action queue
ActionQueue queuedActions[5];

//profile vars:
byte profile = 0;
int profileLocMap[KEYS][4] = {0};
Action currentProfile[KEYS];

//settings vars:
keyboardOptions options;
byte mode = 0;

//global string
volatile char str[100] ={0};

bool printKeyInfo = false;

//function that changes the current profile
void changeProfile(byte p){
  profile = p;
  loadCurrentProfile();
}

void switchProfile(){
  if(profile == 4){
    profile = 0;
  }
  else{
    profile+=1;
  }
  //initialize();
}

//function that loads the actions in the current profile by the profile action location map
void loadCurrentProfile(){
  for(int i = 0; i < KEYS; i++){
    Action a = {};
    if(profileLocMap[i][profile] == 0){
      a.loopingCommand=0xff;
    }
    else{
      EEPROM.get(profileLocMap[i][profile], a);
    }
    currentProfile[i] = a;
  }
}

Action getActionFromKey(byte key){
  return currentProfile[key];
}

void initialize(){
  loadEEPROM();
  changeProfile(profile);
  for(int i = 0; i < 5; i++){
    queuedActions[i] = ActionQueue{Action{}, -1};
  }
}

bool specialKey(byte key){
  if(key == PROFILE_KEY){
    //Serial.println("Switching profile");
    switchProfile();
    initialize();
    printProfile();
    return true;
  }
  else if(key == FN_KEY){
    printKeyInfo = true;
    return true;
  }
  return false;
}

bool specialKeyCheck(byte key){
  if(key == PROFILE_KEY){
    return true;
  }
  else if(key == FN_KEY){
    return true;
  }
  return false;
}

void setup() {
  Serial.begin(115200);
  Serial.println("Running Setup");
  if(!display.begin(SSD1306_SWITCHCAPVCC, 0x3C)) { // Address 0x3C for 128x32
     Serial.println("Screen failiure");
     delay(1000);
  }
  for(int i = 0; i < COLS; i++){
    pinMode(cols[i], INPUT_PULLUP);
  }
  for(int i = 0; i < ROWS; i++){
    pinMode(rows[i], OUTPUT);
    digitalWrite(rows[i], HIGH);
  }
  for(int i = 0; i < KEYS; i++){
    states[i] = 0;
  }
  delay(100);
  display.clearDisplay();
  display.display();
  initialize();
  printMemoryUsage();
}


void loop() {
  //read input from serial
  if (Serial.available() > 0){
    byte reading = 1;
    byte readIn[100];
    byte i = 0;
    long lastRead = millis();
    while(millis() < lastRead + 1000){
      if(Serial.available() > 0){
        lastRead = millis();
        i++;
        byte c = Serial.read();
        Serial.print(c, HEX);
        Serial.print(" ");
        if(c == INPUT_END){
          Serial.println("breaking input");
          break;
        }
        if(i > 100){
          reading = 0;
        }
        if(reading == 1){
          readIn[i-1]= c;
        }
        
      }
    }

    Serial.print("read: ");
    Serial.println(i);
    if(!reading){
      i = 100;
    }
    //handle the input
    handleInput(readIn, i-2);
  }

  //read keys
  scan();
  for(int i = 0; i < 5; i++){
    if(queuedActions[i].timeToExecute != -1){
      if(millis() > queuedActions[i].timeToExecute){
        playAction(queuedActions[i].a);
        queuedActions[i] = getNextQueue(queuedActions[i].a);
      }
    }
  }

  if(clearScreen && clearTime < millis()){
    //Serial.println(clearTime);
    //Serial.println(millis());
    clearScreen = false;
    printProfile();
  }
}

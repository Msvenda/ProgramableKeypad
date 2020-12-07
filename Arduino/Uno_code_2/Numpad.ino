//array that maps keys to keypad values
byte numpadKeys[21] = {0, 179, 178, 0, 219, 220, 221, 222, 231, 232, 233, 
                      228, 229, 230, 223, 225, 226, 227, 234, 235, 224};

//function that handles keypad presses
void numpadPress(byte key){
  if(numpadKeys[key]!=0){
     pressKey(numpadKeys[key]);
  };
}

//function that handles keypad releases
void numpadRelease(byte key){
  if(numpadKeys[key]!=0){
     releaseKey(numpadKeys[key]);
  };
}

//function that presses single key
void pressKey(byte key){
  Serial.write(OUTPUT_KEY);
  Serial.write(1);
  Serial.write(key);
  Serial.write(OUTPUT_END);
}
//function that releases single key
void releaseKey(byte key){
  Serial.write(OUTPUT_KEY);
  Serial.write(PROFILE_KEY);
  Serial.write(key);
  Serial.write(OUTPUT_END);
}

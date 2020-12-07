
//function that scans keyboard matrix for newly pressed or released keys and executes actions accordingly
//returns number of keys pressed during scan
byte scan(){
  int c = 0;
  for(int i = 0; i < ROWS; i++){
    digitalWrite(rows[i], LOW);
    for(int j = 0; j <  COLS; j++){
      if(digitalRead(cols[j])){
        stopAction(i, j);
      }
      else{
        doAction(i, j);
        c++;
      }
    }
    digitalWrite(rows[i], HIGH);
  }
  return c;
}

void doAction(int row, int col){
  int key = keymaps[row][col];
  if(key==-1){
    return;
  }
  if(states[key] == 0){
    states[key] = 1;
    if(printKeyInfo){
      printSelectedKey(key);
      printKeyInfo = false;
    }
    else if(!specialKey(key)){
      if(profile == 4){
        numpadPress(key);
      }
      else{
        Action a = getActionFromKey(key);
        activateAction(a);
      }
    }
  }
}
void stopAction(int row, int col){
  byte key = keymaps[row][col];
  if(key>KEYS){
    return;
  }
  if(states[key] == 1){
    states[key] = 0;
    if(profile == 4){
      numpadRelease(key);
    }
    if(!specialKeyCheck(key)){
      Serial.println(key);
      Action a = getActionFromKey(key);
      deactivateAction(a);
    }
  }
}


//function that handles Serial input and hadles it acording to content
void handleInput(byte readIn[], byte len){
  //if INPUT_TYPE byte is INPUT_TYPE_COMMAND check next byte and execute requested command
  if(readIn[INPUT_TYPE] == INPUT_TYPE_COMMAND){
    switch(readIn[1]){
      //command for reseting the memory
      case INPUT_COMMAND_RESET:{
        Serial.println(F("Wiping memory and setting defaults"));
        reset();
        break;
      }
      //command for reloading device
      case INPUT_COMMAND_RELOAD:{
        initialize();
        break;
      }
      //command for setting the device options
      case INPUT_COMMAND_OPTIONS:{
        int interval = (readIn[2]<<8)+readIn[3];
        keyboardOptions o ={};
        o.loopInterval = interval;
        EEPROM.put(0, o);
        initialize();
        break;
      }
//      case INPUT_COMMAND_LOAD:{
//        
//        break;
//      }
    }
  }
  //else forward input to save and create action
  else if(readIn[INPUT_TYPE] == INPUT_TYPE_ACTION){
    if(readIn[INPUT_PROFILE] > 3 || readIn[INPUT_KEY] > 20 || len < 4){
      printFormatError();
    }
    else if(!createAndSaveAction(readIn, len)){
      printSaveError();
    }
    else{
      initialize();
      printMemoryUsage();
    }
    
  }
}

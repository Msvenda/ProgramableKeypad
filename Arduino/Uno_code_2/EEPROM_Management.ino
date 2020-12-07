
//function that takes byte array and creates an action from it
//returns false if action could not be created or saved, or true otherwise
bool createAndSaveAction(byte readIn[], byte len){
  
  //create action
  Action a = Action{};
  a.loopingCommand = readIn[INPUT_LOOP_COMMAND]+FUNCTION_START;
  a.profileKey = (readIn[INPUT_PROFILE]<<6) + readIn[INPUT_KEY];
  a.modifiers = readIn[INPUT_MOD];

  //check if profile and key combo is taken
  int addr = profileKeyIsTaken(a.profileKey);
  a.stringLength = len-INPUT_STRING;
  
  //check if string fits in old memory location
  bool oldMem = false;
  Action oldA;
  if(addr){
    EEPROM.get(addr, oldA);
    if(oldA.stringLength >= a.stringLength){
      oldMem = true;
    }
  }
  

  //write string to memory
  //if can save in old memory location
  if(oldMem){
    int mem = oldA.stringLoc;
    for(int i = INPUT_STRING; i <= len; i++){
      //Serial.write(readIn[i]);
      byte c = readIn[i];
      EEPROM.write(mem, c);
      mem++;
    }
    a.stringLoc = oldA.stringLoc;
  }
  //if can not save in old memory location
  else{
    //cehck if new new action can be saved in EEPROM
    float memUsage = EEPROM.length()-1-len;
    memUsage -= nextActionMem+sizeof(a);
    memUsage -= (EEPROM.length()-nextStringMem);
    memUsage = memUsage/(EEPROM.length()-1.0);
    
    //if EEPROM would fill up, return false
    if(memUsage<0.001){
      return false;
    }
    for(int i = len; i >= INPUT_STRING; i--){
      //Serial.write(readIn[i]);
      byte c = readIn[i];
      EEPROM.write(nextStringMem, c);
      nextStringMem--;
    }
    a.stringLoc = nextStringMem+1;
  }
  
  //save action to memory
  //if profile and key combo is taken save to same location
  if(addr){
    EEPROM.put(addr, a);
  }
  //else save to next availiable location
  else{
    EEPROM.put(nextActionMem, a);
    nextActionMem += sizeof(a);
  }
  return true;
}

//function that loads all settings and actions from EEPROM
void loadEEPROM(){
  //reset memory pointer
  nextActionMem = 0;
  Serial.println("loading Actions");
  Action a = {};
  
  //load board options and move memory pointer
  EEPROM.get(nextActionMem, options);
  nextActionMem+=sizeof(options);
  Serial.print(F("options: "));
  Serial.println(options.loopInterval);
  Serial.print(F("actionMem: "));
  Serial.println(nextActionMem);

  //load actions until all loaded
  while(true){
    EEPROM.get(nextActionMem, a);
    Serial.println(a.loopingCommand, BIN);
    Serial.println(nextActionMem);
    //if loopingCommand does not start with FUNCTION_START all actions are assumed loaded
    if(( (a.loopingCommand >> 3) & (~FUNCTION_START >> 3) ) == 0){
      loadAction(a, nextActionMem);
      nextActionMem+=sizeof(a);
      //Serial.println("loaded Action");
    }
    else{
      //Serial.println("no more Actions found");
      break;
    }
  }
}

//function that gets string from eeprom using its starting location and length
void getStringFromEEPROM(int loc, byte len){
  for(int i = 0; (i<=len); i++){
    int addr = loc+i;
    str[i] = (EEPROM.read(addr));
  }
  return ;
}

//resets EEPROM to starting values
void reset(){
  nextStringMem = EEPROM.length()-1;
  keyboardOptions o ={};
  o.loopInterval = 1000;
  EEPROM.put(0, o);
  for(int i = sizeof(o); i < EEPROM.length(); i++){
    EEPROM.update(i, 0xff);
  }
  initialize();
}

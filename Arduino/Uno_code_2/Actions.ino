
//function that readies an action for use
void loadAction(Action a, int memLoc){
  byte profile, key;
  Serial.print(F("ProfileKey: "));
  Serial.println(a.profileKey, BIN);
  profile = a.profileKey>>6;
  Serial.print(F("Profile: "));
  Serial.println(profile, BIN);
  key = (a.profileKey&0b00111111);
  Serial.print(F("Key: "));
  Serial.println(key, BIN);
  profileLocMap[key][profile] = memLoc;
  if(a.stringLoc < nextStringMem){
    nextStringMem = a.stringLoc-1; 
  }
}

//function that checks if the profile and key combination is already taken
//returns addres of action if taken, or 0 if not taken
int profileKeyIsTaken(byte profileKey){
  byte profile = profileKey>>6;
  byte key = (profileKey&0b00111111);
  if(profileLocMap[key][profile]!=0){
    return profileLocMap[key][profile];
  }
  return 0;
}

//function that activates saved action depending on type and length
void activateAction(Action a){
  //if action content is empty or too long, abort
  if(a.stringLength < 0 || a.stringLength > 99){
    return;
  }
  //if action is looping, queue it
  if((a.loopingCommand & 0b00000110) > 0){
    byte wasQueued = false;
    //check if action already in queue and remove it
    for(int i = 0; i <  5; i++){
      if(queuedActions[i].a.profileKey == a.profileKey){
         queuedActions[i] = ActionQueue{Action{}, -1};
         wasQueued = true;
      }
    }
    //if action not queued, play it once and queue it
    if(!wasQueued){
      if(!queueAction(a)){
        printQueueError();
      }
      playAction(a);
    }
  }
  //if action is single text key, play it as key
  else if( ((a.loopingCommand & 0b00000001) == COMMAND_TEXT) && 
      (a.modifiers == 0) && 
      ((a.loopingCommand & 0b00000110) == 0) &&
      (a.stringLength == 0) ){
    
    playKey(a);
  }
  //if does not meet other criteria, play as normal action
  else{
    playAction(a);
  }
}

//functions that stops action after key released. Only applicable to single key actions
void deactivateAction(Action a){
  if( ((a.loopingCommand & 0b00000001) == COMMAND_TEXT) && 
      (a.modifiers == 0) && 
      ((a.loopingCommand & 0b00000110) ==0) &&
      (a.stringLength == 0) ){
    stopKey(a);
  }
}

//send action to 16u2 to be sent to PC
void playAction(Action a){
  //if command is text, send text command to 16u2
  if((a.loopingCommand & 0b00000001) == COMMAND_TEXT){
    //send modifier byte
    //Serial.print("output mod:");
    Serial.write(OUTPUT_MOD);
    //Serial.println();
    //send modifiers
    //Serial.print("modifiers:");
    Serial.write(a.modifiers);
    //Serial.println();
    //get text from EEPROM
    getStringFromEEPROM(a.stringLoc, a.stringLength);
    //send text start byte and write text
    //Serial.print("output start:");
    Serial.write(OUTPUT_START);
    //Serial.println();
    //Serial.print("output text:");
    for(int i = 0; i <= a.stringLength; i++){
      Serial.write(str[i]);
    }
    //Serial.println();
    //send end byte
    //Serial.print("output end:");
    Serial.write(OUTPUT_END);
    //Serial.println();
  }
  //if command is not text, send consumer command to 16u2
  else{
    //get modifiers  from EEPROM
    getStringFromEEPROM(a.stringLoc, a.stringLength);
    //send consumer byte and write consumer keys
    Serial.write(OUTPUT_CONSUMER);
    for(int i = 0; i <= a.stringLength; i++){
      Serial.write(str[i]);
    }
    //send end byte
    Serial.write(OUTPUT_END);
  }

}

//function that sends key to be pressed to 16u2
void playKey(Action a){
  Serial.write(OUTPUT_KEY);
  Serial.write(1);
  getStringFromEEPROM(a.stringLoc, a.stringLength);
  Serial.write(str[0]);
  Serial.write(OUTPUT_END);
}

//function that sends key to be released to 16u2
void stopKey(Action a){
  Serial.write(OUTPUT_KEY);
  Serial.write(ZERO);
  getStringFromEEPROM(a.stringLoc, a.stringLength);
  Serial.write(str[0]);
  Serial.write(OUTPUT_END);
}

//function that queues action to be executed in loop.
//returns false on failiure and true on success
bool queueAction(Action a){
  byte wasQueued = false;
  for(int i = 0; i <  5; i++){
    //if no action is in queue slot time to execute == -1
    if(queuedActions[i].timeToExecute == -1){
      queuedActions[i] = getNextQueue(a);
      wasQueued = true;
      break;
    }
  }
  return wasQueued;
}

//set next execution time for queue item depending on loop type
ActionQueue getNextQueue(Action a){
  unsigned long timeToExecute = millis();
  switch((a.loopingCommand & 0b110) >> 1){
    case 1:{
      timeToExecute += options.loopInterval;
      break;
    }
    case 2:{
      timeToExecute += options.loopInterval/2;
      break;
    }
    case 3:{
      timeToExecute += options.loopInterval/4;
    }
  }
  return ActionQueue{a, timeToExecute};
}


//function that clears the screen and resets all text options
void resetScreen(){
  display.clearDisplay();
  display.setTextSize(1);             // Normal 1:1 pixel scale
  display.setTextColor(SSD1306_WHITE);        // Draw white text
  display.setCursor(0,0);             // Start at top-left corner
}

//function that prints the current profile
void printProfile(){
  //don't print profile if other info printed
  if(clearScreen == true){
    return;
  }
  resetScreen();
  display.setTextSize(2);
  display.println(F("PROFILE: "));
  if(profile < 4){
     display.println((profile+1));
  }
  else{
    display.println(F("NUMPAD"));
  }
  
  display.display();
}

//print current memory usage
void printMemoryUsage(){
  float memUsage = EEPROM.length()-1;
  memUsage -= nextActionMem;
  memUsage -= (EEPROM.length()-nextStringMem);
  memUsage = memUsage/(EEPROM.length()-1.0);
  memUsage *= 100;
  memUsage = 100 - memUsage;
  resetScreen();
  display.setTextSize(1);
  display.println(F("Memory usage:"));
  display.setTextSize(2);
  display.print(memUsage);
  display.println(F("%"));
  display.display();
  printProfileDelay(3000);
}

//print error in in queueing action
void printQueueError(){
  resetScreen();
  display.setTextSize(2);
  display.println(F("ERROR:"));

  display.setTextSize(1);
  display.print(F("Error queueing action, action queue may be full."));
  
  display.display();

  printProfileDelay(3000);
}

//print overflow error in saving action
void printSaveError(){
  resetScreen();
  display.setTextSize(2);
  display.println(F("ERROR:"));

  display.setTextSize(1);
  display.print(F("Error saving; memory overflow. Reset Memory."));
  
  display.display();

  printProfileDelay(3000);
}

//print format error in saving action
void printFormatError(){
  resetScreen();
  display.setTextSize(2);
  display.println(F("ERROR:"));

  display.setTextSize(1);
  display.print(F("Error saving; wrong format."));
  
  display.display();

  printProfileDelay(3000);
}

//prints saved action for selected key
void printSelectedKey(byte key){
  
  Action a = getActionFromKey(key);
  if(a.stringLength < 0 || a.stringLength > 99){
    return;
  }
  getStringFromEEPROM(a.stringLoc, a.stringLength);

  resetScreen();
  display.setTextSize(1);
  display.print(F("Key: ")); display.print(key);
  if(key == PROFILE_KEY){
    display.println(F(""));
    display.print(F("Changes to the next profile (1-5)"));
  }
  else if(key == FN_KEY){
    display.println(F(""));
    display.print(F("Press another key to get it's function"));
  }
  else if(profile == 4){    
    display.println(F(""));
    display.print(F("Check Keycap"));
  }
  else{
    if( (a.loopingCommand & 0b1) == 0){
      if(a.modifiers & 0b1000){
        display.write(' ');
        display.print(F("| SHIFT"));
      }
      if(a.modifiers & 0b0100){
        display.write(' ');
        display.print(F("| CTRL"));
      }
      if(a.modifiers & 0b0010){
        display.write(' ');
        display.print(F("| WIN/GUI"));
      }
      if(a.modifiers & 0b0001){
        display.write(' ');
        display.print(F("| ALT"));
      }
    }
    if((a.loopingCommand & 0b110) != 0){
      if( (a.loopingCommand & 0b110) == 2){
        display.write(' ');
        display.print(F("| 1x"));
      }
      else if((a.loopingCommand & 0b110) == 4){
        display.write(' ');
        display.print(F("| 2x"));
      }
      else if((a.loopingCommand & 0b110) == 6){
        display.write(' ');
        display.print(F("| 4x"));
      }
    }
    display.println(F(""));
    for(int i = 0;  i < a.stringLength+1; i++){
      if(isPrintable(str[i])){
        display.write(str[i]);
      }
      else{
        String s = String(str[i], HEX);
        display.print(F("[0x"));
        display.write(s[2]);
        display.write(s[3]);
        display.write(']');
      }
      
    }
    display.print(F(""));
  }
  display.display();

  printProfileDelay(3000);
  
}

//prints profile info with specified delay
void printProfileDelay(long m){
  clearScreen = true;
  clearTime = millis() + m;
}

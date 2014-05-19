/* CanSat Mini GS */

#include <LiquidCrystal.h>
// initialize the library with the numbers of the interface pins

#define BACKLIGHT_PIN 13

float alt = 0;
float temp = 0;
int mission_time = 0;
int pkt_cnt = 0;


byte alt_buf[2] = {0,0};
byte tmp_buf[2] = {0,0};
byte mission_time_buf[2] = {0,0}; // Mission Time Buffer
byte pkt_cnt_buf[2] = {0,0}; // Packet count buffer

int next_pkt_cnt = 1;
int pkt_loss = 0;

//Used for decent rate calculation
float alts [3];
int alts_idx = 0;
float mission_times [3];
int mission_time_idx = 0;

int byteCount = 0; // Incoming telemetry bytes after start delimiter 7E 
LiquidCrystal lcd(12, 11, 5, 4, 3, 2);


void setup() {
  
   pinMode(BACKLIGHT_PIN, OUTPUT);
   digitalWrite(BACKLIGHT_PIN,HIGH);
  // set up the LCD's number of columns and rows:
  lcd.begin(20, 4);  
  lcd.setCursor(0, 0);
  Serial.begin(9600);
}

void loop() {
  
  alt = BitReadCombine(alt_buf[0],alt_buf[1])/100.0;
  alts[(++alts_idx)%3] = alt;
  temp = BitReadCombine(tmp_buf[0],tmp_buf[1])/10.0;
  mission_time = BitReadCombine(mission_time_buf[0],mission_time_buf[1]);
  mission_times[(++mission_time_idx)%3] = mission_time;
  pkt_cnt = BitReadCombine(pkt_cnt_buf[0],pkt_cnt_buf[1]);
  pkt_loss += pkt_cnt-next_pkt_cnt;
  next_pkt_cnt = pkt_cnt;
   
  
  //Print on LCD   
  lcd.setCursor(0,0);
  lcd.print("Alt:");
  lcd.print(alt);  
  
  lcd.setCursor(0,1);
  lcd.print("Temp:");
  lcd.print(temp);
    
  lcd.setCursor(0,2);
  lcd.print("DR:");
  lcd.print(calculate_decent_rate());

  lcd.setCursor(0,3);
  lcd.print("PKT Loss:");  
  lcd.print((pkt_loss*100.0)/pkt_cnt);
  lcd.print("%");
  delay(500);
}

void serialEvent() {
  while (Serial.available()) {
    // get the new byte:
    byte inChar = Serial.read();                    
    byteCount++;
    
    // PKT_CNT
    if(byteCount > 2  && byteCount<5){
      pkt_cnt_buf[byteCount - 3] = inChar;
    }
    
    //MISSION_TIME
    if(byteCount > 4  && byteCount<7){
      mission_time_buf[byteCount - 4] = inChar;
    }
    
    //ALT
    if(byteCount > 20  && byteCount<23){
      alt_buf[byteCount - 21 ] = inChar;
    }
    
    //TMP
    if(byteCount > 22 && byteCount<25){
      tmp_buf[byteCount-23] = inChar;
    }          
    
    //START DELIM
    if(inChar == 0x7E){       
       byteCount = 0;               
    }
   
  }
 
}

int BitReadCombine( unsigned int x_high, unsigned int x_low)
{
  int x;
  for( int t = 7; t >= 0; t--)
  {
    bitWrite(x, t,  bitRead(x_low, t));
  }
  for( int t = 7; t >= 0; t--)
  {
    bitWrite(x, t + 8,  bitRead(x_high, t));
  }
  return x;
}

float calculate_decent_rate(){
   float decent_rate_sum = 0;
   for(int i = 0;i<2;i++){
     int diff = mission_times[i+1]-mission_times[i]
     if(diff!=0){
       decent_rate_sum += (alts[i+1] - alts[i])/diff); 
     }
   } 
   return decent_rate_sum/2;
}


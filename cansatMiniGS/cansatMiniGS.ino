/* CanSat Mini GS */

#include <LiquidCrystal.h>
// initialize the library with the numbers of the interface pins

#define BACKLIGHT_PIN 13

float p_alt = 0;
float p_temp = 0;
int p_mission_time = 0;
int p_lux = 0;
int p_pkt_cnt = 0;

float c_alt = 0;
float c_temp = 0;
int c_mission_time = 0;
int c_pkt_cnt = 0;


byte p_alt_buf[2] = {0,0};
byte p_tmp_buf[2] = {0,0};
byte p_mission_time_buf[2] = {0,0}; // Mission Time Buffer
byte p_pkt_cnt_buf[2] = {0,0}; // Packet count buffer

//Used for payload decent rate calculation
float p_alts [3];
int p_alts_idx = 0;
float p_mission_times [3];
int p_mission_time_idx = 0;

byte c_alt_buf[2] = {0,0};
byte c_tmp_buf[2] = {0,0};
byte c_mission_time_buf[2] = {0,0}; // Mission Time Buffer
byte c_pkt_cnt_buf[2] = {0,0}; // Packet count buffer

//Used for container decent rate calculation
float c_alts [3];
int c_alts_idx = 0;
float c_mission_times [3];
int c_mission_time_idx = 0;


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
  
  p_alt = BitReadCombine(p_alt_buf[0],p_alt_buf[1])/100.0;
  p_alts[(++p_alts_idx)%3] = p_alt;
  p_temp = BitReadCombine(p_tmp_buf[0],p_tmp_buf[1])/10.0;
  p_mission_time = BitReadCombine(p_mission_time_buf[0],p_mission_time_buf[1]);
  p_mission_times[(++p_mission_time_idx)%3] = p_mission_time;
  p_pkt_cnt = BitReadCombine(p_pkt_cnt_buf[0],p_pkt_cnt_buf[1]);
     
  
  //Print on LCD   
  lcd.setCursor(0,0);
  lcd.print("PA:");
  lcd.print(p_alt);  
  
  lcd.setCursor(10,0);
  lcd.print("PT:");
  lcd.print(p_temp);
  
  lcd.setCursor(0,1);
  lcd.print("PL:");
  lcd.print(p_lux);  
  
  lcd.setCursor(10,1);
  lcd.print("PD:");
  lcd.print(calculate_decent_rate());


 
  delay(500);
}

void serialEvent() {
  while (Serial.available()) {
    // get the new byte:
    byte inChar = Serial.read();                    
    byteCount++;
    
    // PKT_CNT
    if(byteCount > 2  && byteCount<5){
      p_pkt_cnt_buf[byteCount - 3] = inChar;
    }
    
    //MISSION_TIME
    if(byteCount > 4  && byteCount<7){
      p_mission_time_buf[byteCount - 4] = inChar;
    }
    
    //ALT
    if(byteCount > 20  && byteCount<23){
      p_alt_buf[byteCount - 21 ] = inChar;
    }
    
    //TMP
    if(byteCount > 22 && byteCount<25){
      p_tmp_buf[byteCount-23] = inChar;
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
     int diff = p_mission_times[i+1]-p_mission_times[i];
     if(diff!=0){
       decent_rate_sum += ((p_alts[i+1] - p_alts[i])/diff); 
     }
   } 
   return decent_rate_sum/2;
}


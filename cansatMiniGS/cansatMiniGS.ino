/* CanSat Mini GS */

#include <LiquidCrystal.h>
// initialize the library with the numbers of the interface pins

#define BACKLIGHT_PIN 13

typedef struct{  
  float alt;
  float temp;
  uint16_t mission_time;
  uint16_t lux;
  uint16_t pkt_cnt;
  int src_vlt;
  boolean umbrella_deployed;
  boolean payload_released;
}telemetry_packet_t;

static telemetry_packet_t p;
static telemetry_packet_t c;

byte alt_buf[2] = {0,0};
byte tmp_buf[2] = {0,0};
byte mission_time_buf[2] = {0,0}; // Mission Time Buffer
byte pkt_cnt_buf[2] = {0,0}; // Packet count buffer
byte vlt_buf[2] = {0,0};
byte lux_buf[2] = {0,0};
byte status_buf[2] = {0,0};

//Used for payload decent rate calculation
float p_alts [3];
int p_alts_idx = 0;
float p_mission_times [3];
int p_mission_time_idx = 0;

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
  
  //Print on LCD   
  lcd.setCursor(0,0);
  lcd.print("PA:");
  lcd.print(p.alt);  
  
  lcd.setCursor(10,0);
  lcd.print("PT:");
  lcd.print(p.temp);
  
  lcd.setCursor(0,1);
  lcd.print("PL:");
  lcd.print(p.lux);  
  
  lcd.setCursor(10,1);
  lcd.print("PD:");
  lcd.print(calculate_decent_rate(true));
  
  //Print on LCD   
  lcd.setCursor(0,2);
  lcd.print("CA:");
  lcd.print(c.alt);  
  
  lcd.setCursor(10,2);
  lcd.print("CT:");
  lcd.print(c.temp);
  
  lcd.setCursor(0,3);
  lcd.print("CS:");
  lcd.print(c.umbrella_deployed?"Y","N"); 
  lcd.print(c.payload_released?"Y","N");
  
  lcd.setCursor(10,3);
  lcd.print("CD:");
  lcd.print(calculate_decent_rate(false));


 
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

    //SOURCE VOLT
    if(byteCount > 24 && byteCount<27){
      vlt_buf[byteCount-25] = inChar;
    }    
    
    //LUX
    if(byteCount > 26 && byteCount<29){
      lux_buf[byteCount-27] = inChar;
    }  
    
    //STATUS
    if(byteCount > 28 && byteCount<31){
      status_buf[byteCount-29] = inChar;
    }      
    
    //START DELIM
    if(inChar == 0x7E){       
       byteCount = 0;         
       if(status_buf[0]==0xFF){
       //Container
        c.alt = BitReadCombine(alt_buf[0],alt_buf[1])/10.0;
        c_alts[(++c_alts_idx)%3] = c.alt;
        c.temp = BitReadCombine(tmp_buf[0],tmp_buf[1])/10.0;
        c.mission_time = BitReadCombine(mission_time_buf[0],mission_time_buf[1]);
        c_mission_times[(++c_mission_time_idx)%3] = c.mission_time;
        c.pkt_cnt = BitReadCombine(pkt_cnt_buf[0],pkt_cnt_buf[1]);    
        c.umbrella_deployed = status_buf[1] & 0xF0;
        c.payload_released = status_buf[1]&0x0F;
      }else{
        //Payload
        p.alt = BitReadCombine(alt_buf[0],alt_buf[1])/100.0;
        p_alts[(++c_alts_idx)%3] = p.alt;
        p.temp = BitReadCombine(tmp_buf[0],tmp_buf[1])/10.0;
        p.mission_time = UBitReadCombine(mission_time_buf[0],mission_time_buf[1]);
        p_mission_times[(++p_mission_time_idx)%3] = p.mission_time;
        p.pkt_cnt = UBitReadCombine(pkt_cnt_buf[0],pkt_cnt_buf[1]);   
        p.lux = UBitReadCombine(lux_buf[0],lux_buf[1])*16;  
        p.src_vlt = BitReadCombine(vlt_buf[0],vlt_buf[1]);         
      }  
    }
  }
}

uint16_t UBitReadCombine( unsigned int x_high, unsigned int x_low)
{
  uint16_t x;
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

float calculate_decent_rate(boolean payload){
   float decent_rate_sum = 0;
   int diff;
   for(int i = 0;i<2;i++){
     if(payload){
         diff = p_mission_times[i+1]-p_mission_times[i];
         if(diff!=0){
           decent_rate_sum += ((p_alts[i+1] - p_alts[i])/diff); 
         }
     }else{
        diff = c_mission_times[i+1]-c_mission_times[i];
        if(diff!=0){
          decent_rate_sum += ((c_alts[i+1] - c_alts[i])/diff);
        }
     } 
   return decent_rate_sum/2;
 }
}


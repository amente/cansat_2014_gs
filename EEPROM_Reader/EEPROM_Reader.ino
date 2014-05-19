#include <Wire.h>
#define EEPROM_ADDR  0x50
#define EEPROM_SIZE  0x8000
#define EEPROM_BLOCK_SIZE  32

void setup()
{
  Wire.begin();        // join i2c bus (address optional for master)
  Serial.begin(9600);  // start serial for output
}

void loop()
{
  while(Serial.available())
    Serial.read();
  while(!Serial.available());

  Wire.beginTransmission(EEPROM_ADDR);
      Wire.write(0x00);
      Wire.write(0x00);
  Wire.endTransmission(false);
  
  for(int i=0; i<EEPROM_SIZE/EEPROM_BLOCK_SIZE; i++)
  { 
    Wire.requestFrom(EEPROM_ADDR, EEPROM_BLOCK_SIZE); 
    while(Wire.available())
      Serial.write(Wire.read());
    Serial.flush();
  }
}

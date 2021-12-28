#include <SPI.h>
#include <Wire.h>
#include <Adafruit_GFX.h>
#include <Adafruit_SSD1306.h>
#define OLED_RESET 4
Adafruit_SSD1306 display(OLED_RESET);
void setup() {
  Serial.begin(9600);
  pinMode(5, INPUT);
  pinMode(7, OUTPUT);
  digitalWrite(7, HIGH);
  display.begin(SSD1306_SWITCHCAPVCC, 0x3C);
  display.clearDisplay();
  display.display();
}

int zaehler = 1;
int buchstabe = 0;

void loop() {
  if (Serial.available() > 0) {
    buchstabe = Serial.read();
    
    if (buchstabe == 119)
    {
      zaehler++;
    }
  }

  display.clearDisplay();
  display.setTextColor(WHITE);
  display.setTextSize(2);
  display.setCursor(5,0);

  if (zaehler == 1)
  {
    display.println("Fabian");
  }

  if (zaehler == 2)
  {
    display.println("Granig");
  }

  if (zaehler == 3)
  {
    display.println("1.12.2004");
  }

  if (zaehler == 4)
  {
    display.println("Wolfsberg");
  }

  if (zaehler == 5)
  {
    display.setTextSize(1);
    display.println("Programmieren");
  }

  if (zaehler == 6)
  {
    zaehler = 1;
  }
  display.display();
}

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
bool schalter = false;
bool schalter_controller = false;

void loop() {
  schalter = digitalRead(5);
  if (schalter == true && schalter_controller == false)
  {
    zaehler++;
    schalter_controller = true;
  }

  if (schalter_controller == true && schalter == false)
  {
    schalter_controller = false;
  }

  if (zaehler == 1)
  {
    display.clearDisplay();
    display.setTextColor(WHITE);
    display.setTextSize(2);
    display.setCursor(5,0);
    display.println("Fabian");
    display.display();
  }

  if (zaehler == 2)
  {
    display.clearDisplay();
    display.setTextColor(WHITE);
    display.setTextSize(2);
    display.setCursor(5,0);
    display.println("Granig");
    display.display();
  }

  if (zaehler == 3)
  {
    display.clearDisplay();
    display.setTextColor(WHITE);
    display.setTextSize(2);
    display.setCursor(5,0);
    display.println("1.12.2004");
    display.display();
  }

  if (zaehler == 4)
  {
    display.clearDisplay();
    display.setTextColor(WHITE);
    display.setTextSize(2);
    display.setCursor(5,0);
    display.println("Wolfsberg");
    display.display();
  }

  if (zaehler == 5)
  {
    display.clearDisplay();
    display.setTextColor(WHITE);
    display.setTextSize(1);
    display.setCursor(5,0);
    display.println("Programmieren");
    display.display();
  }

  if (zaehler == 6)
  {
    zaehler = 1;
  }
  
  Serial.println(zaehler);
}

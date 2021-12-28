void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(4, INPUT);
}

int zaehler = 0;
int zaehler_alt = 0;

void loop() {
  // put your main code here, to run repeatedly:
  bool schalter = digitalRead(4);

  zaehler_alt = zaehler;
  if (schalter == 0)
  {
    zaehler = zaehler + 1;
  }
  
  if (zaehler == zaehler_alt)
  {
    
  }
  else
  {
    Serial.println(zaehler);
  }
  
  while (0 == schalter)
  {
    schalter = digitalRead(4);
  }
}

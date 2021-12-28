void setup() {
  Serial.begin(9600);
  pinMode(3, OUTPUT);
  pinMode(4, OUTPUT);
  pinMode(10, INPUT);
}

bool schalter = false;

void loop() {
  schalter = digitalRead(10);
  
  if (schalter == true)
  {
    digitalWrite(3, LOW); 
    digitalWrite(4, HIGH);
    delay(1000);
    digitalWrite(4, LOW);       
    delay(1000);
  }
  else
  {
    digitalWrite(3, HIGH);
    digitalWrite(4, LOW);
  }
}

void setup() {
  Serial.begin(9600);
  pinMode(13, OUTPUT);
}

int buchstabe = 0;

void loop() {
  if (Serial.available() > 0) {
    buchstabe = Serial.read();
    Serial.println(buchstabe);
    
    if (buchstabe == 97)
    {
      digitalWrite(13, LOW);
    }

    if (buchstabe == 101)
    {
      digitalWrite(13, HIGH<);
    }
  }
}

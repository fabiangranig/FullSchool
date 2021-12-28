void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(5, INPUT);
  pinMode(10, OUTPUT);
  pinMode(11, OUTPUT);
  pinMode(12, OUTPUT);
  pinMode(8, OUTPUT);
  pinMode(9, OUTPUT);

  digitalWrite(8, HIGH);
  digitalWrite(12, HIGH);
}

bool schalter = false;

void loop() {
  // put your main code here, to run repeatedly:
  schalter = digitalRead(5);
  Serial.println(5);

  if (schalter == true)
  {
    delay(500);
    for (int i = 0; i < 6; i++)
    {
      delay(500);
      digitalWrite(12, HIGH);
      delay(500);
      digitalWrite(12, LOW);
    }
    digitalWrite(11, HIGH);
    delay(1000);
    digitalWrite(12, LOW);
    digitalWrite(11, LOW);
    digitalWrite(10, HIGH);
    delay(2000);
    digitalWrite(8, LOW);
    digitalWrite(9, HIGH);
    delay(4000);
    for (int i = 0; i < 6; i++)
    {
      delay(500);
      digitalWrite(9, HIGH);
      delay(500);
      digitalWrite(9, LOW);
    }
    digitalWrite(8, HIGH);
    digitalWrite(9, LOW);
    delay(2000);
    digitalWrite(11, HIGH);
    delay(1000);
    digitalWrite(10, LOW);
    digitalWrite(11, LOW);
    digitalWrite(12, HIGH);
  }
}

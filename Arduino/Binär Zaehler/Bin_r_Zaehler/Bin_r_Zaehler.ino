void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(2, INPUT);
  pinMode(3, OUTPUT);
  pinMode(4, OUTPUT);
  pinMode(5, OUTPUT);
  pinMode(6, OUTPUT);
}

int zaehler = 0;
int zaehler_alt = 0;

int rest = 0;

void loop() {
  // put your main code here, to run repeatedly:
  bool schalter = digitalRead(2);

  zaehler_alt = zaehler;
  if (schalter == 1)
  {
    zaehler = zaehler + 1;
    Serial.println(zaehler);
  }

  if (zaehler > 15)
  {
    zaehler = 0;
  }

  rest = zaehler;
  
  if (zaehler - 8 >= 0)
  {
    digitalWrite(6, HIGH);
    rest = zaehler - 8;
  }

  if (rest - 4 >= 0)
  {
    digitalWrite(5, HIGH);
    rest = rest - 4;
  }

  if (rest - 2 >= 0)
  {
    digitalWrite(4, HIGH);
    rest = rest - 2;
  }

  if (rest - 1 >= 0)
  {
    digitalWrite(3, HIGH);
    rest = rest - 1;
  }
  
  while (1 == schalter)
  {
    schalter = digitalRead(2);
  }

  digitalWrite(3, LOW);
  digitalWrite(4, LOW);
  digitalWrite(5, LOW);
  digitalWrite(6, LOW);
  rest = 0;
}

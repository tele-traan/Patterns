using TemplateMethod;

Human vasya = new Child("Вася");
Human lesha = new Adult("Алексей");
Human innokentiy = new Elder("Иннокентий");

vasya.DoDailyCycle();
lesha.DoDailyCycle();
innokentiy.DoDailyCycle();
using ChainOfResponsibility;

var intern1 = new Intern("Иван Стажёрович");
var intern2 = new Intern("Александр Стажёрович");
var intern3 = new Intern("Руслан Стажёрович");
var intern4 = new Intern("Тимур Стажёрович");

TaskChecker senior = new Senior("Алексей Сеньорович");
TaskChecker middle = new Middle("Игорь Миддлович", senior);
TaskChecker junior = new Junior("Егор Джунович", middle);

TestTask task1 = new("Сверстать лендинг", 5);
TestTask task2 = new("Написать круд", 30);
TestTask task3 = new("Спроектировать архитектуру базы данных", 70);
TestTask task4 = new("Написать логику промышленного контроллера с нуля", 150);

intern1.ApplyForVacancy(task1, junior);
intern2.ApplyForVacancy(task2, junior);
intern3.ApplyForVacancy(task3, junior);
intern4.ApplyForVacancy(task4, junior);
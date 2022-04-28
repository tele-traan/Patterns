namespace Factory
{
    class Program
    {
        static void Main()
        {
            School school75 = new TypicalMbouSosh("31 среднеобразовательная школа города Казани");
            School whiteCrowSchool = new PrivateSchool("Частная школа \"Белая Ворона\"");

            school75.DisplayInfo();
            whiteCrowSchool.DisplayInfo();

            Worker vasya = school75.GraduatePupil();
            vasya.FullName = "Васька Пупкин";

            Worker vasiliy = whiteCrowSchool.GraduatePupil();
            vasiliy.FullName = "Василий Васильевич Пупенко";

            Company kznSoft = new LowSalaryCompany("ООО \"КазаньГорСофт\"");
            Company akBars = new HighSalaryCompany("АК БАРС Софт");

            kznSoft.HireWorker(vasya);
            kznSoft.HireWorker(vasiliy);

            akBars.HireWorker(vasya);
            akBars.HireWorker(vasiliy);
        }
    }
}
PrintHeader();
PrintHeader();
Console.WriteLine("Основная часть программы");
PrintFooter();

void PrintHeader()
{
    Console.WriteLine("^_^");
    Console.WriteLine("Лаб.работа №13");
    Console.WriteLine("0_0");
    Console.WriteLine("Дата формирования отчета: 23.07");
}

void PrintFooter()
{
    Console.WriteLine(">_<");
    Console.WriteLine("  Конец программы");
    Console.WriteLine("X_X");
}

//2
void PrintStudentCard(string name, int age, string num)
{
    Console.WriteLine($"Студент:{name}, возраст:{age}, номер группы: {num}");
}
PrintStudentCard("Егор", 18, "ИС-13");
PrintStudentCard("Валерия", 17, "ИС-34");
//3
double Cal(double b , double n)
{
    return b + b * n / 100;
}
bool ie(double averageGrade)
{
    return averageGrade >= 4.5;
}
double re = 4.7;
if (ie(re))
{
    Console.WriteLine(Cal(2000,15));
}
else
{
    Console.WriteLine(Cal(2000,0));
}
//4
double Col(int[] grades)
{
    int sum = 0;
    foreach (int grade in grades)
    {
        sum += grade;
    }
    return (double)sum / grades.Length;
}
int[] grades = { 4, 5, 3, 5, 4 };
double average = Col(grades);
Console.WriteLine(average);

//самостоятельные
//Б
void PrintPerson(string text, int num)
{
    Console.WriteLine($"{text}, {num}");
}
PrintPerson("елка", 18);
PrintPerson("клен", 18);
//А
void PrintDivider()
{
    Console.WriteLine("Студент: Анна, Возраст: 17");
}
PrintDivider();
//индивидуальные
//3
bool IsPositive(int number)
{
    return number > 0;
}
int m = 6;
if (IsPositive(m))
{
    Console.WriteLine("Положительное");
}
else
{
    Console.WriteLine("Отрицательное");
}
//8
double CelsiusToFahrenheit(double celsius)
{
    return celsius * 9 / 5 + 32;
}
double result = CelsiusToFahrenheit(40);
Console.WriteLine(result);
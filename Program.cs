PrintHeader();
PrintHeader();
Console.WriteLine("Основная часть программы");
PrintFooter();

void PrintHeader()
{
    Console.WriteLine("^_^");
    Console.WriteLine("Лаб.работа №13");
    Console.WriteLine("0_0");
}

void PrintFooter()
{
    Console.WriteLine(">_<");
    Console.WriteLine("  Конец программы");
    Console.WriteLine("X_X");
    Console.WriteLine("Дата формирования отчета: 23.07");
}

//2
void PrintStudentCard(string name, int age, string num)
{
    Console.WriteLine($"Студент:{name}, возраст:{age}, номер группы: {num}");
}
PrintStudentCard("Егор", 18, "13");
PrintStudentCard("Валерия", 17, "34");
//3
double Cal(double b , double n)
{
    return b + b * n / 100;
}
double r = Cal(2000, 15);
Console.WriteLine(r);
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
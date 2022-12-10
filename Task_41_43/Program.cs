Console.WriteLine("Input task");
string n1 = Console.ReadLine();
int n = ProverkaString(n1);
if (n == 1)
    Task41();
if (n == 2)
    Task43();


//Блок функций и методов
int NumbersMoreZero(string[] massive)                               //Функция подсчета количества чисел >0
{
    int NumbersZero = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        int numI = ProverkaString(massive[i]);                      //Проверяем функцией проверки ввода букв не ошибся ли пользователь при вводе
        if (numI > 0)
        {
            NumbersZero = NumbersZero + 1;                          //Считеам количество
        }
    }
    return NumbersZero;
}
int ProverkaString(string Z)                                        //функция проверки ввода букв вместо цифр
{
    bool resultA = int.TryParse(Z, out int F);                      // Проверка на ввод букв
    if (resultA == false)
    {
        Console.WriteLine("You should input only numbers");
        Environment.Exit(0);
    }
    int A = Convert.ToInt32(Z);                                     //Если проверка пройдена, переводим А в число
    return A;
}
void Peresechenie(double B1, double B2, double K1, double K2)       //Метод вычисления точки пересечения
{
    if (K1 == K2 && B1 == B2)
        Console.WriteLine("Odinnakovie pryamie");
    else
    if (K1 == K2)
        Console.WriteLine("U pryamih net tochek peresecheniya");
    else
    {
        double X = (B2 - B1) / (K1 - K2);
        double Y = (K1 * (B2 - B1)) / (K1 - K2) + B1;
        Console.WriteLine("Tochka peresecheniya: (" + X + ", " + Y + ")");
    }
}

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// Вводим сразу все числа в одну линию, не через бесконечное кол-во ReadLine.
void Task41()
{
    Console.WriteLine("Input some numbers with commas");
    string[] massive = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries);            //ВВодим числа через запятую и создаем массив удаляя все запятые
    Console.WriteLine("Numbers greater than zero: " + NumbersMoreZero(massive));                        //Выводим количество чисел больше нуля
}

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// Точки для уравнений пользователь вводит с клавиатуры, можно через несколько ReadLine
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
void Task43()
{
    Console.Write("Input b1: ");
    string B11 = (Console.ReadLine());              //Вводим координаты
    double B1 = ProverkaString(B11);
    Console.Write("Input b2: ");
    string B21 = (Console.ReadLine());
    double B2 = ProverkaString(B21);
    Console.Write("Input k1: ");
    string K11 = (Console.ReadLine());
    double K1 = ProverkaString(K11);
    Console.Write("Input k2: ");
    string K21 = (Console.ReadLine());
    double K2 = ProverkaString(K21);
    Peresechenie(B1, B2, K1, K2);                   //Выводим результаты
}


Console.WriteLine("Консольный калькулятор на C#\r");
Console.WriteLine("____________________________\n");
string nachalo = "0";

while (nachalo != "9")
{
    Console.WriteLine("Выберите действие:\n1 - сложить 2 числа,\n2 - вычесть первое из второго,\n3 - перемножить два числа,\n4 - разделить первое на второе,\n5 - возвести в степень N первое число,\n6 - найти квадратный корень из числа,\n7 - найти 1 процент от числа,\n8 - найти факториал из числа,\n9 - выйти из программы");
    string action = Console.ReadLine();

    if (action == "1")
    {
        Console.Write("Введите первое число : ");
        string first = Console.ReadLine();
        Console.Write("Введите второе число : ");
        string second = Console.ReadLine();

        float firstnum = Convert.ToSingle(first);
        float secondnum = Convert.ToSingle(second);

        Console.WriteLine(firstnum + secondnum);
        Console.Write("Если вы хотите остановить работу программы напишите 9 : ");
        nachalo = Console.ReadLine();
    }
    if (action == "2")
    {
        Console.Write("Введите первое число : ");
        string first = Console.ReadLine();
        Console.Write("Введите второе число : ");
        string second = Console.ReadLine();

        float firstnum = Convert.ToSingle(first);
        float secondnum = Convert.ToSingle(second);

        Console.WriteLine(secondnum - firstnum);
        Console.Write("Если вы хотите остановить работу программы напишите 9 : ");
        nachalo = Console.ReadLine();
    }
    if (action == "3")
    {
        Console.Write("Введите первое число : ");
        string first = Console.ReadLine();
        Console.Write("Введите второе число : ");
        string second = Console.ReadLine();

        float firstnum = Convert.ToSingle(first);
        float secondnum = Convert.ToSingle(second);

        Console.WriteLine(firstnum * secondnum);
        Console.Write("Если вы хотите остановить работу программы напишите 9 : ");
        nachalo = Console.ReadLine();
    }
    if (action == "4")
    {
        Console.Write("Введите первое число : ");
        string first_number_string = Console.ReadLine();
        Console.Write("Введите второе число : ");
        string second_number_string = Console.ReadLine();

        float first_number = Convert.ToSingle(first_number_string);
        float second_number = Convert.ToSingle(second_number_string);

        Console.WriteLine(first_number / second_number);
    }
    if (action == "5")
    {
        Console.Write("Введите первое число : ");
        string first = Console.ReadLine();
        Console.Write("Введите второе число : ");
        string second = Console.ReadLine();

        float firstnum = Convert.ToSingle(first);
        float secondnum = Convert.ToSingle(second);

        float N = firstnum;
        for (int i = 0; i < secondnum - 1; i++)
        {
            firstnum *= N;
        }
        Console.WriteLine(firstnum);
        Console.Write("Если вы хотите остановить работу программы напишите 9 : ");
        nachalo = Console.ReadLine();
    }
    if (action == "6")
    {
        Console.Write("Введите число : ");
        string first = Console.ReadLine();
        float firstnum = Convert.ToSingle(first);

        Console.WriteLine(Math.Sqrt(firstnum));

        Console.Write("Если вы хотите остановить работу программы напишите 9 : ");
        nachalo = Console.ReadLine();
    }
    if (action == "7")
    {
        Console.Write("Введите число : ");
        string first = Console.ReadLine();
        float firstnum = Convert.ToSingle(first);

        Console.WriteLine(firstnum * 0.01);

        Console.Write("Если вы хотите остановить работу программы напишите 9 : ");
        nachalo = Console.ReadLine();
    }
    if (action == "8")
    {
        Console.Write("Введите число : ");
        string first = Console.ReadLine();
        int firstnum = Convert.ToInt32(first);

        int N = 1;

        for (int i = 1; i < firstnum + 1; i++)
        {
            N = i * N;
        }
        Console.WriteLine(N);

        Console.Write("Если вы хотите остановить работу программы напишите 9 : ");
        nachalo = Console.ReadLine();
    }
    if (action != "1" && action != "2" && action != "3" && action != "4" && action != "5" && action != "6%" && action != "7" && action != "8")
    {
        Console.Write("Такого действия нет, повторите попытку или введите цифру 9 , чтобы закончить : ");
        nachalo = Console.ReadLine();
    }
}
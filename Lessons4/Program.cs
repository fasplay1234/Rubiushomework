// №1

// using System;

// class Fraction
// {
//     private int numerator; // числитель
//     private int denominator; // знаменатель

//     public Fraction(int numerator, int denominator)
//     {
//         this.numerator = numerator;
//         this.denominator = denominator;
//     }

//     public int Numerator
//     {
//         get { return numerator; }
//         set { numerator = value; }
//     }
//     public int Denominator
//     {
//         get { return denominator; }
//         set { denominator = value; }
//     }

//     public override string ToString()
//     {
//         return $"{numerator}/{denominator}";
//     }

//     public static Fraction operator +(Fraction a, Fraction b)
//     {
//         int num = a.numerator * b.denominator + b.numerator * a.denominator;
//         int den = a.denominator * b.denominator;

//         return new Fraction(num, den);
//     }
//    public static Fraction operator -(Fraction a, Fraction b)
//     {
//         int num = a.numerator * b.denominator - b.numerator * a.denominator;
//         int den = a.denominator * b.denominator;

//         return new Fraction(num, den);
//     }
//     public static Fraction operator *(Fraction a, Fraction b)
//     {
//         int num = a.numerator * b.numerator;
//         int den = a.denominator * b.denominator;

//         return new Fraction(num, den);
//     }
//     public static Fraction operator /(Fraction a, Fraction b)
//     {
//         int num = a.numerator * b.denominator;
//         int den = a.denominator * b.numerator;

//         return new Fraction(num, den);
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Введите числитель первой дроби:");
//         int numerator1 = int.Parse(Console.ReadLine());

//         Console.WriteLine("Введите знаменатель первой дроби:");
//         int denominator1 = int.Parse(Console.ReadLine());

//         Console.WriteLine("Введите числитель второй дроби:");
//         int numerator2 = int.Parse(Console.ReadLine());

//         Console.WriteLine("Введите знаменатель второй дроби:");
//         int denominator2 = int.Parse(Console.ReadLine());

//         Fraction f1 = new Fraction(numerator1, denominator1);
//         Fraction f2 = new Fraction(numerator2, denominator2);

//         Console.WriteLine("Сумма: " + (f1 + f2));
//         Console.WriteLine("Разность: " + (f1 - f2));
//         Console.WriteLine("Умножение: " + (f1 * f2));
//         Console.WriteLine("Деление: " + (f1 / f2));
//     }
// }


// №2
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Выберите тип транспорта:");
        Console.WriteLine("1) Водный");
        Console.WriteLine("2) Воздушный");
        Console.WriteLine("3) Наземный");

        int typeIndex = int.Parse(Console.ReadLine());

        if (typeIndex == 1)
        {
            Console.WriteLine("Вы выбрали: Водный транспорт.");
            Console.WriteLine("Доступные подтипы водного транспорта:");
            Console.WriteLine("1) Яхта");
            Console.WriteLine("2) Лодка");
            Console.WriteLine("Введите номер подтипа транспорта (1-2): ");

            int subTypeIndex = int.Parse(Console.ReadLine());
            if (subTypeIndex == 1)
                Console.WriteLine($"Отличный выбор! Вы передвигаетесь на: {subTypeIndex} - Яхта, тип транспорта: {typeIndex} - Водный.");
            else if (subTypeIndex == 2)
                Console.WriteLine($"Отличный выбор! Вы передвигаетесь на: {subTypeIndex} - Лодка, тип транспорта: {typeIndex} - Водный.");
        }
        else if (typeIndex == 2)
        {
            Console.WriteLine("Вы выбрали: Воздушный транспорт.");
            Console.WriteLine("Доступные подтипы воздушного транспорта:");
            Console.WriteLine("1) Вертолёт");
            Console.WriteLine("2) Самолёт");
            Console.WriteLine("Введите номер подтипа транспорта (1-2): ");

            int airSubTypeIndex = int.Parse(Console.ReadLine());
            if (airSubTypeIndex == 1)
                Console.WriteLine($"Отличный выбор! Вы передвигаетесь на: {airSubTypeIndex} - Вертолёт, тип транспорта: {typeIndex} - Воздушный.");
            else
                Console.WriteLine($"Отличный выбор! Вы передвигаетесь на: {airSubTypeIndex} - Самолёт, тип транспорта: {typeIndex} - Воздушный.");
        }
        else
        {
            Console.WriteLine("Вы выбрали: Наземный транспорт.");
            Console.WriteLine("Доступные подтипы наземного транспорта:");
            Console.WriteLine("1) Автомобиль");
            Console.WriteLine("2) Велосипед");
            Console.WriteLine("Введите номер подтипа транспорта (1-2): ");

            int groundSubTypeIndex = int.Parse(Console.ReadLine());
            if (groundSubTypeIndex == 1)
                Console.WriteLine($"Отличный выбор! Вы передвигаетесь на: {groundSubTypeIndex} - Автомобиль, тип транспорта: {typeIndex} - Наземный.");
            else
                Console.WriteLine($"Отличный выбор! Вы передвигаетесь на: {groundSubTypeIndex} - Велосипед, тип транспорта: {typeIndex} - Наземный.");
        }
    }
}

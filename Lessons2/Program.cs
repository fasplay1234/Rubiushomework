// Условные операторы
Console.Write("Введите номер года: ");
int y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{y}");
if ((y % 4 == 0) & (y<=30000) || (y % 4 == 0 && y % 100 != 0) & (y % 400 == 0)) {
    Console.WriteLine("YES");
} else {
    Console.WriteLine("NO");
}

// Циклы
Console.Write("Введите количество различных расходов: ");
int count = int.Parse(Console.ReadLine());
decimal totalExpenses = 0;
for (int i = 1; i <= count; i++) {
    Console.Write($"Введите сумму расхода #{i}: ");
    decimal expense = decimal.Parse(Console.ReadLine());
    totalExpenses += expense;
}
Console.WriteLine($"Общая сумма расходов за месяц: {totalExpenses}");
// №1 Методы и функции
using System;
// class Program {
//     static void Main()
//         {
//             Console.Write("Введите сумму дохода: ");
//             decimal income = decimal.Parse(Console.ReadLine());
//             decimal taxes = CalculateTax(income);
//             Console.WriteLine($"Сумма налогов к уплате: {taxes:F2} рублей.");
//         }

//     static decimal CalculateTax(decimal income)
//         {
//             decimal taxRate = 0.13m;
//             decimal taxes = income * taxRate;
//             return Math.Round(taxes, 2);
//         }
// }

// №2 Массивы и коллекции
class Program
{
    static void Main()
    {
        Dictionary<string, int> inventory = new Dictionary<string, int>();
        bool running = true;

        while (running)
        {
            Console.WriteLine("МЕНЮ:");
            Console.WriteLine("1. Добавить товар");
            Console.WriteLine("2. Просмотреть все товары");
            Console.WriteLine("3. Удалить товар");
            Console.WriteLine("4. Найти товар");
            Console.WriteLine("5. Выйти");
            Console.Write("Введите номер действия: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddProduct(inventory);
                    break;
                case "2":
                    ViewProducts(inventory);
                    break;
                case "3":
                    RemoveProduct(inventory);
                    break;
                case "4":
                    FindProduct(inventory);
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Неправильный ввод, попробуйте еще раз.");
                    break;
            }
        }
    }
    static void AddProduct(Dictionary<string, int> inventory)
    {
        Console.Write("Введите название товара: ");
        string productName = Console.ReadLine();
        Console.Write("Введите количество: ");
        if (int.TryParse(Console.ReadLine(), out int quantity))
        {
            if (inventory.ContainsKey(productName))
            {
                inventory[productName] += quantity;
            }
            else
            {
                inventory[productName] = quantity;
            }
            Console.WriteLine($"Товар '{productName}' успешно добавлен/обновлен.");
        }
        else
        {
            Console.WriteLine("Неправильный ввод количества.");
        }
    }

    static void ViewProducts(Dictionary<string, int> inventory)
    {
        Console.WriteLine("Все товары:");
        foreach (var item in inventory)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }

    static void RemoveProduct(Dictionary<string, int> inventory)
    {
        Console.Write("Введите название товара для удаления: ");
        string productName = Console.ReadLine();

        if (inventory.Remove(productName))
        {
            Console.WriteLine($"Товар '{productName}' успешно удален.");
        }
        else
        {
            Console.WriteLine($"Товар '{productName}' не найден.");
        }
    }

    static void FindProduct(Dictionary<string, int> inventory)
    {
        Console.Write("Введите название товара для поиска: ");
        string productName = Console.ReadLine();

        if (inventory.TryGetValue(productName, out int quantity))
        {
            Console.WriteLine($"{productName}: {quantity}");
        }
        else
        {
            Console.WriteLine($"Товар '{productName}' не найден.");
        }
    }
}

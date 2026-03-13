using Practice8;
using System;

class Program
{
    static void Main()
    {
        LabList sample = new LabList();

        do
        {
            Console.WriteLine("1 - Добавить элемент в конец");
            Console.WriteLine("2 - Добавить элемент по индексу");
            Console.WriteLine("3 - Изменить элемент по индексу");
            Console.WriteLine("4 - Удалить последний элемент");
            Console.WriteLine("5 - Удалить элемент по индексу");
            Console.WriteLine("6 - Получить количество элементов");
            Console.WriteLine("7 - Вывести список");
            Console.WriteLine("8 - Вывести элемент по индексу");
            Console.WriteLine("9 - Выход");

            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Введите Id");
                        int Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите Тип");
                        string type = Console.ReadLine();
                        Console.WriteLine("Введите Дату");
                        string date = Console.ReadLine();
                        Console.WriteLine("Введите Статус");
                        string status = Console.ReadLine();
                        Console.WriteLine("Введите Результат");
                        string result = Console.ReadLine();
                        sample.Add(Id, type, date, status, result);
                        break;
                    case 2:
                        Console.WriteLine("Введите индекс куда вставляете новый элемент");
                        int index = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите Id");
                        int Id2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите Тип");
                        string type2 = Console.ReadLine();
                        Console.WriteLine("Введите Дату");
                        string date2 = Console.ReadLine();
                        Console.WriteLine("Введите Статус");
                        string status2 = Console.ReadLine();
                        Console.WriteLine("Введите Результат");
                        string result2 = Console.ReadLine();
                        sample.IndAdd(index, Id2, type2, date2, status2, result2);
                        break;
                    case 3:
                        Console.WriteLine("Введите индекс изменяемого элемента");
                        int index2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите Id");
                        int Id3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите Тип");
                        string type3 = Console.ReadLine();
                        Console.WriteLine("Введите Дату");
                        string date3 = Console.ReadLine();
                        Console.WriteLine("Введите Статус");
                        string status3 = Console.ReadLine();
                        Console.WriteLine("Введите Результат");
                        string result3 = Console.ReadLine();
                        sample.IndChange(index2, Id3, type3, date3, status3, result3);
                        break;
                    case 4:
                        sample.RemoveLast();
                        break;
                    case 5:
                        Console.WriteLine("Введите индекс элемента который хотите удалить");
                        int index3 = Convert.ToInt32(Console.ReadLine());
                        sample.IndDelete(index3);
                        break;
                    case 6:
                        int count = sample.ElemCounts();
                        Console.WriteLine($"Количество элементов {count}");
                        break;
                    case 7:
                        sample.ShowAll();
                        break;
                    case 8:
                        Console.WriteLine("Введите индекс элемента который хотите увидеть");
                        int index4 = Convert.ToInt32(Console.ReadLine());
                        sample.IndShow(index4);
                        break;
                    case 9:
                        sample.Exit();
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Вы ничего не выбрали");
            }
        }
        while (true);
    }
}

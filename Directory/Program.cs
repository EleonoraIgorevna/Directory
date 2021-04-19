
using System;

namespace Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            (string name, int age)[] users;
            Console.WriteLine("Введите количество пользователей в справочнике.");
            int count = Convert.ToInt32(Console.ReadLine());
            users = new (string name, int age)[count];

            for (int i = 0; i < users.Length; i++)
            {
                Console.Write("Введите ФИО  пользователя через пробел: ");
                string userName = Console.ReadLine();
                Console.Write("Введите ввозраст  пользователя. ");
                int userAge = Convert.ToInt32(Console.ReadLine());
                users[i] = (userName, userAge);
                Console.WriteLine($"Пользователь {userName} ({userAge} лет ) сохранен. ") ; 

            }

            Console.WriteLine("Ввод данных запрещен, нажмите любую клавишу.");
            Console.ReadKey();
            Console.Clear();

            int choice;

            do
            {
                Console.Write("0 -   Завершение меню.");
                Console.Write("1 -   Просмотр всей базы данных.");
                Console.Write("2 -   Просмотр пользователей.");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
   
                {
                    Console.WriteLine("Вывод баззы данных.");
                    for (int i = 0; i < users.Length; i++)
                        Console.WriteLine($"Пользователь {users[i].name}  ({users[i].age}). ");

                }
                if (choice == 2)
                {
                    int userIndex;
                    do
                    {
                        Console.WriteLine($"Введите индентификатор пользователя от 0 до {users.Length - 1}");
                        int userIndex = Convert.ToInt32(Console.ReadLine());
                    } while (userIndex < 0 || userIndex >= users.Length);

                





                }
            }

            while (choice != 0);



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace HM_Thread
{
    class User
    {
        private int Id;
        private string Name;
        public User(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }
    internal class Program
    {
        static int sec = 0;
        static void Main(string[] args)
        {
            //Task1
            //List<User> list = new List<User>
            //{
            //    new User(1, "Bob"),
            //    new User(2, "Alex"),
            //    new User(3, "Mark"),
            //    new User(4, "Jhon"),
            //    new User(5, "Kebob"),
            //};
            //Thread thread = new Thread(() => { ShowUsers(list); });
            //thread.Start();

            //Task2
            //Console.WriteLine("Игра \"Успел, не успел\"");
            //Console.WriteLine("Нажмите любую клавишу, когда увидите случайный символ:");
            //bool ready = false;
            //char randomChar = (char)34;
            //ConsoleKeyInfo yourChar;

            //Thread generateKeyThread = new Thread(() =>
            //{
            //    Random random = new Random();
            //    randomChar = (char)random.Next(97, 122);
            //    ready = true;

            //    Console.WriteLine($"Введите символ: {randomChar}");
            //});
            //Thread timeThread = new Thread(() =>
            //{
            //    DateTime start = DateTime.Now;
            //    DateTime end;
            //    while (ready)
            //    {
            //        yourChar = Console.ReadKey();
            //        if (yourChar.KeyChar.Equals(randomChar))
            //        {
            //            end = DateTime.Now;
            //            ready = false;
            //            Console.WriteLine($"\nПравильно! Времени потрачено: {(end - start)}");
            //            break;
            //        }
            //        Console.WriteLine("\nНепрвильно! Повторите ввод");
            //    }
            //});
            //generateKeyThread.Start();
            //timeThread.Start();

            //Task3
            
            using (var timer = new System.Threading.Timer(PrintTime, null, 0, 1000))
            {
                Thread.Sleep(20000);
            }        
        }

        private static void PrintTime(object state)
        {
            sec++;
            if (sec <= 3)
            {
                Console.WriteLine($"Первые 10 секунд, ждем: {sec} секунда");
            }
            else if (sec <= 10)
            {
                Console.WriteLine($"Первые 10 секунд, каждую секунду: {sec} секунда");
            }
            else if (sec <= 20)
            {
                if (sec % 2 == 0)
                {
                    Console.WriteLine($"Вторые 10 секунд, каждые 2 секунды: {sec} секунда");
                }
            }
        }

        private static void ShowUsers(List<User> users)
        {
            foreach (var item in users)
            {
                Console.WriteLine(item);
            }
        }
    }
}

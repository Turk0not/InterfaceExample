using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager()
            };

            foreach (var eat in eats)
            {
                eat.Eat();
            }

            Console.ReadLine();
        }

        interface IWorker
        {
            void Work();
        }

        interface IEat
        {
            void Eat();
        }

        interface ISalary
        {
            void GetSalary();
        }
        class Manager : IWorker, IEat, ISalary
        {
            public void Eat()
            {
                Console.WriteLine("Şuan Yöneticiler Yemek Yiyor");
            }

            public void GetSalary()
            {
                Console.WriteLine("Şuan Yöneticiler Maaş Alıyor");
            }

            public void Work()
            {
                Console.WriteLine("Şuan Yöneticiler Çalışıyor");
            }
        }

        class Worker : IWorker, IEat, ISalary
        {
            public void Eat()
            {
                Console.WriteLine("Şuan Çalışanlar Yemek Yiyor");
            }

            public void GetSalary()
            {
                Console.WriteLine("Şuan Çalışanlar Maaş Alıyor");
            }

            public void Work()
            {
                Console.WriteLine("Şuan Çalışanlar Çalışıyor");
            }
        }

        class Robot : IWorker
        {
            public void Work()
            {
                Console.WriteLine("Şuan Robotlar Çalışıyor");
            }
        }
    }
}

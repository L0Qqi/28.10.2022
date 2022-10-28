using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тумаков
{
    public enum BankCurrent
    {
        дебетовый,
        депозитный,
        кредитный

    }
    class Bank
    {

        private int id;
        private int balance;
        private BankCurrent name;

        public void Name()
        {
            Console.WriteLine("Выберите какой счет вы бы хотели открыть : " + '\n' + "1) дебетовый" + '\n' + "2) депозитный " + '\n' + "3) кредитный");
            string name1 = Console.ReadLine();
            if (name1 == "дебетовый")
            {
                Console.WriteLine("Вам одобрен " + BankCurrent.дебетовый + " счёт");
            }
            else if (name1 == "епозитный")
            {
                Console.WriteLine("Вам одобрен " + BankCurrent.депозитный + " счёт");
            }
            else if (name1 == "кредитный")
            {
                Console.WriteLine("Вам одобрен " + BankCurrent.кредитный + " счёт");
            }
            else
            {
                Console.WriteLine("Вам не одобрили заявку, так как были введены неверне данные");
            }
        }

        public void ID()
        {
            Console.WriteLine("Введите ID  своего будущего счета : ");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Вашему счету присвоен уникальный ID : " + id);
        }
        Random random = new Random();
        private static int Id1;
        public void PrintID()
        {
            Id1 = random.Next();
            Id1++;
            Console.WriteLine("Вам присвоен уникальный рандомный ID : " + Id1);
        }
        public void Balance()
        {
            Console.WriteLine("Выберите пункт меню: " + '\n' + "1) Узнать баланс" + '\n' + "2) Пополнить баланс");
            string operation = Console.ReadLine();
            if (operation == "Узнать баланс" || operation == "узнать баланс" || operation == "УЗНАТЬ БАЛАНС")
            {
                Console.WriteLine("Ваш баланс : " + balance);

            }

            if (operation == "Пополнить баланс" || operation == "пополнить баланс" || operation == "ПОПОЛНИТЬ БЛАНАС")
            {
                Console.WriteLine("Введите сумму ,которую хотели бы внести на счет");
                int summ = int.Parse(Console.ReadLine());
                balance = summ;
                Console.WriteLine("Вы внесли " + summ + " на счет");
            }


        }





        public void Withdraw()
        {
            Console.WriteLine("Снимите со счета желаемую сумму" + '\n' + "Какую сумму необходимо снять?");
            int summ = int.Parse(Console.ReadLine());
            if (balance < summ)
            {
                Console.WriteLine("Недостаточно средств на счете");
                Balance();

            }
            else
            {
                Console.WriteLine("После снятия средств на балансе осталось : " + (balance - summ));
            }

        }
    }


    class Build
    {
        private int height;
        private int floor;
        private int flat;
        private int entrance;
        public Build(int height, int floor, int flat, int entrance)
        {
            this.height = height;
            this.floor = floor;
            this.flat = flat;
            this.entrance = entrance;
        }
        private static int number;
        public void Number()
        {
            Random rnd = new Random();
            number = rnd.Next();
            number++;
            Console.WriteLine("Уникальный номер дома :" + number);
        }
        public void HeightFloor()
        {
            Console.WriteLine("Высота одного этажа равна :" + height / floor);
        }
        public void Flat1_Count()
        {
            Console.WriteLine("Количество квартир в подъезде : " + flat / entrance);
        }
        public void Flat2_Count()
        {
            Console.WriteLine("Количество квартир на этаже : " + flat / floor);
        }



    }
    internal class Program
    {

        static void Main(string[] args)
        {
            

            Console.WriteLine("Тумаков.Задача 7.3");
            Bank bank2 = new Bank();
            bank2.Name();
            bank2.PrintID();
            bank2.Balance();
            bank2.Withdraw();


            Console.WriteLine("Тумаков.Задача 7.4");
            Console.WriteLine("Введите высоту, этажность, количество квартир , количество подъездов");
            int height = int.Parse(Console.ReadLine());
            int floor = int.Parse(Console.ReadLine());
            int flats = int.Parse(Console.ReadLine());
            int entrances = int.Parse(Console.ReadLine());
            Build build = new Build(height, floor, flats, entrances);
            build.HeightFloor();
            build.Flat1_Count();
            build.Flat2_Count();













        }

    }
}

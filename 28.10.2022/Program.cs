using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _28._10._2022
{
    abstract class Objects
    {
        private string name;

        public void Getname(string name)
        {
            this.name = name;
        }
    }

    class Vase : Objects
    {
        public Vase(string name)
        {
            base.Getname(name);
            Console.WriteLine("Имя объекта: " + name);
        }
        string info = "Ваза — в истории материальной культуры ваза — традиционная форма ёмкости для жидкостей: воды, вина, масла.";
        
        public Vase(int num)
        {
            Console.WriteLine(info); 
        }

        private int vase_cnt;
        private int franch;
        private int rim;
        private int italian;

        public int Vase_cnt
        {
            get { return vase_cnt; }    
            set { vase_cnt = value; }
        }
        public int Franch
        {
            get { return franch; }
            set { franch = value; }
        }
        public int Rim
        {
            get { return rim; }
            set { rim = value; }
        }
        public int Italian
        {
            get { return italian; }
            set { italian = value; }
        }
        public void Is_Franch()
        {
            Console.WriteLine($"Французских ваз: {franch}");
        }
        public void Is_Rim()
        {
            Console.WriteLine($"Римских ваз: {rim}");
        }
        public void Is_Italian()
        {
            Console.WriteLine($"Итальянских ваз: {italian}");
        }

        public void Place()
        {
            Console.WriteLine($"В распоряжении музея {vase_cnt} вазы") ;
            Console.WriteLine("Сколько ваз вы хотите выставить на показ");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine($"На высавке {vase_cnt} вазы, остальные {vase_cnt-count} ваз на складе");
        }
        public void Broken()
        {
            Console.WriteLine("Цена одной вазы - 5000$");
            Console.WriteLine("Сколько ваз разбили посетители?");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine($"{count * 50000}$ вы потеряли из-за дебилов");
        }
    }
    class Pictures : Objects
    {
        public Pictures(string name)
        {
            base.Getname(name);
            Console.WriteLine("Имя объекта: " + name);
        }
        string info = "Картина  — произведение изобразительного искусства «относительно ограниченное от окружающей среды и предполагающее сосредоточенное, длительное восприятие с одной фиксированной точки зрения»";

        public Pictures(int num)
        {
            Console.WriteLine(info);
        }

        private int picturies_cnt;
        private int shishkin;
        private int aivazovkiy;
        private int serov;

        public int Picturies_cnt
        {
            get { return picturies_cnt; }
            set { picturies_cnt = value; }
        }
        public int Shishkin
        {
            get { return shishkin; }
            set { shishkin = value; }
        }
        public int Aivazovkiy
        {
            get { return aivazovkiy; }
            set { aivazovkiy = value; }
        }
        public int Serov
        {
            get { return serov; }
            set { serov = value; }
        }
        public void From_Shishkin()
        {
            Console.WriteLine($"Картин Шишкина: {shishkin}");
        }
        public void From_Aivazovkiy()
        {
            Console.WriteLine($"Картин Айвазовского: {aivazovkiy}");
        }
        public void From_Serov()
        {
            Console.WriteLine($"Картин Серова: {serov}");
        }
        public void Galleries()
        {
            Console.WriteLine($"В распоряжении музея {picturies_cnt} картин");
            Console.WriteLine("Сколько картинных залов на вашей выставке?");
            int count = int.Parse(Console.ReadLine());
            if (picturies_cnt%count == 0)
            {
                Console.WriteLine($"В каждом картинном зале {picturies_cnt/count} картин");
            }
            else
            {
                Console.WriteLine($"В каждом картинном зале {picturies_cnt / count} картин, остальные {picturies_cnt%count} картин на складе");
            }
        }
        public void Restavration()
        {
            Console.WriteLine("Сколько картин требуется отреставрировать?");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("Цена($) реставрации одной картины?");
            int cost = int.Parse(Console.ReadLine());
            Console.WriteLine($"{count * cost}$ необходимо потратить на реставрацию");
        }

    }

    class Car
    {
        private string brand;
        private string model;
        private string classs;
        private int speed;
        
        
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Classs
        {
            get { return classs; }
            set { classs = value; }
        }
        
        public void Print()
        {
            Console.WriteLine($"Бренд: {brand} | Модель: {model}");
            Console.WriteLine($"Класс машины: {classs}");
            Console.WriteLine($"Скорость в л. с.: {speed}");
        }
        public void Horse()
        {
            Console.WriteLine($"{brand} {model} имеет {speed} л. с.");
        }
        public void View()
        {
            Console.WriteLine($"{brand} {model} - {classs}");
        }

        public void Price()
        {
            Console.WriteLine("Сколько стоит машина?($)");
            int money = int.Parse(Console.ReadLine());
            if (money <= 16000)
            {
                Console.WriteLine($"{brand} {model} относится к обычному классу машин");
            }
            if (money > 16000 && money <= 45000)
            {
                Console.WriteLine($"{brand} {model} относится к классу бизнес");
            }
            if (money > 45000)
            {
                Console.WriteLine($"{brand} {model} относится к премиум классу машин");
            }
        }
        public void Condition()
        {
            Console.WriteLine("Оцените состояние машины: ");
            Console.WriteLine("1 - ведро | 2 - нормальное | 3 - идеальное");
            int a = int.Parse(Console.ReadLine());
            if (a == 1)
            {
                Console.WriteLine($"{brand} {model} не понравится посетителям выставки");
            }
            if (a == 2)
            {
                Console.WriteLine($"Посетители выставки не обратят внимание на {brand} {model}");
            }
            if (a == 3)
            {
                Console.WriteLine($"Посетителям понравится {brand} {model}");
            }
        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Vase vase = new Vase("Вазы");
            Vase vase1 = new Vase(1);
            Console.WriteLine("Введите количество ваз в распоряжении музея: ");
            int vase_cnt = int.Parse(Console.ReadLine());
            vase.Vase_cnt = vase_cnt;

            Random rand1 = new Random();
            int count1 = rand1.Next(0, vase_cnt);
            vase.Franch = count1;
            vase.Is_Franch();
            Thread.Sleep(500);

            Random rand2 = new Random();
            int count2 = rand2.Next(0, vase_cnt);
            vase.Rim = count2;
            vase.Is_Rim();
            Thread.Sleep(500);

            Random rand3 = new Random();
            int count3 = rand3.Next(0, vase_cnt);
            vase.Italian = count3;
            vase.Is_Italian();

            vase.Place();
            vase.Broken();

            Pictures picturies = new Pictures("Картины");
            Pictures picturies1 = new Pictures(2);
            Console.WriteLine("Введите количество картин в распоряжении музея: ");
            int picturies_cnt = int.Parse(Console.ReadLine());
            picturies.Picturies_cnt = picturies_cnt;

            Random rand4 = new Random();
            int count4 = rand4.Next(0, picturies_cnt);
            picturies.Shishkin = count4;
            picturies.From_Shishkin();
            Thread.Sleep(500);

            Random rand5 = new Random();
            int count5 = rand5.Next(0, picturies_cnt);
            picturies.Aivazovkiy = count5;
            picturies.From_Aivazovkiy();
            Thread.Sleep(500);

            Random rand6 = new Random();
            int count6 = rand6.Next(0, picturies_cnt);
            picturies.Serov = count6;
            picturies.From_Serov();

            picturies.Galleries();
            picturies.Restavration();


            Car car = new Car();

            Console.WriteLine("Введите марку и модель машины");
            string way = @"C:\Users\loqi\Downloads\28.10program.txt";

            using (StreamWriter writer = new StreamWriter(way))
            {
                writer.WriteLine(Console.ReadLine());
                writer.WriteLine(Console.ReadLine());
            }

            string way1 = @"C:\Users\loqi\Downloads\28.10program.txt";

            using (StreamReader reader = new StreamReader(way1))
            {
                car.Brand = reader.ReadLine();
                car.Model = reader.ReadLine();
            }
            car.Classs = "Седан";
            car.Speed = 145;
            car.Print();
            car.Horse();
            car.View();
            car.Price();
            car.Condition();
        }

    }
}

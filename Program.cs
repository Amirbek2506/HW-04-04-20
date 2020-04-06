using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyprojecsApp
{

    class Program
    {
        static void Main(string[] args)
        {/*
                                            //Задача 1
             Console.WriteLine("Теперь запишите сумму:");
           int SUM = int.Parse(Console.ReadLine());
           Converter ExchangeRates=new Converter(10.2183,11.0174,0.1316);
           Console.WriteLine($"\t\tКурс валют на сегодня: \n\t\t1 USD = {10.2183} TJS\n\t\t1 EUR = {11.0174} TJS \n\t\t1 RUB = {0.1316} TJS");
           Console.WriteLine("\nПожалуйста, выберите тип конвертации:");
           Console.WriteLine("Для конвертация сомони в доллар нажмите - 1");
           Console.WriteLine("Для конвертация сомони в евро нажмите - 2");
           Console.WriteLine("Для конвертация сомони в рубл нажмите - 3");
           Console.WriteLine("Для конвертация доллар в сомони нажмите - 4");
           Console.WriteLine("Для конвертация евро в сомони нажмите - 5");
           Console.WriteLine("Для конвертация рубл в сомони нажмите - 6");
           int Choice = int.Parse(Console.ReadLine());
           switch(Choice)
           {
               case 1:
                   Console.WriteLine($"{SUM} сомони = {ExchangeRates.SomToUsd(SUM)} доллар");
                   break;
               case 2:
                   Console.WriteLine($"{SUM} сомони = {ExchangeRates.SomToEur(SUM)} евро");
                   break;
               case 3:
                   Console.WriteLine($"{SUM} сомони = {ExchangeRates.SomToRub(SUM)} рубл");
                   break;
               case 4:
                   Console.WriteLine($"{SUM} доллар = {ExchangeRates.UsdToSom(SUM)} сомони");
                   break;
               case 5:
                   Console.WriteLine($"{SUM} евро ={ExchangeRates.EurToSom(SUM)} сомони");
                   break;
               case 6:
                   Console.WriteLine($"{SUM} рубл = {ExchangeRates.RubToSom(SUM)} сомони");
                   break;
               default:
                   Console.WriteLine("Неправильная команда. Пожалуйста, попробуйте еще раз");
                   break;
           }
            Console.ReadKey();
                                            //Задача 2
            Employee employee = new Employee();
            employee.ShowListOfExperience();
            System.Console.Write("Введите имя: ");
            employee.Name = Console.ReadLine();
            System.Console.Write("Введите фамиля: ");
            employee.LastName = Console.ReadLine();
            System.Console.Write("Введите профессию: ");
            employee.position = Console.ReadLine();
            System.Console.Write("Введите стаж: ");
            employee.experience = int.Parse(Console.ReadLine());
            employee.GetInfo();
            employee.ShowoSalary();
            Console.WriteLine($"Зарплата с учетом стажа работы = " + employee.PlusExperience());
            employee.ShowTax();
            Console.ReadKey();
        */
        }
    }
     public class Converter 
    {
        private double USD{ get; set;}
        private double EUR {get; set;}
        private double RUB {get; set;}
        public Converter(double usd, double eur, double rub)
        {
            this.USD = usd;
            this.EUR = eur;
            this.RUB=rub;
        }
        public double SomToUsd(double som)
        {
            return Math.Round(som/USD,4);
        }
        public double SomToEur(double som)
        {
            return Math.Round(som/EUR,4);
        }
        public double SomToRub(double som)
        {
            return Math.Round(som/RUB,4);
        }
        public double UsdToSom(double usd)
        {
            return Math.Round(usd*USD,4);
        }
        public double EurToSom(double eur)
        {
            return Math.Round(eur*EUR,4);
        }
        public double RubToSom(double rub)
        {
            return Math.Round(rub*RUB,4);
        }
    }
   class Employee 
    {
        public string Name {get;set;}
        public string LastName {get;set;}
        public string position {get;set;}
        public int experience {get;set;}
        public Employee(string Name, string LastName, string position, int experience)
        {
            this.Name = Name;
            this.LastName = LastName;
            this.position = position;
            this.experience = experience;
        }
        private static string[] PositionArr = {"Программист","Экономисть","Врач","Уборщик","Менеджмент","Учитель","Менеджер","Юрист","Маршедр","Ахрана"};
        private static int[] salary = {1200,3000,2300,1500,2700,1234,4134,1340,1234,5435};
        private static int[] ExperienceArr = {0,100,200,300,400,500,600,700,800,900};
        public void GetInfo ()
        {
            System.Console.WriteLine($"Должность: {position}\nИмя: {Name}\nФамилия: {LastName}");
        }
        public int PlusExperience ()
        {
            int sum = 0;
            for(int i = 0; i < ExperienceArr.Length; i++)
            {
                if(PositionArr[i] == position)
                {
                    sum += salary[i];
                }
                if(experience > ExperienceArr.Length-1 && i < 1)
                {
                    sum += ExperienceArr[ExperienceArr.Length-1];
                }
                else if(i == experience)
                {
                    sum += ExperienceArr[i];
                }
            }
            return sum;
        }
        public Employee(){}
        public void ShowListOfExperience ()
        {
            System.Console.Write("Список профессий: ");
            for(int i = 0; i < PositionArr.Length; i ++)
            {
                if(i == PositionArr.Length-1)
                {
                    System.Console.Write(PositionArr[i] + " ");
                }
                else {
                    System.Console.Write(PositionArr[i] + ", ");
                }
            }
            System.Console.WriteLine();
        }
        public void ShowoSalary()
        {
            for(int i = 0; i < PositionArr.Length;i++)
            {
                if(PositionArr[i] == position)
                {
                    System.Console.WriteLine($"У {PositionArr[i]} зарплата = {salary[i]}");
                }
            }
        }
        public void ShowTax()
        {
            double salary = 0;
            for(int i = 0; i < PositionArr.Length; i++)
            {
                if(PositionArr[i] == position)
                {
                    salary += Employee.salary[i];
                }
                if(experience > ExperienceArr.Length-1 && i < 1)
                {
                    salary += ExperienceArr[ExperienceArr.Length-1];
                }
                else if(i == experience)
                {
                    salary += ExperienceArr[i];
                }
            }
            Console.WriteLine($"Размер зарплаты учитывая 13%({salary*0.13} сомон) налога и 1%({salary*0.01} сомон) пенсионного фонда с общей суммы");

            Console.WriteLine($"Выплате: {salary-((salary*0.13)+(salary*0.01))}");
        }
    }
}

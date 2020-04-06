using System;

namespace MyprojecsApp
{
    class Program
    {
        static void Main(string[] args)
        {
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
}

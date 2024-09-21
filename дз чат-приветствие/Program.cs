using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_чат_приветствие
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тема: танцы");
            Console.WriteLine("Здравствуйте,вас приветствует студия танцев Viktoria");
            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ваш пол(м/ж)");
            char pol = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Занимались ли вы ранее танцами? false-нет; true-да");
            bool ymenye = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Какой стиль в танце вы предпочитаете?");
            string styl = Console.ReadLine();
            Console.WriteLine("Сколько раз в неделю вы планируете заниматься(введите одну цифру)?");
            int plan = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ваш номер телефона");
            long nomer = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Откуда узнали о нашей студии?");
            string jjjj = Console.ReadLine();
            Console.WriteLine($" Вас зовут: {name};\n" +
                $" Возраст: {age};\n" +
                $" Пол: {pol};\n" +
                $" Умение: {ymenye};\n" +
                $" Стиль: {styl};\n" +
                $" Количество занятий: {plan};\n" +
                $" Номер телефона: {nomer};\n" +
                $" Откуда узнали о нас: {jjjj}" );
            Console.ReadLine();
        }

     
    }
}

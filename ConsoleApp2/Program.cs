using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person GrandMother_id_1_1 = new Person()
            {
                FIO = "Бабка № 1_1",
                Age = 55,
                Gender = Gender.man,
                Mother = null,
                Father = null

            };

            Person GrandFather_id_1_2 = new Person()
            {
                FIO = "Дед № 1_2",
                Age = 55,
                Gender = Gender.man,
                Mother = null,
                Father = null

            };

            Person GrandMother_id_2_1 = new Person()
            {
                FIO = "Бабка № 2_1",
                Age = 55,
                Gender = Gender.man,
                Mother = null,
                Father = null

            };

            Person GrandFather_id_2_2 = new Person()
            {
                FIO = "Дед № 2_2",
                Age = 55,
                Gender = Gender.man,
                Mother = null,
                Father = null

            };

            Person Father_id_1 = new Person()
            {
                FIO = "ПАПА № 1",
                Age = 55,
                Gender = Gender.man,
                Mother = GrandMother_id_1_1,
                Father = GrandFather_id_1_2

            };

            Person Mother_id_2 = new Person()
            {
                FIO = "МАМА № 2",
                Age = 55,
                Gender = Gender.woman,
                Mother = GrandMother_id_2_1,
                Father = GrandFather_id_2_2               

            };

            
            Print(Father_id_1);
            Print(Mother_id_2);
            


            Console.ReadKey();
        }
        static void Print(Person person)
        {
            Console.WriteLine($"|Имя :{person.FIO} Лет: {person.Age} Пол: {person.Gender}|");

            Console.WriteLine($"|Мама: {person.Mother.FIO}||Папа: {person.Father.FIO}|");
            Console.WriteLine("--------------------------------");
        }
    }
}

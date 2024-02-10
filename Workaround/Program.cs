using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();
            SelamVer();
            SelamVer();
            SelamVer();
            Person person1 = new Person();
            person1.FirstName = "ÖMER";
            person1.LastName = "BARUTÇU";
            person1.DateOfBirthYear = 1984;
            person1.NationalID = 123;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);


            Console.ReadLine();
        }
        static void SelamVer()
        {
            Console.WriteLine("Merhaba !");
        }
        private static void Degiskenler()
        {
            string mesaj = "Hello Word!";
            double tutar = 10000;
            int sayi = 100;
            bool girisYapmisMi = false;



            Console.WriteLine(mesaj);
            Console.WriteLine(tutar);
            Console.WriteLine(mesaj);
        }
    }
}

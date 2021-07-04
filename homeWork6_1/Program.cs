using System;

namespace homeWork6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            string userSurename;
            string userTown;
            string userHobby;
            int userAge;

            Console.WriteLine("Здравствуйте. Представьтесь");
            Console.Write("Ваше имя: ");
            userName = Console.ReadLine();
            Console.Write("Ваша фамилия: ");
            userSurename = Console.ReadLine();
            Console.Write("Ваш возраст: ");
            userAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ваш город проживания: ");
            userTown = Console.ReadLine();
            Console.Write("Ваше увлечение: ");
            userHobby = Console.ReadLine();

            Console.WriteLine("Вас зовут " + userName + " " + userSurename + ", Вам " + userAge + " лет. Вы из города " + userTown + ". Ваше увлечение это " + userHobby);
        }
    }
}




       

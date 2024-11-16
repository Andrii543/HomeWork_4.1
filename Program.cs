using System.Globalization;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        //Вивід на укр мові в консолі 
        Console.OutputEncoding = UTF8Encoding.UTF8;


        Console.WriteLine("Привіт, світ!");

        Console.WriteLine("Впишіть цифру дня:");

        //Вивід для користувача яка цифра відповідає за конкретний день
        Console.WriteLine("\n1:Понеділок \n2:Вівторок \n3:Cереда \n4:Четвер \n5:П'ятниця \n6:Субота \n7:Неділя");
        
        int userInput = Convert.ToInt32(Console.ReadLine());

        // для перевірки чи користувач ввів правильне число
        #region написав цей код бо хтів попрактикуватись на if бо вигідніше в цьому завданні зробити switch 
        bool Verification = true;
        if (userInput >= 7)
        {
            Console.WriteLine("Ви ввели не правильне число, ви можете обрати від 1 до 7");
            Verification = false;
        }
        #endregion

        if (Verification == true)
        {
            switch (userInput)
            {
                case 1:
                    Console.WriteLine("Ви вибрали Понеділок");
                    break;

                case 2:
                    Console.WriteLine("Ви вибрали Вівторок");
                    break;
                case 3:
                    Console.WriteLine("Ви вибрали Cереда");
                    break;
                case 4:
                    Console.WriteLine("Ви вибрали Четвер");
                    break;
                case 5:
                    Console.WriteLine("Ви вибрали Пятниця");
                    break;
                case 6:
                    Console.WriteLine("Ви вибрали Субота");
                    break;
                case 7:
                    Console.WriteLine("Ви вибрали Неділя");
                    break;
                default:
                    Console.WriteLine("Ви вибрали не існуючий день");
                    break;
            }
        }


    }
}
using System.Data;

namespace Task_02_04
{
    internal class Program
    {
        //Пользователь вводит свою дату рождения построчно
        //(сначала год, потом месяц и в конце дату)
        //произведите расчет является ли пользователь совершеннолетним 
        //на текущую дату и выведите соответствующее сообщение об этом
        static void Main(string[] args)
        {
            Console.Write("Введите год рождения: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Введите месяц рождения (1-12): ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Введите день рождения: ");
            int day = int.Parse(Console.ReadLine());
            DateTime birthDate = new DateTime(year, month, day);
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - birthDate.Year;
            if (currentDate < birthDate.AddYears(age))
            {
                age--;
            }
            if (age >= 18)
            {
                Console.WriteLine("Вы совершеннолетний.");
            }
            else
            {
                Console.WriteLine("Вы несовершеннолетний.");
            }
        }
    }
}
using System.Data;

namespace Task1
{
    public class Logic
    {
        public static string wordForm (int amount, string type)
        {
            var word = "";
            try
            {
                if (type == "rubles")
                {
                    if (amount >= 10 && amount <= 14)
                    {
                        word = " рублей";
                    }
                    else if (amount % 10 == 1)
                    {
                        word = " рубль";
                    }
                    else if (amount % 10 >= 2 && amount % 10 <= 4)
                    {
                        word = " рубля";
                    }
                    else if (amount % 10 >= 5 && amount % 10 <= 9)
                    {
                        word = " рублей";
                    }
                }
                else if (type == "cents")
                {
                    if (amount >= 10 && amount <= 14)
                    {
                        word = " копеек";
                    }
                    else if (amount % 10 == 1)
                    {
                        word = " копейка";
                    }
                    else if (amount % 10 >= 2 && amount % 10 <= 4)
                    {
                        word = " копейки";
                    }
                    else if (amount % 10 >= 5 && amount % 10 <= 9)
                    {
                        word = " копеек";
                    }
                }
                else
                    throw new Exception("Неправильно указан тип слова: rubles/cents");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return word;
        }
        public static string msgForm (int r, int c, string r_line, string c_line)
        {
            var word = "";
            if (r != 0 && c != 0)
                word = r.ToString() + r_line + ", " + c.ToString() + c_line;
            else if (c != 0)
                word = c.ToString() + c_line;
            else
                word = r.ToString() + r_line + " ровно";
            return word;
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // НАЧАЛО взаимодействия с пользователем
            int price = 0; // цена продукта
            do
            {
                Console.Write("Введите цену продукта: ");
                try
                {
                    price = int.Parse(Console.ReadLine());
                    if (price < 1 || price > 9999)
                        throw new Exception("Число должно быть в пределах от 1 до 9999");
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (price < 1 || price > 9999);
            // КОНЕЦ взаимодействия с пользователем

            // НАЧАЛО логики
            int rubles = price / 100; // рубли
            int cents = price % 100; // копейки
            string r_line = ""; // слова, которые будем склонять
            string c_line = "";
            r_line = Logic.wordForm(rubles, "rubles");
            c_line = Logic.wordForm(cents, "cents");

            var OutMsg = Logic.msgForm(rubles, cents, r_line, c_line);
            // КОНЕЦ логики

            // НАЧАЛО взаимодействия с пользователем
            Console.WriteLine(OutMsg);
            // КОНЕЦ взаимодействия с пользователем
        }
    }
}

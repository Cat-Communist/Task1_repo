namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int price = 0; // цена продукта
            do
            {
                Console.Write("Введите цену продукта: ");
                try
                {
                    price = int.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (price < 1 || price > 9999);

            int rubles = price / 100; // рубли
            int cents = price % 100; // копейки
            string r_line = ""; // слова, которые будем склонять
            string c_line = "";
            if (rubles >= 10 && rubles <= 14)
            {
                r_line = " рублей";
            }
            else if (rubles % 10 == 1)
            {
                r_line = " рубль";
            }
            else if (rubles % 10 >= 2 && rubles % 10 <= 4)
            {
                r_line = " рубля";
            }
            else if (rubles % 10 >= 5 && rubles % 10 <= 9)
            {
                r_line = " рублей";
            }

            if (cents >= 10 && cents <= 14)
            {
                c_line = " копеек";
            }
            else if (cents % 10 == 1)
            {
                c_line = " копейка";
            }
            else if (cents % 10 >= 2 && cents % 10 <= 4)
            {
                c_line = " копейки";
            }
            else if (cents % 10 >= 5 && cents % 10 <= 9)
            {
                c_line = " копеек";
            }

            if (rubles != 0 && cents != 0)
                Console.WriteLine(rubles + r_line + ", " + cents + c_line);
            else if (cents != 0)
                Console.WriteLine(cents + c_line);
            else
                Console.WriteLine(rubles + r_line + " ровно");
        }
    }
}

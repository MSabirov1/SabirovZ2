
namespace SabirovZ2
{
    internal class Second
    {
        private static int CheckInt()
        {
            int a = 0;
            while (true)
            {
                Console.Write("Write int: ");
                string s = Console.ReadLine();
                if (int.TryParse(s, out a))
                    break;
            }
            return a;
        }
        public static bool O1(int n) => n % 3 == 0 && n % 7 == 0;

        public static void O4()
        {
            int date = 0;
            while (date < 1 || date > 7)
            {
                try
                {
                    date = CheckInt();
                }
                catch (Exception)
                {

                }
            }
            switch (date)
            {
                case 1:
                    {
                        Console.WriteLine("Monday");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Tuesday");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Wednesday");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Thursday");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Friday");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Saturday");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Sunday");
                        break;
                    }
            }
        }

        public static void O5()
        {
            bool a = true;
            while (a)
            {
                Console.Write("Write day: ");
                string s = Console.ReadLine();
                switch (s)
                {
                    case "Monday":
                        {
                            Console.WriteLine(1);
                            a = false;
                            break;
                        }
                    case "Tuesday":
                        {
                            Console.WriteLine(2);
                            a = false;
                            break;
                        }
                    case "Wendnesday":
                        {
                            Console.WriteLine(3);
                            a = false;
                            break;
                        }
                    case "Thursday":
                        {
                            Console.WriteLine(4);
                            a = false;
                            break;
                        }
                    case "Friday":
                        {
                            Console.WriteLine(5);
                            a = false;
                            break;
                        }
                    case "Saturday":
                        {
                            Console.WriteLine(6);
                            a = false;
                            break;
                        }
                    case "Sunday":
                        {
                            Console.WriteLine(7);
                            a = false;
                            break;
                        }
                }
            }
        }
    }
}

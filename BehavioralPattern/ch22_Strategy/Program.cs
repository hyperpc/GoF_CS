using System;
using System.Configuration;
using System.Reflection;

//dotnet add package System.Configuration.ConfigurationManager --version 4.7.0
namespace ch22_Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Movie Ticket
            {
                Ticket.MovieTicket ticket = new Ticket.MovieTicket();
                double originalPrice = 60.0;
                double currentPrice;
                ticket.Price=originalPrice;
                System.Console.WriteLine($"原票价为：{originalPrice}");
                System.Console.WriteLine("-------------------------");

                Ticket.Discount discount;
                string discountType = ConfigurationManager.AppSettings["discountType"];
                //System.Console.WriteLine($"{discountType}");
                discount = (Ticket.Discount)Assembly.Load("ch22_Strategy").CreateInstance(discountType);
                ticket.SetDiscount(discount);

                currentPrice = ticket.Price;
                System.Console.WriteLine($"折后价为：{currentPrice}");
            }

            // 2. PetShop Order

            // 3. Encrypt: MD5, SHA32...
            // 4. OrderBy: Pop, Select, Insert,...
            // 5. Plane: (TakeOff, Fly)
            //       Helicopter(Vertical, SubSonic)
            //       AirPlane(LongDistance, SubSonic)
            //       Fighter(LongDistance, SuuperSonic)
            //       Harrier(Vertical, SuperSonic)

            Console.ReadLine();
        }
    }
}

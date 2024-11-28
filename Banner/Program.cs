using System.Drawing;

namespace Banner
{
    internal class Program
    {
        enum Days { Hétfő, Kedd, Szerda, Vasárnap }
        static void Main(string[] args)
        {

            if (Days.Kedd < Days.Vasárnap) { }

            for (Days nap = Days.Hétfő; nap <= Days.Szerda; nap++)
            {
                switch (nap)
                {
                    case Days.Hétfő:

                        break;
                    case Days.Kedd:

                        break;
                    case Days.Szerda:
                        break;
                    case Days.Vasárnap:
                        break;
                    default:
                        break;
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write('■');
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine('■');

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;


namespace HotelGo99
{
    class Program

        
    {
        public static int RoomSize { get; private set; }
        public static int stay { get; private set; }

        static void Main(string[] args)
        {  

            int Rn = 15;

                switch (Rn)
                {
                    case 1:
                        RoomSize = 0;
                        stay = 0;
                        Console.WriteLine("Queen Size 1 night stay $30.00");
                        break;
                    case 2:
                        RoomSize = 0;
                        stay = 1;
                        Console.WriteLine("Queen Size 2 night stay $60.00");
                        break;
                    case 3:
                        RoomSize = 0;
                        stay = 2;
                        Console.WriteLine("Queen Size 3 night stay $90.00");
                        break;
                    case 4:
                        RoomSize = 0;
                        stay = 3;
                        Console.WriteLine("Queen Size 4 night stay $120.00");
                        break;
                    case 5:
                        RoomSize = 0;
                        stay = 4;
                        Console.WriteLine("Queen Size 5 night stay $150.00");
                        break;
                    case 6:
                        RoomSize = 1;
                        stay = 0;
                        Console.WriteLine("King Size 1 night stay $40.00");
                        break;
                    case 7:
                        RoomSize = 1;
                        stay = 1;
                        Console.WriteLine("King Size 2 night stay $80.00");
                        break;
                    case 8:
                        RoomSize = 1;
                        stay = 2;
                        Console.WriteLine("King Size 3 night stay $120.00");
                        break;
                    case 9:
                        RoomSize = 1;
                        stay = 3;
                        Console.WriteLine("King Size 4 night stay $160.00");
                        break;
                    case 10:
                        RoomSize = 1;
                        stay = 4;
                        Console.WriteLine("King Size 5 night stay $200.00");
                        break;
                    case 11:
                        RoomSize = 2;
                        stay = 0;
                        Console.WriteLine("Suite 1 night stay $50.00");
                        break;
                    case 12:
                        RoomSize = 2;
                        stay = 1;
                        Console.WriteLine("Suite 2 night stay $100.00");
                        break;
                    case 13:
                        RoomSize = 2;
                        stay = 2;
                        Console.WriteLine("Suite 3 night stay $150.00");
                        break;
                    case 14:
                        RoomSize = 2;
                        stay = 3;
                        Console.WriteLine("Suite 4 night stay $200.00");
                        break;
                    case 15:
                        RoomSize = 2;
                        stay = 4;
                        Console.WriteLine("Suite 5 night stay $250.00");
                        break;
                    default:
                        Console.WriteLine("Error - invalid selection");
                        break;
                
            }
            Console.ReadLine();
        }
    }
}

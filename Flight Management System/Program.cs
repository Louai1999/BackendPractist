namespace Flight_Management_System
{
    internal class Program
    {



        public static int mainMenue()
        {
            Console.WriteLine("1. Register Passenger ");
            Console.WriteLine("2. Add Aircraft");
            Console.WriteLine("3. Register Pilot");
            Console.WriteLine("4. View Flights");
            Console.WriteLine("5. Schedul Flight");
            Console.WriteLine("6. Book Flight");
            Console.WriteLine("7. Cancel Booking");
            Console.WriteLine("8. Depart Flight");
            Console.WriteLine("9. Cancel Flight");
            Console.WriteLine("10. Passenger Booking History");
            Console.WriteLine("11. Flight Revenue");
            Console.WriteLine("0.Exit");

            Console.WriteLine("");
            Console.WriteLine("==Select option==");
            return int.Parse(Console.ReadLine());


        }
        public static void RegisterPassenger()
        {

        
        }//1

        public static void AddAircraft()
        {


        }//2

        public static void RegisterPilot()
        {


        }//3

        public static void ViewFlights()
        {


        }//4

        public static void SchedulFlight()
        {


        }//5

        public static void BookFlight()
        {


        }//6

        public static void CancelBooking()
        {


        }//7

        public static void DepartFlight()
        {


        }//8

        public static void CancelFlight()
        {


        }//9

        public static void PassengerBookingHistory()
        {


        }//10

        public static void FlightRevenue()
        {


        }//11





        static void Main(string[] args)
        {
            bool exit = false;
            while (exit == false)
            {
                switch (mainMenue())
                {
                    case 1:
                        break;


                    case 2:
                        break;


                    case 3:
                        break;


                    case 4:
                        break;


                    case 5:
                        break;


                    case 6:
                        break;


                    case 7:
                        break;


                    case 8:
                        break;


                    case 9:
                        break;


                    case 10:
                        break;


                    case 11:
                        break;

                    default:
                        Console.WriteLine("invalid option");
                        break;

                }
                Console.WriteLine("press any key to continue...");
                Console.ReadKey();
                Console.Clear();


            }




        }
    }
}

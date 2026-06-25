using Flight_Management_System.Models;
using System.ComponentModel;
using System.Numerics;
using System.Xml.Linq;

namespace Flight_Management_System
{
    internal class Program
    {



        public static int mainMenue()
        {
            Console.WriteLine("*************************************************");
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
            Console.WriteLine("*************************************************");

            Console.WriteLine("");
            Console.WriteLine("==Select option==");
            return int.Parse(Console.ReadLine());


        }//Mainmenu
        public static void RegisterPassenger()
        {
            Console.WriteLine("Please enter your name:");
            string PsName = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(PsName))
            {
                Console.WriteLine("Error: Passenger name cannot be empty");
                return;
            }
            Console.WriteLine($"Hello welcome:  {PsName}");


            Console.WriteLine("Please enter phone number: ");
            double PhNumber = double.Parse (Console.ReadLine());
            Console.WriteLine($"{PsName} your phone number is {PhNumber}");

            int newId = FlightContext.passengers.Count + 1;
            Passenger newPassenger = new Passenger
            {
                passengerId =newId,
                passengerName = PsName,
                passengerPhone = PhNumber
            };

            FlightContext.passengers.Add(newPassenger);
            Console.WriteLine($"\n Passenger registered successfully! Your ID is: {newPassenger.passengerId.ToString ("D3")}");

        }//1

        public static void AddAircraft()
        {
            Console.WriteLine("Please enter Airccraft model:");
            string aircraftName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(aircraftName))

            {
                Console.WriteLine("Error: AirCraft model cannot be empty . ");
                return ;
            }


            Console.WriteLine("Please enter total seats:");
            int totalSeats = int.Parse(Console.ReadLine());

            if (totalSeats <= 0)
            {
                Console.WriteLine("Eroro: Total seats cannot be less than 0 ");
                return;
            }

            int newAirCraft = FlightContext.aircrafts.Count + 1;

            Aircraft newAircraft = new Aircraft
            {
                aircraftId =  newAirCraft,
                model = aircraftName,
                totalSeats = totalSeats,
                isOperational = true

            };

            FlightContext.aircrafts.Add(newAircraft);
            Console.WriteLine($" Aircraft registered successfully! Your ID is: {newAirCraft} ");

            




        }//2

        public static void RegisterPilot()
        {
            Console.WriteLine("Hello pilot enter your name: ");
            string pilotName = Console.ReadLine();

            Console.WriteLine($"Mr/Miss {pilotName}  Enter your phone number: ");
            string pilotPhones = Console.ReadLine();

            Console.WriteLine("Enter your license Number: ");
            string licenseNumbers = Console.ReadLine();

            Console.WriteLine("How many flight hours");
            int flightHour = int.Parse(Console.ReadLine());


            int newPilotId = FlightContext.pilots.Count + 1;

            Pilot newPilot = new Pilot
            {
                pilotId = newPilotId,
                pilotName = pilotName,
                pilotPhone = pilotPhones,
                licenseNumber = licenseNumbers,
                flightHours = flightHour,


                isAvailable = true

            };
                
            FlightContext.pilots.Add(newPilot);
            Console.WriteLine($"Pilot added successfully your id is : {newPilot.pilotId.ToString("D3")}");

            Console.WriteLine($"Hello {newPilot.pilotName}, your ID is: {newPilot.pilotId.ToString("D3")}");
            Console.WriteLine($"Phone number: {pilotPhones}");
            Console.WriteLine($"License number: {licenseNumbers}");
            Console.WriteLine($"Your active flight:{flightHour}");

            Console.WriteLine("");
            Console.WriteLine("Pilot registered successfully");











        }//3

        public static void ViewFlights()
        {
            if(FlightContext.flights.Count == 0 )
            {
                Console.WriteLine("Sorry no flights found! ");
                return;
            }

            foreach (Flight flighte in FlightContext.flights) 
            {
                Console.WriteLine($"Flight code  :  {flighte.flightcode}");
                Console.WriteLine($"Flight origin  : {flighte.origin} ");
                Console.WriteLine($"Flight destination  : {flighte.destination}");
                Console.WriteLine($"Flight departure Date&Time {(flighte.departureDate) + (flighte.departureTime)}");
                Console.WriteLine($"Available seats : {flighte.availableSeats}");
                Console.WriteLine($"Ticket price : {flighte.ticketPrice}");
                Console.WriteLine($"Last ststus : {flighte.status}");
                

            }
            



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
                        RegisterPassenger();
                        break;


                    case 2:
                        AddAircraft();
                        break;


                    case 3:
                        RegisterPilot();
                        break;


                    case 4:
                        ViewFlights();
                        break;


                    case 5:
                        SchedulFlight();
                        break;


                    case 6:
                        BookFlight();
                        break;


                    case 7:
                        CancelBooking();
                        break;


                    case 8:
                        DepartFlight();
                        break;


                    case 9:
                        CancelFlight();
                        break;


                    case 10:
                        PassengerBookingHistory();
                        break;


                    case 11:
                        FlightRevenue();
                        break;

                    default:
                        Console.WriteLine("invalid option");
                        break;

                }
                Console.WriteLine("press any key to continue...");
                Console.ReadKey();
                Console.Clear();


            }


            Console.WriteLine("Good bye!");


        }
    }
}

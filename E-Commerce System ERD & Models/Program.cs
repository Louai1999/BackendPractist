using E_Commerce_System_ERD___Models.Model;

namespace E_Commerce_System_ERD___Models
{
    internal class Program
    {



        //MainMenu
        public static int mainmenue()
        {

            Console.WriteLine("=================================");
            Console.WriteLine(" E-Commerce System EF Core Migration & CRUD");
            Console.WriteLine("=================================");

            Console.WriteLine("1. Add New Room");
            Console.WriteLine("2. Register New Guest");
            Console.WriteLine("3. Book a Room for a Guest");
            Console.WriteLine("4. Search & Filter Rooms");
            Console.WriteLine("5. Guest & Booking Statistics");
            Console.WriteLine("6. Check Out a Guest");
            Console.WriteLine("7. Remove Unavailable Rooms");
            Console.WriteLine("8. Add New Room");
            Console.WriteLine("9. Add New Room");
            Console.WriteLine("10. Add New Room");
            Console.WriteLine("11. Add New Room");
            Console.WriteLine("12. Add New Room");

            Console.WriteLine("0. exit");
            Console.WriteLine("=================================");

            Console.WriteLine("enter your choice: ");

            return Convert.ToInt32(Console.ReadLine());


        }


        public static void RegisterNewUser(ECommerceContext context)
        {
            Console.WriteLine("\n--- 01: Register New User ---");
            Console.Write("Enter Username: ");
            string uname = Console.ReadLine();
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            User newUser = new User
            {
                userName = uname,
                email = email,
                registrationDate = DateTime.Now,
                isActive = true
            };

            context.users.Add(newUser); // 
            context.SaveChanges();      // SQL

            Console.WriteLine($"User registered successfully! Assigned ID: {newUser.userId}");

        }



        public static void AddProductToCategory(ECommerceContext context)
        {
            Console.WriteLine("\n--- 02: Add Product ---");
            Console.Write("Enter Category ID: ");
            int catId = int.Parse(Console.ReadLine());
            Console.Write("Enter Product Name: ");
            string pName = Console.ReadLine();
            Console.Write("Enter Price: ");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.Write("Enter Stock Quantity: ");
            int stock = int.Parse(Console.ReadLine());

            Product newProduct = new Product
            {
                productName = pName,
                price = price,
                stockQuantity = stock,
                categoryId = catId, // ربط الـ Foreign Key بالقسم
                createdAt = DateTime.Now,
                isAvailable = true
            };

            context.products.Add(newProduct);
            context.SaveChanges();
            Console.WriteLine($" Product '{pName}' added successfully!");



        }



        public static void PlaceOrder(ECommerceContext context)
        {
            Console.WriteLine("Please enter User Id");
            int uId = int.Parse(Console.ReadLine());


            Order newOrder = new Order
            {
                userId = uId,
                orderDate = DateTime.Now,
                status = "Pinding",
                totalAmount = 0

            };


            context.orders.Add(newOrder);
            context.SaveChanges();

            Console.WriteLine($"Order created invoice number {newOrder.orderId}");



        }




            static void Main(string[] args)
        {

            bool exit = false;
            while (exit == false)
            {
                switch (mainmenue())
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


                    case 12:
                        break;

                    case 0:
                        exit = true;
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

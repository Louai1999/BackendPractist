using E_Commerce_System_ERD___Models.Model;

namespace E_Commerce_System_ERD___Models
{
    internal class Program
    {

        ECommerceContext db = new ECommerceContext();


        //MainMenu
        public static int mainmenue()
        {

            Console.WriteLine("=================================");
            Console.WriteLine(" E-Commerce System EF Core Migration & CRUD");
            Console.WriteLine("=================================");

            Console.WriteLine("1. Register a New User");
            Console.WriteLine("2. Add a New Product to a Category");
            Console.WriteLine("3. Place an Order");
            Console.WriteLine("4. Write a Product Review");
            Console.WriteLine("5. Update Product Price and Availability");
            Console.WriteLine("6. Cancel an Order");
            Console.WriteLine("7. Delete a Review");
            Console.WriteLine("8. View All Products (Get All)");
            Console.WriteLine("9. Filter Products by Category and Price Range");
            Console.WriteLine("10. Get Category with All Its Products (Include)");
            Console.WriteLine("11.  View Order History with Full Details\r\n(ThenInclude");
            Console.WriteLine("12.  Product Summary Report (Projection + Lazy\r\nLoading)");

            Console.WriteLine("0. exit");
            Console.WriteLine("=================================");

            Console.WriteLine("enter your choice: ");

            return Convert.ToInt32(Console.ReadLine());


        }


        public static void RegisterNewUser(ECommerceContext context)
        {
            try
            {
                Console.WriteLine("\n--- 01: Register New User ---");
                Console.Write("Enter Username: ");
                string uname = Console.ReadLine();
                Console.Write("Enter Email: ");
                string email = Console.ReadLine();
                Console.WriteLine("Enter password ");
                string pssUser = Console.ReadLine();
                Console.WriteLine("Enter your full name ");
                string fName = Console.ReadLine();
                Console.WriteLine("Enter phone number ");
                string pNumber = Console.ReadLine();
                Console.WriteLine("address");
                string addrese = Console.ReadLine();
                Console.WriteLine("Registration Date");

                
         







                User newUser = new User
                {
                    userName = uname,
                    email = email,
                    registrationDate = DateTime.Now,
                    passwordHash = pssUser,
                    fullName = fName,
                    phoneNember = pNumber,
                    address = addrese,


                    isActive = true
                };

                context.users.Add(newUser); // 
                context.SaveChanges();      // SQL

                Console.WriteLine($"User registered successfully! Assigned ID: {newUser.userId}");
            }
            catch (Microsoft.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine("Error");


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error");

            }
        } //01



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



        } //02



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



        }//03 Still not completed


        public static void RroductReview (ECommerceContext context)

        {
            Console.WriteLine("Users list");

            var userList = context.users.ToList();

            foreach (var u in userList) //
            {
                Console.WriteLine($"User number: [{u.userId}] | Name: {u.userName}");
            }

            Console.WriteLine("Please enter  user id ");
            int userReview = int.Parse(Console.ReadLine());


            Console.WriteLine("Product List");
            var productList = context.products.ToList();

            foreach (var P in  productList)
            {
                Console.WriteLine($"Product number: [{P.productId}] | Name: {P.productName}");

            }


            Console.WriteLine ("please enter product Id ");
            int pId = int .Parse(Console.ReadLine());


            Console.WriteLine ("Please write your rate about the product :  ");
            int rating = int .Parse(Console.ReadLine());

            Console.WriteLine ("Please adde comment ");
            string comment = Console.ReadLine();



            Review newReview = new Review
            {
                userId = userReview,
                productId = pId,
                rating = rating,
                comment = comment,
                reviewDate = DateTime.Now,
            };


            context.reviews.Add(newReview);
            context.SaveChanges();
            Console.WriteLine("Revoew added successfully ");



        } //4
           
            
        public static void UbdateProduct(ECommerceContext context)
        {
            Console.WriteLine("Enter the product ID :");
            int pId = int .Parse(Console.ReadLine());
            var product   = context.products.FirstOrDefault(p => p.productId ==  pId);

            if (product != null)
            {

                Console.WriteLine("Enter the new Price:");
                product.price = decimal.Parse(Console.ReadLine());

                Console.WriteLine("is Product available? true / false ");
                product. isAvailable = bool.Parse(Console.ReadLine());




                product.price = 25;
                context.SaveChanges();


                Console.WriteLine("Price ubdated done ");

            }

        }

        public static void CancelOrder (ECommerceContext context)

        {


        }
        public static void DeleteReview(ECommerceContext context)
        {


        }

        public static void VewAllProduct(ECommerceContext context)
        {


        }

        public static void FilterProduct(ECommerceContext context)
        {


        }

        public static void GetCategory(ECommerceContext context)

        {


        }
        public static void OrderHistory(ECommerceContext context)

        {


        }
        public static void ProductSummaryReport(ECommerceContext context)
        {


        }







        static void Main(string[] args)
        {

            ECommerceContext db = new ECommerceContext();

            bool exit = false;
            while (exit == false)
            {
                switch (mainmenue())
                {

                    case 1:
                        RegisterNewUser(db);

                        break;



                    case 2:
                        AddProductToCategory(db);

                        break;


                    case 3:
                        PlaceOrder(db);

                        break;


                    case 4:
                        RroductReview(db);

                        break;


                    case 5:

                        UbdateProduct(db);
                        break;


                    case 6:
                        CancelOrder(db);

                        break;


                    case 7:
                        DeleteReview(db);

                        break;


                    case 8:
                        VewAllProduct(db);

                        break;


                    case 9:
                        FilterProduct(db);

                        break;


                    case 10:

                        GetCategory(db);
                        break;


                    case 11:
                        OrderHistory(db);

                        break;


                    case 12:

                        ProductSummaryReport(db);   
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

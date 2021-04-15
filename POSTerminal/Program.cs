using System;
using System.Collections.Generic;

namespace POSTerminal
{
    public class Product
    {
        private string name;
        private string category;
        private string description;
        private decimal price;

        public Product(string xname, string xcategory, string xdescription, decimal xprice)
        {
            name = xname;
            category = xcategory;
            description = xdescription;
            price = xprice;
        }
        public string xname
        {
            get { return name; }
            set { name = value; }
        }
        public string xcategory
        {
            get { return category; }
            set { category = value; }
        }
        public string xdescription
        {
            get { return description; }
            set { description = value; }
        }
        public decimal xprice
        {
            get { return price; }
            set { price = value; }
        }
    }
    public class Checkout
    {
        public static Dictionary<string, int> cart = new Dictionary<string, int>();

        public static void addToCart(string item, int quantity)
        {
            if (cart.ContainsKey(item) == true)
            {
                cart[item] += quantity;
                if (cart[item] < 0)
                {
                    cart[item] = 0;
                }
            }
            else
            {
                cart[item] = quantity;
            }
        }
        public decimal lineTotal(int quantity, decimal price)
        {
            return quantity * price;
        }
        public static decimal subTotal()
        {
            decimal thisTotal = 0;
            foreach (KeyValuePair<string, int> item in cart)
            {
                if (item.Key == Program.newHardCover.xname)
                {
                    thisTotal = (item.Value * Program.newHardCover.xprice) + thisTotal;
                }
                else if (item.Key == Program.newPaperBack.xname)
                {
                    thisTotal = (item.Value * Program.newPaperBack.xprice) + thisTotal;
                }
                else if (item.Key == Program.usedHardCover.xname)
                {
                    thisTotal = (item.Value * Program.usedHardCover.xprice) + thisTotal;
                }
                else if (item.Key == Program.usedPaperBack.xname)
                {
                    thisTotal = (item.Value * Program.usedPaperBack.xprice) + thisTotal;
                }
                else if (item.Key == Program.tea.xname)
                {
                    thisTotal = (item.Value * Program.tea.xprice) + thisTotal;
                }
                else if (item.Key == Program.hotCoco.xname)
                {
                    thisTotal = (item.Value * Program.hotCoco.xprice) + thisTotal;
                }
                else if (item.Key == Program.coffee.xname)
                {
                    thisTotal = (item.Value * Program.coffee.xprice) + thisTotal;
                }
                else if (item.Key == Program.flat.xname)
                {
                    thisTotal = (item.Value * Program.flat.xprice) + thisTotal;
                }
                else if (item.Key == Program.ameri.xname)
                {
                    thisTotal = (item.Value * Program.ameri.xprice) + thisTotal;
                }
                else if (item.Key == Program.coldBrew.xname)
                {
                    thisTotal = (item.Value * Program.coldBrew.xprice) + thisTotal;
                }
                else if (item.Key == Program.milkshake.xname)
                {
                    thisTotal = (item.Value * Program.milkshake.xprice) + thisTotal;
                }
                else if (item.Key == Program.CoffeeShake.xname)
                {
                    thisTotal = (item.Value * Program.CoffeeShake.xprice) + thisTotal;
                }
                else if (item.Key == Program.bottomless.xname)
                {
                    thisTotal = (item.Value * Program.bottomless.xprice) + thisTotal;
                }
                else if (item.Key == Program.cookie.xname)
                {
                    thisTotal = (item.Value * Program.cookie.xprice) + thisTotal;
                }
                else if (item.Key == Program.addOn.xname)
                {
                    thisTotal = (item.Value * Program.addOn.xprice) + thisTotal;
                }
            }
            return thisTotal;
        }
        public static void ListReceipt()
        {
            string spacing;
            decimal thisTotal;

            Console.Write("Qty\tItem\t\t\t\tLine Price\n\n");

            foreach (KeyValuePair<string, int> item in cart)
            {
                thisTotal = 0.00m;
                if (item.Key == Program.newHardCover.xname)
                {
                    thisTotal = (item.Value * Program.newHardCover.xprice) + thisTotal;
                }
                else if (item.Key == Program.newPaperBack.xname)
                {
                    thisTotal = (item.Value * Program.newPaperBack.xprice) + thisTotal;
                }
                else if (item.Key == Program.usedHardCover.xname)
                {
                    thisTotal = (item.Value * Program.usedHardCover.xprice) + thisTotal;
                }
                else if (item.Key == Program.usedPaperBack.xname)
                {
                    thisTotal = (item.Value * Program.usedPaperBack.xprice) + thisTotal;
                }
                else if (item.Key == Program.tea.xname)
                {
                    thisTotal = (item.Value * Program.tea.xprice) + thisTotal;
                }
                else if (item.Key == Program.hotCoco.xname)
                {
                    thisTotal = (item.Value * Program.hotCoco.xprice) + thisTotal;
                }
                else if (item.Key == Program.coffee.xname)
                {
                    thisTotal = (item.Value * Program.coffee.xprice) + thisTotal;
                }
                else if (item.Key == Program.flat.xname)
                {
                    thisTotal = (item.Value * Program.flat.xprice) + thisTotal;
                }
                else if (item.Key == Program.ameri.xname)
                {
                    thisTotal = (item.Value * Program.ameri.xprice) + thisTotal;
                }
                else if (item.Key == Program.coldBrew.xname)
                {
                    thisTotal = (item.Value * Program.coldBrew.xprice) + thisTotal;
                }
                else if (item.Key == Program.milkshake.xname)
                {
                    thisTotal = (item.Value * Program.milkshake.xprice) + thisTotal;
                }
                else if (item.Key == Program.CoffeeShake.xname)
                {
                    thisTotal = (item.Value * Program.CoffeeShake.xprice) + thisTotal;
                }
                else if (item.Key == Program.bottomless.xname)
                {
                    thisTotal = (item.Value * Program.bottomless.xprice) + thisTotal;
                }
                else if (item.Key == Program.cookie.xname)
                {
                    thisTotal = (item.Value * Program.cookie.xprice) + thisTotal;
                }
                else if (item.Key == Program.addOn.xname)
                {
                    thisTotal = (item.Value * Program.addOn.xprice) + thisTotal;
                }
                Console.Write($"{item.Value}\t{item.Key} ");
                if (item.Key.Length < 11)
                {
                    spacing = "\t\t\t";
                }
                else if (item.Key.Length > 18)
                {
                    spacing = "\t";
                }
                else
                {
                    spacing = "\t\t";
                }
                Console.WriteLine($"{spacing} ${thisTotal}\n");
            }
        }
        public static decimal salestax(decimal total)
        {
            decimal tax = total * .07m;
            tax = Math.Round(tax, 2);
            return tax;
        }
        public static decimal grandTotal(decimal total)
        {
            total = total * 1.07m;
            total = Math.Round(total, 2);

            return total;
        }
    }
    class Program
    {
        public static List<Product> menu = new List<Product>();
        public static Product newHardCover = new Product("New Hardcover Book", "Book", "Protected new book straight from the printers. Don't put a drink on it.", 29.99m);
        public static Product newPaperBack = new Product("New Paperback Book", "Book", "Fill your shelves with non-spine-cracked tomes.", 12.99m);
        public static Product usedHardCover = new Product("Used Hardcover Book", "Book", "Still looks good on the shelf. Someone else has touched it though.", 14.50m);
        public static Product usedPaperBack = new Product("Used Paperback Book", "Book", "What you give to your friends to borrow just in case.", 3.99m);
        public static Product tea = new Product("Hot Tea", "Caffiene", "Drink of sophistication. Available in a varitey of colors.", 1.29m);
        public static Product hotCoco = new Product("Hot Chocolate", "Dessert", "For those that don't need energy but want to look cool.", 2.79m);
        public static Product coffee = new Product("House Coffee", "Caffiene", "For the real caffiene addicts. They don't care what's in it.", 1.79m);
        public static Product flat = new Product("Flat White", "Caffiene", "Travelers choice. Guaranteed to remind you of home, or a home cafe.", 2.85m);
        public static Product ameri = new Product("Americano", "Caffiene", "Bitter and backwards, much like our country.", 3.10m);
        public static Product coldBrew = new Product("Cold Brew", "Caffiene", "We brewed this yesterday. It will make you think you quenching your thirst.", 3.95m);
        public static Product milkshake = new Product("Milkshake", "Dessert", "For the young at heart. Watch out for your yard filling with boys.", 4.99m);
        public static Product CoffeeShake = new Product("Coffee Milkshake", "Dessert", "For those that want to shame-drink their pain away.", 6.30m);
        public static Product bottomless = new Product("Bottomless mug", "Caffiene", "For those planning on sticking around a long time and taking that outlet table. I'm looking at you Todd!", 6.00m);
        public static Product cookie = new Product("Baked Good", "Dessert", "If you're starting to get hungry but can't imagine stopping at another place before home.", 3.50m);
        public static Product addOn = new Product("Wasting Cashier's Time", "Dessert", "Ask stupid questions, get stupid consequences. It's a regressive intelligence tax.", 0.29m);
        static void Main(string[] args)
        {
            bool loop = true;
            int menuChoice;
            createMenu();
            do
            {
                PrintMenu();

                menuChoice = MenuInput();

                loop = InputDirectory(menuChoice);
            } while (loop);
        }
        public static void tenderOrder(decimal tender)
        {
            bool notPaid = true;
            bool invalid = true;
            decimal orderTotal = Checkout.grandTotal(Checkout.subTotal());
            string input;
            do
            {
                if (tender < orderTotal)
                {
                    do
                    {
                        Console.Write($"\n\nAmount Still Due: ${orderTotal - tender}\n\n");
                        orderTotal = orderTotal - tender;

                        Console.Write("Please Enter the Cash Tendered: $");
                        input = Console.ReadLine().ToLower();
                        invalid = Program.ValidateToDec(input);
                        if (invalid == false)
                        {
                            tender = decimal.Parse(input);
                        }
                        else
                        {
                            Program.InvalidMessage(3);
                        }
                    } while (invalid);
                }
                else
                {
                    notPaid = false;
                    Console.WriteLine($"\n\nCustomer's Change is ${tender - orderTotal}");
                    Console.Write("\n\nPress enter to return to the main menu.\n\n");
                    Console.ReadLine();
                    Checkout.cart.Clear();
                }
            } while (notPaid);
        }
        static void CartInterface(int choice)
        {
            bool invalid = true;
            int quantity;
            string input;
            decimal lineAmount;
            Checkout shopCart = new Checkout();
            do
            {
                Console.Write("\n\nHow many? (Enter negative quantity to reduce amount in transaction): ");
                input = Console.ReadLine().ToLower();
                invalid = ValidateToInt(input);
                if (invalid == true)
                {
                    InvalidMessage(2);
                }
                else
                {
                    quantity = Int32.Parse(input);

                    Checkout.addToCart(menu[choice].xname, quantity);
                    //need this to say how many are in the cart and the line total.
                    Console.Write($"\n\nQuantity now in cart: {Checkout.cart[menu[choice].xname]}");

                    lineAmount = shopCart.lineTotal(Checkout.cart[menu[choice].xname], menu[choice].xprice);

                    Console.Write($"\nLine total: ${lineAmount}");
                    Console.Write("\n\nPress enter to return to the main menu.\n\n");
                    Console.ReadLine();
                }
            } while (invalid);
        }
        static decimal TenderCash()
        {
            bool invalid = true;
            string input;
            decimal tender = 0.00m;

            do
            {
                Console.Write($"Grand Total: ${Checkout.grandTotal(Checkout.subTotal())}\n");
                Console.Write("::::::::::::::::::::::::::::::::::::::::::::::::::\n\n");
                Console.Write("Please Enter the Cash Tendered: $");
                input = Console.ReadLine().ToLower();
                invalid = ValidateToDec(input);
                if (invalid == false)
                {
                    tender = decimal.Parse(input);
                    if (tender < 0)
                    {
                        invalid = true;
                        InvalidMessage(4);
                    }
                    else
                    {
                        tenderOrder(tender);
                    }
                }
                else
                {
                    InvalidMessage(3);
                }
            } while (invalid);
            return tender;
        }
        static bool InputDirectory(int choice)
        {
            bool loop = true;
            decimal tender;
            decimal change;

            if (choice == menu.Count + 3)
            {
                loop = false;
            }
            else if (choice == menu.Count + 2)
            {
                Checkout.cart.Clear();
                Console.Write("\n\n:::This transaction has been cancelled:::\n\n");
                Console.Write("Press Enter to Continue.");
                Console.ReadLine();
            }
            else if (choice == menu.Count + 1)
            {
                Console.Write("\n\n:::::::::::::::::::::CheckOut:::::::::::::::::::::\n");
                Console.Write("\n:::::::::::::::::::::Receipt::::::::::::::::::::::\n\n");

                Checkout.ListReceipt();
                Console.WriteLine();
                Console.Write($"SubTotal: ${Checkout.subTotal()}\n");
                Console.Write($"Sales Tax: ${Checkout.salestax(Checkout.subTotal())}\n");
                Console.Write("::::::::::::::::::::::::::::::::::::::::::::::::::\n");

                tender = TenderCash();
            }
            else if (choice == menu.Count)
            {
                Console.Write($"\nCurrent SubTotal is ${Checkout.subTotal()}\n\n");
                Console.Write("Press Enter to Continue.");
                Console.ReadLine();
            }
            else
            {
                Console.Write($"\n{menu[choice].xname} - ${menu[choice].xprice} - {menu[choice].xcategory}\n{menu[choice].xdescription}");
                Console.Write($"\n\nQuantity in Cart: ");
                if (Checkout.cart.ContainsKey(menu[choice].xname))
                {
                    Console.Write(Checkout.cart[menu[choice].xname]);
                }
                else
                {
                    Console.Write(0);
                }
                CartInterface(choice);
            }
            return loop;
        }
        static int MenuInput()
        {
            bool invalid = true;
            string input;
            int menuChoice = 0;
            do
            {
                input = Console.ReadLine().ToLower();
                invalid = ValidateToInt(input);

                if (invalid == true)
                {
                    InvalidMessage(1);
                    PrintMenu();
                }
                else
                {
                    menuChoice = Int32.Parse(input);
                    if (menuChoice < 1 || menuChoice > menu.Count + 4)
                    {
                        invalid = true;
                        InvalidMessage(1);
                        PrintMenu();
                    }
                }
            } while (invalid);
            return menuChoice - 1;
        }
        static void PrintMenu()
        {
            string spacing;
            int counter = 1;

            Console.Write("\nApocalypto Cafe and Readery point of sale\n\n:::::::::::::::::MENU:::::::::::::::::\n\n");

            foreach (Product item in menu)
            {
                if (item.xname.Length < 11)
                {
                    spacing = "\t\t\t";
                }
                else if (item.xname.Length > 20)
                {
                    spacing = "\t";
                }
                else
                {
                    spacing = "\t\t";
                }

                Console.Write($"{counter} - {item.xname}{spacing}${item.xprice}\n");
                counter++;
            }
            Console.Write($"{counter} - Display Current SubTotal\n{counter + 1} - CheckOut\n");
            Console.Write($"{counter + 2} - Cancel Transaction\n{counter + 3} - Shut Down POS\n");
            Console.Write("\n::::::::::::::Choose One::::::::::::::");
            Console.Write("\n\nMenu Number: ");
        }
        public static bool ValidateToDec(string input)
        {
            bool invalid = true;
            try
            {
                decimal.Parse(input);
                invalid = false;
            }
            catch
            {
            }
            return invalid;
        }
        static bool ValidateToInt(string input)
        {
            bool invalid = true;
            try
            {
                Int32.Parse(input);
                invalid = false;
            }
            catch
            {
            }
            return invalid;
        }
        static void createMenu()
        {
            menu.Add(newHardCover);
            menu.Add(newPaperBack);
            menu.Add(usedHardCover);
            menu.Add(usedPaperBack);
            menu.Add(tea);
            menu.Add(hotCoco);
            menu.Add(coffee);
            menu.Add(flat);
            menu.Add(ameri);
            menu.Add(coldBrew);
            menu.Add(milkshake);
            menu.Add(CoffeeShake);
            menu.Add(bottomless);
            menu.Add(cookie);
            menu.Add(addOn);
        }
        public static void InvalidMessage(int error)
        {
            switch (error)
            {
                case 1:
                    Console.Write("\n\nThat was not a valid entry. Please enter the menu number.\n\n");
                    break;
                case 2:
                    Console.Write("\n\nThat was not a valid entry. Please enter a whole number for the quantitiy.\n\n");
                    break;
                case 3:
                    Console.Write("\n\nThat was not a valid entry. Please enter the correct cash tendered.\n\n");
                    break;
                case 4:
                    Console.Write("\n\nThat was not a valid entry. Please enter a positive amount of cash to tender.\n\n");
                    break;
            }
        }

    }
}

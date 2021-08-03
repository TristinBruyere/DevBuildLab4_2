using System;

namespace Lab4_2
{
    class MenuItem
    {
        private int ID;
        private string Name;
        private string Description;
        private decimal Price;

        public MenuItem(int _ID, string _Name, string _Description, decimal _Price)
        {
            ID = _ID;
            Name = _Name;
            Description = _Description;
            Price = _Price;
        }

        public MenuItem(int _ID, string _Name, decimal _Price)
        {
            ID = _ID;
            Name = _Name;
            Description = "EMPTY";
            Price = _Price;
        }

        public void SetID(int _ID)
        {
            ID = _ID;
        }
        public int GetID() { return ID; }

        public void SetName(string _Name)
        {
            if (_Name == "")
            {
                _Name = "EMPTY";
            }
            Name = _Name;
        }
        public string GetName() { return Name; }

        public void SetDescription(string _Description)
        {
            if (_Description == "")
            {
                _Description = "EMPTY";
            }
            Description = _Description;
        }
        public string GetDescription() { return Description; }

        public void SetPrice(decimal _Price)
        {
            if (_Price < 0.50m)
            {
                _Price = 0.50m; // Could also set Price = 0.50m
            }
            else if (_Price > 10.00m)
            {
                _Price = 10.00m; // Could alse set Price = 10.00m
            }
            Price = _Price; // Would be unnessessary if the changes above were made
        }
        public decimal GetPrice() { return Price; }

        public override string ToString()
        {
            return $"\n============== MENU ITEM INFO ==============\nID: {ID}\nName: {Name}\nDescription: {Description}\nPrice: {Price}";
        }
    }

    class Rectangle // PART 4
    {
        public int Length;
        public int Width;

        public static void IsEqual(Rectangle r1, Rectangle r2)
        {
            if (r1 == r2)
            {
                Console.WriteLine("\nSame\n");
            }
            else
            {
                Console.WriteLine("\nDifferent\n");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //MenuItem item0 = new MenuItem(); //This does not work without a default constructor

            MenuItem item1 = new MenuItem( 1, "Pie", "An apple pie.", 6.99m );
            Console.WriteLine(item1);

            MenuItem item2 = new MenuItem( 2, "Soda", 1.99m );
            Console.WriteLine(item2);

            MenuItem item3 = new MenuItem( 3, "Burger", "World's best burger", 12.99m);
            Console.WriteLine(item3);
            item3.SetID(13);
            item3.SetName("");
            item3.SetDescription("");
            item3.SetPrice(13); // Price will be 10.00
            Console.WriteLine(item3);
            item3.SetID(3);
            item3.SetName("Jalapeno Burger");
            item3.SetDescription("A spicy snack");
            item3.SetPrice(0.25m);
            // Testing the Get methods
            Console.WriteLine("\n==========Testing the Get methods===========\n");
            Console.WriteLine($"ID: {item3.GetID()}");
            Console.WriteLine($"Name: {item3.GetName()}");
            Console.WriteLine($"Description: {item3.GetDescription()}");
            Console.WriteLine($"Price: {item3.GetPrice()}"); // Price will be .50

            // PART 4
            // Summary: When r1 and r2 are set to the same value initially they are equal, even though they share the same values.
            // However, when you set r1 = r2 they are evaluated as equal.
            // Hypothesis: I believe this is because their "memory slots" are different until they are set as equal to eachother. 

            Console.WriteLine("\n === PART 4 ===\n");
            Rectangle r1 = new Rectangle() { Length = 5, Width = 5 };
            Rectangle r2 = new Rectangle() { Length = 6, Width = 6 };
            Console.WriteLine($"Different Values\nr1 length/width: {r1.Length}/{r1.Width}\nr2 length/width: {r2.Length}/{r2.Width}");
            Rectangle.IsEqual(r1, r2);
            r1.Length = 6;
            r1.Width = 6;
            Console.WriteLine($"\nSame Values changed manually\nr1 length/width: {r1.Length}/{r1.Width}\nr2 length/width: {r2.Length}/{r2.Width}");
            Rectangle.IsEqual(r1, r2);
            r2 = r1;
            Console.WriteLine($"\nSame Values changed by setting r1 = r2\nr1 length/width: {r1.Length}/{r1.Width}\nr2 length/width: {r2.Length}/{r2.Width}");
            Rectangle.IsEqual(r1, r2);
        }
    }
}

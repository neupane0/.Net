using ConsoleApp.Week6;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
           
            Console.WriteLine("========== TASK 1: Expression Bodied Members ==========");
            Rectangle rect = new Rectangle { Width = 5, Height = 10 };
            Console.WriteLine(rect);
            Console.WriteLine();

            // ============== TASK 2 ==============
            Console.WriteLine("========== TASK 2: Custom Delegates ==========");

            // Part 1: Calculate delegate
            Calculate calc = DiscountCalculator.Add;
            Console.WriteLine($"Add(10, 5) = {calc(10, 5)}");

            calc = DiscountCalculator.Subtract;
            Console.WriteLine($"Subtract(10, 5) = {calc(10, 5)}");
            Console.WriteLine();

            // Part 2: DiscountStrategy delegate
            double originalPrice = 5000;
            Console.WriteLine($"Original Price: Rs. {originalPrice}");

            // 2.2: Call with different discount strategies
            double festivalPrice = DiscountCalculator.CalculateFinalPrice(originalPrice, DiscountCalculator.FestivalDiscount);
            Console.WriteLine($"Festival Discount (20% off): Rs. {festivalPrice}");

            double seasonalPrice = DiscountCalculator.CalculateFinalPrice(originalPrice, DiscountCalculator.SeasonalDiscount);
            Console.WriteLine($"Seasonal Discount (10% off): Rs. {seasonalPrice}");

            double noDiscountPrice = DiscountCalculator.CalculateFinalPrice(originalPrice, DiscountCalculator.NoDiscount);
            Console.WriteLine($"No Discount: Rs. {noDiscountPrice}");

            // 2.3: Lambda expression with 30% discount
            double lambdaPrice = DiscountCalculator.CalculateFinalPrice(originalPrice, price => price * 0.70);
            Console.WriteLine($"Lambda Discount (30% off): Rs. {lambdaPrice}");
            Console.WriteLine();

            // ============== TASK 3 ==============
            Console.WriteLine("========== TASK 3: Built-in Delegates (Func) ==========");
            int[] numbers = { 5, 12, 8, 21, 3, 16, 7 };

            Console.WriteLine("All numbers: " + string.Join(", ", numbers));

            Console.Write("Even numbers: ");
            ProcessNumbers(numbers, n => n % 2 == 0);

            Console.Write("Numbers greater than 10: ");
            ProcessNumbers(numbers, n => n > 10);
            Console.WriteLine();

            // ============== TASK 4 ==============
            Console.WriteLine("========== TASK 4: LINQ Basics ==========");

            // 1. Selecting/Projection
            Console.WriteLine("--- 1. Selecting/Projection ---");
            List<int> intList = new List<int> { 1, 2, 3, 4, 5 };
            var squaredNumbers = intList.Select(n => n * n).ToList();
            Console.WriteLine("Original: " + string.Join(", ", intList));
            Console.WriteLine("Squared: " + string.Join(", ", squaredNumbers));
            Console.WriteLine();

            // 2. Filtering (Where)
            Console.WriteLine("--- 2. Filtering (Where) ---");
            List<Book> books = new List<Book>
            {
                new Book { Title = "C# Programming", Price = 1500 },
                new Book { Title = "Learn Python", Price = 800 },
                new Book { Title = "Advanced Java", Price = 1200 },
                new Book { Title = "Web Design", Price = 950 },
                new Book { Title = "Data Structures", Price = 1800 }
            };

            var premiumBooks = books.Where(b => b.Price > 1000).ToList();
            Console.WriteLine("Premium Books (Price > Rs. 1000):");
            premiumBooks.ForEach(b => Console.WriteLine($"  {b}"));
            Console.WriteLine();

            // 3. Sorting (OrderBy)
            Console.WriteLine("--- 3. Sorting (OrderBy) ---");
            List<Student> students = new List<Student>
            {
                new Student { Name = "Zara" },
                new Student { Name = "Alice" },
                new Student { Name = "Mike" },
                new Student { Name = "Emma" },
                new Student { Name = "David" },
                new Student { Name = "Sarah" },
                new Student { Name = "Bob" },
                new Student { Name = "Linda" },
                new Student { Name = "Chris" },
                new Student { Name = "Nina" }
            };

            var sortedStudents = students.OrderBy(s => s.Name).ToList();
            Console.WriteLine("AAA Scholarship Award Winners (Alphabetically):");
            sortedStudents.ForEach(s => Console.WriteLine($"  {s}"));
            Console.WriteLine();

            // ============== TASK 5 ==============
            Console.WriteLine("========== TASK 5: LINQ Continued ==========");

            // 1. Aggregation Operators
            Console.WriteLine("--- 1. Aggregation Operators ---");
            List<CashierSales> salesData = new List<CashierSales>
            {
                new CashierSales { CashierName = "John", Sales = 15000 },
                new CashierSales { CashierName = "Mary", Sales = 22000 },
                new CashierSales { CashierName = "Peter", Sales = 18000 },
                new CashierSales { CashierName = "Lisa", Sales = 12000 },
                new CashierSales { CashierName = "Tom", Sales = 25000 }
            };

            int totalCashiers = salesData.Count();
            double totalSales = salesData.Sum(c => c.Sales);
            double highestSales = salesData.Max(c => c.Sales);
            double lowestSales = salesData.Min(c => c.Sales);
            double averageSales = salesData.Average(c => c.Sales);

            Console.WriteLine($"Total Cashiers: {totalCashiers}");
            Console.WriteLine($"Total Sales: Rs. {totalSales}");
            Console.WriteLine($"Highest Sales: Rs. {highestSales}");
            Console.WriteLine($"Lowest Sales: Rs. {lowestSales}");
            Console.WriteLine($"Average Sales: Rs. {averageSales}");
            Console.WriteLine();

            // 2. Quantifier Operators (Any/All)
            Console.WriteLine("--- 2. Quantifier Operators (Any/All) ---");
            List<Applicant> applicants = new List<Applicant>
            {
                new Applicant { Name = "John", Age = 20 },
                new Applicant { Name = "Sarah", Age = 17 },
                new Applicant { Name = "Mike", Age = 22 },
                new Applicant { Name = "Emma", Age = 19 },
                new Applicant { Name = "David", Age = 16 }
            };

            bool anyUnder18 = applicants.Any(a => a.Age < 18);
            bool allAbove16 = applicants.All(a => a.Age >= 16);

            Console.WriteLine($"Are there any applicants under 18? {anyUnder18}");
            Console.WriteLine($"Are all applicants above 16? {allAbove16}");
            Console.WriteLine();

            // 3. Element Operators (First, Last, FirstOrDefault)
            Console.WriteLine("--- 3. Element Operators ---");
            List<Song> songs = new List<Song>
            {
                new Song { Title = "Morning Blues", DurationInSeconds = 180 },
                new Song { Title = "Night Rider", DurationInSeconds = 300 },
                new Song { Title = "Summer Vibes", DurationInSeconds = 210 },
                new Song { Title = "Epic Journey", DurationInSeconds = 480 },
                new Song { Title = "Quick Beat", DurationInSeconds = 150 }
            };

            var firstSong = songs.First();
            var lastSong = songs.Last();
            var firstLongSong = songs.First(s => s.DurationInSeconds > 240);
            var firstVeryLongSong = songs.FirstOrDefault(s => s.DurationInSeconds > 600);

            Console.WriteLine($"First Song: {firstSong}");
            Console.WriteLine($"Last Song: {lastSong}");
            Console.WriteLine($"First song > 4 minutes (240s): {firstLongSong}");
            Console.WriteLine($"First song > 10 minutes (600s): {(firstVeryLongSong != null ? firstVeryLongSong.ToString() : "None found")}");
            Console.WriteLine();

            // ============== TASK 6 ==============
            Console.WriteLine("========== TASK 6: LINQ Comprehensive Task ==========");

            List<TourBooking> tourBookings = new List<TourBooking>
            {
                new TourBooking { CustomerName = "Alice Johnson", Destination = "Paris", Price = 45000, DurationInDays = 7, IsInternational = true },
                new TourBooking { CustomerName = "Bob Smith", Destination = "Pokhara", Price = 8000, DurationInDays = 3, IsInternational = false },
                new TourBooking { CustomerName = "Charlie Brown", Destination = "Tokyo", Price = 55000, DurationInDays = 10, IsInternational = true },
                new TourBooking { CustomerName = "Diana Prince", Destination = "Chitwan", Price = 12000, DurationInDays = 5, IsInternational = false },
                new TourBooking { CustomerName = "Edward Norton", Destination = "London", Price = 60000, DurationInDays = 8, IsInternational = true },
                new TourBooking { CustomerName = "Fiona Apple", Destination = "Mustang", Price = 15000, DurationInDays = 6, IsInternational = false },
                new TourBooking { CustomerName = "George Martin", Destination = "New York", Price = 50000, DurationInDays = 5, IsInternational = true },
                new TourBooking { CustomerName = "Hannah Montana", Destination = "Lumbini", Price = 7000, DurationInDays = 2, IsInternational = false }
            };

            // Filter: Tours above Rs. 10,000 and duration more than 4 days
            var filteredTours = tourBookings
                .Where(t => t.Price > 10000 && t.DurationInDays > 4);

            // Transform/Project into new anonymous type with Category
            var transformedTours = filteredTours
                .Select(t => new
                {
                    CustomerName = t.CustomerName,
                    Destination = t.Destination,
                    Category = t.IsInternational ? "International" : "Domestic",
                    Price = t.Price
                });

            // Sort by Category (Domestic first), then by Price
            var sortedTours = transformedTours
                .OrderBy(t => t.Category)
                .ThenBy(t => t.Price)
                .ToList();

            // Display results
            Console.WriteLine("Market Analysis Report - Premium Tours (Price > Rs. 10,000 & Duration > 4 days)");
            Console.WriteLine("=".PadRight(80, '='));

            foreach (var tour in sortedTours)
            {
                Console.WriteLine($"Customer: {tour.CustomerName}");
                Console.WriteLine($"Destination: {tour.Destination}");
                Console.WriteLine($"Category: {tour.Category}");
                Console.WriteLine($"Price: Rs. {tour.Price}");
                Console.WriteLine("-".PadRight(80, '-'));
            }

            Console.WriteLine("\n=============== ALL TASKS COMPLETED ===============");
            Console.ReadLine();
        }

        // ============== TASK 3: Helper Method ==============
        static void ProcessNumbers(int[] numbers, Func<int, bool> condition)
        {
            var result = numbers.Where(condition);


            Console.ReadLine();
        }


    }
}
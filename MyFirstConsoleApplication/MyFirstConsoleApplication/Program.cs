
using System.Xml.Linq;

namespace MyFirstConsoleApplication
{

    internal class Program
    {
        private static void Main()
        {
            //Display name and location
            string name, location;
            name = "Steven";
            location = "Lima, Peru";
            Console.WriteLine("My name is " + name + ". I'm from " + location);
            Console.ReadKey();

            //Display current date
            string now = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine( "Today is " + now);
            Console.ReadKey();


            //Display days until Christmas
            //1. Get today's date
            DateTime today = DateTime.Today;
            //2. Get the date for Christmas of the current year
            DateTime christmas = new DateTime(today.Year, 12, 25);
            //3. Calculate the time difference
            TimeSpan timeRemaining = christmas - today;
            //4. Check if Christmas has already passed this year
            if (timeRemaining.TotalDays < 0)
            {
                // If Christmas has passed, calculate the days remaining for next year's Christmas
                christmas = new DateTime(today.Year + 1, 12, 25);
                timeRemaining = christmas - today;
            }
            //5. Get the number of days remaining
            int daysRemaining = (int)timeRemaining.TotalDays;
            Console.WriteLine("Days until Christmas: " + daysRemaining);


            //Add the program example from section 2.1...
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("The width is:");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("The height is:");
            heightString = Console.ReadLine();           
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " +
                   woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
                   glassArea + " square metres");

        }
    }

}
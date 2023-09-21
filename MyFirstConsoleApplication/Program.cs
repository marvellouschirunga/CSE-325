// See https://aka.ms/new-console-template for more information
string name = "Marvellous Humphery Chirunga";
string location = "Harare, Zimbabwe";
Console.WriteLine($"My name is {name}");
Console.WriteLine($"I am from {location}");
DateTime todayDate = DateTime.Now;
Console.WriteLine("Current date is: " + todayDate.ToString("MM/dd/yyyy"));
DateTime christmas = new DateTime(todayDate.Year, 12, 25);
var daysTillChristmas = (christmas - todayDate).Days;
Console.WriteLine($"Number of days until Christmas this year: {daysTillChristmas}");

double width, height, woodLength, glassArea;
string widthString, heightString;

Console.WriteLine("Enter window width:");
widthString = Console.ReadLine();
width = double.Parse(widthString);

Console.WriteLine("Enter window height:");
heightString = Console.ReadLine();
height = double.Parse(heightString);

woodLength = 2 * (width + height) * 3.25;
glassArea = 2 * (width * height);

Console.WriteLine("The length of the wood is " + woodLength + " feet" );
Console.WriteLine("The area of the glass is " + glassArea + " square metres");

Console.ReadKey();



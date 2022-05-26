Random number = new Random();
int randomNumber = number.Next(1,7);
Console.WriteLine("\n The random number is: = "+ randomNumber);

DateTime currentDate = DateTime.Now;
Console.WriteLine("\n Todays date is := "+ currentDate.ToString());
 
DateTime addnumber = currentDate.AddDays(randomNumber);
Console.WriteLine("\n Added a random number to today's date := "+addnumber.ToString());
Console.ReadLine();
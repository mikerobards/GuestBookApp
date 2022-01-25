using GuestBook;

List<string> guestNames = new List<string>();
int guestCount = 0;
string anotherParty;
bool isValidNum;

GuestBookMethods.WelcomeUser();

//GuestBookMethods.AskUsersName();

//GuestBookMethods.AskNumberGuests(guestCount);


do
{

    string userName = GuestBookMethods.AskUsersName();
    guestNames.Add(userName);

    do
    {
        Console.Write("How many are in your party: ");
        string numValue = Console.ReadLine();
        isValidNum = int.TryParse(numValue, out int num);
        if (isValidNum)
        {
            guestCount += num;
        }
        else
        {
            Console.WriteLine("That is not a valid number! Try again.");
        } 
    } while (!isValidNum);
    
    Console.Write("Enter another party? (y/n): ");
    anotherParty = Console.ReadLine();

} while (anotherParty == "y");

Console.WriteLine();

foreach (var name in guestNames)
{
    Console.WriteLine(name);
}

Console.WriteLine();

Console.WriteLine(guestCount);







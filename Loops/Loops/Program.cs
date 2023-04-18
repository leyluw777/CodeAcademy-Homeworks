string username = "admin";
string password = "123";
string input_username = "";
string input_password = "";

do
{
    Console.WriteLine("Type your username: ");
    input_username = Console.ReadLine();

    Console.WriteLine("Type your password: ");
    input_password = Console.ReadLine();
}
while (input_password != password || input_username != username);
Console.WriteLine("You have successfully logged in your profile!");
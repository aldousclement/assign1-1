using System;

class Program
{
    static void Main()
    {
        string username, password;
        int attempts = 3;

        do
        {
            Console.Write("Enter username: ");
            username = Console.ReadLine();

            Console.Write("Enter password: ");
            password = Console.ReadLine();

            if (username == "Admin" && password == "Admin1234!")
            {
                Console.WriteLine("Login succesful!");
                break; 
            }
            else
            {
                Console.WriteLine("Incorrect credentials. Attempts left: " + --attempts);
            }
        } while (attempts > 0);

        if (attempts  == 0)
        {
            Console.WriteLine("Maximum attempts reached. Login failed");
        }
    }
}
namespace classencapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("inara   ", "   ahmadova", "inara123");
            user.ChangePassword("Sabir123", "uliyev123");

            Console.WriteLine(user.UserName);
        }
    }
}




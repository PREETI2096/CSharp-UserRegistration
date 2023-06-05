namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program");
            UserValidation userValidation = new UserValidation();
            userValidation.ValidateMobileNumber();
        }
    }
}
namespace GA_Variables_And_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myFirstName = "Your First Name";
            string myLastName = "Your Last Name";
            string myFullName = myFirstName + " " + myLastName;
            Console.WriteLine(myFullName);

            // New Code
            // Reassigning my teachers name to myFirstName
            myFirstName = "William";
            // Reassigning my teachers name to myLastName
            myLastName = "Cram";
            // Adding another string to myFullNamem
            myFullName = myFirstName + " " + myLastName + " is my professor";
            // Displaying the result
            Console.WriteLine(myFullName);
        }
    }
}

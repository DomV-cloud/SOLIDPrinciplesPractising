namespace SOLIDPrinciplesPractising.UNSOLID.SRP
{
    /// <summary>
    /// Single Responsibility Principle (SRP)
    /// </summary>
    public class UserManager
    {
        public void AddUser(string username, string password)
        {
            // Logic for adding user
            Console.WriteLine("User is added.");

            // Save user to database
            SaveToDatabase(username, password);
        }

        private void SaveToDatabase(string username, string password)
        {
            // Locig for saving the user to the database
            Console.WriteLine("User is stored in database.");
        }
    }
}

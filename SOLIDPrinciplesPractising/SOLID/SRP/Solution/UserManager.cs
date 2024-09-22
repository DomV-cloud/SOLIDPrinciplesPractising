namespace SOLIDPrinciplesPractising.SOLID.SRP.Solution
{
    public class UserManager
    {
        private readonly IDatabaseService _databaseService;

        public UserManager(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public void AddUser(string username, string password)
        {
            if (!ValidateUser(username, password))
            {
                Console.WriteLine("User validation failed");
            }

            _databaseService.SaveToDatabase(username, password);
        }
        
        private bool ValidateUser(string username, string password)
        {
            var userIsOkay = !String.IsNullOrEmpty(username) && !String.IsNullOrEmpty(password);

            return userIsOkay;
        }
    }

    public class DatabaseService : IDatabaseService
    {
        public void SaveToDatabase(string username, string password)
        {
            Console.WriteLine("User is stored in database.");
        }
    }

    public interface IDatabaseService
    {
        public void SaveToDatabase(string username, string password);
    }
}

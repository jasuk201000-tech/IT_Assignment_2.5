using IT_Assessment_2.CSVs;

namespace IT_Assignment_2.Helpers
{
    public static class SessionManager
    {
        public static CsvHelper.Staff CurrentUser { get; set; }

        public static bool IsLoggedIn => CurrentUser != null;
        public static bool IsAdmin => CurrentUser?.Role == "Admin";
        public static bool IsManager => CurrentUser?.Role == "Manager" || CurrentUser?.Role == "Admin";
        public static bool IsCashier => CurrentUser?.Role == "Cashier";

        public static void Login(CsvHelper.Staff user)
        {
            CurrentUser = user;
        }

        public static void Logout()
        {
            CurrentUser = null;
        }
    }
}
using IT_Assessment_2.CSVs;
using static IT_Assessment_2.Models.Staff;

namespace IT_Assignment_2.Helpers
{
    public static class SessionManager
    {
        public static CsvHelper.Staff CurrentUser { get; set; }

        public static bool IsLoggedIn => CurrentUser != null;
        public static bool IsAdmin => CurrentUser?.Role == UserRole.Admin;
        public static bool IsManager => CurrentUser?.Role == UserRole.Manager
                                      || CurrentUser?.Role == UserRole.Admin;
        public static bool IsCashier => CurrentUser?.Role == UserRole.Cashier;

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
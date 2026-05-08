using IT_Assessment_2.Models;
using static IT_Assessment_2.Models.Staff;

namespace IT_Assignment_2.Helpers
{

    public static class SessionManager
    {
        public static Staff CurrentUser { get; private set; }
        public static bool IsLoggedIn => CurrentUser != null;
        public static bool IsAdmin => CurrentUser?.Role == UserRole.Admin;
        public static bool IsManager => CurrentUser?.Role >= UserRole.Manager;
        public static bool IsCashier => CurrentUser?.Role == UserRole.Cashier;

        public static void Login(Staff user)
        {
            CurrentUser = user;
        }

        public static void Logout()
        {
            CurrentUser = null;
        }
    }
}
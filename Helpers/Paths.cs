using System.IO;
using System.Windows.Forms;
using IT_Assessment_2.CSVs;

namespace IT_Assignment_2.Helpers
{
    public static class Paths
    {
        public static string DataDir => Path.Combine(Application.StartupPath, "CSVs"); 
        public static string Staff => Path.Combine(DataDir, "staff.csv");
        public static string Products => Path.Combine(DataDir, "products.csv");
        public static string Variants => Path.Combine(DataDir, "variants.csv");
        public static string Categories => Path.Combine(DataDir, "categories.csv");
        public static string Orders => Path.Combine(DataDir, "orders.csv");
        public static string OrderItems => Path.Combine(DataDir, "order_items.csv");
    }
}

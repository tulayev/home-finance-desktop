using System.Configuration;

namespace PersonalFinanceApp.Data
{
    public static class Helper
    {
        public static string GetConString() => ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
    }
}

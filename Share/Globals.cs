using System;

namespace Share
{
    public static class Globals
    {
        public static string[] CommandLineVars = new string[5];
        public static string ServerAddress { get; set; } = string.Empty;
        public static string DbName { get; set; } = string.Empty;
        public static string UserName { get; set; } = "User_Linkserver";
        public static string Password { get; set; } = "4105986";
        public static string CompanyName { get; set; }  = string.Empty;
        public static string Today { get; set; } = string.Empty;
        public static string SignId { get; set; } = string.Empty;



    }
}

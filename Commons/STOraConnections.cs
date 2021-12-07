using System;

namespace Commons
{
    /// <summary>
    /// Class Connection
    /// </summary>
    public class STConnections
    {
        private static string _Server;

        private static string _Database;

        private static string _Username;

        private static string _Password;

        public static string CNStr
        {
            get
            {
                return string.Concat(new string[] { "Server=", _Server, ";database=", _Database, ";uid=", _Username, ";pwd=", _Password, ";Connect Timeout=9999;" });
            }
        }

        public static string Database
        {
            get
            {
                return IConnections._Database;
            }
            set
            {
                IConnections._Database = value;
            }
        }

        public static string Password
        {
            get
            {
                return IConnections._Password;
            }
            set
            {
                IConnections._Password = value;
            }
        }

        public static string Server
        {
            get
            {
                return IConnections._Server;
            }
            set
            {
                IConnections._Server = value;
            }
        }

        public static string Username
        {
            get
            {
                return IConnections._Username;
            }
            set
            {
                IConnections._Username = value;
            }
        }

        public IConnections()
        {
        }
    }
}
using System.Collections.Generic;
//using Dapper;
using System.Configuration;
using TrackerLibrary.DataAccess;


namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections(DatabaseType db)
        {
            if (db == DatabaseType.Sql)
            {
                /*TODO - Set up the SQL connector properly */
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }

            if (db == DatabaseType.TextFile)
            {

                /*TODO - Create Text Connection*/
                TextConnector text = new TextConnector();
                Connections.Add(text);

            }

        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}

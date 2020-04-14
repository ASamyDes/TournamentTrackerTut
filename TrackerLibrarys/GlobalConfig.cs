using System.Collections.Generic;
//using Dapper;
using System.Configuration;
using TrackerLibrary.DataAccess;
using System.Text;
using System.Threading.Tasks;
using System;


namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; } 

        public static void InitializeConnections(DatabaseType db)
        {


            if (db == DatabaseType.Sql)
            {
                /*TODO - Set up the SQL connector properly */
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }

            if (db == DatabaseType.TextFile)
            {

                /*TODO - Create Text Connection*/
                TextConnector text = new TextConnector();
                Connection = text;

            }

        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;
using TrackerLibrary;
//using Dapper;
using System.Configuration;


namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database)
            {
                /*TODO - Set up the SQL connector properly */
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }

            if (textFiles)
            {

                /*TODO - Create Text Connection*/
                TextConnector text = new TextConnector();
                Connections.Add(text);

            }
     
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager
        }
    }
}

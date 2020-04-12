using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    class SqlConnector : IDataConnection
    {
        //TODO - Make the CreatePrize method actually save to the database
        /// <summary>
        /// Saves a prize to the database
        /// </summary>
        /// <param name="model"> the prize information</param>
        /// <returns> the prize information including the unique identifier(ID)</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.id = 1;
            return model;
        }
    }
}

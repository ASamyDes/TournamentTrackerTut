using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;
using System.Collections.Generic;
using System.Linq;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {


        private const string PrizesFile = "PrizeModels.csv";

        //TODO - Wire up the createprize for text Files.
        public PrizeModel CreatePrize(PrizeModel model)
        {
            /* * load the text file
             * convert the text to List<prizemodel>*/
            List<PrizeModel> prizes =  PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            //int currentId = prizes.OrderByDescending(x => x.id).First().id + 1;
            int currentId = 1;

            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.id).First().id + 1;
            }
            model.id = currentId;

            prizes.Add(model);

            //Convert list 

            prizes.SaveToPrizeFile(PrizesFile);

            return model;
        }
    }
}


/*
 * load the text file
 * convert the text to List<prizemodel>
 * find the ID
 * add the new record with the new ID (max + 1)
 * convert the prizes to List<string>
 * save the list<string> to the Text file
 */

using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;
using System.Collections.Generic;
using System.Linq;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {


        private const string PrizesFile = "PrizeModels.csv";
        private const string PeopleFile = "PersonModels.csv";
        private const string TeamFile = "TeamsModels.csv";


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
        public PersonModel CreatePerson(PersonModel model)
        {
            List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

            int currentId = 1;
            if (people.Count > 0)
            {
                currentId = people.OrderByDescending(x => x.id).First().id + 1;
            }
            model.id = currentId;

            people.Add(model);

            people.SaveToPersonsModel(PeopleFile);

            return model;
        }

        public List<PersonModel> GetPerson_All()
        {
            return PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            List<TeamModel> teams = TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(PeopleFile);

            int currentId = 1;
            if (teams.Count > 0)
            {
                currentId = teams.OrderByDescending(x => x.id).First().id + 1;
            }
            model.id = currentId;

            teams.Add(model);
            teams.SaveToTeamFile(TeamFile);

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";
        private const string PeopleFile = "PersonModels.csv";
        private const string TeamFile = "TeamModels.csv";
        private const string TournamnetFile = "TournamnetModels.csv";
        private const string MatchupFile = "MatchupModels.csv";
        private const string MatchupEntryFile = "MatchupEntryModel.csv";

        public PersonModel CreatePerson(PersonModel model)
        {
            List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
            int currentId = 1;
            if (people.Count > 0)
            {
                currentId = people.OrderByDescending(x => x.Id).First().Id + 1;

            }
            model.Id = currentId;
            people.Add(model);
            people.SaveToPeopleFile();
            return model;
        }
 
        public PrizeModel CreatePrize(PrizeModel model)
        {
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();//Load the text file & Convert the text to List<PrizeModel>

            int currentId = 1;
            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1; //Find the max ID
            }
            model.Id = currentId;
            prizes.Add(model); //Add the new record with the new ID
            //Convert the prizes to list<string>
            //Save the list<string> to the text file
            prizes.SaveToPrizeFile();
            return model;
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            List<TeamModel> teams = TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();
            int currentId = 1;
            if (teams.Count > 0)
            {
                currentId = teams.OrderByDescending(x => x.Id).First().Id + 1; //Find the max ID
            }
            model.Id = currentId;
            teams.Add(model);

            teams.SaveToTeamFile();
            return model;

        }

        public List<PersonModel> GetPerson_All()
        {
            return PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
        }

        public List<TeamModel> GetTeam_All()
        {
            return TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();
        }

        public void CreateTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = TournamnetFile
                .FullFilePath()
                .LoadFile()
                .ConvertToTournamentModels();

            int currentId = 1;
            if (tournaments.Count > 0)
            {
                currentId = tournaments.OrderByDescending(x => x.Id).First().Id + 1; //Find the max ID
            }

            model.Id = currentId;

            model.SaveRoundsToFile();

            tournaments.Add(model);

            tournaments.SaveToTournamentFie();
        }

        public List<TournamentModel> GetTournament_All()
        {
            return TournamnetFile
                .FullFilePath()
                .LoadFile()
                .ConvertToTournamentModels();
        }
    }
}

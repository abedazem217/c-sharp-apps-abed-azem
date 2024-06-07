using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_abed_azem.SportApp
{
    public  class Season
    {
        private int year;
        private string SportType;
        private string league;
        private Round[] roundsAmount;
        private Round nextRound;
        private Team[] teamsAmount;
        private int teamNumber;
        private bool stillActive;

        public Season(int year, string SportType, string league, Team[] teamsAmount)
        {
            this.year = year;
            this.SportType = SportType;
            this.league = league;
            this.teamsAmount = teamsAmount;
        }
            


        public void DisplayTable()
        {
            foreach (Team t in teamsAmount)
            {
                Console.WriteLine("the team name:"+t.getName()+" ==== "+"the team points: " + t.getPoints());
            }
        }

    }
}

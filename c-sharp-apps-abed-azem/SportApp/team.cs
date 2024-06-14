using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_abed_azem.SportApp
{
    public class Team
    {
        private string Name;
        private string City;
        private string league;
        private int GamesNum;
        private int GamesPlayed;
        private int wins;
        private int loses;
        private int draws;
        private double Points;
        private int goalsFor;
        private int goalsAgains;
        private int goalsDifferential;
        private string v;

        public Team(string v)
        {
            this.v = v;
        }

        public Team(string Name, string City)
        {
            this.Name = Name;
            this.City = City;
            

        }

        public string getName()
        {
            return Name;
        }

        public double getPoints()
        {
            return Points;
        }
    }


    
}



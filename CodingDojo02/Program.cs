using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo02
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public interface ScoreKeeper
    {
        void scoreTeamA1();
        void scoreTeamA2();
        void scoreTeamA3();
        void scoreTeamB1();
        void scoreTeamB2();
        void scoreTeamB3();
        String getScore();
    }

    public class ScorersTable : ScoreKeeper
    {

        private int teamAScore;

        public string getScore()
        {
            return "00" + teamAScore + ":000";
        }

        public void scoreTeamA1()
        {
            teamAScore += 1;
        }

        public void scoreTeamA2()
        {
            teamAScore += 2;
        }

        public void scoreTeamA3()
        {
            throw new NotImplementedException();
        }

        public void scoreTeamB1()
        {
            throw new NotImplementedException();
        }

        public void scoreTeamB2()
        {
            throw new NotImplementedException();
        }

        public void scoreTeamB3()
        {
            throw new NotImplementedException();
        }
    }
}

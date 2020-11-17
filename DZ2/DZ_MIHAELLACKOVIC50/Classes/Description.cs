using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Description
    {
        private int numOfEpisodes;
        private TimeSpan lengthOfEpisodes;
        private string nameOfEpisodes;


        public int NUMOFEPISODES { get => numOfEpisodes; set => numOfEpisodes = value; }
        public TimeSpan LENGTHOFEPISODES { get => lengthOfEpisodes; set => lengthOfEpisodes = value; }
        public string NAMEOFEPISODES { get => nameOfEpisodes; set => nameOfEpisodes = value; }

        public Description(int aNumOfEpisodes, TimeSpan aLengthofEpisodes, string aNameOfEpisodes)
        {
            numOfEpisodes = aNumOfEpisodes;
            lengthOfEpisodes = aLengthofEpisodes;
            nameOfEpisodes = aNameOfEpisodes;
        }



    }
}
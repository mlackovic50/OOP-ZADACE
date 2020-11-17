using System;

namespace Classes
{
    public class Episode
    {
        public Description description;
        public int viewers;
        public double sumOfRatings;
        public double maximumRating;
        public TimeSpan lengthOfEpisodes;
        double max = 0;

        public Episode(int aViewers, double aSumOfRatings, double aMaximumRating, Description aDescription)
        {
            viewers = aViewers;
            sumOfRatings = aSumOfRatings;
            maximumRating = aMaximumRating;
            description = aDescription;
        }

        public Episode(int aViewers, double aSumOfRatings, double aMaximumRating)
        {
            viewers = aViewers;
            sumOfRatings = aSumOfRatings;
            maximumRating = aMaximumRating;
        }

        public Episode()
        {
            viewers = 0;
        }

        public void AddView(double aScore)
        {
            double score = aScore;
            sumOfRatings += score;
            if (score > max)
            {
                max = score;
            }
        }
        public double GetMaxScore()
        {
            return max;
        }

        public double GetAverageScore()
        {
            return sumOfRatings / viewers;
        }


        public double GetViewerCount()
        {
            return 10;
        }
        public override string ToString()
        {
            return $"{viewers},{sumOfRatings},{maximumRating},{description};
        }
    }
}
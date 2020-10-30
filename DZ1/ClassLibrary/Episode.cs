using System;

namespace ClassLibrary
{
    public class Episode
        {
            public int viewers;
            public double sumOfRatings;
            public double maximumRating = 0;

            public Episode()
            {
            }

            public Episode(int aViewers, double aSumOfRatings, double aMaximumRating)
            {
                viewers = aViewers;
                sumOfRatings = aSumOfRatings;
                maximumRating = aMaximumRating;
            }
            public void AddView(double aRandomRating)
            {
                double randomRating = aRandomRating;
                sumOfRatings += randomRating;
                if (randomRating > maximumRating)
                {
                    maximumRating = randomRating;
                }
            }
            public double GetAverageScore()
            {
                return sumOfRatings / viewers;
            }
            public double GetMaxScore()
            {
                return maximumRating;
            }
            public double GetViewerCount()
            {
                viewers = 10;
                return viewers;

            }
        }
}

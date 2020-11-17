using System;
using System.Collections.Generic;
using System.Text;
namespace Classes
{
    public class TvUtilities
    {
        double GenerateRandomScore()
        {
            Random random = new Random();
            return random.NextDouble() * (10.0);
        }
    }
    public Episode Parse(string[] ep)
    {
        ep = ep.Split(',');
        int viewers = int.Parse(ep[0]);
        double sumOfRatings = double.Parse(ep[1]);
        double maximumRating = double.Parse(ep[2]);
        int episodeNumber = int.Parse(ep[3]);
        TimeSpan episodeLength = TimeSpan.Parse(ep[4]);
        string episodeName = ep[5];
        Description description = new Description(episodeNumber, episodeLength, episodeName);
        Episode ep0 = new Episode(viewers, sumOfRatings, maximumRating, description);
        return ep0;
    }
    public void Sort(Episode[] ep)
    {
        Episode ep = new Episode();
        int i, j, temp;
        for (i = 0; i < ep.lengthOfEpisodes - 1; i++)
        {
            for (j = 0; j < ep.lengthOfEpisodes - i - 1; j++)
            {
                if (ep[j] > ep[j + 1])
                {
                    temp = ep[j];
                    ep[j] = ep[j + 1];
                    ep[j + 1] = temp;
                }
            }
        }
    }
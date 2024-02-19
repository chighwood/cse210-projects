using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Video video1 = new Video("Mercedes VS BMW: Which is the greater brand? ", "CARWOW", 720);
        video1.AddComment("Commenter1", "BMW is sooooo much better than that other junk!");
        video1.AddComment("Commenter2", "I feel that neither are bettera and you should just buy a japanese made vehicle.");
        video1.AddComment("Commenter3", "Mercedes are more comfortable in my opinion but BMW's are more fun to drive");


        Video video2 = new Video("5 hour Fireplace ", "RelaxingSounds", 480);
        video2.AddComment("Commenter4", "So soothing and relaxing!");
        video2.AddComment("Commenter5", "I like listening to this when I read a book of the couch.");
        video2.AddComment("Commenter6", "It's a good background noise when I'm doing my work.");


        Video video3 = new Video("One night camping in the woods when it's snowing", "BushcraftMan", 950);
        video3.AddComment("Commenter7", "Love hearing the nature and the wind in the trees!");
        video3.AddComment("Commenter8", "Watching these videos helps me settle down for the night. So relaxing.");
        video3.AddComment("Commenter9", "I LOVE that you do this! Keep up the great work.");


        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);


        foreach (var video in videos) 
        {
            video.DisplayVideoInfo();
        }
    }
}

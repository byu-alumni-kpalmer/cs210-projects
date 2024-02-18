using System;
using System.Collections.Generic;

namespace YouTubeTrackVids
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Video> videos = new List<Video>
            {
                new Video("Sucking blood", "Marie", 900),
                new Video("The Love of Christ", "Keith Palmer", 940),
                new Video("Hell is not a joke, Jesus", 500),
                new Video("Vampire 2", "Palmer", 7400)
            
            };

            videos[0].AddComment("Nice lesson", "I enjoyed it, much love!");
            videos[0].AddComment("that was amazing", "Very helpful, very accurate.");
            videos[0].AddComment("thanks for the video", "Love the content, bring new for us!");
            videos[0].AddComment("gud stuff", "yayyy, thanks!");
            videos[0].AddComment("una gatita", " que le gusto, el manbo");
            videos[0].AddComment("Baseball tomorrow", "H****t, ");
            videos[0].AddComment("my Homie", "Dang it is dope!, ");

            videos[1].AddComment("good stuff", "dude, cool.");
            videos[1].AddComment("you hommie", "I hear you!");
            videos[1].AddComment("wow", "save it to my pc.");
            videos[1].AddComment("aya99y", "cool  teacher ty.");
            


            videos[2].AddComment("Jews", "course is amazing, lots of info.");
            videos[2].AddComment("Fire on earth", "keep up the good works, thank you!");
            videos[2].AddComment("roger", "bring some more like this please.");
            videos[2].AddComment("master", "You the man.");
            videos[2].AddComment("Palmer", "so you've made my day.");

            videos[3].AddComment("Diamond course", "thousand stars.");
            videos[3].AddComment("sssss", "nice, hmm");
            videos[3].AddComment("save it", "more, please ");
            videos[3].AddComment("Wow", "Thanks bro, I appreciate you ");
            videos[3].AddComment("incredible", "You are the best, ");
            videos[3].AddComment("Want ", "Pilgrims, ");

            foreach (Video video in videos)
            {

                video.DisplayInfo();
            }
        }
    }
}
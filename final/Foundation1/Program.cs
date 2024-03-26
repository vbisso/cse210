using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("FOUNDATION 1:\n");
        List<Video> _videos = new List<Video>();
        Video video1 = new Video("Exploring Hidden Gems in Tokyo","TravelJunkieAdventures",720,new List<Comments>());
        Comments comment1 = new Comments("TravelEnthusiast23","Wow, I've been to Tokyo before but never knew about these places! Adding them to my list for next time.");
        Comments comment2 = new Comments("WanderlustAdventures","This video captures the essence of Tokyo perfectly! Makes me miss the bustling streets and vibrant culture.");
        Comments comment3 = new Comments("TokyoLocalGuide","As a Tokyo local, I can confirm these are indeed some hidden gems! Thanks for showcasing them to the world.");        
        video1._comments.Add(comment1); 
        video1._comments.Add(comment2);
        video1._comments.Add(comment3);
        _videos.Add(video1);

        Video video2 = new Video("Cooking Authentic Italian Pasta Carbonara","ChefGustoCooking",480,new List<Comments>());
        Comments comment4 = new Comments("FoodieFanatic101","My mouth is watering just watching this! Definitely trying out this recipe for dinner tonight.");
        Comments comment5 = new Comments("ItalianCuisineExpert","Finally, a carbonara recipe that sticks to the authentic ingredients and methods! Grazie for sharing.");
        Comments comment6 = new Comments("HungryFoodie22","I've tried making carbonara before but it never turns out quite right. Your step-by-step instructions are so helpful, thanks!");        
        video2._comments.Add(comment4); 
        video2._comments.Add(comment5);
        video2._comments.Add(comment6);
        _videos.Add(video2);

        Video video3 = new Video("Gaming Highlights: Epic Fortnite Wins Compilation","ProGamerX",600,new List<Comments>());
        Comments comment7 = new Comments("GamingProdigy123","These plays are insane! Makes me want to hop on Fortnite right now and try to pull off some of these moves.");
        Comments comment8 = new Comments("VictoryRoyaleMaster","That last clutch victory had me on the edge of my seat! Such intense gameplay, love it.");
        Comments comment9 = new Comments("CasualGamer99","Watching these highlights makes me realize how much I still need to improve. Great compilation though, very entertaining!");
        video3._comments.Add(comment7); 
        video3._comments.Add(comment8);
        video3._comments.Add(comment9);
        _videos.Add(video3);

        Video video4 = new Video("DIY Home Decor: Transforming Your Space on a Budget","CreativeCrafts101",840,new List<Comments>());
        Comments comment10 = new Comments("DecorEnthusiast56","I never knew decorating on a budget could look this good! Definitely trying out some of these ideas in my own home.");
        Comments comment11 = new Comments("DecorEnthusiast56","Thank you for sharing these creative and affordable DIY projects! Can't wait to give my space a makeover.");
        Comments comment12 = new Comments("HomeImprovementFanatic","These ideas are perfect for sprucing up my apartment without breaking the bank. Love the creativity!");
        video4._comments.Add(comment10); 
        video4._comments.Add(comment11);
        video4._comments.Add(comment12);
        _videos.Add(video4);

        foreach(Video video in _videos){
            video.DisplayVideoInfo();
        }
    }
}
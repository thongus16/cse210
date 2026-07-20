using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> vids = new List<Video>(); 

        List<Comment> coms1 = new List<Comment>();
        coms1.Add(new Comment("m.a.5450", "All of these characters deserve their own games"));
        coms1.Add(new Comment("roth7542", "Quake 3 and UT99 were so fun in their prime"));
        coms1.Add(new Comment("Firetruck", "Hunter with a lightning gun on nightmare is like a railgun."));
        Video vid1 = new Video("The Forgotten Lore of Quake 3's Characters", "Qc", 3428, coms1);
        vids.Add(vid1);

        List<Comment> coms2 = new List<Comment>();
        coms2.Add(new Comment("crass13", "hhhgregg"));
        coms2.Add(new Comment("dubbin", "panasonic bluray $99"));
        coms2.Add(new Comment("BrotherMan", "32-inch lcd tv only 299"));
        Video vid2 = new Video("Doing", "Terry", 213, coms2);
        vids.Add(vid2);

        List<Comment> coms3 = new List<Comment>();
        coms3.Add(new Comment("MMM666", "The zombies exploding in a square was a work of art."));
        coms3.Add(new Comment("redcar_", "Babe, wake up, a new yellow Becinor video just dropped."));
        coms3.Add(new Comment("GusKhan", "That Archie on the thumbnail honestly looks like he's chilling over a bonfire"));
        Video vid3 = new Video("Explosions", "becinor", 837, coms3);
        vids.Add(vid3);

        foreach (Video v in vids)
        {
            v.GetString();
            Console.WriteLine($"Number of Comments: {v.GetNumComments()}");
            v.GetComments();
            Console.WriteLine();
        }
    }
}
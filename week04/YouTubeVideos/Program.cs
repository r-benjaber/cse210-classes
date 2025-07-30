using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Video vid1 = new Video("MrBeast", "Staying 100 days in an Island", 1327);
        Comment com1v1 = new Comment("MrYolo54", "Wow that video is amazing");
        vid1.AddComment(com1v1);
        Comment com2v1 = new Comment("WowFantastic2", "I think this is too much");
        vid1.AddComment(com2v1);
        Comment com3v1 = new Comment("RonaldCliff1", "W");
        vid1.AddComment(com3v1);
        vid1.DisplayAll();

        Video vid2 = new Video("Mark Rober", "Building a chess robot", 893);
        Comment com1v2 = new Comment("Julian Alvarenga", "I want to learn how to play chess just to use this Robot");
        vid2.AddComment(com1v2);
        Comment com2v2 = new Comment("KrostixM", "Wow, I wonder how Mark knows too much");
        vid2.AddComment(com2v2);
        Comment com3v2 = new Comment("xXGrannyRooster420Xx", "This is a generic hate comment");
        vid2.AddComment(com3v2);
        Comment com4v2 = new Comment("KittenLover777", "5:13 Isn't that AirRack in the background?");
        vid2.AddComment(com4v2);
        vid2.DisplayAll();

        Video vid3 = new Video("AirRack", "Sneaking into Area 51", 1217);
        Comment com1v3 = new Comment("DungeonMasterMississipi", "Ima wa Area 51 no naka ni Arien ni iru");
        vid3.AddComment(com1v3);
        Comment com2v3 = new Comment("YoutubeFails23", "How in the world is he allowed to do that");
        vid3.AddComment(com2v3);
        Comment com3v3 = new Comment("Mark Rober", "You gotta pay bro");
        vid3.AddComment(com3v3);
        vid3.DisplayAll();
    }
}
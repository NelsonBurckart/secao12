using System;
using Course122.Entities;

namespace Course122 {
    class Program {
        static void Main(string[] args) {
            Comment c1 = new Comment("Have a nice trip.");
            Comment c2 = new Comment("Uau!");
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:13:13"),
                "Travelling to",
                "I am to visit",
                12);
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Have a nice trip3.");
            Comment c4 = new Comment("Uau!3");
            Post p2 = new Post(
                DateTime.Parse("21/06/2018 13:13:13"),
                "Travelling to",
                "I am to visit",
                12);
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}

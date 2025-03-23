using System;

namespace tpmodul6_103022300101
{
    class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design by Contract - Deru Khairan Djuharianto");
            video.PrintVideoDetails();
            Console.WriteLine();
            video.IncreasePlayCount(777777777);
            video.PrintVideoDetails();
        }
    }
}
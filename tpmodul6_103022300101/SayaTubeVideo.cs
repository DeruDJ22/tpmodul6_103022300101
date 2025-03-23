using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_103022300101
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;
        Random ran = new Random();

        public SayaTubeVideo(string title)
        {
            this.id = ran.Next(1000,9999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            this.playCount += count;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Judul: {title}");
            Console.WriteLine($"Jumlah diputar: {playCount}");
        }
    }
}

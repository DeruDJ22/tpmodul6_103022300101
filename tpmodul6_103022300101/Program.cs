using System;

namespace tpmodul6_103022300101
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Membuat objek video dengan judul tertentu
                SayaTubeVideo video = new SayaTubeVideo("Tutorial Design by Contract - Deru Khairan Djuharianto");
                video.PrintVideoDetails();
                Console.WriteLine();

                // Loop untuk menambah play count secara bertahap
                for (int i = 0; i < 1000; i++)
                {
                    video.IncreasePlayCount(7777777);
                    video.PrintVideoDetails();
                    Console.WriteLine();

                    // Hentikan jika playCount sudah mencapai batas maksimum int
                    if (video.getPlayCount() == int.MaxValue)
                    {
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                // Tangkap dan tampilkan error jika terjadi
                Console.WriteLine($"Error! {e.Message}");
            }
        }
    }
}

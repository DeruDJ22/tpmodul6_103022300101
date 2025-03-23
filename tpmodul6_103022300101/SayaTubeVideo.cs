using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace tpmodul6_103022300101
{
    class SayaTubeVideo
    {
        private int id;          // ID unik untuk video
        private string title;    // Judul video
        private int playCount;   // Jumlah pemutaran video
        Random ran = new Random(); // Objek untuk menghasilkan ID acak

        // Constructor untuk inisialisasi video
        public SayaTubeVideo(string title)
        {
            // Debug.Assert untuk validasi input (Design by Contract)
            Debug.Assert(title != null, "Judul tidak boleh kosong");
            Debug.Assert(title.Length <= 100, "Judul tidak boleh lebih dari 100 karakter");

            this.id = ran.Next(1000, 9999); // Generate ID acak
            this.title = title;
            this.playCount = 0; // Awalnya playCount = 0
        }

        // Menambah jumlah playCount dengan batas maksimal
        public void IncreasePlayCount(int count)
        {
            Debug.Assert(count <= 10000000, "Maksimal peningkatan play count adalah 10 juta");

            try
            {
                checked // Mendeteksi overflow
                {
                    if (this.playCount > int.MaxValue - count)
                    {
                        throw new OverflowException();
                    }
                    this.playCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error! Sudah mencapai batas maksimum play count");
                this.playCount = int.MaxValue; // Set ke nilai maksimal int
            }
        }

        // Menampilkan detail video ke console
        public void PrintVideoDetails()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Judul: {title}");
            Console.WriteLine($"Jumlah diputar: {playCount}");
        }

        // Getter untuk playCount
        public int getPlayCount()
        {
            return this.playCount;
        }
    }
}

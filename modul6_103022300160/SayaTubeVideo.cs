using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300160
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            this.title = title;
            this.playCount = 0;

            Random rand = new Random();
            this.id = rand.Next(10000, 99999);
        }

        public void IncreasePlayCount(int jumlah)
        {
            Debug.Assert(title != null, "judul video tidak boleh null");
            Debug.Assert(jumlah > 0, "Jumlah play count harus lebih dari 0");
            Debug.Assert(playCount + jumlah <= 25000000, "play count maksimal 25.000.000");
            try
            {
                checked
                {
                    if (jumlah < 0) throw new ArgumentException("Jumlah tidak boleh negatif");
                    if (playCount + jumlah > 25000000) throw new ArgumentException("play count melebihi batas maksimal");
                    playCount += jumlah;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("error : play vount overflow")
            }
            catch(Exception e)
            {
                Console.WriteLine("error: " + e.Message)
            }
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine(" Id: " + id);
            Console.WriteLine(" Judul Video: " + title);
            Console.WriteLine(" Jumlah Putar: " + playCount);
        }
 
        public int getPlayCount()
        {
            return this.playCount;
        }
        public string getTitle()
        {
            return title;
        }
    }
}

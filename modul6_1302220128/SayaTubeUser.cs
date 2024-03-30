using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302220128
{
    public class SayaTubeUser
    {
        public int id;
        public List<SayaTubeVideo> uploadedvideo;
        public string Username;

        public SayaTubeUser(string username)
        {
            this.Username = username;
            this.uploadedvideo = new List<SayaTubeVideo>();
        }
        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            for (int i = 0; i < this.uploadedvideo.Count; i++)
            {
                total += this.uploadedvideo[i].GetPlayCount();
            }
            return total;
        }
        public void addVideo(SayaTubeVideo video)
        {
            this.uploadedvideo.Add(video);
        }
        public void PrintAllVideoCount()
        {
            for (int i = 0;i < this.uploadedvideo.Count;i++)
            {
                int j = i + 1;
                Console.WriteLine("User: " + this.Username + "\nVideo: " + j + "Judul: " + this.uploadedvideo[i].Title); ;
            }
        }

    }
}

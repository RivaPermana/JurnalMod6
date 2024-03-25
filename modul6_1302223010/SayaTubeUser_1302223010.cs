using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302223010
{
    internal class SayaTubeUser_1302223010
    {
        private int id;
        private List<SayaTubeVideo_1302223010> uploadVideos;
        string Username;
        private int playCount;
        private string title;

        public SayaTubeUser_1302223010(int id, List<SayaTubeVideo_1302223010> uploadVideos, string username)
        {
            Random ngacak = new Random();
            id = ngacak.Next(9999, 100001);
            this.uploadVideos = uploadVideos;
            this.Username = username;
        }

        public int GetPlayCount()
        {
            return playCount;
        }
        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            for (int i = 0; i < uploadVideos.Count; i++)
            {
                total = +uploadVideos[1].GetPlayCount();
            }
            return total;
        }

        public string GetTitle()
        {
            return title;
        }


        public void AddVideo(SayaTubeVideo_1302223010 video)
        {
            uploadVideos.Add(video);
        }

        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine($"User: {Username}");
            for(int i = 0;i < uploadVideos.Count; i++)
            {
                Console.WriteLine($"Video 1 judul: " + GetTitle());
            }
        }
    }
}

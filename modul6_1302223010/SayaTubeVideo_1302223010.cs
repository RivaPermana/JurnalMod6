using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302223010
{
    internal class SayaTubeVideo_1302223010
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo_1302223010(string title)
        {
            Random ngacak = new Random();
            id = ngacak.Next(9999, 100001);

            Debug.Assert(title.Length <= 100 && title != null);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            Contract.Requires(count > 0 && count <= 10000000, "Input penambahan play count max 10.000.000");
            Contract.Ensures(playCount <= int.MaxValue - count, "Penambahan play count melebihi batas max");

            try
            {
                checked
                {
                    playCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error; Play count melebihi batas max1 10.000.000");
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"Video ID: {id}");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Play Count {playCount}");
        }

        internal int GetPlayCount()
        {
            throw new NotImplementedException();
        }
    }
}

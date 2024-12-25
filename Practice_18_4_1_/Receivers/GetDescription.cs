using Practice_18_4_1_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace Practice_18_4_1_.Receivers
{
    internal class GetDescription : Ireceiver
    {
        string _url;
        public GetDescription(string url)
        {
            _url = url;
        }
        public async Task Operation()
        {
            var youtube = new YoutubeClient();
            var videoInfo = youtube.Videos.GetAsync(_url).Result;
            var title = videoInfo.Title;
            var duration = videoInfo.Duration.ToString();

            Console.WriteLine($"{title}, продолжительность - {duration}");
            Console.WriteLine();
        }
    }
}

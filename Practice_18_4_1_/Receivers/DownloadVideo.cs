using Practice_18_4_1_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace Practice_18_4_1_.Receivers
{
    internal class DownloadVideo : Ireceiver
    {
        string _url;
        public DownloadVideo(string url)
        {
            _url = url;
        }
        public async Task Operation()
        {
            Console.WriteLine("Ввведите путь сохранения видеоролика");
            string path = Console.ReadLine();
            Console.WriteLine("Скачивание начато");

            var youtube = new YoutubeClient();
            var video = await youtube.Videos.GetAsync(_url);
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(video.Id);
            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();

            if (streamInfo != null)
            {
                var fileName = $"{video.Title}.{streamInfo.Container}";
                var filePath = Path.Combine(path, fileName);

                await youtube.Videos.Streams.DownloadAsync(streamInfo, filePath);
            }
        }
    }
}

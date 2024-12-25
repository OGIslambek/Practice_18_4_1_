using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice_18_4_1_.Interfaces;

namespace Practice_18_4_1_.Commands
{
    internal class DownloadCommand : Icommand
    {
        Ireceiver download;

        public DownloadCommand(Ireceiver download)
        {
            this.download = download;
        }

        public async void Run()
        {
            await download.Operation();
            Console.WriteLine("Скачивание завершено");

        }
    }
}

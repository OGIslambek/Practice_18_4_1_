using Practice_18_4_1_.Commands;
using Practice_18_4_1_.Interfaces;
using Practice_18_4_1_.Receivers;

namespace Practice_18_4_1_
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите url видеоролика");
            string url = Console.ReadLine();


            User user = new User();
            Ireceiver getDescription = new GetDescription(url);
            user.SetCommand(new GetDescriptionCommand(getDescription));
            user.RunCommand();

            Ireceiver download = new DownloadVideo(url);
            user.SetCommand(new DownloadCommand(download));
            user.RunCommand();

            Console.ReadKey();
        }
    }
}

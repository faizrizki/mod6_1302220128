namespace modul6_1302220128
{    
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo video1 = new SayaTubeVideo("Tukang Bubur Naik Haji 1");
            SayaTubeVideo video2 = new SayaTubeVideo("Tukang Bubur Naik Haji 2");
            SayaTubeVideo video3 = new SayaTubeVideo("Tukang Bubur Naik Haji 3");
            SayaTubeVideo video4 = new SayaTubeVideo("Tukang Bubur Naik Haji 4");
            SayaTubeVideo video5 = new SayaTubeVideo("Tukang Bubur Naik Haji 5");
            SayaTubeVideo video6 = new SayaTubeVideo("Tukang Bubur Naik Haji 6");
            SayaTubeVideo video7 = new SayaTubeVideo("Tukang Bubur Naik Haji 7");
            SayaTubeVideo video8 = new SayaTubeVideo("Tukang Bubur Naik Haji 8");
            SayaTubeVideo video9 = new SayaTubeVideo("Tukang Bubur Naik Haji 9");
            SayaTubeVideo video10 = new SayaTubeVideo("Tukang Bubur Naik Haji 10");

            SayaTubeUser user1 = new SayaTubeUser("Muhammad Rizki");
            user1.addVideo(video1);
            user1.addVideo(video2);
            user1.addVideo(video3);
            user1.addVideo(video4);
            user1.addVideo(video5);
            user1.addVideo(video6);
            user1.addVideo(video7);
            user1.addVideo(video8);
            user1.addVideo(video9);
            user1.addVideo(video10);

            user1.PrintAllVideoCount();
        }
    }
}


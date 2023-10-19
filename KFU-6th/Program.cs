using System;

namespace KFU_6th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PopFestival popFestival = new PopFestival("Pop Fest 2023", "Москва", 2023, 10, 20, 19, 500, "MONETOCHKA") ;
            popFestival.GetFestiavalInfo();
            Console.WriteLine();
            popFestival.PerformFestival();
            Console.WriteLine();

            RapFestival rapFestival = new RapFestival("Rap Fest 2023", "Казань", 2024, 06, 1, 20, 2000, "Big Baby Tape");
            rapFestival.GetFestiavalInfo();
            Console.WriteLine();
            rapFestival.PerformFestival();
            Console.WriteLine();

            Artist artist = new Artist("Kizaru", "Россия", Genre.ХипХоп, 780);
            artist.Perform();
            artist.GetArtistInfo();
            artist.ReceivePayment(300000);
            Console.WriteLine();

            Song song = new Song("Jesus Walks", "Kanye West", Genre.ХипХоп, 3.19, 1234000);
            song.NowPlay();
            song.GetSongInfo();
            song.RemixSong();
            Console.WriteLine();

            Song anotherSong = new Song("Lully, Lulla, Lullay", "VOICE58", Genre.Класика, 4.35, 1302304);
            anotherSong.NowPlay();
            anotherSong.GetSongInfo();
            Console.WriteLine();

            Festival[] festivals = new Festival[2];
            festivals[0] = popFestival;
            festivals[1] = rapFestival;

            foreach (Festival festival in festivals)
            {
                festival.PerformFestival();
                Console.WriteLine();
            }
        }
    }
}

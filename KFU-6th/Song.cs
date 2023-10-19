using System;

namespace KFU_6th
{
    class Song
    {
        public string title;
        public string author;
        public Genre genre;
        public double duration;
        public uint listening;

        public Song(string title, string author, Genre genre, double duration, uint listening)
        {
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.duration = duration;
            this.listening = listening;
        }
        public void NowPlay()
        {
            Console.WriteLine($"Сейчас играет песня {title}. Исполнитель {author}");
        }
        public void GetSongInfo()
        {
            Console.WriteLine($"Песня: {title}\nИсполнитель: {author}\nЖанр: {genre}\nПродолжительность: {duration} минут\nКоличество прослушиваний: {listening}");
        }
        public void Listening()
        {
            listening++;
        }
        public void SetGenre(Genre genre)
        {
            this.genre = genre;
        }
        public void RemixSong()
        {
            Console.WriteLine($"Для песни {title} был выпущен новый ремикс.");
        }
    }
}

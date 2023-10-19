using System;

namespace KFU_6th
{
    enum Genre
    {
        Рок,
        Поп,
        ХипХоп,
        Джаз,
        Класика,
        Рэп
    }
    abstract class Festival
    {
        public string name;
        public string venue;
        public int year;
        public int month;
        public int day;
        private int startTime;

        public Festival(string name, string venue, int year, int month, int day, int startTime)
        {
            this.name = name;
            this.venue = venue;
            this.year = year;
            this.month = month;
            this.day = day;
            this.startTime = startTime;
        }

        protected Festival(string name, string venue)
        {
            this.name = name;
            this.venue = venue;
        }

        public void CancelFeastival()
        {
            Console.WriteLine($"Фестиваль '{name}' будет отменен.");
        }
        public void AnnounceDate()
        {
            Console.WriteLine($"Фестиваль '{name}' будет проведен {day}.{month}.{year}");
        }
        public void AnnounceTime()
        {
            Console.WriteLine($"Фестиваль '{name}' начнется в {startTime}");
        }
        public void SetDate(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }
        public void SetTime(int startTime)
        {
            this.startTime = startTime;
        }
        public void GetFestiavalInfo()
        {
            Console.WriteLine($"Название фестиваля: '{name}'\nДата проведения: {day}.{month}.{year}\nВремя начала: {startTime}\nМесто проведения: {venue}");
        }
        public abstract void PerformFestival();

    }
}

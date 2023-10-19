using System;

namespace KFU_6th
{
    class PopFestival : Festival
    {
        public int audienceCount;
        public string headliner;
        private int startTime;

        public PopFestival(string name, string venue, int year, int month, int day, int startTime, int audienceCount, string headliner) : base(name, venue, year, month, day, startTime)
        {
            this.audienceCount = audienceCount;
            this.headliner = headliner;
            this.startTime = startTime;
        }
        public PopFestival(string name, string venue, int audienceCount, string headliner) : base(name, venue)
        {
            this.audienceCount = audienceCount;
            this.headliner = headliner;
        }
        public override void PerformFestival()
        {
            Console.WriteLine($"Музыкальный поп фестиваль '{name}' пройдет в {venue}!\nДата проведения: {day}.{month}.{year}\nВремя начала: {startTime}\nХедлайнер: {headliner}\nКоличество зрителей/слушателей: {audienceCount}");
        }
    }
}

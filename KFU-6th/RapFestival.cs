using System;

namespace KFU_6th
{
    class RapFestival : Festival
    {
        public int bandCount;
        public string stage;
        private int startTime;
        public RapFestival(string name, string venue, int year, int month, int day, int startTime, int bandCount, string stage) : base(name, venue, year, month, day, startTime)
        {
            this.bandCount = bandCount;
            this.stage = stage;
            this.startTime = startTime;
        }
        public RapFestival(string name, string venue, int bandCount, string stage) : base(name, venue)
        {
            this.bandCount = bandCount;
            this.stage = stage;
        }
        public override void PerformFestival()
        {
            Console.WriteLine($"Музыкальный поп фестиваль '{name}' пройдет в {venue}!\nДата проведения: {day}.{month}.{year}\nВремя начала: {startTime}:00\nКоличество групп: {bandCount}\nCцена фестиваля: {stage}");
        }
    }
}

using System;

namespace KFU_6th
{
    class Artist
    {
        public string name;
        public string country;
        public Genre genre;
        public uint qtyOfPerformance;

        public Artist(string name, string country, Genre genre, uint qtyOfPerformance)
        {
            this.name = name;
            this.genre = genre;
            this.country = country;
            this.qtyOfPerformance = qtyOfPerformance;
        }
        public void ReceivePayment(double amount)
        {
            Console.WriteLine($"{name} заработал за выступление {amount}руб.");
        }
        public void AttendPressConference()
        {
            Console.WriteLine($"{name} принимает участвие в пресс-конференции.");
        }
        public void SignAutographs()
        {
            Console.WriteLine($"{name} будет раздавать автографы для фанатов.");
        }
        public void GetArtistInfo()
        {
            Console.WriteLine($"Имя артиста: {name}\nИз какой страны артист: {country}\nЖанр выступления: {genre}\nКоличество выступлений: {qtyOfPerformance}");
        }
        public void SetArtistNewInfo(Genre genre, uint qtyOfPerformance)
        {
            this.genre = genre;
            this.qtyOfPerformance = qtyOfPerformance;
        }
        public void Perform()
        {
            qtyOfPerformance++;
            Console.WriteLine($"{name} провел {genre} выступление!");
        }

    }
}

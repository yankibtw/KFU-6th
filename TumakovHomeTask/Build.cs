using System;

namespace TumakovHomeTask
{
    class Build
    {
        private static uint accountNumberSeed = 0;
        private uint ID;
        private double heightBuild;
        private uint numberOfFloors;
        private uint qtyOfApartments;
        private uint qtyOfEntrances;

        private uint GenerateID()
        {
            accountNumberSeed++;
            return accountNumberSeed;
        }
        public Build() { }
        public Build(double heightBuild, uint numberOfFloors, uint qtyOfApartments, uint qtyOfEntrances)
        {
            this.ID = GenerateID();
            this.heightBuild = heightBuild;
            this.numberOfFloors = numberOfFloors;
            this.qtyOfApartments = qtyOfApartments;
            this.qtyOfEntrances = qtyOfEntrances;
        }
        public void SetDataOfBuild(double heightBuild, uint numberOfFloors, uint qtyOfApartments, uint qtyOfEntrances)
        {
            ID = GenerateID();
            this.heightBuild = heightBuild;
            this.numberOfFloors = numberOfFloors;
            this.qtyOfApartments = qtyOfApartments;
            this.qtyOfEntrances = qtyOfEntrances;
        }
        public void GetInfoOfBuild()
        {
            Console.WriteLine($"Номер здания: {ID}\n" +
                $"Высота здания: {heightBuild}\n" +
                $"Количество этажей в здании: {numberOfFloors}\n" +
                $"Количество квартир в здании: {qtyOfApartments}\n" +
                $"Количество подъездов в здании: {qtyOfEntrances}");
        }
        public double CalculateHeighPerFloor()
        {
            return (heightBuild / numberOfFloors);
        }
        public uint? CalculateApartmentsPerEntrances()
        {
            if (qtyOfApartments % qtyOfEntrances == 0) return qtyOfApartments / qtyOfEntrances;
            else return null;
        }
        public uint? CalculateApartmentsPerFloors()
        {
            if (qtyOfApartments % numberOfFloors == 0) return qtyOfApartments / numberOfFloors;
            else return null;
        }
    }
}

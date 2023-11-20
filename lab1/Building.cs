using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Building
    {
        private int entrances;
        private int floors;
        private int apartmentsperfloor;
        private double price;

        public Building(int entrances, int floors, int apartmentsPerFloor, decimal squareMeterCost)
        {
            if (entrances <= 0 || floors <= 0 || apartmentsPerFloor <= 0 || squareMeterCost <= 0)
            {
                throw new ArgumentException("Невірне значення. Всі значення мають бути вищим за нуль.");
            }
        }

        public Building(int entrances, int floors, int apartmentsperfloor, double price)
        {
            this.entrances = entrances;
            this.floors = floors;
            this.apartmentsperfloor = apartmentsperfloor;
            this.price = price;
        }

        public int CalculateApartmentsInEntrance()
        {
            return floors * apartmentsperfloor;
        }

        public int CalculateTotalApartments()
        {
            return entrances * CalculateApartmentsInEntrance();
        }

        public double CalculateTotalCost()
        {
            int totalApartments = CalculateTotalApartments();
            return totalApartments * price;
        }
    }
}

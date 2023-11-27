using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Building
    {
        private int entrances;
        private int floors;
        private int apartmentsperfloor;
        private double price;
        private double area;

        public Building(int entrances, int floors, int apartmentsPerFloor, decimal price, double area)
        {
            if (entrances <= 0 || floors <= 0 || apartmentsPerFloor <= 0 || price <= 0 || area <= 0)
            {
                throw new ArgumentException("Невірне значення. Всі значення мають бути вищі за нуль.");
            }
        }
        public Building()
        {
            this.entrances = 0;
            this.floors = 0;
            this.apartmentsperfloor = 0;
            this.price = 0.0;
            this.area = 0.0;
        }

        public Building(int entrances, int floors, int apartmentsperfloor, double price, double area)
        {
            this.entrances = entrances;
            this.floors = floors;
            this.apartmentsperfloor = apartmentsperfloor;
            this.price = price;
            this.area = area;
        }

        public int CalculateApartmentsInEntrance()
        {
            return floors * apartmentsperfloor;
        }

        public int CalculateTotalApartments()
        {
            return entrances * CalculateApartmentsInEntrance();
        }

        public virtual double CalculateTotalCost()
        {
            int totalApartments = CalculateTotalApartments();
            return totalApartments * price;
        }
    }
    public class Apartment : Building
    {
        private string name;
        private double pricepermeter;
        private double area;

        public Apartment(string name, double pricepermeter, double area)
        {
            this.name = name;
            this.pricepermeter = pricepermeter;
            this.area = area;
        }
        public virtual double CalculateApartmentCost()
        {
            return area * pricepermeter;
        }
        public virtual string GetInfo()
        {
            return name;
        }
    }

    public class CentralApartment : Apartment
    {
        private string districtName;

        public CentralApartment(string name, double pricepermeter, double area, string districtName)
            : base(name,pricepermeter, area)
        {
            this.districtName = districtName;
        }

        public override double CalculateApartmentCost()
        {
            return base.CalculateApartmentCost() * 1.1;
        }
        public override string GetInfo()
        {
            return this.districtName;
        }
    }

}

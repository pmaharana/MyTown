using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTown
{
    public class Bank
    {
        public string Name { get; set; }
        public string BuildingType { get; set; }
        public int NumberOfRoom { get; set; }
        public string ConstructionMaterial { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public double MyProperty { get; set; }
        public double SquareFootage
        {
            get { return this.Width * this.Length; }

        }
        public int Floors { get; set; }
        public int Classrooms { get; set; }
        public int BathRooms { get; set; }
        public double Volume
        {
            get { return this.Width * this.Length * this.Height; }

        }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string FullAddress
        {
            get { return Address1 + Address2 + City + State + ZipCode; }

        }
        public int Occupants { get; set; }

        public void IncrementOccupants()
        {
            Occupants++;
        }
        public void DecrementOccupants()
        {
            Occupants--;
        }
        private double _amountofmoney;

        public double AmountOfMoney
        {
            get { return _amountofmoney; }
            
        }

        public void WithdrawMoney(double withdrawmoney)
        {
            withdrawmoney += _amountofmoney;
        }

        public void DepositMoney (double depositmoney)
        {
            depositmoney = -_amountofmoney;
        }
        public Bank (string bt)     //string for building type
        {
            this.BuildingType = bt;
        }
        public string DisplayName()
        {
            return this.Name;
        }
        public string TooString()
        {
            return $"{this.BuildingType} : {this.Name}";
        }
        public Bank()
        {

        }

    }
}

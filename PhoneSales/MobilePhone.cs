using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneSales
{
    //Mobile phone is a base class, we inherit applephone, androidphone and windowsphone from it
    public abstract class MobilePhone : IComparable
    {
        //Here we rate the condition of the mobiles
        public enum Condition
        {
            poor,
            fair,
            good,
            mint,
        };
        //variable declaration
        protected string make;
        protected string model;
        protected decimal originalPrice;
        protected string operatingSystem;
        protected DateTime datePurchase;
        protected DateTime dateManufactured;
        protected Condition condition;
        //constructor
        public MobilePhone (string make, string model,
            decimal originalPrice, string operatingSystem, DateTime datePurchase, Condition condition, DateTime dateManufactured)
        {
            this.make = make;
            this.model = model;
            this.originalPrice = originalPrice;
            this.datePurchase = datePurchase;
            this.condition = condition;
            this.dateManufactured = dateManufactured;
            this.operatingSystem = operatingSystem;
        }

        public MobilePhone(string make, string model, decimal originalPrice, string operatingSystem, Condition condition, DateTime datePurchase, DateTime dateManufactured)
        {
            this.make = make;
            this.model = model;
            this.originalPrice = originalPrice;
            this.operatingSystem = operatingSystem;
            this.condition = condition;
            this.datePurchase = datePurchase;
            this.dateManufactured = dateManufactured;
        }

        public MobilePhone(string make, string model, decimal originalPrice, string operatingSystem, Condition condition, DateTime datePurchase)
        {
            this.make = make;
            this.model = model;
            this.originalPrice = originalPrice;
            this.operatingSystem = operatingSystem;
            this.condition = condition;
            this.datePurchase = datePurchase;
        }
        //calculate the phones approximate age in years
        public int CalcualteApproximateAgeInYears()
        {
            DateTime now = DateTime.Now;
            TimeSpan ageAsTimeSpan = now.Subtract(dateManufactured);
            int ageInYears = ageAsTimeSpan.Days / 365; // note  this does not account for leap years so age is just approximate

            return ageInYears;
        }
        //this method will be implemeted in the class that is derived from this base class ie ApplePhone.cs
        public abstract decimal CalculateApproximateValue();

        public virtual string Description()
        {
            //Obtain a string describing the current mobile condition using the enum declaration above
            string conditionName = Enum.GetName(typeof(Condition), condition);
            //Creat a string describing current mobile
            string description = string.Format("Make: {0}{1}Model:{2}{3}Condition: {4}{5}OperatingSystem: {6}{7}originalPrice: {8:c}{9}Current Value:{10:c}",
                make,
                Environment.NewLine,
                model,
                Environment.NewLine,
                conditionName,
                Environment.NewLine,
                operatingSystem,
                Environment.NewLine,
                originalPrice,
                Environment.NewLine,
                CalculateApproximateValue());
            return description;
        }
        //Implement Icomparable for default sort order
        int IComparable.CompareTo(object obj)
        {
            MobilePhone otherMobilePhone = (MobilePhone)obj;
            decimal differenceInPrice = this.CalculateApproximateValue() -
                otherMobilePhone.CalculateApproximateValue();

            return Math.Sign(differenceInPrice);
        }

        public int CompareTo(object obj)
        {
            if (obj is MobilePhone)
            {
                MobilePhone otherMobilePhone = (MobilePhone)obj;
                return this.make.CompareTo(otherMobilePhone.make);
            }
            else
            {
                throw new ArgumentException("Object is not a MobilePhone");
            }
        }
    }
}

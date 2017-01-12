using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneSales
{
    //Stating that ApplePhone is a type of MobilePhone
    public class ApplePhone : MobilePhone
    {
        //Consturctor for ApplePhone class
        public ApplePhone(string make, string model,
            decimal originalPrice, string operatingSystem, DateTime datePurchase, Condition condition, DateTime dateManufactured)
            : base(make, model, originalPrice,operatingSystem, condition, datePurchase, dateManufactured)
        {
            //Constructor is empty as this class adds no new attributes
        }
        //This calcualtion below is overwritten in the different inheriting classes as the depreciation level varies by phone type
        public override decimal CalculateApproximateValue()
        {
            decimal value = 0;
            //here the phone value is modified in accordance to its condition
            if (condition == Condition.mint)
            {
                value = originalPrice * 0.9m; // ie 90% of original value
            }

            else if (condition == Condition.good)
            {
                value = originalPrice * 0.8m;
            }

            else if (condition == Condition.fair)
            {
                value = originalPrice * 0.7m;
            }

            else if (condition == Condition.poor)
            {
                value = originalPrice * 0.5m;
            }
            //Value also takes into account phones age
            int age = CalcualteApproximateAgeInYears();

            for (int i = 0; i < age; i++)
            {
                value = value * 0.9m;
            }

            value = Decimal.Round(value, 0); //round to nearest pound

            //value = value - (value % 100);

            value = value + 50; // then add £50
            return value;
        }
    }
}

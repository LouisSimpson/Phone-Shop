using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneSales
{
    //States windows phone is type of mobile phone
    public class WindowsPhone : MobilePhone
    {
        public WindowsPhone(string make, string model,
            decimal originalPrice, string operatingSystem, DateTime datePurchase, Condition condition, DateTime dateManufactured)
            : base(make, model, originalPrice, operatingSystem, condition, datePurchase, dateManufactured)
        {
            //constructor is empty as class adds no new attributes
        }
        //calculation is overwritten in accordance to phone manufacturer
        public override decimal CalculateApproximateValue()
        {
            decimal value = 0;
            //phone value is modified in accordance to its condition
            if (condition == Condition.mint)
            {
                value = originalPrice * 0.5m; //ie 50%
            }

            else if (condition == Condition.good)
            {
                value = originalPrice * 0.4m;
            }

            else if (condition == Condition.fair)
            {
                value = originalPrice * 0.3m;
            }

            else if (condition == Condition.poor)
            {
                value = originalPrice * 0.2m;
            }
            // phone age is also taken into consideration
            int age = CalcualteApproximateAgeInYears();

            for (int i = 0; i < age; i++)
            {
                value = value * 0.9m;
            }

            value = Decimal.Round(value, 0); //rounded to the nearest pound

            value = value + 20;// £20 is then added
            return value;
        }
    }
}

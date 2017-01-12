using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneSales
{
    //Stating AndroidPhone is type of MobilePhone
    public class AndroidPhone : MobilePhone
    {
        //Constructor for AndroidPhone
        public AndroidPhone(string make, string model,
           decimal originalPrice, string operatingSystem, DateTime datePurchase, Condition condition, DateTime dateManufactured)
            : base(make, model, originalPrice,operatingSystem, condition, datePurchase, dateManufactured)
        {
            //Constructor is empty as the class adds no new attributes
        }
        //calculation is over written in accordance to phone make
        public override decimal CalculateApproximateValue()
        {
            //Phone vlaue is modified in accordance to its condition
            decimal value = 0;

            if (condition == Condition.mint)
            {
                value = originalPrice * 0.8m; //ie 80% of original value
            }

            else if (condition == Condition.good)
            {
                value = originalPrice * 0.7m;
            }

            else if (condition == Condition.fair)
            {
                value = originalPrice * 0.5m;
            }

            else if (condition == Condition.poor)
            {
                value = originalPrice * 0.4m;
            }
            // phone age is also taken into consideration
            int age = CalcualteApproximateAgeInYears();

            for (int i = 0; i < age; i++)
            {
                value = value * 0.9m;
            }

            value = Decimal.Round(value, 0); //value is rounded to nearest pound

            

            value = value + 50; //then £50 is added
            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneSales
{
   public class Shop
    {
        //the shop contains a list of mobilephones
        //we use polymorphism to inherit from the base class
        private List<MobilePhone> mobileStock;

        private int mobileCurrentlyDisplayed = 0;

        public Shop()
        {
            mobileStock = new List<MobilePhone>();
        }

        public int MobileCurrentlyDisplayed
        {
            get { return mobileCurrentlyDisplayed; }
        }

        public int NumberOfMobiles
        {
            get { return mobileStock.Count; }
        }

        public string DescribeCurrentMobile()
        {
            //if there is any mobilephones we ask for the description
            string description;

            if (mobileStock.Count > 0)
            {
                description = mobileStock[mobileCurrentlyDisplayed].Description();
            }

            else
            {
                description = "No mobiles in stock";
            }

            return description;
        }

        public void AddMobile(MobilePhone mobilephone)
        {
            mobileStock.Add(mobilephone);
        }

        public void RemoveMobileAt(int index)
        {
            if (index < mobileStock.Count)
            {
                mobileStock.RemoveAt(index);
                //make sure mobilecurrentlydisplayed is either at zero or is pointing at an exisiting moble

                LegaliseMobileCurrentlyDisplayed();
            }
        }
        //ensure that mobile currently displayed indexes a mobile that exists
        private void LegaliseMobileCurrentlyDisplayed()
        {
            if (mobileCurrentlyDisplayed > (mobileStock.Count - 1))
            {
                mobileCurrentlyDisplayed = mobileStock.Count - 1; //note this value will be -1 if stock level is zero

                if ( mobileCurrentlyDisplayed < 0)
                {
                    mobileCurrentlyDisplayed = 0; //ensure its legal or is at zero
                }
            }
        }

        public bool IsPreviousMobilePhone()
        {
            if ( mobileCurrentlyDisplayed > 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool IsNextMobilePhone()
        {
            if (mobileCurrentlyDisplayed < mobileStock.Count - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void StepToPreviousMobilePhone()
        {
            if (IsPreviousMobilePhone())
            {
                mobileCurrentlyDisplayed--;
            }
        }

        public void StepToNextMobilePhone()
        {
            if (IsNextMobilePhone())
            {
                mobileCurrentlyDisplayed++;
            }
        }
    }
}

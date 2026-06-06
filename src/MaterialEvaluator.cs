using System;

namespace MaterialApp
{
    public class MaterialEvaluator
    {
        public string ValidateMaterialExpiry(DateTime expiryDate, int warningDays, bool isCritical)
        {
            DateTime today = DateTime.Today;


            if (isCritical)
            {
                warningDays += 5;
            }


            if (today > expiryDate)
            {
                return "Expired";
            }
            else if ((expiryDate - today).Days <= warningDays)
            {
                return "Near Expiry";
            }

            else
            {
                return "Valid";
            }
        }
    }
}

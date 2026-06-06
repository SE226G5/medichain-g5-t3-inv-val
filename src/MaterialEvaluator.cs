using System;

namespace MaterialApp
{
    public class MaterialEvaluator
    {
        public string ValidateMaterialExpiry(DateTime expiryDate, int warningDays)
        {
            DateTime today = DateTime.Today;

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

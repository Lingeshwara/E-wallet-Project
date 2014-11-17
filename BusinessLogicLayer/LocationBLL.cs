using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class LocationBLL
    {

        public string Location(string locationName, string postalCode, string venue, string unitNo)
        {
            string returnMessage = "";

            if (locationName.Length < 0) { returnMessage += "Password cannot be empty!"; }
            if (postalCode.Length < 0) { returnMessage += "Password cannot be empty!"; }
            if (venue.Length < 0) { returnMessage += "Password cannot be empty!"; }
            if (unitNo.Length < 0) { returnMessage += "Password cannot be empty!"; }


           
            return returnMessage;
        }

        public int ILocation(string locationName, string postalCode, string venue, string unitNo)
        {
            string returnMessage = "";

            if (locationName.Length < 0) { returnMessage += "Password cannot be empty!"; }
            if (postalCode.Length < 0) { returnMessage += "Password cannot be empty!"; }
            if (venue.Length < 0) { returnMessage += "Password cannot be empty!"; }
            if (unitNo.Length < 0) { returnMessage += "Password cannot be empty!"; }


            Location dlInsertLoc = new Location();
            return dlInsertLoc.ILocation(locationName, postalCode, venue, unitNo);
        }
    }
}

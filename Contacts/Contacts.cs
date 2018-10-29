using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Code_Snippets.Contacts
{
    public class Contacts
    {
        AMTANGEE.SDK.Contacts.Contact GetContactByCustomerNo(string customerNo)
        {
            AMTANGEE.SDK.Contacts.Contacts contacts = AMTANGEE.SDK.Contacts.Contacts.SearchByCustomerOrVendorNo(customerNo);
            if (contacts.Count > 0)
            {
                if (contacts[0] is AMTANGEE.SDK.Contacts.Contact)
                    return (AMTANGEE.SDK.Contacts.Contact)contacts[0];
                else
                    return ((AMTANGEE.SDK.Contacts.ContactPerson)contacts[0]).Parent;
            }

            return null;
        }

        AMTANGEE.SDK.Contacts.Contact GetContactByEmailAddress(string emailAddress)
        {
            AMTANGEE.SDK.Contacts.Contacts contacts = AMTANGEE.SDK.Contacts.Contacts.SearchByEmailAddress(AMTANGEE.SDK.Contacts.SearchKinds.BeginsWith, emailAddress);
            if (contacts.Count > 0)
            {
                if (contacts[0] is AMTANGEE.SDK.Contacts.Contact)
                    return (AMTANGEE.SDK.Contacts.Contact)contacts[0];
                else
                    return ((AMTANGEE.SDK.Contacts.ContactPerson)contacts[0]).Parent;
            }

            return null;
        }
    }
}

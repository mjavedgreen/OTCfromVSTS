using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneTimeControl.IView
{
  interface IOneTimeDonationView
  {
    //properties
    string DonationAmount { get; set; }
    string CardNumber { get; set; }
    string CarHolderName { get; set; }
    string ExpiryMonth { get; set; }
    List<String> ExM { get; set; }
    string ExpiryYear { get; set; }
    string SecurityCode { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
    string Email { get; set; }
    string PhoneNumber { get; set; }
    string Extension { get; set; }
    string AddressLineOne { get; set; }
    string UnitSuit { get; set; }
    string City { get; set; }
    string PostalCode { get; set; }

  }
}

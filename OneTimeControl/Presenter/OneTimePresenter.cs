using OneTimeControl.IView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneTimeControl.Presenter
{
  class OneTimePresenter
  {
   // private OneTimeDonation oneTimeDonation;
    private IOneTimeDonationView oneTimeDonationView;

    //Binging Form Events to Presenter
    

    public OneTimePresenter( IOneTimeDonationView oneTimeDonationView)//:this(oneTimeDonation)
    {
      this.oneTimeDonationView = oneTimeDonationView;
      oneTimeDonationView.Save += SaveForm;
      oneTimeDonationView.Reset += ClearForm;
;
    }

    private void ClearForm(object sender, EventArgs e)
    {
      ClearTheForm();
      MessageBox.Show("Form cleared");
    }

    private void SaveForm(object sender, EventArgs e)
    {
      //oneTimeDonation.ca
      string abc = oneTimeDonationView.Country;
      string def = oneTimeDonationView.Province;
      MessageBox.Show("Donation Saved");
    }

    private void ClearTheForm()
    {
      oneTimeDonationView.CardNumber = String.Empty;
      oneTimeDonationView.CarHolderName = String.Empty;
      oneTimeDonationView.FirstName = String.Empty;
      oneTimeDonationView.LastName = String.Empty;
      oneTimeDonationView.PhoneNumber = String.Empty;
      oneTimeDonationView.PostalCode = String.Empty;
      oneTimeDonationView.SecurityCode = String.Empty;
      oneTimeDonationView.DonationAmount = String.Empty;
      oneTimeDonationView.ExpiryMonth = "MM";
      oneTimeDonationView.ExpiryYear = "YYYY"; //String.Empty;
      oneTimeDonationView.Extension = String.Empty;
      oneTimeDonationView.AddressLineOne = String.Empty;
      oneTimeDonationView.UnitSuit = String.Empty;
      oneTimeDonationView.City = String.Empty;
      oneTimeDonationView.PostalCode = String.Empty;
      oneTimeDonationView.Email = String.Empty;
      oneTimeDonationView.Province = String.Empty;
      oneTimeDonationView.Country = String.Empty;
    }
  }
}

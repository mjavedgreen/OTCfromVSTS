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
    private OneTimeDonation oneTimeDonation;
    private IOneTimeDonationView oneTimeDonationView;

    //Binging Form Events to Presenter
    public OneTimePresenter(OneTimeDonation oneTimeDonation)
    {
      this.oneTimeDonation = oneTimeDonation;
      oneTimeDonation.Save += SaveForm;
      oneTimeDonation.Reset += ClearForm;
    }

    public OneTimePresenter(OneTimeDonation oneTimeDonation, IOneTimeDonationView oneTimeDonationView):this(oneTimeDonation)
    {
      this.oneTimeDonationView = oneTimeDonationView;
    }

    private void ClearForm(object sender, EventArgs e)
    {
      MessageBox.Show("Reset button clikced");
     // string abc = oneTimeDonationView.CardNumber;
    }

    private void SaveForm(object sender, EventArgs e)
    {
      MessageBox.Show("Donate button clikced");
    }
  }
}

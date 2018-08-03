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

    //Binging Form Events to Presenter
    public OneTimePresenter(OneTimeDonation oneTimeDonation)
    {
      this.oneTimeDonation = oneTimeDonation;
      oneTimeDonation.Save += SaveForm;
      oneTimeDonation.Reset += ClearForm;
    }

    private void ClearForm(object sender, EventArgs e)
    {
      MessageBox.Show("Reset button clikced");
    }

    private void SaveForm(object sender, EventArgs e)
    {
      MessageBox.Show("Donate button clikced");
    }
  }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace OneTimeControl
{
  public partial class OneTimeDonation : UserControl
  {
    public OneTimeDonation()
    {
      InitializeComponent();
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }

    private void radTextBoxControl1_TextChanged(object sender, EventArgs e)
    {

    }

    private void OneTimeDonation_Load(object sender, EventArgs e)
    {
      tbAmount.Focus();
    }

    private void radTextBox13_TextChanged(object sender, EventArgs e)
    {

    }


    private void tbCardNumber_KeyPress(object sender, KeyPressEventArgs e)
    {

      if(tbCardNumber.TextLength.ToString() == "0")
      {
        switch (e.KeyChar)
        {
          case '3': CreditCradLogoChanger(sender, e, @"C:\Users\md javed\source\repos\OneTimeControl\OneTimeControl\Images\icAmex.png", 4); break;
          case '4': CreditCradLogoChanger(sender, e, @"C:\Users\md javed\source\repos\OneTimeControl\OneTimeControl\Images\icVisa.png", 3);break;
          case '5':  CreditCradLogoChanger(sender, e, @"C:\Users\md javed\source\repos\OneTimeControl\OneTimeControl\Images\icMasterCard.png", 3); break;
  
        }
      }
      
      NumberValidation(sender, e);
      if (tbCardNumber.TextLength.ToString() == "0") { picBoxCardLogo.Image = null; }
    }

    private void tbCardHolderName_KeyPress(object sender, KeyPressEventArgs e)
    {
      LetterValidation(sender, e);
    }

    private void tbSecCodeCVV_KeyPress(object sender, KeyPressEventArgs e)
    {
      NumberValidation(sender, e);
    }

    private void tbFirstName_KeyPress(object sender, KeyPressEventArgs e)
    {
      LetterValidation(sender, e);
      
    }

    private void tbLastName_KeyPress(object sender, KeyPressEventArgs e)
    {
      LetterValidation(sender, e);
    }

    private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
    {
      NumberValidation(sender, e);
    }

    private void tbExtensionNumber_KeyPress(object sender, KeyPressEventArgs e)
    {
      NumberValidation(sender, e);
    }

    private void tbEmail_Leave(object sender, EventArgs e)
    {
      string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
      if (Regex.IsMatch(tbEmail.Text, pattern))
      {
        errorProviderMain.Clear();
      }
      else
      {
        errorProviderMain.SetError(this.tbEmail, "Please enter proper Email Address");
      }
    }

    private void tbAmount_KeyPress(object sender, KeyPressEventArgs e)
    {
      
      
      if (Regex.IsMatch(tbAmount.Text, @"\.\d\d") && e.KeyChar != 8   || !char.IsDigit(e.KeyChar) && e.KeyChar != 8)
        {
          e.Handled = true;
        }
      if (e.KeyChar == '.')
      {
       
        e.Handled = false;
      }

    }

    private void tbCardNumber_Leave(object sender, EventArgs e)
    {
        if(tbCardNumber.MaxLength != 16)
      {
        errorProviderMain.SetError(this.tbCardNumber, "Card Number not proper");
      }
      else
      {
        errorProviderMain.Clear();
      }
    }

    private void tbSecCodeCVV_Leave(object sender, EventArgs e)
    {
        if(tbSecCodeCVV.MaxLength != 3)
      {
        errorProviderMain.SetError(this.tbSecCodeCVV, "Security Code Incomplete");
      }
      else { errorProviderMain.Clear(); }
    }




    private void CreditCradLogoChanger(object sender, KeyPressEventArgs e, string logoLocation, int secCodeLenghtSize)
    {
      picBoxCardLogo.Image = null;
      picBoxCardLogo.ImageLocation = logoLocation;
      tbSecCodeCVV.MaxLength = secCodeLenghtSize;
    }


    private void NumberValidation(object sender, KeyPressEventArgs e)
    {
      char ch = e.KeyChar;
      if (!char.IsDigit(ch) && ch != 8)
      {
        e.Handled = true;
      }
    }

    private void LetterValidation(object sender, KeyPressEventArgs e)
    {
      e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
    }

  }
}

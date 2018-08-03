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
using OneTimeControl.IView;
using OneTimeControl.Services;

namespace OneTimeControl
{
  public partial class OneTimeDonation : UserControl, IOneTimeDonationView
  {

    private IDataService dataService;
    

    #region Binding View to Form
    public string DonationAmount { get { return tbAmount.Text.Trim(); } set { tbAmount.Text = value; } }
    public string CardNumber { get { return tbCardNumber.Text.Trim(); } set { tbCardNumber.Text = value; } }
    public string CarHolderName { get { return tbCardHolderName.Text; } set { tbCardHolderName.Text = value; } }
    public string ExpiryMonth { get; set; }
    public string ExpiryYear { get; set; }
    public string SecurityCode { get { return tbSecCodeCVV.Text.Trim(); }  set { tbSecCodeCVV.Text = value; }  }
    public string FirstName { get { return tbFirstName.Text; } set { tbFirstName.Text = value; } }
    public string LastName { get { return tbLastName.Text; } set { tbLastName.Text = value; } }
    public string Email { get { return tbEmail.Text; } set { tbEmail.Text = value; } }
    public string PhoneNumber { get { return tbPhone.Text; } set { tbPhone.Text = value; } }
    public string Extension { get { return tbExtensionNumber.Text; } set { tbExtensionNumber.Text = value; } }
    public string AddressLineOne { get { return tbAddress.Text; } set { tbAddress.Text = value; } }
    public string UnitSuit { get { return tbUnitSuite.Text; } set { tbUnitSuite.Text = value; } }
    public string City { get { return tbCity.Text; } set { tbCity.Text = value; } }
    public string PostalCode { get { return tbPostalCode.Text; } set { tbPostalCode.Text = value; } }
    #endregion
    public OneTimeDonation()
    {
      InitializeComponent();
    }

    public event EventHandler<EventArgs> Save;
    public event EventHandler<EventArgs> Reset;

    #region Validation of Controls
    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }

    private void radTextBoxControl1_TextChanged(object sender, EventArgs e)
    {

    }

    private void OneTimeDonation_Load(object sender, EventArgs e)
    {
      tbAmount.Focus();
      dataService = new DataServices(this);
      ddlMM.DataSource = dataService.GetExpiryMonths();
      ddlMM.DisplayMember = "Text";
      ddlMM.ValueMember = "Value";

      ddlYYYY.DataSource = dataService.GetExpiryYears();
      ddlYYYY.DisplayMember = "Text";
      ddlYYYY.ValueMember = "Value";

      ddlCountry.DataSource = dataService.GetCountries();
      ddlCountry.DisplayMember = "Text";
      ddlCountry.ValueMember = "Value";

      ddlProvince.DataSource = dataService.GetCanadianProvinces();
      ddlProvince.DisplayMember = "Text";
      ddlProvince.ValueMember = "Value";

      ddlFormAnswer.DataSource = dataService.GetWhatLedYouToDonateItems();
      ddlFormAnswer.DisplayMember = "Text";
      ddlFormAnswer.ValueMember = "Value";

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
    #endregion
  }
}

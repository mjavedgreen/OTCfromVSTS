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
using OneTimeControl.Presenter;
using Telerik.WinControls.UI;

namespace OneTimeControl
{
  public partial class OneTimeDonation : UserControl, IOneTimeDonationView
  {

    private IDataService dataService;
    private OneTimePresenter presenter;
    

    #region Binding IView to Form
    public string DonationAmount { get { return tbAmount.Text.Trim(); } set { tbAmount.Text = value; } }
    public string CardNumber { get { return tbCardNumber.Text.Trim(); } set { tbCardNumber.Text = value; } }
    public string CarHolderName { get { return tbCardHolderName.Text; } set { tbCardHolderName.Text = value; } }
    public string ExpiryMonth { get { return ddlMM.SelectedItem.Text.ToString(); } set { ddlMM.Text = value; }  }
   //public string ExpiryMonth { get; set; }
    public string ExpiryYear { get { return ddlYYYY.SelectedItem.Text.ToString(); } set { ddlYYYY.Text = value; } }
   // public string ExpiryYear { get; set; }
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
    public string Country { get { return ddlCountry.SelectedItem.Text.ToString(); } set { ddlCountry.Text = value; } }
    public string Province { get { return ddlProvince.SelectedItem.Value.ToString(); } set { ddlProvince.Text = value; } }

    //public string Country { get; set; }
    //public string Province { get; set; }

    public string DonationReason { get { return ddlFormAnswer.SelectedIndex.ToString(); } set { } }
    public string Comments { get { return tbComments.Text.ToString(); } set { tbComments.Text = value; } }

    public string CardType { get { return lblCardType.Text.ToString(); } set { lblCardType.Text = value; } }
    #endregion
    public OneTimeDonation()
    {
      InitializeComponent();
      dataService = new DataServices(this);
      ddlMM.DataSource = dataService.GetExpiryMonths();
      ddlMM.DisplayMember = "Text";
      ddlMM.ValueMember = "Value";
      ddlMM.SelectedIndex = 0;

      ddlYYYY.DataSource = dataService.GetExpiryYears();
      ddlYYYY.DisplayMember = "Text";
      ddlYYYY.ValueMember = "Value";
      ddlYYYY.SelectedIndex = 0;

      ddlCountry.DataSource = dataService.GetCountries();
      ddlCountry.DisplayMember = "Text";
      ddlCountry.ValueMember = "Value";
 //     ddlCountry.SelectedIndex = 0;

      ddlProvince.DataSource = dataService.GetCanadianProvinces();
      ddlProvince.DisplayMember = "Text";
      ddlProvince.ValueMember = "Value";
 //     ddlProvince.SelectedIndex = 0;

      ddlFormAnswer.DataSource = dataService.GetWhatLedYouToDonateItems();
      ddlFormAnswer.DisplayMember = "Text";
      ddlFormAnswer.ValueMember = "Value";
 //     ddlFormAnswer.SelectedIndex = 0;
      // presenter = new OneTimePresenter(this);
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
      presenter = new OneTimePresenter(this);
    }

   
    private void tbCardNumber_KeyPress(object sender, KeyPressEventArgs e)
    {

      if(tbCardNumber.TextLength.ToString() == "0")
      {
        switch (e.KeyChar)
        {
          case '3': CreditCradLogoChanger(sender, e, @"C:\Users\md javed\source\repos\OneTimeControl\OneTimeControl\Images\icAmex.png", 4,"AMEX"); break;
          case '4': CreditCradLogoChanger(sender, e, @"C:\Users\md javed\source\repos\OneTimeControl\OneTimeControl\Images\icVisa.png", 3,"VISA");break;
          case '5':  CreditCradLogoChanger(sender, e, @"C:\Users\md javed\source\repos\OneTimeControl\OneTimeControl\Images\icMasterCard.png", 3,"MasterCard"); break;
  
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
        errorProviderMain.SetError(this.tbEmail,"");
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
        if(tbCardNumber.Text.Length.ToString() != "16")
      {
        errorProviderMain.SetError(this.tbCardNumber, "Card Number not proper");
      }
      else
      {
        errorProviderMain.SetError(this.tbCardNumber, "");
      }
    }

    private void tbSecCodeCVV_Leave(object sender, EventArgs e)
    {
        if(tbSecCodeCVV.Text.Length != 3)
      {
        errorProviderMain.SetError(this.tbSecCodeCVV, "Security Code Incomplete");
      }
     else { errorProviderMain.SetError(this.tbSecCodeCVV, ""); }
    }




    private void CreditCradLogoChanger(object sender, KeyPressEventArgs e, string logoLocation, int secCodeLenghtSize, string cardType)
    {
      picBoxCardLogo.Image = null;
      picBoxCardLogo.ImageLocation = logoLocation;
      tbSecCodeCVV.MaxLength = secCodeLenghtSize;
      lblCardType.Text = cardType;
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

   
   

    private void btnDonate_Click(object sender, EventArgs e)
    {
      //check for entire validation here
      bool valStatus = CompleteValidation();
      if (valStatus)
      {
        Save(sender, e);
      }
      else
      {
        MessageBox.Show("Please complete the form");
      }

      //  Save(sender, e);
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
      Reset(sender, e);
    }

    private void tbFirstName_Leave(object sender, EventArgs e)
    {
      CheckIfEmpty(tbFirstName, "First Name");
    }

    private void CheckIfEmpty(RadTextBox textBox, string controlName)
    {
      if (textBox.Text.Length.ToString() == "0")
      {
        errorProviderMain.SetError(textBox, controlName + " cannot be empty");
      }
      else
      {
        errorProviderMain.SetError(textBox, "");
      }
    }



    private void tbLastName_Leave(object sender, EventArgs e)
    {
      CheckIfEmpty(tbLastName, "Last Name");
    }

    private void tbCardHolderName_Leave(object sender, EventArgs e)
    {
      CheckIfEmpty(tbCardHolderName, "Card Holder Name");
    }

    private void tbAddress_Leave(object sender, EventArgs e)
    {
      CheckIfEmpty(tbAddress, "Address");
    }

    private void tbCity_Leave(object sender, EventArgs e)
    {
      CheckIfEmpty(tbCity, "City");
    }

    private void tbPostalCode_Leave(object sender, EventArgs e)
    {
      CheckIfEmpty(tbPostalCode, "Postal Code");
    }

    private void tbAmount_Leave(object sender, EventArgs e)
    {
      CheckIfEmpty(tbAmount, "Amount");
    }
    //Dropdown Validations 
    private void ddlMM_Leave(object sender, EventArgs e)
    {
     
      DropDownValidation(ddlMM);
    }

    #endregion

    private void ddlCountry_SelectedValueChanged(object sender, EventArgs e)
    {
      if(ddlCountry.SelectedValue.ToString() == "US")
      {
        ddlProvince.DataSource = dataService.GetAmericanStates();
        ddlProvince.DisplayMember = "Text";
        ddlProvince.ValueMember = "Value";
      }
      else if(ddlCountry.SelectedValue.ToString() == "AU")
      {
        ddlProvince.DataSource = dataService.GetAustralianStates();
        ddlProvince.DisplayMember = "Text";
        ddlProvince.ValueMember = "Value";
      }
      else
      {
        ddlProvince.DataSource = dataService.GetCanadianProvinces();
        ddlProvince.DisplayMember = "Text";
        ddlProvince.ValueMember = "Value";

      }
    }


    #region Final Validation
    private bool CompleteValidation()
    {
      if(tbAmount.Text == "")
      {
        MessageBox.Show("Please enter Amount");
        return false;
      } else if (tbCardNumber.Text == "")
      {
        MessageBox.Show("Please enter Credit Card details"); return false;
      } else if (tbCardHolderName.Text == "")
      {
        MessageBox.Show("Please enter Card Holder Name"); return false;
      }
      else if (tbSecCodeCVV.Text == "")
      {
        MessageBox.Show("Please enter Security Code"); return false;
      } else if (tbFirstName.Text == "")
      {
        MessageBox.Show("Please enter First Name"); return false;
      } else if (tbLastName.Text == "")
      {
        MessageBox.Show("Please enter Last Name"); return false;
      } else if (tbEmail.Text == "")
      {
        MessageBox.Show("Please enter Email"); return false;
      } else if (tbAddress.Text == "")
      {
        MessageBox.Show("Please enter Address"); return false;
      }


      return true;







    }

    #endregion
    private void DropDownValidation(RadDropDownList radDropDownList)
    {
      if(radDropDownList.SelectedIndex < 1)
      {
        errorProviderMain.SetError(radDropDownList, "PLease select an option");
      }
      else
      {
        errorProviderMain.SetError(radDropDownList, "");
      }

    }

    private void ddlYYYY_Leave(object sender, EventArgs e)
    {
      DropDownValidation(ddlYYYY);
    }

    private void ddlCountry_Leave(object sender, EventArgs e)
    {
      DropDownValidation(ddlCountry);
    }

    private void ddlProvince_Leave(object sender, EventArgs e)
    {
      DropDownValidation(ddlProvince);
    }
  }
}

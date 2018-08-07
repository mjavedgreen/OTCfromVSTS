namespace OneTimeControl
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.oneTimeDonation1 = new OneTimeControl.OneTimeDonation();
            this.SuspendLayout();
            // 
            // oneTimeDonation1
            // 
            this.oneTimeDonation1.AddressLineOne = "";
            this.oneTimeDonation1.CardNumber = "";
            this.oneTimeDonation1.CardType = "";
            this.oneTimeDonation1.CarHolderName = "";
            this.oneTimeDonation1.City = "";
            this.oneTimeDonation1.Comments = "";
            this.oneTimeDonation1.Country = "CA";
            this.oneTimeDonation1.DonationAmount = "";
            this.oneTimeDonation1.DonationReason = "0";
            this.oneTimeDonation1.Email = "";
            this.oneTimeDonation1.ExpiryMonth = "MM";
            this.oneTimeDonation1.ExpiryYear = "YYYY";
            this.oneTimeDonation1.Extension = "";
            this.oneTimeDonation1.FirstName = "";
            this.oneTimeDonation1.LastName = "";
            this.oneTimeDonation1.Location = new System.Drawing.Point(1, 12);
            this.oneTimeDonation1.Name = "oneTimeDonation1";
            this.oneTimeDonation1.PhoneNumber = "";
            this.oneTimeDonation1.PostalCode = "";
            this.oneTimeDonation1.Province = "";
            this.oneTimeDonation1.SecurityCode = "";
            this.oneTimeDonation1.Size = new System.Drawing.Size(549, 1464);
            this.oneTimeDonation1.TabIndex = 0;
            this.oneTimeDonation1.UnitSuit = "";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(579, 694);
            this.Controls.Add(this.oneTimeDonation1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

    }

    #endregion

    private OneTimeDonation oneTimeDonation1;
  }
}
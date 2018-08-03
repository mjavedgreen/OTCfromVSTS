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
            this.oneTimeDonation1.Location = new System.Drawing.Point(13, 3);
            this.oneTimeDonation1.Name = "oneTimeDonation1";
            this.oneTimeDonation1.Size = new System.Drawing.Size(522, 1464);
            this.oneTimeDonation1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(562, 878);
            this.Controls.Add(this.oneTimeDonation1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

    }

    #endregion

    private OneTimeDonation oneTimeDonation1;
  }
}
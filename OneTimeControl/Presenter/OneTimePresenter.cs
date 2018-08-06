using Newtonsoft.Json;
using OneTimeControl.Entities;
using OneTimeControl.IView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OneTimeControl.Entities.Donation;

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

    }

    private void ClearForm(object sender, EventArgs e)
    {
      ClearMainForm();
      MessageBox.Show("Form cleared");
    }

    private void SaveForm(object sender, EventArgs e)
    {
      //oneTimeDonation.ca
      string abc = oneTimeDonationView.Country;
      string def = oneTimeDonationView.Province;

      //Payment
      MakeDonation();
      MessageBox.Show("Donation Saved");
    //  ClearMainForm();
    }

    private void MakeDonation()
    {
      try
      {
        string conResp = PostConstituent();
        string tranResp = PostTransaction(conResp);
        string donResp = PostDonation(conResp, tranResp);
        string creditCardPaymentResponse = PostCreditCardPayment(tranResp);

        //var paymentResult = new PaymentResult
        //{
        //  Success = (creditCardPaymentResponse.Status == Succeeded),
        //  ExternalPaymentID = creditCardPaymentResponse.PaymentID,
        //  ErrorMessage = creditCardPaymentResponse.FriendlyErrorMessage
        //};

        //return paymentResult;



      }
      catch(Exception ex)
      {

      }
    }

   

    private string GetEncodedAuthorization()
    {
      var encodedAuthorization = Convert.ToBase64String(
                                   Encoding.GetEncoding("ISO-8859-1").
                                   GetBytes("hscf" + ':' + "6c50374006f3457eaa03b892b2533e79"));

      return encodedAuthorization;
    }

    private void ClearMainForm()
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
      oneTimeDonationView.Comments = String.Empty;
      


    }


    #region Transaction Start
    private string PostConstituent()
    {
      var constituent = new Constituent
      {
        TitleID = 9,
        FirstName = oneTimeDonationView.FirstName,
        LastName = oneTimeDonationView.LastName,
        EmailAddress = oneTimeDonationView.Email,
        PhoneNumber = oneTimeDonationView.PhoneNumber,
        LanguagePreference = "en-CA",
        Address = new Constituent.FrontStreamAddress
        {
          AddressLine1 = oneTimeDonationView.AddressLineOne,
          AddressLine2 = oneTimeDonationView.AddressLineOne,
          Apartment = string.Empty,
          City = oneTimeDonationView.City,
          ProvinceCode = "ON",
          CountryCode = "CA",
          PostalCode = oneTimeDonationView.PhoneNumber,
          ProvinceFreeText = null,
        },
        IsOrganization = false,
        OrganizationName = null,
        AllowContactViaEmail = false,
        AllowContactViaPost = false
      };
      StringContent jSonReqConstituent = new StringContent(JsonConvert.SerializeObject(constituent), Encoding.UTF8, "application/json");
      HttpClient cons = new HttpClient();
      cons.DefaultRequestHeaders.Accept.Clear();
      cons.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
      cons.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", GetEncodedAuthorization());
      HttpResponseMessage res = cons.PostAsync("https://secureuat.artezhq.com/api/Constituents", jSonReqConstituent).Result;
      var constituentResponse = res.Content.ReadAsAsync<ConstituentResponse>();
      var transaction = new Transaction { ConstituentID = constituentResponse.Result.ConstituentID };
      return transaction.ConstituentID;//.ToString();
    }


    private string PostTransaction(string consResp)
    {
      HttpClient cons = new HttpClient();
      cons.DefaultRequestHeaders.Accept.Clear();
      var transaction = new Transaction { ConstituentID = consResp };
      cons.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
      cons.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", GetEncodedAuthorization());
      StringContent jSonReqTransaction = new StringContent(JsonConvert.SerializeObject(transaction), Encoding.UTF8, "application/json");
      HttpResponseMessage resTransaction = cons.PostAsync("https://secureuat.artezhq.com/api/Transactions", jSonReqTransaction).Result;
      var transactionResponse = resTransaction.Content.ReadAsAsync<TransactionResponse>();
      return transactionResponse.Result.TransactionID;
    }

    private string PostDonation(string conResp, string tranResp)
    {
      //throw new NotImplementedException();
      var donation = new Donation
      {
        Amount = 5.00M, //Convert.ToDecimal(oneTimeDonationView.DonationAmount),
        CurrencyID = "CAD",
        DonorConstituentID = conResp,
        EventID = "26922",//"2034",//"185644-finone",  //Default event in the Gateway
        SolicitorTeamID = null,
        SolicitorRegistrationID = null,
        IgnoreMinimumTaxReceiptAmount = false,
        TransactionID = tranResp,
        ShowAmountOnDonorScroll = false,
        ShowNameOnDonorScroll = false,
        UdfResponses = GetUdfResponse(),

      };
      HttpClient cons = new HttpClient();
      cons.DefaultRequestHeaders.Accept.Clear();
      cons.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
      cons.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", GetEncodedAuthorization());
      StringContent jSonReqDonation = new StringContent(JsonConvert.SerializeObject(donation), Encoding.UTF8, "application/json");
      HttpResponseMessage resDonation = cons.PostAsync("https://secureuat.artezhq.com/api/Donations", jSonReqDonation).Result;
      var donationResponse = resDonation.Content.ReadAsAsync<DonationResponse>();
      return donationResponse.Result.DonationID;
    }

    private string PostCreditCardPayment(string tranResp)
    {
      //Credit Card Payment

      var creditCardPayment = new CreditCardPayment
      {
        TransactionID = tranResp,
        CardNumber = oneTimeDonationView.CardNumber,
        CardType = "Visa",
        ExpiryMonth = "09",
        ExpiryYear = "2018",
        CardHolderName = oneTimeDonationView.CarHolderName,
        CardVerificationValue = oneTimeDonationView.SecurityCode,
        PaymentAmount = oneTimeDonationView.DonationAmount //"5.00"//oneTimeDonationInterface.DonationAmount.ToString("N2")
      };
      HttpClient cons = new HttpClient();
      cons.DefaultRequestHeaders.Accept.Clear();
      cons.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
      cons.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", GetEncodedAuthorization());
      StringContent jSonReqCreditCardPayment = new StringContent(JsonConvert.SerializeObject(creditCardPayment), Encoding.UTF8, "application/json");
      HttpResponseMessage creditCardResponseMessage = cons.PostAsync("https://secureuat.artezhq.com/api/CreditCardPayments", jSonReqCreditCardPayment).Result;
      var ghi = creditCardResponseMessage.Content.ReadAsAsync<CreditCardPaymentResponse>();
      return ghi.Result.PaymentID.ToString();
    }


    private IList<FronstreamUdfResponse> GetUdfResponse()
    {
      var list = new List<FronstreamUdfResponse>();
      var r1 = new FronstreamUdfResponse();
      r1.AnswerID = "58241";
      r1.Value = "19GEA-9999";
      list.Add(r1);
      var r2 = new FronstreamUdfResponse();
      r2.AnswerID = "58237";//"507985";//
      r2.Value = "";// "False";
      list.Add(r2);
      //var r3 = new FronstreamUdfResponse();
      //r3.AnswerID = "507986";
      //r3.Value = "";// "False";

      return list;
    }
    #endregion
  }
}

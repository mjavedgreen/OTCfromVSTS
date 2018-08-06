using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneTimeControl.Entities
{
  public class Constituent
  {
    public class FrontStreamAddress
    {
      public virtual string AddressLine1 { get; set; }
      public virtual string AddressLine2 { get; set; }
      public virtual string Apartment { get; set; }
      public virtual string City { get; set; }
      public virtual string ProvinceCode { get; set; }
      public virtual string CountryCode { get; set; }
      public virtual string PostalCode { get; set; }
      public virtual string ProvinceFreeText { get; set; }

    }

    public virtual int? TitleID { get; set; }
    public virtual string FirstName { get; set; }
    public virtual string LastName { get; set; }
    public virtual string EmailAddress { get; set; }
    public virtual string PhoneNumber { get; set; }
    public virtual string LanguagePreference { get; set; }
    public virtual FrontStreamAddress Address { get; set; }
    public virtual bool IsOrganization { get; set; }
    public virtual string OrganizationName { get; set; }
    public virtual bool AllowContactViaPost { get; set; }
    public virtual bool AllowContactViaEmail { get; set; }
  }

  public class ConstituentResponse
  {
    public string ConstituentID { get; set; }
  }

  public class Transaction
  {
    public virtual string ConstituentID { get; set; }
  }
  public class TransactionResponse
  {
    public virtual string TransactionID { get; set; }
  }

  public class Donation
  {
    public class FronstreamUdfResponse
    {
      public virtual string AnswerID { get; set; }
      public virtual string Value { get; set; }
    }

    public virtual decimal Amount { get; set; }
    public virtual string CurrencyID { get; set; }
    public virtual string DonorConstituentID { get; set; }
    public virtual string EventID { get; set; }
    public virtual string SolicitorTeamID { get; set; }
    public virtual string SolicitorRegistrationID { get; set; }
    public virtual bool IgnoreMinimumTaxReceiptAmount { get; set; }
    public virtual IList<FronstreamUdfResponse> UdfResponses { get; set; }
    public virtual string TransactionID { get; set; }
    public virtual bool ShowNameOnDonorScroll { get; set; }
    public virtual bool ShowAmountOnDonorScroll { get; set; }
  }

  public class DonationResponse
  {
    public virtual string DonationID { get; set; }
  }

  public class CreditCardPayment
  {
    public virtual string TransactionID { get; set; }
    public virtual string CardNumber { get; set; }
    public virtual string CardType { get; set; }
    public virtual string ExpiryMonth { get; set; }
    public virtual string ExpiryYear { get; set; }
    public virtual string CardHolderName { get; set; }
    public virtual string CardVerificationValue { get; set; }
    public virtual string PaymentAmount { get; set; }
  }

  public class CreditCardPaymentResponse
  {
    public virtual string PaymentID { get; set; }
    public virtual string Status { get; set; }
    public virtual string FriendlyErrorMessage { get; set; }
  }


  public class PaymentResult
  {
    public bool Success { get; set; }
    public string ExternalPaymentID { get; set; }
    public string ErrorMessage { get; set; }
  }
}

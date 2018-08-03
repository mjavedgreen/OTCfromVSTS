
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace OneTimeControl.Services
{
  class DataServices : IDataService
  {
    private OneTimeDonation oneTimeDonation;

    public DataServices(OneTimeDonation oneTimeDonation)
    {
      this.oneTimeDonation = oneTimeDonation;
    }

    public virtual IEnumerable<SelectListItem> GetCountries()
    {

      //yield return new SelectListItem { Text = "", Value = "" };
      yield return new SelectListItem { Text = "Canada", Value = "CA" };
      yield return new SelectListItem { Text = "United States", Value = "US" };
      yield return new SelectListItem { Text = "Afghanistan", Value = "AF" };
      yield return new SelectListItem { Text = "Albania", Value = "AL" };
      yield return new SelectListItem { Text = "Algeria", Value = "DZ" };
      yield return new SelectListItem { Text = "Argentina", Value = "AR" };
      yield return new SelectListItem { Text = "Armenia", Value = "AM" };
      yield return new SelectListItem { Text = "Australia", Value = "AU" };
      yield return new SelectListItem { Text = "Austria", Value = "AT" };
      yield return new SelectListItem { Text = "Azerbaijan", Value = "AZ" };
      yield return new SelectListItem { Text = "Bahamas", Value = "BS" };
      yield return new SelectListItem { Text = "Bahrain", Value = "BH" };
      yield return new SelectListItem { Text = "Bangladesh", Value = "BD" };
      yield return new SelectListItem { Text = "Barbados", Value = "BB" };
      yield return new SelectListItem { Text = "Belarus", Value = "BY" };
      yield return new SelectListItem { Text = "Belgium", Value = "BE" };
      yield return new SelectListItem { Text = "Belize", Value = "BZ" };
      yield return new SelectListItem { Text = "Bolivia", Value = "BO" };
      yield return new SelectListItem { Text = "Bosnia and Herzegovina", Value = "BA" };
      yield return new SelectListItem { Text = "Brazil", Value = "BR" };
      yield return new SelectListItem { Text = "Brunei Darussalam", Value = "BN" };
      yield return new SelectListItem { Text = "Bulgaria", Value = "BG" };
      yield return new SelectListItem { Text = "Cambodia", Value = "KH" };
      yield return new SelectListItem { Text = "Cayman Islands", Value = "KY" };
      yield return new SelectListItem { Text = "Chile", Value = "CL" };
      yield return new SelectListItem { Text = "China", Value = "CN" };
      yield return new SelectListItem { Text = "Colombia", Value = "CO" };
      yield return new SelectListItem { Text = "Costa Rica", Value = "CR" };
      yield return new SelectListItem { Text = "Croatia", Value = "HR" };
      yield return new SelectListItem { Text = "Czech Republic", Value = "CZ" };
      yield return new SelectListItem { Text = "Denmark", Value = "DK" };
      yield return new SelectListItem { Text = "Dominican Republic", Value = "DO" };
      yield return new SelectListItem { Text = "Ecuador", Value = "EC" };
      yield return new SelectListItem { Text = "Egypt", Value = "EG" };
      yield return new SelectListItem { Text = "El Salvador", Value = "SV" };
      yield return new SelectListItem { Text = "Estonia", Value = "EE" };
      yield return new SelectListItem { Text = "Ethiopia", Value = "ET" };
      yield return new SelectListItem { Text = "Faroe Islands", Value = "FO" };
      yield return new SelectListItem { Text = "Finland", Value = "FI" };
      yield return new SelectListItem { Text = "France", Value = "FR" };
      yield return new SelectListItem { Text = "Georgia", Value = "GE" };
      yield return new SelectListItem { Text = "Germany", Value = "DE" };
      yield return new SelectListItem { Text = "Greece", Value = "GR" };
      yield return new SelectListItem { Text = "Greenland", Value = "GL" };
      yield return new SelectListItem { Text = "Guatemala", Value = "GT" };
      yield return new SelectListItem { Text = "Honduras", Value = "HN" };
      yield return new SelectListItem { Text = "Hong Kong S.A.R.", Value = "HK" };
      yield return new SelectListItem { Text = "Hungary", Value = "HU" };
      yield return new SelectListItem { Text = "Iceland", Value = "IS" };
      yield return new SelectListItem { Text = "India", Value = "IN" };
      yield return new SelectListItem { Text = "Indonesia", Value = "ID" };
      yield return new SelectListItem { Text = "Iran", Value = "IR" };
      yield return new SelectListItem { Text = "Iraq", Value = "IQ" };
      yield return new SelectListItem { Text = "Ireland", Value = "IE" };
      yield return new SelectListItem { Text = "Israel", Value = "IL" };
      yield return new SelectListItem { Text = "Italy", Value = "IT" };
      yield return new SelectListItem { Text = "Jamaica", Value = "JM" };
      yield return new SelectListItem { Text = "Japan", Value = "JP" };
      yield return new SelectListItem { Text = "Jordan", Value = "JO" };
      yield return new SelectListItem { Text = "Kazakhstan", Value = "KZ" };
      yield return new SelectListItem { Text = "Kenya", Value = "KE" };
      yield return new SelectListItem { Text = "Korea", Value = "KR" };
      yield return new SelectListItem { Text = "Kuwait", Value = "KW" };
      yield return new SelectListItem { Text = "Kyrgyzstan", Value = "KG" };
      yield return new SelectListItem { Text = "Lao P.D.R.", Value = "LA" };
      yield return new SelectListItem { Text = "Latvia", Value = "LV" };
      yield return new SelectListItem { Text = "Lebanon", Value = "LB" };
      yield return new SelectListItem { Text = "Libya", Value = "LY" };
      yield return new SelectListItem { Text = "Liechtenstein", Value = "LI" };
      yield return new SelectListItem { Text = "Lithuania", Value = "LT" };
      yield return new SelectListItem { Text = "Luxembourg", Value = "LU" };
      yield return new SelectListItem { Text = "Malaysia", Value = "MY" };
      yield return new SelectListItem { Text = "Maldives", Value = "MV" };
      yield return new SelectListItem { Text = "Malta", Value = "MT" };
      yield return new SelectListItem { Text = "Mauritius", Value = "MU" };
      yield return new SelectListItem { Text = "Mexico", Value = "MX" };
      yield return new SelectListItem { Text = "Mongolia", Value = "MN" };
      yield return new SelectListItem { Text = "Montenegro", Value = "ME" };
      yield return new SelectListItem { Text = "Morocco", Value = "MA" };
      yield return new SelectListItem { Text = "Nepal", Value = "NP" };
      yield return new SelectListItem { Text = "Netherlands", Value = "NL" };
      yield return new SelectListItem { Text = "New Zealand", Value = "NZ" };
      yield return new SelectListItem { Text = "Nicaragua", Value = "NI" };
      yield return new SelectListItem { Text = "Nigeria", Value = "NG" };
      yield return new SelectListItem { Text = "Norway", Value = "NO" };
      yield return new SelectListItem { Text = "Oman", Value = "OM" };
      yield return new SelectListItem { Text = "Pakistan", Value = "PK" };
      yield return new SelectListItem { Text = "Panama", Value = "PA" };
      yield return new SelectListItem { Text = "Paraguay", Value = "PY" };
      yield return new SelectListItem { Text = "Peru", Value = "PE" };
      yield return new SelectListItem { Text = "Philippines", Value = "PH" };
      yield return new SelectListItem { Text = "Poland", Value = "PL" };
      yield return new SelectListItem { Text = "Portugal", Value = "PT" };
      yield return new SelectListItem { Text = "Principality of Monaco", Value = "MC" };
      yield return new SelectListItem { Text = "Puerto Rico", Value = "PR" };
      yield return new SelectListItem { Text = "Qatar", Value = "QA" };
      yield return new SelectListItem { Text = "Romania", Value = "RO" };
      yield return new SelectListItem { Text = "Russia", Value = "RU" };
      yield return new SelectListItem { Text = "Rwanda", Value = "RW" };
      yield return new SelectListItem { Text = "Saudi Arabia", Value = "SA" };
      yield return new SelectListItem { Text = "Scotland", Value = "AB" };
      yield return new SelectListItem { Text = "Senegal", Value = "SN" };
      yield return new SelectListItem { Text = "Serbia", Value = "RS" };
      yield return new SelectListItem { Text = "Scottland", Value = "UK" };
      yield return new SelectListItem { Text = "Singapore", Value = "SG" };
      yield return new SelectListItem { Text = "Slovakia", Value = "SK" };
      yield return new SelectListItem { Text = "Slovenia", Value = "SI" };
      yield return new SelectListItem { Text = "South Africa", Value = "ZA" };
      yield return new SelectListItem { Text = "Spain", Value = "ES" };
      yield return new SelectListItem { Text = "Sri Lanka", Value = "LK" };
      yield return new SelectListItem { Text = "Sweden", Value = "SE" };
      yield return new SelectListItem { Text = "Switzerland", Value = "CH" };
      yield return new SelectListItem { Text = "Syria", Value = "SY" };
      yield return new SelectListItem { Text = "Taiwan", Value = "TW" };
      yield return new SelectListItem { Text = "Tajikistan", Value = "TJ" };
      yield return new SelectListItem { Text = "Thailand", Value = "TH" };
      yield return new SelectListItem { Text = "Trinidad and Tobago", Value = "TT" };
      yield return new SelectListItem { Text = "Tunisia", Value = "TN" };
      yield return new SelectListItem { Text = "Turkey", Value = "TR" };
      yield return new SelectListItem { Text = "Turkmenistan", Value = "TM" };
      yield return new SelectListItem { Text = "U.A.E.", Value = "AE" };
      yield return new SelectListItem { Text = "Ukraine", Value = "UA" };
      yield return new SelectListItem { Text = "United Kingdom", Value = "GB" };
      yield return new SelectListItem { Text = "Uruguay", Value = "UY" };
      yield return new SelectListItem { Text = "Uzbekistan", Value = "UZ" };
      yield return new SelectListItem { Text = "Venezuela", Value = "VE" };
      yield return new SelectListItem { Text = "Vietnam", Value = "VN" };
      yield return new SelectListItem { Text = "Yemen", Value = "YE" };
      yield return new SelectListItem { Text = "Zimbabwe", Value = "ZW" };
    }


    public virtual IEnumerable<SelectListItem> GetCanadianProvinces()
    {
      yield return new SelectListItem { Text = "", Value = "" };
      yield return new SelectListItem { Text = "Ontario", Value = "ON" };
      yield return new SelectListItem { Text = "Alberta", Value = "AB" };
      yield return new SelectListItem { Text = "British Columbia", Value = "BC" };
      yield return new SelectListItem { Text = "Manitoba", Value = "MB" };
      yield return new SelectListItem { Text = "New Brunswick", Value = "NB" };
      yield return new SelectListItem { Text = "Newfoundland and Labrador", Value = "NL" };
      yield return new SelectListItem { Text = "Northwest Territories", Value = "NT" };
      yield return new SelectListItem { Text = "Nova Scotia", Value = "NS" };
      yield return new SelectListItem { Text = "Nunavut", Value = "NU" };
      yield return new SelectListItem { Text = "Prince Edward Island", Value = "PE" };
      yield return new SelectListItem { Text = "Quebec", Value = "QC" };
      yield return new SelectListItem { Text = "Saskatchewan", Value = "SK" };
      yield return new SelectListItem { Text = "Yukon", Value = "YT" };
    }

    public virtual IEnumerable<SelectListItem> GetAustralianStates()
    {
      yield return new SelectListItem { Text = "", Value = "" };
      yield return new SelectListItem { Text = "ACT", Value = "ACT" };
      yield return new SelectListItem { Text = "NSW", Value = "NSW" };
      yield return new SelectListItem { Text = "NT", Value = "NT" };
      yield return new SelectListItem { Text = "QLD", Value = "QLD" };
      yield return new SelectListItem { Text = "SA", Value = "SA" };
      yield return new SelectListItem { Text = "TAS", Value = "TAS" };
      yield return new SelectListItem { Text = "VIC", Value = "VIC" };
      yield return new SelectListItem { Text = "WA", Value = "WA" };
    }

    public virtual IEnumerable<SelectListItem> GetAmericanStates()
    {
      yield return new SelectListItem { Text = "", Value = "" };
      yield return new SelectListItem { Text = "Alabama", Value = "AL" };
      yield return new SelectListItem { Text = "Alaska", Value = "AK" };
      yield return new SelectListItem { Text = "Arizona", Value = "AZ" };
      yield return new SelectListItem { Text = "Arkansas", Value = "AR" };
      yield return new SelectListItem { Text = "California", Value = "CA" };
      yield return new SelectListItem { Text = "Colorado", Value = "CO" };
      yield return new SelectListItem { Text = "Connecticut", Value = "CT" };
      yield return new SelectListItem { Text = "Delaware", Value = "DE" };
      yield return new SelectListItem { Text = "District of Columbia", Value = "DC" };
      yield return new SelectListItem { Text = "Florida", Value = "FL" };
      yield return new SelectListItem { Text = "Georgia", Value = "GA" };
      yield return new SelectListItem { Text = "Hawaii", Value = "HI" };
      yield return new SelectListItem { Text = "Idaho", Value = "ID" };
      yield return new SelectListItem { Text = "Illinois", Value = "IL" };
      yield return new SelectListItem { Text = "Indiana", Value = "IN" };
      yield return new SelectListItem { Text = "Iowa", Value = "IA" };
      yield return new SelectListItem { Text = "Kansas", Value = "KS" };
      yield return new SelectListItem { Text = "Kentucky", Value = "KY" };
      yield return new SelectListItem { Text = "Louisiana", Value = "LA" };
      yield return new SelectListItem { Text = "Maine", Value = "ME" };
      yield return new SelectListItem { Text = "Maryland", Value = "MD" };
      yield return new SelectListItem { Text = "Massachusetts", Value = "MA" };
      yield return new SelectListItem { Text = "Michigan", Value = "MI" };
      yield return new SelectListItem { Text = "Minnesota", Value = "MN" };
      yield return new SelectListItem { Text = "Mississippi", Value = "MS" };
      yield return new SelectListItem { Text = "Missouri", Value = "MO" };
      yield return new SelectListItem { Text = "Montana", Value = "MT" };
      yield return new SelectListItem { Text = "Nebraska", Value = "NE" };
      yield return new SelectListItem { Text = "Nevada", Value = "NV" };
      yield return new SelectListItem { Text = "New Hampshire", Value = "NH" };
      yield return new SelectListItem { Text = "New Jersey", Value = "NJ" };
      yield return new SelectListItem { Text = "New Mexico", Value = "NM" };
      yield return new SelectListItem { Text = "New York", Value = "NY" };
      yield return new SelectListItem { Text = "North Carolina", Value = "NC" };
      yield return new SelectListItem { Text = "North Dakota", Value = "ND" };
      yield return new SelectListItem { Text = "Ohio", Value = "OH" };
      yield return new SelectListItem { Text = "Oklahoma", Value = "OK" };
      yield return new SelectListItem { Text = "Oregon", Value = "OR" };
      yield return new SelectListItem { Text = "Pennsylvania", Value = "PA" };
      yield return new SelectListItem { Text = "Rhode Island", Value = "RI" };
      yield return new SelectListItem { Text = "South Carolina", Value = "SC" };
      yield return new SelectListItem { Text = "South Dakota", Value = "SD" };
      yield return new SelectListItem { Text = "Tennessee", Value = "TN" };
      yield return new SelectListItem { Text = "Texas", Value = "TX" };
      yield return new SelectListItem { Text = "Utah", Value = "UT" };
      yield return new SelectListItem { Text = "Vermont", Value = "VT" };
      yield return new SelectListItem { Text = "Virginia", Value = "VA" };
      yield return new SelectListItem { Text = "Washington", Value = "WA" };
      yield return new SelectListItem { Text = "West Virginia", Value = "WV" };
      yield return new SelectListItem { Text = "Wisconsin", Value = "WI" };
      yield return new SelectListItem { Text = "Wyoming", Value = "WY" };
    }

    public virtual IEnumerable<SelectListItem> GetWhatLedYouToDonateItems()
    {
      yield return new SelectListItem { Text = "Select One", Value = "Select" };
      yield return new SelectListItem { Text = "Social Media", Value = "GEA-DIGT-FBA" };
      yield return new SelectListItem { Text = "Radio", Value = "RDA-MISC-GTA" };
      yield return new SelectListItem { Text = "E-mail from SickKids", Value = "DML-MISC-IND" };
      yield return new SelectListItem { Text = "Fundraising Event", Value = "EUVCEV" };
      yield return new SelectListItem { Text = "TV Show / Special", Value = "TVA-SKTV999-06" };
      yield return new SelectListItem { Text = "SickKids Leaders Program", Value = "SKL000000" };
      yield return new SelectListItem { Text = "Letter or postcard from SickKids", Value = "DML-MISC-IND" };
      yield return new SelectListItem { Text = "WorkPlace Fundraising", Value = "UEFEMP" };
      yield return new SelectListItem { Text = "Door To Door Canvasser", Value = "DOA-TNI-MIS" };
      yield return new SelectListItem { Text = "Mall Canvasser", Value = "DDA-PO-MIS" };
      yield return new SelectListItem { Text = "Google Search", Value = "NIA-PPCGO-GEN" };
      yield return new SelectListItem { Text = "Other", Value = "GEA-9999" };
    }

    public virtual string GetFinancialInstitutionName(string financialInstitutionID)
    {
      var name = string.Empty;

      switch (financialInstitutionID)
      {
        case "001":
          name = "Bank of Montreal";
          break;
        case "002":
          name = "Bank of Nova Scotia";
          break;
        case "006":
          name = "Banque Nationale Du Canada";
          break;
        case "010":
          name = "Canadian Imperial Bank of Commerce";
          break;
        case "016":
          name = "HSBC Bank Canada";
          break;
        case "039":
          name = "Laurentian Bank of Canada";
          break;
        case "614":
          name = "Tangerine Bank";
          break;
        case "004":
          name = "Toronto-Dominion Canada Trust";
          break;
        case "003":
          name = "Royal Bank of Canada";
          break;
      }

      return name;
    }


    public virtual IEnumerable<SelectListItem> GetTitles()
    {
      yield return new SelectListItem { Text = "", Value = "" };
      yield return new SelectListItem { Text = "Ms.", Value = "Ms." };
      yield return new SelectListItem { Text = "Mrs.", Value = "Mrs." };
      yield return new SelectListItem { Text = "Mr.", Value = "Mr." };
      yield return new SelectListItem { Text = "Mr. & Mrs.", Value = "Mr. & Mrs." };
      yield return new SelectListItem { Text = "Dr.", Value = "Dr." };
    }

    public virtual IEnumerable<SelectListItem> GetExpiryMonths()
    {
      yield return new SelectListItem { Text = "MM", Value = "" };
      yield return new SelectListItem { Text = "01", Value = "01" };
      yield return new SelectListItem { Text = "02", Value = "02" };
      yield return new SelectListItem { Text = "03", Value = "03" };
      yield return new SelectListItem { Text = "04", Value = "04" };
      yield return new SelectListItem { Text = "05", Value = "05" };
      yield return new SelectListItem { Text = "06", Value = "06" };
      yield return new SelectListItem { Text = "07", Value = "07" };
      yield return new SelectListItem { Text = "08", Value = "08" };
      yield return new SelectListItem { Text = "09", Value = "09" };
      yield return new SelectListItem { Text = "10", Value = "10" };
      yield return new SelectListItem { Text = "11", Value = "11" };
      yield return new SelectListItem { Text = "12", Value = "12" };

    }

    public virtual IEnumerable<SelectListItem> GetExpiryYears()
    {
      var currentYear = DateTime.Now.Year;
      var endYear = currentYear + 10;

      yield return new SelectListItem { Text = "YYYY", Value = "" };
      for (int year = currentYear; currentYear <= endYear; currentYear++)
        yield return new SelectListItem { Text = currentYear.ToString(), Value = currentYear.ToString() };
    }
  }
}

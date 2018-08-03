using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace OneTimeControl.Services
{
  public interface IDataService
  {
    IEnumerable<SelectListItem> GetCountries();

    IEnumerable<SelectListItem> GetCanadianProvinces();

    IEnumerable<SelectListItem> GetAustralianStates();

    IEnumerable<SelectListItem> GetAmericanStates();

    IEnumerable<SelectListItem> GetWhatLedYouToDonateItems();

    IEnumerable<SelectListItem> GetExpiryMonths();

    IEnumerable<SelectListItem> GetExpiryYears();

    IEnumerable<SelectListItem> GetTitles();

    string GetFinancialInstitutionName(string financialInstitutionID);
  }
}

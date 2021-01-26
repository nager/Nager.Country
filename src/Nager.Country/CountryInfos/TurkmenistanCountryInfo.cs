using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Turkmenistan
    /// </summary>
    public class TurkmenistanCountryInfo : ICountryInfo
    {
        public string CommonName => "Turkmenistan";
        public string OfficialName => "Turkmenistan";
        public Alpha2Code Alpha2Code => Alpha2Code.TM;
        public Alpha3Code Alpha3Code => Alpha3Code.TKM;
        public int NumericCode => 795;
        public string[] TLD => new [] { ".tm" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.CentralAsia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AF,
            Alpha2Code.IR,
            Alpha2Code.KZ,
            Alpha2Code.UZ,
        };

        public ICurrency[] Currencies => new [] { new TmtCurrency() };
        public string[] CallingCodes => new [] { "993" };
    }
}

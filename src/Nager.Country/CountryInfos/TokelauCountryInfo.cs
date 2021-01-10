using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Tokelau
    /// </summary>
    public class TokelauCountryInfo : ICountryInfo
    {
        public string CommonName => "Tokelau";
        public string OfficialName => "Tokelau";
        public Alpha2Code Alpha2Code => Alpha2Code.TK;
        public Alpha3Code Alpha3Code => Alpha3Code.TKL;
        public int NumericCode => 772;
        public string[] TLD => new [] { ".tk" };

        public Region Region => Region.Oceania;
        public SubRegion SubRegion => SubRegion.Polynesia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new NzdCurrency() };
        public string[] CallingCodes => new [] { "690" };
    }
}

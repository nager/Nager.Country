using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// New Zealand
    /// </summary>
    public class NewZealandCountryInfo : ICountryInfo
    {
        public string CommonName => "New Zealand";
        public string OfficialName => "New Zealand";
        public Alpha2Code Alpha2Code => Alpha2Code.NZ;
        public Alpha3Code Alpha3Code => Alpha3Code.NZL;
        public int NumericCode => 554;
        public string[] TLD => new [] { ".nz" };

        public Region Region => Region.Oceania;
        public SubRegion SubRegion => SubRegion.AustraliaAndNewZealand;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new NzdCurrency() };
        public string[] CallingCodes => new [] { "64" };
    }
}

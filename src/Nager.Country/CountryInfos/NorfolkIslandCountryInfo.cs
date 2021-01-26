using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Norfolk Island
    /// </summary>
    public class NorfolkIslandCountryInfo : ICountryInfo
    {
        public string CommonName => "Norfolk Island";
        public string OfficialName => "Territory of Norfolk Island";
        public Alpha2Code Alpha2Code => Alpha2Code.NF;
        public Alpha3Code Alpha3Code => Alpha3Code.NFK;
        public int NumericCode => 574;
        public string[] TLD => new [] { ".nf" };

        public Region Region => Region.Oceania;
        public SubRegion SubRegion => SubRegion.AustraliaAndNewZealand;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new AudCurrency() };
        public string[] CallingCodes => new [] { "672" };
    }
}

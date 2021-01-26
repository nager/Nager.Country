using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Bouvet Island
    /// </summary>
    public class BouvetIslandCountryInfo : ICountryInfo
    {
        public string CommonName => "Bouvet Island";
        public string OfficialName => "Bouvet Island";
        public Alpha2Code Alpha2Code => Alpha2Code.BV;
        public Alpha3Code Alpha3Code => Alpha3Code.BVT;
        public int NumericCode => 074;
        public string[] TLD => new [] { ".bv" };

        public Region Region => Region.Antarctic;
        public SubRegion SubRegion => SubRegion.None;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new NokCurrency() };
        public string[] CallingCodes => new string[0];
    }
}

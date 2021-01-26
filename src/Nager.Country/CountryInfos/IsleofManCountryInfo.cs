using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Isle of Man
    /// </summary>
    public class IsleofManCountryInfo : ICountryInfo
    {
        public string CommonName => "Isle of Man";
        public string OfficialName => "Isle of Man";
        public Alpha2Code Alpha2Code => Alpha2Code.IM;
        public Alpha3Code Alpha3Code => Alpha3Code.IMN;
        public int NumericCode => 833;
        public string[] TLD => new [] { ".im" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.NorthernEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new GbpCurrency() };
        public string[] CallingCodes => new [] { "44" };
    }
}

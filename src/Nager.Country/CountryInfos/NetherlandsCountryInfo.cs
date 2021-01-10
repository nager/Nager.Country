using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Netherlands
    /// </summary>
    public class NetherlandsCountryInfo : ICountryInfo
    {
        public string CommonName => "Netherlands";
        public string OfficialName => "Netherlands";
        public Alpha2Code Alpha2Code => Alpha2Code.NL;
        public Alpha3Code Alpha3Code => Alpha3Code.NLD;
        public int NumericCode => 528;
        public string[] TLD => new [] { ".nl" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.WesternEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.BE,
            Alpha2Code.DE,
        };

        public ICurrency[] Currencies => new [] { new EurCurrency() };
        public string[] CallingCodes => new [] { "31" };
    }
}

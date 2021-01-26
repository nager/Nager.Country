using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Denmark
    /// </summary>
    public class DenmarkCountryInfo : ICountryInfo
    {
        public string CommonName => "Denmark";
        public string OfficialName => "Kingdom of Denmark";
        public Alpha2Code Alpha2Code => Alpha2Code.DK;
        public Alpha3Code Alpha3Code => Alpha3Code.DNK;
        public int NumericCode => 208;
        public string[] TLD => new [] { ".dk" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.NorthernEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.DE,
        };

        public ICurrency[] Currencies => new [] { new DkkCurrency() };
        public string[] CallingCodes => new [] { "45" };
    }
}

using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Dominican Republic
    /// </summary>
    public class DominicanRepublicCountryInfo : ICountryInfo
    {
        public string CommonName => "Dominican Republic";
        public string OfficialName => "Dominican Republic";
        public Alpha2Code Alpha2Code => Alpha2Code.DO;
        public Alpha3Code Alpha3Code => Alpha3Code.DOM;
        public int NumericCode => 214;
        public string[] TLD => new [] { ".do" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.HT,
        };

        public ICurrency[] Currencies => new [] { new DopCurrency() };
        public string[] CallingCodes => new [] { "1809", "1829", "1849" };
    }
}

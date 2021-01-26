using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Cayman Islands
    /// </summary>
    public class CaymanIslandsCountryInfo : ICountryInfo
    {
        public string CommonName => "Cayman Islands";
        public string OfficialName => "Cayman Islands";
        public Alpha2Code Alpha2Code => Alpha2Code.KY;
        public Alpha3Code Alpha3Code => Alpha3Code.CYM;
        public int NumericCode => 136;
        public string[] TLD => new [] { ".ky" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new KydCurrency() };
        public string[] CallingCodes => new [] { "1345" };
    }
}

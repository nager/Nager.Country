using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Martinique
    /// </summary>
    public class MartiniqueCountryInfo : ICountryInfo
    {
        public string CommonName => "Martinique";
        public string OfficialName => "Martinique";
        public Alpha2Code Alpha2Code => Alpha2Code.MQ;
        public Alpha3Code Alpha3Code => Alpha3Code.MTQ;
        public int NumericCode => 474;
        public string[] TLD => new [] { ".mq" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new EurCurrency() };
        public string[] CallingCodes => new [] { "596" };
    }
}

using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Trinidad and Tobago
    /// </summary>
    public class TrinidadAndTobagoCountryInfo : ICountryInfo
    {
        public string CommonName => "Trinidad and Tobago";
        public string OfficialName => "Republic of Trinidad and Tobago";
        public Alpha2Code Alpha2Code => Alpha2Code.TT;
        public Alpha3Code Alpha3Code => Alpha3Code.TTO;
        public int NumericCode => 780;
        public string[] TLD => new [] { ".tt" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new TtdCurrency() };
        public string[] CallingCodes => new [] { "1868" };
    }
}

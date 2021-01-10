using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Montserrat
    /// </summary>
    public class MontserratCountryInfo : ICountryInfo
    {
        public string CommonName => "Montserrat";
        public string OfficialName => "Montserrat";
        public Alpha2Code Alpha2Code => Alpha2Code.MS;
        public Alpha3Code Alpha3Code => Alpha3Code.MSR;
        public int NumericCode => 500;
        public string[] TLD => new [] { ".ms" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new XcdCurrency() };
        public string[] CallingCodes => new [] { "1664" };
    }
}

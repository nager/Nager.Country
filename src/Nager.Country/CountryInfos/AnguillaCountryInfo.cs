using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Anguilla
    /// </summary>
    public class AnguillaCountryInfo : ICountryInfo
    {
        public string CommonName => "Anguilla";
        public string OfficialName => "Anguilla";
        public Alpha2Code Alpha2Code => Alpha2Code.AI;
        public Alpha3Code Alpha3Code => Alpha3Code.AIA;
        public int NumericCode => 660;
        public string[] TLD => new [] { ".ai" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new XcdCurrency() };
        public string[] CallingCodes => new [] { "1264" };
    }
}

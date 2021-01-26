using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Grenada
    /// </summary>
    public class GrenadaCountryInfo : ICountryInfo
    {
        public string CommonName => "Grenada";
        public string OfficialName => "Grenada";
        public Alpha2Code Alpha2Code => Alpha2Code.GD;
        public Alpha3Code Alpha3Code => Alpha3Code.GRD;
        public int NumericCode => 308;
        public string[] TLD => new [] { ".gd" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new XcdCurrency() };
        public string[] CallingCodes => new [] { "1473" };
    }
}

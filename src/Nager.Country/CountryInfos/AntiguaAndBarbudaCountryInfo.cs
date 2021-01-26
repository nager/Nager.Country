using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Antigua and Barbuda
    /// </summary>
    public class AntiguaAndBarbudaCountryInfo : ICountryInfo
    {
        public string CommonName => "Antigua and Barbuda";
        public string OfficialName => "Antigua and Barbuda";
        public Alpha2Code Alpha2Code => Alpha2Code.AG;
        public Alpha3Code Alpha3Code => Alpha3Code.ATG;
        public int NumericCode => 028;
        public string[] TLD => new [] { ".ag" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new XcdCurrency() };
        public string[] CallingCodes => new [] { "1268" };
    }
}

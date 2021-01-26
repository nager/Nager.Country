using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Guadeloupe
    /// </summary>
    public class GuadeloupeCountryInfo : ICountryInfo
    {
        public string CommonName => "Guadeloupe";
        public string OfficialName => "Guadeloupe";
        public Alpha2Code Alpha2Code => Alpha2Code.GP;
        public Alpha3Code Alpha3Code => Alpha3Code.GLP;
        public int NumericCode => 312;
        public string[] TLD => new [] { ".gp" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new EurCurrency() };
        public string[] CallingCodes => new [] { "590" };
    }
}

using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Uruguay
    /// </summary>
    public class UruguayCountryInfo : ICountryInfo
    {
        public string CommonName => "Uruguay";
        public string OfficialName => "Oriental Republic of Uruguay";
        public Alpha2Code Alpha2Code => Alpha2Code.UY;
        public Alpha3Code Alpha3Code => Alpha3Code.URY;
        public int NumericCode => 858;
        public string[] TLD => new [] { ".uy" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.SouthAmerica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AR,
            Alpha2Code.BR,
        };

        public ICurrency[] Currencies => new [] { new UyuCurrency() };
        public string[] CallingCodes => new [] { "598" };
    }
}

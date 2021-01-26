using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Suriname
    /// </summary>
    public class SurinameCountryInfo : ICountryInfo
    {
        public string CommonName => "Suriname";
        public string OfficialName => "Republic of Suriname";
        public Alpha2Code Alpha2Code => Alpha2Code.SR;
        public Alpha3Code Alpha3Code => Alpha3Code.SUR;
        public int NumericCode => 740;
        public string[] TLD => new [] { ".sr" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.SouthAmerica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.BR,
            Alpha2Code.GF,
            Alpha2Code.GY,
        };

        public ICurrency[] Currencies => new [] { new SrdCurrency() };
        public string[] CallingCodes => new [] { "597" };
    }
}

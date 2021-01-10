using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// French Southern and Antarctic Lands
    /// </summary>
    public class FrenchSouthernAndAntarcticLandsCountryInfo : ICountryInfo
    {
        public string CommonName => "French Southern and Antarctic Lands";
        public string OfficialName => "Territory of the French Southern and Antarctic Lands";
        public Alpha2Code Alpha2Code => Alpha2Code.TF;
        public Alpha3Code Alpha3Code => Alpha3Code.ATF;
        public int NumericCode => 260;
        public string[] TLD => new [] { ".tf" };

        public Region Region => Region.Antarctic;
        public SubRegion SubRegion => SubRegion.None;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new EurCurrency() };
        public string[] CallingCodes => new string[0];
    }
}

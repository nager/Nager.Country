using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Cape Verde
    /// </summary>
    public class CapeVerdeCountryInfo : ICountryInfo
    {
        public string CommonName => "Cape Verde";
        public string OfficialName => "Republic of Cabo Verde";
        public Alpha2Code Alpha2Code => Alpha2Code.CV;
        public Alpha3Code Alpha3Code => Alpha3Code.CPV;
        public int NumericCode => 132;
        public string[] TLD => new [] { ".cv" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.WesternAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new CveCurrency() };
        public string[] CallingCodes => new [] { "238" };
    }
}

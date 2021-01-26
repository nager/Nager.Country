using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Finland
    /// </summary>
    public class FinlandCountryInfo : ICountryInfo
    {
        public string CommonName => "Finland";
        public string OfficialName => "Republic of Finland";
        public Alpha2Code Alpha2Code => Alpha2Code.FI;
        public Alpha3Code Alpha3Code => Alpha3Code.FIN;
        public int NumericCode => 246;
        public string[] TLD => new [] { ".fi" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.NorthernEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.NO,
            Alpha2Code.SE,
            Alpha2Code.RU,
        };

        public ICurrency[] Currencies => new [] { new EurCurrency() };
        public string[] CallingCodes => new [] { "358" };
    }
}

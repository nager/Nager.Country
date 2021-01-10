using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Ireland
    /// </summary>
    public class IrelandCountryInfo : ICountryInfo
    {
        public string CommonName => "Ireland";
        public string OfficialName => "Republic of Ireland";
        public Alpha2Code Alpha2Code => Alpha2Code.IE;
        public Alpha3Code Alpha3Code => Alpha3Code.IRL;
        public int NumericCode => 372;
        public string[] TLD => new [] { ".ie" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.NorthernEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.GB,
        };

        public ICurrency[] Currencies => new [] { new EurCurrency() };
        public string[] CallingCodes => new [] { "353" };
    }
}

using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Azerbaijan
    /// </summary>
    public class AzerbaijanCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Azerbaijan";
        ///<inheritdoc/>
        public string OfficialName => "Republic of Azerbaijan";
        ///<inheritdoc/>
        public string NativeName => "Azərbaycan";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.AZ;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.AZE;
        ///<inheritdoc/>
        public int NumericCode => 031;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".az" };

        ///<inheritdoc/>
        public Region Region => Region.Asia;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternAsia;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AM,
            Alpha2Code.GE,
            Alpha2Code.IR,
            Alpha2Code.RU,
            Alpha2Code.TR,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new AznCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "994" };
    }
}

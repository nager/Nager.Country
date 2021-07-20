using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Netherlands
    /// </summary>
    public class NetherlandsCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Netherlands";
        ///<inheritdoc/>
        public string OfficialName => "Netherlands";
        ///<inheritdoc/>
        public string NativeName => "Nederland";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.NL;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.NLD;
        ///<inheritdoc/>
        public int NumericCode => 528;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".nl" };

        ///<inheritdoc/>
        public Region Region => Region.Europe;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternEurope;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.BE,
            Alpha2Code.DE,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new EurCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "31" };
    }
}

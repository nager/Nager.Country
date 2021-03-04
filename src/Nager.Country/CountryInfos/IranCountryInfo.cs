using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Iran
    /// </summary>
    public class IranCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Iran";
        ///<inheritdoc/>
        public string OfficialName => "Islamic Republic of Iran";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.IR;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.IRN;
        ///<inheritdoc/>
        public int NumericCode => 364;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".ir", "ایران." };

        ///<inheritdoc/>
        public Region Region => Region.Asia;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthernAsia;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AF,
            Alpha2Code.AM,
            Alpha2Code.AZ,
            Alpha2Code.IQ,
            Alpha2Code.PK,
            Alpha2Code.TR,
            Alpha2Code.TM,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new IrrCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "98" };
    }
}

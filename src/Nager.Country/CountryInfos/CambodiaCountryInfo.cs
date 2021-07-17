using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Cambodia
    /// </summary>
    public class CambodiaCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Cambodia";
        ///<inheritdoc/>
        public string OfficialName => "Kingdom of Cambodia";
        ///<inheritdoc/>
        public string NativeName => "Kâmpŭchéa";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.KH;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.KHM;
        ///<inheritdoc/>
        public int NumericCode => 116;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".kh" };

        ///<inheritdoc/>
        public Region Region => Region.Asia;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthEasternAsia;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.LA,
            Alpha2Code.TH,
            Alpha2Code.VN,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new KhrCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "855" };
    }
}

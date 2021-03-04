using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Timor-Leste
    /// </summary>
    public class TimorLesteCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Timor-Leste";
        ///<inheritdoc/>
        public string OfficialName => "Democratic Republic of Timor-Leste";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.TL;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.TLS;
        ///<inheritdoc/>
        public int NumericCode => 626;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".tl" };

        ///<inheritdoc/>
        public Region Region => Region.Asia;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthEasternAsia;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.ID,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new UsdCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "670" };
    }
}

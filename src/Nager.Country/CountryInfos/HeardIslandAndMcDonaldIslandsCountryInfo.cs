using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Heard Island and McDonald Islands
    /// </summary>
    public class HeardIslandAndMcDonaldIslandsCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Heard Island and McDonald Islands";
        ///<inheritdoc/>
        public string OfficialName => "Heard Island and McDonald Islands";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.HM;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.HMD;
        ///<inheritdoc/>
        public int NumericCode => 334;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".hm", ".aq" };

        ///<inheritdoc/>
        public Region Region => Region.Antarctic;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.None;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new AudCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new string[0];
    }
}

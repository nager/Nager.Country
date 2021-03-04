using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Brunei
    /// </summary>
    public class BruneiCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Brunei";
        ///<inheritdoc/>
        public string OfficialName => "Nation of Brunei, Abode of Peace";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.BN;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.BRN;
        ///<inheritdoc/>
        public int NumericCode => 096;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".bn" };

        ///<inheritdoc/>
        public Region Region => Region.Asia;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthEasternAsia;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.MY,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new BndCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "673" };
    }
}

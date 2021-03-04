using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Vietnam
    /// </summary>
    public class VietnamCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Vietnam";
        ///<inheritdoc/>
        public string OfficialName => "Socialist Republic of Vietnam";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.VN;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.VNM;
        ///<inheritdoc/>
        public int NumericCode => 704;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".vn" };

        ///<inheritdoc/>
        public Region Region => Region.Asia;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthEasternAsia;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.KH,
            Alpha2Code.CN,
            Alpha2Code.LA,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new VndCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "84" };
    }
}

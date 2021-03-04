using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Kazakhstan
    /// </summary>
    public class KazakhstanCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Kazakhstan";
        ///<inheritdoc/>
        public string OfficialName => "Republic of Kazakhstan";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.KZ;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.KAZ;
        ///<inheritdoc/>
        public int NumericCode => 398;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".kz", ".қаз" };

        ///<inheritdoc/>
        public Region Region => Region.Asia;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.CentralAsia;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.CN,
            Alpha2Code.KG,
            Alpha2Code.RU,
            Alpha2Code.TM,
            Alpha2Code.UZ,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new KztCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "76", "77" };
    }
}

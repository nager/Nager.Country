using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// New Caledonia
    /// </summary>
    public class NewCaledoniaCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "New Caledonia";
        ///<inheritdoc/>
        public string OfficialName => "New Caledonia";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.NC;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.NCL;
        ///<inheritdoc/>
        public int NumericCode => 540;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".nc" };

        ///<inheritdoc/>
        public Region Region => Region.Oceania;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.Melanesia;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new XpfCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "687" };
    }
}

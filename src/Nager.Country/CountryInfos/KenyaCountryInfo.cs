using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Kenya
    /// </summary>
    public class KenyaCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Kenya";
        ///<inheritdoc/>
        public string OfficialName => "Republic of Kenya";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.KE;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.KEN;
        ///<inheritdoc/>
        public int NumericCode => 404;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".ke" };

        ///<inheritdoc/>
        public Region Region => Region.Africa;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.ET,
            Alpha2Code.SO,
            Alpha2Code.SS,
            Alpha2Code.TZ,
            Alpha2Code.UG,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new KesCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "254" };
    }
}

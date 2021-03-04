using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Uganda
    /// </summary>
    public class UgandaCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Uganda";
        ///<inheritdoc/>
        public string OfficialName => "Republic of Uganda";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.UG;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.UGA;
        ///<inheritdoc/>
        public int NumericCode => 800;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".ug" };

        ///<inheritdoc/>
        public Region Region => Region.Africa;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.CD,
            Alpha2Code.KE,
            Alpha2Code.RW,
            Alpha2Code.SS,
            Alpha2Code.TZ,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new UgxCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "256" };
    }
}

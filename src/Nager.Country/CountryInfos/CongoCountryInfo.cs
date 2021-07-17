using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// DR Congo
    /// </summary>
    public class CongoCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "DR Congo";
        ///<inheritdoc/>
        public string OfficialName => "Democratic Republic of the Congo";
        ///<inheritdoc/>
        public string NativeName => "République du Congo";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.CD;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.COD;
        ///<inheritdoc/>
        public int NumericCode => 180;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".cd" };

        ///<inheritdoc/>
        public Region Region => Region.Africa;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.MiddleAfrica;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AO,
            Alpha2Code.BI,
            Alpha2Code.CF,
            Alpha2Code.CG,
            Alpha2Code.RW,
            Alpha2Code.SS,
            Alpha2Code.TZ,
            Alpha2Code.UG,
            Alpha2Code.ZM,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new CdfCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "243" };
    }
}

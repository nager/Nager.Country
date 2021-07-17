using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Burundi
    /// </summary>
    public class BurundiCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Burundi";
        ///<inheritdoc/>
        public string OfficialName => "Republic of Burundi";
        ///<inheritdoc/>
        public string NativeName => "Burundi";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.BI;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.BDI;
        ///<inheritdoc/>
        public int NumericCode => 108;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".bi" };

        ///<inheritdoc/>
        public Region Region => Region.Africa;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.CD,
            Alpha2Code.RW,
            Alpha2Code.TZ,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new BifCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "257" };
    }
}

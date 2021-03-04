using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Namibia
    /// </summary>
    public class NamibiaCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Namibia";
        ///<inheritdoc/>
        public string OfficialName => "Republic of Namibia";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.NA;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.NAM;
        ///<inheritdoc/>
        public int NumericCode => 516;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".na" };

        ///<inheritdoc/>
        public Region Region => Region.Africa;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthernAfrica;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AO,
            Alpha2Code.BW,
            Alpha2Code.ZA,
            Alpha2Code.ZM,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new ICurrency[] { new NadCurrency(), new ZarCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "264" };
    }
}

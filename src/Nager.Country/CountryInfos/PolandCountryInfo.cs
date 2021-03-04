using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Poland
    /// </summary>
    public class PolandCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Poland";
        ///<inheritdoc/>
        public string OfficialName => "Republic of Poland";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.PL;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.POL;
        ///<inheritdoc/>
        public int NumericCode => 616;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".pl" };

        ///<inheritdoc/>
        public Region Region => Region.Europe;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.EasternEurope;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.BY,
            Alpha2Code.CZ,
            Alpha2Code.DE,
            Alpha2Code.LT,
            Alpha2Code.RU,
            Alpha2Code.SK,
            Alpha2Code.UA,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new PlnCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "48" };
    }
}

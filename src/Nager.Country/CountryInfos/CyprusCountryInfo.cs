using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Cyprus
    /// </summary>
    public class CyprusCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Cyprus";
        ///<inheritdoc/>
        public string OfficialName => "Republic of Cyprus";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.CY;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.CYP;
        ///<inheritdoc/>
        public int NumericCode => 196;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".cy" };

        ///<inheritdoc/>
        public Region Region => Region.Europe;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.EasternEurope;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.GB,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new EurCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "357" };
    }
}

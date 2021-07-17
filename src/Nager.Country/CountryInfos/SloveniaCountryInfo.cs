using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Slovenia
    /// </summary>
    public class SloveniaCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Slovenia";
        ///<inheritdoc/>
        public string OfficialName => "Republic of Slovenia";
        ///<inheritdoc/>
        public string NativeName => "Slovenija";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.SI;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.SVN;
        ///<inheritdoc/>
        public int NumericCode => 705;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".si" };

        ///<inheritdoc/>
        public Region Region => Region.Europe;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthernEurope;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AT,
            Alpha2Code.HR,
            Alpha2Code.IT,
            Alpha2Code.HU,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new EurCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "386" };
    }
}

using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Norway
    /// </summary>
    public class NorwayCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Norway";
        ///<inheritdoc/>
        public string OfficialName => "Kingdom of Norway";
        ///<inheritdoc/>
        public string NativeName => "Norge";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.NO;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.NOR;
        ///<inheritdoc/>
        public int NumericCode => 578;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".no" };

        ///<inheritdoc/>
        public Region Region => Region.Europe;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.NorthernEurope;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.FI,
            Alpha2Code.SE,
            Alpha2Code.RU,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new NokCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "47" };
    }
}

using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Latvia
    /// </summary>
    public class LatviaCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Latvia";
        ///<inheritdoc/>
        public string OfficialName => "Republic of Latvia";
        ///<inheritdoc/>
        public string NativeName => "Latvija";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.LV;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.LVA;
        ///<inheritdoc/>
        public int NumericCode => 428;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".lv" };

        ///<inheritdoc/>
        public Region Region => Region.Europe;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.NorthernEurope;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.BY,
            Alpha2Code.EE,
            Alpha2Code.LT,
            Alpha2Code.RU,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new EurCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "371" };
    }
}

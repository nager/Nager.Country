using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Russia
    /// </summary>
    public class RussiaCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Russia";
        ///<inheritdoc/>
        public string OfficialName => "Russian Federation";
        ///<inheritdoc/>
        public string NativeName => "Россия";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.RU;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.RUS;
        ///<inheritdoc/>
        public int NumericCode => 643;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".ru", ".su", ".рф" };

        ///<inheritdoc/>
        public Region Region => Region.Europe;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.EasternEurope;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AZ,
            Alpha2Code.BY,
            Alpha2Code.CN,
            Alpha2Code.EE,
            Alpha2Code.FI,
            Alpha2Code.GE,
            Alpha2Code.KZ,
            Alpha2Code.KP,
            Alpha2Code.LV,
            Alpha2Code.LT,
            Alpha2Code.MN,
            Alpha2Code.NO,
            Alpha2Code.PL,
            Alpha2Code.UA,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new RubCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "7" };
    }
}

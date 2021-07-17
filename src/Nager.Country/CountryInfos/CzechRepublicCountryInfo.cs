using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Czech Republic
    /// </summary>
    public class CzechRepublicCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Czechia";
        ///<inheritdoc/>
        public string OfficialName => "Czech Republic";
        ///<inheritdoc/>
        public string NativeName => "Česká republika";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.CZ;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.CZE;
        ///<inheritdoc/>
        public int NumericCode => 203;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".cz" };

        ///<inheritdoc/>
        public Region Region => Region.Europe;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.EasternEurope;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AT,
            Alpha2Code.DE,
            Alpha2Code.PL,
            Alpha2Code.SK,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new CzkCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "420" };
    }
}

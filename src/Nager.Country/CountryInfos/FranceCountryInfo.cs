using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// France
    /// </summary>
    public class FranceCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "France";
        ///<inheritdoc/>
        public string OfficialName => "French Republic";
        ///<inheritdoc/>
        public string NativeName => "France";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.FR;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.FRA;
        ///<inheritdoc/>
        public int NumericCode => 250;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".fr" };

        ///<inheritdoc/>
        public Region Region => Region.Europe;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternEurope;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AD,
            Alpha2Code.BE,
            Alpha2Code.DE,
            Alpha2Code.IT,
            Alpha2Code.LU,
            Alpha2Code.MC,
            Alpha2Code.ES,
            Alpha2Code.CH,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new EurCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "33" };
    }
}

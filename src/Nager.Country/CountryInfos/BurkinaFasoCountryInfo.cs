using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Burkina Faso
    /// </summary>
    public class BurkinaFasoCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Burkina Faso";
        ///<inheritdoc/>
        public string OfficialName => "Burkina Faso";
        ///<inheritdoc/>
        public string NativeName => "Burkina Faso";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.BF;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.BFA;
        ///<inheritdoc/>
        public int NumericCode => 854;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".bf" };

        ///<inheritdoc/>
        public Region Region => Region.Africa;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternAfrica;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.BJ,
            Alpha2Code.CI,
            Alpha2Code.GH,
            Alpha2Code.ML,
            Alpha2Code.NE,
            Alpha2Code.TG,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new XofCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "226" };
    }
}

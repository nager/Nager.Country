using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Venezuela
    /// </summary>
    public class VenezuelaCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Venezuela";
        ///<inheritdoc/>
        public string OfficialName => "Bolivarian Republic of Venezuela";
        ///<inheritdoc/>
        public string NativeName => "Venezuela";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.VE;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.VEN;
        ///<inheritdoc/>
        public int NumericCode => 862;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".ve" };

        ///<inheritdoc/>
        public Region Region => Region.Americas;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthAmerica;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.BR,
            Alpha2Code.CO,
            Alpha2Code.GY,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new VefCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "58" };
    }
}

using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Chile
    /// </summary>
    public class ChileCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Chile";
        ///<inheritdoc/>
        public string OfficialName => "Republic of Chile";
        ///<inheritdoc/>
        public string NativeName => "Chile";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.CL;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.CHL;
        ///<inheritdoc/>
        public int NumericCode => 152;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".cl" };

        ///<inheritdoc/>
        public Region Region => Region.Americas;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthAmerica;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AR,
            Alpha2Code.BO,
            Alpha2Code.PE,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new ClpCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "56" };
    }
}

using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Aruba
    /// </summary>
    public class ArubaCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Aruba";
        ///<inheritdoc/>
        public string OfficialName => "Aruba";
        ///<inheritdoc/>
        public string NativeName => "Aruba";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.AW;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.ABW;
        ///<inheritdoc/>
        public int NumericCode => 533;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".aw" };

        ///<inheritdoc/>
        public Region Region => Region.Americas;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.Caribbean;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new AwgCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "297" };
    }
}

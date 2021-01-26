using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Aruba
    /// </summary>
    public class ArubaCountryInfo : ICountryInfo
    {
        public string CommonName => "Aruba";
        public string OfficialName => "Aruba";
        public Alpha2Code Alpha2Code => Alpha2Code.AW;
        public Alpha3Code Alpha3Code => Alpha3Code.ABW;
        public int NumericCode => 533;
        public string[] TLD => new [] { ".aw" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new AwgCurrency() };
        public string[] CallingCodes => new [] { "297" };
    }
}

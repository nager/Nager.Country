using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Iceland
    /// </summary>
    public class IcelandCountryInfo : ICountryInfo
    {
        public string CommonName => "Iceland";
        public string OfficialName => "Iceland";
        public Alpha2Code Alpha2Code => Alpha2Code.IS;
        public Alpha3Code Alpha3Code => Alpha3Code.ISL;
        public int NumericCode => 352;
        public string[] TLD => new [] { ".is" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.NorthernEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new IskCurrency() };
        public string[] CallingCodes => new [] { "354" };
    }
}

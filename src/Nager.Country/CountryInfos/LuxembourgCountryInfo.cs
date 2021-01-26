using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Luxembourg
    /// </summary>
    public class LuxembourgCountryInfo : ICountryInfo
    {
        public string CommonName => "Luxembourg";
        public string OfficialName => "Grand Duchy of Luxembourg";
        public Alpha2Code Alpha2Code => Alpha2Code.LU;
        public Alpha3Code Alpha3Code => Alpha3Code.LUX;
        public int NumericCode => 442;
        public string[] TLD => new [] { ".lu" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.WesternEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.BE,
            Alpha2Code.FR,
            Alpha2Code.DE,
        };

        public ICurrency[] Currencies => new [] { new EurCurrency() };
        public string[] CallingCodes => new [] { "352" };
    }
}

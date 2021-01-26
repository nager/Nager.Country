using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Brazil
    /// </summary>
    public class BrazilCountryInfo : ICountryInfo
    {
        public string CommonName => "Brazil";
        public string OfficialName => "Federative Republic of Brazil";
        public Alpha2Code Alpha2Code => Alpha2Code.BR;
        public Alpha3Code Alpha3Code => Alpha3Code.BRA;
        public int NumericCode => 076;
        public string[] TLD => new [] { ".br" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.SouthAmerica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AR,
            Alpha2Code.BO,
            Alpha2Code.CO,
            Alpha2Code.GF,
            Alpha2Code.GY,
            Alpha2Code.PY,
            Alpha2Code.PE,
            Alpha2Code.SR,
            Alpha2Code.UY,
            Alpha2Code.VE,
        };

        public ICurrency[] Currencies => new [] { new BrlCurrency() };
        public string[] CallingCodes => new [] { "55" };
    }
}

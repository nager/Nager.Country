using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Paraguay
    /// </summary>
    public class ParaguayCountryInfo : ICountryInfo
    {
        public string CommonName => "Paraguay";
        public string OfficialName => "Republic of Paraguay";
        public Alpha2Code Alpha2Code => Alpha2Code.PY;
        public Alpha3Code Alpha3Code => Alpha3Code.PRY;
        public int NumericCode => 600;
        public string[] TLD => new [] { ".py" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.SouthAmerica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AR,
            Alpha2Code.BO,
            Alpha2Code.BR,
        };

        public ICurrency[] Currencies => new [] { new PygCurrency() };
        public string[] CallingCodes => new [] { "595" };
    }
}

using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Peru
    /// </summary>
    public class PeruCountryInfo : ICountryInfo
    {
        public string CommonName => "Peru";
        public string OfficialName => "Republic of Peru";
        public Alpha2Code Alpha2Code => Alpha2Code.PE;
        public Alpha3Code Alpha3Code => Alpha3Code.PER;
        public int NumericCode => 604;
        public string[] TLD => new [] { ".pe" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.SouthAmerica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.BO,
            Alpha2Code.BR,
            Alpha2Code.CL,
            Alpha2Code.CO,
            Alpha2Code.EC,
        };

        public ICurrency[] Currencies => new [] { new PenCurrency() };
        public string[] CallingCodes => new [] { "51" };
    }
}

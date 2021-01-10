using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Saint Helena
    /// </summary>
    public class SaintHelenaCountryInfo : ICountryInfo
    {
        public string CommonName => "Saint Helena, Ascension and Tristan da Cunha";
        public string OfficialName => "Saint Helena, Ascension and Tristan da Cunha";
        public Alpha2Code Alpha2Code => Alpha2Code.SH;
        public Alpha3Code Alpha3Code => Alpha3Code.SHN;
        public int NumericCode => 654;
        public string[] TLD => new[] { ".sh", ".ac" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.WesternAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AR,
            Alpha2Code.BR,
            Alpha2Code.CL,
            Alpha2Code.PY,
            Alpha2Code.PE,
        };

        public ICurrency[] Currencies => new ICurrency[] { new ShpCurrency(), new GbpCurrency() };
        public string[] CallingCodes => new[] { "290", "247" };
    }
}

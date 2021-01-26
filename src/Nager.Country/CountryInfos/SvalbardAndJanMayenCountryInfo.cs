using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Svalbard and Jan Mayen
    /// </summary>
    public class SvalbardAndJanMayenCountryInfo : ICountryInfo
    {
        public string CommonName => "Svalbard and Jan Mayen";
        public string OfficialName => "Svalbard og Jan Mayen";
        public Alpha2Code Alpha2Code => Alpha2Code.SJ;
        public Alpha3Code Alpha3Code => Alpha3Code.SJM;
        public int NumericCode => 744;
        public string[] TLD => new [] { ".sj" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.NorthernEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new NokCurrency() };
        public string[] CallingCodes => new [] { "4779" };
    }
}

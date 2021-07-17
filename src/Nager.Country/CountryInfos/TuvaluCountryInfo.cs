using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Tuvalu
    /// </summary>
    public class TuvaluCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Tuvalu";
        ///<inheritdoc/>
        public string OfficialName => "Tuvalu";
        ///<inheritdoc/>
        public string NativeName => "Tuvalu";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.TV;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.TUV;
        ///<inheritdoc/>
        public int NumericCode => 798;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".tv" };

        ///<inheritdoc/>
        public Region Region => Region.Oceania;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.Polynesia;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new AudCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "688" };
    }
}

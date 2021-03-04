using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Syria
    /// </summary>
    public class SyriaCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Syria";
        ///<inheritdoc/>
        public string OfficialName => "Syrian Arab Republic";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.SY;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.SYR;
        ///<inheritdoc/>
        public int NumericCode => 760;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".sy", "سوريا." };

        ///<inheritdoc/>
        public Region Region => Region.Asia;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternAsia;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.IQ,
            Alpha2Code.IL,
            Alpha2Code.JO,
            Alpha2Code.LB,
            Alpha2Code.TR,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new SypCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "963" };
    }
}

using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Svalbard and Jan Mayen
    /// </summary>
    public class SvalbardAndJanMayenCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Svalbard and Jan Mayen";
        ///<inheritdoc/>
        public string OfficialName => "Svalbard og Jan Mayen";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.SJ;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.SJM;
        ///<inheritdoc/>
        public int NumericCode => 744;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".sj" };

        ///<inheritdoc/>
        public Region Region => Region.Europe;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.NorthernEurope;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new NokCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "4779" };
    }
}

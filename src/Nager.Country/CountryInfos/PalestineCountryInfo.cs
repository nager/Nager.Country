using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Palestine
    /// </summary>
    public class PalestineCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Palestine";
        ///<inheritdoc/>
        public string OfficialName => "State of Palestine";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.PS;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.PSE;
        ///<inheritdoc/>
        public int NumericCode => 275;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".ps", "فلسطين." };

        ///<inheritdoc/>
        public Region Region => Region.Asia;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternAsia;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.IL,
            Alpha2Code.EG,
            Alpha2Code.JO,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new IlsCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "970" };
    }
}

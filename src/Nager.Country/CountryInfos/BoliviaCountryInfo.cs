using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Bolivia
    /// </summary>
    public class BoliviaCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Bolivia";
        ///<inheritdoc/>
        public string OfficialName => "Plurinational State of Bolivia";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.BO;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.BOL;
        ///<inheritdoc/>
        public int NumericCode => 068;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".bo" };

        ///<inheritdoc/>
        public Region Region => Region.Americas;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthAmerica;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AR,
            Alpha2Code.BR,
            Alpha2Code.CL,
            Alpha2Code.PY,
            Alpha2Code.PE,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new BobCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "591" };
    }
}

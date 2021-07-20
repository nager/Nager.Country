using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Brazil
    /// </summary>
    public class BrazilCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Brazil";
        ///<inheritdoc/>
        public string OfficialName => "Federative Republic of Brazil";
        ///<inheritdoc/>
        public string NativeName => "Brasil";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.BR;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.BRA;
        ///<inheritdoc/>
        public int NumericCode => 076;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".br" };

        ///<inheritdoc/>
        public Region Region => Region.Americas;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthAmerica;

        ///<inheritdoc/>
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

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new BrlCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "55" };
    }
}

namespace Nager.Country.Currencies
{
    /// <summary>
    /// Nok Currency
    /// </summary>
    public class NokCurrency : ICurrency
    {
        ///<inheritdoc/>
        public string Symbol => "kr";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "NOK";

        ///<inheritdoc/>
        public string NumericCode => "578";

        ///<inheritdoc/>
        public string Name => "Norwegian Krone";
    }
}

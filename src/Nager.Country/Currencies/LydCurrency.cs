namespace Nager.Country.Currencies
{
    /// <summary>
    /// Lyd Currency
    /// </summary>
    public class LydCurrency : ICurrency
    {
        ///<inheritdoc/>
        public string Symbol => "د.ل.‏";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "LYD";

        ///<inheritdoc/>
        public string NumericCode => "434";

        ///<inheritdoc/>
        public string Name => "Libyan Dinar";
    }
}

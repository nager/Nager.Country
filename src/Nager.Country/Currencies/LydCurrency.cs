namespace Nager.Country.Currencies
{
    public class LydCurrency : ICurrency
    {
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

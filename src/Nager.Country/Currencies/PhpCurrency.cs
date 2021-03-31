namespace Nager.Country.Currencies
{
    public class PhpCurrency : ICurrency
    {
        ///<inheritdoc/>
        public string Symbol => "₱";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "PHP";

        ///<inheritdoc/>
        public string NumericCode => "608";

        ///<inheritdoc/>
        public string Name => "Philippine Piso";
    }
}

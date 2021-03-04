namespace Nager.Country.Currencies
{
    public class BsdCurrency : ICurrency
    {
        public string Symbol => "$";

        ///<inheritdoc/>
        public string Singular => "dollar";

        ///<inheritdoc/>
        public string Plural => "dollars";

        ///<inheritdoc/>
        public string IsoCode => "BSD";

        ///<inheritdoc/>
        public string NumericCode => "044";

        ///<inheritdoc/>
        public string Name => "Bahamian dollar";
    }
}

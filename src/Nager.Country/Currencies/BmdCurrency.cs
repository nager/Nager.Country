namespace Nager.Country.Currencies
{
    public class BmdCurrency : ICurrency
    {
        public string Symbol => "$";

        ///<inheritdoc/>
        public string Singular => "dollar";

        ///<inheritdoc/>
        public string Plural => "dollars";

        ///<inheritdoc/>
        public string IsoCode => "BMD";

        ///<inheritdoc/>
        public string NumericCode => "060";

        ///<inheritdoc/>
        public string Name => "Bermudian dollar";
    }
}

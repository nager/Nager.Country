namespace Nager.Country.Currencies
{
    public class CadCurrency : ICurrency
    {
        public string Symbol => "$";

        ///<inheritdoc/>
        public string Singular => "dollar";

        ///<inheritdoc/>
        public string Plural => "dollars";

        ///<inheritdoc/>
        public string IsoCode => "CAD";

        ///<inheritdoc/>
        public string NumericCode => "124";

        ///<inheritdoc/>
        public string Name => "Canadian dollar";
    }
}

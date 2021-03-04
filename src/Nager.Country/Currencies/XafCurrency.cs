namespace Nager.Country.Currencies
{
    public class XafCurrency : ICurrency
    {
        public string Symbol => "FCFA";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "XAF";

        ///<inheritdoc/>
        public string NumericCode => "950";

        ///<inheritdoc/>
        public string Name => "Central African CFA Franc";
    }
}

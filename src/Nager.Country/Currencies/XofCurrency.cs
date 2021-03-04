namespace Nager.Country.Currencies
{
    public class XofCurrency : ICurrency
    {
        public string Symbol => "CFA";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "XOF";

        ///<inheritdoc/>
        public string NumericCode => "952";

        ///<inheritdoc/>
        public string Name => "West African CFA Franc";
    }
}

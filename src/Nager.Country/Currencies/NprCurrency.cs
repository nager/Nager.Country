namespace Nager.Country.Currencies
{
    public class NprCurrency : ICurrency
    {
        public string Symbol => "रु";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "NPR";

        ///<inheritdoc/>
        public string NumericCode => "524";

        ///<inheritdoc/>
        public string Name => "Nepalese Rupee";
    }
}

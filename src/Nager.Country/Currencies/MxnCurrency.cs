namespace Nager.Country.Currencies
{
    public class MxnCurrency : ICurrency
    {
        public string Symbol => "$";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "MXN";

        ///<inheritdoc/>
        public string NumericCode => "484";

        ///<inheritdoc/>
        public string Name => "Mexican Peso";
    }
}

namespace Nager.Country.Currencies
{
    public class IlsCurrency : ICurrency
    {
        ///<inheritdoc/>
        public string Symbol => "₪";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "ILS";

        ///<inheritdoc/>
        public string NumericCode => "376";

        ///<inheritdoc/>
        public string Name => "Israeli New Shekel";
    }
}

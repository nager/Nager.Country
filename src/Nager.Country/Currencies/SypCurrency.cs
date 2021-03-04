namespace Nager.Country.Currencies
{
    public class SypCurrency : ICurrency
    {
        public string Symbol => "ل.س.‏";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "SYP";

        ///<inheritdoc/>
        public string NumericCode => "760";

        ///<inheritdoc/>
        public string Name => "Syrian Pound";
    }
}

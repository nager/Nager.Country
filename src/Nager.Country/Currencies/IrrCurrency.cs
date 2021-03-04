namespace Nager.Country.Currencies
{
    public class IrrCurrency : ICurrency
    {
        public string Symbol => "ريال";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "IRR";

        ///<inheritdoc/>
        public string NumericCode => "364";

        ///<inheritdoc/>
        public string Name => "Iranian Rial";
    }
}

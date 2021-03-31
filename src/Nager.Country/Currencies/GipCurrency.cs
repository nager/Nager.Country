namespace Nager.Country.Currencies
{
    public class GipCurrency : ICurrency
    {
        ///<inheritdoc/>
        public string Symbol => "£";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "GIP";

        ///<inheritdoc/>
        public string NumericCode => "292";

        ///<inheritdoc/>
        public string Name => "Gibraltar pound";
    }
}

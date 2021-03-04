namespace Nager.Country.Currencies
{
    public class SrdCurrency : ICurrency
    {
        public string Symbol => "$";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "SRD";

        ///<inheritdoc/>
        public string NumericCode => "968";

        ///<inheritdoc/>
        public string Name => "Surinamese dollar";
    }
}

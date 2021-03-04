namespace Nager.Country.Currencies
{
    public class CupCurrency : ICurrency
    {
        public string Symbol => "$";

        ///<inheritdoc/>
        public string Singular => "peso";

        ///<inheritdoc/>
        public string Plural => "peso";

        ///<inheritdoc/>
        public string IsoCode => "CUP";

        ///<inheritdoc/>
        public string NumericCode => "192";

        ///<inheritdoc/>
        public string Name => "Cuban peso";
    }
}

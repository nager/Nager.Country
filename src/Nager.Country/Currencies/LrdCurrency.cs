namespace Nager.Country.Currencies
{
    public class LrdCurrency : ICurrency
    {
        public string Symbol => "$";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "LRD";

        ///<inheritdoc/>
        public string NumericCode => "430";

        ///<inheritdoc/>
        public string Name => "Liberian dollar";
    }
}

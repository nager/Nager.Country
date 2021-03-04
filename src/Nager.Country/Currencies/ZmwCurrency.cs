namespace Nager.Country.Currencies
{
    public class ZmwCurrency : ICurrency
    {
        public string Symbol => "K";

        ///<inheritdoc/>
        public string Singular => "kwacha";

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "ZMW";

        ///<inheritdoc/>
        public string NumericCode => "967";

        ///<inheritdoc/>
        public string Name => "Zambian kwacha";
    }
}

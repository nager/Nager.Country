namespace Nager.Country.Currencies
{
    public class HrkCurrency : ICurrency
    {
        public string Symbol => "kn";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "HRK";

        ///<inheritdoc/>
        public string NumericCode => "191";

        ///<inheritdoc/>
        public string Name => "Croatian Kuna";
    }
}

namespace Nager.Country.Currencies
{
    public class TwdCurrency : ICurrency
    {
        ///<inheritdoc/>
        public string Symbol => "NT$";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "TWD";

        ///<inheritdoc/>
        public string NumericCode => "901";

        ///<inheritdoc/>
        public string Name => "New Taiwan Dollar";
    }
}

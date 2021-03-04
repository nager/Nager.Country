namespace Nager.Country.Currencies
{
    public class WstCurrency : ICurrency
    {
        public string Symbol => "WS$";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "WST";

        ///<inheritdoc/>
        public string NumericCode => "882";

        ///<inheritdoc/>
        public string Name => "Samoan tala";
    }
}

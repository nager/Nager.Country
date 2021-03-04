namespace Nager.Country.Currencies
{
    public class BynCurrency : ICurrency
    {
        public string Symbol => "Br";

        ///<inheritdoc/>
        public string Singular => "rouble";

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "BYN";

        ///<inheritdoc/>
        public string NumericCode => "933";

        ///<inheritdoc/>
        public string Name => "Belarusian ruble";
    }
}

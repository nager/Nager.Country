namespace Nager.Country.Currencies
{
    public class BynCurrency : ICurrency
    {
        public string Symbol => "Br";

        public string Singular => "rouble";

        public string Plural => null;

        public string IsoCode => "BYN";

        public string NumericCode => "933";

        public string Name => "Belarusian ruble";
    }
}

namespace Nager.Country.Currencies
{
    public class InrCurrency : ICurrency
    {
        public string Symbol => "₹";

        public string Singular => null;

        public string Plural => null;

        public string IsoCode => "INR";

        public string NumericCode => "356";

        public string Name => "Indian Rupee";
    }
}

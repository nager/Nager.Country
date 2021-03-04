namespace Nager.Country.Currencies
{
    public class XpfCurrency : ICurrency
    {
        public string Symbol => "R";

        ///<inheritdoc/>
        public string Singular => "rand";

        ///<inheritdoc/>
        public string Plural => "rand";

        ///<inheritdoc/>
        public string IsoCode => "ZAR";

        ///<inheritdoc/>
        public string NumericCode => "710";

        ///<inheritdoc/>
        public string Name => "South African Rand";
    }
}

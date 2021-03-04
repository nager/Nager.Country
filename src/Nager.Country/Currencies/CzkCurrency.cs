namespace Nager.Country.Currencies
{
    public class CzkCurrency : ICurrency
    {
        public string Symbol => "Kč";

        ///<inheritdoc/>
        public string Singular => "koruna";

        ///<inheritdoc/>
        public string Plural => "koruna";

        ///<inheritdoc/>
        public string IsoCode => "CZK";

        ///<inheritdoc/>
        public string NumericCode => "203";

        ///<inheritdoc/>
        public string Name => "Czech koruna";
    }
}

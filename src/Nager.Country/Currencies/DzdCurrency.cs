namespace Nager.Country.Currencies
{
    public class DzdCurrency : ICurrency
    {
        ///<inheritdoc/>
        public string Symbol => "د.ج.‏";

        ///<inheritdoc/>
        public string Singular => "dinar";

        ///<inheritdoc/>
        public string Plural => "dinar";

        ///<inheritdoc/>
        public string IsoCode => "DZD";

        ///<inheritdoc/>
        public string NumericCode => "012";

        ///<inheritdoc/>
        public string Name => "Algerian dinar";
    }
}

namespace Nager.Country.Currencies
{
    public class EgpCurrency : ICurrency
    {
        public string Symbol => "ج.م.‏";

        ///<inheritdoc/>
        public string Singular => "pound";

        ///<inheritdoc/>
        public string Plural => "pound";

        ///<inheritdoc/>
        public string IsoCode => "EGP";

        ///<inheritdoc/>
        public string NumericCode => "818";

        ///<inheritdoc/>
        public string Name => "Egyptian pound";
    }
}

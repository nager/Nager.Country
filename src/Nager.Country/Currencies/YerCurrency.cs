namespace Nager.Country.Currencies
{
    public class YerCurrency : ICurrency
    {
        public string Symbol => "ر.ي.‏";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "YER";

        ///<inheritdoc/>
        public string NumericCode => "886";

        ///<inheritdoc/>
        public string Name => "Yemeni Rial";
    }
}

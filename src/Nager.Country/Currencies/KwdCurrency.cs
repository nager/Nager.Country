namespace Nager.Country.Currencies
{
    public class KwdCurrency : ICurrency
    {
        public string Symbol => "د.ك.‏";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "KWD";

        ///<inheritdoc/>
        public string NumericCode => "414";

        ///<inheritdoc/>
        public string Name => "Kuwaiti Dinar";
    }
}

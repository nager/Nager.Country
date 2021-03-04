namespace Nager.Country.Currencies
{
    public class OmrCurrency : ICurrency
    {
        public string Symbol => "ر.ع.‏";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "OMR";

        ///<inheritdoc/>
        public string NumericCode => "512";

        ///<inheritdoc/>
        public string Name => "Omani Rial";
    }
}

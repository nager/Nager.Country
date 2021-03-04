namespace Nager.Country.Currencies
{
    public class BhdCurrency : ICurrency
    {
        public string Symbol => "د.ب.‏";

        ///<inheritdoc/>
        public string Singular => "dinar";

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "BHD";

        ///<inheritdoc/>
        public string NumericCode => "048";

        ///<inheritdoc/>
        public string Name => "Bahraini dinar";
    }
}

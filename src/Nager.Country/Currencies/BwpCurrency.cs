namespace Nager.Country.Currencies
{
    public class BwpCurrency : ICurrency
    {
        public string Symbol => "P";

        ///<inheritdoc/>
        public string Singular => "Pula";

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "BWP";

        ///<inheritdoc/>
        public string NumericCode => "072";

        ///<inheritdoc/>
        public string Name => "Botswana pula";
    }
}

namespace Nager.Country.Currencies
{
    public class KhrCurrency : ICurrency
    {
        public string Symbol => "៛";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "KHR";

        ///<inheritdoc/>
        public string NumericCode => "116";

        ///<inheritdoc/>
        public string Name => "Cambodian Riel";
    }
}

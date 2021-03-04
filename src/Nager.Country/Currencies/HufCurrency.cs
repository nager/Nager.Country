namespace Nager.Country.Currencies
{
    public class HufCurrency : ICurrency
    {
        public string Symbol => "Ft";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "HUF";

        ///<inheritdoc/>
        public string NumericCode => "348";

        ///<inheritdoc/>
        public string Name => "Hungarian Forint";
    }
}

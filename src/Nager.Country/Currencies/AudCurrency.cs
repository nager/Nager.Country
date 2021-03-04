namespace Nager.Country.Currencies
{
    public class AudCurrency : ICurrency
    {
        public string Symbol => "$";

        ///<inheritdoc/>
        public string Singular => "dollar";

        ///<inheritdoc/>
        public string Plural => "dollars";

        ///<inheritdoc/>
        public string IsoCode => "AUD";

        ///<inheritdoc/>
        public string NumericCode => "036";

        ///<inheritdoc/>
        public string Name => "Australian dollar";
    }
}

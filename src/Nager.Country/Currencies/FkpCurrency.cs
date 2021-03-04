namespace Nager.Country.Currencies
{
    public class FkpCurrency : ICurrency
    {
        public string Symbol => "£";

        ///<inheritdoc/>
        public string Singular => "pound";

        ///<inheritdoc/>
        public string Plural => "pence";

        ///<inheritdoc/>
        public string IsoCode => "FKP";

        ///<inheritdoc/>
        public string NumericCode => "238";

        ///<inheritdoc/>
        public string Name => "Falkland Islands pound";
    }
}

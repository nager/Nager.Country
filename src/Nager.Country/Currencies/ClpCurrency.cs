namespace Nager.Country.Currencies
{
    public class ClpCurrency : ICurrency
    {
        public string Symbol => "$";

        ///<inheritdoc/>
        public string Singular => "peso";

        ///<inheritdoc/>
        public string Plural => "peso";

        ///<inheritdoc/>
        public string IsoCode => "CLP";

        ///<inheritdoc/>
        public string NumericCode => "152";

        ///<inheritdoc/>
        public string Name => "Chilean peso";
    }
}

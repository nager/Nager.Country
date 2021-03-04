namespace Nager.Country.Currencies
{
    public class DopCurrency : ICurrency
    {
        public string Symbol => "$";

        ///<inheritdoc/>
        public string Singular => "peso";

        ///<inheritdoc/>
        public string Plural => "peso";

        ///<inheritdoc/>
        public string IsoCode => "DOP";

        ///<inheritdoc/>
        public string NumericCode => "214";

        ///<inheritdoc/>
        public string Name => "Dominican peso";
    }
}

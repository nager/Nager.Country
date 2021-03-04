namespace Nager.Country.Currencies
{
    public class BgnCurrency : ICurrency
    {
        public string Symbol => "лв.";

        ///<inheritdoc/>
        public string Singular => "lev";

        ///<inheritdoc/>
        public string Plural => "levove";

        ///<inheritdoc/>
        public string IsoCode => "BGN";

        ///<inheritdoc/>
        public string NumericCode => "975";

        ///<inheritdoc/>
        public string Name => "Bulgarian lev";
    }
}

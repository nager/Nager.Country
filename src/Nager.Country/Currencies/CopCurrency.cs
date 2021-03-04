namespace Nager.Country.Currencies
{
    public class CopCurrency : ICurrency
    {
        public string Symbol => "$";

        ///<inheritdoc/>
        public string Singular => "peso";

        ///<inheritdoc/>
        public string Plural => "peso";

        ///<inheritdoc/>
        public string IsoCode => "COP";

        ///<inheritdoc/>
        public string NumericCode => "170";

        ///<inheritdoc/>
        public string Name => "Colombian peso";
    }
}

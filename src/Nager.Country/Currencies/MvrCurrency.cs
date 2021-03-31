namespace Nager.Country.Currencies
{
    public class MvrCurrency : ICurrency
    {
        ///<inheritdoc/>
        public string Symbol => "ރ.";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "MVR";

        ///<inheritdoc/>
        public string NumericCode => "462";

        ///<inheritdoc/>
        public string Name => "Maldivian Rufiyaa";
    }
}

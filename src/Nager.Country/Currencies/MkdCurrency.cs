namespace Nager.Country.Currencies
{
    public class MkdCurrency : ICurrency
    {
        public string Symbol => "ден";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "MKD";

        ///<inheritdoc/>
        public string NumericCode => "807";

        ///<inheritdoc/>
        public string Name => "Macedonian Denar";
    }
}

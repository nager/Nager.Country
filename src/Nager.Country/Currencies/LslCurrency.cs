namespace Nager.Country.Currencies
{
    public class LslCurrency : ICurrency
    {
        public string Symbol => "L";

        ///<inheritdoc/>
        public string Singular => "Loti";

        ///<inheritdoc/>
        public string Plural => "Maloti";

        ///<inheritdoc/>
        public string IsoCode => "LSL";

        ///<inheritdoc/>
        public string NumericCode => "426";

        ///<inheritdoc/>
        public string Name => "Lesotho loti";
    }
}

namespace Nager.Country.Currencies
{
    public class GhsCurrency : ICurrency
    {
        public string Symbol => "GH₵";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "GHS";

        ///<inheritdoc/>
        public string NumericCode => "936";

        ///<inheritdoc/>
        public string Name => "Ghanaian cedi";
    }
}

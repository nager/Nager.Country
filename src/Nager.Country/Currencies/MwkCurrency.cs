namespace Nager.Country.Currencies
{
    public class MwkCurrency : ICurrency
    {
        public string Symbol => "K";

        ///<inheritdoc/>
        public string Singular => "kwacha";

        ///<inheritdoc/>
        public string Plural => "kwacha";

        ///<inheritdoc/>
        public string IsoCode => "MWK";

        ///<inheritdoc/>
        public string NumericCode => "454";

        ///<inheritdoc/>
        public string Name => "Malawian kwacha";
    }
}

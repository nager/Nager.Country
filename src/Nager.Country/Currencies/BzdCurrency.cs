namespace Nager.Country.Currencies
{
    /// <summary>
    /// Bzd Currency
    /// </summary>
    public class BzdCurrency : ICurrency
    {
        ///<inheritdoc/>
        public string Symbol => "$";

        ///<inheritdoc/>
        public string Singular => "dollar";

        ///<inheritdoc/>
        public string Plural => "dollars";

        ///<inheritdoc/>
        public string IsoCode => "BZD";

        ///<inheritdoc/>
        public string NumericCode => "084";

        ///<inheritdoc/>
        public string Name => "Belize dollar";
    }
}

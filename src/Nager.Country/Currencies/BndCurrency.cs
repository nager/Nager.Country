namespace Nager.Country.Currencies
{
    /// <summary>
    /// Bnd Currency
    /// </summary>
    public class BndCurrency : ICurrency
    {
        ///<inheritdoc/>
        public string Symbol => "$";

        ///<inheritdoc/>
        public string Singular => "dollar";

        ///<inheritdoc/>
        public string Plural => "dollars";

        ///<inheritdoc/>
        public string IsoCode => "BND";

        ///<inheritdoc/>
        public string NumericCode => "096";

        ///<inheritdoc/>
        public string Name => "Brunei dollar";
    }
}

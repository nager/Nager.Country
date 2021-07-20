namespace Nager.Country.Currencies
{
    /// <summary>
    /// Fjd Currency
    /// </summary>
    public class FjdCurrency : ICurrency
    {
        ///<inheritdoc/>
        public string Symbol => "FJ$";

        ///<inheritdoc/>
        public string Singular => "dollar";

        ///<inheritdoc/>
        public string Plural => "dollar";

        ///<inheritdoc/>
        public string IsoCode => "FJD";

        ///<inheritdoc/>
        public string NumericCode => "242";

        ///<inheritdoc/>
        public string Name => "Fiji dollar";
    }
}

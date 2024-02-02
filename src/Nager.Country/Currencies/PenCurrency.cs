namespace Nager.Country.Currencies
{
    /// <summary>
    /// Pen Currency
    /// </summary>
    public class PenCurrency : ICurrency
    {
        ///<inheritdoc/>
        public string Symbol => "S/";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "PEN";

        ///<inheritdoc/>
        public string NumericCode => "604";

        ///<inheritdoc/>
        public string Name => "Peruvian Sol";
    }
}

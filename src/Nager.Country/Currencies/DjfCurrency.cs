namespace Nager.Country.Currencies
{
    /// <summary>
    /// Djf Currency
    /// </summary>
    public class DjfCurrency : ICurrency
    {
        ///<inheritdoc/>
        public string Symbol => "Fdj";

        ///<inheritdoc/>
        public string Singular => "franc";

        ///<inheritdoc/>
        public string Plural => "francs";

        ///<inheritdoc/>
        public string IsoCode => "DJF";

        ///<inheritdoc/>
        public string NumericCode => "262";

        ///<inheritdoc/>
        public string Name => "Djiboutian franc";
    }
}

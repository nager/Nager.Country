namespace Nager.Country.Currencies
{
    /// <summary>
    /// Gyd Currency
    /// </summary>
    public class GydCurrency : ICurrency
    {
        ///<inheritdoc/>
        public string Symbol => "$";

        ///<inheritdoc/>
        public string Singular => "dollar";

        ///<inheritdoc/>
        public string Plural => "dollar";

        ///<inheritdoc/>
        public string IsoCode => "GYD";

        ///<inheritdoc/>
        public string NumericCode => "328";

        ///<inheritdoc/>
        public string Name => "Guyanese dollar";
    }
}

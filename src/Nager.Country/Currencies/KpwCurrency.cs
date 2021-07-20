namespace Nager.Country.Currencies
{
    /// <summary>
    /// Kpw Currency
    /// </summary>
    public class KpwCurrency : ICurrency
    {
        ///<inheritdoc/>
        public string Symbol => "₩";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "KPW";

        ///<inheritdoc/>
        public string NumericCode => "408";

        ///<inheritdoc/>
        public string Name => "North Korean won";
    }
}

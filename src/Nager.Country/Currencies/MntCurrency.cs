namespace Nager.Country.Currencies
{
    /// <summary>
    /// Mnt Currency
    /// </summary>
    public class MntCurrency : ICurrency
    {
        ///<inheritdoc/>
        public string Symbol => "₮";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "MNT";

        ///<inheritdoc/>
        public string NumericCode => "496";

        ///<inheritdoc/>
        public string Name => "Mongolian Tugrik";
    }
}

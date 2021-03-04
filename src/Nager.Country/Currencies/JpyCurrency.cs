namespace Nager.Country.Currencies
{
    public class JpyCurrency : ICurrency
    {
        public string Symbol => "¥";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "JPY";

        ///<inheritdoc/>
        public string NumericCode => "392";

        ///<inheritdoc/>
        public string Name => "Japanese Yen";
    }
}

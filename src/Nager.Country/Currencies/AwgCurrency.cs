namespace Nager.Country.Currencies
{
    public class AwgCurrency : ICurrency
    {
        public string Symbol => "Afl";

        ///<inheritdoc/>
        public string Singular => "florin";

        ///<inheritdoc/>
        public string Plural => "florin";

        ///<inheritdoc/>
        public string IsoCode => "AWG";

        ///<inheritdoc/>
        public string NumericCode => "533";

        ///<inheritdoc/>
        public string Name => "Aruban florin";
    }
}

namespace Nager.Country.Currencies
{
    public class NioCurrency : ICurrency
    {
        public string Symbol => "C$";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "NIO";

        ///<inheritdoc/>
        public string NumericCode => "558";

        ///<inheritdoc/>
        public string Name => "Nicaraguan Córdoba";
    }
}

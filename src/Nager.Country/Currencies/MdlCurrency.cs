namespace Nager.Country.Currencies
{
    public class MdlCurrency : ICurrency
    {
        ///<inheritdoc/>
        public string Symbol => "L";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "MDL";

        ///<inheritdoc/>
        public string NumericCode => "498";

        ///<inheritdoc/>
        public string Name => "Moldovan Leu";
    }
}

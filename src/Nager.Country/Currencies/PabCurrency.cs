namespace Nager.Country.Currencies
{
    public class PabCurrency : ICurrency
    {
        public string Symbol => "B/.";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "PAB";

        ///<inheritdoc/>
        public string NumericCode => "590";

        ///<inheritdoc/>
        public string Name => "Panamanian Balboa";
    }
}

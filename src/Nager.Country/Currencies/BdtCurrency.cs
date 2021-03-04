namespace Nager.Country.Currencies
{
    public class BdtCurrency : ICurrency
    {
        public string Symbol => "৳";

        ///<inheritdoc/>
        public string Singular => "taka";

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "BDT";

        ///<inheritdoc/>
        public string NumericCode => "050";

        ///<inheritdoc/>
        public string Name => "Bangladeshi taka";
    }
}

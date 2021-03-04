namespace Nager.Country.Currencies
{
    public class KesCurrency : ICurrency
    {
        public string Symbol => "Ksh";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "KES";

        ///<inheritdoc/>
        public string NumericCode => "404";

        ///<inheritdoc/>
        public string Name => "Kenyan Shilling";
    }
}

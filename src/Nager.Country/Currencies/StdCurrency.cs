namespace Nager.Country.Currencies
{
    public class StdCurrency : ICurrency
    {
        public string Symbol => "Db";

        ///<inheritdoc/>
        public string Singular => "dobra";

        ///<inheritdoc/>
        public string Plural => "dobra";

        ///<inheritdoc/>
        public string IsoCode => "STD";

        ///<inheritdoc/>
        public string NumericCode => "678";

        ///<inheritdoc/>
        public string Name => "São Tomé and Príncipe dobra";
    }
}

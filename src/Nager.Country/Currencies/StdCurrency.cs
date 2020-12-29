namespace Nager.Country.Currencies
{
    public class StdCurrency : ICurrency
    {
        public string Symbol => "Db";

        public string Singular => "dobra";

        public string Plural => "dobra";

        public string IsoCode => "STD";

        public string NumericCode => "678";

        public string Name => "São Tomé and Príncipe dobra";
    }
}

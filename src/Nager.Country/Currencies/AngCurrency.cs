namespace Nager.Country.Currencies
{
    public class AngCurrency : ICurrency
    {
        public string Symbol => "NAƒ";

        public string Singular => "guilder";

        public string Plural => "guilders";

        public string IsoCode => "ANG";

        public string NumericCode => "532";

        public string Name => "Netherlands Antillean guilder";
    }
}

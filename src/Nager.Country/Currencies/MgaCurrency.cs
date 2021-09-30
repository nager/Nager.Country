namespace Nager.Country.Currencies
{
    /// <summary>
    /// Mdl Currency
    /// </summary>
    public class MdlCurrency : ICurrency
    {
        ///<inheritdoc/>
        public string Symbol => "Ar";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "MGA";

        ///<inheritdoc/>
        public string NumericCode => "969";

        ///<inheritdoc/>
        public string Name => "Malagasy ariary";
    }
}

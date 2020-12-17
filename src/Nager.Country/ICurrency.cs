namespace Nager.Country
{
    public interface ICurrency
    {
        string Symbol { get; }
        string Singular { get; }
        string Plural { get; }
        /// <summary>
        /// ISO 4217 - IsoCode
        /// </summary>
        string IsoCode { get; }
        /// <summary>
        /// ISO 4217 - Num
        /// </summary>
        string NumericCode { get; }
        /// <summary>
        /// ISO 4217 - Name
        /// </summary>
        string Name { get; }
    }
}

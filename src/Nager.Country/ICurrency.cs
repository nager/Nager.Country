namespace Nager.Country
{
    /// <summary>
    /// Currency ISO 4217
    /// https://en.wikipedia.org/wiki/ISO_4217
    /// </summary>
    public interface ICurrency
    {
        /// <summary>
        /// Symbol
        /// </summary>
        string Symbol { get; }
        /// <summary>
        /// Singular
        /// </summary>
        string Singular { get; }
        /// <summary>
        /// Plural
        /// </summary>
        string Plural { get; }
        /// <summary>
        /// IsoCode
        /// </summary>
        string IsoCode { get; }
        /// <summary>
        /// Num
        /// </summary>
        string NumericCode { get; }
        /// <summary>
        /// Name
        /// </summary>
        string Name { get; }
    }
}

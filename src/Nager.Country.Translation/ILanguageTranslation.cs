namespace Nager.Country.Translation
{
    public interface ILanguageTranslation
    {
        string CommonName { get; }
        string OfficialName { get; }
        Translation[] Translations { get; }

        /// <summary>
        /// ISO 639-1 language code
        /// </summary>
        LanguageCode LanguageCode { get; }
    }
}

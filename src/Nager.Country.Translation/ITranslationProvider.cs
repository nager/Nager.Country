using System.Collections.Generic;
using System.Globalization;

namespace Nager.Country.Translation
{
    /// <summary>
    /// Translation Provider Interface
    /// </summary>
    public interface ITranslationProvider
    {
        /// <summary>
        /// Gets all available language translations.
        /// </summary>
        /// <returns>A collection of supported language translations.</returns>
        IEnumerable<ILanguageTranslation> GetLanguages();

        /// <summary>
        /// Gets the language translation for the specified ISO language code (string).
        /// </summary>
        /// <param name="languageCode">The ISO language code (e.g., "en").</param>
        /// <returns>The corresponding language translation.</returns>
        ILanguageTranslation? GetLanguage(string languageCode);

        /// <summary>
        /// Gets the language translation for the specified <see cref="LanguageCode"/>.
        /// </summary>
        /// <param name="languageCode">The language code enumeration value.</param>
        /// <returns>The corresponding language translation.</returns>
        ILanguageTranslation? GetLanguage(LanguageCode languageCode);

        /// <summary>
        /// Gets the country translation for the specified ISO Alpha-2 country code.
        /// </summary>
        /// <param name="alpha2Code">The ISO Alpha-2 country code.</param>
        /// <returns>The corresponding country translation.</returns>
        ICountryTranslation? GetCountryTranslation(Alpha2Code alpha2Code);

        /// <summary>
        /// Gets the localized country name for the specified country and language code.
        /// </summary>
        /// <param name="alpha2or3Code">The ISO Alpha-2 or Alpha-3 country code.</param>
        /// <param name="languageCode">The target language code.</param>
        /// <returns>The localized country name.</returns>
        string? GetCountryTranslatedName(string alpha2or3Code, LanguageCode languageCode);

        /// <summary>
        /// Gets the localized country name for the specified Alpha-2 code and language code.
        /// </summary>
        /// <param name="alpha2Code">The ISO Alpha-2 country code.</param>
        /// <param name="languageCode">The target language code.</param>
        /// <returns>The localized country name.</returns>
        string? GetCountryTranslatedName(Alpha2Code alpha2Code, LanguageCode languageCode);

        /// <summary>
        /// Gets the localized country name for the specified Alpha-3 code and language code.
        /// </summary>
        /// <param name="alpha3Code">The ISO Alpha-3 country code.</param>
        /// <param name="languageCode">The target language code.</param>
        /// <returns>The localized country name.</returns>
        string? GetCountryTranslatedName(Alpha3Code alpha3Code, LanguageCode languageCode);

        /// <summary>
        /// Gets the localized country name for the specified country and language code as strings.
        /// </summary>
        /// <param name="alpha2or3Code">The ISO Alpha-2 or Alpha-3 country code.</param>
        /// <param name="languageCode">The target ISO language code as a string.</param>
        /// <returns>The localized country name.</returns>
        string? GetCountryTranslatedName(string alpha2or3Code, string languageCode);

        /// <summary>
        /// Gets the localized country name for the specified Alpha-2 code and language code as a string.
        /// </summary>
        /// <param name="alpha2Code">The ISO Alpha-2 country code.</param>
        /// <param name="languageCode">The target ISO language code as a string.</param>
        /// <returns>The localized country name.</returns>
        string? GetCountryTranslatedName(Alpha2Code alpha2Code, string languageCode);

        /// <summary>
        /// Gets the localized country name for the specified Alpha-3 code and language code as a string.
        /// </summary>
        /// <param name="alpha3Code">The ISO Alpha-3 country code.</param>
        /// <param name="languageCode">The target ISO language code as a string.</param>
        /// <returns>The localized country name.</returns>
        string? GetCountryTranslatedName(Alpha3Code alpha3Code, string languageCode);

        /// <summary>
        /// Gets the localized country name using culture information.
        /// </summary>
        /// <param name="alpha2or3Code">The ISO Alpha-2 or Alpha-3 country code.</param>
        /// <param name="culture">The target culture (e.g., CultureInfo("de-DE")).</param>
        /// <returns>The localized country name.</returns>
        string? GetCountryTranslatedName(string alpha2or3Code, CultureInfo culture);

        /// <summary>
        /// Gets the localized country name using culture information.
        /// </summary>
        /// <param name="alpha2Code">The ISO Alpha-2 country code.</param>
        /// <param name="culture">The target culture.</param>
        /// <returns>The localized country name.</returns>
        string? GetCountryTranslatedName(Alpha2Code alpha2Code, CultureInfo culture);

        /// <summary>
        /// Gets the localized country name using culture information.
        /// </summary>
        /// <param name="alpha3Code">The ISO Alpha-3 country code.</param>
        /// <param name="culture">The target culture.</param>
        /// <returns>The localized country name.</returns>
        string? GetCountryTranslatedName(Alpha3Code alpha3Code, CultureInfo culture);

        /// <summary>
        /// Gets the localized country name using culture information, falling back to a default language if necessary.
        /// </summary>
        /// <param name="alpha2or3Code">The ISO Alpha-2 or Alpha-3 country code.</param>
        /// <param name="culture">The target culture.</param>
        /// <param name="defaultLanguageCode">The fallback language code if no translation is available for the culture.</param>
        /// <returns>The localized country name.</returns>
        string? GetCountryTranslatedName(string alpha2or3Code, CultureInfo culture, LanguageCode defaultLanguageCode);

        /// <summary>
        /// Gets the localized country name using culture information, falling back to a default language if necessary.
        /// </summary>
        /// <param name="alpha2Code">The ISO Alpha-2 country code.</param>
        /// <param name="culture">The target culture.</param>
        /// <param name="defaultLanguageCode">The fallback language code if no translation is available for the culture.</param>
        /// <returns>The localized country name.</returns>
        string? GetCountryTranslatedName(Alpha2Code alpha2Code, CultureInfo culture, LanguageCode defaultLanguageCode);

        /// <summary>
        /// Gets the localized country name using culture information, falling back to a default language if necessary.
        /// </summary>
        /// <param name="alpha3Code">The ISO Alpha-3 country code.</param>
        /// <param name="culture">The target culture.</param>
        /// <param name="defaultLanguageCode">The fallback language code if no translation is available for the culture.</param>
        /// <returns>The localized country name.</returns>
        string? GetCountryTranslatedName(Alpha3Code alpha3Code, CultureInfo culture, LanguageCode defaultLanguageCode);
    }
}

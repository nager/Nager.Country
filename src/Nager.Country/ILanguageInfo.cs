using System;
namespace Nager.Country
{
    public interface ILanguageInfo
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

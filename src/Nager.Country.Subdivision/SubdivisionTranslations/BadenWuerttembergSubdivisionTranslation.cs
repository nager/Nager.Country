using Nager.Country.Translation;

namespace Nager.Country.Subdivision.SubdivisionTranslations;

public class BadenWuerttembergSubdivisionTranslation : ISubdivisionTranslation
{
	public TranslationInfo[] Translations => new[]
	{
		new TranslationInfo( LanguageCode.DE, "Baden-Württemberg")
	};
}
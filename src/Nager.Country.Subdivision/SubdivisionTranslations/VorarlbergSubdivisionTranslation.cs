using Nager.Country.Translation;

namespace Nager.Country.Subdivision.SubdivisionTranslations;

public class VorarlbergSubdivisionTranslation : ISubdivisionTranslation
{
	public TranslationInfo[] Translations => new[]
	{
		new TranslationInfo( LanguageCode.DE, "Vorarlberg")
	};
}
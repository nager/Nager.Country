using Nager.Country.Translation;

namespace Nager.Country.Subdivision.SubdivisionTranslations;

public class LowerSaxonySubdivisionTranslation : ISubdivisionTranslation
{
	public TranslationInfo[] Translations => new[]
	{
		new TranslationInfo( LanguageCode.DE, "Niedersachsen")
	};
}
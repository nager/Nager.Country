using Nager.Country.Translation;

namespace Nager.Country.Subdivision.SubdivisionTranslations;

public class SalzburgSubdivisionTranslation : ISubdivisionTranslation
{
	public TranslationInfo[] Translations => new[]
	{
		new TranslationInfo( LanguageCode.DE, "Salzburg")
	};
}
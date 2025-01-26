using Nager.Country.Translation;

namespace Nager.Country.Subdivision.SubdivisionTranslations;

public class ValaisSubdivisionTranslation : ISubdivisionTranslation
{
	public TranslationInfo[] Translations => new[]
	{
		new TranslationInfo( LanguageCode.DE, "Wallis")
	};
}
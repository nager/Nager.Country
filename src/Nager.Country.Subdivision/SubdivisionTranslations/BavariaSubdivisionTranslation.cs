using Nager.Country.Translation;

namespace Nager.Country.Subdivision.SubdivisionTranslations;

public class BavariaSubdivisionTranslation : ISubdivisionTranslation
{
	public TranslationInfo[] Translations => new[]
	{
		new TranslationInfo( LanguageCode.DE, "Bayern")
	};
}
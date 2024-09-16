using Nager.Country.Translation;

namespace Nager.Country.Subdivision.SubdivisionTranslations;

public class ViennaSubdivisionTranslation : ISubdivisionTranslation
{
	public TranslationInfo[] Translations => new[]
	{
		new TranslationInfo( LanguageCode.DE, "Wien")
	};
}
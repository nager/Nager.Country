using Nager.Country.Translation;

namespace Nager.Country.Subdivision.SubdivisionTranslations;

public class LowerAustriaSubdivisionTranslation : ISubdivisionTranslation
{
	public TranslationInfo[] Translations => new[]
	{
		new TranslationInfo( LanguageCode.DE, "Niederösterreich")
	};
}
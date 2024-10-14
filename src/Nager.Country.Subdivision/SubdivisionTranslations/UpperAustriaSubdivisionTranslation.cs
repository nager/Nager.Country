using Nager.Country.Translation;

namespace Nager.Country.Subdivision.SubdivisionTranslations;

public class UpperAustriaSubdivisionTranslation : ISubdivisionTranslation
{
	public TranslationInfo[] Translations => new[]
	{
		new TranslationInfo( LanguageCode.DE, "Oberösterreich")
	};
}
using Nager.Country.Translation;

namespace Nager.Country.Subdivision.SubdivisionTranslations;

public class StyriaSubdivisionTranslation : ISubdivisionTranslation
{
	public TranslationInfo[] Translations => new[]
	{
		new TranslationInfo( LanguageCode.DE, "Steiermark")
	};
}
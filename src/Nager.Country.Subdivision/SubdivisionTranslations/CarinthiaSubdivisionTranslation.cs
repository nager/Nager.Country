using Nager.Country.Translation;

namespace Nager.Country.Subdivision.SubdivisionTranslations;

public class CarinthiaSubdivisionTranslation : ISubdivisionTranslation
{
	public TranslationInfo[] Translations => new[]
	{
		new TranslationInfo( LanguageCode.DE, "Kärnten")
	};
}
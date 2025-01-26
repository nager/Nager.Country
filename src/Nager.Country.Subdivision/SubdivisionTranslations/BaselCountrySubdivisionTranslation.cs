using Nager.Country.Translation;

namespace Nager.Country.Subdivision.SubdivisionTranslations;

public class BaselCountrySubdivisionTranslation : ISubdivisionTranslation
{
	public TranslationInfo[] Translations => new[]
	{
		new TranslationInfo( LanguageCode.DE, "Basel-Landschaft")
	};
}
using Nager.Country.Translation;

namespace Nager.Country.Subdivision.SubdivisionTranslations;

public class BaselCitySubdivisionTranslation : ISubdivisionTranslation
{
	public TranslationInfo[] Translations => new[]
	{
		new TranslationInfo( LanguageCode.DE, "Basel-Stadt")
	};
}
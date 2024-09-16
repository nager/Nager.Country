using Nager.Country.Translation;

namespace Nager.Country.Subdivision.SubdivisionTranslations;

public class GrisonsSubdivisionTranslation : ISubdivisionTranslation
{
	public TranslationInfo[] Translations => new[]
	{
		new TranslationInfo( LanguageCode.DE, "Graubünden"),		new TranslationInfo( LanguageCode.IT, "Grigioni"),		new TranslationInfo( LanguageCode.RM, "Grischun")
	};
}
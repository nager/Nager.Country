using Nager.Country.Translation;

namespace Nager.Country.Subdivision.SubdivisionTranslations;

public class SchleswigHolsteinSubdivisionTranslation : ISubdivisionTranslation
{
	public TranslationInfo[] Translations => new[]
	{
		new TranslationInfo( LanguageCode.DE, "Schleswig-Holstein")
	};
}
using Nager.Country.Translation;

namespace Nager.Country.Subdivision.SubdivisionTranslations;

public class ZurichSubdivisionTranslation : ISubdivisionTranslation
{
	public TranslationInfo[] Translations => new[]
	{
		new TranslationInfo( LanguageCode.DE, "Zürich")
	};
}
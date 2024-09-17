using Nager.Country.Translation;

namespace Nager.Country.Subdivision.SubdivisionTranslations;

public class SaxonySubdivisionTranslation : ISubdivisionTranslation
{
	public TranslationInfo[] Translations => new[]
	{
		new TranslationInfo( LanguageCode.DE, "Sachsen")
	};
}
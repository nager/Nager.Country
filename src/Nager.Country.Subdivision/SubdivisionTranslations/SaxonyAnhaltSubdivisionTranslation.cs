using Nager.Country.Translation;

namespace Nager.Country.Subdivision.SubdivisionTranslations;

public class SaxonyAnhaltSubdivisionTranslation : ISubdivisionTranslation
{
	public TranslationInfo[] Translations => new[]
	{
		new TranslationInfo( LanguageCode.DE, "Sachsen-Anhalt")
	};
}
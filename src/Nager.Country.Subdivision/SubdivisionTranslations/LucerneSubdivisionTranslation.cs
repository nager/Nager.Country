using Nager.Country.Translation;

namespace Nager.Country.Subdivision.SubdivisionTranslations;

public class LucerneSubdivisionTranslation : ISubdivisionTranslation
{
	public TranslationInfo[] Translations => new[]
	{
		new TranslationInfo( LanguageCode.DE, "Luzern")
	};
}
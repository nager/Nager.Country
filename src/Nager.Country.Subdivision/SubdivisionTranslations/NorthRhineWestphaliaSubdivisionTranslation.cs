using Nager.Country.Translation;

namespace Nager.Country.Subdivision.SubdivisionTranslations;

public class NorthRhineWestphaliaSubdivisionTranslation : ISubdivisionTranslation
{
	public TranslationInfo[] Translations => new[]
	{
		new TranslationInfo( LanguageCode.DE, "Nordrhein-Westfalen")
	};
}
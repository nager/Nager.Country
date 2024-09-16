using Nager.Country.Translation;

namespace Nager.Country.Subdivision.SubdivisionTranslations;

public class SaintGallSubdivisionTranslation : ISubdivisionTranslation
{
	public TranslationInfo[] Translations => new[]
	{
		new TranslationInfo( LanguageCode.DE, "Sankt Gallen")
	};
}
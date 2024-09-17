using Nager.Country.Translation;

namespace Nager.Country.Subdivision.SubdivisionTranslations;

public class ThuringiaSubdivisionTranslation : ISubdivisionTranslation
{
	public TranslationInfo[] Translations => new[]
	{
		new TranslationInfo( LanguageCode.DE, "Thüringen")
	};
}
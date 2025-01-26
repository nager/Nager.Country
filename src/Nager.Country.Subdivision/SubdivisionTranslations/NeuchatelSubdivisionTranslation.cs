using Nager.Country.Translation;

namespace Nager.Country.Subdivision.SubdivisionTranslations;

public class NeuchatelSubdivisionTranslation : ISubdivisionTranslation
{
	public TranslationInfo[] Translations => new[]
	{
		new TranslationInfo( LanguageCode.FR, "Neuchâtel"),		new TranslationInfo( LanguageCode.DE, "Neuenburg")
	};
}
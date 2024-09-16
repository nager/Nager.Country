using Nager.Country.Translation;

namespace Nager.Country.Subdivision.SubdivisionTranslations;

public class FribourgSubdivisionTranslation : ISubdivisionTranslation
{
	public TranslationInfo[] Translations => new[]
	{
		new TranslationInfo( LanguageCode.FR, "Fribourg"),		new TranslationInfo( LanguageCode.DE, "Freiburg")
	};
}
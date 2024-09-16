using Nager.Country.Translation;

namespace Nager.Country.Subdivision.SubdivisionTranslations;

public class BernSubdivisionTranslation : ISubdivisionTranslation
{
	public TranslationInfo[] Translations => new[]
	{
		new TranslationInfo( LanguageCode.FR, "Berne")
	};
}
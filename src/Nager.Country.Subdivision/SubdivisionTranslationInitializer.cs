using Nager.Country.Subdivision.SubdivisionTranslations;

namespace Nager.Country.Subdivision;

internal static class SubdivisionTranslationInitializer
{
	public static Dictionary<SubdivisionCode, ISubdivisionTranslation> Create()
	{
		return new Dictionary<SubdivisionCode, ISubdivisionTranslation>
		{
			{ SubdivisionCode.AT2, new CarinthiaSubdivisionTranslation() },
			{ SubdivisionCode.AT3, new LowerAustriaSubdivisionTranslation() },
			{ SubdivisionCode.AT4, new UpperAustriaSubdivisionTranslation() },
			{ SubdivisionCode.AT5, new SalzburgSubdivisionTranslation() },
			{ SubdivisionCode.AT6, new StyriaSubdivisionTranslation() },
			{ SubdivisionCode.AT7, new TyrolSubdivisionTranslation() },
			{ SubdivisionCode.AT8, new VorarlbergSubdivisionTranslation() },
			{ SubdivisionCode.AT9, new ViennaSubdivisionTranslation() },
			{ SubdivisionCode.CHBL, new BaselCountrySubdivisionTranslation() },
			{ SubdivisionCode.CHBS, new BaselCitySubdivisionTranslation() },
			{ SubdivisionCode.CHBE, new BernSubdivisionTranslation() },
			{ SubdivisionCode.CHFR, new FribourgSubdivisionTranslation() },
			{ SubdivisionCode.CHGE, new GenevaSubdivisionTranslation() },
			{ SubdivisionCode.CHGR, new GrisonsSubdivisionTranslation() },
			{ SubdivisionCode.CHLU, new LucerneSubdivisionTranslation() },
			{ SubdivisionCode.CHNE, new NeuchatelSubdivisionTranslation() },
			{ SubdivisionCode.CHSG, new SaintGallSubdivisionTranslation() },
			{ SubdivisionCode.CHVS, new ValaisSubdivisionTranslation() },
			{ SubdivisionCode.CHZH, new ZurichSubdivisionTranslation() },
			{ SubdivisionCode.DEBW, new BadenWuerttembergSubdivisionTranslation() },
			{ SubdivisionCode.DEBY, new BavariaSubdivisionTranslation() },
			{ SubdivisionCode.DEMV, new MecklenburgWesternPomeraniaSubdivisionTranslation() },
			{ SubdivisionCode.DENI, new LowerSaxonySubdivisionTranslation() },
			{ SubdivisionCode.DENW, new NorthRhineWestphaliaSubdivisionTranslation() },
			{ SubdivisionCode.DERP, new RhinelandPalatinateSubdivisionTranslation() },
			{ SubdivisionCode.DESN, new SaxonySubdivisionTranslation() },
			{ SubdivisionCode.DEST, new SaxonyAnhaltSubdivisionTranslation() },
			{ SubdivisionCode.DESH, new SchleswigHolsteinSubdivisionTranslation() },
			{ SubdivisionCode.DETH, new ThuringiaSubdivisionTranslation() }
		};
	}
}
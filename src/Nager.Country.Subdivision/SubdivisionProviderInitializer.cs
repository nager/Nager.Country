using Nager.Country.Subdivision.SubdivisionInfos;

namespace Nager.Country.Subdivision;

internal static class SubdivisionProviderInitializer
{
	public static Dictionary<SubdivisionCode, ISubdivisionInfo> Create()
	{
		return new Dictionary<SubdivisionCode, ISubdivisionInfo>
		{		
			{ SubdivisionCode.AT1, new BurgenlandSubdivisionInfo() },
			{ SubdivisionCode.AT2, new CarinthiaSubdivisionInfo() },
			{ SubdivisionCode.AT3, new LowerAustriaSubdivisionInfo() },
			{ SubdivisionCode.AT4, new UpperAustriaSubdivisionInfo() },
			{ SubdivisionCode.AT5, new SalzburgSubdivisionInfo() },
			{ SubdivisionCode.AT6, new StyriaSubdivisionInfo() },
			{ SubdivisionCode.AT7, new TyrolSubdivisionInfo() },
			{ SubdivisionCode.AT8, new VorarlbergSubdivisionInfo() },
			{ SubdivisionCode.AT9, new ViennaSubdivisionInfo() },
			{ SubdivisionCode.CHAG, new AargauSubdivisionInfo() },
			{ SubdivisionCode.CHAR, new AppenzellAusserrhodenSubdivisionInfo() },
			{ SubdivisionCode.CHAI, new AppenzellInnerrhodenSubdivisionInfo() },
			{ SubdivisionCode.CHBL, new BaselCountrySubdivisionInfo() },
			{ SubdivisionCode.CHBS, new BaselCitySubdivisionInfo() },
			{ SubdivisionCode.CHBE, new BernSubdivisionInfo() },
			{ SubdivisionCode.CHFR, new FribourgSubdivisionInfo() },
			{ SubdivisionCode.CHGE, new GenevaSubdivisionInfo() },
			{ SubdivisionCode.CHGL, new GlarusSubdivisionInfo() },
			{ SubdivisionCode.CHGR, new GrisonsSubdivisionInfo() },
			{ SubdivisionCode.CHJU, new JuraSubdivisionInfo() },
			{ SubdivisionCode.CHLU, new LucerneSubdivisionInfo() },
			{ SubdivisionCode.CHNE, new NeuchatelSubdivisionInfo() },
			{ SubdivisionCode.CHNW, new NidwaldenSubdivisionInfo() },
			{ SubdivisionCode.CHOW, new ObwaldenSubdivisionInfo() },
			{ SubdivisionCode.CHSG, new SaintGallSubdivisionInfo() },
			{ SubdivisionCode.CHSH, new SchaffhausenSubdivisionInfo() },
			{ SubdivisionCode.CHSZ, new SchwyzSubdivisionInfo() },
			{ SubdivisionCode.CHSO, new SolothurnSubdivisionInfo() },
			{ SubdivisionCode.CHTG, new ThurgauSubdivisionInfo() },
			{ SubdivisionCode.CHTI, new TicinoSubdivisionInfo() },
			{ SubdivisionCode.CHUR, new UriSubdivisionInfo() },
			{ SubdivisionCode.CHVS, new ValaisSubdivisionInfo() },
			{ SubdivisionCode.CHVD, new VaudSubdivisionInfo() },
			{ SubdivisionCode.CHZG, new ZugSubdivisionInfo() },
			{ SubdivisionCode.CHZH, new ZurichSubdivisionInfo() },
			{ SubdivisionCode.DEBW, new BadenWuerttembergSubdivisionInfo() },
			{ SubdivisionCode.DEBY, new BavariaSubdivisionInfo() },
			{ SubdivisionCode.DEBE, new BerlinSubdivisionInfo() },
			{ SubdivisionCode.DEBB, new BrandenburgSubdivisionInfo() },
			{ SubdivisionCode.DEHB, new BremenSubdivisionInfo() },
			{ SubdivisionCode.DEHH, new HamburgSubdivisionInfo() },
			{ SubdivisionCode.DEHE, new HesseSubdivisionInfo() },
			{ SubdivisionCode.DEMV, new MecklenburgWesternPomeraniaSubdivisionInfo() },
			{ SubdivisionCode.DENI, new LowerSaxonySubdivisionInfo() },
			{ SubdivisionCode.DENW, new NorthRhineWestphaliaSubdivisionInfo() },
			{ SubdivisionCode.DERP, new RhinelandPalatinateSubdivisionInfo() },
			{ SubdivisionCode.DESL, new SaarlandSubdivisionInfo() },
			{ SubdivisionCode.DESN, new SaxonySubdivisionInfo() },
			{ SubdivisionCode.DEST, new SaxonyAnhaltSubdivisionInfo() },
			{ SubdivisionCode.DESH, new SchleswigHolsteinSubdivisionInfo() },
			{ SubdivisionCode.DETH, new ThuringiaSubdivisionInfo() }
		};
	}
}	                                           
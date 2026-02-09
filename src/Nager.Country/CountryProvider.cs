using Nager.Country.CountryInfos;
using System;
using System.Collections.Generic;

#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_0_OR_GREATER
using System.Diagnostics.CodeAnalysis;
#endif

namespace Nager.Country
{
    /// <summary>
    /// CountryProvider
    /// </summary>
    public class CountryProvider : ICountryProvider
    {
        private readonly Dictionary<Alpha2Code, ICountryInfo> _alpha2Code2CountryInfo = new Dictionary<Alpha2Code, ICountryInfo>();
        private readonly Dictionary<Alpha3Code, ICountryInfo> _alpha3Code2CountryInfo = new Dictionary<Alpha3Code, ICountryInfo>();

        /// <summary>
        /// CountryProvider
        /// </summary>
        public CountryProvider()
        {
            #region Alpha2Code mapping

            this._alpha2Code2CountryInfo.Add(Alpha2Code.AD, new AndorraCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.AE, new UnitedArabEmiratesCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.AF, new AfghanistanCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.AG, new AntiguaAndBarbudaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.AI, new AnguillaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.AL, new AlbaniaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.AM, new ArmeniaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.AO, new AngolaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.AQ, new AntarcticaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.AR, new ArgentinaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.AS, new AmericanSamoaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.AT, new AustriaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.AU, new AustraliaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.AW, new ArubaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.AX, new AlandIslandsCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.AZ, new AzerbaijanCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.BA, new BosniaandHerzegovinaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.BB, new BarbadosCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.BD, new BangladeshCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.BE, new BelgiumCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.BF, new BurkinaFasoCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.BG, new BulgariaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.BH, new BahrainCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.BI, new BurundiCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.BJ, new BeninCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.BL, new SaintBarthelemyCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.BM, new BermudaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.BN, new BruneiCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.BO, new BoliviaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.BQ, new CaribbeanNetherlandsCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.BR, new BrazilCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.BS, new BahamasCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.BT, new BhutanCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.BV, new BouvetIslandCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.BW, new BotswanaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.BY, new BelarusCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.BZ, new BelizeCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.CA, new CanadaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.CC, new CocosIslandsCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.CD, new CongoCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.CF, new CentralAfricanRepublicCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.CG, new RepublicOfTheCongoCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.CH, new SwitzerlandCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.CI, new IvoryCoastCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.CK, new CookIslandsCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.CL, new ChileCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.CM, new CameroonCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.CN, new ChinaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.CO, new ColombiaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.CR, new CostaRicaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.CU, new CubaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.CV, new CapeVerdeCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.CW, new CuracaoCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.CX, new ChristmasIslandCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.CY, new CyprusCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.CZ, new CzechRepublicCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.DE, new GermanyCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.DJ, new DjiboutiCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.DK, new DenmarkCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.DM, new DominicaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.DO, new DominicanRepublicCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.DZ, new AlgeriaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.EC, new EcuadorCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.EE, new EstoniaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.EG, new EgyptCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.EH, new WesternSaharaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.ER, new EritreaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.ES, new SpainCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.ET, new EthiopiaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.FI, new FinlandCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.FJ, new FijiCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.FK, new FalklandIslandsCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.FM, new MicronesiaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.FO, new FaroeIslandsCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.FR, new FranceCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.GA, new GabonCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.GB, new UnitedKingdomCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.GD, new GrenadaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.GE, new GeorgiaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.GF, new FrenchGuianaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.GG, new GuernseyCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.GH, new GhanaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.GI, new GibraltarCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.GL, new GreenlandCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.GM, new GambiaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.GN, new GuineaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.GP, new GuadeloupeCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.GQ, new EquatorialGuineaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.GR, new GreeceCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.GS, new SouthGeorgiaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.GT, new GuatemalaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.GU, new GuamCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.GW, new GuineaBissauCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.GY, new GuyanaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.HK, new HongKongCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.HM, new HeardIslandAndMcDonaldIslandsCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.HN, new HondurasCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.HR, new CroatiaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.HT, new HaitiCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.HU, new HungaryCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.ID, new IndonesiaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.IE, new IrelandCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.IL, new IsraelCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.IM, new IsleofManCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.IN, new IndiaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.IO, new BritishIndianOceanTerritoryCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.IQ, new IraqCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.IR, new IranCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.IS, new IcelandCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.IT, new ItalyCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.JE, new JerseyCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.JM, new JamaicaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.JO, new JordanCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.JP, new JapanCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.KE, new KenyaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.KG, new KyrgyzstanCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.KH, new CambodiaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.KI, new KiribatiCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.KM, new ComorosCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.KN, new SaintKittsAndNevisCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.KP, new NorthKoreaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.KR, new SouthKoreaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.KW, new KuwaitCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.KY, new CaymanIslandsCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.KZ, new KazakhstanCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.LA, new LaosCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.LB, new LebanonCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.LC, new SaintLuciaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.LI, new LiechtensteinCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.LK, new SriLankaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.LR, new LiberiaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.LS, new LesothoCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.LT, new LithuaniaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.LU, new LuxembourgCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.LV, new LatviaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.LY, new LibyaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.MA, new MoroccoCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.MC, new MonacoCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.MD, new MoldovaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.ME, new MontenegroCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.MF, new SaintMartinCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.MG, new MadagascarCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.MH, new MarshallIslandsCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.MK, new NorthMacedoniaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.ML, new MaliCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.MM, new MyanmarCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.MN, new MongoliaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.MO, new MacauCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.MP, new NorthernMarianaIslandsCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.MQ, new MartiniqueCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.MR, new MauritaniaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.MS, new MontserratCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.MT, new MaltaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.MU, new MauritiusCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.MV, new MaldivesCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.MW, new MalawiCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.MX, new MexicoCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.MY, new MalaysiaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.MZ, new MozambiqueCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.NA, new NamibiaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.NC, new NewCaledoniaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.NE, new NigerCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.NF, new NorfolkIslandCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.NG, new NigeriaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.NI, new NicaraguaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.NL, new NetherlandsCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.NO, new NorwayCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.NP, new NepalCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.NR, new NauruCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.NU, new NiueCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.NZ, new NewZealandCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.OM, new OmanCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.PA, new PanamaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.PE, new PeruCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.PF, new FrenchPolynesiaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.PG, new PapuaNewGuineaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.PH, new PhilippinesCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.PK, new PakistanCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.PL, new PolandCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.PM, new SaintPierreAndMiquelonCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.PN, new PitcairnIslandsCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.PR, new PuertoRicoCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.PS, new PalestineCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.PT, new PortugalCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.PW, new PalauCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.PY, new ParaguayCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.QA, new QatarCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.RE, new ReunionCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.RO, new RomaniaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.RS, new SerbiaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.RU, new RussiaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.RW, new RwandaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.SA, new SaudiArabiaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.SB, new SolomonIslandsCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.SC, new SeychellesCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.SD, new SudanCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.SE, new SwedenCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.SG, new SingaporeCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.SH, new SaintHelenaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.SI, new SloveniaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.SJ, new SvalbardAndJanMayenCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.SK, new SlovakiaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.SL, new SierraLeoneCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.SM, new SanMarinoCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.SN, new SenegalCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.SO, new SomaliaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.SR, new SurinameCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.SS, new SouthSudanCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.ST, new SaoTomeAndPrincipeCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.SV, new ElSalvadorCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.SX, new SintMaartenCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.SY, new SyriaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.SZ, new EswatiniCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.TC, new TurksAndCaicosIslandsCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.TD, new ChadCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.TF, new FrenchSouthernAndAntarcticLandsCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.TG, new TogoCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.TH, new ThailandCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.TJ, new TajikistanCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.TK, new TokelauCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.TL, new TimorLesteCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.TM, new TurkmenistanCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.TN, new TunisiaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.TO, new TongaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.TR, new TurkeyCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.TT, new TrinidadAndTobagoCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.TV, new TuvaluCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.TW, new TaiwanCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.TZ, new TanzaniaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.UA, new UkraineCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.UG, new UgandaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.UM, new UnitedStatesMinorOutlyingIslandsCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.US, new UnitedStatesCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.UY, new UruguayCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.UZ, new UzbekistanCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.VA, new VaticanCityCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.VC, new SaintVincentAndTheGrenadinesCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.VE, new VenezuelaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.VG, new BritishVirginIslandsCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.VI, new UnitedStatesVirginIslandsCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.VN, new VietnamCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.VU, new VanuatuCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.WF, new WallisAndFutunaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.WS, new SamoaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.XK, new KosovoCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.YE, new YemenCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.YT, new MayotteCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.ZA, new SouthAfricaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.ZM, new ZambiaCountryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.ZW, new ZimbabweCountryInfo());

            #endregion

            #region Alpha3Code mapping

            foreach (var countryInfo in this._alpha2Code2CountryInfo.Values)
            {
                this._alpha3Code2CountryInfo.Add(countryInfo.Alpha3Code, countryInfo);
            }

            #endregion
        }

        /// <inheritdoc/>
        public IEnumerable<ICountryInfo> GetCountries()
        {
            return this._alpha2Code2CountryInfo.Values;
        }

        /// <inheritdoc/>
        public ICountryInfo GetCountry(string alpha2or3Code)
        {
            if (Enum.TryParse(alpha2or3Code, true, out Alpha2Code alpha2Code))
            {
                return this.GetCountry(alpha2Code);
            }

            if (Enum.TryParse(alpha2or3Code, true, out Alpha3Code alpha3Code))
            {
                return this.GetCountry(alpha3Code);
            }

            throw new UnknownCountryException($"Cannot found a country for code {alpha2or3Code}");
        }

#if NETSTANDARD2_0 || NET48

        /// <inheritdoc/>
        public bool TryGetCountry(string alpha2or3Code, out ICountryInfo? countryInfo)
        {
            return this.TryGetCountryInternal(alpha2or3Code, out countryInfo);
        }

#endif

#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_0_OR_GREATER

        /// <inheritdoc/>
        public bool TryGetCountry(string alpha2or3Code, [NotNullWhen(true)] out ICountryInfo? countryInfo)
        {
            return this.TryGetCountryInternal(alpha2or3Code, out countryInfo);
        }

#endif

        private bool TryGetCountryInternal(string alpha2or3Code, out ICountryInfo? countryInfo)
        {
            if (Enum.TryParse(alpha2or3Code, true, out Alpha2Code alpha2Code))
            {
                if (Enum.IsDefined(typeof(Alpha2Code), alpha2Code))
                {
                    countryInfo = this.GetCountry(alpha2Code);
                    return true;
                }
            }

            if (Enum.TryParse(alpha2or3Code, true, out Alpha3Code alpha3Code))
            {
                if (Enum.IsDefined(typeof(Alpha3Code), alpha3Code))
                {
                    countryInfo = this.GetCountry(alpha3Code);
                    return true;
                }
            }

            countryInfo = null;
            return false;
        }

        /// <inheritdoc/>
        public ICountryInfo GetCountry(Alpha2Code alpha2Code)
        {
            if (this._alpha2Code2CountryInfo.TryGetValue(alpha2Code, out ICountryInfo? countryInfo))
            {
                return countryInfo;
            }

            throw new UnknownCountryException($"Cannot found a country for code {alpha2Code}");
        }

        /// <inheritdoc/>
        public ICountryInfo GetCountry(Alpha3Code alpha3Code)
        {
            if (this._alpha3Code2CountryInfo.TryGetValue(alpha3Code, out ICountryInfo? countryInfo))
            {
                return countryInfo;
            }

            throw new UnknownCountryException($"Cannot found a country for code {alpha3Code}");
        }

        /// <inheritdoc/>
        public ICountryInfo GetCountryByName(string countryName)
        {
            foreach (var countryInfo in this._alpha2Code2CountryInfo.Values)
            {
                if (countryInfo.CommonName.Equals(countryName, StringComparison.OrdinalIgnoreCase))
                {
                    return countryInfo;
                }

                if (countryInfo.OfficialName.Equals(countryName, StringComparison.OrdinalIgnoreCase))
                {
                    return countryInfo;
                }
            }

            throw new UnknownCountryException($"Cannot found a country for countryName {countryName}");
        }
    }
}

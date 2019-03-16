using Nager.Country.CountryInfo;
using System;
using System.Collections.Generic;

namespace Nager.Country
{
    public class CountryProvider : ICountryProvider
    {
        public readonly Dictionary<Alpha2Code, ICountryInfo> _alpha2Code2CountryInfo = new Dictionary<Alpha2Code, ICountryInfo>();
        public readonly Dictionary<Alpha3Code, ICountryInfo> _alpha3Code2CountryInfo = new Dictionary<Alpha3Code, ICountryInfo>();

        public CountryProvider()
        {
            #region Alpha2Code mapping

            this._alpha2Code2CountryInfo.Add(Alpha2Code.AF, new AfghanistanInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.AX, new AlandIslandsInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.AL, new AlbaniaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.DZ, new AlgeriaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.AS, new AmericanSamoaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.AD, new AndorraInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.AO, new AngolaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.AI, new AnguillaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.AQ, new AntarcticaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.AG, new AntiguaAndBarbudaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.AR, new ArgentinaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.AM, new ArmeniaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.AW, new ArubaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.AU, new AustraliaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.AT, new AustriaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.AZ, new AzerbaijanInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.BS, new BahamasInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.BH, new BahrainInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.BD, new BangladeshInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.BB, new BarbadosInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.BY, new BelarusInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.BE, new BelgiumInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.BZ, new BelizeInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.BJ, new BeninInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.BM, new BermudaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.BT, new BhutanInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.BO, new BoliviaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.BA, new BosniaandHerzegovinaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.BW, new BotswanaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.BV, new BouvetIslandInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.BR, new BrazilInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.IO, new BritishIndianOceanTerritoryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.VG, new BritishVirginIslandsInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.BN, new BruneiInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.BG, new BulgariaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.BF, new BurkinaFasoInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.BI, new BurundiInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.KH, new CambodiaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.CM, new CameroonInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.CA, new CanadaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.CV, new CapeVerdeInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.BQ, new CaribbeanNetherlandsInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.KY, new CaymanIslandsInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.CF, new CentralAfricanRepublicInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.TD, new ChadInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.CL, new ChileInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.CN, new ChinaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.CX, new ChristmasIslandInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.CC, new CocosIslandsInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.CO, new ColombiaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.KM, new ComorosInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.CD, new CongoInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.CK, new CookIslandsInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.CR, new CostaRicaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.HR, new CroatiaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.CU, new CubaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.CW, new CuracaoInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.CY, new CyprusInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.CZ, new CzechRepublicInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.DK, new DenmarkInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.DJ, new DjiboutiInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.DM, new DominicaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.DO, new DominicanRepublicInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.EC, new EcuadorInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.EG, new EgyptInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.SV, new ElSalvadorInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.GQ, new EquatorialGuineaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.ER, new EritreaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.EE, new EstoniaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.ET, new EthiopiaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.FK, new FalklandIslandsInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.FO, new FaroeIslandsInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.FJ, new FijiInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.FI, new FinlandInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.FR, new FranceInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.GF, new FrenchGuianaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.PF, new FrenchPolynesiaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.TF, new FrenchSouthernAndAntarcticLandsInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.GA, new GabonInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.GM, new GambiaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.GE, new GeorgiaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.DE, new GermanyInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.GH, new GhanaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.GI, new GibraltarInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.GR, new GreeceInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.GL, new GreenlandInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.GD, new GrenadaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.GP, new GuadeloupeInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.GU, new GuamInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.GT, new GuatemalaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.GG, new GuernseyInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.GW, new GuineaBissauInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.GN, new GuineaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.GY, new GuyanaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.HT, new HaitiInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.HM, new HeardIslandAndMcDonaldIslandsInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.HN, new HondurasInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.HK, new HongKongInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.HU, new HungaryInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.IS, new IcelandInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.IN, new IndiaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.ID, new IndonesiaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.IR, new IranInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.IQ, new IraqInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.IE, new IrelandInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.IM, new IsleofManInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.IL, new IsraelInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.IT, new ItalyInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.CI, new IvoryCoastInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.JM, new JamaicaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.JP, new JapanInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.JE, new JerseyInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.JO, new JordanInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.KZ, new KazakhstanInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.KE, new KenyaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.KI, new KiribatiInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.KW, new KuwaitInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.KG, new KyrgyzstanInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.LA, new LaosInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.LV, new LatviaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.LB, new LebanonInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.LS, new LesothoInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.LR, new LiberiaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.LY, new LibyaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.LI, new LiechtensteinInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.LT, new LithuaniaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.LU, new LuxembourgInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.MO, new MacauInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.MK, new MacedoniaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.MG, new MadagascarInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.MW, new MalawiInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.MY, new MalaysiaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.MV, new MaldivesInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.ML, new MaliInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.MT, new MaltaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.MH, new MarshallIslandsInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.MQ, new MartiniqueInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.MR, new MauritaniaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.MU, new MauritiusInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.YT, new MayotteInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.MX, new MexicoInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.FM, new MicronesiaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.MD, new MoldovaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.MC, new MonacoInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.MN, new MongoliaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.ME, new MontenegroInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.MS, new MontserratInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.MA, new MoroccoInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.MZ, new MozambiqueInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.MM, new MyanmarInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.NA, new NamibiaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.NR, new NauruInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.NP, new NepalInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.NL, new NetherlandsInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.NC, new NewCaledoniaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.NZ, new NewZealandInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.NI, new NicaraguaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.NG, new NigeriaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.NE, new NigerInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.NU, new NiueInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.NF, new NorfolkIslandInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.MP, new NorthernMarianaIslandsInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.KP, new NorthKoreaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.NO, new NorwayInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.OM, new OmanInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.PK, new PakistanInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.PW, new PalauInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.PS, new PalestineInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.PA, new PanamaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.PG, new PapuaNewGuineaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.PY, new ParaguayInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.PE, new PeruInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.PH, new PhilippinesInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.PN, new PitcairnIslandsInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.PL, new PolandInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.PT, new PortugalInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.PR, new PuertoRicoInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.QA, new QatarInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.CG, new RepublicOfTheCongoInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.RE, new ReunionInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.RO, new RomaniaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.RU, new RussiaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.RW, new RwandaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.BL, new SaintBarthelemyInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.SH, new SaintHelenaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.KN, new SaintKittsAndNevisInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.LC, new SaintLuciaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.MF, new SaintMartinInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.PM, new SaintPierreAndMiquelonInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.VC, new SaintVincentAndTheGrenadinesInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.WS, new SamoaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.SM, new SanMarinoInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.ST, new SaoTomeAndPrincipeInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.SA, new SaudiArabiaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.SN, new SenegalInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.RS, new SerbiaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.SC, new SeychellesInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.SL, new SierraLeoneInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.SG, new SingaporeInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.SX, new SintMaartenInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.SK, new SlovakiaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.SI, new SloveniaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.SB, new SolomonIslandsInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.SO, new SomaliaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.ZA, new SouthAfricaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.GS, new SouthGeorgiaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.KR, new SouthKoreaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.SS, new SouthSudanInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.ES, new SpainInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.LK, new SriLankaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.SD, new SudanInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.SR, new SurinameInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.SJ, new SvalbardAndJanMayenInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.SZ, new SwazilandInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.SE, new SwedenInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.CH, new SwitzerlandInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.SY, new SyriaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.TW, new TaiwanInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.TJ, new TajikistanInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.TZ, new TanzaniaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.TH, new ThailandInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.TL, new TimorLesteInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.TG, new TogoInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.TK, new TokelauInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.TO, new TongaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.TT, new TrinidadAndTobagoInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.TN, new TunisiaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.TR, new TurkeyInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.TM, new TurkmenistanInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.TC, new TurksAndCaicosIslandsInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.TV, new TuvaluInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.UG, new UgandaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.UA, new UkraineInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.AE, new UnitedArabEmiratesInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.GB, new UnitedKingdomInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.US, new UnitedStatesInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.UM, new UnitedStatesMinorOutlyingIslandsInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.VI, new UnitedStatesVirginIslandsInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.UY, new UruguayInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.UZ, new UzbekistanInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.VU, new VanuatuInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.VA, new VaticanCityInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.VE, new VenezuelaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.VN, new VietnamInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.WF, new WallisAndFutunaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.EH, new WesternSaharaInfo());
            //this._alpha2Code2CountryInfo.Add(Alpha2Code.XK, new KosovoInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.YE, new YemenInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.ZM, new ZambiaInfo());
            this._alpha2Code2CountryInfo.Add(Alpha2Code.ZW, new ZimbabweInfo());

            #endregion

            #region Alpha3Code mapping

            foreach (var countryInfo in this._alpha2Code2CountryInfo.Values)
            {
                this._alpha3Code2CountryInfo.Add(countryInfo.Alpha3Code, countryInfo);
            }

            #endregion
        }

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

            return null;
        }

        public ICountryInfo GetCountry(Alpha2Code alpha2Code)
        {
            if (this._alpha2Code2CountryInfo.TryGetValue(alpha2Code, out ICountryInfo countryInfo))
            {
                return countryInfo;
            }

            return null;
        }

        public ICountryInfo GetCountry(Alpha3Code alpha3Code)
        {
            if (this._alpha3Code2CountryInfo.TryGetValue(alpha3Code, out ICountryInfo countryInfo))
            {
                return countryInfo;
            }

            return null;
        }
    }
}

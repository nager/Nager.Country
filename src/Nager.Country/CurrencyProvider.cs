using Nager.Country.Currencies;

namespace Nager.Country
{
    /// <summary>
    /// Provides static access to all supported ISO 4217 currency instances.
    /// Each currency is represented as a reusable, immutable object identified by its ISO code.
    /// </summary>
    public static class CurrencyProvider
    {
        /// <summary>
        /// AED currency
        /// </summary>
        public static readonly ICurrency Aed = new AedCurrency();
        /// <summary>
        /// AFN currency
        /// </summary>
        public static readonly ICurrency Afn = new AfnCurrency();
        /// <summary>
        /// ALL currency
        /// </summary>
        public static readonly ICurrency All = new AllCurrency();
        /// <summary>
        /// AMD currency
        /// </summary>
        public static readonly ICurrency Amd = new AmdCurrency();
        /// <summary>
        /// ANG currency
        /// </summary>
        public static readonly ICurrency Ang = new AngCurrency();
        /// <summary>
        /// AOA currency
        /// </summary>
        public static readonly ICurrency Aoa = new AoaCurrency();
        /// <summary>
        /// ARS currency
        /// </summary>
        public static readonly ICurrency Ars = new ArsCurrency();
        /// <summary>
        /// AUD currency
        /// </summary>
        public static readonly ICurrency Aud = new AudCurrency();
        /// <summary>
        /// AWG currency
        /// </summary>
        public static readonly ICurrency Awg = new AwgCurrency();
        /// <summary>
        /// AZN currency
        /// </summary>
        public static readonly ICurrency Azn = new AznCurrency();
        /// <summary>
        /// BAM currency
        /// </summary>
        public static readonly ICurrency Bam = new BamCurrency();
        /// <summary>
        /// BBD currency
        /// </summary>
        public static readonly ICurrency Bbd = new BbdCurrency();
        /// <summary>
        /// BDT currency
        /// </summary>
        public static readonly ICurrency Bdt = new BdtCurrency();
        /// <summary>
        /// BGN currency
        /// </summary>
        public static readonly ICurrency Bgn = new BgnCurrency();
        /// <summary>
        /// BHD currency
        /// </summary>
        public static readonly ICurrency Bhd = new BhdCurrency();
        /// <summary>
        /// BIF currency
        /// </summary>
        public static readonly ICurrency Bif = new BifCurrency();
        /// <summary>
        /// BMD currency
        /// </summary>
        public static readonly ICurrency Bmd = new BmdCurrency();
        /// <summary>
        /// BND currency
        /// </summary>
        public static readonly ICurrency Bnd = new BndCurrency();
        /// <summary>
        /// BOB currency
        /// </summary>
        public static readonly ICurrency Bob = new BobCurrency();
        /// <summary>
        /// BOV currency
        /// </summary>
        public static readonly ICurrency Bov = new BovCurrency();
        /// <summary>
        /// BRL currency
        /// </summary>
        public static readonly ICurrency Brl = new BrlCurrency();
        /// <summary>
        /// BSD currency
        /// </summary>
        public static readonly ICurrency Bsd = new BsdCurrency();
        /// <summary>
        /// BTN currency
        /// </summary>
        public static readonly ICurrency Btn = new BtnCurrency();
        /// <summary>
        /// BWP currency
        /// </summary>
        public static readonly ICurrency Bwp = new BwpCurrency();
        /// <summary>
        /// BYN currency
        /// </summary>
        public static readonly ICurrency Byn = new BynCurrency();
        /// <summary>
        /// BZD currency
        /// </summary>
        public static readonly ICurrency Bzd = new BzdCurrency();
        /// <summary>
        /// CAD currency
        /// </summary>
        public static readonly ICurrency Cad = new CadCurrency();
        /// <summary>
        /// CDF currency
        /// </summary>
        public static readonly ICurrency Cdf = new CdfCurrency();
        /// <summary>
        /// CHF currency
        /// </summary>
        public static readonly ICurrency Chf = new ChfCurrency();
        /// <summary>
        /// CLP currency
        /// </summary>
        public static readonly ICurrency Clp = new ClpCurrency();
        /// <summary>
        /// CNY currency
        /// </summary>
        public static readonly ICurrency Cny = new CnyCurrency();
        /// <summary>
        /// COP currency
        /// </summary>
        public static readonly ICurrency Cop = new CopCurrency();
        /// <summary>
        /// CRC currency
        /// </summary>
        public static readonly ICurrency Crc = new CrcCurrency();
        /// <summary>
        /// CUC currency
        /// </summary>
        public static readonly ICurrency Cuc = new CucCurrency();
        /// <summary>
        /// CUP currency
        /// </summary>
        public static readonly ICurrency Cup = new CupCurrency();
        /// <summary>
        /// CVE currency
        /// </summary>
        public static readonly ICurrency Cve = new CveCurrency();
        /// <summary>
        /// CZK currency
        /// </summary>
        public static readonly ICurrency Czk = new CzkCurrency();
        /// <summary>
        /// DJF currency
        /// </summary>
        public static readonly ICurrency Djf = new DjfCurrency();
        /// <summary>
        /// DKK currency
        /// </summary>
        public static readonly ICurrency Dkk = new DkkCurrency();
        /// <summary>
        /// DOP currency
        /// </summary>
        public static readonly ICurrency Dop = new DopCurrency();
        /// <summary>
        /// DZD currency
        /// </summary>
        public static readonly ICurrency Dzd = new DzdCurrency();
        /// <summary>
        /// EGP currency
        /// </summary>
        public static readonly ICurrency Egp = new EgpCurrency();
        /// <summary>
        /// ERN currency
        /// </summary>
        public static readonly ICurrency Ern = new ErnCurrency();
        /// <summary>
        /// ETB currency
        /// </summary>
        public static readonly ICurrency Etb = new EtbCurrency();
        /// <summary>
        /// EUR currency
        /// </summary>
        public static readonly ICurrency Eur = new EurCurrency();
        /// <summary>
        /// FJD currency
        /// </summary>
        public static readonly ICurrency Fjd = new FjdCurrency();
        /// <summary>
        /// FKP currency
        /// </summary>
        public static readonly ICurrency Fkp = new FkpCurrency();
        /// <summary>
        /// GBP currency
        /// </summary>
        public static readonly ICurrency Gbp = new GbpCurrency();
        /// <summary>
        /// GEL currency
        /// </summary>
        public static readonly ICurrency Gel = new GelCurrency();
        /// <summary>
        /// GHS currency
        /// </summary>
        public static readonly ICurrency Ghs = new GhsCurrency();
        /// <summary>
        /// GIP currency
        /// </summary>
        public static readonly ICurrency Gip = new GipCurrency();
        /// <summary>
        /// GMD currency
        /// </summary>
        public static readonly ICurrency Gmd = new GmdCurrency();
        /// <summary>
        /// GNF currency
        /// </summary>
        public static readonly ICurrency Gnf = new GnfCurrency();
        /// <summary>
        /// GTQ currency
        /// </summary>
        public static readonly ICurrency Gtq = new GtqCurrency();
        /// <summary>
        /// GYD currency
        /// </summary>
        public static readonly ICurrency Gyd = new GydCurrency();
        /// <summary>
        /// HKD currency
        /// </summary>
        public static readonly ICurrency Hkd = new HkdCurrency();
        /// <summary>
        /// HNL currency
        /// </summary>
        public static readonly ICurrency Hnl = new HnlCurrency();
        /// <summary>
        /// HRK currency
        /// </summary>
        public static readonly ICurrency Hrk = new HrkCurrency();
        /// <summary>
        /// HTG currency
        /// </summary>
        public static readonly ICurrency Htg = new HtgCurrency();
        /// <summary>
        /// HUF currency
        /// </summary>
        public static readonly ICurrency Huf = new HufCurrency();
        /// <summary>
        /// IDR currency
        /// </summary>
        public static readonly ICurrency Idr = new IdrCurrency();
        /// <summary>
        /// ILS currency
        /// </summary>
        public static readonly ICurrency Ils = new IlsCurrency();
        /// <summary>
        /// INR currency
        /// </summary>
        public static readonly ICurrency Inr = new InrCurrency();
        /// <summary>
        /// IQD currency
        /// </summary>
        public static readonly ICurrency Iqd = new IqdCurrency();
        /// <summary>
        /// IRR currency
        /// </summary>
        public static readonly ICurrency Irr = new IrrCurrency();
        /// <summary>
        /// ISK currency
        /// </summary>
        public static readonly ICurrency Isk = new IskCurrency();
        /// <summary>
        /// JMD currency
        /// </summary>
        public static readonly ICurrency Jmd = new JmdCurrency();
        /// <summary>
        /// JOD currency
        /// </summary>
        public static readonly ICurrency Jod = new JodCurrency();
        /// <summary>
        /// JPY currency
        /// </summary>
        public static readonly ICurrency Jpy = new JpyCurrency();
        /// <summary>
        /// KES currency
        /// </summary>
        public static readonly ICurrency Kes = new KesCurrency();
        /// <summary>
        /// KGS currency
        /// </summary>
        public static readonly ICurrency Kgs = new KgsCurrency();
        /// <summary>
        /// KHR currency
        /// </summary>
        public static readonly ICurrency Khr = new KhrCurrency();
        /// <summary>
        /// KMF currency
        /// </summary>
        public static readonly ICurrency Kmf = new KmfCurrency();
        /// <summary>
        /// KPW currency
        /// </summary>
        public static readonly ICurrency Kpw = new KpwCurrency();
        /// <summary>
        /// KRW currency
        /// </summary>
        public static readonly ICurrency Krw = new KrwCurrency();
        /// <summary>
        /// KWD currency
        /// </summary>
        public static readonly ICurrency Kwd = new KwdCurrency();
        /// <summary>
        /// KYD currency
        /// </summary>
        public static readonly ICurrency Kyd = new KydCurrency();
        /// <summary>
        /// KZT currency
        /// </summary>
        public static readonly ICurrency Kzt = new KztCurrency();
        /// <summary>
        /// LAK currency
        /// </summary>
        public static readonly ICurrency Lak = new LakCurrency();
        /// <summary>
        /// LBP currency
        /// </summary>
        public static readonly ICurrency Lbp = new LbpCurrency();
        /// <summary>
        /// LKR currency
        /// </summary>
        public static readonly ICurrency Lkr = new LkrCurrency();
        /// <summary>
        /// LRD currency
        /// </summary>
        public static readonly ICurrency Lrd = new LrdCurrency();
        /// <summary>
        /// LSL currency
        /// </summary>
        public static readonly ICurrency Lsl = new LslCurrency();
        /// <summary>
        /// LYD currency
        /// </summary>
        public static readonly ICurrency Lyd = new LydCurrency();
        /// <summary>
        /// MAD currency
        /// </summary>
        public static readonly ICurrency Mad = new MadCurrency();
        /// <summary>
        /// MDL currency
        /// </summary>
        public static readonly ICurrency Mdl = new MdlCurrency();
        /// <summary>
        /// MGA currency
        /// </summary>
        public static readonly ICurrency Mga = new MgaCurrency();
        /// <summary>
        /// MKD currency
        /// </summary>
        public static readonly ICurrency Mkd = new MkdCurrency();
        /// <summary>
        /// MMK currency
        /// </summary>
        public static readonly ICurrency Mmk = new MmkCurrency();
        /// <summary>
        /// MNT currency
        /// </summary>
        public static readonly ICurrency Mnt = new MntCurrency();
        /// <summary>
        /// MOP currency
        /// </summary>
        public static readonly ICurrency Mop = new MopCurrency();
        /// <summary>
        /// MRO currency
        /// </summary>
        public static readonly ICurrency Mro = new MroCurrency();
        /// <summary>
        /// MUR currency
        /// </summary>
        public static readonly ICurrency Mur = new MurCurrency();
        /// <summary>
        /// MVR currency
        /// </summary>
        public static readonly ICurrency Mvr = new MvrCurrency();
        /// <summary>
        /// MWK currency
        /// </summary>
        public static readonly ICurrency Mwk = new MwkCurrency();
        /// <summary>
        /// MXN currency
        /// </summary>
        public static readonly ICurrency Mxn = new MxnCurrency();
        /// <summary>
        /// MYR currency
        /// </summary>
        public static readonly ICurrency Myr = new MyrCurrency();
        /// <summary>
        /// MZN currency
        /// </summary>
        public static readonly ICurrency Mzn = new MznCurrency();
        /// <summary>
        /// NAD currency
        /// </summary>
        public static readonly ICurrency Nad = new NadCurrency();
        /// <summary>
        /// NGN currency
        /// </summary>
        public static readonly ICurrency Ngn = new NgnCurrency();
        /// <summary>
        /// NIO currency
        /// </summary>
        public static readonly ICurrency Nio = new NioCurrency();
        /// <summary>
        /// NOK currency
        /// </summary>
        public static readonly ICurrency Nok = new NokCurrency();
        /// <summary>
        /// NPR currency
        /// </summary>
        public static readonly ICurrency Npr = new NprCurrency();
        /// <summary>
        /// NZD currency
        /// </summary>
        public static readonly ICurrency Nzd = new NzdCurrency();
        /// <summary>
        /// OMR currency
        /// </summary>
        public static readonly ICurrency Omr = new OmrCurrency();
        /// <summary>
        /// PAB currency
        /// </summary>
        public static readonly ICurrency Pab = new PabCurrency();
        /// <summary>
        /// PEN currency
        /// </summary>
        public static readonly ICurrency Pen = new PenCurrency();
        /// <summary>
        /// PGK currency
        /// </summary>
        public static readonly ICurrency Pgk = new PgkCurrency();
        /// <summary>
        /// PHP currency
        /// </summary>
        public static readonly ICurrency Php = new PhpCurrency();
        /// <summary>
        /// PKR currency
        /// </summary>
        public static readonly ICurrency Pkr = new PkrCurrency();
        /// <summary>
        /// PLN currency
        /// </summary>
        public static readonly ICurrency Pln = new PlnCurrency();
        /// <summary>
        /// PYG currency
        /// </summary>
        public static readonly ICurrency Pyg = new PygCurrency();
        /// <summary>
        /// QAR currency
        /// </summary>
        public static readonly ICurrency Qar = new QarCurrency();
        /// <summary>
        /// RON currency
        /// </summary>
        public static readonly ICurrency Ron = new RonCurrency();
        /// <summary>
        /// RSD currency
        /// </summary>
        public static readonly ICurrency Rsd = new RsdCurrency();
        /// <summary>
        /// RUB currency
        /// </summary>
        public static readonly ICurrency Rub = new RubCurrency();
        /// <summary>
        /// RWF currency
        /// </summary>
        public static readonly ICurrency Rwf = new RwfCurrency();
        /// <summary>
        /// SAR currency
        /// </summary>
        public static readonly ICurrency Sar = new SarCurrency();
        /// <summary>
        /// SBD currency
        /// </summary>
        public static readonly ICurrency Sbd = new SbdCurrency();
        /// <summary>
        /// SCR currency
        /// </summary>
        public static readonly ICurrency Scr = new ScrCurrency();
        /// <summary>
        /// SDG currency
        /// </summary>
        public static readonly ICurrency Sdg = new SdgCurrency();
        /// <summary>
        /// SEK currency
        /// </summary>
        public static readonly ICurrency Sek = new SekCurrency();
        /// <summary>
        /// SGD currency
        /// </summary>
        public static readonly ICurrency Sgd = new SgdCurrency();
        /// <summary>
        /// SHP currency
        /// </summary>
        public static readonly ICurrency Shp = new ShpCurrency();
        /// <summary>
        /// SLL currency
        /// </summary>
        public static readonly ICurrency Sll = new SllCurrency();
        /// <summary>
        /// SOS currency
        /// </summary>
        public static readonly ICurrency Sos = new SosCurrency();
        /// <summary>
        /// SRD currency
        /// </summary>
        public static readonly ICurrency Srd = new SrdCurrency();
        /// <summary>
        /// SSP currency
        /// </summary>
        public static readonly ICurrency Ssp = new SspCurrency();
        /// <summary>
        /// STD currency
        /// </summary>
        public static readonly ICurrency Std = new StdCurrency();
        /// <summary>
        /// SVC currency
        /// </summary>
        public static readonly ICurrency Svc = new SvcCurrency();
        /// <summary>
        /// SYP currency
        /// </summary>
        public static readonly ICurrency Syp = new SypCurrency();
        /// <summary>
        /// SZL currency
        /// </summary>
        public static readonly ICurrency Szl = new SzlCurrency();
        /// <summary>
        /// THB currency
        /// </summary>
        public static readonly ICurrency Thb = new ThbCurrency();
        /// <summary>
        /// TJS currency
        /// </summary>
        public static readonly ICurrency Tjs = new TjsCurrency();
        /// <summary>
        /// TMT currency
        /// </summary>
        public static readonly ICurrency Tmt = new TmtCurrency();
        /// <summary>
        /// TND currency
        /// </summary>
        public static readonly ICurrency Tnd = new TndCurrency();
        /// <summary>
        /// TOP currency
        /// </summary>
        public static readonly ICurrency Top = new TopCurrency();
        /// <summary>
        /// TRY currency
        /// </summary>
        public static readonly ICurrency Try = new TryCurrency();
        /// <summary>
        /// TTD currency
        /// </summary>
        public static readonly ICurrency Ttd = new TtdCurrency();
        /// <summary>
        /// TWD currency
        /// </summary>
        public static readonly ICurrency Twd = new TwdCurrency();
        /// <summary>
        /// TZS currency
        /// </summary>
        public static readonly ICurrency Tzs = new TzsCurrency();
        /// <summary>
        /// UAH currency
        /// </summary>
        public static readonly ICurrency Uah = new UahCurrency();
        /// <summary>
        /// UGX currency
        /// </summary>
        public static readonly ICurrency Ugx = new UgxCurrency();
        /// <summary>
        /// USD currency
        /// </summary>
        public static readonly ICurrency Usd = new UsdCurrency();
        /// <summary>
        /// UYU currency
        /// </summary>
        public static readonly ICurrency Uyu = new UyuCurrency();
        /// <summary>
        /// UZS currency
        /// </summary>
        public static readonly ICurrency Uzs = new UzsCurrency();
        /// <summary>
        /// VEF currency
        /// </summary>
        public static readonly ICurrency Vef = new VefCurrency();
        /// <summary>
        /// VES currency
        /// </summary>
        public static readonly ICurrency Ves = new VesCurrency();
        /// <summary>
        /// VND currency
        /// </summary>
        public static readonly ICurrency Vnd = new VndCurrency();
        /// <summary>
        /// VUV currency
        /// </summary>
        public static readonly ICurrency Vuv = new VuvCurrency();
        /// <summary>
        /// WST currency
        /// </summary>
        public static readonly ICurrency Wst = new WstCurrency();
        /// <summary>
        /// XAF currency
        /// </summary>
        public static readonly ICurrency Xaf = new XafCurrency();
        /// <summary>
        /// XCD currency
        /// </summary>
        public static readonly ICurrency Xcd = new XcdCurrency();
        /// <summary>
        /// XDR currency
        /// </summary>
        public static readonly ICurrency Xdr = new XdrCurrency();
        /// <summary>
        /// XOF currency
        /// </summary>
        public static readonly ICurrency Xof = new XofCurrency();
        /// <summary>
        /// XPF currency
        /// </summary>
        public static readonly ICurrency Xpf = new XpfCurrency();
        /// <summary>
        /// YER currency
        /// </summary>
        public static readonly ICurrency Yer = new YerCurrency();
        /// <summary>
        /// ZAR currency
        /// </summary>
        public static readonly ICurrency Zar = new ZarCurrency();
        /// <summary>
        /// ZMW currency
        /// </summary>
        public static readonly ICurrency Zmw = new ZmwCurrency();
        /// <summary>
        /// ZWL currency
        /// </summary>
        public static readonly ICurrency Zwl = new ZwlCurrency();
    }
}

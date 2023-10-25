using System.ComponentModel;

namespace CurrencyData;

public enum Currency
{
    /// <summary>
    /// Unknown - Represent the 0 value enum
    /// </summary>
    Unknown = 0,
    /// <summary>
    /// Afghani
    /// </summary>
    [Description("Afghani")] AFN = 971,
    /// <summary>
    /// Euro
    /// </summary>
    [Description("Euro")] EUR = 978,
    /// <summary>
    /// Lek
    /// </summary>
    [Description("Lek")] ALL = 8,
    /// <summary>
    /// Algerian Dinar
    /// </summary>
    [Description("Algerian Dinar")] DZD = 12,
    /// <summary>
    /// US Dollar
    /// </summary>
    [Description("US Dollar")] USD = 840,
    /// <summary>
    /// Kwanza
    /// </summary>
    [Description("Kwanza")] AOA = 973,
    /// <summary>
    /// East Caribbean Dollar
    /// </summary>
    [Description("East Caribbean Dollar")] XCD = 951,
    /// <summary>
    /// Argentine Peso
    /// </summary>
    [Description("Argentine Peso")] ARS = 32,
    /// <summary>
    /// Armenian Dram
    /// </summary>
    [Description("Armenian Dram")] AMD = 51,
    /// <summary>
    /// Aruban Florin
    /// </summary>
    [Description("Aruban Florin")] AWG = 533,
    /// <summary>
    /// Australian Dollar
    /// </summary>
    [Description("Australian Dollar")] AUD = 36,
    /// <summary>
    /// Azerbaijan Manat
    /// </summary>
    [Description("Azerbaijan Manat")] AZN = 944,
    /// <summary>
    /// Bahamian Dollar
    /// </summary>
    [Description("Bahamian Dollar")] BSD = 44,
    /// <summary>
    /// Bahraini Dinar
    /// </summary>
    [Description("Bahraini Dinar")] BHD = 48,
    /// <summary>
    /// Taka
    /// </summary>
    [Description("Taka")] BDT = 50,
    /// <summary>
    /// Barbados Dollar
    /// </summary>
    [Description("Barbados Dollar")] BBD = 52,
    /// <summary>
    /// Belarusian Ruble
    /// </summary>
    [Description("Belarusian Ruble")] BYN = 933,
    /// <summary>
    /// Belize Dollar
    /// </summary>
    [Description("Belize Dollar")] BZD = 84,
    /// <summary>
    /// CFA Franc BCEAO
    /// </summary>
    [Description("CFA Franc BCEAO")] XOF = 952,
    /// <summary>
    /// Bermudian Dollar
    /// </summary>
    [Description("Bermudian Dollar")] BMD = 60,
    /// <summary>
    /// Indian Rupee
    /// </summary>
    [Description("Indian Rupee")] INR = 356,
    /// <summary>
    /// Ngultrum
    /// </summary>
    [Description("Ngultrum")] BTN = 64,
    /// <summary>
    /// Boliviano
    /// </summary>
    [Description("Boliviano")] BOB = 68,
    /// <summary>
    /// Mvdol
    /// </summary>
    [Description("Mvdol")] BOV = 984,
    /// <summary>
    /// Convertible Mark
    /// </summary>
    [Description("Convertible Mark")] BAM = 977,
    /// <summary>
    /// Pula
    /// </summary>
    [Description("Pula")] BWP = 72,
    /// <summary>
    /// Norwegian Krone
    /// </summary>
    [Description("Norwegian Krone")] NOK = 578,
    /// <summary>
    /// Brazilian Real
    /// </summary>
    [Description("Brazilian Real")] BRL = 986,
    /// <summary>
    /// Brunei Dollar
    /// </summary>
    [Description("Brunei Dollar")] BND = 96,
    /// <summary>
    /// Bulgarian Lev
    /// </summary>
    [Description("Bulgarian Lev")] BGN = 975,
    /// <summary>
    /// Burundi Franc
    /// </summary>
    [Description("Burundi Franc")] BIF = 108,
    /// <summary>
    /// Cabo Verde Escudo
    /// </summary>
    [Description("Cabo Verde Escudo")] CVE = 132,
    /// <summary>
    /// Riel
    /// </summary>
    [Description("Riel")] KHR = 116,
    /// <summary>
    /// CFA Franc BEAC
    /// </summary>
    [Description("CFA Franc BEAC")] XAF = 950,
    /// <summary>
    /// Canadian Dollar
    /// </summary>
    [Description("Canadian Dollar")] CAD = 124,
    /// <summary>
    /// Cayman Islands Dollar
    /// </summary>
    [Description("Cayman Islands Dollar")] KYD = 136,
    /// <summary>
    /// Chilean Peso
    /// </summary>
    [Description("Chilean Peso")] CLP = 152,
    /// <summary>
    /// Unidad de Fomento
    /// </summary>
    [Description("Unidad de Fomento")] CLF = 990,
    /// <summary>
    /// Yuan Renminbi
    /// </summary>
    [Description("Yuan Renminbi")] CNY = 156,
    /// <summary>
    /// Colombian Peso
    /// </summary>
    [Description("Colombian Peso")] COP = 170,
    /// <summary>
    /// Unidad de Valor Real
    /// </summary>
    [Description("Unidad de Valor Real")] COU = 970,
    /// <summary>
    /// Comorian Franc
    /// </summary>
    [Description("Comorian Franc")] KMF = 174,
    /// <summary>
    /// Congolese Franc
    /// </summary>
    [Description("Congolese Franc")] CDF = 976,
    /// <summary>
    /// New Zealand Dollar
    /// </summary>
    [Description("New Zealand Dollar")] NZD = 554,
    /// <summary>
    /// Costa Rican Colon
    /// </summary>
    [Description("Costa Rican Colon")] CRC = 188,
    /// <summary>
    /// Kuna
    /// </summary>
    [Description("Kuna")] HRK = 191,
    /// <summary>
    /// Cuban Peso
    /// </summary>
    [Description("Cuban Peso")] CUP = 192,
    /// <summary>
    /// Peso Convertible
    /// </summary>
    [Description("Peso Convertible")] CUC = 931,
    /// <summary>
    /// Netherlands Antillean Guilder
    /// </summary>
    [Description("Netherlands Antillean Guilder")] ANG = 532,
    /// <summary>
    /// Czech Koruna
    /// </summary>
    [Description("Czech Koruna")] CZK = 203,
    /// <summary>
    /// Danish Krone
    /// </summary>
    [Description("Danish Krone")] DKK = 208,
    /// <summary>
    /// Djibouti Franc
    /// </summary>
    [Description("Djibouti Franc")] DJF = 262,
    /// <summary>
    /// Dominican Peso
    /// </summary>
    [Description("Dominican Peso")] DOP = 214,
    /// <summary>
    /// Egyptian Pound
    /// </summary>
    [Description("Egyptian Pound")] EGP = 818,
    /// <summary>
    /// El Salvador Colon
    /// </summary>
    [Description("El Salvador Colon")] SVC = 222,
    /// <summary>
    /// Nakfa
    /// </summary>
    [Description("Nakfa")] ERN = 232,
    /// <summary>
    /// Lilangeni
    /// </summary>
    [Description("Lilangeni")] SZL = 748,
    /// <summary>
    /// Ethiopian Birr
    /// </summary>
    [Description("Ethiopian Birr")] ETB = 230,
    /// <summary>
    /// Falkland Islands Pound
    /// </summary>
    [Description("Falkland Islands Pound")] FKP = 238,
    /// <summary>
    /// Fiji Dollar
    /// </summary>
    [Description("Fiji Dollar")] FJD = 242,
    /// <summary>
    /// CFP Franc
    /// </summary>
    [Description("CFP Franc")] XPF = 953,
    /// <summary>
    /// Dalasi
    /// </summary>
    [Description("Dalasi")] GMD = 270,
    /// <summary>
    /// Lari
    /// </summary>
    [Description("Lari")] GEL = 981,
    /// <summary>
    /// Ghana Cedi
    /// </summary>
    [Description("Ghana Cedi")] GHS = 936,
    /// <summary>
    /// Gibraltar Pound
    /// </summary>
    [Description("Gibraltar Pound")] GIP = 292,
    /// <summary>
    /// Quetzal
    /// </summary>
    [Description("Quetzal")] GTQ = 320,
    /// <summary>
    /// Pound Sterling
    /// </summary>
    [Description("Pound Sterling")] GBP = 826,
    /// <summary>
    /// Guinean Franc
    /// </summary>
    [Description("Guinean Franc")] GNF = 324,
    /// <summary>
    /// Guyana Dollar
    /// </summary>
    [Description("Guyana Dollar")] GYD = 328,
    /// <summary>
    /// Gourde
    /// </summary>
    [Description("Gourde")] HTG = 332,
    /// <summary>
    /// Lempira
    /// </summary>
    [Description("Lempira")] HNL = 340,
    /// <summary>
    /// Hong Kong Dollar
    /// </summary>
    [Description("Hong Kong Dollar")] HKD = 344,
    /// <summary>
    /// Forint
    /// </summary>
    [Description("Forint")] HUF = 348,
    /// <summary>
    /// Iceland Krona
    /// </summary>
    [Description("Iceland Krona")] ISK = 352,
    /// <summary>
    /// Rupiah
    /// </summary>
    [Description("Rupiah")] IDR = 360,
    /// <summary>
    /// SDR (Special Drawing Right)
    /// </summary>
    [Description("SDR (Special Drawing Right)")] XDR = 960,
    /// <summary>
    /// Iranian Rial
    /// </summary>
    [Description("Iranian Rial")] IRR = 364,
    /// <summary>
    /// Iraqi Dinar
    /// </summary>
    [Description("Iraqi Dinar")] IQD = 368,
    /// <summary>
    /// New Israeli Sheqel
    /// </summary>
    [Description("New Israeli Sheqel")] ILS = 376,
    /// <summary>
    /// Jamaican Dollar
    /// </summary>
    [Description("Jamaican Dollar")] JMD = 388,
    /// <summary>
    /// Yen
    /// </summary>
    [Description("Yen")] JPY = 392,
    /// <summary>
    /// Jordanian Dinar
    /// </summary>
    [Description("Jordanian Dinar")] JOD = 400,
    /// <summary>
    /// Tenge
    /// </summary>
    [Description("Tenge")] KZT = 398,
    /// <summary>
    /// Kenyan Shilling
    /// </summary>
    [Description("Kenyan Shilling")] KES = 404,
    /// <summary>
    /// North Korean Won
    /// </summary>
    [Description("North Korean Won")] KPW = 408,
    /// <summary>
    /// Won
    /// </summary>
    [Description("Won")] KRW = 410,
    /// <summary>
    /// Kuwaiti Dinar
    /// </summary>
    [Description("Kuwaiti Dinar")] KWD = 414,
    /// <summary>
    /// Som
    /// </summary>
    [Description("Som")] KGS = 417,
    /// <summary>
    /// Lao Kip
    /// </summary>
    [Description("Lao Kip")] LAK = 418,
    /// <summary>
    /// Lebanese Pound
    /// </summary>
    [Description("Lebanese Pound")] LBP = 422,
    /// <summary>
    /// Loti
    /// </summary>
    [Description("Loti")] LSL = 426,
    /// <summary>
    /// Rand
    /// </summary>
    [Description("Rand")] ZAR = 710,
    /// <summary>
    /// Liberian Dollar
    /// </summary>
    [Description("Liberian Dollar")] LRD = 430,
    /// <summary>
    /// Libyan Dinar
    /// </summary>
    [Description("Libyan Dinar")] LYD = 434,
    /// <summary>
    /// Swiss Franc
    /// </summary>
    [Description("Swiss Franc")] CHF = 756,
    /// <summary>
    /// Pataca
    /// </summary>
    [Description("Pataca")] MOP = 446,
    /// <summary>
    /// Denar
    /// </summary>
    [Description("Denar")] MKD = 807,
    /// <summary>
    /// Malagasy Ariary
    /// </summary>
    [Description("Malagasy Ariary")] MGA = 969,
    /// <summary>
    /// Malawi Kwacha
    /// </summary>
    [Description("Malawi Kwacha")] MWK = 454,
    /// <summary>
    /// Malaysian Ringgit
    /// </summary>
    [Description("Malaysian Ringgit")] MYR = 458,
    /// <summary>
    /// Rufiyaa
    /// </summary>
    [Description("Rufiyaa")] MVR = 462,
    /// <summary>
    /// Ouguiya
    /// </summary>
    [Description("Ouguiya")] MRU = 929,
    /// <summary>
    /// Mauritius Rupee
    /// </summary>
    [Description("Mauritius Rupee")] MUR = 480,
    /// <summary>
    /// ADB Unit of Account
    /// </summary>
    [Description("ADB Unit of Account")] XUA = 965,
    /// <summary>
    /// Mexican Peso
    /// </summary>
    [Description("Mexican Peso")] MXN = 484,
    /// <summary>
    /// Mexican Unidad de Inversion (UDI)
    /// </summary>
    [Description("Mexican Unidad de Inversion (UDI)")] MXV = 979,
    /// <summary>
    /// Moldovan Leu
    /// </summary>
    [Description("Moldovan Leu")] MDL = 498,
    /// <summary>
    /// Tugrik
    /// </summary>
    [Description("Tugrik")] MNT = 496,
    /// <summary>
    /// Moroccan Dirham
    /// </summary>
    [Description("Moroccan Dirham")] MAD = 504,
    /// <summary>
    /// Mozambique Metical
    /// </summary>
    [Description("Mozambique Metical")] MZN = 943,
    /// <summary>
    /// Kyat
    /// </summary>
    [Description("Kyat")] MMK = 104,
    /// <summary>
    /// Namibia Dollar
    /// </summary>
    [Description("Namibia Dollar")] NAD = 516,
    /// <summary>
    /// Nepalese Rupee
    /// </summary>
    [Description("Nepalese Rupee")] NPR = 524,
    /// <summary>
    /// Cordoba Oro
    /// </summary>
    [Description("Cordoba Oro")] NIO = 558,
    /// <summary>
    /// Naira
    /// </summary>
    [Description("Naira")] NGN = 566,
    /// <summary>
    /// Rial Omani
    /// </summary>
    [Description("Rial Omani")] OMR = 512,
    /// <summary>
    /// Pakistan Rupee
    /// </summary>
    [Description("Pakistan Rupee")] PKR = 586,
    /// <summary>
    /// Balboa
    /// </summary>
    [Description("Balboa")] PAB = 590,
    /// <summary>
    /// Kina
    /// </summary>
    [Description("Kina")] PGK = 598,
    /// <summary>
    /// Guarani
    /// </summary>
    [Description("Guarani")] PYG = 600,
    /// <summary>
    /// Sol
    /// </summary>
    [Description("Sol")] PEN = 604,
    /// <summary>
    /// Philippine Peso
    /// </summary>
    [Description("Philippine Peso")] PHP = 608,
    /// <summary>
    /// Zloty
    /// </summary>
    [Description("Zloty")] PLN = 985,
    /// <summary>
    /// Qatari Rial
    /// </summary>
    [Description("Qatari Rial")] QAR = 634,
    /// <summary>
    /// Romanian Leu
    /// </summary>
    [Description("Romanian Leu")] RON = 946,
    /// <summary>
    /// Russian Ruble
    /// </summary>
    [Description("Russian Ruble")] RUB = 643,
    /// <summary>
    /// Rwanda Franc
    /// </summary>
    [Description("Rwanda Franc")] RWF = 646,
    /// <summary>
    /// Saint Helena Pound
    /// </summary>
    [Description("Saint Helena Pound")] SHP = 654,
    /// <summary>
    /// Tala
    /// </summary>
    [Description("Tala")] WST = 882,
    /// <summary>
    /// Dobra
    /// </summary>
    [Description("Dobra")] STN = 930,
    /// <summary>
    /// Saudi Riyal
    /// </summary>
    [Description("Saudi Riyal")] SAR = 682,
    /// <summary>
    /// Serbian Dinar
    /// </summary>
    [Description("Serbian Dinar")] RSD = 941,
    /// <summary>
    /// Seychelles Rupee
    /// </summary>
    [Description("Seychelles Rupee")] SCR = 690,
    /// <summary>
    /// Leone
    /// </summary>
    [Description("Leone")] SLL = 694,
    /// <summary>
    /// Singapore Dollar
    /// </summary>
    [Description("Singapore Dollar")] SGD = 702,
    /// <summary>
    /// Sucre
    /// </summary>
    [Description("Sucre")] XSU = 994,
    /// <summary>
    /// Solomon Islands Dollar
    /// </summary>
    [Description("Solomon Islands Dollar")] SBD = 90,
    /// <summary>
    /// Somali Shilling
    /// </summary>
    [Description("Somali Shilling")] SOS = 706,
    /// <summary>
    /// South Sudanese Pound
    /// </summary>
    [Description("South Sudanese Pound")] SSP = 728,
    /// <summary>
    /// Sri Lanka Rupee
    /// </summary>
    [Description("Sri Lanka Rupee")] LKR = 144,
    /// <summary>
    /// Sudanese Pound
    /// </summary>
    [Description("Sudanese Pound")] SDG = 938,
    /// <summary>
    /// Surinam Dollar
    /// </summary>
    [Description("Surinam Dollar")] SRD = 968,
    /// <summary>
    /// Swedish Krona
    /// </summary>
    [Description("Swedish Krona")] SEK = 752,
    /// <summary>
    /// WIR Euro
    /// </summary>
    [Description("WIR Euro")] CHE = 947,
    /// <summary>
    /// WIR Franc
    /// </summary>
    [Description("WIR Franc")] CHW = 948,
    /// <summary>
    /// Syrian Pound
    /// </summary>
    [Description("Syrian Pound")] SYP = 760,
    /// <summary>
    /// New Taiwan Dollar
    /// </summary>
    [Description("New Taiwan Dollar")] TWD = 901,
    /// <summary>
    /// Somoni
    /// </summary>
    [Description("Somoni")] TJS = 972,
    /// <summary>
    /// Tanzanian Shilling
    /// </summary>
    [Description("Tanzanian Shilling")] TZS = 834,
    /// <summary>
    /// Baht
    /// </summary>
    [Description("Baht")] THB = 764,
    /// <summary>
    /// Pa'anga
    /// </summary>
    [Description("Pa'anga")] TOP = 776,
    /// <summary>
    /// Trinidad and Tobago Dollar
    /// </summary>
    [Description("Trinidad and Tobago Dollar")] TTD = 780,
    /// <summary>
    /// Tunisian Dinar
    /// </summary>
    [Description("Tunisian Dinar")] TND = 788,
    /// <summary>
    /// Turkish Lira
    /// </summary>
    [Description("Turkish Lira")] TRY = 949,
    /// <summary>
    /// Turkmenistan New Manat
    /// </summary>
    [Description("Turkmenistan New Manat")] TMT = 934,
    /// <summary>
    /// Uganda Shilling
    /// </summary>
    [Description("Uganda Shilling")] UGX = 800,
    /// <summary>
    /// Hryvnia
    /// </summary>
    [Description("Hryvnia")] UAH = 980,
    /// <summary>
    /// UAE Dirham
    /// </summary>
    [Description("UAE Dirham")] AED = 784,
    /// <summary>
    /// US Dollar (Next day)
    /// </summary>
    [Description("US Dollar (Next day)")] USN = 997,
    /// <summary>
    /// Peso Uruguayo
    /// </summary>
    [Description("Peso Uruguayo")] UYU = 858,
    /// <summary>
    /// Uruguay Peso en Unidades Indexadas (UI)
    /// </summary>
    [Description("Uruguay Peso en Unidades Indexadas (UI)")] UYI = 940,
    /// <summary>
    /// Unidad Previsional
    /// </summary>
    [Description("Unidad Previsional")] UYW = 927,
    /// <summary>
    /// Uzbekistan Sum
    /// </summary>
    [Description("Uzbekistan Sum")] UZS = 860,
    /// <summary>
    /// Vatu
    /// </summary>
    [Description("Vatu")] VUV = 548,
    /// <summary>
    /// Bolívar Soberano
    /// </summary>
    [Description("Bolívar Soberano")] VES = 928,
    /// <summary>
    /// Dong
    /// </summary>
    [Description("Dong")] VND = 704,
    /// <summary>
    /// Yemeni Rial
    /// </summary>
    [Description("Yemeni Rial")] YER = 886,
    /// <summary>
    /// Zambian Kwacha
    /// </summary>
    [Description("Zambian Kwacha")] ZMW = 967,
    /// <summary>
    /// Zimbabwe Dollar
    /// </summary>
    [Description("Zimbabwe Dollar")] ZWL = 932,
    /// <summary>
    /// Bond Markets Unit European Composite Unit (EURCO)
    /// </summary>
    [Description("Bond Markets Unit European Composite Unit (EURCO)")] XBA = 955,
    /// <summary>
    /// Bond Markets Unit European Monetary Unit (E.M.U.-6)
    /// </summary>
    [Description("Bond Markets Unit European Monetary Unit (E.M.U.-6)")] XBB = 956,
    /// <summary>
    /// Bond Markets Unit European Unit of Account 9 (E.U.A.-9)
    /// </summary>
    [Description("Bond Markets Unit European Unit of Account 9 (E.U.A.-9)")] XBC = 957,
    /// <summary>
    /// Bond Markets Unit European Unit of Account 17 (E.U.A.-17)
    /// </summary>
    [Description("Bond Markets Unit European Unit of Account 17 (E.U.A.-17)")] XBD = 958,
    /// <summary>
    /// Codes specifically reserved for testing purposes
    /// </summary>
    [Description("Codes specifically reserved for testing purposes")] XTS = 963,
    /// <summary>
    /// The codes assigned for transactions where no currency is involved
    /// </summary>
    [Description("The codes assigned for transactions where no currency is involved")] XXX = 999,
    /// <summary>
    /// Gold
    /// </summary>
    [Description("Gold")] XAU = 959,
    /// <summary>
    /// Palladium
    /// </summary>
    [Description("Palladium")] XPD = 964,
    /// <summary>
    /// Platinum
    /// </summary>
    [Description("Platinum")] XPT = 962,
    /// <summary>
    /// Silver
    /// </summary>
    [Description("Silver")] XAG = 961,
    /// <summary>
    /// Afghani
    /// </summary>
    [Description("Afghani")] AFA = 4,
    /// <summary>
    /// Markka
    /// </summary>
    [Description("Markka")] FIM = 246,
    /// <summary>
    /// Andorran Peseta
    /// </summary>
    [Description("Andorran Peseta")] ADP = 20,
    /// <summary>
    /// Spanish Peseta
    /// </summary>
    [Description("Spanish Peseta")] ESP = 724,
    /// <summary>
    /// French Franc
    /// </summary>
    [Description("French Franc")] FRF = 250,
    /// <summary>
    /// Kwanza
    /// </summary>
    [Description("Kwanza")] AOK = 24,
    /// <summary>
    /// Kwanza Reajustado
    /// </summary>
    [Description("Kwanza Reajustado")] AOR = 982,
    /// <summary>
    /// Russian Ruble
    /// </summary>
    [Description("Russian Ruble")] RUR = 810,
    /// <summary>
    /// Schilling
    /// </summary>
    [Description("Schilling")] ATS = 40,
    /// <summary>
    /// Azerbaijan Manat
    /// </summary>
    [Description("Azerbaijan Manat")] AYM = 945,
    /// <summary>
    /// Azerbaijanian Manat
    /// </summary>
    [Description("Azerbaijanian Manat")] AZM = 31,
    /// <summary>
    /// Belarusian Ruble
    /// </summary>
    [Description("Belarusian Ruble")] BYB = 112,
    /// <summary>
    /// Belarusian Ruble
    /// </summary>
    [Description("Belarusian Ruble")] BYR = 974,
    /// <summary>
    /// Convertible Franc
    /// </summary>
    [Description("Convertible Franc")] BEC = 993,
    /// <summary>
    /// Belgian Franc
    /// </summary>
    [Description("Belgian Franc")] BEF = 56,
    /// <summary>
    /// Financial Franc
    /// </summary>
    [Description("Financial Franc")] BEL = 992,
    /// <summary>
    /// Dinar
    /// </summary>
    [Description("Dinar")] BAD = 70,
    /// <summary>
    /// Cruzeiro
    /// </summary>
    [Description("Cruzeiro")] BRB = 76,
    /// <summary>
    /// Cruzeiro Real
    /// </summary>
    [Description("Cruzeiro Real")] BRR = 987,
    /// <summary>
    /// Lev A/52
    /// </summary>
    [Description("Lev A/52")] BGJ = 100,
    /// <summary>
    /// Cyprus Pound
    /// </summary>
    [Description("Cyprus Pound")] CYP = 196,
    /// <summary>
    /// Koruna
    /// </summary>
    [Description("Koruna")] CSK = 200,
    /// <summary>
    /// Sucre
    /// </summary>
    [Description("Sucre")] ECS = 218,
    /// <summary>
    /// Unidad de Valor Constante (UVC)
    /// </summary>
    [Description("Unidad de Valor Constante (UVC)")] ECV = 983,
    /// <summary>
    /// Ekwele
    /// </summary>
    [Description("Ekwele")] GQE = 226,
    /// <summary>
    /// Kroon
    /// </summary>
    [Description("Kroon")] EEK = 233,
    /// <summary>
    /// European Currency Unit (E.C.U)
    /// </summary>
    [Description("European Currency Unit (E.C.U)")] XEU = 954,
    /// <summary>
    /// Georgian Coupon
    /// </summary>
    [Description("Georgian Coupon")] GEK = 268,
    /// <summary>
    /// Mark der DDR
    /// </summary>
    [Description("Mark der DDR")] DDM = 278,
    /// <summary>
    /// Deutsche Mark
    /// </summary>
    [Description("Deutsche Mark")] DEM = 276,
    /// <summary>
    /// Cedi
    /// </summary>
    [Description("Cedi")] GHC = 288,
    /// <summary>
    /// Ghana Cedi
    /// </summary>
    [Description("Ghana Cedi")] GHP = 939,
    /// <summary>
    /// Drachma
    /// </summary>
    [Description("Drachma")] GRD = 300,
    /// <summary>
    /// Guinea Escudo
    /// </summary>
    [Description("Guinea Escudo")] GWE = 624,
    /// <summary>
    /// Italian Lira
    /// </summary>
    [Description("Italian Lira")] ITL = 380,
    /// <summary>
    /// Irish Pound
    /// </summary>
    [Description("Irish Pound")] IEP = 372,
    /// <summary>
    /// Latvian Lats
    /// </summary>
    [Description("Latvian Lats")] LVL = 428,
    /// <summary>
    /// Financial Rand
    /// </summary>
    [Description("Financial Rand")] ZAL = 991,
    /// <summary>
    /// Lithuanian Litas
    /// </summary>
    [Description("Lithuanian Litas")] LTL = 440,
    /// <summary>
    /// Luxembourg Convertible Franc
    /// </summary>
    [Description("Luxembourg Convertible Franc")] LUC = 989,
    /// <summary>
    /// Luxembourg Franc
    /// </summary>
    [Description("Luxembourg Franc")] LUF = 442,
    /// <summary>
    /// Luxembourg Financial Franc
    /// </summary>
    [Description("Luxembourg Financial Franc")] LUL = 988,
    /// <summary>
    /// Malagasy Franc
    /// </summary>
    [Description("Malagasy Franc")] MGF = 450,
    /// <summary>
    /// Mali Franc
    /// </summary>
    [Description("Mali Franc")] MLF = 466,
    /// <summary>
    /// Maltese Lira
    /// </summary>
    [Description("Maltese Lira")] MTL = 470,
    /// <summary>
    /// Ouguiya
    /// </summary>
    [Description("Ouguiya")] MRO = 478,
    /// <summary>
    /// Mozambique Escudo
    /// </summary>
    [Description("Mozambique Escudo")] MZE = 508,
    /// <summary>
    /// Netherlands Guilder
    /// </summary>
    [Description("Netherlands Guilder")] NLG = 528,
    /// <summary>
    /// Zloty
    /// </summary>
    [Description("Zloty")] PLZ = 616,
    /// <summary>
    /// Portuguese Escudo
    /// </summary>
    [Description("Portuguese Escudo")] PTE = 620,
    /// <summary>
    /// Leu A/52
    /// </summary>
    [Description("Leu A/52")] ROK = 642,
    /// <summary>
    /// Dobra
    /// </summary>
    [Description("Dobra")] STD = 678,
    /// <summary>
    /// Serbian Dinar
    /// </summary>
    [Description("Serbian Dinar")] CSD = 891,
    /// <summary>
    /// Slovak Koruna
    /// </summary>
    [Description("Slovak Koruna")] SKK = 703,
    /// <summary>
    /// Tolar
    /// </summary>
    [Description("Tolar")] SIT = 705,
    /// <summary>
    /// Rhodesian Dollar
    /// </summary>
    [Description("Rhodesian Dollar")] RHD = 716,
    /// <summary>
    /// Spanish Peseta
    /// </summary>
    [Description("Spanish Peseta")] ESA = 996,
    /// <summary>
    /// "A" Account (convertible Peseta Account)
    /// </summary>
    [Description("\"A\" Account (convertible Peseta Account)")] ESB = 995,
    /// <summary>
    /// Sudanese Dinar
    /// </summary>
    [Description("Sudanese Dinar")] SDD = 736,
    /// <summary>
    /// Surinam Guilder
    /// </summary>
    [Description("Surinam Guilder")] SRG = 740,
    /// <summary>
    /// Tajik Ruble
    /// </summary>
    [Description("Tajik Ruble")] TJR = 762,
    /// <summary>
    /// Timor Escudo
    /// </summary>
    [Description("Timor Escudo")] TPE = 626,
    /// <summary>
    /// Old Turkish Lira
    /// </summary>
    [Description("Old Turkish Lira")] TRL = 792,
    /// <summary>
    /// Turkmenistan Manat
    /// </summary>
    [Description("Turkmenistan Manat")] TMM = 795,
    /// <summary>
    /// Karbovanet
    /// </summary>
    [Description("Karbovanet")] UAK = 804,
    /// <summary>
    /// US Dollar (Same day)
    /// </summary>
    [Description("US Dollar (Same day)")] USS = 998,
    /// <summary>
    /// Bolivar
    /// </summary>
    [Description("Bolivar")] VEB = 862,
    /// <summary>
    /// Bolivar Fuerte
    /// </summary>
    [Description("Bolivar Fuerte")] VEF = 937,
    /// <summary>
    /// Yemeni Dinar
    /// </summary>
    [Description("Yemeni Dinar")] YDD = 720,
    /// <summary>
    /// New Yugoslavian Dinar
    /// </summary>
    [Description("New Yugoslavian Dinar")] YUD = 890,
    /// <summary>
    /// New Zaire
    /// </summary>
    [Description("New Zaire")] ZRN = 180,
    /// <summary>
    /// Zambian Kwacha
    /// </summary>
    [Description("Zambian Kwacha")] ZMK = 894,
    /// <summary>
    /// Zimbabwe Dollar (new)
    /// </summary>
    [Description("Zimbabwe Dollar (new)")] ZWN = 942,
    /// <summary>
    /// Zimbabwe Dollar
    /// </summary>
    [Description("Zimbabwe Dollar")] ZWR = 935,
}


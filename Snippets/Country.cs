using System.ComponentModel;

namespace CountryData;

public enum Country
{
    /// <summary>
    /// Unknown - Represent the 0 value enum
    /// </summary>
    Unknown = 0,
    /// <summary>
    /// Uzbekistan
    /// </summary>
    [Description("Uzbekistan")] UZ = 860,
    /// <summary>
    /// Austria
    /// </summary>
    [Description("Austria")] AT = 040,
    /// <summary>
    /// Sierra Leone
    /// </summary>
    [Description("Sierra Leone")] SL = 694,
    /// <summary>
    /// Cocos (Keeling) Islands
    /// </summary>
    [Description("Cocos (Keeling) Islands")] CC = 166,
    /// <summary>
    /// Mauritania
    /// </summary>
    [Description("Mauritania")] MR = 478,
    /// <summary>
    /// Israel
    /// </summary>
    [Description("Israel")] IL = 376,
    /// <summary>
    /// Moldova
    /// </summary>
    [Description("Moldova")] MD = 498,
    /// <summary>
    /// Fiji
    /// </summary>
    [Description("Fiji")] FJ = 242,
    /// <summary>
    /// Serbia
    /// </summary>
    [Description("Serbia")] RS = 688,
    /// <summary>
    /// Cameroon
    /// </summary>
    [Description("Cameroon")] CM = 120,
    /// <summary>
    /// Bahamas
    /// </summary>
    [Description("Bahamas")] BS = 044,
    /// <summary>
    /// Nauru
    /// </summary>
    [Description("Nauru")] NR = 520,
    /// <summary>
    /// Czechia
    /// </summary>
    [Description("Czechia")] CZ = 203,
    /// <summary>
    /// Egypt
    /// </summary>
    [Description("Egypt")] EG = 818,
    /// <summary>
    /// Myanmar
    /// </summary>
    [Description("Myanmar")] MM = 104,
    /// <summary>
    /// Netherlands
    /// </summary>
    [Description("Netherlands")] NL = 528,
    /// <summary>
    /// Uruguay
    /// </summary>
    [Description("Uruguay")] UY = 858,
    /// <summary>
    /// Northern Mariana Islands
    /// </summary>
    [Description("Northern Mariana Islands")] MP = 580,
    /// <summary>
    /// Central African Republic
    /// </summary>
    [Description("Central African Republic")] CF = 140,
    /// <summary>
    /// Saint Helena, Ascension and Tristan da Cunha
    /// </summary>
    [Description("Saint Helena, Ascension and Tristan da Cunha")] SH = 654,
    /// <summary>
    /// Equatorial Guinea
    /// </summary>
    [Description("Equatorial Guinea")] GQ = 226,
    /// <summary>
    /// Colombia
    /// </summary>
    [Description("Colombia")] CO = 170,
    /// <summary>
    /// Kyrgyzstan
    /// </summary>
    [Description("Kyrgyzstan")] KG = 417,
    /// <summary>
    /// Spain
    /// </summary>
    [Description("Spain")] ES = 724,
    /// <summary>
    /// Malawi
    /// </summary>
    [Description("Malawi")] MW = 454,
    /// <summary>
    /// Hungary
    /// </summary>
    [Description("Hungary")] HU = 348,
    /// <summary>
    /// Monaco
    /// </summary>
    [Description("Monaco")] MC = 492,
    /// <summary>
    /// Cape Verde
    /// </summary>
    [Description("Cape Verde")] CV = 132,
    /// <summary>
    /// South Africa
    /// </summary>
    [Description("South Africa")] ZA = 710,
    /// <summary>
    /// Denmark
    /// </summary>
    [Description("Denmark")] DK = 208,
    /// <summary>
    /// Guadeloupe
    /// </summary>
    [Description("Guadeloupe")] GP = 312,
    /// <summary>
    /// Ireland
    /// </summary>
    [Description("Ireland")] IE = 372,
    /// <summary>
    /// Malta
    /// </summary>
    [Description("Malta")] MT = 470,
    /// <summary>
    /// Wallis and Futuna
    /// </summary>
    [Description("Wallis and Futuna")] WF = 876,
    /// <summary>
    /// Suriname
    /// </summary>
    [Description("Suriname")] SR = 740,
    /// <summary>
    /// Vatican City
    /// </summary>
    [Description("Vatican City")] VA = 336,
    /// <summary>
    /// Mali
    /// </summary>
    [Description("Mali")] ML = 466,
    /// <summary>
    /// Tonga
    /// </summary>
    [Description("Tonga")] TO = 776,
    /// <summary>
    /// San Marino
    /// </summary>
    [Description("San Marino")] SM = 674,
    /// <summary>
    /// Saint Barthélemy
    /// </summary>
    [Description("Saint Barthélemy")] BL = 652,
    /// <summary>
    /// Gibraltar
    /// </summary>
    [Description("Gibraltar")] GI = 292,
    /// <summary>
    /// Canada
    /// </summary>
    [Description("Canada")] CA = 124,
    /// <summary>
    /// Benin
    /// </summary>
    [Description("Benin")] BJ = 204,
    /// <summary>
    /// Guam
    /// </summary>
    [Description("Guam")] GU = 316,
    /// <summary>
    /// North Korea
    /// </summary>
    [Description("North Korea")] KP = 408,
    /// <summary>
    /// Tuvalu
    /// </summary>
    [Description("Tuvalu")] TV = 798,
    /// <summary>
    /// Panama
    /// </summary>
    [Description("Panama")] PA = 591,
    /// <summary>
    /// Rwanda
    /// </summary>
    [Description("Rwanda")] RW = 646,
    /// <summary>
    /// Republic of the Congo
    /// </summary>
    [Description("Republic of the Congo")] CG = 178,
    /// <summary>
    /// Jamaica
    /// </summary>
    [Description("Jamaica")] JM = 388,
    /// <summary>
    /// Bahrain
    /// </summary>
    [Description("Bahrain")] BH = 048,
    /// <summary>
    /// Sint Maarten
    /// </summary>
    [Description("Sint Maarten")] SX = 534,
    /// <summary>
    /// Turks and Caicos Islands
    /// </summary>
    [Description("Turks and Caicos Islands")] TC = 796,
    /// <summary>
    /// Pakistan
    /// </summary>
    [Description("Pakistan")] PK = 586,
    /// <summary>
    /// Kazakhstan
    /// </summary>
    [Description("Kazakhstan")] KZ = 398,
    /// <summary>
    /// Laos
    /// </summary>
    [Description("Laos")] LA = 418,
    /// <summary>
    /// Trinidad and Tobago
    /// </summary>
    [Description("Trinidad and Tobago")] TT = 780,
    /// <summary>
    /// Montenegro
    /// </summary>
    [Description("Montenegro")] ME = 499,
    /// <summary>
    /// Niue
    /// </summary>
    [Description("Niue")] NU = 570,
    /// <summary>
    /// Liberia
    /// </summary>
    [Description("Liberia")] LR = 430,
    /// <summary>
    /// Grenada
    /// </summary>
    [Description("Grenada")] GD = 308,
    /// <summary>
    /// Papua New Guinea
    /// </summary>
    [Description("Papua New Guinea")] PG = 598,
    /// <summary>
    /// Chad
    /// </summary>
    [Description("Chad")] TD = 148,
    /// <summary>
    /// Chile
    /// </summary>
    [Description("Chile")] CL = 152,
    /// <summary>
    /// Puerto Rico
    /// </summary>
    [Description("Puerto Rico")] PR = 630,
    /// <summary>
    /// Saudi Arabia
    /// </summary>
    [Description("Saudi Arabia")] SA = 682,
    /// <summary>
    /// Norway
    /// </summary>
    [Description("Norway")] NO = 578,
    /// <summary>
    /// Gambia
    /// </summary>
    [Description("Gambia")] GM = 270,
    /// <summary>
    /// Philippines
    /// </summary>
    [Description("Philippines")] PH = 608,
    /// <summary>
    /// Isle of Man
    /// </summary>
    [Description("Isle of Man")] IM = 833,
    /// <summary>
    /// Portugal
    /// </summary>
    [Description("Portugal")] PT = 620,
    /// <summary>
    /// Honduras
    /// </summary>
    [Description("Honduras")] HN = 340,
    /// <summary>
    /// Cyprus
    /// </summary>
    [Description("Cyprus")] CY = 196,
    /// <summary>
    /// Anguilla
    /// </summary>
    [Description("Anguilla")] AI = 660,
    /// <summary>
    /// Heard Island and McDonald Islands
    /// </summary>
    [Description("Heard Island and McDonald Islands")] HM = 334,
    /// <summary>
    /// Togo
    /// </summary>
    [Description("Togo")] TG = 768,
    /// <summary>
    /// Lebanon
    /// </summary>
    [Description("Lebanon")] LB = 422,
    /// <summary>
    /// Morocco
    /// </summary>
    [Description("Morocco")] MA = 504,
    /// <summary>
    /// Estonia
    /// </summary>
    [Description("Estonia")] EE = 233,
    /// <summary>
    /// Faroe Islands
    /// </summary>
    [Description("Faroe Islands")] FO = 234,
    /// <summary>
    /// Argentina
    /// </summary>
    [Description("Argentina")] AR = 032,
    /// <summary>
    /// Gabon
    /// </summary>
    [Description("Gabon")] GA = 266,
    /// <summary>
    /// Namibia
    /// </summary>
    [Description("Namibia")] NA = 516,
    /// <summary>
    /// Vietnam
    /// </summary>
    [Description("Vietnam")] VN = 704,
    /// <summary>
    /// Greece
    /// </summary>
    [Description("Greece")] GR = 300,
    /// <summary>
    /// British Virgin Islands
    /// </summary>
    [Description("British Virgin Islands")] VG = 092,
    /// <summary>
    /// Mozambique
    /// </summary>
    [Description("Mozambique")] MZ = 508,
    /// <summary>
    /// Norfolk Island
    /// </summary>
    [Description("Norfolk Island")] NF = 574,
    /// <summary>
    /// South Georgia
    /// </summary>
    [Description("South Georgia")] GS = 239,
    /// <summary>
    /// Armenia
    /// </summary>
    [Description("Armenia")] AM = 051,
    /// <summary>
    /// Kenya
    /// </summary>
    [Description("Kenya")] KE = 404,
    /// <summary>
    /// Bhutan
    /// </summary>
    [Description("Bhutan")] BT = 064,
    /// <summary>
    /// United Arab Emirates
    /// </summary>
    [Description("United Arab Emirates")] AE = 784,
    /// <summary>
    /// Cook Islands
    /// </summary>
    [Description("Cook Islands")] CK = 184,
    /// <summary>
    /// Ethiopia
    /// </summary>
    [Description("Ethiopia")] ET = 231,
    /// <summary>
    /// Singapore
    /// </summary>
    [Description("Singapore")] SG = 702,
    /// <summary>
    /// Peru
    /// </summary>
    [Description("Peru")] PE = 604,
    /// <summary>
    /// Palestine
    /// </summary>
    [Description("Palestine")] PS = 275,
    /// <summary>
    /// Samoa
    /// </summary>
    [Description("Samoa")] WS = 882,
    /// <summary>
    /// South Sudan
    /// </summary>
    [Description("South Sudan")] SS = 728,
    /// <summary>
    /// Andorra
    /// </summary>
    [Description("Andorra")] AD = 020,
    /// <summary>
    /// Saint Martin
    /// </summary>
    [Description("Saint Martin")] MF = 663,
    /// <summary>
    /// Eswatini
    /// </summary>
    [Description("Eswatini")] SZ = 748,
    /// <summary>
    /// Tajikistan
    /// </summary>
    [Description("Tajikistan")] TJ = 762,
    /// <summary>
    /// Zambia
    /// </summary>
    [Description("Zambia")] ZM = 894,
    /// <summary>
    /// United States
    /// </summary>
    [Description("United States")] US = 840,
    /// <summary>
    /// Burundi
    /// </summary>
    [Description("Burundi")] BI = 108,
    /// <summary>
    /// Japan
    /// </summary>
    [Description("Japan")] JP = 392,
    /// <summary>
    /// Curaçao
    /// </summary>
    [Description("Curaçao")] CW = 531,
    /// <summary>
    /// Uganda
    /// </summary>
    [Description("Uganda")] UG = 800,
    /// <summary>
    /// Mongolia
    /// </summary>
    [Description("Mongolia")] MN = 496,
    /// <summary>
    /// Nigeria
    /// </summary>
    [Description("Nigeria")] NG = 566,
    /// <summary>
    /// Guatemala
    /// </summary>
    [Description("Guatemala")] GT = 320,
    /// <summary>
    /// Jersey
    /// </summary>
    [Description("Jersey")] JE = 832,
    /// <summary>
    /// Costa Rica
    /// </summary>
    [Description("Costa Rica")] CR = 188,
    /// <summary>
    /// Yemen
    /// </summary>
    [Description("Yemen")] YE = 887,
    /// <summary>
    /// Greenland
    /// </summary>
    [Description("Greenland")] GL = 304,
    /// <summary>
    /// Madagascar
    /// </summary>
    [Description("Madagascar")] MG = 450,
    /// <summary>
    /// Algeria
    /// </summary>
    [Description("Algeria")] DZ = 012,
    /// <summary>
    /// Belgium
    /// </summary>
    [Description("Belgium")] BE = 056,
    /// <summary>
    /// Sri Lanka
    /// </summary>
    [Description("Sri Lanka")] LK = 144,
    /// <summary>
    /// Finland
    /// </summary>
    [Description("Finland")] FI = 246,
    /// <summary>
    /// Bermuda
    /// </summary>
    [Description("Bermuda")] BM = 060,
    /// <summary>
    /// North Macedonia
    /// </summary>
    [Description("North Macedonia")] MK = 807,
    /// <summary>
    /// Saint Vincent and the Grenadines
    /// </summary>
    [Description("Saint Vincent and the Grenadines")] VC = 670,
    /// <summary>
    /// Niger
    /// </summary>
    [Description("Niger")] NE = 562,
    /// <summary>
    /// British Indian Ocean Territory
    /// </summary>
    [Description("British Indian Ocean Territory")] IO = 086,
    /// <summary>
    /// Latvia
    /// </summary>
    [Description("Latvia")] LV = 428,
    /// <summary>
    /// Nepal
    /// </summary>
    [Description("Nepal")] NP = 524,
    /// <summary>
    /// Ivory Coast
    /// </summary>
    [Description("Ivory Coast")] CI = 384,
    /// <summary>
    /// Liechtenstein
    /// </summary>
    [Description("Liechtenstein")] LI = 438,
    /// <summary>
    /// DR Congo
    /// </summary>
    [Description("DR Congo")] CD = 180,
    /// <summary>
    /// Belize
    /// </summary>
    [Description("Belize")] BZ = 084,
    /// <summary>
    /// Qatar
    /// </summary>
    [Description("Qatar")] QA = 634,
    /// <summary>
    /// Tokelau
    /// </summary>
    [Description("Tokelau")] TK = 772,
    /// <summary>
    /// Indonesia
    /// </summary>
    [Description("Indonesia")] ID = 360,
    /// <summary>
    /// French Polynesia
    /// </summary>
    [Description("French Polynesia")] PF = 258,
    /// <summary>
    /// Lesotho
    /// </summary>
    [Description("Lesotho")] LS = 426,
    /// <summary>
    /// Poland
    /// </summary>
    [Description("Poland")] PL = 616,
    /// <summary>
    /// Palau
    /// </summary>
    [Description("Palau")] PW = 585,
    /// <summary>
    /// Guernsey
    /// </summary>
    [Description("Guernsey")] GG = 831,
    /// <summary>
    /// Antigua and Barbuda
    /// </summary>
    [Description("Antigua and Barbuda")] AG = 028,
    /// <summary>
    /// Saint Pierre and Miquelon
    /// </summary>
    [Description("Saint Pierre and Miquelon")] PM = 666,
    /// <summary>
    /// Western Sahara
    /// </summary>
    [Description("Western Sahara")] EH = 732,
    /// <summary>
    /// Luxembourg
    /// </summary>
    [Description("Luxembourg")] LU = 442,
    /// <summary>
    /// Taiwan
    /// </summary>
    [Description("Taiwan")] TW = 158,
    /// <summary>
    /// Hong Kong
    /// </summary>
    [Description("Hong Kong")] HK = 344,
    /// <summary>
    /// Turkmenistan
    /// </summary>
    [Description("Turkmenistan")] TM = 795,
    /// <summary>
    /// Russia
    /// </summary>
    [Description("Russia")] RU = 643,
    /// <summary>
    /// Azerbaijan
    /// </summary>
    [Description("Azerbaijan")] AZ = 031,
    /// <summary>
    /// Ecuador
    /// </summary>
    [Description("Ecuador")] EC = 218,
    /// <summary>
    /// Cambodia
    /// </summary>
    [Description("Cambodia")] KH = 116,
    /// <summary>
    /// Mayotte
    /// </summary>
    [Description("Mayotte")] YT = 175,
    /// <summary>
    /// Botswana
    /// </summary>
    [Description("Botswana")] BW = 072,
    /// <summary>
    /// Croatia
    /// </summary>
    [Description("Croatia")] HR = 191,
    /// <summary>
    /// Saint Lucia
    /// </summary>
    [Description("Saint Lucia")] LC = 662,
    /// <summary>
    /// Paraguay
    /// </summary>
    [Description("Paraguay")] PY = 600,
    /// <summary>
    /// Bolivia
    /// </summary>
    [Description("Bolivia")] BO = 068,
    /// <summary>
    /// Maldives
    /// </summary>
    [Description("Maldives")] MV = 462,
    /// <summary>
    /// American Samoa
    /// </summary>
    [Description("American Samoa")] AS = 016,
    /// <summary>
    /// Iceland
    /// </summary>
    [Description("Iceland")] IS = 352,
    /// <summary>
    /// Slovakia
    /// </summary>
    [Description("Slovakia")] SK = 703,
    /// <summary>
    /// French Southern and Antarctic Lands
    /// </summary>
    [Description("French Southern and Antarctic Lands")] TF = 260,
    /// <summary>
    /// Brunei
    /// </summary>
    [Description("Brunei")] BN = 096,
    /// <summary>
    /// Saint Kitts and Nevis
    /// </summary>
    [Description("Saint Kitts and Nevis")] KN = 659,
    /// <summary>
    /// Afghanistan
    /// </summary>
    [Description("Afghanistan")] AF = 004,
    /// <summary>
    /// Ghana
    /// </summary>
    [Description("Ghana")] GH = 288,
    /// <summary>
    /// Kuwait
    /// </summary>
    [Description("Kuwait")] KW = 414,
    /// <summary>
    /// Svalbard and Jan Mayen
    /// </summary>
    [Description("Svalbard and Jan Mayen")] SJ = 744,
    /// <summary>
    /// Bangladesh
    /// </summary>
    [Description("Bangladesh")] BD = 050,
    /// <summary>
    /// Guyana
    /// </summary>
    [Description("Guyana")] GY = 328,
    /// <summary>
    /// Kiribati
    /// </summary>
    [Description("Kiribati")] KI = 296,
    /// <summary>
    /// Barbados
    /// </summary>
    [Description("Barbados")] BB = 052,
    /// <summary>
    /// Albania
    /// </summary>
    [Description("Albania")] AL = 008,
    /// <summary>
    /// Pitcairn Islands
    /// </summary>
    [Description("Pitcairn Islands")] PN = 612,
    /// <summary>
    /// Burkina Faso
    /// </summary>
    [Description("Burkina Faso")] BF = 854,
    /// <summary>
    /// Macau
    /// </summary>
    [Description("Macau")] MO = 446,
    /// <summary>
    /// Seychelles
    /// </summary>
    [Description("Seychelles")] SC = 690,
    /// <summary>
    /// Switzerland
    /// </summary>
    [Description("Switzerland")] CH = 756,
    /// <summary>
    /// South Korea
    /// </summary>
    [Description("South Korea")] KR = 410,
    /// <summary>
    /// United States Virgin Islands
    /// </summary>
    [Description("United States Virgin Islands")] VI = 850,
    /// <summary>
    /// Tunisia
    /// </summary>
    [Description("Tunisia")] TN = 788,
    /// <summary>
    /// Bouvet Island
    /// </summary>
    [Description("Bouvet Island")] BV = 074,
    /// <summary>
    /// Iran
    /// </summary>
    [Description("Iran")] IR = 364,
    /// <summary>
    /// Jordan
    /// </summary>
    [Description("Jordan")] JO = 400,
    /// <summary>
    /// Réunion
    /// </summary>
    [Description("Réunion")] RE = 638,
    /// <summary>
    /// Turkey
    /// </summary>
    [Description("Turkey")] TR = 792,
    /// <summary>
    /// Tanzania
    /// </summary>
    [Description("Tanzania")] TZ = 834,
    /// <summary>
    /// Ukraine
    /// </summary>
    [Description("Ukraine")] UA = 804,
    /// <summary>
    /// Mauritius
    /// </summary>
    [Description("Mauritius")] MU = 480,
    /// <summary>
    /// Somalia
    /// </summary>
    [Description("Somalia")] SO = 706,
    /// <summary>
    /// Guinea
    /// </summary>
    [Description("Guinea")] GN = 324,
    /// <summary>
    /// French Guiana
    /// </summary>
    [Description("French Guiana")] GF = 254,
    /// <summary>
    /// Marshall Islands
    /// </summary>
    [Description("Marshall Islands")] MH = 584,
    /// <summary>
    /// Solomon Islands
    /// </summary>
    [Description("Solomon Islands")] SB = 090,
    /// <summary>
    /// United States Minor Outlying Islands
    /// </summary>
    [Description("United States Minor Outlying Islands")] UM = 581,
    /// <summary>
    /// Lithuania
    /// </summary>
    [Description("Lithuania")] LT = 440,
    /// <summary>
    /// Slovenia
    /// </summary>
    [Description("Slovenia")] SI = 705,
    /// <summary>
    /// Nicaragua
    /// </summary>
    [Description("Nicaragua")] NI = 558,
    /// <summary>
    /// Dominican Republic
    /// </summary>
    [Description("Dominican Republic")] DO = 214,
    /// <summary>
    /// Iraq
    /// </summary>
    [Description("Iraq")] IQ = 368,
    /// <summary>
    /// El Salvador
    /// </summary>
    [Description("El Salvador")] SV = 222,
    /// <summary>
    /// Venezuela
    /// </summary>
    [Description("Venezuela")] VE = 862,
    /// <summary>
    /// Zimbabwe
    /// </summary>
    [Description("Zimbabwe")] ZW = 716,
    /// <summary>
    /// Sweden
    /// </summary>
    [Description("Sweden")] SE = 752,
    /// <summary>
    /// Thailand
    /// </summary>
    [Description("Thailand")] TH = 764,
    /// <summary>
    /// Timor-Leste
    /// </summary>
    [Description("Timor-Leste")] TL = 626,
    /// <summary>
    /// Bosnia and Herzegovina
    /// </summary>
    [Description("Bosnia and Herzegovina")] BA = 070,
    /// <summary>
    /// Guinea-Bissau
    /// </summary>
    [Description("Guinea-Bissau")] GW = 624,
    /// <summary>
    /// Montserrat
    /// </summary>
    [Description("Montserrat")] MS = 500,
    /// <summary>
    /// Dominica
    /// </summary>
    [Description("Dominica")] DM = 212,
    /// <summary>
    /// Falkland Islands
    /// </summary>
    [Description("Falkland Islands")] FK = 238,
    /// <summary>
    /// Caribbean Netherlands
    /// </summary>
    [Description("Caribbean Netherlands")] BQ = 535,
    /// <summary>
    /// Djibouti
    /// </summary>
    [Description("Djibouti")] DJ = 262,
    /// <summary>
    /// Antarctica
    /// </summary>
    [Description("Antarctica")] AQ = 010,
    /// <summary>
    /// Haiti
    /// </summary>
    [Description("Haiti")] HT = 332,
    /// <summary>
    /// Comoros
    /// </summary>
    [Description("Comoros")] KM = 174,
    /// <summary>
    /// Italy
    /// </summary>
    [Description("Italy")] IT = 380,
    /// <summary>
    /// Belarus
    /// </summary>
    [Description("Belarus")] BY = 112,
    /// <summary>
    /// Cayman Islands
    /// </summary>
    [Description("Cayman Islands")] KY = 136,
    /// <summary>
    /// France
    /// </summary>
    [Description("France")] FR = 250,
    /// <summary>
    /// Senegal
    /// </summary>
    [Description("Senegal")] SN = 686,
    /// <summary>
    /// China
    /// </summary>
    [Description("China")] CN = 156,
    /// <summary>
    /// Sudan
    /// </summary>
    [Description("Sudan")] SD = 729,
    /// <summary>
    /// Oman
    /// </summary>
    [Description("Oman")] OM = 512,
    /// <summary>
    /// United Kingdom
    /// </summary>
    [Description("United Kingdom")] GB = 826,
    /// <summary>
    /// Mexico
    /// </summary>
    [Description("Mexico")] MX = 484,
    /// <summary>
    /// Australia
    /// </summary>
    [Description("Australia")] AU = 036,
    /// <summary>
    /// Cuba
    /// </summary>
    [Description("Cuba")] CU = 192,
    /// <summary>
    /// Eritrea
    /// </summary>
    [Description("Eritrea")] ER = 232,
    /// <summary>
    /// Bulgaria
    /// </summary>
    [Description("Bulgaria")] BG = 100,
    /// <summary>
    /// Romania
    /// </summary>
    [Description("Romania")] RO = 642,
    /// <summary>
    /// Micronesia
    /// </summary>
    [Description("Micronesia")] FM = 583,
    /// <summary>
    /// Vanuatu
    /// </summary>
    [Description("Vanuatu")] VU = 548,
    /// <summary>
    /// Syria
    /// </summary>
    [Description("Syria")] SY = 760,
    /// <summary>
    /// São Tomé and Príncipe
    /// </summary>
    [Description("São Tomé and Príncipe")] ST = 678,
    /// <summary>
    /// Germany
    /// </summary>
    [Description("Germany")] DE = 276,
    /// <summary>
    /// New Zealand
    /// </summary>
    [Description("New Zealand")] NZ = 554,
    /// <summary>
    /// Angola
    /// </summary>
    [Description("Angola")] AO = 024,
    /// <summary>
    /// Christmas Island
    /// </summary>
    [Description("Christmas Island")] CX = 162,
    /// <summary>
    /// Aruba
    /// </summary>
    [Description("Aruba")] AW = 533,
    /// <summary>
    /// India
    /// </summary>
    [Description("India")] IN = 356,
    /// <summary>
    /// Malaysia
    /// </summary>
    [Description("Malaysia")] MY = 458,
    /// <summary>
    /// Georgia
    /// </summary>
    [Description("Georgia")] GE = 268,
    /// <summary>
    /// New Caledonia
    /// </summary>
    [Description("New Caledonia")] NC = 540,
    /// <summary>
    /// Libya
    /// </summary>
    [Description("Libya")] LY = 434,
    /// <summary>
    /// Åland Islands
    /// </summary>
    [Description("Åland Islands")] AX = 248,
    /// <summary>
    /// Martinique
    /// </summary>
    [Description("Martinique")] MQ = 474,
    /// <summary>
    /// Brazil
    /// </summary>
    [Description("Brazil")] BR = 076,
}


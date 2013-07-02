﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityCore_Manager.Database.Enums
{
    public enum Faction
    {
            
            //PLAYERHuman = 1,
            //PLAYEROrc = 2,
            //PLAYERDwarf = 3,
            //PLAYERNightElf = 4,
            //PLAYERUndead = 5,
            //PLAYERTauren = 6,
            //Creature = 7,
            //Escortee = 10,
            //Stormwind = 11,
            //Stormwind2 = 12,
            //Monster = 14,
            //Creature2 = 15,
            //Monster2 = 16,
            //DefiasBrotherhood = 17,
            //Murloc = 18,
            //GnollRedridge = 19,
            //GnollRiverpaw = 20,
            //UndeadScourge = 21,
            //BeastSpider = 22,
            //GnomereganExiles = 23,
            //Worgen = 24,
            //Kobold = 25,
            //Kobold2 = 26,
            //DefiasBrotherhood2 = 27,
            //TrollBloodscalp = 28,
            //Orgrimmar = 29,
            //TrollSkullsplitter = 30,
            //Prey = 31,
            //BeastWolf4 = 32,
            //Escortee = 33,
            //DefiasBrotherhood3 = 34,
            //Friendly = 35,
            //Trogg = 36,
            //TrollFrostmane = 37,
            //BeastWolf2 = 38,
            //GnollShadowhide = 39,
            //OrcBlackrock = 40,
            //Villian = 41,
            //Victim = 42,
            //Villian = 43,
            //BeastBear = 44,
            //Ogre = 45,
            //KurzensMercenaries = 46,
            //VentureCompany = 47,
            //BeastRaptor = 48,
            //Basilisk = 49,
            //DragonflightGreen = 50,
            //LostOnes = 51,
            //GizlocksDummy = 52,
            //HumanNightWatch = 53,
            //DarkIronDwarves = 54,
            //Ironforge = 55,
            //HumanNightWatch = 56,
            //Ironforge = 57,
            //Creature3 = 58,
            //Trogg = 59,
            //DragonflightRed = 60,
            //GnollMosshide = 61,
            //OrcDragonmaw = 62,
            //GnomeLeper = 63,
            //GnomereganExiles = 64,
            //Orgrimmar = 65,
            //Leopard = 66,
            //ScarletCrusade = 67,
            //Undercity = 68,
            //Ratchet = 69,
            //GnollRothide = 70,
            //Undercity = 71,
            //BeastGorilla = 72,
            //BeastCarrionBird = 73,
            //Naga = 74,
            //Dalaran = 76,
            //ForlornSpirit = 77,
            //Darkhowl = 78,
            //Darnassus = 79,
            //Darnassus = 80,
            //Grell = 81,
            //Furbolg = 82,
            //HordeGeneric = 83,
            //AllianceGeneric = 84,
            //Orgrimmar = 85,
            //GizlocksCharm = 86,
            //Syndicate = 87,
            //HillsbradMilitia = 88,
            //ScarletCrusade = 89,
            //Demon = 90,
            //Elemental = 91,
            //Spirit = 92,
            //Monster3 = 93,
            //Treasure = 94,
            //GnollMudsnout = 95,
            //HIllsbradSouthshoreMayor = 96,
            //Syndicate = 97,
            //Undercity = 98,
            //Victim = 99,
            //Treasure = 100,
            //Treasure = 101,
            //Treasure = 102,
            //DragonflightBlack = 103,
            //ThunderBluff = 104,
            //ThunderBluff = 105,
            //HordeGeneric = 106,
            //TrollFrostmane = 107,
            //Syndicate = 108,
            //QuilboarRazormane2 = 109,
            //QuilboarRazormane2 = 110,
            //QuilboarBristleback = 111,
            //QuilboarBristleback = 112,
            //Escortee = 113,
            //Treasure = 114,
            //PLAYERGnome = 115,
            //PLAYERTroll = 116,
            //Undercity = 118,
            //BloodsailBuccaneers = 119,
            //BootyBay = 120,
            //BootyBay = 121,
            //Ironforge = 122,
            //Stormwind3 = 123,
            //Darnassus = 124,
            //Orgrimmar = 125,
            //DarkspearTrolls = 126,
            //Villian = 127,
            //Blackfathom = 128,
            //Makrura = 129,
            //CentaurKolkar = 130,
            //CentaurGalak = 131,
            //GelkisClanCentaur = 132,
            //MagramClanCentaur = 133,
            //Maraudine = 134,
            //Monster4 = 148,
            //Theramore = 149,
            //Theramore = 150,
            //Theramore = 151,
            //QuilboarRazorfen = 152,
            //QuilboarRazorfen = 153,
            //QuilboarDeathshead = 154,
            //Enemy = 168,
            //Ambient = 188,
            //Creature4 = 189,
            //Ambient = 190,
            //NethergardeCaravan = 208,
            //NethergardeCaravan = 209,
            //AllianceGeneric = 210,
            //SouthseaFreebooters = 230,
            //Escortee = 231,
            //Escortee = 232,
            //UndeadScourge = 233,
            //Escortee = 250,
            //WailingCaverns = 270,
            //Escortee = 290,
            //Silithid = 310,
            //Silithid = 311,
            //BeastSpider = 312,
            //WailingCaverns = 330,
            //Blackfathom = 350,
            //ArmiesofCThun = 370,
            //SilvermoonRemnant = 371,
            //BootyBay = 390,
            //Basilisk = 410,
            //BeastBat = 411,
            //TheDefilers = 412,
            //Scorpid = 413,
            //TimbermawHold = 414,
            //Titan = 415,
            //Titan = 416,
            //TaskmasterFizzule = 430,
            //WailingCaverns = 450,
            //Titan = 470,
            //Ravenholdt = 471,
            //Syndicate = 472,
            //Ravenholdt = 473,
            //Gadgetzan = 474,
            //Gadgetzan = 475,
            //GnomereganBug = 494,
            //Escortee = 495,
            //Harpy = 514,
            //AllianceGeneric = 534,
            //BurningBlade = 554,
            //ShadowsilkPoacher = 574,
            //SearingSpider = 575,
            //Trogg = 594,
            //Victim = 614,
            //Monster5 = 634,
            //CenarionCircle = 635,
            //TimbermawHold = 636,
            //Ratchet = 637,
            //TrollWitherbark = 654,
            //CentaurKolkar = 655,
            //DarkIronDwarves = 674,
            //AllianceGeneric = 694,
            //HydraxianWaterlords = 695,
            //HordeGeneric = 714,
            //DarkIronDwarves = 734,
            //GoblinDarkIronBarPatron = 735,
            //GoblinDarkIronBarPatron = 736,
            //DarkIronDwarves = 754,
            //Escortee = 774,
            //Escortee = 775,
            //BroodofNozdormu = 776,
            //MightofKalimdor = 777,
            //Giant = 778,
            //ArgentDawn = 794,
            //TrollVilebranch = 795,
            //ArgentDawn = 814,
            //Elemental = 834,
            //Everlook = 854,
            //Everlook = 855,
            //WintersaberTrainers = 874,
            //GnomereganExiles = 875,
            //DarkspearTrolls = 876,
            //DarkspearTrolls = 877,
            //Theramore = 894,
            //TrainingDummy = 914,
            //FurbolgUncorrupted = 934,
            //Demon = 954,
            //UndeadScourge = 974,
            //CenarionCircle = 994,
            //ThunderBluff = 995,
            //CenarionCircle = 996,
            //ShatterspearTrolls = 1014,
            //ShatterspearTrolls = 1015,
            //HordeGeneric = 1034,
            //AllianceGeneric = 1054,
            //AllianceGeneric = 1055,
            //Orgrimmar = 1074,
            //Theramore = 1075,
            //Darnassus = 1076,
            //Theramore = 1077,
            //Stormwind4 = 1078,
            //Friendly = 1080,
            //Elemental = 1081,
            //BeastBoar = 1094,
            //TrainingDummy = 1095,
            //Theramore = 1096,
            //Darnassus = 1097,
            //DragonflightBlackBait = 1114,
            //Undercity = 1134,
            //Undercity = 1154,
            //Orgrimmar = 1174,
            //BattlegroundNeutral = 1194,
            //FrostwolfClan = 1214,
            //FrostwolfClan = 1215,
            //StormpikeGuard = 1216,
            //StormpikeGuard = 1217,
            //SulfuronFirelords = 1234,
            //SulfuronFirelords = 1235,
            //SulfuronFirelords = 1236,
            //CenarionCircle = 1254,
            //Creature5 = 1274,
            //Creature6 = 1275,
            //Gizlock = 1294,
            //HordeGeneric = 1314,
            //AllianceGeneric = 1315,
            //StormpikeGuard = 1334,
            //FrostwolfClan = 1335,
            //Shendralar = 1354,
            //Shendralar = 1355,
            //OgreCaptainKromcrush = 1374,
            //Treasure = 1375,
            //DragonflightBlack = 1394,
            //SilithidAttackers = 1395,
            //SpiritGuideAlliance = 1414,
            //SpiritGuideHorde = 1415,
            //Jaedenar = 1434,
            //Victim = 1454,
            //ThoriumBrotherhood = 1474,
            //ThoriumBrotherhood = 1475,
            //HordeGeneric = 1494,
            //HordeGeneric = 1495,
            //HordeGeneric = 1496,
            //SilverwingSentinels = 1514,
            //WarsongOutriders = 1515,
            //StormpikeGuard = 1534,
            //FrostwolfClan = 1554,
            //DarkmoonFaire = 1555,
            //ZandalarTribe = 1574,
            //Stormwind5 = 1575,
            //SilvermoonRemnant = 1576,
            //TheLeagueofArathor = 1577,
            //Darnassus = 1594,
            //Orgrimmar = 1595,
            //StormpikeGuard = 1596,
            //FrostwolfClan = 1597,
            //TheDefilers = 1598,
            //TheLeagueofArathor = 1599,
            //Darnassus = 1600,
            //BroodofNozdormu = 1601,
            //SilvermoonCity = 1602,
            //SilvermoonCity = 1603,
            //SilvermoonCity = 1604,
            //DragonflightBronze = 1605,
            //Creature7 = 1606,
            //Creature8 = 1607,
            //CenarionCircle = 1608,
            //PLAYERBloodElf = 1610,
            //Ironforge = 1611,
            //Orgrimmar = 1612,
            //MightofKalimdor = 1613,
            //Monster6 = 1614,
            //SteamwheedleCartel = 1615,
            //RCObjects = 1616,
            //RCEnemies = 1617,
            //Ironforge = 1618,
            //Orgrimmar = 1619,
            //Enemy = 1620,
            //Blue = 1621,
            //Red = 1622,
            //Tranquillien = 1623,
            //ArgentDawn = 1624,
            //ArgentDawn = 1625,
            //UndeadScourge = 1626,
            //Farstriders = 1627,
            //Tranquillien = 1628,
            //PLAYERDraenei = 1629,
            //ScourgeInvaders = 1630,
            //ScourgeInvaders = 1634,
            //SteamwheedleCartel = 1635,
            //Farstriders = 1636,
            //Farstriders = 1637,
            //Exodar = 1638,
            //Exodar = 1639,
            //Exodar = 1640,
            //WarsongOutriders = 1641,
            //SilverwingSentinels = 1642,
            //TrollForest = 1643,
            //TheSonsofLothar = 1644,
            //TheSonsofLothar = 1645,
            //Exodar = 1646,
            //Exodar = 1647,
            //TheSonsofLothar = 1648,
            //TheSonsofLothar = 1649,
            //TheMaghar = 1650,
            //TheMaghar = 1651,
            //TheMaghar = 1652,
            //TheMaghar = 1653,
            //Exodar = 1654,
            //Exodar = 1655,
            //SilvermoonCity = 1656,
            //SilvermoonCity = 1657,
            //SilvermoonCity = 1658,
            //CenarionExpedition = 1659,
            //CenarionExpedition = 1660,
            //CenarionExpedition = 1661,
            //FelOrc = 1662,
            //FelOrcGhost = 1663,
            //SonsofLotharGhosts = 1664,
            //None = 1665,
            //HonorHold = 1666,
            //HonorHold = 1667,
            //Thrallmar = 1668,
            //Thrallmar = 1669,
            //Thrallmar = 1670,
            //HonorHold = 1671,
            //TestFaction1 = 1672,
            //ToWoWFlag = 1673,
            //TestFaction4 = 1674,
            //TestFaction3 = 1675,
            //ToWoWFlagTriggerHordeDND = 1676,
            //ToWoWFlagTriggerAllianceDND = 1677,
            //Ethereum = 1678,
            //Broken = 1679,
            //Elemental = 1680,
            //EarthElemental = 1681,
            //FightingRobots = 1682,
            //ActorGood = 1683,
            //ActorEvil = 1684,
            //StillpineFurbolg = 1685,
            //StillpineFurbolg = 1686,
            //CrazedOwlkin = 1687,
            //ChessAlliance = 1688,
            //ChessHorde = 1689,
            //ChessAlliance = 1690,
            //ChessHorde = 1691,
            //MonsterSpar = 1692,
            //MonsterSparBuddy = 1693,
            //Exodar = 1694,
            //SilvermoonCity = 1695,
            //TheVioletEye = 1696,
            //FelOrc = 1697,
            //Exodar = 1698,
            //Exodar = 1699,
            //Exodar = 1700,
            //Sunhawks = 1701,
            //Sunhawks = 1702,
            //TrainingDummy = 1703,
            //FelOrc = 1704,
            //FelOrc = 1705,
            //FungalGiant = 1706,
            //Sporeggar = 1707,
            //Sporeggar = 1708,
            //Sporeggar = 1709,
            //CenarionExpedition = 1710,
            //MonsterPredator = 1711,
            //MonsterPrey = 1712,
            //MonsterPrey = 1713,
            //Sunhawks = 1714,
            //VoidAnomaly = 1715,
            //HyjalDefenders = 1716,
            //HyjalDefenders = 1717,
            //HyjalDefenders = 1718,
            //HyjalDefenders = 1719,
            //HyjalInvaders = 1720,
            //Kurenai = 1721,
            //Kurenai = 1722,
            //Kurenai = 1723,
            //Kurenai = 1724,
            //EarthenRing = 1725,
            //EarthenRing = 1726,
            //EarthenRing = 1727,
            //CenarionExpedition = 1728,
            //Thrallmar = 1729,
            //TheConsortium = 1730,
            //TheConsortium = 1731,
            //AllianceGeneric = 1732,
            //AllianceGeneric = 1733,
            //HordeGeneric = 1734,
            //HordeGeneric = 1735,
            //MonsterSparBuddy = 1736,
            //HonorHold = 1737,
            //Arakkoa = 1738,
            //ZangarmarshBannerAlliance = 1739,
            //ZangarmarshBannerHorde = 1740,
            //TheShatar = 1741,
            //ZangarmarshBannerNeutral = 1742,
            //TheAldor = 1743,
            //TheScryers = 1744,
            //SilvermoonCity = 1745,
            //TheScryers = 1746,
            //CavernsofTimeThrall = 1747,
            //CavernsofTimeDurnholde = 1748,
            //CavernsofTimeSouthshoreGuards = 1749,
            //ShadowCouncilCovert = 1750,
            //Monster7 = 1751,
            //DarkPortalAttackerLegion = 1752,
            //DarkPortalAttackerLegion = 1753,
            //DarkPortalAttackerLegion = 1754,
            //DarkPortalDefenderAlliance = 1755,
            //DarkPortalDefenderAlliance = 1756,
            //DarkPortalDefenderAlliance = 1757,
            //DarkPortalDefenderHorde = 1758,
            //DarkPortalDefenderHorde = 1759,
            //DarkPortalDefenderHorde = 1760,
            //InciterTrigger = 1761,
            //InciterTrigger2 = 1762,
            //InciterTrigger3 = 1763,
            //InciterTrigger4 = 1764,
            //InciterTrigger5 = 1765,
            //ArgentDawn = 1766,
            //ArgentDawn = 1767,
            //Demon = 1768,
            //Demon = 1769,
            //ActorGood = 1770,
            //ActorEvil = 1771,
            //ManaCreature = 1772,
            //KhadgarsServant = 1773,
            //Friendly = 1774,
            //TheShatar = 1775,
            //TheAldor = 1776,
            //TheAldor = 1777,
            //TheScaleoftheSands = 1778,
            //KeepersofTime = 1779,
            //BladespireClan = 1780,
            //BloodmaulClan = 1781,
            //BladespireClan = 1782,
            //BloodmaulClan = 1783,
            //BladespireClan = 1784,
            //BloodmaulClan = 1785,
            //Demon = 1786,
            //Monster8 = 1787,
            //TheConsortium = 1788,
            //Sunhawks = 1789,
            //BladespireClan = 1790,
            //BloodmaulClan = 1791,
            //FelOrc = 1792,
            //Sunhawks = 1793,
            //Protectorate = 1794,
            //Protectorate = 1795,
            //Ethereum = 1796,
            //Protectorate = 1797,
            //ArcaneAnnihilatorDNR = 1798,
            //EthereumSparbuddy = 1799,
            //Ethereum = 1800,
            //Horde = 1801,
            //Alliance = 1802,
            //Ambient = 1803,
            //Ambient = 1804,
            //TheAldor = 1805,
            //Friendly = 1806,
            //Protectorate = 1807,
            //KirinVarBelmara = 1808,
            //KirinVarCohlien = 1809,
            //KirinVarDathric = 1810,
            //KirinVarLuminrath = 1811,
            //Friendly = 1812,
            //ServantofIllidan = 1813,
            //MonsterSparBuddy = 1814,
            //BeastWolf3 = 1815,
            //Friendly = 1816,
            //LowerCity = 1818,
            //AllianceGeneric = 1819,
            //AshtongueDeathsworn = 1820,
            //SpiritsofShadowmoon1 = 1821,
            //SpiritsofShadowmoon2 = 1822,
            //Ethereum = 1823,
            //Netherwing = 1824,
            //Demon = 1825,
            //ServantofIllidan = 1826,
            //Wyrmcult = 1827,
            //Treant = 1828,
            //LeotherasDemonI = 1829,
            //LeotherasDemonII = 1830,
            //LeotherasDemonIII = 1831,
            //LeotherasDemonIV = 1832,
            //LeotherasDemonV = 1833,
            //Azaloth = 1834,
            //HordeGeneric = 1835,
            //TheConsortium = 1836,
            //Sporeggar = 1837,
            //TheScryers = 1838,
            //RockFlayer = 1839,
            //FlayerHunter = 1840,
            //ShadowmoonShade = 1841,
            //LegionCommunicator = 1842,
            //ServantofIllidan = 1843,
            //TheAldor = 1844,
            //TheScryers = 1845,
            //RavenswoodAncients = 1846,
            //MonsterSpar = 1847,
            //MonsterSparBuddy = 1848,
            //ServantofIllidan = 1849,
            //Netherwing = 1850,
            //LowerCity = 1851,
            //ChessFriendlytoAllChess = 1852,
            //ServantofIllidan = 1853,
            //TheAldor = 1854,
            //TheScryers = 1855,
            //ShatariSkyguard = 1856,
            //Friendly = 1857,
            //AshtongueDeathsworn = 1858,
            //Maiev = 1859,
            //SkettisShadowyArakkoa = 1860,
            //SkettisArakkoa = 1862,
            //OrcDragonmaw = 1863,
            //DragonmawEnemy = 1864,
            //OrcDragonmaw = 1865,
            //AshtongueDeathsworn = 1866,
            //Maiev = 1867,
            //MonsterSparBuddy = 1868,
            //Arakkoa = 1869,
            //ShatariSkyguard = 1870,
            //SkettisArakkoa = 1871,
            //Ogrila = 1872,
            //RockFlayer = 1873,
            //Ogrila = 1874,
            //TheAldor = 1875,
            //TheScryers = 1876,
            //OrcDragonmaw = 1877,
            //Frenzy = 1878,
            //SkyguardEnemy = 1879,
            //OrcDragonmaw = 1880,
            //SkettisArakkoa = 1881,
            //ServantofIllidan = 1882,
            //TheramoreDeserter = 1883,
            //Tuskarr = 1884,
            //Vrykul = 1885,
            //Creature9 = 1886,
            //Creature10 = 1887,
            //NorthseaPirates = 1888,
            //UNUSED = 1889,
            //TrollAmani = 1890,
            //ValianceExpedition = 1891,
            //ValianceExpedition = 1892,
            //ValianceExpedition = 1893,
            //Vrykul = 1894,
            //Vrykul = 1895,
            //DarkmoonFaire = 1896,
            //TheHandofVengeance = 1897,
            //ValianceExpedition = 1898,
            //ValianceExpedition = 1899,
            //TheHandofVengeance = 1900,
            //HordeExpedition = 1901,
            //ActorEvil = 1902,
            //ActorEvil = 1904,
            //TamedPlaguehound = 1905,
            //SpottedGryphon = 1906,
            //TestFaction1 = 1907,
            //TestFaction1 = 1908,
            //BeastRaptor = 1909,
            //VrykulAncientSpirit1 = 1910,
            //VrykulAncientSiprit2 = 1911,
            //VrykulAncientSiprit3 = 1912,
            //CTFFlagAlliance = 1913,
            //Vrykul = 1914,
            //Test = 1915,
            //Maiev = 1916,
            //Creature11 = 1917,
            //HordeExpedition = 1918,
            //VrykulGladiator = 1919,
            //ValgardeCombatant = 1920,
            //TheTaunka = 1921,
            //TheTaunka = 1922,
            //TheTaunka = 1923,
            //MonsterZoneForceReaction1 = 1924,
            //Monster9 = 1925,
            //ExplorersLeague = 1926,
            //ExplorersLeague = 1927,
            //TheHandofVengeance = 1928,
            //TheHandofVengeance = 1929,
            //RamRacingPowerupDND = 1930,
            //RamRacingTrapDND = 1931,
            //Elemental = 1932,
            //Friendly = 1933,
            //ActorGood = 1934,
            //ActorGood = 1935,
            //CraigsSquirrels = 1936,
            //CraigsSquirrels = 1937,
            //CraigsSquirrels = 1938,
            //CraigsSquirrels = 1939,
            //CraigsSquirrels = 1940,
            //CraigsSquirrels = 1941,
            //CraigsSquirrels = 1942,
            //CraigsSquirrels = 1943,
            //CraigsSquirrels = 1944,
            //CraigsSquirrels = 1945,
            //CraigsSquirrels = 1947,
            //Blue = 1948,
            //TheKaluak = 1949,
            //TheKaluak = 1950,
            //Darnassus = 1951,
            //HolidayWaterBarrel = 1952,
            //MonsterPredator = 1953,
            //IronDwarves = 1954,
            //IronDwarves = 1955,
            //ShatteredSunOffensive = 1956,
            //ShatteredSunOffensive = 1957,
            //ActorEvil = 1958,
            //ActorEvil = 1959,
            //ShatteredSunOffensive = 1960,
            //FightingVanityPet = 1961,
            //UndeadScourge = 1962,
            //Demon = 1963,
            //UndeadScourge = 1964,
            //MonsterSpar = 1965,
            //Murloc = 1966,
            //ShatteredSunOffensive = 1967,
            //MurlocWinterfin = 1968,
            //Murloc = 1969,
            //Monster10 = 1970,
            //FriendlyForceReaction = 1971,
            //ObjectForceReaction = 1972,
            //ValianceExpedition = 1973,
            //ValianceExpedition = 1974,
            //UndeadScourge = 1975,
            //ValianceExpedition = 1976,
            //ValianceExpedition = 1977,
            //WarsongOffensive = 1978,
            //WarsongOffensive = 1979,
            //WarsongOffensive = 1980,
            //WarsongOffensive = 1981,
            //UndeadScourge = 1982,
            //MonsterSpar = 1983,
            //MonsterSparBuddy = 1984,
            //Monster11 = 1985,
            //Escortee = 1986,
            //CenarionExpedition = 1987,
            //UndeadScourge = 1988,
            //Poacher = 1989,
            //Ambient = 1990,
            //UndeadScourge = 1991,
            //Monster12 = 1992,
            //MonsterSpar = 1993,
            //MonsterSparBuddy = 1994,
            //CTFFlagAlliance = 1995,
            //CTFFlagAlliance = 1997,
            //HolidayMonster = 1998,
            //MonsterPrey = 1999,
            //MonsterPrey = 2000,
            //FurbolgRedfang = 2001,
            //FurbolgFrostpaw = 2003,
            //ValianceExpedition = 2004,
            //UndeadScourge = 2005,
            //KirinTor = 2006,
            //KirinTor = 2007,
            //KirinTor = 2008,
            //KirinTor = 2009,
            //TheWyrmrestAccord = 2010,
            //TheWyrmrestAccord = 2011,
            //TheWyrmrestAccord = 2012,
            //TheWyrmrestAccord = 2013,
            //AzjolNerub = 2014,
            //AzjolNerub = 2016,
            //AzjolNerub = 2017,
            //UndeadScourge = 2018,
            //TheTaunka = 2019,
            //WarsongOffensive = 2020,
            //REUSE = 2021,
            //Monster12 = 2022,
            //ScourgeInvaders = 2023,
            //TheHandofVengeance = 2024,
            //TheSilverCovenant = 2025,
            //TheSilverCovenant = 2026,
            //TheSilverCovenant = 2027,
            //Ambient = 2028,
            //MonsterPredator = 2029,
            //MonsterPredator = 2030,
            //HordeGeneric = 2031,
            //GrizzlyHillsTrapper = 2032,
            //Monster13 = 2033,
            //WarsongOffensive = 2034,
            //UndeadScourge = 2035,
            //Friendly = 2036,
            //ValianceExpedition = 2037,
            //Ambient = 2038,
            //Monster14 = 2039,
            //ValianceExpedition = 2040,
            //TheWyrmrestAccord = 2041,
            //UndeadScourge = 2042,
            //UndeadScourge = 2043,
            //ValianceExpedition = 2044,
            //WarsongOffensive = 2045,
            //Escortee = 2046,
            //TheKaluak = 2047,
            //ScourgeInvaders = 2048,
            //ScourgeInvaders = 2049,
            //KnightsoftheEbonBlade = 2050,
            //KnightsoftheEbonBlade = 2051,
            //WrathgateScourge = 2052,
            //WrathgateAlliance = 2053,
            //WrathgateHorde = 2054,
            //MonsterSpar = 2055,
            //MonsterSparBuddy = 2056,
            //MonsterZoneForceReaction2 = 2057,
            //CTFFlagHorde = 2058,
            //CTFFlagNeutral = 2059,
            //FrenzyheartTribe = 2060,
            //FrenzyheartTribe = 2061,
            //FrenzyheartTribe = 2062,
            //TheOracles = 2063,
            //TheOracles = 2064,
            //TheOracles = 2065,
            //TheOracles = 2066,
            //TheWyrmrestAccord = 2067,
            //UndeadScourge = 2068,
            //TrollDrakkari = 2069,
            //ArgentCrusade = 2070,
            //ArgentCrusade = 2071,
            //ArgentCrusade = 2072,
            //ArgentCrusade = 2073,
            //CavernsofTimeDurnholde = 2074,
            //CoTScourge = 2075,
            //CoTArthas = 2076,
            //CoTArthas = 2077,
            //CoTStratholmeCitizen = 2078,
            //CoTArthas = 2079,
            //UndeadScourge = 2080,
            //Freya = 2081,
            //UndeadScourge = 2082,
            //UndeadScourge = 2083,
            //UndeadScourge = 2084,
            //UndeadScourge = 2085,
            //ArgentDawn = 2086,
            //ArgentDawn = 2087,
            //ActorEvil = 2088,
            //ScarletCrusade = 2089,
            //MountTaxiAlliance = 2090,
            //MountTaxiHorde = 2091,
            //MountTaxiNeutral = 2092,
            //UndeadScourge = 2093,
            //UndeadScourge = 2094,
            //ScarletCrusade = 2095,
            //ScarletCrusade = 2096,
            //UndeadScourge = 2097,
            //ElementalAir = 2098,
            //ElementalWater = 2099,
            //UndeadScourge = 2100,
            //ActorEvil = 2101,
            //ActorEvil = 2102,
            //ScarletCrusade = 2103,
            //MonsterSpar = 2104,
            //MonsterSparBuddy = 2105,
            //Ambient = 2106,
            //TheSonsofHodir = 2107,
            //IronGiants = 2108,
            //FrostVrykul = 2109,
            //Friendly = 2110,
            //Monster15 = 2111,
            //TheSonsofHodir = 2112,
            //FrostVrykul = 2113,
            //Vrykul = 2114,
            //ActorGood = 2115,
            //Vrykul = 2116,
            //ActorGood = 2117,
            //Earthen = 2118,
            //MonsterReferee = 2119,
            //MonsterReferee = 2120,
            //TheSunreavers = 2121,
            //TheSunreavers = 2122,
            //TheSunreavers = 2123,
            //Monster16 = 2124,
            //FrostVrykul = 2125,
            //FrostVrykul = 2126,
            //Ambient = 2127,
            //Hyldsmeet = 2128,
            //TheSunreavers = 2129,
            //TheSilverCovenant = 2130,
            //ArgentCrusade = 2131,
            //WarsongOffensive = 2132,
            //FrostVrykul = 2133,
            //ArgentCrusade = 2134,
            //Friendly = 2135,
            //Ambient = 2136,
            //Friendly = 2137,
            //ArgentCrusade = 2138,
            //ScourgeInvaders = 2139,
            //Friendly = 2140,
            //Friendly = 2141,
            //Alliance = 2142,
            //ValianceExpedition = 2143,
            //KnightsoftheEbonBlade = 2144,
            //ScourgeInvaders = 2145,
            //TheKaluak = 2148,
            //MonsterSparBuddy = 2150,
            //Ironforge = 2155,
            //MonsterPredator = 2156,
            //ActorGood = 2176,
            //ActorGood = 2178,
            //HatesEverything = 2189,
            //HatesEverything = 2190,
            //HatesEverything = 2191,
            //UndeadScourge = 2209,
            //SilvermoonCity = 2210,
            //UndeadScourge = 2212,
            //KnightsoftheEbonBlade = 2214,
            //TheAshenVerdict = 2216,
            //TheAshenVerdict = 2217,
            //TheAshenVerdict = 2218,
            //TheAshenVerdict = 2219,
            //KnightsoftheEbonBlade = 2226,
            //ArgentCrusade = 2230,
            //CTFFlagHorde2 = 2235,
            //CTFFlagAlliance2 = 2236

    }
}
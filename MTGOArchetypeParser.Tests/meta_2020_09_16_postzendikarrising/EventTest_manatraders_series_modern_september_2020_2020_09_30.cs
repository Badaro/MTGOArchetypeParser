using FluentAssertions;
using MTGOArchetypeParser.Model;
using MTGOArchetypeParser.Metas.Modern;
using MTGOArchetypeParser.Archetypes.Modern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 alnash: Shadow Prowess (BR, Lurrus)
#02 adamwasmo: Oops All Spells (WUBRG)
#03 seasonofmists: Humans (WUBRG)
#04 zachattack23: WURG Control (WURG)
#05 NewHJ: Obosh Aggro (R, Obosh)
#06 Mogged: Heliod Combo (W)
#07 Trid0n: Humans (WUBRG)
#08 Patapon20: Dredge (BRG)
#09 FreedMania: Amulet Titan (UG)
#10 nbdf: Dredge (BRG)
#11 mlgb92: Humans (WUBRG)
#12 The_nayr: Shadow Prowess (BR, Lurrus)
#13 MadMaxErnst: UBRG Control (UBRG)
#14 Foxantes: Eldrazi Tron (C)
#15 Frejat: Reclaimer Titan (WRG)
#16 HouseOfManaMTG: Amulet Titan (UG)
#17 medvedev: Shadow Prowess (BR, Lurrus)
#18 Janh: Sultai Control (UBG)
#19 Danker: Humans (WUBRG)
#20 Gionax: Mono White Taxes (W)
#21 CaptainFarbosa: Humans (WUBRG)
#22 NHA37: Shadow Prowess (BR, Lurrus)
#23 Malakxy: Shadow Prowess (BR, Lurrus)
#24 billsive: WURG Control (WURG)
#25 _Batutinha_: Bant Control (WUG)
#26 Lord_of_puntlantis: Electro Balance (UR)
#27 GanYanCHN: Belcher (RG)
#28 mrichi: Heliod Combo (WG)
#29 CitrusD: Yawgmoth (BG)
#30 zbishop: Selesnya Taxes (WG)
#31 Oderus Urungus: Niv To Light (WUBRG)
#32 Wyern: Belcher (RG)
#33 TwistedWombat: Humans (WUBRG)
#34 CmA_LEO: Golgari Midrange (BG)
#35 RealJoy: Spirits (WUG)
#36 ragefistnate4: Green Tron (G)
#37 SknerusMcKwacz: Oops All Spells (WUBRG)
#38 albert62: Jund Midrange (BRG)
#39 carloswylde: Gifts Storm (UR)
#40 Nukkinz: Dredge (BRG)
#41 oosunq: Dredge (BRG)
#42 CordoTwin: Grixis Shadow (UBR)
#43 NMSX: Shadow Prowess (BR, Lurrus)
#44 RickSanchez1: Obosh Aggro (R, Obosh)
#45 Ryan_39: WURG Control (WURG)
#46 drvendigo: Jund Midrange (BRG)
#47 UTXShiro: Amulet Titan (URG)
#48 bamzing: Reclaimer Titan (WRG)
#49 blavantasian: Ad Nauseam (WUB)
#50 Kazuga: Shadow Prowess (BR, Lurrus)
#51 Kuhb: Shadow Prowess (BR, Lurrus)
#52 schnda: WURG Control (WURG)
#53 magetacr: Gifts Storm (UR)
#54 _Shatun_: Gruul Midrange (RG)
#55 guaxiniinja: Titan Shift (RG)
#56 acz: Gruul Midrange (RG)
#57 BaronOfBacon: Humans (WUBRG)
#58 deadlylike: Shadow Prowess (BR, Lurrus)
#59 indianpancake: WURG Control (WURG)
#60 manjyui: Gruul Midrange (RG)
#61 Thunderstriker7: Green Tron (G)
#62 Vertyx_: Bogles (WG, Lurrus)
#63 patxi: WURG Control (WURG)
#64 wambocombo2020: UBRG Control (UBRG)
#65 RedArmada: WURG Control (WURG)
#66 musasabi: Orzhov Midrange (WB)
#67 cometa183: Humans (WUBRG)
#68 Dai1412: Green Tron (G)
#69 nonbo: Merfolk (UG)
#70 Muldrotha7912: Eldrazi Tron (C)
#71 msskinbolic: Mill (UB, Lurrus)
#72 szydlovski: Shadow Prowess (BR, Lurrus)
#73 DarthDessel: Gifts Storm (UR)
#74 DaniMRebel: Spirits (WU)
#75 Elfkid: Shadow Prowess (BR, Lurrus)
#76 badluckbandit: Shadow Prowess (BR, Lurrus)
#77 trunks132: Shadow Prowess (BR, Lurrus)
#78 Joao_Andrade: Green Tron (G)
#79 mrjgiles: Blue Tron (U)
#80 Jiobimbo: Azorius Taxes (WU)
#81 MissTrigger: Bogles (WG)
#82 Menoti: Green Tron (G)
#83 faisal: Jund Midrange (BRG)
#84 runn3runn3r: Rakdos Prowess (BR, Lurrus)
#85 sharkcaster_mage: Reclaimer Titan (WRG)
#86 CrouchingPig: Ad Nauseam (WUB)
#87 papajerrett13: Rakdos Prowess (BR, Lurrus)
#88 Ashanti: Gifts Storm (UR)
#89 Galrion89: Belcher (RG)
#90 max09: Selesnya Taxes (WG)
#91 thinenagooyen: Titan Shift (RG)
#92 Callad0: Primeval Titan (UG)
#93 BlogBoy: Smallpox (WB)
#94 kaktusowysmok: Goblins (BR)
#95 Seraphic_demon: Bant Midrange (WUG)
#96 kingsmudge: Eldrazi Tron (C)
#97 coert: Bogles (WUG, Lurrus)
#98 SweetIto: Shadow Prowess (BR, Lurrus)
#99 Nammersquats: Bogles (WG, Lurrus)
#100 jenara19: Humans (WUBRG)
#101 Koala40: Oops All Spells (WUBRG)
#102 Traft: WURG Control (WURG)
#103 Rai_K: Humans (WUBRG)
#104 abisbocci: Jund Shadow (BRG)
#105 an_actual_potato: Temur Control (URG)
#106 The_GingerBrute: Hammer Time (WR, Lurrus)
#107 RandomOctopus: Oops All Spells (WUBRG)
#108 TheUnseen: Humans (WUBRG)
#109 ajax13s: Rakdos Midrange (BR)
#110 IRONBAN974: Ad Nauseam (WUB)
#111 Kauri: Heliod Combo (WG)
#112 facematt: Domain Zoo (WUBRG, Jegantha)
#113 ThatAsianGuy8: Gruul Midrange (RG)
#114 ACG88: Reclaimer Titan (WRG)
#115 Koptek: Temur Control (URG)
#116 Stompy45: Obosh Aggro (R, Obosh)
#117 salvite: Temur Control (URG)
#118 ary31415: Orzhov Taxes (WB)
#119 MTGteamDecay: Humans (WUBRG)
#120 SourceOdin: Reclaimer Titan (WRG)
#121 ShutoShotokan: Humans (WUBRG)
#122 deftjad: Spirits (WU)
#123 PieGonti: Humans (WUBRG)
#124 DylansHyper: Sultai Control (UBG)
#125 PeanutBrittle: Humans (WUBRG)
#126 Deburca: Jeskai Control (WUR)
#127 Nilsfit: Sultai Control (UBG)
#128 acetrainerblue: Yawgmoth (BG)
#129 Promidnightz: Devoted (WG, Lurrus)
#130 starfall: Shadow Prowess (BR, Lurrus)
#131 olea: Amulet Titan (RG)
#132 MandrillMan: Obosh Aggro (R, Obosh)
#133 efree19: Izzet Prowess (UR)
#134 remf: Spirits (WU)
#135 Ekeross: Mono Red Prowess (R)
#136 Firewalker89: Grixis Shadow (UBR)
#137 Icteridae: Devoted (WUG)
#138 rexplosion: Jeskai Control (WUR)
#139 untiltedmtg: Gruul Midrange (RG)
#140 pokerswizard: Mill (UB, Lurrus)
#141 thehunter1379: Green Tron (G)
#142 Kammautha: Izzet Prowess (UR)
#143 CHILLEDADED: Green Tron (G)
#144 Irra0770: Jund Midrange (BRG)
#145 tylerjjobrien: Esper Control (WUB)
#146 simply_skilled: Shadow Prowess (BR, Lurrus)
#147 Egadd2894: Niv To Light (WUBRG, Jegantha)
#148 brothernova: Titan Shift (RG)
#149 BERNASTORRES: Mill (UB)
#150 magicmiguelGG: Gruul Midrange (RG)
#151 Sprouts: Golgari Midrange (BG)
#152 Wtnof: Reclaimer Titan (WRG)
#153 ThreeThreeElk: Humans (WUBRG)
#154 whysloth: Ad Nauseam (WUB)
#155 foretweezy1: Eldrazi Tron (C)
#156 Daking3603: Reclaimer Titan (WRG)
#157 Theo_Jung: Shadow Prowess (BR, Lurrus)
#158 SvenSveeterSven: Izzet Control (UR)
#159 yneves: Green Tron (G, Jegantha)
#160 Xwhale: Humans (WUBRG)
#161 Tikidan: Izzet Prowess (UR)
#162 legionwolfe: Bogles (WG, Lurrus)
#163 tomvon9: Green Tron (G)
#164 WeareVenom: WURG Control (WURG)
#165 Beenew: Obosh Aggro (R, Obosh)
#166 ello_baron: Humans (WUBRG)
#167 Bodingle: Mardu Midrange (WBR)
#168 helmanns: Humans (WUBRG)
#169 sonso jf: Heliod Combo (WG)
#170 Bedell: Amulet Titan (URG)
#171 fradelrock: Shadow Prowess (BR, Lurrus)
#172 twinlesstwin: UBRG Control (UBRG)
#173 itzyoshimitsu: Bant Midrange (WUG)
#174 __palem__: Gruul Midrange (RG)
#175 camr0n_1: Amulet Titan (RG)
#176 acjestes: Gifts Storm (UR)
#177 diem4x: Shadow Prowess (BR, Lurrus)
#178 tojo85: Gruul Midrange (RG)
#179 GYBA: Oops All Spells (WUBRG)
#180 WhiTe TsaR: Oops All Spells (BRG)
#181 Varo: Obosh Aggro (R, Obosh)
#182 lancaster2124: Gruul Midrange (RG)
#183 pootisgodsamongus: Obosh Aggro (R, Obosh)
#184 JustBurn420: Slivers (WUBRG)
#185 KelMasterP: Humans (WUBRG)
#186 BigDaddyVince: Gruul Midrange (RG)
#187 AluminumMonster: Bant Control (WUG)
#188 cookiekid00: Shadow Prowess (BR, Lurrus)
#189 ianisrad: Hammer Time (WR, Lurrus)
#190 BSK_hercules: WURG Control (WURG)
#191 SamuelGraebner: WURG Control (WURG)
#192 rigorage: Gruul Midrange (RG)
#193 Searzist: Mill (UB, Lurrus)
#194 hplovely: Titan Shift (RG)
#195 jkirchnerortiz: Sultai Control (UBG)
#196 didoguidotti1: WURG Control (WURG)
#197 ziofrancone: Izzet Prowess (UR)
#198 mgoat: Grixis Shadow (UBR)
#199 _LSN_: Burn (WR)
#200 nublkau: Izzet Prowess (UR)
#201 thegodmikedevo: Eldrazi Tron (C)
#202 thetunnelingcat: Eldrazi Tron (C)
#203 TheKingFor1000years: Infect (UG)
#204 CrypticRocket: Humans (WUBRG)
#205 Denmark_Dan: Primeval Titan (RG)
#206 TuggaNaxos: Rakdos Prowess (BR, Lurrus)
#207 manaproducti0ns: Temur Control (URG)
#208 OrnatePuzzles: Gruul Midrange (RG)
#209 L3D91: Shadow Prowess (BR, Lurrus)
#210 Game_Night: Jeskai Control (WUR)
#211 Alma: Jund Midrange (BRG)
#212 ScreenwriterNY: Mill (WU, Lurrus)
#213 Karatedom: Shadow Prowess (BR, Lurrus)
#214 nietzreznor: Shadow Prowess (BR, Lurrus)
#215 deranged_welp: Obosh Aggro (R, Obosh)
#216 rav104: Oops All Spells (WUBRG)
#217 Thrall90: Rakdos Prowess (BR, Lurrus)
#218 Dafne17: Obosh Aggro (R, Obosh)
#219 Lonestar16: WURG Control (WURG)
#220 fling5133: Jund Midrange (BRG)
#221 l0rd0fdarkn3ss25: Bogles (WG)
#222 meijisalt12: Oops All Spells (WUBRG)
#223 bullwinkle6705: UBRG Control (UBRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_manatraders_series_modern_september_2020_2020_09_30 : EventTest
    {
        [Test]
        public void Deck01_alnash_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",0),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_adamwasmo_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",1),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck03_seasonofmists_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",2),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck04_zachattack23_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",3),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_NewHJ_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",4),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck06_Mogged_HeliodCombo_W()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",5),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Trid0n_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",6),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Patapon20_Dredge_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",7),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck09_FreedMania_AmuletTitan_UG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",8),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck10_nbdf_Dredge_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",9),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck11_mlgb92_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",10),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Thenayr_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",11),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_MadMaxErnst_UBRGControl_UBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",12),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Foxantes_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",13),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck15_Frejat_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",14),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck16_HouseOfManaMTG_AmuletTitan_UG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",15),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck17_medvedev_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",16),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_Janh_SultaiControl_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",17),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck19_Danker_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",18),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Gionax_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",19),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck21_CaptainFarbosa_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",20),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck22_NHA37_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",21),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck23_Malakxy_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",22),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck24_billsive_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",23),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Batutinha_BantControl_WUG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",24),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck26_Lordofpuntlantis_ElectroBalance_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",25),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(FreeSpells),
                typeof(ElectroBalance),
                null
            );
        }

        [Test]
        public void Deck27_GanYanCHN_Belcher_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",26),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck28_mrichi_HeliodCombo_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",27),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck29_CitrusD_Yawgmoth_BG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",28),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck30_zbishop_SelesnyaTaxes_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",29),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck31_OderusUrungus_NivToLight_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",30),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck32_Wyern_Belcher_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",31),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck33_TwistedWombat_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",32),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck34_CmALEO_GolgariMidrange_BG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",33),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck35_RealJoy_Spirits_WUG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",34),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck36_ragefistnate4_GreenTron_G()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",35),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck37_SknerusMcKwacz_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",36),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck38_albert62_JundMidrange_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",37),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck39_carloswylde_GiftsStorm_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",38),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck40_Nukkinz_Dredge_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",39),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck41_oosunq_Dredge_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",40),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck42_CordoTwin_GrixisShadow_UBR()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",41),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck43_NMSX_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",42),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck44_RickSanchez1_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",43),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck45_Ryan39_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",44),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck46_drvendigo_JundMidrange_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",45),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck47_UTXShiro_AmuletTitan_URG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",46),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck48_bamzing_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",47),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck49_blavantasian_AdNauseam_WUB()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",48),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck50_Kazuga_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",49),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck51_Kuhb_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",50),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck52_schnda_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",51),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck53_magetacr_GiftsStorm_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",52),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck54_Shatun_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",53),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck55_guaxiniinja_TitanShift_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",54),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck56_acz_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",55),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck57_BaronOfBacon_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",56),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck58_deadlylike_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",57),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck59_indianpancake_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",58),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck60_manjyui_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",59),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck61_Thunderstriker7_GreenTron_G()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",60),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck62_Vertyx_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",61),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck63_patxi_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",62),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck64_wambocombo2020_UBRGControl_UBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",63),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck65_RedArmada_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",64),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck66_musasabi_OrzhovMidrange_WB()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",65),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck67_cometa183_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",66),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck68_Dai1412_GreenTron_G()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",67),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck69_nonbo_Merfolk_UG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",68),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck70_Muldrotha7912_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",69),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck71_msskinbolic_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",70),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck72_szydlovski_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",71),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck73_DarthDessel_GiftsStorm_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",72),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck74_DaniMRebel_Spirits_WU()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",73),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck75_Elfkid_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",74),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck76_badluckbandit_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",75),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck77_trunks132_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",76),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck78_JoaoAndrade_GreenTron_G()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",77),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck79_mrjgiles_BlueTron_U()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",78),
                new PostZendikarRising(),
                ArchetypeColor.U,
                typeof(Tron),
                typeof(BlueTron),
                null
            );
        }

        [Test]
        public void Deck80_Jiobimbo_AzoriusTaxes_WU()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",79),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck81_MissTrigger_Bogles_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",80),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck82_Menoti_GreenTron_G()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",81),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck83_faisal_JundMidrange_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",82),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck84_runn3runn3r_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",83),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck85_sharkcastermage_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",84),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck86_CrouchingPig_AdNauseam_WUB()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",85),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck87_papajerrett13_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",86),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck88_Ashanti_GiftsStorm_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",87),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck89_Galrion89_Belcher_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",88),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck90_max09_SelesnyaTaxes_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",89),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck91_thinenagooyen_TitanShift_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",90),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck92_Callad0_PrimevalTitan_UG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",91),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck93_BlogBoy_Smallpox_WB()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",92),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(Smallpox),
                null,
                null
            );
        }

        [Test]
        public void Deck94_kaktusowysmok_Goblins_BR()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",93),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck95_Seraphicdemon_BantMidrange_WUG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",94),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck96_kingsmudge_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",95),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck97_coert_Bogles_WUG_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",96),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck98_SweetIto_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",97),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck99_Nammersquats_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",98),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck100_jenara19_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",99),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck101_Koala40_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",100),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck102_Traft_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",101),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck103_RaiK_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",102),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck104_abisbocci_JundShadow_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",103),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck105_anactualpotato_TemurControl_URG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",104),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck106_TheGingerBrute_HammerTime_WR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",105),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck107_RandomOctopus_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",106),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck108_TheUnseen_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",107),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck109_ajax13s_RakdosMidrange_BR()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",108),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck110_IRONBAN974_AdNauseam_WUB()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",109),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck111_Kauri_HeliodCombo_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",110),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck112_facematt_DomainZoo_WUBRG_Jegantha()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",111),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(DomainZoo),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck113_ThatAsianGuy8_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",112),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck114_ACG88_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",113),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck115_Koptek_TemurControl_URG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",114),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck116_Stompy45_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",115),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck117_salvite_TemurControl_URG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",116),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck118_ary31415_OrzhovTaxes_WB()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",117),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck119_MTGteamDecay_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",118),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck120_SourceOdin_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",119),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck121_ShutoShotokan_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",120),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck122_deftjad_Spirits_WU()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",121),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck123_PieGonti_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",122),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck124_DylansHyper_SultaiControl_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",123),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck125_PeanutBrittle_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",124),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck126_Deburca_JeskaiControl_WUR()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",125),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck127_Nilsfit_SultaiControl_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",126),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck128_acetrainerblue_Yawgmoth_BG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",127),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck129_Promidnightz_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",128),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck130_starfall_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",129),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck131_olea_AmuletTitan_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",130),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck132_MandrillMan_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",131),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck133_efree19_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",132),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck134_remf_Spirits_WU()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",133),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck135_Ekeross_MonoRedProwess_R()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",134),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck136_Firewalker89_GrixisShadow_UBR()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",135),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck137_Icteridae_Devoted_WUG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",136),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck138_rexplosion_JeskaiControl_WUR()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",137),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck139_untiltedmtg_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",138),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck140_pokerswizard_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",139),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck141_thehunter1379_GreenTron_G()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",140),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck142_Kammautha_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",141),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck143_CHILLEDADED_GreenTron_G()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",142),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck144_Irra0770_JundMidrange_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",143),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck145_tylerjjobrien_EsperControl_WUB()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",144),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck146_simplyskilled_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",145),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck147_Egadd2894_NivToLight_WUBRG_Jegantha()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",146),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck148_brothernova_TitanShift_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",147),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck149_BERNASTORRES_Mill_UB()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",148),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck150_magicmiguelGG_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",149),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck151_Sprouts_GolgariMidrange_BG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",150),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck152_Wtnof_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",151),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck153_ThreeThreeElk_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",152),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck154_whysloth_AdNauseam_WUB()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",153),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck155_foretweezy1_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",154),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck156_Daking3603_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",155),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck157_TheoJung_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",156),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck158_SvenSveeterSven_IzzetControl_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",157),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck159_yneves_GreenTron_G_Jegantha()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",158),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck160_Xwhale_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",159),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck161_Tikidan_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",160),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck162_legionwolfe_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",161),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck163_tomvon9_GreenTron_G()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",162),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck164_WeareVenom_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",163),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck165_Beenew_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",164),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck166_ellobaron_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",165),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck167_Bodingle_MarduMidrange_WBR()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",166),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck168_helmanns_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",167),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck169_sonsojf_HeliodCombo_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",168),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck170_Bedell_AmuletTitan_URG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",169),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck171_fradelrock_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",170),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck172_twinlesstwin_UBRGControl_UBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",171),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck173_itzyoshimitsu_BantMidrange_WUG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",172),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck174_palem_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",173),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck175_camr0n1_AmuletTitan_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",174),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck176_acjestes_GiftsStorm_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",175),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck177_diem4x_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",176),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck178_tojo85_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",177),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck179_GYBA_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",178),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck180_WhiTeTsaR_OopsAllSpells_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",179),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck181_Varo_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",180),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck182_lancaster2124_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",181),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck183_pootisgodsamongus_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",182),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck184_JustBurn420_Slivers_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",183),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Slivers),
                null,
                null
            );
        }

        [Test]
        public void Deck185_KelMasterP_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",184),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck186_BigDaddyVince_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",185),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck187_AluminumMonster_BantControl_WUG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",186),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck188_cookiekid00_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",187),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck189_ianisrad_HammerTime_WR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",188),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck190_BSKhercules_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",189),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck191_SamuelGraebner_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",190),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck192_rigorage_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",191),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck193_Searzist_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",192),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck194_hplovely_TitanShift_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",193),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck195_jkirchnerortiz_SultaiControl_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",194),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck196_didoguidotti1_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",195),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck197_ziofrancone_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",196),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck198_mgoat_GrixisShadow_UBR()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",197),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck199_LSN_Burn_WR()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",198),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck200_nublkau_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",199),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck201_thegodmikedevo_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",200),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck202_thetunnelingcat_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",201),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck203_TheKingFor1000years_Infect_UG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",202),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck204_CrypticRocket_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",203),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck205_DenmarkDan_PrimevalTitan_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",204),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck206_TuggaNaxos_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",205),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck207_manaproducti0ns_TemurControl_URG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",206),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck208_OrnatePuzzles_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",207),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck209_L3D91_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",208),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck210_GameNight_JeskaiControl_WUR()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",209),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck211_Alma_JundMidrange_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",210),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck212_ScreenwriterNY_Mill_WU_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",211),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck213_Karatedom_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",212),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck214_nietzreznor_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",213),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck215_derangedwelp_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",214),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck216_rav104_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",215),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck217_Thrall90_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",216),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck218_Dafne17_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",217),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck219_Lonestar16_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",218),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck220_fling5133_JundMidrange_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",219),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck221_l0rd0fdarkn3ss25_Bogles_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",220),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck222_meijisalt12_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",221),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck223_bullwinkle6705_UBRGControl_UBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-september-2020-2020-09-30",222),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}

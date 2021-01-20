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
#01 Phill_Hellmuth: WURG Control (WURG)
#02 HannoLee: Green Tron (G)
#03 _IlNano_: Shadow Prowess (BR, Lurrus)
#04 Gerardo94: WURG Control (WURG)
#05 coert: Heliod Combo (WG)
#06 VilaCelta: Ad Nauseam (WUB)
#07 GobFTW: Temur Control (URG)
#08 Harry13: Sultai Control (UBG)
#09 Lord_of_puntlantis: Electro Balance (UR)
#10 Theo_Jung: Heliod Combo (WG)
#11 LLegend: Electro Balance (URG)
#12 mlgb92: Bant Midrange (WUG)
#13 wzybang: Amulet Titan (G)
#14 HypnoticaL: Shadow Prowess (BR, Lurrus)
#15 Bordas99: Dredge (BRG)
#16 nbdf: Dredge (BRG)
#17 B1gDan: Shadow Prowess (BR, Lurrus)
#18 Ekeross: Shadow Prowess (BR, Lurrus)
#19 graciasportanto: Sultai Control (UBG)
#20 wordy333: Izzet Prowess (UR)
#21 Olivetti: WURG Control (WURG)
#22 carloswylde: Green Tron (G)
#23 NHA37: Heliod Combo (WR)
#24 noesmitipo: Belcher (URG)
#25 Conor_man11: Hammer Time (WB, Lurrus)
#26 5c_Bloodmoon: Omnath Saheeli (WURG)
#27 Falco_Lombardi: Hammer Time (W, Lurrus)
#28 pedrogush: Hammer Time (WB, Lurrus)
#29 Bedell: Reclaimer Titan (WG)
#30 max09: Ad Nauseam (WUB)
#31 PieGonti: Belcher (BRG)
#32 gazurmah: Izzet Control (UR)
#33 Pintogeddon2: Belcher (URG)
#34 Xwhale: Reclaimer Titan (WG)
#35 __palem__: Burn (WR)
#36 Foxantes: Oops All Spells (WUBRG)
#37 twinlesstwin: Mardu Midrange (WBR)
#38 FreedMania: Amulet Titan (G)
#39 SKK: Reclaimer Titan (WRG)
#40 Callad0: Heliod Combo (WG)
#41 Mogged: Obosh Aggro (R, Obosh)
#42 evange_: Izzet Prowess (UR)
#43 sonso jf: Heliod Combo (WG)
#44 BaronOfBacon: Shadow Prowess (BR, Lurrus)
#45 fluffywolf2: Pyro Prison (R)
#46 SknerusMcKwacz: WURG Control (WURG)
#47 kaktusowysmok: Goblins (BR)
#48 ReanimatorFiend: WURG Control (WURG)
#49 DmZB: Gifts Storm (UR)
#50 tbrantl99: Ad Nauseam (WUB)
#51 starfall: Shadow Prowess (BR, Lurrus)
#52 didoguidotti1: WURG Control (WURG)
#53 thecodyhope: Elementals (WUBRG, Kaheera)
#54 Sam_M: Spirits (WU)
#55 jacopo88: Reclaimer Titan (WRG)
#56 armstrong36: Dredge (BRG)
#57 Offbeat_Hero: Mono White Taxes (W, Yorion)
#58 Moonsault37: Humans (WUBRG)
#59 SonicK: Belcher (URG)
#60 a_p_s: Thopter Urza (WU)
#61 grinderA: Izzet Prowess (UR)
#62 Better_than_Average: Obosh Aggro (R, Obosh)
#63 wild88plk: Reclaimer Titan (WRG)
#64 RnB: Obosh Aggro (R, Obosh)
#65 A22en: Mill (UB, Lurrus)
#66 djbmppwns: Heliod Combo (WG)
#67 do0mswitch: WURG Control (WURG)
#68 tarrasque1: Mono White Taxes (W)
#69 musasabi: Mardu Midrange (WBR)
#70 Sciakimika: Amulet Titan (G)
#71 dynamisskill: Heliod Combo (WG)
#72 GrilledCheese: Amulet Titan (G)
#73 TheWillHallExp: Mardu Midrange (WBR)
#74 NAKISHIMA: Oops All Spells (WUBRG)
#75 ThreeThreeElk: Reclaimer Titan (WG)
#76 ShutoShotokan: Humans (WUBRG)
#77 Vad3r: Niv To Light (WUBRG, Yorion)
#78 MadMaxErnst: WURG Control (WURG)
#79 TheEnduringIdealist: Belcher (WURG)
#80 solaec0501: Primeval Titan (UG)
#81 FromTheCrypt: Eldrazi Tron (C)
#82 badluckbandit: Heliod Combo (WG)
#83 INickStrad: WURG Control (WURG)
#84 Joao_Andrade: WURG Control (WURG)
#85 Kuhb: Hammer Time (WB, Lurrus)
#86 ridetheiguana: Rakdos Midrange (BR)
#87 mikeleee: Shadow Prowess (BR, Lurrus)
#88 rorschach-: WURG Control (WURG)
#89 powery: Heliod Combo (WG)
#90 LMAOMOBILE: Rakdos Midrange (BR)
#91 adriaferrer: Sultai Control (UBG)
#92 _Shatun_: Rakdos Midrange (BR)
#93 On-The-Play: Rakdos Midrange (BR)
#94 SimoCr: Green Tron (G)
#95 La_Parkita: Izzet Prowess (UR)
#96 Bodybag: Shadow Prowess (BR, Lurrus)
#97 thinenagooyen: Titan Shift (RG)
#98 Traft: WURG Control (WURG)
#99 SebastianStueckl: Heliod Combo (WG)
#100 bwheezy: Jeskai Control (WUR)
#101 ElYallo: Heliod Combo (WG)
#102 Frutuoso: Orzhov Midrange (WB)
#103 _LSN_: Burn (WR, Lurrus)
#104 DaniMRebel: Spirits (WU)
#105 MaxCapone: Oops All Spells (WUBG)
#106 ReinardBR: Green Tron (G)
#107 MissTrigger: Izzet Prowess (UR)
#108 bucknasty691989: Rakdos Midrange (BR)
#109 mac121711: WURG Control (WURG)
#110 Hollardustin: Jeskai Control (WUR)
#111 cptobvious343: Izzet Control (UR)
#112 MandrillMan: Heliod Combo (WG)
#113 Jositoshekel: Heliod Combo (WG)
#114 paucr5: Eldrazi Tron (C)
#115 Child_oftheSand: Mono White Taxes (W)
#116 DavidLeChiffre: Humans (WUBRG)
#117 Ne-rik-is: Mono White Taxes (W)
#118 Costola91: Heliod Combo (WG)
#119 nsroller: Heliod Combo (WG)
#120 DuHeng: Shadow Prowess (BR, Lurrus)
#121 Alexmcl88: Amulet Titan (G)
#122 patxi: Dimir Control (UB)
#123 Elfkid: Dredge (BRG)
#124 spiderspace: Belcher (URG)
#125 xf13rc3byerly: Shadow Prowess (BR, Lurrus)
#126 jenara19: Green Tron (RG)
#127 claydawson: Izzet Prowess (UR)
#128 indianpancake: Sultai Control (UBG)
#129 Broccoliasaurus: Mardu Midrange (WBR)
#130 bolov0: Mardu Midrange (WBR)
#131 HenryAmbrogius: Gifts Storm (UR)
#132 Draconic1: Reclaimer Titan (WG)
#133 Bloodlights: Dimir Control (UB)
#134 bigb3n: WURG Control (WURG)
#135 christopdeck: Burn (WRG, Lurrus)
#136 aedrew: Humans (WUBRG)
#137 kolbej: WURG Control (WURG)
#138 bozokaboy: Oops All Spells (WUBG)
#139 mikepick7: Burn (WR)
#140 LucasG1ggs: Eldrazi Tron (C)
#141 diem4x: Sultai Control (UBG)
#142 meanfannypack: Heliod Combo (WG)
#143 _Batutinha_: Reclaimer Titan (WRG)
#144 FerMTG: Rakdos Midrange (BR)
#145 Cobstrike: Reclaimer Titan (WRG)
#146 boulderelf: Obosh Aggro (R, Obosh)
#147 ATGerwaz: Sultai Control (UBG)
#148 Aerien_sol: Sultai Control (UBG)
#149 rafusfito: Ad Nauseam (WUB)
#150 delverniv: Izzet Prowess (UR)
#151 cntrlfreak: Shadow Prowess (BR, Lurrus)
#152 w1vern: Shadow Prowess (BR, Lurrus)
#153 lipingpong: Burn (WR)
#154 magic_viking: Bant Blink (WUG)
#155 Firewalker89: Grixis Shadow (UBR)
#156 Sprouts: Hammer Time (WR)
#157 Sods: Green Tron (G)
#158 Gigy: Shadow Prowess (BR, Lurrus)
#159 HouseOfManaMTG: Amulet Titan (G)
#160 TwistedWombat: Izzet Prowess (UR)
#161 albertosd: WBRG Shadow (WBRG)
#162 Aluren85: Scapeshift (WURG)
#163 marcofabrizi: Shadow Prowess (BR, Lurrus)
#164 ander_lizarrakoa: Dimir Control (UB)
#165 matyo804: Reclaimer Titan (WRG)
#166 teske: Azorius Control (WU)
#167 Tykos: Hammer Time (WB, Lurrus)
#168 schnda: WURG Control (WURG)
#169 mistakenn: Amulet Titan (RG)
#170 Krikles: Obosh Aggro (R, Obosh)
#171 NJGB1: UBRG Shadow (UBRG)
#172 guispiller: Gifts Storm (UR)
#173 ACG88: Green Tron (G)
#174 NightKnight131: Heliod Combo (WG)
#175 DcNo: Humans (WUBRG)
#176 TeamGreed: Dredge (BRG)
#177 JUJUBEAN__2004: Heliod Combo (WG)
#178 Aeolus1295: Amulet Titan (G)
#179 ShowTime_: Rakdos Midrange (BR)
#180 MrRaeb: WURG Control (WURG)
#181 Joshicallsmefabo: Shadow Prowess (BR, Lurrus)
#182 Shadowz2005: Mardu Midrange (WBR)
#183 kingfroik: Shadow Prowess (BR, Lurrus)
#184 sam555101: Izzet Prowess (UR)
#185 _Takeno_: Pyro Prison (R)
#186 easymoneymarksman: Shadow Prowess (BR, Lurrus)
#187 sharkcaster_mage: Humans (WUBRG)
#188 Koso: Shadow Prowess (BR, Lurrus)
#189 Capipf95: Burn (WR, Lurrus)
#190 nothingnamed: Green Tron (G)
#191 Cabz: Burn (WR)
#192 MartinezDP: Omnath Saheeli (WURG, Yorion)
#193 Frankdog: Goblins (BR)
#194 WhiteFaces: Hammer Time (W, Lurrus)
#195 LuisMj: WURG Control (WURG)
#196 Denmark_Dan: Azorius Control (WU)
#197 Bomberboss: Mardu Midrange (WBR)
#198 NathanLipetz: Rakdos Midrange (BR)
#199 magma728: Ad Nauseam (WUB)
#200 bamzing: WURG Control (WURG)
#201 Rosencrantz_920: Amulet Titan (G)
#202 blavantasian: Ad Nauseam (WUB)
#203 tylerjjobrien: Rakdos Midrange (BR)
#204 TwitchAwP: Ad Nauseam (WUB)
#205 Pietrone10: Infect (UG)
#206 albert62: WURG Control (WURG)
#207 Geme: Green Tron (G)
#208 Stompy45: Mardu Midrange (WBR)
#209 ballestin93: WURG Control (WURG)
#210 MagicMichiel: Shadow Prowess (BR, Lurrus)
#211 Kauri: Hardened Scales (RG)
#212 Kyro4: Shadow Prowess (BR, Lurrus)
#213 kronos23: Eldrazi Tron (C)
#214 lsmguys: WURG Control (WURG)
#215 ninomtg: Shadow Prowess (BR, Lurrus)
#216 zaferus: Burn (WR)
#217 ouranos139: Amulet Titan (G)
#218 AlabasterWolfie: Shadow Prowess (UBRG, Lurrus)
#219 Ruizthebeast: Devoted (WG, Lurrus)
#220 remf: Spirits (WU)
#221 Iceman76: Goblins (BR)
#222 APandaWithOneLeg: Green Tron (G, Jegantha)
#223 Kirkinator: Obosh Aggro (R, Obosh)
#224 Camero: Belcher (URG)
#225 ncowden: WURG Control (WURG)
#226 Fenrir303: Hammer Time (WB, Lurrus)
#227 SamuelGraebner: WURG Control (WURG)
#228 3HaLeX1: Izzet Prowess (UR)
#229 alasan922: Bant Midrange (WUG)
#230 yumad3988: Primeval Titan (UG)
#231 Hexdrinker9: Naya Midrange (WRG)
#232 therf: Jeskai Control (WUR)
#233 adamwasmo: Oops All Spells (WUBRG)
#234 Laplasjan: Hammer Time (WB, Lurrus)
#235 Marinex: Dredge (BRG)
#236 antus94: Shadow Prowess (BRG, Lurrus)
#237 KBTMTG: Eldrazi Tron (C)
#238 zecarlonxo: Obosh Aggro (R, Obosh)
#239 SacmenFeg: Burn (WR)
#240 Halobender: Izzet Prowess (UR)
#241 pepeteam: Sultai Control (UBG)
#242 Nammersquats: Infect (UG)
#243 jackchurch1996: Mardu Midrange (WBR)
#244 Whitco02: Izzet Prowess (UR)
#245 Bayesta_93: Shadow Prowess (BR, Lurrus)
#246 carletao: Izzet Control (UR)
#247 d00mwake: Rakdos Prowess (BR, Lurrus)
#248 Karatedom: Rakdos Prowess (BR, Lurrus)
#249 BSK_hercules: Sultai Control (UBG)
#250 Wtnof: Oops All Spells (WUBG)
#251 Fenruscloud: Infect (BG)
#252 vfras96: Rogues (UB, Lurrus)
#253 WhiTe TsaR: Sultai Control (UBG)
#254 Kr0k39: Gifts Storm (UR)
#255 travis8427: Infect (UG)
#256 spokes: Oops All Spells (WUBG)
#257 iaky91: Ad Nauseam (WUB)
#258 _Luks: Thopter Urza (UBR)
#259 SouthernSliver: Slivers (WUBRG)
#260 energiza: Humans (WUBRG)
#261 SweetIto: Shadow Prowess (BR, Lurrus)
#262 weishengzhishabi: Sultai Control (UBG)
#263 pokerswizard: Spirits (WU)
#264 toondoslav: Infect (UG)
#265 miqa: Electro End (UR)
#266 dhawk50: Burn (WR)
#267 crazeejakee07: WURG Control (WURG)
#268 1yo2yo: Thopter Urza (WUB)
#269 LiturgijskaKnjiga: Bogles (WG)
#270 DirtyRowdyBoy: WURG Control (WURG)
#271 Daking3603: Reclaimer Titan (WRG)
#272 jdmoyer17: Mill (UB, Lurrus)
#273 ArchaeusDota: Uroza (WUBRG)
#274 Drockafeller: WURG Control (WURG)
#275 Tw33Ty: Shadow Prowess (BR, Lurrus)
#276 ziofrancone: Ascendancy Combo (WURG, Jegantha)
#277 Noix11: Humans (WUBRG)
#278 TheJigIsAlwaysUp: Heliod Combo (WG)
#279 FingersMLD: Mono White Taxes (W)
#280 tzirkel: Heliod Combo (WG)
#281 __BMJ__: Rakdos Prowess (BR, Lurrus)
#282 cftsoc3: Bant Blink (WUG)
#283 MickeyPlaysMagic: Mardu Midrange (WBR)
#284 SakingMTG: Green Tron (RG)
#285 fpawlusz: Amulet Titan (G)
#286 joker10289: Reclaimer Titan (WG)
#287 whitefangshinobi: Izzet Prowess (UR)
#288 jay44bab: Shadow Prowess (BR, Lurrus)
#289 Dafne17: Mono Red Prowess (R)
#290 MdvWin: Hammer Time (W, Lurrus)
#291 mrichi: WURG Control (WURG)
#292 kevilynn: Spirits (WUG)
#293 Sherwinator: Mill (UB, Lurrus)
#294 abisbocci: Grixis Shadow (UBR)
#295 Manakin: Hardened Scales (RG)
#296 Nilsfit: Ascendancy Combo (WURG, Jegantha)
#297 NGFC_Mark: Oops All Spells (WUBG)
#298 ecobaronen: Titan Shift (RG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_manatraders_series_modern_december_2020_2020_12_31 : EventTest
    {
        [Test]
        public void Deck01_PhillHellmuth_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",0),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_HannoLee_GreenTron_G()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",1),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck03_IlNano_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",2),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_Gerardo94_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",3),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_coert_HeliodCombo_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",4),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck06_VilaCelta_AdNauseam_WUB()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",5),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck07_GobFTW_TemurControl_URG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",6),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Harry13_SultaiControl_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",7),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Lordofpuntlantis_ElectroBalance_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",8),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(FreeSpells),
                typeof(ElectroBalance),
                null
            );
        }

        [Test]
        public void Deck10_TheoJung_HeliodCombo_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",9),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck11_LLegend_ElectroBalance_URG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",10),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(FreeSpells),
                typeof(ElectroBalance),
                null
            );
        }

        [Test]
        public void Deck12_mlgb92_BantMidrange_WUG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",11),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck13_wzybang_AmuletTitan_G()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",12),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck14_HypnoticaL_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",13),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck15_Bordas99_Dredge_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",14),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck16_nbdf_Dredge_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",15),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck17_B1gDan_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",16),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_Ekeross_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",17),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck19_graciasportanto_SultaiControl_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",18),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck20_wordy333_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",19),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck21_Olivetti_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",20),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck22_carloswylde_GreenTron_G()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",21),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck23_NHA37_HeliodCombo_WR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",22),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck24_noesmitipo_Belcher_URG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",23),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Conorman11_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",24),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck26_5cBloodmoon_OmnathSaheeli_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",25),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(OmnathSaheeli),
                null
            );
        }

        [Test]
        public void Deck27_FalcoLombardi_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",26),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck28_pedrogush_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",27),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck29_Bedell_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",28),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck30_max09_AdNauseam_WUB()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",29),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck31_PieGonti_Belcher_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",30),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck32_gazurmah_IzzetControl_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",31),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck33_Pintogeddon2_Belcher_URG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",32),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck34_Xwhale_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",33),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck35_palem_Burn_WR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",34),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck36_Foxantes_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",35),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck37_twinlesstwin_MarduMidrange_WBR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",36),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck38_FreedMania_AmuletTitan_G()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",37),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck39_SKK_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",38),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck40_Callad0_HeliodCombo_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",39),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck41_Mogged_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",40),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(OboshAggro),
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck42_evange_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",41),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck43_sonsojf_HeliodCombo_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",42),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck44_BaronOfBacon_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",43),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck45_fluffywolf2_PyroPrison_R()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",44),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(PyroPrison),
                null,
                null
            );
        }

        [Test]
        public void Deck46_SknerusMcKwacz_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",45),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck47_kaktusowysmok_Goblins_BR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",46),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck48_ReanimatorFiend_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",47),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck49_DmZB_GiftsStorm_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",48),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck50_tbrantl99_AdNauseam_WUB()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",49),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck51_starfall_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",50),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck52_didoguidotti1_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",51),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck53_thecodyhope_Elementals_WUBRG_Kaheera()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",52),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                ArchetypeCompanion.Kaheera
            );
        }

        [Test]
        public void Deck54_SamM_Spirits_WU()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",53),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck55_jacopo88_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",54),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck56_armstrong36_Dredge_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",55),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck57_OffbeatHero_MonoWhiteTaxes_W_Yorion()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",56),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck58_Moonsault37_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",57),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck59_SonicK_Belcher_URG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",58),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck60_aps_ThopterUrza_WU()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",59),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck61_grinderA_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",60),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck62_BetterthanAverage_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",61),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(OboshAggro),
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck63_wild88plk_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",62),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck64_RnB_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",63),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(OboshAggro),
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck65_A22en_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",64),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck66_djbmppwns_HeliodCombo_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",65),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck67_do0mswitch_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",66),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck68_tarrasque1_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",67),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck69_musasabi_MarduMidrange_WBR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",68),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck70_Sciakimika_AmuletTitan_G()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",69),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck71_dynamisskill_HeliodCombo_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",70),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck72_GrilledCheese_AmuletTitan_G()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",71),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck73_TheWillHallExp_MarduMidrange_WBR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",72),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck74_NAKISHIMA_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",73),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck75_ThreeThreeElk_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",74),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck76_ShutoShotokan_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",75),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck77_Vad3r_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",76),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck78_MadMaxErnst_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",77),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck79_TheEnduringIdealist_Belcher_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",78),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck80_solaec0501_PrimevalTitan_UG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",79),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck81_FromTheCrypt_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",80),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck82_badluckbandit_HeliodCombo_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",81),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck83_INickStrad_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",82),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck84_JoaoAndrade_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",83),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck85_Kuhb_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",84),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck86_ridetheiguana_RakdosMidrange_BR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",85),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck87_mikeleee_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",86),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck88_rorschach_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",87),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck89_powery_HeliodCombo_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",88),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck90_LMAOMOBILE_RakdosMidrange_BR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",89),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck91_adriaferrer_SultaiControl_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",90),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck92_Shatun_RakdosMidrange_BR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",91),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck93_OnThePlay_RakdosMidrange_BR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",92),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck94_SimoCr_GreenTron_G()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",93),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck95_LaParkita_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",94),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck96_Bodybag_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",95),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck97_thinenagooyen_TitanShift_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",96),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck98_Traft_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",97),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck99_SebastianStueckl_HeliodCombo_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",98),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck100_bwheezy_JeskaiControl_WUR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",99),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck101_ElYallo_HeliodCombo_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",100),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck102_Frutuoso_OrzhovMidrange_WB()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",101),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck103_LSN_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",102),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck104_DaniMRebel_Spirits_WU()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",103),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck105_MaxCapone_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",104),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck106_ReinardBR_GreenTron_G()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",105),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck107_MissTrigger_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",106),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck108_bucknasty691989_RakdosMidrange_BR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",107),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck109_mac121711_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",108),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck110_Hollardustin_JeskaiControl_WUR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",109),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck111_cptobvious343_IzzetControl_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",110),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck112_MandrillMan_HeliodCombo_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",111),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck113_Jositoshekel_HeliodCombo_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",112),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck114_paucr5_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",113),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck115_ChildoftheSand_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",114),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck116_DavidLeChiffre_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",115),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck117_Nerikis_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",116),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck118_Costola91_HeliodCombo_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",117),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck119_nsroller_HeliodCombo_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",118),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck120_DuHeng_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",119),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck121_Alexmcl88_AmuletTitan_G()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",120),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck122_patxi_DimirControl_UB()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",121),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck123_Elfkid_Dredge_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",122),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck124_spiderspace_Belcher_URG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",123),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck125_xf13rc3byerly_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",124),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck126_jenara19_GreenTron_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",125),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck127_claydawson_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",126),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck128_indianpancake_SultaiControl_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",127),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck129_Broccoliasaurus_MarduMidrange_WBR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",128),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck130_bolov0_MarduMidrange_WBR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",129),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck131_HenryAmbrogius_GiftsStorm_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",130),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck132_Draconic1_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",131),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck133_Bloodlights_DimirControl_UB()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",132),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck134_bigb3n_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",133),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck135_christopdeck_Burn_WRG_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",134),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(RedAggro),
                typeof(Burn),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck136_aedrew_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",135),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck137_kolbej_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",136),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck138_bozokaboy_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",137),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck139_mikepick7_Burn_WR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",138),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck140_LucasG1ggs_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",139),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck141_diem4x_SultaiControl_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",140),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck142_meanfannypack_HeliodCombo_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",141),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck143_Batutinha_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",142),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck144_FerMTG_RakdosMidrange_BR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",143),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck145_Cobstrike_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",144),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck146_boulderelf_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",145),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(OboshAggro),
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck147_ATGerwaz_SultaiControl_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",146),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck148_Aeriensol_SultaiControl_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",147),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck149_rafusfito_AdNauseam_WUB()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",148),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck150_delverniv_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",149),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck151_cntrlfreak_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",150),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck152_w1vern_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",151),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck153_lipingpong_Burn_WR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",152),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck154_magicviking_BantBlink_WUG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",153),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck155_Firewalker89_GrixisShadow_UBR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",154),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck156_Sprouts_HammerTime_WR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",155),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(HammerTime),
                null,
                null
            );
        }

        [Test]
        public void Deck157_Sods_GreenTron_G()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",156),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck158_Gigy_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",157),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck159_HouseOfManaMTG_AmuletTitan_G()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",158),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck160_TwistedWombat_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",159),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck161_albertosd_WBRGShadow_WBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",160),
                new PostZendikarRising(),
                ArchetypeColor.WBRG,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck162_Aluren85_Scapeshift_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",161),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck163_marcofabrizi_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",162),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck164_anderlizarrakoa_DimirControl_UB()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",163),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck165_matyo804_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",164),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck166_teske_AzoriusControl_WU()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",165),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck167_Tykos_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",166),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck168_schnda_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",167),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck169_mistakenn_AmuletTitan_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",168),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck170_Krikles_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",169),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(OboshAggro),
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck171_NJGB1_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",170),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck172_guispiller_GiftsStorm_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",171),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck173_ACG88_GreenTron_G()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",172),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck174_NightKnight131_HeliodCombo_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",173),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck175_DcNo_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",174),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck176_TeamGreed_Dredge_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",175),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck177_JUJUBEAN2004_HeliodCombo_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",176),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck178_Aeolus1295_AmuletTitan_G()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",177),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck179_ShowTime_RakdosMidrange_BR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",178),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck180_MrRaeb_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",179),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck181_Joshicallsmefabo_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",180),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck182_Shadowz2005_MarduMidrange_WBR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",181),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck183_kingfroik_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",182),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck184_sam555101_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",183),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck185_Takeno_PyroPrison_R()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",184),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(PyroPrison),
                null,
                null
            );
        }

        [Test]
        public void Deck186_easymoneymarksman_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",185),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck187_sharkcastermage_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",186),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck188_Koso_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",187),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck189_Capipf95_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",188),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck190_nothingnamed_GreenTron_G()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",189),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck191_Cabz_Burn_WR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",190),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck192_MartinezDP_OmnathSaheeli_WURG_Yorion()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",191),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(OmnathSaheeli),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck193_Frankdog_Goblins_BR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",192),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck194_WhiteFaces_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",193),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck195_LuisMj_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",194),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck196_DenmarkDan_AzoriusControl_WU()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",195),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck197_Bomberboss_MarduMidrange_WBR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",196),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck198_NathanLipetz_RakdosMidrange_BR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",197),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck199_magma728_AdNauseam_WUB()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",198),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck200_bamzing_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",199),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck201_Rosencrantz920_AmuletTitan_G()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",200),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck202_blavantasian_AdNauseam_WUB()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",201),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck203_tylerjjobrien_RakdosMidrange_BR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",202),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck204_TwitchAwP_AdNauseam_WUB()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",203),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck205_Pietrone10_Infect_UG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",204),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck206_albert62_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",205),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck207_Geme_GreenTron_G()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",206),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck208_Stompy45_MarduMidrange_WBR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",207),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck209_ballestin93_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",208),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck210_MagicMichiel_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",209),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck211_Kauri_HardenedScales_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",210),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck212_Kyro4_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",211),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck213_kronos23_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",212),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck214_lsmguys_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",213),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck215_ninomtg_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",214),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck216_zaferus_Burn_WR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",215),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck217_ouranos139_AmuletTitan_G()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",216),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck218_AlabasterWolfie_ShadowProwess_UBRG_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",217),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck219_Ruizthebeast_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",218),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck220_remf_Spirits_WU()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",219),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck221_Iceman76_Goblins_BR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",220),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck222_APandaWithOneLeg_GreenTron_G_Jegantha()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",221),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck223_Kirkinator_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",222),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(OboshAggro),
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck224_Camero_Belcher_URG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",223),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck225_ncowden_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",224),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck226_Fenrir303_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",225),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck227_SamuelGraebner_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",226),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck228_3HaLeX1_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",227),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck229_alasan922_BantMidrange_WUG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",228),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck230_yumad3988_PrimevalTitan_UG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",229),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck231_Hexdrinker9_NayaMidrange_WRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",230),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck232_therf_JeskaiControl_WUR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",231),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck233_adamwasmo_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",232),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck234_Laplasjan_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",233),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck235_Marinex_Dredge_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",234),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck236_antus94_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",235),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck237_KBTMTG_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",236),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck238_zecarlonxo_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",237),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(OboshAggro),
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck239_SacmenFeg_Burn_WR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",238),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck240_Halobender_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",239),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck241_pepeteam_SultaiControl_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",240),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck242_Nammersquats_Infect_UG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",241),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck243_jackchurch1996_MarduMidrange_WBR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",242),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck244_Whitco02_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",243),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck245_Bayesta93_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",244),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck246_carletao_IzzetControl_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",245),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck247_d00mwake_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",246),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(RedAggro),
                typeof(Prowess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck248_Karatedom_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",247),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(RedAggro),
                typeof(Prowess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck249_BSKhercules_SultaiControl_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",248),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck250_Wtnof_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",249),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck251_Fenruscloud_Infect_BG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",250),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck252_vfras96_Rogues_UB_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",251),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Rogues),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck253_WhiTeTsaR_SultaiControl_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",252),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck254_Kr0k39_GiftsStorm_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",253),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck255_travis8427_Infect_UG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",254),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck256_spokes_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",255),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck257_iaky91_AdNauseam_WUB()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",256),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck258_Luks_ThopterUrza_UBR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",257),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck259_SouthernSliver_Slivers_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",258),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Slivers),
                null,
                null
            );
        }

        [Test]
        public void Deck260_energiza_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",259),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck261_SweetIto_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",260),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck262_weishengzhishabi_SultaiControl_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",261),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck263_pokerswizard_Spirits_WU()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",262),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck264_toondoslav_Infect_UG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",263),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck265_miqa_ElectroEnd_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",264),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(FreeSpells),
                typeof(ElectroEnd),
                null
            );
        }

        [Test]
        public void Deck266_dhawk50_Burn_WR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",265),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck267_crazeejakee07_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",266),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck268_1yo2yo_ThopterUrza_WUB()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",267),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck269_LiturgijskaKnjiga_Bogles_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",268),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck270_DirtyRowdyBoy_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",269),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck271_Daking3603_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",270),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck272_jdmoyer17_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",271),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck273_ArchaeusDota_Uroza_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",272),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck274_Drockafeller_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",273),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck275_Tw33Ty_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",274),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck276_ziofrancone_AscendancyCombo_WURG_Jegantha()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",275),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(AscendancyCombo),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck277_Noix11_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",276),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck278_TheJigIsAlwaysUp_HeliodCombo_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",277),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck279_FingersMLD_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",278),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck280_tzirkel_HeliodCombo_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",279),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck281_BMJ_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",280),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(RedAggro),
                typeof(Prowess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck282_cftsoc3_BantBlink_WUG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",281),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck283_MickeyPlaysMagic_MarduMidrange_WBR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",282),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck284_SakingMTG_GreenTron_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",283),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck285_fpawlusz_AmuletTitan_G()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",284),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck286_joker10289_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",285),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck287_whitefangshinobi_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",286),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck288_jay44bab_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",287),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck289_Dafne17_MonoRedProwess_R()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",288),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck290_MdvWin_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",289),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck291_mrichi_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",290),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck292_kevilynn_Spirits_WUG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",291),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck293_Sherwinator_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",292),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck294_abisbocci_GrixisShadow_UBR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",293),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck295_Manakin_HardenedScales_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",294),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck296_Nilsfit_AscendancyCombo_WURG_Jegantha()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",295),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(AscendancyCombo),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck297_NGFCMark_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",296),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck298_ecobaronen_TitanShift_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2020-12-31",297),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }


    }
}

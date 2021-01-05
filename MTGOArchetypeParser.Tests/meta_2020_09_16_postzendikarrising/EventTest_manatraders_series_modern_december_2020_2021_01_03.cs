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
#02 HannoLee: KGC Tron (G)
#03 _IlNano_: Shadow Prowess (BR, Lurrus)
#04 Gerardo94: WURG Control (WURG)
#05 coert: Heliod Combo (WG)
#06 VilaCelta: Ad Nauseam (WUB)
#07 GobFTW: Temur Control (URG)
#08 Harry13: Sultai Control (UBG)
#09 Lord_of_puntlantis: Izzet Restore Balance (UR)
#10 Theo_Jung: Heliod Combo (WG)
#11 LLegend: Izzet Restore Balance (UR)
#12 mlgb92: Bant Midrange (WUG)
#13 wzybang: KGC Amulet Titan (G)
#14 HypnoticaL: Shadow Prowess (BR, Lurrus)
#15 Bordas99: Dredge (BRG)
#16 nbdf: Dredge (BRG)
#17 B1gDan: Shadow Prowess (BR, Lurrus)
#18 Ekeross: Shadow Prowess (BR, Lurrus)
#19 graciasportanto: Sultai Control (UBG)
#20 wordy333: Izzet Prowess (UR)
#21 Olivetti: WURG Control (WURG)
#22 carloswylde: KGC Tron (G)
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
#36 Foxantes: Oops All Spells (WUBG)
#37 twinlesstwin: Mardu Midrange (WBR)
#38 FreedMania: KGC Amulet Titan (G)
#39 SKK: Reclaimer Titan (WRG)
#40 Callad0: Heliod Combo (WG)
#41 Mogged: Obosh Aggro (R, Obosh)
#42 evange_: Izzet Prowess (UR)
#43 sonso jf: Heliod Combo (WG)
#44 BaronOfBacon: Shadow Prowess (BR, Lurrus)
#45 fluffywolf2: Red Prison (R)
#46 SknerusMcKwacz: WURG Control (WURG)
#47 kaktusowysmok: Snoop Goblins (BR)
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
#67 V3rve: Shadow Prowess (BRG, Lurrus)
#68 do0mswitch: WURG Control (WURG)
#69 tarrasque1: Mono White Taxes (W)
#70 musasabi: Mardu Midrange (WBR)
#71 Sciakimika: KGC Amulet Titan (G)
#72 dynamisskill: Heliod Combo (WG)
#73 GrilledCheese: KGC Amulet Titan (G)
#74 TheWillHallExp: Mardu Midrange (WBR)
#75 NAKISHIMA: Oops All Spells (WUBG)
#76 ThreeThreeElk: Reclaimer Titan (WG)
#77 ShutoShotokan: Humans (WUBRG)
#78 Vad3r: Niv To Light (WUBRG, Yorion)
#79 MadMaxErnst: WURG Control (WURG)
#80 TheEnduringIdealist: Belcher (WRG)
#81 solaec0501: Primeval Titan (UG)
#82 FromTheCrypt: E Tron (C)
#83 badluckbandit: Heliod Combo (WG)
#84 the302storm: Bant Control (WUG)
#85 INickStrad: WURG Control (WURG)
#86 Joao_Andrade: WURG Control (WURG)
#87 Kuhb: Hammer Time (WB, Lurrus)
#88 ridetheiguana: Rakdos Midrange (BR)
#89 mikeleee: Shadow Prowess (BR, Lurrus)
#90 rorschach-: WURG Control (WURG)
#91 powery: Heliod Combo (WG)
#92 LMAOMOBILE: Rakdos Midrange (BR)
#93 adriaferrer: Sultai Control (UBG)
#94 _Shatun_: Rakdos Midrange (BR)
#95 On-The-Play: Rakdos Midrange (BR)
#96 SimoCr: KGC Tron (G)
#97 La_Parkita: Izzet Prowess (UR)
#98 GlimpseOfRandomness: Sultai Control (UBG)
#99 Bodybag: Shadow Prowess (BR, Lurrus)
#100 thinenagooyen: Titan Shift (RG)
#101 Traft: WURG Control (WURG)
#102 SebastianStueckl: Heliod Combo (WG)
#103 bwheezy: Jeskai Control (WUR)
#104 ElYallo: Heliod Combo (WG)
#105 Frutuoso: Orzhov Midrange (WB)
#106 _LSN_: Burn (WR, Lurrus)
#107 DaniMRebel: Spirits (WU)
#108 MaxCapone: Oops All Spells (WUBG)
#109 ReinardBR: KGC Tron (G)
#110 MissTrigger: Izzet Prowess (UR)
#111 bucknasty691989: Rakdos Midrange (BR)
#112 mac121711: WURG Control (WURG)
#113 Hollardustin: Jeskai Control (WUR)
#114 cptobvious343: Izzet Control (UR)
#115 MandrillMan: Heliod Combo (WG)
#116 Jositoshekel: Heliod Combo (WG)
#117 paucr5: E Tron (C)
#118 Child_oftheSand: Mono White Taxes (W)
#119 DavidLeChiffre: Humans (WUBRG)
#120 Ne-rik-is: Mono White Taxes (W)
#121 Costola91: Heliod Combo (WG)
#122 nsroller: Heliod Combo (WG)
#123 DuHeng: Shadow Prowess (BR, Lurrus)
#124 Alexmcl88: Amulet Titan (G)
#125 patxi: Dimir Control (UB)
#126 Elfkid: Dredge (BRG)
#127 spiderspace: Belcher (URG)
#128 xf13rc3byerly: Shadow Prowess (BR, Lurrus)
#129 jenara19: KGC Tron (G)
#130 claydawson: Izzet Prowess (UR)
#131 indianpancake: Sultai Control (UBG)
#132 Broccoliasaurus: Rakdos Midrange (BR)
#133 bolov0: Mardu Midrange (WBR)
#134 HenryAmbrogius: Gifts Storm (UR)
#135 Draconic1: Reclaimer Titan (WG)
#136 Bloodlights: Dimir Control (UB)
#137 bigb3n: WURG Control (WURG)
#138 christopdeck: Burn (WR, Lurrus)
#139 aedrew: Humans (WUBRG)
#140 kolbej: WURG Control (WURG)
#141 bozokaboy: Oops All Spells (WUBG)
#142 mikepick7: Burn (WR)
#143 LucasG1ggs: E Tron (C)
#144 diem4x: Sultai Control (UBG)
#145 meanfannypack: Heliod Combo (WG)
#146 _Batutinha_: Reclaimer Titan (WRG)
#147 FerMTG: Rakdos Midrange (BR)
#148 Cobstrike: Reclaimer Titan (WRG)
#149 boulderelf: Obosh Aggro (R, Obosh)
#150 papporockentucara: Heliod Combo (WG)
#151 ATGerwaz: Sultai Control (UBG)
#152 Aerien_sol: Sultai Control (UBG)
#153 rafusfito: Ad Nauseam (WUB)
#154 delverniv: Izzet Prowess (UR)
#155 cntrlfreak: Shadow Prowess (BR, Lurrus)
#156 w1vern: Shadow Prowess (BR, Lurrus)
#157 lipingpong: Burn (WR)
#158 magic_viking: Bant Blink (WUG)
#159 Firewalker89: Grixis Shadow (UBR)
#160 Sprouts: Hammer Time (WR)
#161 Sods: KGC Tron (G)
#162 Gigy: Shadow Prowess (BR, Lurrus)
#163 HouseOfManaMTG: KGC Amulet Titan (G)
#164 TwistedWombat: Izzet Prowess (UR)
#165 albertosd: WBRG Shadow (WBRG)
#166 Aluren85: Scapeshift (WURG)
#167 CordoTwin: Shadow Prowess (BR, Lurrus)
#168 marcofabrizi: Shadow Prowess (BR, Lurrus)
#169 ander_lizarrakoa: Dimir Control (UB)
#170 matyo804: Reclaimer Titan (WG)
#171 teske: Azorius Control (WU)
#172 Tykos: Hammer Time (WB, Lurrus)
#173 schnda: WURG Control (WURG)
#174 KarnageKardsENT: Ad Nauseam (WUB)
#175 mistakenn: Amulet Titan (RG)
#176 Krikles: Obosh Aggro (R, Obosh)
#177 NJGB1: UBRG Shadow (UBRG)
#178 guispiller: Gifts Storm (UR)
#179 ACG88: KGC Tron (G)
#180 NightKnight131: Heliod Combo (WG)
#181 DcNo: Humans (WUBRG)
#182 TeamGreed: Dredge (BRG)
#183 JUJUBEAN__2004: Heliod Combo (WG)
#184 Aeolus1295: KGC Amulet Titan (G)
#185 ShowTime_: Rakdos Midrange (BR)
#186 MrRaeb: WURG Control (WURG)
#187 Joshicallsmefabo: Shadow Prowess (BR, Lurrus)
#188 Shadowz2005: Mardu Midrange (WBR)
#189 kingfroik: Shadow Prowess (BR, Lurrus)
#190 sam555101: Izzet Prowess (UR)
#191 _Takeno_: Red Prison (R)
#192 easymoneymarksman: Shadow Prowess (BR, Lurrus)
#193 sharkcaster_mage: Humans (WUBRG)
#194 Koso: Shadow Prowess (BR, Lurrus)
#195 Capipf95: Burn (WR, Lurrus)
#196 nothingnamed: KGC Tron (G)
#197 Cabz: Burn (WR)
#198 MartinezDP: Omnath Saheeli (WURG, Yorion)
#199 Frankdog: Snoop Goblins (BR)
#200 WhiteFaces: Hammer Time (W, Lurrus)
#201 LuisMj: WURG Control (WURG)
#202 Denmark_Dan: Azorius Control (WU)
#203 Bomberboss: Mardu Midrange (WBR)
#204 NathanLipetz: Rakdos Midrange (BR)
#205 magma728: Ad Nauseam (WUB)
#206 bamzing: WURG Control (WURG)
#207 Rosencrantz_920: KGC Amulet Titan (G)
#208 blavantasian: Ad Nauseam (WUB)
#209 tylerjjobrien: Rakdos Midrange (BR)
#210 Fink64: Infect (BG)
#211 TwitchAwP: Ad Nauseam (WUB)
#212 Pietrone10: Infect (UG)
#213 albert62: WURG Control (WURG)
#214 Geme: KGC Tron (G)
#215 Stompy45: Mardu Midrange (WBR)
#216 ballestin93: WURG Control (WURG)
#217 MagicMichiel: Shadow Prowess (BR, Lurrus)
#218 Kauri: Hardened Scales (RG)
#219 Kyro4: Shadow Prowess (BR, Lurrus)
#220 kronos23: E Tron (C)
#221 lsmguys: WURG Control (WURG)
#222 Kenzaburo: WURG Control (WURG)
#223 ninomtg: Shadow Prowess (BR, Lurrus)
#224 zaferus: Burn (WR)
#225 ouranos139: Amulet Titan (G)
#226 AlabasterWolfie: Shadow Prowess (UBRG, Lurrus)
#227 Ruizthebeast: Devoted (WG, Lurrus)
#228 remf: Spirits (WU)
#229 Iceman76: Snoop Goblins (BR)
#230 APandaWithOneLeg: KGC Tron (G, Jegantha)
#231 Kirkinator: Obosh Aggro (R, Obosh)
#232 Camero: Belcher (URG)
#233 ncowden: WURG Control (WURG)
#234 Fenrir303: Hammer Time (WB, Lurrus)
#235 SamuelGraebner: WURG Control (WURG)
#236 3HaLeX1: Izzet Prowess (UR)
#237 alasan922: Bant Midrange (WUG)
#238 yumad3988: Primeval Titan (UG)
#239 Hexdrinker9: Naya Midrange (WRG)
#240 therf: Jeskai Control (WUR)
#241 adamwasmo: Oops All Spells (UBRG)
#242 Laplasjan: Hammer Time (WB, Lurrus)
#243 Marinex: Dredge (BRG)
#244 Wede97: Snoop Goblins (BR)
#245 antus94: Shadow Prowess (BRG, Lurrus)
#246 KBTMTG: E Tron (C)
#247 zecarlonxo: Obosh Aggro (R, Obosh)
#248 SacmenFeg: Burn (WR)
#249 Halobender: Izzet Prowess (UR)
#250 pepeteam: Sultai Control (UBG)
#251 Nammersquats: Infect (UG)
#252 Frejat: Rakdos Midrange (BR)
#253 jackchurch1996: Mardu Midrange (WBR)
#254 Whitco02: Izzet Prowess (UR)
#255 Bayesta_93: Shadow Prowess (BR, Lurrus)
#256 carletao: Izzet Control (UR)
#257 d00mwake: Rakdos Prowess (BR, Lurrus)
#258 Karatedom: Rakdos Prowess (BR, Lurrus)
#259 WeareVenom: WURG Control (WURG)
#260 BSK_hercules: Sultai Control (UBG)
#261 Wtnof: Oops All Spells (WUBG)
#262 Fenruscloud: Infect (BG)
#263 vfras96: Rogues (UB, Lurrus)
#264 WhiTe TsaR: Sultai Control (UBG)
#265 Kr0k39: Gifts Storm (UR)
#266 TuggaNaxos: WURG Control (WURG)
#267 travis8427: Infect (UG)
#268 spokes: Oops All Spells (WUBG)
#269 iaky91: Ad Nauseam (WUB)
#270 _Luks: Thopter Urza (UBR)
#271 SouthernSliver: Slivers (WUBRG)
#272 energiza: Humans (WUBRG)
#273 SweetIto: Shadow Prowess (BR, Lurrus)
#274 weishengzhishabi: Sultai Control (UBG)
#275 pokerswizard: Spirits (WU)
#276 toondoslav: Infect (UG)
#277 miqa: Izzet Living End (UR)
#278 dhawk50: Burn (WR)
#279 crazeejakee07: WURG Control (WURG)
#280 1yo2yo: Thopter Urza (WUB)
#281 LiturgijskaKnjiga: Bogles (WG)
#282 DirtyRowdyBoy: WURG Control (WURG)
#283 Daking3603: Reclaimer Titan (WRG)
#284 jdmoyer17: Mill (UB, Lurrus)
#285 ArchaeusDota: Uroza (WUBRG)
#286 Drockafeller: WURG Control (WURG)
#287 Tw33Ty: Shadow Prowess (BR, Lurrus)
#288 ziofrancone: Jeskai Breach (WURG, Jegantha)
#289 Noix11: Humans (WUBRG)
#290 TheJigIsAlwaysUp: Heliod Combo (WG)
#291 Mateusf34: E Tron (C)
#292 FingersMLD: Mono White Taxes (W)
#293 tzirkel: Heliod Combo (WG)
#294 __BMJ__: Rakdos Prowess (BR, Lurrus)
#295 cftsoc3: Bant Blink (WUG)
#296 MickeyPlaysMagic: Rakdos Midrange (BR)
#297 SakingMTG: KGC Tron (G)
#298 fpawlusz: KGC Amulet Titan (G)
#299 joker10289: Reclaimer Titan (WG)
#300 whitefangshinobi: Izzet Prowess (UR)
#301 jay44bab: Shadow Prowess (BR, Lurrus)
#302 Dafne17: Mono Red Prowess (R)
#303 MdvWin: Hammer Time (W, Lurrus)
#304 mrichi: WURG Control (WURG)
#305 kevilynn: Bant Spirits (WUG)
#306 Sherwinator: Mill (UB, Lurrus)
#307 cypriankrzysztof: Heliod Combo (WG)
#308 abisbocci: Grixis Shadow (UBR)
#309 Manakin: Hardened Scales (RG)
#310 Nilsfit: Jeskai Breach (WUR, Jegantha)
#311 NGFC_Mark: Oops All Spells (WUBG)
#312 ecobaronen: Titan Shift (RG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_manatraders_series_modern_december_2020_2021_01_03 : EventTest
    {
        [Test]
        public void Deck01_PhillHellmuth_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",0),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_HannoLee_KGCTron_G()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",1),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GreenTron),
                null,
                null
            );
        }

        [Test]
        public void Deck03_IlNano_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",2),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_Gerardo94_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",3),
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
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",4),
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
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",5),
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
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",6),
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
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",7),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Lordofpuntlantis_IzzetRestoreBalance_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",8),
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
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",9),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck11_LLegend_IzzetRestoreBalance_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",10),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(FreeSpells),
                typeof(ElectroBalance),
                null
            );
        }

        [Test]
        public void Deck12_mlgb92_BantMidrange_WUG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",11),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck13_wzybang_KGCAmuletTitan_G()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",12),
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
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",13),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck15_Bordas99_Dredge_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",14),
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
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",15),
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
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",16),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_Ekeross_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",17),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck19_graciasportanto_SultaiControl_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",18),
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
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",19),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck21_Olivetti_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",20),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck22_carloswylde_KGCTron_G()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",21),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GreenTron),
                null,
                null
            );
        }

        [Test]
        public void Deck23_NHA37_HeliodCombo_WR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",22),
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
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",23),
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
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",24),
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
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",25),
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
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",26),
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
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",27),
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
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",28),
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
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",29),
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
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",30),
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
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",31),
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
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",32),
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
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",33),
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
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",34),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck36_Foxantes_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",35),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck37_twinlesstwin_MarduMidrange_WBR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",36),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck38_FreedMania_KGCAmuletTitan_G()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",37),
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
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",38),
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
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",39),
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
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",40),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck42_evange_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",41),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck43_sonsojf_HeliodCombo_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",42),
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
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",43),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck45_fluffywolf2_RedPrison_R()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",44),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(RedPrison),
                null,
                null
            );
        }

        [Test]
        public void Deck46_SknerusMcKwacz_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",45),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck47_kaktusowysmok_SnoopGoblins_BR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",46),
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
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",47),
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
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",48),
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
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",49),
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
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",50),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck52_didoguidotti1_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",51),
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
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",52),
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
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",53),
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
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",54),
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
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",55),
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
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",56),
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
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",57),
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
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",58),
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
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",59),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck61_grinderA_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",60),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck62_BetterthanAverage_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",61),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck63_wild88plk_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",62),
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
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",63),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck65_A22en_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",64),
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
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",65),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck67_V3rve_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",66),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck68_do0mswitch_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",67),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck69_tarrasque1_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",68),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck70_musasabi_MarduMidrange_WBR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",69),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck71_Sciakimika_KGCAmuletTitan_G()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",70),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck72_dynamisskill_HeliodCombo_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",71),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck73_GrilledCheese_KGCAmuletTitan_G()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",72),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck74_TheWillHallExp_MarduMidrange_WBR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",73),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck75_NAKISHIMA_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",74),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck76_ThreeThreeElk_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",75),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck77_ShutoShotokan_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",76),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck78_Vad3r_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",77),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck79_MadMaxErnst_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",78),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck80_TheEnduringIdealist_Belcher_WRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",79),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck81_solaec0501_PrimevalTitan_UG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",80),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck82_FromTheCrypt_ETron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",81),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(EldraziTron),
                null,
                null
            );
        }

        [Test]
        public void Deck83_badluckbandit_HeliodCombo_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",82),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck84_the302storm_BantControl_WUG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",83),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck85_INickStrad_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",84),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck86_JoaoAndrade_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",85),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck87_Kuhb_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",86),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck88_ridetheiguana_RakdosMidrange_BR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",87),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck89_mikeleee_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",88),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck90_rorschach_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",89),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck91_powery_HeliodCombo_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",90),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck92_LMAOMOBILE_RakdosMidrange_BR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",91),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck93_adriaferrer_SultaiControl_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",92),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck94_Shatun_RakdosMidrange_BR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",93),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck95_OnThePlay_RakdosMidrange_BR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",94),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck96_SimoCr_KGCTron_G()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",95),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GreenTron),
                null,
                null
            );
        }

        [Test]
        public void Deck97_LaParkita_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",96),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck98_GlimpseOfRandomness_SultaiControl_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",97),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck99_Bodybag_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",98),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck100_thinenagooyen_TitanShift_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",99),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck101_Traft_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",100),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck102_SebastianStueckl_HeliodCombo_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",101),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck103_bwheezy_JeskaiControl_WUR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",102),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck104_ElYallo_HeliodCombo_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",103),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck105_Frutuoso_OrzhovMidrange_WB()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",104),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck106_LSN_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",105),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck107_DaniMRebel_Spirits_WU()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",106),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck108_MaxCapone_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",107),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck109_ReinardBR_KGCTron_G()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",108),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GreenTron),
                null,
                null
            );
        }

        [Test]
        public void Deck110_MissTrigger_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",109),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck111_bucknasty691989_RakdosMidrange_BR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",110),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck112_mac121711_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",111),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck113_Hollardustin_JeskaiControl_WUR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",112),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck114_cptobvious343_IzzetControl_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",113),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck115_MandrillMan_HeliodCombo_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",114),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck116_Jositoshekel_HeliodCombo_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",115),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck117_paucr5_ETron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",116),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(EldraziTron),
                null,
                null
            );
        }

        [Test]
        public void Deck118_ChildoftheSand_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",117),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck119_DavidLeChiffre_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",118),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck120_Nerikis_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",119),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck121_Costola91_HeliodCombo_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",120),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck122_nsroller_HeliodCombo_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",121),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck123_DuHeng_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",122),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck124_Alexmcl88_AmuletTitan_G()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",123),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck125_patxi_DimirControl_UB()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",124),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck126_Elfkid_Dredge_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",125),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck127_spiderspace_Belcher_URG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",126),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck128_xf13rc3byerly_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",127),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck129_jenara19_KGCTron_G()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",128),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GreenTron),
                null,
                null
            );
        }

        [Test]
        public void Deck130_claydawson_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",129),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck131_indianpancake_SultaiControl_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",130),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck132_Broccoliasaurus_RakdosMidrange_BR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",131),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck133_bolov0_MarduMidrange_WBR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",132),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck134_HenryAmbrogius_GiftsStorm_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",133),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck135_Draconic1_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",134),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck136_Bloodlights_DimirControl_UB()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",135),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck137_bigb3n_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",136),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck138_christopdeck_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",137),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck139_aedrew_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",138),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck140_kolbej_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",139),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck141_bozokaboy_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",140),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck142_mikepick7_Burn_WR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",141),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck143_LucasG1ggs_ETron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",142),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(EldraziTron),
                null,
                null
            );
        }

        [Test]
        public void Deck144_diem4x_SultaiControl_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",143),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck145_meanfannypack_HeliodCombo_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",144),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck146_Batutinha_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",145),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck147_FerMTG_RakdosMidrange_BR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",146),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck148_Cobstrike_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",147),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck149_boulderelf_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",148),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck150_papporockentucara_HeliodCombo_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",149),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck151_ATGerwaz_SultaiControl_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",150),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck152_Aeriensol_SultaiControl_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",151),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck153_rafusfito_AdNauseam_WUB()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",152),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck154_delverniv_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",153),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck155_cntrlfreak_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",154),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck156_w1vern_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",155),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck157_lipingpong_Burn_WR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",156),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck158_magicviking_BantBlink_WUG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",157),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck159_Firewalker89_GrixisShadow_UBR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",158),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck160_Sprouts_HammerTime_WR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",159),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(HammerTime),
                null,
                null
            );
        }

        [Test]
        public void Deck161_Sods_KGCTron_G()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",160),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GreenTron),
                null,
                null
            );
        }

        [Test]
        public void Deck162_Gigy_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",161),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck163_HouseOfManaMTG_KGCAmuletTitan_G()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",162),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck164_TwistedWombat_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",163),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck165_albertosd_WBRGShadow_WBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",164),
                new PostZendikarRising(),
                ArchetypeColor.WBRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck166_Aluren85_Scapeshift_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",165),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck167_CordoTwin_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",166),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck168_marcofabrizi_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",167),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck169_anderlizarrakoa_DimirControl_UB()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",168),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck170_matyo804_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",169),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck171_teske_AzoriusControl_WU()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",170),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck172_Tykos_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",171),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck173_schnda_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",172),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck174_KarnageKardsENT_AdNauseam_WUB()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",173),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck175_mistakenn_AmuletTitan_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",174),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck176_Krikles_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",175),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck177_NJGB1_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",176),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck178_guispiller_GiftsStorm_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",177),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck179_ACG88_KGCTron_G()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",178),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GreenTron),
                null,
                null
            );
        }

        [Test]
        public void Deck180_NightKnight131_HeliodCombo_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",179),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck181_DcNo_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",180),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck182_TeamGreed_Dredge_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",181),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck183_JUJUBEAN2004_HeliodCombo_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",182),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck184_Aeolus1295_KGCAmuletTitan_G()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",183),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck185_ShowTime_RakdosMidrange_BR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",184),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck186_MrRaeb_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",185),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck187_Joshicallsmefabo_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",186),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck188_Shadowz2005_MarduMidrange_WBR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",187),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck189_kingfroik_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",188),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck190_sam555101_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",189),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck191_Takeno_RedPrison_R()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",190),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(RedPrison),
                null,
                null
            );
        }

        [Test]
        public void Deck192_easymoneymarksman_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",191),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck193_sharkcastermage_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",192),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck194_Koso_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",193),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck195_Capipf95_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",194),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck196_nothingnamed_KGCTron_G()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",195),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GreenTron),
                null,
                null
            );
        }

        [Test]
        public void Deck197_Cabz_Burn_WR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",196),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck198_MartinezDP_OmnathSaheeli_WURG_Yorion()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",197),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(OmnathSaheeli),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck199_Frankdog_SnoopGoblins_BR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",198),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck200_WhiteFaces_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",199),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck201_LuisMj_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",200),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck202_DenmarkDan_AzoriusControl_WU()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",201),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck203_Bomberboss_MarduMidrange_WBR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",202),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck204_NathanLipetz_RakdosMidrange_BR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",203),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck205_magma728_AdNauseam_WUB()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",204),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck206_bamzing_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",205),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck207_Rosencrantz920_KGCAmuletTitan_G()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",206),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck208_blavantasian_AdNauseam_WUB()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",207),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck209_tylerjjobrien_RakdosMidrange_BR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",208),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck210_Fink64_Infect_BG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",209),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck211_TwitchAwP_AdNauseam_WUB()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",210),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck212_Pietrone10_Infect_UG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",211),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck213_albert62_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",212),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck214_Geme_KGCTron_G()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",213),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GreenTron),
                null,
                null
            );
        }

        [Test]
        public void Deck215_Stompy45_MarduMidrange_WBR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",214),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck216_ballestin93_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",215),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck217_MagicMichiel_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",216),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck218_Kauri_HardenedScales_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",217),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck219_Kyro4_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",218),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck220_kronos23_ETron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",219),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(EldraziTron),
                null,
                null
            );
        }

        [Test]
        public void Deck221_lsmguys_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",220),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck222_Kenzaburo_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",221),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck223_ninomtg_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",222),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck224_zaferus_Burn_WR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",223),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck225_ouranos139_AmuletTitan_G()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",224),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck226_AlabasterWolfie_ShadowProwess_UBRG_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",225),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck227_Ruizthebeast_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",226),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck228_remf_Spirits_WU()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",227),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck229_Iceman76_SnoopGoblins_BR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",228),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck230_APandaWithOneLeg_KGCTron_G_Jegantha()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",229),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GreenTron),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck231_Kirkinator_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",230),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck232_Camero_Belcher_URG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",231),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck233_ncowden_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",232),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck234_Fenrir303_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",233),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck235_SamuelGraebner_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",234),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck236_3HaLeX1_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",235),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck237_alasan922_BantMidrange_WUG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",236),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck238_yumad3988_PrimevalTitan_UG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",237),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck239_Hexdrinker9_NayaMidrange_WRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",238),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck240_therf_JeskaiControl_WUR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",239),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck241_adamwasmo_OopsAllSpells_UBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",240),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck242_Laplasjan_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",241),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck243_Marinex_Dredge_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",242),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck244_Wede97_SnoopGoblins_BR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",243),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck245_antus94_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",244),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck246_KBTMTG_ETron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",245),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(EldraziTron),
                null,
                null
            );
        }

        [Test]
        public void Deck247_zecarlonxo_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",246),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck248_SacmenFeg_Burn_WR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",247),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck249_Halobender_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",248),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck250_pepeteam_SultaiControl_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",249),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck251_Nammersquats_Infect_UG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",250),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck252_Frejat_RakdosMidrange_BR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",251),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck253_jackchurch1996_MarduMidrange_WBR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",252),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck254_Whitco02_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",253),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck255_Bayesta93_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",254),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck256_carletao_IzzetControl_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",255),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck257_d00mwake_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",256),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck258_Karatedom_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",257),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck259_WeareVenom_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",258),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck260_BSKhercules_SultaiControl_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",259),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck261_Wtnof_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",260),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck262_Fenruscloud_Infect_BG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",261),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck263_vfras96_Rogues_UB_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",262),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Rogues),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck264_WhiTeTsaR_SultaiControl_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",263),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck265_Kr0k39_GiftsStorm_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",264),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck266_TuggaNaxos_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",265),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck267_travis8427_Infect_UG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",266),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck268_spokes_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",267),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck269_iaky91_AdNauseam_WUB()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",268),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck270_Luks_ThopterUrza_UBR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",269),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck271_SouthernSliver_Slivers_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",270),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Slivers),
                null,
                null
            );
        }

        [Test]
        public void Deck272_energiza_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",271),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck273_SweetIto_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",272),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck274_weishengzhishabi_SultaiControl_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",273),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck275_pokerswizard_Spirits_WU()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",274),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck276_toondoslav_Infect_UG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",275),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck277_miqa_IzzetLivingEnd_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",276),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(FreeSpells),
                typeof(ElectroEnd),
                null
            );
        }

        [Test]
        public void Deck278_dhawk50_Burn_WR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",277),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck279_crazeejakee07_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",278),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck280_1yo2yo_ThopterUrza_WUB()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",279),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck281_LiturgijskaKnjiga_Bogles_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",280),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck282_DirtyRowdyBoy_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",281),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck283_Daking3603_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",282),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck284_jdmoyer17_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",283),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck285_ArchaeusDota_Uroza_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",284),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck286_Drockafeller_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",285),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck287_Tw33Ty_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",286),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck288_ziofrancone_JeskaiBreach_WURG_Jegantha()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",287),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(AscendancyCombo),
                typeof(AscendancyBreach),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck289_Noix11_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",288),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck290_TheJigIsAlwaysUp_HeliodCombo_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",289),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck291_Mateusf34_ETron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",290),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(EldraziTron),
                null,
                null
            );
        }

        [Test]
        public void Deck292_FingersMLD_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",291),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck293_tzirkel_HeliodCombo_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",292),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck294_BMJ_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",293),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck295_cftsoc3_BantBlink_WUG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",294),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck296_MickeyPlaysMagic_RakdosMidrange_BR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",295),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck297_SakingMTG_KGCTron_G()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",296),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GreenTron),
                null,
                null
            );
        }

        [Test]
        public void Deck298_fpawlusz_KGCAmuletTitan_G()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",297),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck299_joker10289_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",298),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck300_whitefangshinobi_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",299),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck301_jay44bab_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",300),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck302_Dafne17_MonoRedProwess_R()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",301),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck303_MdvWin_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",302),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck304_mrichi_WURGControl_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",303),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck305_kevilynn_BantSpirits_WUG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",304),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck306_Sherwinator_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",305),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck307_cypriankrzysztof_HeliodCombo_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",306),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck308_abisbocci_GrixisShadow_UBR()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",307),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck309_Manakin_HardenedScales_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",308),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck310_Nilsfit_JeskaiBreach_WUR_Jegantha()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",309),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(AscendancyCombo),
                typeof(AscendancyBreach),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck311_NGFCMark_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",310),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck312_ecobaronen_TitanShift_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-december-2020-2021-01-03",311),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }


    }
}

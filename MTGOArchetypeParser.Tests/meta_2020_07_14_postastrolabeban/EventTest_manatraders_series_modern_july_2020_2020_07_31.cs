using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 d00mwake: Mardu Prowess (WBR, Lurrus)
#02 nbdf: Dredge (WBRG)
#03 GanYanCHN: Izzet Prowess (UR)
#04 Bedell: Amulet Titan (UG)
#05 Losilla: Scapeshift (URG)
#06 djbmppwns: Gruul Prowess (RG, Jegantha)
#07 JKnecht: UBRG Shadow (UBRG)
#08 Daniel_Garcia: Gruul Prowess (RG, Jegantha)
#09 ConnorM426: Dredge (WBRG)
#10 LLegend: Gruul Midrange (RG)
#11 Caleb_Yetman: Humans (WUBRG)
#12 Skuttlespike: Izzet Prowess (UR)
#13 patxi: Reclamation (URG)
#14 RNGspecialist: Scapeshift (URG)
#15 CNewman: Gruul Midrange (RG)
#16 Themightylinguine: Green Tron (G)
#17 killerp0p0: Izzet Prowess (UR)
#18 cometa183: Azorius Control (WU)
#19 HannoLee: Green Tron (G)
#20 Sprouts: Abzan Midrange (WBG)
#21 ouranos139: Amulet Titan (UG)
#22 MissTrigger: Burn (R)
#23 Cherryxman: Scapeshift (URG)
#24 albert62: Jund Midrange (BRG)
#25 Bodybag: Humans (WUBRG)
#26 VerMahilen: Thalia Stompy (WB)
#27 GodOfSlaughter: Jund Midrange (BRG)
#28 Aluren85: Eldrazi Tron (C)
#29 __BMJ__: UBRG Shadow (UBRG)
#30 Praxifi: Gruul Midrange (RG)
#31 Tw33Ty: Humans (WUBRG)
#32 katoriarch123: Bant Control (WUG)
#33 Thrall90: Jund Midrange (BRG)
#34 Darthkid: Burn (WR)
#35 zachattack23: Bant Control (WUG)
#36 Nammersquats: Izzet Prowess (UR)
#37 grinderA: Burn (WR)
#38 MattJMusic: Burn (R)
#39 SebastianStueckl: Gruul Midrange (RG)
#40 Kuhmero: Burn (WR)
#41 sonso jf: Humans (WUBRG)
#42 L3D91: Eldrazi Tron (C)
#43 Callad0: Izzet Prowess (UR)
#44 YUMAS2: Eldrazi Tron (C)
#45 twinlesstwin: Gruul Midrange (RG)
#46 limp22: Azorius Control (WU)
#47 _Ingles_: Burn (WR)
#48 DreamsOfAshiok: Eldrazi Tron (C)
#49 ScuttoZ: Gruul Midrange (RG)
#50 oosunq: Jund Midrange (BRG)
#51 alicoco: Ad Nauseam (WUBR)
#52 Nilsfit: Reclamation (UBG)
#53 crazeejakee07: Azorius Control (WU)
#54 w1vern: Scapeshift (URG)
#55 antonio00: Gruul Midrange (RG)
#56 Amatox: Bant Blink (WUG)
#57 Mordeka1ser: Niv To Light (WUBRG, Yorion)
#58 karn_90: Sultai Control (UBG)
#59 zecarlonxo: Mono Red Prowess (R)
#60 Dai1412: Izzet Prowess (UR)
#61 kaktusowysmok: Goblins (BR)
#62 NightKnight131: Devoted (WG, Lurrus)
#63 untiltedmtg: Gruul Midrange (RG)
#64 SweetIto: Gruul Midrange (RG)
#65 MadMaxErnst: Sultai Control (UBG)
#66 BSK_hercules: Dredge (WBRG)
#67 goodplayer95: Niv To Light (WUBRG)
#68 _Shatun_: Gruul Midrange (RG)
#69 Curtisaxel: Gruul Midrange (RG)
#70 TatemusPrime: Burn (WR)
#71 matheusponciano: Dredge (UBRG)
#72 mac121711: Jeskai Control (WUR)
#73 Thattaman: Jund Midrange (BRG)
#74 Irra0770: Jund Midrange (BRG)
#75 Iceman76: Amulet Titan (UG)
#76 penach010: Devoted (WRG, Yorion)
#77 Conor_man11: Burn (WR)
#78 Mingueretxo: Eldrazi Tron (C)
#79 BrunoPardini: Jund Midrange (BRG)
#80 halfie44: Jund Midrange (BRG)
#81 Crocodile_MTG: UBRG Shadow (UBRG)
#82 polinasgiuleppe: Izzet Prowess (UR)
#83 Joao_Andrade: Jund Midrange (BRG)
#84 Jitko: Eldrazi Tron (C)
#85 msskinbolic: Izzet Prowess (UR)
#86 r0cknati0n: Sultai Control (UBG)
#87 _Batutinha_: Reclamation (UBRG)
#88 Murager: Gruul Midrange (RG)
#89 mdvayu2: Saheeli Combo (WUR)
#90 EQUITES: Grixis Shadow (UBR)
#91 Noix11: Humans (WUBRG)
#92 jinavie: Azorius Control (WU)
#93 FedeG: Eldrazi Tron (C)
#94 thinenagooyen: Goblins (BR)
#95 osk4: Niv To Light (WUBRG, Yorion)
#96 SknerusMcKwacz: Scapeshift (URG)
#97 Kauri: Hardened Scales (G)
#98 Janh: Saheeli Combo (WUR)
#99 olea: Dredge (WBRG)
#100 iron_maiden_2: Eldrazi Tron (C)
#101 toastxp: Rakdos Prowess (BR, Lurrus)
#102 Darkiundsa: Green Tron (G)
#103 Daking3603: Crabvine (UBG)
#104 omgitztommy: Burn (R)
#105 mrichi: Eldrazi Tron (C)
#106 Tondini: Ad Nauseam (WUB)
#107 DmZB: Gifts Storm (UR)
#108 OrnatePuzzles: Gruul Midrange (RG)
#109 lit_city: Grixis Shadow (UBR)
#110 Frank_Bonaparte: Azorius Control (WU)
#111 mistakenn: Amulet Titan (URG)
#112 kotka: Bogles (WG)
#113 ello_baron: Humans (WUBRG)
#114 RandomOctopus: Reclamation (URG)
#115 Phill_Hellmuth: Jund Midrange (BRG)
#116 SouthernSliver: Slivers (WUBRG)
#117 Joshicallsmefabo: Humans (WUBRG)
#118 Ikthaleon: Azorius Control (WU)
#119 CHILLEDADED: Gruul Midrange (RG)
#120 __palem__: Gruul Midrange (RG)
#121 ack_s: Gruul Midrange (RG)
#122 ImGonnaGoAFK: Eldrazi Tron (C)
#123 maximusdee: Gifts Storm (UR)
#124 magicmiguelGG: Eldrazi Tron (C)
#125 genxim: Ad Nauseam (WUB)
#126 aspiringspike: Sultai Control (UBG)
#127 PascalMaynard: Scapeshift (URG)
#128 faisal: Dredge (WBRG)
#129 slatorade: Bogles (WG)
#130 holyshamgar: Jeskai Control (WUR)
#131 pepeteam: Amulet Titan (UG)
#132 i-am-bad-at-mtg: Jund Midrange (BRG)
#133 RnB: Titan Shift (RG)
#134 ph_crescens: Amulet Titan (URG)
#135 crazyklicker: Devoted (WG, Lurrus)
#136 Patapon20: Eldrazi Tron (C)
#137 zacharee: Devoted (WG, Lurrus)
#138 turnthemsideways: Eldrazi Tron (C)
#139 tuhoajatane: Bant Control (WUG)
#140 GiovaniMF: Jund Shadow (BRG)
#141 BaronOfBacon: UBRG Shadow (UBRG)
#142 chris_concarnage: Eldrazi Tron (C)
#143 ACG88: Titan Shift (RG)
#144 takemini: Azorius Control (WU)
#145 FromTheCrypt: Eldrazi Tron (C)
#146 mikeyoffbeat: Hardened Scales (G)
#147 MaxMagicer: Goblins (BR)
#148 r_monger: Eldrazi Tron (C)
#149 PTarts2win: Gruul Midrange (RG)
#150 sharkcaster_mage: Ad Nauseam (WUB)
#151 fried-liver-attack: Gruul Midrange (RG)
#152 diem4x: Sultai Control (UBG)
#153 thegodmikedevo: Eldrazi Tron (C)
#154 BERNASTORRES: Jund Midrange (BRG)
#155 AluminumMonster: Reclamation (UBG)
#156 CordoTwin: Grixis Shadow (UBR)
#157 CRYPTIC_C4SSIE: Scapeshift (URG)
#158 RealJoy: UBRG Shadow (UBRG)
#159 berckovitz: Eldrazi Tron (C)
#160 Legend_cay: Ad Nauseam (WUB)
#161 Blazed-Ugin: Amulet Titan (UG)
#162 ecobaronen: Azorius Control (WU)
#163 winddragon11: Izzet Prowess (UR)
#164 abisbocci: Grixis Shadow (UBR)
#165 INickStrad: Azorius Control (WU)
#166 graciasportanto: Jund Midrange (BRG)
#167 in5ano: Scapeshift (URG)
#168 heydaniel: Eldrazi Tron (C)
#169 kalko: Gifts Storm (UR)
#170 wolfmedic: Gruul Midrange (RG)
#171 desertdrive: Boros Prowess (WR)
#172 StanLee: Scapeshift (UBRG, Lurrus)
#173 Leonardo1080: Selesnya Eldrazi Taxes (WG)
#174 TheKingFor1000years: Infect (UG)
#175 salvite: Eldrazi Tron (C)
#176 Gabriel0288: Titan Shift (RG)
#177 OnlyLuck: Gruul Midrange (RG)
#178 Sideshowsc: Devoted (WG, Lurrus)
#179 Marxelo: Tokens (WB)
#180 Sam_Kentesber: Izzet Prowess (UR)
#181 ThatAsianGuy8: Jund Midrange (BRG)
#182 Denmark_Dan: Titan Shift (RG)
#183 Ebnus: Gruul Midrange (RG)
#184 Wtnof: Gruul Midrange (RG)
#185 DLCabelo: 5 C Control (WUBRG)
#186 matiaskm: Devoted (WG, Lurrus)
#187 Dfeanor: Titan Shift (RG)
#188 simpleliquid: Gruul Midrange (RG)
#189 lucadaky: Gifts Storm (UR)
#190 MadCowChicken: Green Eldrazi (BG, Jegantha)
#191 MatiCheto: Green Tron (G, Jegantha)
#192 Oscarzr22: Eldrazi Tron (C)
#193 HouseOfManaMTG: Amulet Titan (UG)
#194 Xwhale: Eldrazi Tron (C)
#195 Xenowan: Mono Red Prowess (R, Jegantha)
#196 yamakiller: Saheeli Combo (WUR)
#197 WeareVenom: Azorius Control (WU)
#198 TwitchAwP: Gruul Midrange (RG)
#199 mark_68: Scapeshift (WURG)
#200 CaptainFarbosa: UBRG Shadow (UBRG)
#201 nick4567: Jund Midrange (BRG)
#202 cookiekid00: Goblins (BR)
#203 Theo_Jung: Scapeshift (URG)
#204 BANTE: Eldrazi Tron (C)
#205 andycsoto: Eldrazi Tron (C)
#206 foretweezy1: Goblins (BR)
#207 ArchaeusDota: Green Tron (G)
#208 fradev1988: Electro Balance (URG)
#209 vlaprohor: Eldrazi Tron (C)
#210 PieGonti: Jund Shadow (BRG, Lurrus)
#211 grahams: Crabvine (UBG)
#212 SvenSveeterSven: Izzet Control (UR)
#213 Sherwinator: Grixis Shadow (UBR)
#214 Raptor_Nachos: Mono Red Prowess (R)
#215 Nikito18: Azorius Control (WU)
#216 ShowTime_: Jund Midrange (BRG)
#217 TheTarmogoat: Jeskai Control (WUR, Yorion)
#218 musasabi: Jund Midrange (BRG)
#219 GedionRavenor: Azorius Control (WU)
#220 300: Green Tron (G)
#221 thodoris17: Gruul Midrange (RG)
#222 JarenDunnerr: Burn (WR)
#223 mlgb92: Goblins (BR)
#224 qmcgarry45: Burn (WR)
#225 Gobern: Amulet Titan (UG)
#226 AnarchistAbe: Reclamation (UBG)
#227 tsHunter: Sultai Control (UBG)
#228 e_hawk77: Jund Shadow (BRG, Lurrus)
#229 ScreenwriterNY: Ad Nauseam (WUB)
#230 danielmos: Azorius Control (WU)
#231 Znurvel: Infect (WUG)
#232 doughhater: Thalia Stompy (WR)
#233 iuriper: Bant Control (WUG)
#234 goteo: Gruul Prowess (RG, Jegantha)
#235 beestjes: Gruul Midrange (RG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_manatraders_series_modern_july_2020_2020_07_31 : EventTest
    {
        [Test]
        public void Deck01_d00mwake_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",0),
                "PostAstrolabeBan",
                ArchetypeColor.WBR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_nbdf_Dredge_WBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",1),
                "PostAstrolabeBan",
                ArchetypeColor.WBRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck03_GanYanCHN_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",2),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck04_Bedell_AmuletTitan_UG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",3),
                "PostAstrolabeBan",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck05_Losilla_Scapeshift_URG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",4),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                null
            );
        }

        [Test]
        public void Deck06_djbmppwns_GruulProwess_RG_Jegantha()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",5),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck07_JKnecht_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",6),
                "PostAstrolabeBan",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck08_DanielGarcia_GruulProwess_RG_Jegantha()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",7),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck09_ConnorM426_Dredge_WBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",8),
                "PostAstrolabeBan",
                ArchetypeColor.WBRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck10_LLegend_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",9),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck11_CalebYetman_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",10),
                "PostAstrolabeBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck12_Skuttlespike_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",11),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck13_patxi_Reclamation_URG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",12),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck14_RNGspecialist_Scapeshift_URG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",13),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                null
            );
        }

        [Test]
        public void Deck15_CNewman_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",14),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck16_Themightylinguine_GreenTron_G()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",15),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck17_killerp0p0_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",16),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck18_cometa183_AzoriusControl_WU()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",17),
                "PostAstrolabeBan",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck19_HannoLee_GreenTron_G()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",18),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck20_Sprouts_AbzanMidrange_WBG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",19),
                "PostAstrolabeBan",
                ArchetypeColor.WBG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck21_ouranos139_AmuletTitan_UG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",20),
                "PostAstrolabeBan",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck22_MissTrigger_Burn_R()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",21),
                "PostAstrolabeBan",
                ArchetypeColor.R,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck23_Cherryxman_Scapeshift_URG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",22),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                null
            );
        }

        [Test]
        public void Deck24_albert62_JundMidrange_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",23),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck25_Bodybag_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",24),
                "PostAstrolabeBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck26_VerMahilen_ThaliaStompy_WB()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",25),
                "PostAstrolabeBan",
                ArchetypeColor.WB,
                "Taxes",
                "ThaliaStompy",
                null
            );
        }

        [Test]
        public void Deck27_GodOfSlaughter_JundMidrange_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",26),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck28_Aluren85_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",27),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck29_BMJ_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",28),
                "PostAstrolabeBan",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck30_Praxifi_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",29),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck31_Tw33Ty_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",30),
                "PostAstrolabeBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck32_katoriarch123_BantControl_WUG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",31),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck33_Thrall90_JundMidrange_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",32),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck34_Darthkid_Burn_WR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",33),
                "PostAstrolabeBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck35_zachattack23_BantControl_WUG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",34),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck36_Nammersquats_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",35),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck37_grinderA_Burn_WR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",36),
                "PostAstrolabeBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck38_MattJMusic_Burn_R()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",37),
                "PostAstrolabeBan",
                ArchetypeColor.R,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck39_SebastianStueckl_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",38),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck40_Kuhmero_Burn_WR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",39),
                "PostAstrolabeBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck41_sonsojf_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",40),
                "PostAstrolabeBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck42_L3D91_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",41),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck43_Callad0_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",42),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck44_YUMAS2_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",43),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck45_twinlesstwin_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",44),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck46_limp22_AzoriusControl_WU()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",45),
                "PostAstrolabeBan",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck47_Ingles_Burn_WR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",46),
                "PostAstrolabeBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck48_DreamsOfAshiok_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",47),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck49_ScuttoZ_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",48),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck50_oosunq_JundMidrange_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",49),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck51_alicoco_AdNauseam_WUBR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",50),
                "PostAstrolabeBan",
                ArchetypeColor.WUBR,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck52_Nilsfit_Reclamation_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",51),
                "PostAstrolabeBan",
                ArchetypeColor.UBG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck53_crazeejakee07_AzoriusControl_WU()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",52),
                "PostAstrolabeBan",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck54_w1vern_Scapeshift_URG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",53),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                null
            );
        }

        [Test]
        public void Deck55_antonio00_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",54),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck56_Amatox_BantBlink_WUG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",55),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericBlink",
                null,
                null
            );
        }

        [Test]
        public void Deck57_Mordeka1ser_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",56),
                "PostAstrolabeBan",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck58_karn90_SultaiControl_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",57),
                "PostAstrolabeBan",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck59_zecarlonxo_MonoRedProwess_R()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",58),
                "PostAstrolabeBan",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck60_Dai1412_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",59),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck61_kaktusowysmok_Goblins_BR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",60),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "Goblins",
                null,
                null
            );
        }

        [Test]
        public void Deck62_NightKnight131_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",61),
                "PostAstrolabeBan",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck63_untiltedmtg_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",62),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck64_SweetIto_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",63),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck65_MadMaxErnst_SultaiControl_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",64),
                "PostAstrolabeBan",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck66_BSKhercules_Dredge_WBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",65),
                "PostAstrolabeBan",
                ArchetypeColor.WBRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck67_goodplayer95_NivToLight_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",66),
                "PostAstrolabeBan",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                null
            );
        }

        [Test]
        public void Deck68_Shatun_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",67),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck69_Curtisaxel_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",68),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck70_TatemusPrime_Burn_WR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",69),
                "PostAstrolabeBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck71_matheusponciano_Dredge_UBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",70),
                "PostAstrolabeBan",
                ArchetypeColor.UBRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck72_mac121711_JeskaiControl_WUR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",71),
                "PostAstrolabeBan",
                ArchetypeColor.WUR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck73_Thattaman_JundMidrange_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",72),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck74_Irra0770_JundMidrange_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",73),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck75_Iceman76_AmuletTitan_UG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",74),
                "PostAstrolabeBan",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck76_penach010_Devoted_WRG_Yorion()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",75),
                "PostAstrolabeBan",
                ArchetypeColor.WRG,
                "Devoted",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck77_Conorman11_Burn_WR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",76),
                "PostAstrolabeBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck78_Mingueretxo_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",77),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck79_BrunoPardini_JundMidrange_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",78),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck80_halfie44_JundMidrange_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",79),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck81_CrocodileMTG_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",80),
                "PostAstrolabeBan",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck82_polinasgiuleppe_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",81),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck83_JoaoAndrade_JundMidrange_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",82),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck84_Jitko_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",83),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck85_msskinbolic_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",84),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck86_r0cknati0n_SultaiControl_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",85),
                "PostAstrolabeBan",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck87_Batutinha_Reclamation_UBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",86),
                "PostAstrolabeBan",
                ArchetypeColor.UBRG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck88_Murager_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",87),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck89_mdvayu2_SaheeliCombo_WUR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",88),
                "PostAstrolabeBan",
                ArchetypeColor.WUR,
                "SaheeliCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck90_EQUITES_GrixisShadow_UBR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",89),
                "PostAstrolabeBan",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck91_Noix11_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",90),
                "PostAstrolabeBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck92_jinavie_AzoriusControl_WU()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",91),
                "PostAstrolabeBan",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck93_FedeG_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",92),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck94_thinenagooyen_Goblins_BR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",93),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "Goblins",
                null,
                null
            );
        }

        [Test]
        public void Deck95_osk4_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",94),
                "PostAstrolabeBan",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck96_SknerusMcKwacz_Scapeshift_URG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",95),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                null
            );
        }

        [Test]
        public void Deck97_Kauri_HardenedScales_G()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",96),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "HardenedScales",
                null,
                null
            );
        }

        [Test]
        public void Deck98_Janh_SaheeliCombo_WUR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",97),
                "PostAstrolabeBan",
                ArchetypeColor.WUR,
                "SaheeliCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck99_olea_Dredge_WBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",98),
                "PostAstrolabeBan",
                ArchetypeColor.WBRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck100_ironmaiden2_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",99),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck101_toastxp_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",100),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck102_Darkiundsa_GreenTron_G()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",101),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck103_Daking3603_Crabvine_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",102),
                "PostAstrolabeBan",
                ArchetypeColor.UBG,
                "Crabvine",
                null,
                null
            );
        }

        [Test]
        public void Deck104_omgitztommy_Burn_R()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",103),
                "PostAstrolabeBan",
                ArchetypeColor.R,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck105_mrichi_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",104),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck106_Tondini_AdNauseam_WUB()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",105),
                "PostAstrolabeBan",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck107_DmZB_GiftsStorm_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",106),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck108_OrnatePuzzles_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",107),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck109_litcity_GrixisShadow_UBR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",108),
                "PostAstrolabeBan",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck110_FrankBonaparte_AzoriusControl_WU()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",109),
                "PostAstrolabeBan",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck111_mistakenn_AmuletTitan_URG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",110),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck112_kotka_Bogles_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",111),
                "PostAstrolabeBan",
                ArchetypeColor.WG,
                "Bogles",
                null,
                null
            );
        }

        [Test]
        public void Deck113_ellobaron_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",112),
                "PostAstrolabeBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck114_RandomOctopus_Reclamation_URG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",113),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck115_PhillHellmuth_JundMidrange_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",114),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck116_SouthernSliver_Slivers_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",115),
                "PostAstrolabeBan",
                ArchetypeColor.WUBRG,
                "Slivers",
                null,
                null
            );
        }

        [Test]
        public void Deck117_Joshicallsmefabo_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",116),
                "PostAstrolabeBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck118_Ikthaleon_AzoriusControl_WU()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",117),
                "PostAstrolabeBan",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck119_CHILLEDADED_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",118),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck120_palem_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",119),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck121_acks_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",120),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck122_ImGonnaGoAFK_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",121),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck123_maximusdee_GiftsStorm_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",122),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck124_magicmiguelGG_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",123),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck125_genxim_AdNauseam_WUB()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",124),
                "PostAstrolabeBan",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck126_aspiringspike_SultaiControl_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",125),
                "PostAstrolabeBan",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck127_PascalMaynard_Scapeshift_URG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",126),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                null
            );
        }

        [Test]
        public void Deck128_faisal_Dredge_WBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",127),
                "PostAstrolabeBan",
                ArchetypeColor.WBRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck129_slatorade_Bogles_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",128),
                "PostAstrolabeBan",
                ArchetypeColor.WG,
                "Bogles",
                null,
                null
            );
        }

        [Test]
        public void Deck130_holyshamgar_JeskaiControl_WUR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",129),
                "PostAstrolabeBan",
                ArchetypeColor.WUR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck131_pepeteam_AmuletTitan_UG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",130),
                "PostAstrolabeBan",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck132_iambadatmtg_JundMidrange_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",131),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck133_RnB_TitanShift_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",132),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "TitanShift",
                null
            );
        }

        [Test]
        public void Deck134_phcrescens_AmuletTitan_URG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",133),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck135_crazyklicker_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",134),
                "PostAstrolabeBan",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck136_Patapon20_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",135),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck137_zacharee_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",136),
                "PostAstrolabeBan",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck138_turnthemsideways_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",137),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck139_tuhoajatane_BantControl_WUG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",138),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck140_GiovaniMF_JundShadow_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",139),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck141_BaronOfBacon_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",140),
                "PostAstrolabeBan",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck142_chrisconcarnage_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",141),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck143_ACG88_TitanShift_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",142),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "TitanShift",
                null
            );
        }

        [Test]
        public void Deck144_takemini_AzoriusControl_WU()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",143),
                "PostAstrolabeBan",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck145_FromTheCrypt_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",144),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck146_mikeyoffbeat_HardenedScales_G()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",145),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "HardenedScales",
                null,
                null
            );
        }

        [Test]
        public void Deck147_MaxMagicer_Goblins_BR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",146),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "Goblins",
                null,
                null
            );
        }

        [Test]
        public void Deck148_rmonger_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",147),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck149_PTarts2win_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",148),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck150_sharkcastermage_AdNauseam_WUB()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",149),
                "PostAstrolabeBan",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck151_friedliverattack_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",150),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck152_diem4x_SultaiControl_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",151),
                "PostAstrolabeBan",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck153_thegodmikedevo_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",152),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck154_BERNASTORRES_JundMidrange_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",153),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck155_AluminumMonster_Reclamation_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",154),
                "PostAstrolabeBan",
                ArchetypeColor.UBG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck156_CordoTwin_GrixisShadow_UBR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",155),
                "PostAstrolabeBan",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck157_CRYPTICC4SSIE_Scapeshift_URG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",156),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                null
            );
        }

        [Test]
        public void Deck158_RealJoy_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",157),
                "PostAstrolabeBan",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck159_berckovitz_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",158),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck160_Legendcay_AdNauseam_WUB()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",159),
                "PostAstrolabeBan",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck161_BlazedUgin_AmuletTitan_UG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",160),
                "PostAstrolabeBan",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck162_ecobaronen_AzoriusControl_WU()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",161),
                "PostAstrolabeBan",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck163_winddragon11_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",162),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck164_abisbocci_GrixisShadow_UBR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",163),
                "PostAstrolabeBan",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck165_INickStrad_AzoriusControl_WU()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",164),
                "PostAstrolabeBan",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck166_graciasportanto_JundMidrange_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",165),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck167_in5ano_Scapeshift_URG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",166),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                null
            );
        }

        [Test]
        public void Deck168_heydaniel_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",167),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck169_kalko_GiftsStorm_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",168),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck170_wolfmedic_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",169),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck171_desertdrive_BorosProwess_WR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",170),
                "PostAstrolabeBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck172_StanLee_Scapeshift_UBRG_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",171),
                "PostAstrolabeBan",
                ArchetypeColor.UBRG,
                "Scapeshift",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck173_Leonardo1080_SelesnyaEldraziTaxes_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",172),
                "PostAstrolabeBan",
                ArchetypeColor.WG,
                "Taxes",
                "EldraziTaxes",
                null
            );
        }

        [Test]
        public void Deck174_TheKingFor1000years_Infect_UG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",173),
                "PostAstrolabeBan",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck175_salvite_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",174),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck176_Gabriel0288_TitanShift_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",175),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "TitanShift",
                null
            );
        }

        [Test]
        public void Deck177_OnlyLuck_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",176),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck178_Sideshowsc_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",177),
                "PostAstrolabeBan",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck179_Marxelo_Tokens_WB()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",178),
                "PostAstrolabeBan",
                ArchetypeColor.WB,
                "Tokens",
                null,
                null
            );
        }

        [Test]
        public void Deck180_SamKentesber_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",179),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck181_ThatAsianGuy8_JundMidrange_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",180),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck182_DenmarkDan_TitanShift_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",181),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "TitanShift",
                null
            );
        }

        [Test]
        public void Deck183_Ebnus_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",182),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck184_Wtnof_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",183),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck185_DLCabelo_5CControl_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",184),
                "PostAstrolabeBan",
                ArchetypeColor.WUBRG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck186_matiaskm_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",185),
                "PostAstrolabeBan",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck187_Dfeanor_TitanShift_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",186),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "TitanShift",
                null
            );
        }

        [Test]
        public void Deck188_simpleliquid_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",187),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck189_lucadaky_GiftsStorm_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",188),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck190_MadCowChicken_GreenEldrazi_BG_Jegantha()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",189),
                "PostAstrolabeBan",
                ArchetypeColor.BG,
                "GreenEldrazi",
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck191_MatiCheto_GreenTron_G_Jegantha()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",190),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck192_Oscarzr22_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",191),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck193_HouseOfManaMTG_AmuletTitan_UG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",192),
                "PostAstrolabeBan",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck194_Xwhale_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",193),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck195_Xenowan_MonoRedProwess_R_Jegantha()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",194),
                "PostAstrolabeBan",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck196_yamakiller_SaheeliCombo_WUR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",195),
                "PostAstrolabeBan",
                ArchetypeColor.WUR,
                "SaheeliCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck197_WeareVenom_AzoriusControl_WU()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",196),
                "PostAstrolabeBan",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck198_TwitchAwP_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",197),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck199_mark68_Scapeshift_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",198),
                "PostAstrolabeBan",
                ArchetypeColor.WURG,
                "Scapeshift",
                null,
                null
            );
        }

        [Test]
        public void Deck200_CaptainFarbosa_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",199),
                "PostAstrolabeBan",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck201_nick4567_JundMidrange_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",200),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck202_cookiekid00_Goblins_BR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",201),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "Goblins",
                null,
                null
            );
        }

        [Test]
        public void Deck203_TheoJung_Scapeshift_URG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",202),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                null
            );
        }

        [Test]
        public void Deck204_BANTE_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",203),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck205_andycsoto_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",204),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck206_foretweezy1_Goblins_BR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",205),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "Goblins",
                null,
                null
            );
        }

        [Test]
        public void Deck207_ArchaeusDota_GreenTron_G()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",206),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck208_fradev1988_ElectroBalance_URG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",207),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "FreeSpells",
                "ElectroBalance",
                null
            );
        }

        [Test]
        public void Deck209_vlaprohor_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",208),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck210_PieGonti_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",209),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck211_grahams_Crabvine_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",210),
                "PostAstrolabeBan",
                ArchetypeColor.UBG,
                "Crabvine",
                null,
                null
            );
        }

        [Test]
        public void Deck212_SvenSveeterSven_IzzetControl_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",211),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck213_Sherwinator_GrixisShadow_UBR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",212),
                "PostAstrolabeBan",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck214_RaptorNachos_MonoRedProwess_R()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",213),
                "PostAstrolabeBan",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck215_Nikito18_AzoriusControl_WU()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",214),
                "PostAstrolabeBan",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck216_ShowTime_JundMidrange_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",215),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck217_TheTarmogoat_JeskaiControl_WUR_Yorion()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",216),
                "PostAstrolabeBan",
                ArchetypeColor.WUR,
                "GenericControl",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck218_musasabi_JundMidrange_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",217),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck219_GedionRavenor_AzoriusControl_WU()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",218),
                "PostAstrolabeBan",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck220_300_GreenTron_G()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",219),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck221_thodoris17_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",220),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck222_JarenDunnerr_Burn_WR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",221),
                "PostAstrolabeBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck223_mlgb92_Goblins_BR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",222),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "Goblins",
                null,
                null
            );
        }

        [Test]
        public void Deck224_qmcgarry45_Burn_WR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",223),
                "PostAstrolabeBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck225_Gobern_AmuletTitan_UG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",224),
                "PostAstrolabeBan",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck226_AnarchistAbe_Reclamation_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",225),
                "PostAstrolabeBan",
                ArchetypeColor.UBG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck227_tsHunter_SultaiControl_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",226),
                "PostAstrolabeBan",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck228_ehawk77_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",227),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck229_ScreenwriterNY_AdNauseam_WUB()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",228),
                "PostAstrolabeBan",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck230_danielmos_AzoriusControl_WU()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",229),
                "PostAstrolabeBan",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck231_Znurvel_Infect_WUG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",230),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck232_doughhater_ThaliaStompy_WR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",231),
                "PostAstrolabeBan",
                ArchetypeColor.WR,
                "Taxes",
                "ThaliaStompy",
                null
            );
        }

        [Test]
        public void Deck233_iuriper_BantControl_WUG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",232),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck234_goteo_GruulProwess_RG_Jegantha()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",233),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck235_beestjes_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",234),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }


    }
}

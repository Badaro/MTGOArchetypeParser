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
#13 patxi: Temur Control (URG)
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
#26 VerMahilen: Orzhov Taxes (WB)
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
#52 Nilsfit: Sultai Control (UBG)
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
#87 _Batutinha_: UBRG Control (UBRG)
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
#114 RandomOctopus: Temur Control (URG)
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
#155 AluminumMonster: Sultai Control (UBG)
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
#173 Leonardo1080: Green Eldrazi (WG)
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
#226 AnarchistAbe: Sultai Control (UBG)
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
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_nbdf_Dredge_WBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",1),
                new PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck03_GanYanCHN_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",2),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Bedell_AmuletTitan_UG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",3),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck05_Losilla_Scapeshift_URG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",4),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck06_djbmppwns_GruulProwess_RG_Jegantha()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",5),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck07_JKnecht_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",6),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck08_DanielGarcia_GruulProwess_RG_Jegantha()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",7),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck09_ConnorM426_Dredge_WBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",8),
                new PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck10_LLegend_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",9),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck11_CalebYetman_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",10),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Skuttlespike_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",11),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck13_patxi_TemurControl_URG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",12),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck14_RNGspecialist_Scapeshift_URG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",13),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck15_CNewman_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",14),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Themightylinguine_GreenTron_G()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",15),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck17_killerp0p0_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",16),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck18_cometa183_AzoriusControl_WU()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",17),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck19_HannoLee_GreenTron_G()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",18),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck20_Sprouts_AbzanMidrange_WBG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",19),
                new PostAstrolabeBan(),
                ArchetypeColor.WBG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck21_ouranos139_AmuletTitan_UG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",20),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck22_MissTrigger_Burn_R()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",21),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Cherryxman_Scapeshift_URG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",22),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck24_albert62_JundMidrange_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",23),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Bodybag_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",24),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck26_VerMahilen_OrzhovTaxes_WB()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",25),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck27_GodOfSlaughter_JundMidrange_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",26),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Aluren85_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",27),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck29_BMJ_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",28),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Praxifi_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",29),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck31_Tw33Ty_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",30),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck32_katoriarch123_BantControl_WUG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",31),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck33_Thrall90_JundMidrange_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",32),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck34_Darthkid_Burn_WR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",33),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck35_zachattack23_BantControl_WUG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",34),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck36_Nammersquats_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",35),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck37_grinderA_Burn_WR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",36),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck38_MattJMusic_Burn_R()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",37),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck39_SebastianStueckl_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",38),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck40_Kuhmero_Burn_WR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",39),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck41_sonsojf_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",40),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck42_L3D91_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",41),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck43_Callad0_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",42),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck44_YUMAS2_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",43),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck45_twinlesstwin_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",44),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck46_limp22_AzoriusControl_WU()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",45),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck47_Ingles_Burn_WR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",46),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck48_DreamsOfAshiok_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",47),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck49_ScuttoZ_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",48),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck50_oosunq_JundMidrange_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",49),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck51_alicoco_AdNauseam_WUBR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",50),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBR,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck52_Nilsfit_SultaiControl_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",51),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck53_crazeejakee07_AzoriusControl_WU()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",52),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck54_w1vern_Scapeshift_URG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",53),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck55_antonio00_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",54),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck56_Amatox_BantBlink_WUG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",55),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck57_Mordeka1ser_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",56),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck58_karn90_SultaiControl_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",57),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck59_zecarlonxo_MonoRedProwess_R()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",58),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck60_Dai1412_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",59),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck61_kaktusowysmok_Goblins_BR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",60),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck62_NightKnight131_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",61),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck63_untiltedmtg_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",62),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck64_SweetIto_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",63),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck65_MadMaxErnst_SultaiControl_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",64),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck66_BSKhercules_Dredge_WBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",65),
                new PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck67_goodplayer95_NivToLight_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",66),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck68_Shatun_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",67),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck69_Curtisaxel_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",68),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck70_TatemusPrime_Burn_WR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",69),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck71_matheusponciano_Dredge_UBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",70),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck72_mac121711_JeskaiControl_WUR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",71),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck73_Thattaman_JundMidrange_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",72),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck74_Irra0770_JundMidrange_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",73),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck75_Iceman76_AmuletTitan_UG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",74),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck76_penach010_Devoted_WRG_Yorion()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",75),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck77_Conorman11_Burn_WR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",76),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck78_Mingueretxo_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",77),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck79_BrunoPardini_JundMidrange_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",78),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck80_halfie44_JundMidrange_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",79),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck81_CrocodileMTG_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",80),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck82_polinasgiuleppe_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",81),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck83_JoaoAndrade_JundMidrange_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",82),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck84_Jitko_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",83),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck85_msskinbolic_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",84),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck86_r0cknati0n_SultaiControl_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",85),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck87_Batutinha_UBRGControl_UBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",86),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck88_Murager_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",87),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck89_mdvayu2_SaheeliCombo_WUR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",88),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(SaheeliCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck90_EQUITES_GrixisShadow_UBR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",89),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck91_Noix11_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",90),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck92_jinavie_AzoriusControl_WU()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",91),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck93_FedeG_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",92),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck94_thinenagooyen_Goblins_BR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",93),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck95_osk4_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",94),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck96_SknerusMcKwacz_Scapeshift_URG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",95),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck97_Kauri_HardenedScales_G()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",96),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck98_Janh_SaheeliCombo_WUR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",97),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(SaheeliCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck99_olea_Dredge_WBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",98),
                new PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck100_ironmaiden2_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",99),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck101_toastxp_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",100),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck102_Darkiundsa_GreenTron_G()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",101),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck103_Daking3603_Crabvine_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",102),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck104_omgitztommy_Burn_R()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",103),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck105_mrichi_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",104),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck106_Tondini_AdNauseam_WUB()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",105),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck107_DmZB_GiftsStorm_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",106),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck108_OrnatePuzzles_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",107),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck109_litcity_GrixisShadow_UBR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",108),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck110_FrankBonaparte_AzoriusControl_WU()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",109),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck111_mistakenn_AmuletTitan_URG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",110),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck112_kotka_Bogles_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",111),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck113_ellobaron_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",112),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck114_RandomOctopus_TemurControl_URG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",113),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck115_PhillHellmuth_JundMidrange_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",114),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck116_SouthernSliver_Slivers_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",115),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Slivers),
                null,
                null
            );
        }

        [Test]
        public void Deck117_Joshicallsmefabo_Humans_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",116),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck118_Ikthaleon_AzoriusControl_WU()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",117),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck119_CHILLEDADED_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",118),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck120_palem_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",119),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck121_acks_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",120),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck122_ImGonnaGoAFK_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",121),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck123_maximusdee_GiftsStorm_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",122),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck124_magicmiguelGG_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",123),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck125_genxim_AdNauseam_WUB()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",124),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck126_aspiringspike_SultaiControl_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",125),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck127_PascalMaynard_Scapeshift_URG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",126),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck128_faisal_Dredge_WBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",127),
                new PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck129_slatorade_Bogles_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",128),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck130_holyshamgar_JeskaiControl_WUR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",129),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck131_pepeteam_AmuletTitan_UG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",130),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck132_iambadatmtg_JundMidrange_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",131),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck133_RnB_TitanShift_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",132),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck134_phcrescens_AmuletTitan_URG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",133),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck135_crazyklicker_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",134),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck136_Patapon20_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",135),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck137_zacharee_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",136),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck138_turnthemsideways_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",137),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck139_tuhoajatane_BantControl_WUG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",138),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck140_GiovaniMF_JundShadow_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",139),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck141_BaronOfBacon_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",140),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck142_chrisconcarnage_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",141),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck143_ACG88_TitanShift_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",142),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck144_takemini_AzoriusControl_WU()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",143),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck145_FromTheCrypt_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",144),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck146_mikeyoffbeat_HardenedScales_G()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",145),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck147_MaxMagicer_Goblins_BR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",146),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck148_rmonger_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",147),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck149_PTarts2win_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",148),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck150_sharkcastermage_AdNauseam_WUB()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",149),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck151_friedliverattack_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",150),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck152_diem4x_SultaiControl_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",151),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck153_thegodmikedevo_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",152),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck154_BERNASTORRES_JundMidrange_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",153),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck155_AluminumMonster_SultaiControl_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",154),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck156_CordoTwin_GrixisShadow_UBR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",155),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck157_CRYPTICC4SSIE_Scapeshift_URG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",156),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck158_RealJoy_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",157),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck159_berckovitz_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",158),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck160_Legendcay_AdNauseam_WUB()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",159),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck161_BlazedUgin_AmuletTitan_UG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",160),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck162_ecobaronen_AzoriusControl_WU()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",161),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck163_winddragon11_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",162),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck164_abisbocci_GrixisShadow_UBR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",163),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck165_INickStrad_AzoriusControl_WU()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",164),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck166_graciasportanto_JundMidrange_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",165),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck167_in5ano_Scapeshift_URG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",166),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck168_heydaniel_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",167),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck169_kalko_GiftsStorm_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",168),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck170_wolfmedic_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",169),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck171_desertdrive_BorosProwess_WR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",170),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck172_StanLee_Scapeshift_UBRG_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",171),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(Scapeshift),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck173_Leonardo1080_GreenEldrazi_WG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",172),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(GreenEldrazi),
                null,
                null
            );
        }

        [Test]
        public void Deck174_TheKingFor1000years_Infect_UG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",173),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck175_salvite_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",174),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck176_Gabriel0288_TitanShift_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",175),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck177_OnlyLuck_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",176),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck178_Sideshowsc_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",177),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck179_Marxelo_Tokens_WB()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",178),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(Tokens),
                null,
                null
            );
        }

        [Test]
        public void Deck180_SamKentesber_IzzetProwess_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",179),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck181_ThatAsianGuy8_JundMidrange_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",180),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck182_DenmarkDan_TitanShift_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",181),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck183_Ebnus_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",182),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck184_Wtnof_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",183),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck185_DLCabelo_5CControl_WUBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",184),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck186_matiaskm_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",185),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck187_Dfeanor_TitanShift_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",186),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck188_simpleliquid_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",187),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck189_lucadaky_GiftsStorm_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",188),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck190_MadCowChicken_GreenEldrazi_BG_Jegantha()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",189),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(GreenEldrazi),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck191_MatiCheto_GreenTron_G_Jegantha()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",190),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck192_Oscarzr22_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",191),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck193_HouseOfManaMTG_AmuletTitan_UG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",192),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck194_Xwhale_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",193),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck195_Xenowan_MonoRedProwess_R_Jegantha()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",194),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck196_yamakiller_SaheeliCombo_WUR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",195),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(SaheeliCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck197_WeareVenom_AzoriusControl_WU()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",196),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck198_TwitchAwP_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",197),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck199_mark68_Scapeshift_WURG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",198),
                new PostAstrolabeBan(),
                ArchetypeColor.WURG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck200_CaptainFarbosa_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",199),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck201_nick4567_JundMidrange_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",200),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck202_cookiekid00_Goblins_BR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",201),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck203_TheoJung_Scapeshift_URG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",202),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck204_BANTE_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",203),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck205_andycsoto_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",204),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck206_foretweezy1_Goblins_BR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",205),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck207_ArchaeusDota_GreenTron_G()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",206),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck208_fradev1988_ElectroBalance_URG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",207),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(FreeSpells),
                typeof(ElectroBalance),
                null
            );
        }

        [Test]
        public void Deck209_vlaprohor_EldraziTron_C()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",208),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck210_PieGonti_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",209),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Shadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck211_grahams_Crabvine_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",210),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck212_SvenSveeterSven_IzzetControl_UR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",211),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck213_Sherwinator_GrixisShadow_UBR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",212),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck214_RaptorNachos_MonoRedProwess_R()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",213),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck215_Nikito18_AzoriusControl_WU()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",214),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck216_ShowTime_JundMidrange_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",215),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck217_TheTarmogoat_JeskaiControl_WUR_Yorion()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",216),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck218_musasabi_JundMidrange_BRG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",217),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck219_GedionRavenor_AzoriusControl_WU()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",218),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck220_300_GreenTron_G()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",219),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck221_thodoris17_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",220),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck222_JarenDunnerr_Burn_WR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",221),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck223_mlgb92_Goblins_BR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",222),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck224_qmcgarry45_Burn_WR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",223),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck225_Gobern_AmuletTitan_UG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",224),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck226_AnarchistAbe_SultaiControl_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",225),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck227_tsHunter_SultaiControl_UBG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",226),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck228_ehawk77_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",227),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Shadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck229_ScreenwriterNY_AdNauseam_WUB()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",228),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck230_danielmos_AzoriusControl_WU()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",229),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck231_Znurvel_Infect_WUG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",230),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck232_doughhater_ThaliaStompy_WR()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",231),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(ThaliaStompy),
                null,
                null
            );
        }

        [Test]
        public void Deck233_iuriper_BantControl_WUG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",232),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck234_goteo_GruulProwess_RG_Jegantha()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",233),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck235_beestjes_GruulMidrange_RG()
        {
            Test(
                GetDeck("manatraders-series-modern-july-2020-2020-07-31",234),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }


    }
}

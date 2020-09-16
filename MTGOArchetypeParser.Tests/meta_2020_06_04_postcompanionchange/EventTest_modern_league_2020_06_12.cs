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
#01 in5ano: Scapeshift (URG, Yorion)
#02 katobu: Merfolk (WU, Lurrus)
#03 Blindside09: HardenedScales (BG, Lurrus)
#04 CharlieStyle: Burn (WR, Lurrus)
#05 Kurusu: KikiChord (WBRG, Yorion)
#06 fald_on: GiftsStorm (UR)
#07 Urzza100: BantControl (WUG, Yorion)
#08 603Leb: GruulMidrange (RG)
#09 sydneydude: BorosProwess (WR)
#10 rouleur: MonoRedProwess (R)
#11 yamayama: SultaiReclamation (UBG, Yorion)
#12 jimdownside: Aristocrats (WB, Lurrus)
#13 Danny_Bambino: Crabvine (UBG)
#14 pbarrrgh: SultaiReclamation (UBG)
#15 Zeranox: BantBlink (WUG, Yorion)
#16 FlxEx: JundShadow (BRG)
#17 soba178: Humans (WUBRG)
#18 MrRaeb: Uroza (UBG, Yorion)
#19 jessy_samek: Uroza (URG)
#20 B1gDan: MarduShadow (WBR)
#21 floatius: AzoriusControl (WU)
#22 osk4: WURGBlink (WURG, Yorion)
#23 Lucabireskusku: Inverter (UB)
#24 Netow: Bogles (WU, Lurrus)
#25 lancetman2: Dredge (BRG)
#26 j_money10: WUBGControl (WUBG)
#27 lovealienzzz: TemurControl (URG)
#28 renatoaraujo: GTron (G)
#29 Traft: Goblins (BRG)
#30 Mordeka1ser: BringToNiv (WUBRG, Yorion)
#31 anamika: WURGMidrange (WURG)
#32 Dr_D1ck_Forest: AdNauseam (WUB)
#33 Mollok: ThaliaStompy (WR)
#34 knightmare21: IzzetControl (UR)
#35 albert62: JundMidrange (BRG)
#36 kuromatu: ETron (C)
#37 Nideon: OrzhovEldraziTaxes (WB)
#38 nahuel10: WUBGControl (WUBG, Yorion)
#39 Zebrah: AmuletTitan (WURG)
#40 SawphtBoi: Winota (WRG)
#41 Boland: GrixisShadow (UBR)
#42 marcofabrizi: BantMidrange (WUG)
#43 robb93: UTron (U)
#44 Misplacedginger: BantControl (WUG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_04_postcompanionchange
{
    public class EventTest_modern_league_2020_06_12 : EventTest
    {
        [Test]
        public void Deck01_in5ano_Scapeshift_URG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-12",0),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck02_katobu_Merfolk_WU_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-06-12",1),
                new PostCompanionChange(),
                ArchetypeColor.WU,
                typeof(Merfolk),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_Blindside09_HardenedScales_BG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-06-12",2),
                new PostCompanionChange(),
                ArchetypeColor.BG,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_CharlieStyle_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-06-12",3),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_Kurusu_KikiChord_WBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-12",4),
                new PostCompanionChange(),
                ArchetypeColor.WBRG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck06_faldon_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-06-12",5),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Urzza100_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-12",6),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck08_603Leb_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-06-12",7),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck09_sydneydude_BorosProwess_WR()
        {
            Test(
                GetDeck("modern-league-2020-06-12",8),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck10_rouleur_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2020-06-12",9),
                new PostCompanionChange(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck11_yamayama_SultaiReclamation_UBG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-12",10),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(GenericReclamation),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck12_jimdownside_Aristocrats_WB_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-06-12",11),
                new PostCompanionChange(),
                ArchetypeColor.WB,
                typeof(Aristocrats),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_DannyBambino_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-league-2020-06-12",12),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck14_pbarrrgh_SultaiReclamation_UBG()
        {
            Test(
                GetDeck("modern-league-2020-06-12",13),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(GenericReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Zeranox_BantBlink_WUG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-12",14),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck16_FlxEx_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-league-2020-06-12",15),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck17_soba178_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-06-12",16),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck18_MrRaeb_Uroza_UBG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-12",17),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck19_jessysamek_Uroza_URG()
        {
            Test(
                GetDeck("modern-league-2020-06-12",18),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck20_B1gDan_MarduShadow_WBR()
        {
            Test(
                GetDeck("modern-league-2020-06-12",19),
                new PostCompanionChange(),
                ArchetypeColor.WBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck21_floatius_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-06-12",20),
                new PostCompanionChange(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck22_osk4_WURGBlink_WURG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-12",21),
                new PostCompanionChange(),
                ArchetypeColor.WURG,
                typeof(GenericBlink),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck23_Lucabireskusku_Inverter_UB()
        {
            Test(
                GetDeck("modern-league-2020-06-12",22),
                new PostCompanionChange(),
                ArchetypeColor.UB,
                typeof(Inverter),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Netow_Bogles_WU_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-06-12",23),
                new PostCompanionChange(),
                ArchetypeColor.WU,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_lancetman2_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-06-12",24),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck26_jmoney10_WUBGControl_WUBG()
        {
            Test(
                GetDeck("modern-league-2020-06-12",25),
                new PostCompanionChange(),
                ArchetypeColor.WUBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck27_lovealienzzz_TemurControl_URG()
        {
            Test(
                GetDeck("modern-league-2020-06-12",26),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck28_renatoaraujo_GTron_G()
        {
            Test(
                GetDeck("modern-league-2020-06-12",27),
                new PostCompanionChange(),
                ArchetypeColor.G,
                typeof(GTron),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Traft_Goblins_BRG()
        {
            Test(
                GetDeck("modern-league-2020-06-12",28),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Mordeka1ser_BringToNiv_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-12",29),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck31_anamika_WURGMidrange_WURG()
        {
            Test(
                GetDeck("modern-league-2020-06-12",30),
                new PostCompanionChange(),
                ArchetypeColor.WURG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck32_DrD1ckForest_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-06-12",31),
                new PostCompanionChange(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck33_Mollok_ThaliaStompy_WR()
        {
            Test(
                GetDeck("modern-league-2020-06-12",32),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(ThaliaStompy),
                null,
                null
            );
        }

        [Test]
        public void Deck34_knightmare21_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-06-12",33),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck35_albert62_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-06-12",34),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck36_kuromatu_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-06-12",35),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck37_Nideon_OrzhovEldraziTaxes_WB()
        {
            Test(
                GetDeck("modern-league-2020-06-12",36),
                new PostCompanionChange(),
                ArchetypeColor.WB,
                typeof(GenericEldraziTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck38_nahuel10_WUBGControl_WUBG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-12",37),
                new PostCompanionChange(),
                ArchetypeColor.WUBG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck39_Zebrah_AmuletTitan_WURG()
        {
            Test(
                GetDeck("modern-league-2020-06-12",38),
                new PostCompanionChange(),
                ArchetypeColor.WURG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck40_SawphtBoi_Winota_WRG()
        {
            Test(
                GetDeck("modern-league-2020-06-12",39),
                new PostCompanionChange(),
                ArchetypeColor.WRG,
                typeof(Winota),
                null,
                null
            );
        }

        [Test]
        public void Deck41_Boland_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-06-12",40),
                new PostCompanionChange(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck42_marcofabrizi_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-league-2020-06-12",41),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck43_robb93_UTron_U()
        {
            Test(
                GetDeck("modern-league-2020-06-12",42),
                new PostCompanionChange(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck44_Misplacedginger_BantControl_WUG()
        {
            Test(
                GetDeck("modern-league-2020-06-12",43),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}

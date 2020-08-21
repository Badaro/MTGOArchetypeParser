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
#01 SparTaNxX: Neobrand (UG)
#02 nielsen333: Burn (WR, Lurrus)
#03 Cherryxman: Inverter (UB)
#04 meanfannypack: Devoted (WG, Lurrus)
#05 Magicofplayer1: AdNauseam (WUB)
#06 Ftzz: SnowReclamation (UBG)
#07 Zebrah: AmuletTitan (WURG)
#08 no_lyfe: Prowess (R)
#09 xl_snapcaster: Miracles (WU, Kaheera)
#10 Nextep: Uroza (UBG, Yorion)
#11 alnash: SnowTitan (UG, Yorion)
#12 scvslayer: SnowShift (URG, Yorion)
#13 Tempano: Humans (WUBRG)
#14 Kurusu: KikiChord (WBRG, Yorion)
#15 IsKeiP529: KGCTron (G)
#16 ChaoticCamel: RakdosProwess (BR, Lurrus)
#17 hyriuu: Ponza (RG)
#18 Heibing: PrimevalTitan (BRG)
#19 yutya: SnowTitan (WUG, Yorion)
#20 TheNobodys: ThopterUrza (WUBR)
#21 FranPi: GiftsStorm (UR)
#22 BSK_hercules: SultaiSnow (UBG)
#23 Magric: RakdosMidrange (BR)
#24 lovealienzzz: SnowControl (URG)
#25 Drakanar: Merfolk (U)
#26 Walkers: SnowReclamation (UBG)
#27 Darkiundsa: SnowControl (WURG, Yorion)
#28 Jiggywiggy: KinnanUrza (URG, Yorion)
#29 Netow: Dredge (BRG)
#30 Zanman: GyrudaStompy (BRG, Gyruda)
#31 Madwolf87: TraverseShadow (BRG)
#32 Chad1987SR05: Rock (BG)
#33 Wuhsa: BringToNiv (WUBRG)
#34 thelegitpony666: Goblins (BR)
#35 whitefangshinobi: Mill (UB, Lurrus)
#36 salvamala: Jund (BRG)
#37 RodolfoSFD0: TitanShift (RG)
#38 Lcario: ETron (C)
#39 AutumnLily: SnowReclamation (UBG, Yorion)
#40 Jackson1031: Uroza (URG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_04_postcompanionchange
{
    public class EventTest_modern_league_2020_06_19 : EventTest
    {
        [Test]
        public void Deck01_SparTaNxX_Neobrand_UG()
        {
            Test(
                GetDeck("modern-league-2020-06-19",0),
                new PostCompanionChange(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck02_nielsen333_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-06-19",1),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_Cherryxman_Inverter_UB()
        {
            Test(
                GetDeck("modern-league-2020-06-19",2),
                new PostCompanionChange(),
                ArchetypeColor.UB,
                typeof(Inverter),
                null,
                null
            );
        }

        [Test]
        public void Deck04_meanfannypack_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-06-19",3),
                new PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_Magicofplayer1_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-06-19",4),
                new PostCompanionChange(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Ftzz_SnowControl_SnowReclamation_UBG()
        {
            Test(
                GetDeck("modern-league-2020-06-19",5),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SnowReclamation),
                null
            );
        }

        [Test]
        public void Deck07_Zebrah_PrimevalTitan_AmuletTitan_WURG()
        {
            Test(
                GetDeck("modern-league-2020-06-19",6),
                new PostCompanionChange(),
                ArchetypeColor.WURG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck08_nolyfe_Prowess_R()
        {
            Test(
                GetDeck("modern-league-2020-06-19",7),
                new PostCompanionChange(),
                ArchetypeColor.R,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck09_xlsnapcaster_AzoriusControl_Miracles_WU_Kaheera()
        {
            Test(
                GetDeck("modern-league-2020-06-19",8),
                new PostCompanionChange(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                typeof(Miracles),
                ArchetypeCompanion.Kaheera
            );
        }

        [Test]
        public void Deck10_Nextep_Uroza_UBG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-19",9),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck11_alnash_SnowControl_SnowTitan_UG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-19",10),
                new PostCompanionChange(),
                ArchetypeColor.UG,
                typeof(SnowControl),
                typeof(SnowTitan),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck12_scvslayer_SnowControl_SnowShift_URG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-19",11),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(SnowControl),
                typeof(SnowShift),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck13_Tempano_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-06-19",12),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Kurusu_KikiChord_WBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-19",13),
                new PostCompanionChange(),
                ArchetypeColor.WBRG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck15_IsKeiP529_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-06-19",14),
                new PostCompanionChange(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck16_ChaoticCamel_Prowess_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-06-19",15),
                new PostCompanionChange(),
                ArchetypeColor.BR,
                typeof(Prowess),
                typeof(RakdosProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_hyriuu_Ponza_RG()
        {
            Test(
                GetDeck("modern-league-2020-06-19",16),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Heibing_PrimevalTitan_BRG()
        {
            Test(
                GetDeck("modern-league-2020-06-19",17),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck19_yutya_SnowControl_SnowTitan_WUG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-19",18),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                typeof(SnowTitan),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck20_TheNobodys_ThopterUrza_WUBR()
        {
            Test(
                GetDeck("modern-league-2020-06-19",19),
                new PostCompanionChange(),
                ArchetypeColor.WUBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck21_FranPi_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-06-19",20),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck22_BSKhercules_SnowControl_SultaiSnow_UBG()
        {
            Test(
                GetDeck("modern-league-2020-06-19",21),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck23_Magric_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-06-19",22),
                new PostCompanionChange(),
                ArchetypeColor.BR,
                typeof(RakdosMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck24_lovealienzzz_SnowControl_URG()
        {
            Test(
                GetDeck("modern-league-2020-06-19",23),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Drakanar_Merfolk_U()
        {
            Test(
                GetDeck("modern-league-2020-06-19",24),
                new PostCompanionChange(),
                ArchetypeColor.U,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck26_Walkers_SnowControl_SnowReclamation_UBG()
        {
            Test(
                GetDeck("modern-league-2020-06-19",25),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SnowReclamation),
                null
            );
        }

        [Test]
        public void Deck27_Darkiundsa_SnowControl_WURG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-19",26),
                new PostCompanionChange(),
                ArchetypeColor.WURG,
                typeof(SnowControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck28_Jiggywiggy_KinnanUrza_URG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-19",27),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(KinnanUrza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck29_Netow_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-06-19",28),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Zanman_GyrudaStompy_BRG_Gyruda()
        {
            Test(
                GetDeck("modern-league-2020-06-19",29),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(GyrudaStompy),
                null,
                ArchetypeCompanion.Gyruda
            );
        }

        [Test]
        public void Deck31_Madwolf87_DeathsShadow_TraverseShadow_BRG()
        {
            Test(
                GetDeck("modern-league-2020-06-19",30),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(DeathsShadow),
                typeof(TraverseShadow),
                null
            );
        }

        [Test]
        public void Deck32_Chad1987SR05_Rock_BG()
        {
            Test(
                GetDeck("modern-league-2020-06-19",31),
                new PostCompanionChange(),
                ArchetypeColor.BG,
                typeof(Rock),
                null,
                null
            );
        }

        [Test]
        public void Deck33_Wuhsa_BringToNiv_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-06-19",32),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                null
            );
        }

        [Test]
        public void Deck34_thelegitpony666_Goblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-06-19",33),
                new PostCompanionChange(),
                ArchetypeColor.BR,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck35_whitefangshinobi_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-06-19",34),
                new PostCompanionChange(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck36_salvamala_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-league-2020-06-19",35),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck37_RodolfoSFD0_PrimevalTitan_TitanShift_RG()
        {
            Test(
                GetDeck("modern-league-2020-06-19",36),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck38_Lcario_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-06-19",37),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck39_AutumnLily_SnowControl_SnowReclamation_UBG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-19",38),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SnowReclamation),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck40_Jackson1031_Uroza_URG()
        {
            Test(
                GetDeck("modern-league-2020-06-19",39),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }


    }
}

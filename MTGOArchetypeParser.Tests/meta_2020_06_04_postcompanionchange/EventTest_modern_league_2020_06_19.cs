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
#05 Magicofplayer1: Ad Nauseam (WUB)
#06 Ftzz: Sultai Control (UBG)
#07 Zebrah: Amulet Titan (URG)
#08 no_lyfe: Mono Red Prowess (R)
#09 xl_snapcaster: Azorius Control (WU, Kaheera)
#10 Nextep: Uroza (UBG, Yorion)
#11 alnash: Simic Control (UG, Yorion)
#12 scvslayer: Scapeshift (URG, Yorion)
#13 Tempano: Humans (WUBRG)
#14 Kurusu: Kiki Chord (WBRG, Yorion)
#15 IsKeiP529: KGC Tron (G)
#16 ChaoticCamel: Rakdos Prowess (BR, Lurrus)
#17 hyriuu: Gruul Midrange (RG)
#18 Heibing: Primeval Titan (BG)
#19 yutya: Bant Control (WUG, Yorion)
#20 TheNobodys: Thopter Urza (WUBR)
#21 FranPi: Gifts Storm (UR)
#22 BSK_hercules: Sultai Control (UBG)
#23 Magric: Rakdos Midrange (BR)
#24 lovealienzzz: Temur Control (URG)
#25 Drakanar: Merfolk (U)
#26 Walkers: Sultai Control (UBG)
#27 Darkiundsa: WURG Control (WURG, Yorion)
#28 Jiggywiggy: Kinnan Legends (URG, Yorion)
#29 Netow: Dredge (BRG)
#30 Zanman: Titan Stompy (BRG, Gyruda)
#31 Madwolf87: Jund Shadow (BRG)
#32 Chad1987SR05: Golgari Midrange (BG)
#33 Wuhsa: Niv To Light (WUBRG)
#34 thelegitpony666: Goblins (BR)
#35 whitefangshinobi: Mill (UB, Lurrus)
#36 salvamala: Jund Midrange (BRG)
#37 RodolfoSFD0: Titan Shift (RG)
#38 Lcario: E Tron (C)
#39 AutumnLily: Sultai Control (UBG, Yorion)
#40 Jackson1031: Uroza (UG)
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
        public void Deck06_Ftzz_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-06-19",5),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Zebrah_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-league-2020-06-19",6),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck08_nolyfe_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2020-06-19",7),
                new PostCompanionChange(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck09_xlsnapcaster_AzoriusControl_WU_Kaheera()
        {
            Test(
                GetDeck("modern-league-2020-06-19",8),
                new PostCompanionChange(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
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
        public void Deck11_alnash_SimicControl_UG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-19",10),
                new PostCompanionChange(),
                ArchetypeColor.UG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck12_scvslayer_Scapeshift_URG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-19",11),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
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
        public void Deck15_IsKeiP529_KGCTron_G()
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
        public void Deck16_ChaoticCamel_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-06-19",15),
                new PostCompanionChange(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_hyriuu_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-06-19",16),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Heibing_PrimevalTitan_BG()
        {
            Test(
                GetDeck("modern-league-2020-06-19",17),
                new PostCompanionChange(),
                ArchetypeColor.BG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck19_yutya_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-19",18),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
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
        public void Deck22_BSKhercules_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-06-19",21),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
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
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck24_lovealienzzz_TemurControl_URG()
        {
            Test(
                GetDeck("modern-league-2020-06-19",23),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(GenericControl),
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
        public void Deck26_Walkers_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-06-19",25),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck27_Darkiundsa_WURGControl_WURG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-19",26),
                new PostCompanionChange(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck28_Jiggywiggy_KinnanLegends_URG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-19",27),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(KinnanLegends),
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
        public void Deck30_Zanman_TitanStompy_BRG_Gyruda()
        {
            Test(
                GetDeck("modern-league-2020-06-19",29),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(TitanStompy),
                null,
                ArchetypeCompanion.Gyruda
            );
        }

        [Test]
        public void Deck31_Madwolf87_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-league-2020-06-19",30),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck32_Chad1987SR05_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-league-2020-06-19",31),
                new PostCompanionChange(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck33_Wuhsa_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-06-19",32),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
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
        public void Deck36_salvamala_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-06-19",35),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck37_RodolfoSFD0_TitanShift_RG()
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
        public void Deck39_AutumnLily_SultaiControl_UBG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-19",38),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck40_Jackson1031_Uroza_UG()
        {
            Test(
                GetDeck("modern-league-2020-06-19",39),
                new PostCompanionChange(),
                ArchetypeColor.UG,
                typeof(Uroza),
                null,
                null
            );
        }


    }
}

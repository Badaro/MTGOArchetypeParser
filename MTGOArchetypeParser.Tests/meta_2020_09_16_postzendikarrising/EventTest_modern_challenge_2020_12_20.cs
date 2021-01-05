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
#01 dough_shack: Scapeshift (URG)
#02 MaxCapone: Oops All Spells (WUBG)
#03 IzzetSignetIsTheBest: Reclaimer Titan (WG)
#04 Laplasjan: Hammer Time (WB, Lurrus)
#05 bolov0: Rakdos Midrange (BR)
#06 MastaHorus: Izzet Living End (UR)
#07 Samcaster-Mage: E Tron (C)
#08 The_nayr: Obosh Aggro (R, Obosh)
#09 ShowTime_: Burn (WR)
#10 Xwhale: Reclaimer Titan (WG)
#11 TSPJendrek: Sultai Control (UBG)
#12 Ozymandias17: Rakdos Midrange (BR)
#13 patheus_84: Belcher (URG)
#14 joetru: Jund Midrange (BRG)
#15 aManatease: Izzet Prowess (UR)
#16 MrSeri: Hardened Scales (G)
#17 bladede: Jund Midrange (BRG)
#18 nazart: Heliod Combo (WG)
#19 thekingofnone: KGC Tron (G, Jegantha)
#20 elquinielas: Burn (WBR)
#21 mark_68: Sultai Control (UBG, Yorion)
#22 fabee1: Boros Taxes (WR)
#23 Kuhb: Hammer Time (WB, Lurrus)
#24 FerMTG: Heliod Combo (WG)
#25 _IlNano_: Shadow Prowess (BR, Lurrus)
#26 eggybenny: Heliod Combo (WG)
#27 mlex: Dredge (BRG)
#28 KO_Mak: Oops All Spells (UBG)
#29 ice_nine_: Boros Land Destruction (WR)
#30 daibloXSC: Erayo Prison (WUB)
#31 aspiringspike: Jeskai Control (WUR)
#32 pokerswizard: Shadow Prowess (BR, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_challenge_2020_12_20 : EventTest
    {
        [Test]
        public void Deck01_doughshack_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",0),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck02_MaxCapone_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",1),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck03_IzzetSignetIsTheBest_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",2),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck04_Laplasjan_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",3),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_bolov0_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",4),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck06_MastaHorus_IzzetLivingEnd_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",5),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(FreeSpells),
                typeof(ElectroEnd),
                null
            );
        }

        [Test]
        public void Deck07_SamcasterMage_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",6),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(Tron),
typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck08_Thenayr_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",7),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck09_ShowTime_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",8),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Xwhale_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",9),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck11_TSPJendrek_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",10),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Ozymandias17_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",11),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck13_patheus84_Belcher_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",12),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck14_joetru_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",13),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck15_aManatease_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",14),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck16_MrSeri_HardenedScales_G()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",15),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck17_bladede_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",16),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck18_nazart_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",17),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck19_thekingofnone_KGCTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",18),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Tron),
typeof(GreenTron),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck20_elquinielas_Burn_WBR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",19),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck21_mark68_SultaiControl_UBG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",20),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck22_fabee1_BorosTaxes_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",21),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Kuhb_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",22),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck24_FerMTG_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",23),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck25_IlNano_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",24),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck26_eggybenny_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",25),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck27_mlex_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",26),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck28_KOMak_OopsAllSpells_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",27),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck29_icenine_BorosLandDestruction_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",28),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(LandDestruction),
                null,
                null
            );
        }

        [Test]
        public void Deck30_daibloXSC_ErayoPrison_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",29),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(ErayoPrison),
                null,
                null
            );
        }

        [Test]
        public void Deck31_aspiringspike_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",30),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck32_pokerswizard_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-20",31),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}

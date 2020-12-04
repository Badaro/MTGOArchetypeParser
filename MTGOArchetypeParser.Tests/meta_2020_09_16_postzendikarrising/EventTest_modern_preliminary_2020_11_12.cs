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
#01 SpiderSpace: Selenya Taxes (WG, Yorion)
#02 joker10289: Sultai Control (UBG)
#03 10thDegree: Dredge (BRG)
#04 Phill_Hellmuth: Heliod Combo (WG)
#05 gazmon48: Izzet Prowess (UR)
#06 sandydogmtg: Oops All Spells (WUBG)
#07 leclairandy: Heliod Combo (WG)
#08 bgv1989: Ad Nauseam (WUB)
#09 yamakiller: Shadow Prowess (WBR, Lurrus)
#10 CountrytimeCrusher: Ad Nauseam (WUB)
#11 Redgy: Jeskai Control (WUR)
#12 RyanFmtg: Izzet Prowess (UR)
#13 pokerswizard: Obosh Aggro (R, Obosh)
#14 medvedev: Izzet Control (UR)
#15 _Shatun_: Orzhov Midrange (WB)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_11_12 : EventTest
    {
        [Test]
        public void Deck01_SpiderSpace_SelenyaTaxes_WG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-12",0),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck02_joker10289_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-12",1),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_10thDegree_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-12",2),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck04_PhillHellmuth_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-12",3),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck05_gazmon48_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-12",4),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck06_sandydogmtg_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-12",5),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck07_leclairandy_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-12",6),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck08_bgv1989_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-12",7),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck09_yamakiller_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-12",8),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_CountrytimeCrusher_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-12",9),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Redgy_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-12",10),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck12_RyanFmtg_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-12",11),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck13_pokerswizard_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-12",12),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck14_medvedev_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-12",13),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Shatun_OrzhovMidrange_WB()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-12",14),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(GenericMidrange),
                null,
                null
            );
        }


    }
}

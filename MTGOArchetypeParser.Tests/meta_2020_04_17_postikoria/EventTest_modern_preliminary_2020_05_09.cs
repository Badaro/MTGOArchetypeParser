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
#01 Wartico1: Devoted (WG, Lurrus)
#02 Parrit: Hardened Scales (BG, Lurrus)
#03 DDMeelow: Uroza (URG, Yorion)
#04 Heibing: Primeval Titan (UG)
#05 quinniac: Boros Prowess (WR, Lurrus)
#06 yuurari_yuko: Gruul Midrange (RG, Obosh)
#07 WhiteFaces: Golgari Midrange (BG, Lurrus)
#08 Hemsley: Hammer Time (WR, Lurrus)
#09 kanister: WURG Control (WURG, Yorion)
#10 shangaff: Amulet Titan (URG)
#11 ArchaeusDota: Green Tron (RG, Jegantha)
#12 spellvine: Jund Prowess (BRG, Lurrus)
#13 Airvent: Hardened Scales (BG, Lurrus)
#14 oskiyaa: Boros Prowess (WR, Lurrus)
#15 lucasensei2: Electro Balance (UR)
#16 signblindman: Devoted (WG, Lurrus)
#17 eresopacaso: Burn (WR, Lurrus)
#18 Asmodean1990: Jund Midrange (BRG, Lurrus)
#19 Albimtg: Dimir Control (UB, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_preliminary_2020_05_09 : EventTest
    {
        [Test]
        public void Deck01_Wartico1_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-09",0),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_Parrit_HardenedScales_BG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-09",1),
                new PostIkoria(),
                ArchetypeColor.BG,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_DDMeelow_Uroza_URG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-09",2),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck04_Heibing_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-09",3),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck05_quinniac_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-09",4),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_yuurariyuko_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-09",5),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck07_WhiteFaces_GolgariMidrange_BG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-09",6),
                new PostIkoria(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_Hemsley_HammerTime_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-09",7),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_kanister_WURGControl_WURG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-09",8),
                new PostIkoria(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck10_shangaff_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-09",9),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck11_ArchaeusDota_GreenTron_RG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-09",10),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(Tron),
                typeof(GreenTron),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck12_spellvine_JundProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-09",11),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_Airvent_HardenedScales_BG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-09",12),
                new PostIkoria(),
                ArchetypeColor.BG,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_oskiyaa_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-09",13),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck15_lucasensei2_ElectroBalance_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-09",14),
                new PostIkoria(),
                ArchetypeColor.UR,
                typeof(FreeSpells),
                typeof(ElectroBalance),
                null
            );
        }

        [Test]
        public void Deck16_signblindman_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-09",15),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_eresopacaso_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-09",16),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_Asmodean1990_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-09",17),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck19_Albimtg_DimirControl_UB_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-09",18),
                new PostIkoria(),
                ArchetypeColor.UB,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}

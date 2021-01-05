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
#01 Fnoop: Neobrand (UG)
#02 joker10289: Burn (WR, Lurrus)
#03 Jositoshekel: Bogles (WG, Lurrus)
#04 felider: Burn (WR, Lurrus)
#05 selbstdenker: Amulet Titan (UG)
#06 updraftelemental: Boros Prowess (WR, Lurrus)
#07 lighdar: Devoted (WG, Lurrus)
#08 Mogged: Boros Prowess (WR, Lurrus)
#09 kanister: Humans (WUBRG, Jegantha)
#10 Naisirc: Hardened Scales (BG, Lurrus)
#11 Nekonii: Elves (BG, Umori)
#12 eduardo_ossorio: Hardened Scales (BG, Lurrus)
#13 Biednarccio: Amulet Titan (UG)
#14 bigmasticore: Grixis Shadow (UBR)
#15 TSPJendrek: Delver (UB, Lurrus)
#16 Dafne17: Devoted (WG, Lurrus)
#17 Montre82: Burn (WR, Lurrus)
#18 Parrit: Hardened Scales (BG, Lurrus)
#19 NJGB1: Eldrazi Tron (C)
#20 MissTrigger: Burn (WR, Lurrus)
#21 katuo079595: Delver (UBR, Lurrus)
#22 coert: Green Tron (G)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_preliminary_2020_04_22 : EventTest
    {
        [Test]
        public void Deck01_Fnoop_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-22",0),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck02_joker10289_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-22",1),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_Jositoshekel_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-22",2),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_felider_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-22",3),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_selbstdenker_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-22",4),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck06_updraftelemental_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-22",5),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_lighdar_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-22",6),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_Mogged_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-22",7),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_kanister_Humans_WUBRG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-22",8),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck10_Naisirc_HardenedScales_BG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-22",9),
                new PostIkoria(),
                ArchetypeColor.BG,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_Nekonii_Elves_BG_Umori()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-22",10),
                new PostIkoria(),
                ArchetypeColor.BG,
                typeof(Elves),
                null,
                ArchetypeCompanion.Umori
            );
        }

        [Test]
        public void Deck12_eduardoossorio_HardenedScales_BG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-22",11),
                new PostIkoria(),
                ArchetypeColor.BG,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_Biednarccio_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-22",12),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck14_bigmasticore_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-22",13),
                new PostIkoria(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck15_TSPJendrek_Delver_UB_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-22",14),
                new PostIkoria(),
                ArchetypeColor.UB,
                typeof(Delver),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_Dafne17_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-22",15),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_Montre82_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-22",16),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_Parrit_HardenedScales_BG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-22",17),
                new PostIkoria(),
                ArchetypeColor.BG,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck19_NJGB1_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-22",18),
                new PostIkoria(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck20_MissTrigger_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-22",19),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck21_katuo079595_Delver_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-22",20),
                new PostIkoria(),
                ArchetypeColor.UBR,
                typeof(Delver),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck22_coert_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-22",21),
                new PostIkoria(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }


    }
}

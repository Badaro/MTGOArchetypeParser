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
#01 kanister: WURG Control (WURG, Yorion)
#02 Diem4x: Jund Midrange (BRG, Lurrus)
#03 audio336: Boros Prowess (WR, Lurrus)
#04 NJGB1: Grixis Shadow (UBR, Lurrus)
#05 TSPJendrek: Dimir Control (UB, Lurrus)
#06 oskiyaa: Amulet Titan (UG)
#07 tia05: Reclaimer Titan (RG)
#08 Oneyerob: Devoted (WG, Lurrus)
#09 albert62: Jund Midrange (BRG, Lurrus)
#10 paucr5: Devoted (WG, Lurrus)
#11 eresopacaso: Burn (WR, Lurrus)
#12 otakkun: Jund Midrange (BRG, Lurrus)
#13 Jenara19: Humans (WUBRG, Jegantha)
#14 Naisirc: Mono White Taxes (W)
#15 Logarythme: WURG Control (WURG, Yorion)
#16 selbstdenker: Amulet Titan (G)
#17 matyo804: Amulet Titan (UG)
#18 DreamsOfAshiok: Eldrazi Tron (C)
#19 Subi: Infect (WUG, Lurrus)
#20 12Days: Gruul Midrange (RG, Obosh)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_preliminary_2020_05_06 : EventTest
    {
        [Test]
        public void Deck01_kanister_WURGControl_WURG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-06",0),
                new PostIkoria(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck02_Diem4x_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-06",1),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_audio336_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-06",2),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_NJGB1_GrixisShadow_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-06",3),
                new PostIkoria(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_TSPJendrek_DimirControl_UB_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-06",4),
                new PostIkoria(),
                ArchetypeColor.UB,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_oskiyaa_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-06",5),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck07_tia05_ReclaimerTitan_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-06",6),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck08_Oneyerob_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-06",7),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_albert62_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-06",8),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_paucr5_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-06",9),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_eresopacaso_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-06",10),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_otakkun_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-06",11),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_Jenara19_Humans_WUBRG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-06",12),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck14_Naisirc_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-06",13),
                new PostIkoria(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Logarythme_WURGControl_WURG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-06",14),
                new PostIkoria(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck16_selbstdenker_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-06",15),
                new PostIkoria(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck17_matyo804_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-06",16),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck18_DreamsOfAshiok_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-06",17),
                new PostIkoria(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck19_Subi_Infect_WUG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-06",18),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(Infect),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck20_12Days_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-06",19),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }


    }
}

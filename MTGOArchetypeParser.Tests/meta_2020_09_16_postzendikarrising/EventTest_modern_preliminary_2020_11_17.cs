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
#01 hodortimebaby: Oops All Spells (WUBG)
#02 ACG88: KGC Tron (G)
#03 benchsummer: Shadow Prowess (BRG, Lurrus)
#04 kanister: Sultai Control (UBG)
#05 Naisirc: Gruul Midrange (RG)
#06 _Shatun_: Shadow Prowess (BR, Lurrus)
#07 stayrospet: Omnath Saheeli (WURG, Jegantha)
#08 Phill_Hellmuth: Reclaimer Titan (WRG)
#09 cicciogire: WURG Control (WURG)
#10 MZBlazer: Shadow Prowess (BRG, Lurrus)
#11 toondoslav: Infect (UG)
#12 ArchaeusDota: E Tron (C)
#13 ShowTime_: Jund Midrange (BRG)
#14 Wolfie98: Infect (BG)
#15 albert62: WURG Control (WURG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_11_17 : EventTest
    {
        [Test]
        public void Deck01_hodortimebaby_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-17",0),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck02_ACG88_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-17",1),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GTron),
                null,
                null
            );
        }

        [Test]
        public void Deck03_benchsummer_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-17",2),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_kanister_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-17",3),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Naisirc_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-17",4),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Shatun_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-17",5),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_stayrospet_OmnathSaheeli_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-17",6),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(OmnathSaheeli),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck08_PhillHellmuth_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-17",7),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck09_cicciogire_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-17",8),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck10_MZBlazer_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-17",9),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_toondoslav_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-17",10),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck12_ArchaeusDota_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-17",11),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck13_ShowTime_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-17",12),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Wolfie98_Infect_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-17",13),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck15_albert62_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-17",14),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}

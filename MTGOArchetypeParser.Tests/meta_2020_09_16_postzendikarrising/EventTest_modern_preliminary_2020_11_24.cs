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
#01 Lucabireskusku: Rogues (UB, Lurrus)
#02 MarcoBelacca95: Shadow Prowess (BR, Lurrus)
#03 Leinad972: Izzet Prowess (UR)
#04 exoticherman: Shadow Prowess (BR, Lurrus)
#05 Tiemuuu: Izzet Control (UR)
#06 Valorj: Heliod Combo (WG)
#07 WhiTe TsaR: Reclaimer Titan (WRG)
#08 oskiyaa: Humans (WUBRG)
#09 Damgar: KGC Tron (G)
#10 Capriccioso: WURG Control (WURG)
#11 MastaHorus: Izzet Living End (UR)
#12 Phill_Hellmuth: Dice Factory Tron (C)
#13 ColdPier: E Tron (C)
#14 VacatedDrake: Azorius Control (WU)
#15 GrandDrou: Reclaimer Titan (WRG)
#16 kanister: WURG Control (WURG)
#17 Arcatera: Shadow Prowess (BRG, Lurrus)
#18 ACG88: KGC Tron (G)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_11_24 : EventTest
    {
        [Test]
        public void Deck01_Lucabireskusku_Rogues_UB_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-24",0),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Rogues),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_MarcoBelacca95_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-24",1),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_Leinad972_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-24",2),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck04_exoticherman_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-24",3),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_Tiemuuu_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-24",4),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Valorj_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-24",5),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck07_WhiTeTsaR_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-24",6),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck08_oskiyaa_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-24",7),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Damgar_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-24",8),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GreenTron),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Capriccioso_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-24",9),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck11_MastaHorus_IzzetLivingEnd_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-24",10),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(FreeSpells),
                typeof(ElectroEnd),
                null
            );
        }

        [Test]
        public void Deck12_PhillHellmuth_DiceFactoryTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-24",11),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(DiceFactoryTron),
                null,
                null
            );
        }

        [Test]
        public void Deck13_ColdPier_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-24",12),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(EldraziTron),
                null,
                null
            );
        }

        [Test]
        public void Deck14_VacatedDrake_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-24",13),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck15_GrandDrou_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-24",14),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck16_kanister_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-24",15),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Arcatera_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-24",16),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_ACG88_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-24",17),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GreenTron),
                null,
                null
            );
        }


    }
}

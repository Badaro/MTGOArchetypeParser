using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Mulldrifter: Shadow Prowess (WBR, Lurrus)
#02 Do0mSwitch: WURG Control (WURG)
#03 BERNASTORRES: WURG Control (WURG)
#04 stayrospet: Omnath Saheeli (WURG, Jegantha)
#05 yPrincipe: Reclaimer Titan (WRG)
#06 ArchaeusDota: Green Tron (RG)
#07 Phill_Hellmuth: Spirits (WUG)
#08 Tractorage: Omnath Saheeli (WURG, Jegantha)
#09 mtgjens: Crabvine (UBG)
#10 Matteso: Gifts Storm (UR)
#11 pokerswizard: Reclamation (UBG)
#12 exoticherman: Rakdos Prowess (BR, Lurrus)
#13 SoulStrong: Reclaimer Titan (WRG)
#14 Ivc: Azorius Control (WU)
#15 HeyPharaoh: Jeskai Control (WUR)
#16 RespectTheCat: Azorius Taxes (WU, Yorion)
#17 Bedell: Reclaimer Titan (WRG)
#18 Redgy819: Shadow Prowess (BR, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_11_03 : EventTest
    {
        [Test]
        public void Deck01_Mulldrifter_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-03",0),
                "PostZendikarRising",
                ArchetypeColor.WBR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_Do0mSwitch_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-03",1),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck03_BERNASTORRES_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-03",2),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck04_stayrospet_OmnathSaheeli_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-03",3),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "SaheeliCombo",
                "OmnathSaheeli",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck05_yPrincipe_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-03",4),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck06_ArchaeusDota_GreenTron_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-03",5),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck07_PhillHellmuth_Spirits_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-03",6),
                "PostZendikarRising",
                ArchetypeColor.WUG,
                "Spirits",
                null,
                null
            );
        }

        [Test]
        public void Deck08_Tractorage_OmnathSaheeli_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-03",7),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "SaheeliCombo",
                "OmnathSaheeli",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck09_mtgjens_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-03",8),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "Crabvine",
                null,
                null
            );
        }

        [Test]
        public void Deck10_Matteso_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-03",9),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck11_pokerswizard_Reclamation_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-03",10),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck12_exoticherman_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-03",11),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_SoulStrong_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-03",12),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck14_Ivc_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-03",13),
                "PostZendikarRising",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck15_HeyPharaoh_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-03",14),
                "PostZendikarRising",
                ArchetypeColor.WUR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck16_RespectTheCat_AzoriusTaxes_WU_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-03",15),
                "PostZendikarRising",
                ArchetypeColor.WU,
                "Taxes",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck17_Bedell_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-03",16),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck18_Redgy819_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-03",17),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }


    }
}

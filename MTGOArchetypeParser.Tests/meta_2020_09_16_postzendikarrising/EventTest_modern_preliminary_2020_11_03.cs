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
#11 pokerswizard: Sultai Control (UBG)
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
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_Do0mSwitch_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-03",1),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_BERNASTORRES_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-03",2),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_stayrospet_OmnathSaheeli_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-03",3),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(OmnathSaheeli),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck05_yPrincipe_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-03",4),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck06_ArchaeusDota_GreenTron_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-03",5),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck07_PhillHellmuth_Spirits_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-03",6),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Tractorage_OmnathSaheeli_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-03",7),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(OmnathSaheeli),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck09_mtgjens_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-03",8),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Matteso_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-03",9),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck11_pokerswizard_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-03",10),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck12_exoticherman_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-03",11),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_SoulStrong_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-03",12),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck14_Ivc_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-03",13),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck15_HeyPharaoh_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-03",14),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck16_RespectTheCat_AzoriusTaxes_WU_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-03",15),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck17_Bedell_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-03",16),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck18_Redgy819_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-03",17),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }


    }
}

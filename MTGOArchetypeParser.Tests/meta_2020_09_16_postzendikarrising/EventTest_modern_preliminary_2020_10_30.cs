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
#01 tzio: Shadow Prowess (BR, Lurrus)
#02 Morenothings: WURG Control (WURG)
#03 Lordzedane: Jund Midrange (BRG, Lurrus)
#04 MZBlazer: Reclaimer Titan (WRG)
#05 hcook725: Jund Midrange (BRG)
#06 Boucha: Reclaimer Titan (WRG)
#07 mtgjens: Dredge (BRG)
#08 trunks132: Jeskai Control (WUR)
#09 PietroSas: Devoted (WG, Lurrus)
#10 sandydogmtg: Shadow Prowess (WBR, Lurrus)
#11 Qoiet: Rakdos Midrange (BR)
#12 karatedom: Mill (UB, Lurrus)
#13 ExclusiveB: Oops All Spells (WUBRG)
#14 Gerardo94: WURG Control (WURG)
#15 ArchaeusDota: Green Eldrazi (WG)
#16 Rav104: Oops All Spells (WUBG)
#17 TwistedWombat: Omnath Saheeli (WURG, Jegantha)
#18 AlpInco: Burn (WR)
#19 Capitano_CL: Reclaimer Titan (WG)
#20 _Stream: Shadow Prowess (BRG, Lurrus)
#21 pokerswizard: Gifts Storm (UR)
#22 wambocombo2020: Reclaimer Titan (WRG)
#23 j_money10: Azorius Taxes (WU, Yorion)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_10_30 : EventTest
    {
        [Test]
        public void Deck01_tzio_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-30",0),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_Morenothings_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-30",1),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Lordzedane_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-30",2),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_MZBlazer_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-30",3),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck05_hcook725_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-30",4),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Boucha_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-30",5),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck07_mtgjens_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-30",6),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck08_trunks132_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-30",7),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck09_PietroSas_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-30",8),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_sandydogmtg_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-30",9),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_Qoiet_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-30",10),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck12_karatedom_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-30",11),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_ExclusiveB_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-30",12),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Gerardo94_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-30",13),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck15_ArchaeusDota_GreenEldrazi_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-30",14),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(GreenEldrazi),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Rav104_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-30",15),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck17_TwistedWombat_OmnathSaheeli_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-30",16),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(OmnathSaheeli),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck18_AlpInco_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-30",17),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck19_CapitanoCL_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-30",18),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck20_Stream_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-30",19),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck21_pokerswizard_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-30",20),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck22_wambocombo2020_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-30",21),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck23_jmoney10_AzoriusTaxes_WU_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-30",22),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }


    }
}

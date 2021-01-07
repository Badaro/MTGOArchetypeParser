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
#01 McWinSauce: Bant Control (WUG)
#02 Sodeq: Dredge (BRG)
#03 Vidandric: Dredge (BRG)
#04 MaLiam: Sultai Shadow (UBG)
#05 Dazai: Bant Midrange (WUG)
#06 SoulStrong: Simic Control (UG)
#07 Nammersquats: Bant Midrange (WUG)
#08 OptionParalysis: Humans (WUBRG)
#09 _Batutinha_: Primeval Titan (UG)
#10 xfile: Mono Green Taxes (G)
#11 Toastxp: Simic Control (UG)
#12 Gobo2009: Orzhov Midrange (WB)
#13 JustBurn420: Slivers (WUBRG)
#14 BigHuman: Burn (WR)
#15 pegajusus: Simic Control (UG)
#16 Pistone11: Gifts Storm (UR)
*/

namespace MTGOArchetypeParser.Tests.meta_2019_12_13_lastokodays
{
    public class EventTest_modern_preliminary_2020_01_03 : EventTest
    {
        [Test]
        public void Deck01_McWinSauce_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-03",0),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Sodeq_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-03",1),
                new LastOkoDays(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Vidandric_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-03",2),
                new LastOkoDays(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck04_MaLiam_SultaiShadow_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-03",3),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Dazai_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-03",4),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck06_SoulStrong_SimicControl_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-03",5),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Nammersquats_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-03",6),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck08_OptionParalysis_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-03",7),
                new LastOkoDays(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Batutinha_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-03",8),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck10_xfile_MonoGreenTaxes_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-03",9),
                new LastOkoDays(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Toastxp_SimicControl_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-03",10),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Gobo2009_OrzhovMidrange_WB()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-03",11),
                new LastOkoDays(),
                ArchetypeColor.WB,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck13_JustBurn420_Slivers_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-03",12),
                new LastOkoDays(),
                ArchetypeColor.WUBRG,
                typeof(Slivers),
                null,
                null
            );
        }

        [Test]
        public void Deck14_BigHuman_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-03",13),
                new LastOkoDays(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck15_pegajusus_SimicControl_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-03",14),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Pistone11_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-03",15),
                new LastOkoDays(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }


    }
}

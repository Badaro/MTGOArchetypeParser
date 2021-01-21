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
#01 ravensfan52720: Humans (WUBRG)
#02 billsive: Bant Control (WUG, Yorion)
#03 WebZone: Humans (WUBRG)
#04 PeanutBrittle: Gifts Storm (UR)
#05 ecobaronen: Gruul Midrange (RG)
#06 madechai: Mono Red Prowess (R)
#07 brunocaleb: Gruul Midrange (RG)
#08 TheTunnelingCat: Eldrazi Tron (C)
#09 PRGJJAR: Dredge (BRG)
#10 staples87: Eldrazi Tron (C)
#11 benjamin13: Titan Shift (RG)
#12 Sonic_Smasher: Bant Control (WUG)
#13 il_matagatto: Burn (WR)
#14 Misplacedginger: Bant Control (WUG)
#15 BSK_hercules: Gruul Midrange (RG)
#16 lovealienzzz: Temur Control (URG)
#17 yamakiller: Reclamation (URG, Yorion)
#18 PieGonti: Humans (WUBRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_04_postcompanionchange
{
    public class EventTest_modern_preliminary_2020_06_12 : EventTest
    {
        [Test]
        public void Deck01_ravensfan52720_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-12",0),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck02_billsive_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-12",1),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck03_WebZone_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-12",2),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck04_PeanutBrittle_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-12",3),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck05_ecobaronen_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-12",4),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck06_madechai_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-12",5),
                new PostCompanionChange(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck07_brunocaleb_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-12",6),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck08_TheTunnelingCat_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-12",7),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck09_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-12",8),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck10_staples87_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-12",9),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck11_benjamin13_TitanShift_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-12",10),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck12_SonicSmasher_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-12",11),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck13_ilmatagatto_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-12",12),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck14_Misplacedginger_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-12",13),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck15_BSKhercules_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-12",14),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck16_lovealienzzz_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-12",15),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck17_yamakiller_Reclamation_URG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-12",16),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(Reclamation),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck18_PieGonti_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-12",17),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }


    }
}

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
#01 bigjc00: Amulet Titan (RG)
#02 bmac668: Burn (WR)
#03 nick4567: Sultai Control (UBG)
#04 fingers1991: Boros Prowess (WR, Lurrus)
#05 yumad3988: Enduring Ideal (W)
#06 Nammersquats: Boros Prowess (WR, Lurrus)
#07 PvtEnormous: Bant Control (WUG)
#08 A22en: Goblins (BR)
#09 Xwhale: Reclaimer Titan (WRG)
#10 darklingseven: Thopter Urza (UB)
#11 coert: Burn (WR)
#12 SIMONEFIERRO: Burn (WR)
#13 BERNASTORRES: Bogles (WG, Lurrus)
#14 1yo2yo: Sultai Control (UBG)
#15 Gigy: Naya Midrange (WRG)
#16 Toastxp: Uroza (URG)
#17 kthanakit26: Izzet Prowess (UR)
#18 yamakiller: Obosh Aggro (R, Obosh)
#19 SpikeYou: Sultai Control (UBG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_09_03 : EventTest
    {
        [Test]
        public void Deck01_bigjc00_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-03",0),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck02_bmac668_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-03",1),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck03_nick4567_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-03",2),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_fingers1991_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-03",3),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_yumad3988_EnduringIdeal_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-03",4),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(EnduringIdeal),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Nammersquats_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-03",5),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_PvtEnormous_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-03",6),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_A22en_Goblins_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-03",7),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Xwhale_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-03",8),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck10_darklingseven_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-03",9),
                new PostAstrolabeBan(),
                ArchetypeColor.UB,
                typeof(ThopterCombo),
typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck11_coert_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-03",10),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck12_SIMONEFIERRO_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-03",11),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck13_BERNASTORRES_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-03",12),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_1yo2yo_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-03",13),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Gigy_NayaMidrange_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-03",14),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Toastxp_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-03",15),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck17_kthanakit26_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-03",16),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck18_yamakiller_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-03",17),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck19_SpikeYou_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-03",18),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}

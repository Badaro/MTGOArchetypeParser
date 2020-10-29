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
#01 bigjc00: AmuletTitan (URG)
#02 bmac668: Burn (WR)
#03 nick4567: SultaiReclamation (UBG)
#04 fingers1991: BorosProwess (WR, Lurrus)
#05 yumad3988: EnduringIdeal (W)
#06 Nammersquats: BorosProwess (WR, Lurrus)
#07 PvtEnormous: BantControl (WUG)
#08 A22en: SnoopGoblins (BR)
#09 Xwhale: PrimevalTitan (WRG)
#10 darklingseven: ThopterUrza (UB)
#11 coert: Burn (WR)
#12 SIMONEFIERRO: Burn (WR)
#13 BERNASTORRES: Bogles (WG, Lurrus)
#14 1yo2yo: SultaiReclamation (UBG)
#15 Gigy: NayaMidrange (WRG)
#16 Toastxp: Uroza (URG)
#17 kthanakit26: IzzetProwess (UR)
#18 yamakiller: OboshAggro (R, Obosh)
#19 SpikeYou: SultaiReclamation (UBG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_09_03 : EventTest
    {
        [Test]
        public void Deck01_bigjc00_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-03",0),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
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
        public void Deck03_nick4567_SultaiReclamation_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-03",2),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericReclamation),
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
        public void Deck08_A22en_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-03",7),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck09_Xwhale_PrimevalTitan_WRG()
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
                typeof(ThopterUrza),
                null,
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
        public void Deck14_1yo2yo_SultaiReclamation_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-03",13),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericReclamation),
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
        public void Deck19_SpikeYou_SultaiReclamation_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-03",18),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericReclamation),
                null,
                null
            );
        }


    }
}

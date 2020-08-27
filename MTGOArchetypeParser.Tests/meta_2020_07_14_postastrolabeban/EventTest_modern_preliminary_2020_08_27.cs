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
#01 edward40hands: GolgariMidrange (BG)
#02 bigjc00: AmuletTitan (URG)
#03 qbturtle15: GruulMidrange (RG)
#04 Secretaznman: GruulMidrange (RG)
#05 McWinSauce: BantControl (WUG)
#06 yamakiller: MonoRedProwess (R, Obosh)
#07 PvtEnormous: BantControl (WUG)
#08 coert: Burn (WR)
#09 karatedom: RakdosProwess (BR, Lurrus)
#10 McleanYSUTF: SnoopGoblins (BR)
#11 NHA37: AdNauseam (WUB)
#12 juzam_gin: Dredge (WBRG)
#13 Slatorade: Bogles (WG, Lurrus)
#14 SpikeYou: JundShadow (BRG)
#15 Nammersquats: MonoRedProwess (R, Obosh)
#16 tuckbear: SultaiControl (UBG)
#17 cftsoc3: BantControl (WUG)
#18 DragonFodder: Skelementals (BR)
#19 ThekingFor1000years: Infect (UG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_08_27 : EventTest
    {
        [Test]
        public void Deck01_edward40hands_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-27",0),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck02_bigjc00_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-27",1),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck03_qbturtle15_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-27",2),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Secretaznman_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-27",3),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck05_McWinSauce_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-27",4),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck06_yamakiller_MonoRedProwess_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-27",5),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck07_PvtEnormous_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-27",6),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_coert_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-27",7),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck09_karatedom_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-27",8),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_McleanYSUTF_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-27",9),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck11_NHA37_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-27",10),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck12_juzamgin_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-27",11),
                new PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Slatorade_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-27",12),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_SpikeYou_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-27",13),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Nammersquats_MonoRedProwess_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-27",14),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck16_tuckbear_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-27",15),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck17_cftsoc3_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-27",16),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck18_DragonFodder_Skelementals_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-27",17),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Skelementals),
                null,
                null
            );
        }

        [Test]
        public void Deck19_ThekingFor1000years_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-27",18),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }


    }
}

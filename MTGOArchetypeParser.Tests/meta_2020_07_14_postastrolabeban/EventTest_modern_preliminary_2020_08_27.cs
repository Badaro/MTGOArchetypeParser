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
#01 edward40hands: Golgari Midrange (BG)
#02 bigjc00: Amulet Titan (URG)
#03 qbturtle15: Gruul Midrange (RG)
#04 Secretaznman: Gruul Midrange (RG)
#05 McWinSauce: Bant Control (WUG)
#06 yamakiller: Obosh Aggro (R, Obosh)
#07 PvtEnormous: Bant Control (WUG)
#08 coert: Burn (WR)
#09 karatedom: Rakdos Prowess (BR, Lurrus)
#10 McleanYSUTF: Goblins (BR)
#11 NHA37: Ad Nauseam (WUB)
#12 juzam_gin: Dredge (WBRG)
#13 Slatorade: Bogles (WG, Lurrus)
#14 SpikeYou: Jund Shadow (BRG)
#15 Nammersquats: Obosh Aggro (R, Obosh)
#16 tuckbear: Sultai Control (UBG)
#17 cftsoc3: Bant Control (WUG)
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
                "PostAstrolabeBan",
                ArchetypeColor.BG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck02_bigjc00_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-27",1),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck03_qbturtle15_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-27",2),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck04_Secretaznman_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-27",3),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck05_McWinSauce_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-27",4),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck06_yamakiller_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-27",5),
                "PostAstrolabeBan",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck07_PvtEnormous_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-27",6),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck08_coert_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-27",7),
                "PostAstrolabeBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck09_karatedom_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-27",8),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_McleanYSUTF_Goblins_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-27",9),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "Goblins",
                null,
                null
            );
        }

        [Test]
        public void Deck11_NHA37_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-27",10),
                "PostAstrolabeBan",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck12_juzamgin_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-27",11),
                "PostAstrolabeBan",
                ArchetypeColor.WBRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck13_Slatorade_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-27",12),
                "PostAstrolabeBan",
                ArchetypeColor.WG,
                "Bogles",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_SpikeYou_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-27",13),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck15_Nammersquats_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-27",14),
                "PostAstrolabeBan",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck16_tuckbear_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-27",15),
                "PostAstrolabeBan",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck17_cftsoc3_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-27",16),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck18_DragonFodder_Skelementals_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-27",17),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "Skelementals",
                null,
                null
            );
        }

        [Test]
        public void Deck19_ThekingFor1000years_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-27",18),
                "PostAstrolabeBan",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }


    }
}

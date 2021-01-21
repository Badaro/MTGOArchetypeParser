using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Volollo: Rakdos Prowess (BR, Lurrus)
#02 RRozanski: Gruul Midrange (RG)
#03 juzam_gin: Dredge (WBRG)
#04 Toastxp: Azorius Control (WU)
#05 Gigglesworth: Bant Midrange (WUG)
#06 Jositoshekel: Burn (WR)
#07 Theo_Jung: Rakdos Prowess (BR, Lurrus)
#08 MTG-Maestro: Gruul Midrange (RG)
#09 trader08111: Mardu Prowess (WBR, Lurrus)
#10 PeanutBrittle: Mono Red Prowess (R, Jegantha)
#11 CHILLEDADED: Green Tron (G)
#12 TombSimon: Titan Shift (RG)
#13 ImmanuelKantrolGod: Bant Control (WUG)
#14 qbturtle15: Gruul Midrange (RG)
#15 jaaaaabs21: Gruul Midrange (RG)
#16 Xwhale: Rakdos Prowess (BR, Lurrus)
#17 ecobaronen: Mono Red Prowess (R)
#18 ShowTime_: Jund Midrange (BRG)
#19 Gigy: Gruul Midrange (RG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_08_21 : EventTest
    {
        [Test]
        public void Deck01_Volollo_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-21",0),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_RRozanski_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-21",1),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck03_juzamgin_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-21",2),
                "PostAstrolabeBan",
                ArchetypeColor.WBRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck04_Toastxp_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-21",3),
                "PostAstrolabeBan",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck05_Gigglesworth_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-21",4),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck06_Jositoshekel_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-21",5),
                "PostAstrolabeBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck07_TheoJung_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-21",6),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_MTGMaestro_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-21",7),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck09_trader08111_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-21",8),
                "PostAstrolabeBan",
                ArchetypeColor.WBR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_PeanutBrittle_MonoRedProwess_R_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-21",9),
                "PostAstrolabeBan",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck11_CHILLEDADED_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-21",10),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck12_TombSimon_TitanShift_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-21",11),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "TitanShift",
                null
            );
        }

        [Test]
        public void Deck13_ImmanuelKantrolGod_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-21",12),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck14_qbturtle15_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-21",13),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck15_jaaaaabs21_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-21",14),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck16_Xwhale_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-21",15),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_ecobaronen_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-21",16),
                "PostAstrolabeBan",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck18_ShowTime_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-21",17),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck19_Gigy_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-21",18),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }


    }
}

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
#01 Volollo: Rakdos Prowess (BR, Lurrus)
#02 RRozanski: Gruul Midrange (RG)
#03 juzam_gin: Dredge (BRG)
#04 Toastxp: Azorius Control (WU)
#05 Gigglesworth: Bant Midrange (WUG)
#06 Jositoshekel: Incinerator Burn (WR)
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
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_RRozanski_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-21",1),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck03_juzamgin_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-21",2),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Toastxp_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-21",3),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Gigglesworth_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-21",4),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Jositoshekel_IncineratorBurn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-21",5),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                typeof(IncineratorBurn),
                null
            );
        }

        [Test]
        public void Deck07_TheoJung_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-21",6),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_MTGMaestro_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-21",7),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck09_trader08111_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-21",8),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_PeanutBrittle_MonoRedProwess_R_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-21",9),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck11_CHILLEDADED_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-21",10),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck12_TombSimon_TitanShift_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-21",11),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck13_ImmanuelKantrolGod_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-21",12),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck14_qbturtle15_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-21",13),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck15_jaaaaabs21_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-21",14),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Xwhale_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-21",15),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_ecobaronen_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-21",16),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck18_ShowTime_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-21",17),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck19_Gigy_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-21",18),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }


    }
}

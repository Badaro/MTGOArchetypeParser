using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Darkiundsa: Grixis Shadow (UBR)
#02 Sodeq: Ad Nauseam (WUB)
#03 bennybo: Ad Nauseam (WUB)
#04 kanister: Sultai Control (UBG)
#05 komattaman: Gruul Midrange (RG)
#06 ImmanuelKantrolGod: Bant Control (WUG)
#07 musasabi: Reclaimer Titan (WG)
#08 scipios: Crabvine (UBG)
#09 mstuff63: Rakdos Prowess (BR, Lurrus)
#10 Moniz0801: Amulet Titan (RG)
#11 __matsugan: Ad Nauseam (WUB)
#12 Rav104: Izzet Prowess (UR)
#13 Yanti: Gruul Midrange (RG)
#14 faisal: Jund Midrange (BRG)
#15 Nekonii: Elves (BG)
#16 Delthar: Mill (UB)
#17 Nikachu: Merfolk (UG)
#18 Erik157751: Dredge (UBRG)
#19 medvedev: Amulet Titan (RG)
#20 calheiros: Amulet Titan (UG)
#21 Filyoni: Dredge (BRG)
#22 McWinSauce: Bant Control (WUG)
#23 Baku_91: Rakdos Prowess (BR, Lurrus)
#24 SebastianStueckl: Boros Prowess (WR, Lurrus)
#25 Lukas261997: Devoted (WG, Lurrus)
#26 _Stream: Izzet Prowess (UR)
#27 bmac668: Rakdos Prowess (BR, Lurrus)
#28 toondoslav: Infect (WUG)
#29 ShishaMisha: Jund Midrange (BRG)
#30 hcook725: Uroza (WUG)
#31 tuckbear: Pyro Prison (R)
#32 joetru: Jund Midrange (BRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_challenge_2020_09_07 : EventTest
    {
        [Test]
        public void Deck01_Darkiundsa_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",0),
                "PostAstrolabeBan",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck02_Sodeq_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",1),
                "PostAstrolabeBan",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck03_bennybo_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",2),
                "PostAstrolabeBan",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck04_kanister_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",3),
                "PostAstrolabeBan",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck05_komattaman_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",4),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck06_ImmanuelKantrolGod_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",5),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck07_musasabi_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",6),
                "PostAstrolabeBan",
                ArchetypeColor.WG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck08_scipios_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",7),
                "PostAstrolabeBan",
                ArchetypeColor.UBG,
                "Crabvine",
                null,
                null
            );
        }

        [Test]
        public void Deck09_mstuff63_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",8),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_Moniz0801_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",9),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck11_matsugan_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",10),
                "PostAstrolabeBan",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck12_Rav104_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",11),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck13_Yanti_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",12),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck14_faisal_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",13),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck15_Nekonii_Elves_BG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",14),
                "PostAstrolabeBan",
                ArchetypeColor.BG,
                "Elves",
                null,
                null
            );
        }

        [Test]
        public void Deck16_Delthar_Mill_UB()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",15),
                "PostAstrolabeBan",
                ArchetypeColor.UB,
                "Mill",
                null,
                null
            );
        }

        [Test]
        public void Deck17_Nikachu_Merfolk_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",16),
                "PostAstrolabeBan",
                ArchetypeColor.UG,
                "Merfolk",
                null,
                null
            );
        }

        [Test]
        public void Deck18_Erik157751_Dredge_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",17),
                "PostAstrolabeBan",
                ArchetypeColor.UBRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck19_medvedev_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",18),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck20_calheiros_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",19),
                "PostAstrolabeBan",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck21_Filyoni_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",20),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck22_McWinSauce_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",21),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck23_Baku91_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",22),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck24_SebastianStueckl_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",23),
                "PostAstrolabeBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_Lukas261997_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",24),
                "PostAstrolabeBan",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck26_Stream_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",25),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck27_bmac668_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",26),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck28_toondoslav_Infect_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",27),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck29_ShishaMisha_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",28),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck30_hcook725_Uroza_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",29),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck31_tuckbear_PyroPrison_R()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",30),
                "PostAstrolabeBan",
                ArchetypeColor.R,
                "PyroPrison",
                null,
                null
            );
        }

        [Test]
        public void Deck32_joetru_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",31),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }


    }
}

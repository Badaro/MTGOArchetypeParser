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
#01 Darkiundsa: Grixis Shadow (UBR)
#02 Sodeq: Ad Nauseam (WUB)
#03 bennybo: Ad Nauseam (WUB)
#04 kanister: Sultai Control (UBG)
#05 komattaman: Gruul Midrange (RG)
#06 ImmanuelKantrolGod: Bant Control (WUG)
#07 musasabi: Reclaimer Titan (WRG)
#08 scipios: Crabvine (UBG)
#09 mstuff63: Rakdos Prowess (BR, Lurrus)
#10 Moniz0801: Amulet Titan (URG)
#11 __matsugan: Ad Nauseam (WUB)
#12 Rav104: Izzet Prowess (UR)
#13 Yanti: Gruul Midrange (RG)
#14 faisal: Jund Midrange (BRG)
#15 Nekonii: Golgari Elves (BG)
#16 Delthar: Mill (UB)
#17 Nikachu: Merfolk (UG)
#18 Erik157751: Dredge (UBRG)
#19 medvedev: Amulet Titan (UBRG)
#20 calheiros: KGC Amulet Titan (UBRG)
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
#31 tuckbear: Red Prison (R)
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
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Sodeq_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",1),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck03_bennybo_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",2),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck04_kanister_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",3),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_komattaman_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",4),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck06_ImmanuelKantrolGod_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",5),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_musasabi_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",6),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck08_scipios_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",7),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck09_mstuff63_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",8),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_Moniz0801_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",9),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck11_matsugan_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",10),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Rav104_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",11),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Yanti_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",12),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck14_faisal_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",13),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Nekonii_GolgariElves_BG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",14),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(Elves),
                typeof(GolgariElves),
                null
            );
        }

        [Test]
        public void Deck16_Delthar_Mill_UB()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",15),
                new PostAstrolabeBan(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Nikachu_Merfolk_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",16),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Erik157751_Dredge_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",17),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck19_medvedev_AmuletTitan_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",18),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck20_calheiros_KGCAmuletTitan_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",19),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck21_Filyoni_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",20),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck22_McWinSauce_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",21),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Baku91_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",22),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck24_SebastianStueckl_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",23),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_Lukas261997_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",24),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck26_Stream_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",25),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck27_bmac668_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",26),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck28_toondoslav_Infect_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",27),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck29_ShishaMisha_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",28),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck30_hcook725_Uroza_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",29),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck31_tuckbear_RedPrison_R()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",30),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(RedPrison),
                null,
                null
            );
        }

        [Test]
        public void Deck32_joetru_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-07",31),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }


    }
}

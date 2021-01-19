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
#01 kanister: Humans (WUBRG)
#02 MrRaeb: Uroza (UG)
#03 pootisgodsamongus: Obosh Aggro (R, Obosh)
#04 Nikachu: Merfolk (UG)
#05 Skrown: Grixis Shadow (UBR)
#06 Artem_Kuhtin: White Devotion (W)
#07 musasabi: Reclaimer Titan (WG)
#08 Laplasjan: Devoted (WG, Lurrus)
#09 RoadmanEvans: Izzet Prowess (UR)
#10 alemilan19: Sultai Control (UBG)
#11 faisal: Jund Midrange (BRG)
#12 nahuel10: Izzet Prowess (UR)
#13 TuggaNaxos: Rakdos Prowess (BR, Lurrus)
#14 Rooney56: Grixis Shadow (UBR)
#15 SebastianStueckl: Obosh Aggro (R, Obosh)
#16 Rinko: Enduring Ideal (W)
#17 _Batutinha_: Bant Control (WUG)
#18 Raptor_Nachos: Burn (WR, Lurrus)
#19 bennybo: Ad Nauseam (WUB)
#20 Fluorspar: Humans (WUBRG)
#21 raven0904: Green Tron (G)
#22 WingedHussar: Neobrand (UG)
#23 pandanaconda: Hardened Scales (G)
#24 Oderus Urungus: Bogles (WG, Lurrus)
#25 staffmat1992: Gruul Midrange (RG)
#26 CReactor: Rakdos Prowess (BR, Lurrus)
#27 Vallejo97: Gruul Midrange (RG)
#28 ejcos531: Izzet Prowess (UR)
#29 Wtnof: Gruul Midrange (RG)
#30 ThekingFor1000years: Infect (WUG)
#31 _LSN_: Burn (WR, Lurrus)
#32 WeareVenom: Bant Control (WUG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_challenge_2020_09_14 : EventTest
    {
        [Test]
        public void Deck01_kanister_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-14",0),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck02_MrRaeb_Uroza_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-14",1),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck03_pootisgodsamongus_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-09-14",2),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck04_Nikachu_Merfolk_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-14",3),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Skrown_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-14",4),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck06_ArtemKuhtin_WhiteDevotion_W()
        {
            Test(
                GetDeck("modern-challenge-2020-09-14",5),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(WhiteDevotion),
                null,
                null
            );
        }

        [Test]
        public void Deck07_musasabi_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-14",6),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck08_Laplasjan_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-14",7),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_RoadmanEvans_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-14",8),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck10_alemilan19_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-14",9),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck11_faisal_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-14",10),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck12_nahuel10_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-14",11),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck13_TuggaNaxos_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-14",12),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_Rooney56_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-14",13),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck15_SebastianStueckl_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-09-14",14),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck16_Rinko_EnduringIdeal_W()
        {
            Test(
                GetDeck("modern-challenge-2020-09-14",15),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(EnduringIdeal),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Batutinha_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-14",16),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck18_RaptorNachos_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-14",17),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck19_bennybo_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-09-14",18),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Fluorspar_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-14",19),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck21_raven0904_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-09-14",20),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck22_WingedHussar_Neobrand_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-14",21),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck23_pandanaconda_HardenedScales_G()
        {
            Test(
                GetDeck("modern-challenge-2020-09-14",22),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck24_OderusUrungus_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-14",23),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_staffmat1992_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-14",24),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck26_CReactor_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-14",25),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck27_Vallejo97_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-14",26),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck28_ejcos531_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-14",27),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Wtnof_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-14",28),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck30_ThekingFor1000years_Infect_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-14",29),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck31_LSN_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-14",30),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck32_WeareVenom_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-14",31),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}

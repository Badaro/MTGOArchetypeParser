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
#03 pootisgodsamongus: OboshAggro (R, Obosh)
#04 Nikachu: Merfolk (UG)
#05 Skrown: GrixisShadow (UBR)
#06 Artem_Kuhtin: WhiteDevotion (W)
#07 musasabi: PrimevalTitan (WRG)
#08 Laplasjan: Devoted (WG, Lurrus)
#09 RoadmanEvans: IzzetProwess (UR)
#10 alemilan19: SultaiControl (UBG)
#11 faisal: JundMidrange (BRG)
#12 nahuel10: IzzetProwess (UR)
#13 TuggaNaxos: RakdosProwess (BR, Lurrus)
#14 Rooney56: GrixisShadow (UBR)
#15 SebastianStueckl: OboshAggro (R, Obosh)
#16 Rinko: EnduringIdeal (W)
#17 _Batutinha_: BantControl (WUG)
#18 Raptor_Nachos: Burn (WR, Lurrus)
#19 bennybo: AdNauseam (WUB)
#20 Fluorspar: Humans (WUBRG)
#21 raven0904: GTron (G)
#22 WingedHussar: Neobrand (UG)
#23 pandanaconda: HardenedScales (G)
#24 Oderus Urungus: Bogles (WG, Lurrus)
#25 staffmat1992: GruulMidrange (RG)
#26 CReactor: RakdosProwess (BR, Lurrus)
#27 Vallejo97: GruulMidrange (RG)
#28 ejcos531: IzzetProwess (UR)
#29 Wtnof: GruulMidrange (RG)
#30 ThekingFor1000years: Infect (WUG)
#31 _LSN_: Burn (WR, Lurrus)
#32 WeareVenom: BantControl (WUG)
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
                typeof(GenericShadow),
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
        public void Deck07_musasabi_PrimevalTitan_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-14",6),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
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
                typeof(GenericShadow),
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
        public void Deck21_raven0904_GTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-09-14",20),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                null,
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

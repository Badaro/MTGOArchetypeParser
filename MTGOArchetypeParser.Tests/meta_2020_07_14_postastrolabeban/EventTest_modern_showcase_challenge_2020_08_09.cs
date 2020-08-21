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
#01 Lavaridge: TemurReclamation (URG)
#02 romanmy: RakdosProwess (WBR, Lurrus)
#03 Selfeisek: Burn (WR, Lurrus)
#04 SparTaNxX: AdNauseam (WUB)
#05 Sodeq: Dredge (BRG)
#06 XxquestionablyawesomexX: Bogles (WG)
#07 Nosferatu: BantControl (WUG)
#08 Smdster: RakdosProwess (BR, Lurrus)
#09 Oderus Urungus: Ponza (RG)
#10 _Batutinha_: TraverseShadow (BRG)
#11 ReturnToDust: TitanVial (WRG)
#12 Soulerino: Burn (WR)
#13 chengyiw: IzzetProwess (UR)
#14 NorrathDecay: Burn (WR)
#15 iwanteatebi: IzzetProwess (UR)
#16 dani_chad: Jund (BRG)
#17 jschloss: KGCTron (G)
#18 Mcleskey: Burn (WR)
#19 NAP_DARKMAGE_MJM: IzzetProwess (UR)
#20 Metcalf23: EldraziTaxes (WB)
#21 MadMaxErnst: SultaiControl (UBG)
#22 banskk: IzzetProwess (UR)
#23 DreamsOfAshiok: ETron (C)
#24 Mateusf34: ETron (C)
#25 aqualog: Prowess (WR, Lurrus)
#26 TuggaNaxos: Crabvine (UBG)
#27 Danielstallone: Burn (WR)
#28 Novaphantom: ETron (C)
#29 GoblinK1ng: Goblins (BRG)
#30 Capitano_CL: Dredge (WBRG)
#31 AlabasterWolfie: SnoopGoblins (BR)
#32 Kuhb: IzzetProwess (UR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_showcase_challenge_2020_08_09 : EventTest
    {
        [Test]
        public void Deck01_Lavaridge_WildernessReclamation_TemurReclamation_URG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",0),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(WildernessReclamation),
                typeof(TemurReclamation),
                null
            );
        }

        [Test]
        public void Deck02_romanmy_Prowess_RakdosProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",1),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(Prowess),
                typeof(RakdosProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_Selfeisek_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",2),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_SparTaNxX_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",3),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Sodeq_Dredge_BRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",4),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck06_XxquestionablyawesomexX_Bogles_WG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",5),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Nosferatu_BantControl_WUG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",6),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(BantControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Smdster_Prowess_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",7),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Prowess),
                typeof(RakdosProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_OderusUrungus_Ponza_RG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",8),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Batutinha_DeathsShadow_TraverseShadow_BRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",9),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(DeathsShadow),
                typeof(TraverseShadow),
                null
            );
        }

        [Test]
        public void Deck11_ReturnToDust_TitanVial_WRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",10),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(TitanVial),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Soulerino_Burn_WR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",11),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck13_chengyiw_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",12),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck14_NorrathDecay_Burn_WR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",13),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck15_iwanteatebi_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",14),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck16_danichad_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",15),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck17_jschloss_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",16),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck18_Mcleskey_Burn_WR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",17),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck19_NAPDARKMAGEMJM_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",18),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck20_Metcalf23_DeathAndTaxes_EldraziTaxes_WB()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",19),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(DeathAndTaxes),
                typeof(EldraziTaxes),
                null
            );
        }

        [Test]
        public void Deck21_MadMaxErnst_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",20),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(SultaiControl),
                null,
                null
            );
        }

        [Test]
        public void Deck22_banskk_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",21),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck23_DreamsOfAshiok_ETron_C()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",22),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Mateusf34_ETron_C()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",23),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck25_aqualog_Prowess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",24),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Prowess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck26_TuggaNaxos_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",25),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck27_Danielstallone_Burn_WR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",26),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Novaphantom_ETron_C()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",27),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck29_GoblinK1ng_Goblins_BRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",28),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck30_CapitanoCL_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",29),
                new PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck31_AlabasterWolfie_Goblins_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",30),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck32_Kuhb_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",31),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }


    }
}

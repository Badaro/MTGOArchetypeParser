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
#01 Lavaridge: Temur Reclamation (URG)
#02 romanmy: Mardu Prowess (WBR, Lurrus)
#03 Selfeisek: Burn (WR, Lurrus)
#04 SparTaNxX: Ad Nauseam (WUB)
#05 Sodeq: Dredge (BRG)
#06 XxquestionablyawesomexX: Bogles (WG)
#07 Nosferatu: Bant Control (WUG)
#08 Smdster: Rakdos Prowess (BR, Lurrus)
#09 Oderus Urungus: Gruul Midrange (RG)
#10 _Batutinha_: Jund Shadow (BRG)
#11 ReturnToDust: Reclaimer Titan (WG)
#12 Soulerino: Burn (WR)
#13 chengyiw: Izzet Prowess (UR)
#14 NorrathDecay: Burn (WR)
#15 iwanteatebi: Izzet Prowess (UR)
#16 dani_chad: Jund Midrange (BRG)
#17 jschloss: Green Tron (G)
#18 Mcleskey: Burn (WR)
#19 NAP_DARKMAGE_MJM: Izzet Prowess (UR)
#20 Metcalf23: Orzhov Taxes (WB)
#21 MadMaxErnst: Sultai Control (UBG)
#22 banskk: Izzet Prowess (UR)
#23 DreamsOfAshiok: Eldrazi Tron (C)
#24 Mateusf34: Eldrazi Tron (C)
#25 aqualog: Boros Prowess (WR, Lurrus)
#26 TuggaNaxos: Crabvine (UBG)
#27 Danielstallone: Burn (WR)
#28 Novaphantom: Eldrazi Tron (C)
#29 GoblinK1ng: Goblins (BRG)
#30 Capitano_CL: Dredge (WBRG)
#31 AlabasterWolfie: Goblins (BR)
#32 Kuhb: Izzet Prowess (UR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_showcase_challenge_2020_08_09 : EventTest
    {
        [Test]
        public void Deck01_Lavaridge_TemurReclamation_URG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",0),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Reclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck02_romanmy_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",1),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(RedAggro),
                typeof(Prowess),
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
                typeof(RedAggro),
                typeof(Burn),
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
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Smdster_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",7),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(RedAggro),
                typeof(Prowess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_OderusUrungus_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",8),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Batutinha_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",9),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck11_ReturnToDust_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",10),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
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
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck13_chengyiw_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",12),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(RedAggro),
                typeof(Prowess),
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
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck15_iwanteatebi_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",14),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck16_danichad_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",15),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck17_jschloss_GreenTron_G()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",16),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
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
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck19_NAPDARKMAGEMJM_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",18),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck20_Metcalf23_OrzhovTaxes_WB()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",19),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(GenericTaxes),
                null,
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
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck22_banskk_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",21),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck23_DreamsOfAshiok_EldraziTron_C()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",22),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck24_Mateusf34_EldraziTron_C()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",23),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck25_aqualog_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",24),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Prowess),
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
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck28_Novaphantom_EldraziTron_C()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",27),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
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
        public void Deck31_AlabasterWolfie_Goblins_BR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",30),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck32_Kuhb_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-08-09",31),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }


    }
}

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
#01 UmekawaneikU: Jund Shadow (BRG, Lurrus)
#02 unicornparadise: Jund Shadow (BRG, Lurrus)
#03 in5ano: Scapeshift (URG, Yorion)
#04 Traft: Ad Nauseam (WUB)
#05 Diem4x: Jund Midrange (BRG, Lurrus)
#06 mashmalovsky: Hammer Time (WR, Lurrus)
#07 AutumnLily: Sultai Control (UBG, Yorion)
#08 Metcalf23: Boros Taxes (WR, Lurrus)
#09 Toastxp: Jund Shadow (BRG, Lurrus)
#10 MATTHEWFOULKES: Jund Prowess (BRG, Lurrus)
#11 Lord_Beerus: Bant Control (WUG, Yorion)
#12 Sorph: Bant Control (WUG, Yorion)
#13 GALL: Rakdos Prowess (BR, Lurrus)
#14 LORiWWA: Eldrazi Tron (C)
#15 Diatomic: Bant Control (WUG, Yorion)
#16 Brokenwingss: Boros Prowess (WR, Lurrus)
#17 Wartico1: Mardu Prowess (WBR, Lurrus)
#18 NorrathDecay: Burn (WR)
#19 ack_s: Hammer Time (WR, Lurrus)
#20 PRGJJAR: Dredge (BRG)
#21 josemasalteras: Gruul Midrange (RG, Obosh)
#22 JimathanFTW: Ad Nauseam (WUB)
#23 TennTyou: Niv To Light (WUBRG, Jegantha)
#24 AndyAWKWARD: Scapeshift (WURG, Yorion)
#25 _LSN_: Burn (WR, Lurrus)
#26 eminemberry: Burn (WR, Lurrus)
#27 musasabi: Jund Midrange (BRG, Lurrus)
#28 TSPJendrek: Esper Control (WUB, Zirda)
#29 coert: Eldrazi Tron (C)
#30 shadow_PT: Rakdos Prowess (BR, Lurrus)
#31 Gigy: Gruul Midrange (RG, Obosh)
#32 drRobotGranata: Ad Nauseam (WUB)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_challenge_2020_06_01 : EventTest
    {
        [Test]
        public void Deck01_UmekawaneikU_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-06-01",0),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_unicornparadise_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-06-01",1),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_in5ano_Scapeshift_URG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-06-01",2),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck04_Traft_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-06-01",3),
                new PostIkoria(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Diem4x_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-06-01",4),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_mashmalovsky_HammerTime_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-06-01",5),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_AutumnLily_SultaiControl_UBG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-06-01",6),
                new PostIkoria(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck08_Metcalf23_BorosTaxes_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-06-01",7),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_Toastxp_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-06-01",8),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_MATTHEWFOULKES_JundProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-06-01",9),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_LordBeerus_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-06-01",10),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck12_Sorph_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-06-01",11),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck13_GALL_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-06-01",12),
                new PostIkoria(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_LORiWWA_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-06-01",13),
                new PostIkoria(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck15_Diatomic_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-06-01",14),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck16_Brokenwingss_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-06-01",15),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_Wartico1_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-06-01",16),
                new PostIkoria(),
                ArchetypeColor.WBR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_NorrathDecay_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-01",17),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck19_acks_HammerTime_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-06-01",18),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck20_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-01",19),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck21_josemasalteras_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-06-01",20),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck22_JimathanFTW_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-06-01",21),
                new PostIkoria(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck23_TennTyou_NivToLight_WUBRG_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-06-01",22),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck24_AndyAWKWARD_Scapeshift_WURG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-06-01",23),
                new PostIkoria(),
                ArchetypeColor.WURG,
                typeof(Scapeshift),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck25_LSN_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-06-01",24),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck26_eminemberry_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-06-01",25),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck27_musasabi_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-06-01",26),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck28_TSPJendrek_EsperControl_WUB_Zirda()
        {
            Test(
                GetDeck("modern-challenge-2020-06-01",27),
                new PostIkoria(),
                ArchetypeColor.WUB,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Zirda
            );
        }

        [Test]
        public void Deck29_coert_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-06-01",28),
                new PostIkoria(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck30_shadowPT_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-06-01",29),
                new PostIkoria(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck31_Gigy_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-06-01",30),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck32_drRobotGranata_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-06-01",31),
                new PostIkoria(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }


    }
}
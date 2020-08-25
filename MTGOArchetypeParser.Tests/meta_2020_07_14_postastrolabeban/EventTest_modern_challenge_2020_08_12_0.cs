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
#01 blastoids: AzoriusStoneblade (WU)
#02 GedionRavenor: WildernessReclamation (WUG)
#03 LyaApocalypse: KGCTron (G)
#04 qbturtle15: Jund (BRG)
#05 indianpancake: SuicideShadow (BRG, Lurrus)
#06 Samcaster-Mage: ETron (C)
#07 andrw1232: RakdosProwess (BR, Lurrus)
#08 _Falcon_: IzzetProwess (UR)
#09 cftsoc3: BantBlink (WUG)
#10 D00mwake: RakdosProwess (BR, Lurrus)
#11 exoticherman: RakdosProwess (BR, Lurrus)
#12 tanisong1221: SultaiSnow (UBG)
#13 CHILLEDADED: Ponza (RG)
#14 RCMerriam: TraverseShadow (UBRG)
#15 Oscar_Franco: Jund (BRG)
#16 sultai4lyfe: DimirControl (UB)
#17 MissTrigger: IncineratorBurn (R)
#18 patheus_84: AdNauseam (WUB)
#19 JV_7777: ETron (C)
#20 CanadianNinja: BringToNiv (WUBRG, Yorion)
#21 yu-ki: ETron (C)
#22 didoguidotti1: SnowBlade (WUG)
#23 Xwhale: IzzetProwess (UR)
#24 Maox: IzzetProwess (UR)
#25 NorrathDecay: KGCTron (G)
#26 anamika: Elementals (WUBRG)
#27 lilianaofthevess: TraverseShadow (BRG)
#28 bigjc00: AmuletTitan (URG)
#29 cws: GiftsStorm (UR)
#30 aspiringspike: AzoriusStoneblade (WU)
#31 kthanakit26: IzzetProwess (UR)
#32 Xenowan: HardenedScales (G)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_challenge_2020_08_12_0 : EventTest
    {
        [Test]
        public void Deck01_blastoids_AzoriusControl_AzoriusStoneblade_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",0),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_GedionRavenor_WildernessReclamation_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",1),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck03_LyaApocalypse_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",2),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck04_qbturtle15_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",3),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck05_indianpancake_DeathsShadow_SuicideShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",4),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_SamcasterMage_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",5),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck07_andrw1232_Prowess_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",6),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_Falcon_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",7),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck09_cftsoc3_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",8),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck10_D00mwake_Prowess_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",9),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_exoticherman_Prowess_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",10),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_tanisong1221_SnowControl_SultaiSnow_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",11),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck13_CHILLEDADED_Ponza_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",12),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck14_RCMerriam_DeathsShadow_TraverseShadow_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",13),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck15_OscarFranco_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",14),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck16_sultai4lyfe_DimirControl_UB()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",15),
                new PostAstrolabeBan(),
                ArchetypeColor.UB,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck17_MissTrigger_Burn_IncineratorBurn_R()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",16),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(Burn),
                typeof(IncineratorBurn),
                null
            );
        }

        [Test]
        public void Deck18_patheus84_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",17),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck19_JV7777_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",18),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck20_CanadianNinja_BringToNiv_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",19),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck21_yuki_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",20),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck22_didoguidotti1_SnowControl_SnowBlade_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",21),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Xwhale_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",22),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Maox_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",23),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck25_NorrathDecay_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",24),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck26_anamika_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",25),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck27_lilianaofthevess_DeathsShadow_TraverseShadow_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",26),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck28_bigjc00_PrimevalTitan_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",27),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck29_cws_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",28),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck30_aspiringspike_AzoriusControl_AzoriusStoneblade_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",29),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck31_kthanakit26_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",30),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck32_Xenowan_HardenedScales_G()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",31),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }


    }
}

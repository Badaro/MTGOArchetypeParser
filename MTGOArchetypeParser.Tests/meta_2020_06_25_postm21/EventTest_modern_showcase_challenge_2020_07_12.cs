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
#01 musasabi: KGCAmuletTitan (UBRG)
#02 jmeyer2030: SnowShift (URG, Yorion)
#03 DaniMRebel: DeathAndTaxes (WG)
#04 Thrall90: Jund (BRG)
#05 SunofNothing: SnowControl (WUG)
#06 MrRaeb: Uroza (UBG, Yorion)
#07 wambocombo2020: SnowShift (URG, Yorion)
#08 BSK_hercules: IzzetProwess (UR)
#09 kbr3: HardenedScales (G)
#10 Shamwowfella: SultaiSnow (UBG)
#11 siomomi: ETron (C)
#12 nahuel10: SnowReclamation (UBG)
#13 mariogomes097: GrixisShadow (UBR)
#14 EnlargedToShowTexture: SnoopGoblins (BR)
#15 Justodeangelo: SnowControl (WUG)
#16 karn_90: TemurSnow (URG)
#17 zachattack23: SnowControl (WUG)
#18 ArchaeusDota: KGCTron (G)
#19 MCScards: Jund (BRG)
#20 MrSeri: HardenedScales (G)
#21 qbturtle15: Jund (BRG)
#22 hugofreitas1: GiftsStorm (UR)
#23 cws: GiftsStorm (UR)
#24 otakkun: KGCTron (G)
#25 FreedMania: KGCAmuletTitan (WUBRG)
#26 yamakiller: Dredge (BRG)
#27 Juaspas: Ponza (RG)
#28 Fenrir18: SnoopGoblins (BR)
#29 LORiWWA: ETron (C)
#30 Mateusf34: ETron (C)
#31 N3to: GiftsStorm (UR)
#32 xakx47x: Devoted (WG, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_25_postm21
{
    public class EventTest_modern_showcase_challenge_2020_07_12 : EventTest
    {
        [Test]
        public void Deck01_musasabi_PrimevalTitan_KGCAmuletTitan_UBRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",0),
                new PostM21(),
                ArchetypeColor.UBRG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck02_jmeyer2030_SnowControl_SnowShift_URG_Yorion()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",1),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck03_DaniMRebel_DeathAndTaxes_WG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",2),
                new PostM21(),
                ArchetypeColor.WG,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Thrall90_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",3),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck05_SunofNothing_SnowControl_WUG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",4),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck06_MrRaeb_Uroza_UBG_Yorion()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",5),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck07_wambocombo2020_SnowControl_SnowShift_URG_Yorion()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",6),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck08_BSKhercules_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",7),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck09_kbr3_HardenedScales_G()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",8),
                new PostM21(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Shamwowfella_SnowControl_SultaiSnow_UBG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",9),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck11_siomomi_ETron_C()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",10),
                new PostM21(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck12_nahuel10_SnowControl_SnowReclamation_UBG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",11),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(GenericReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck13_mariogomes097_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",12),
                new PostM21(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck14_EnlargedToShowTexture_Goblins_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",13),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck15_Justodeangelo_SnowControl_WUG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",14),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck16_karn90_SnowControl_TemurSnow_URG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",15),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck17_zachattack23_SnowControl_WUG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",16),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck18_ArchaeusDota_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",17),
                new PostM21(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck19_MCScards_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",18),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck20_MrSeri_HardenedScales_G()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",19),
                new PostM21(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck21_qbturtle15_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",20),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck22_hugofreitas1_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",21),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck23_cws_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",22),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck24_otakkun_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",23),
                new PostM21(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck25_FreedMania_PrimevalTitan_KGCAmuletTitan_WUBRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",24),
                new PostM21(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck26_yamakiller_Dredge_BRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",25),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck27_Juaspas_Ponza_RG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",26),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Fenrir18_Goblins_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",27),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck29_LORiWWA_ETron_C()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",28),
                new PostM21(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Mateusf34_ETron_C()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",29),
                new PostM21(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck31_N3to_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",30),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck32_xakx47x_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",31),
                new PostM21(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}

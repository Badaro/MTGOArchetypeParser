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
#01 Icteridae: HeliodDevoted (WUG)
#02 rastaf: KGCTron (G)
#03 FrankEG_MTG: Humans (WUBRG)
#04 fpawlusz: AmuletTitan (WUBRG)
#05 Laplasjan: Devoted (WG, Lurrus)
#06 BSK_hercules: Ponza (RG)
#07 mariogomes097: GrixisShadow (UBR)
#08 TubbyBatman: NarsetsUndoing (UB)
#09 Boland: Dredge (BRG)
#10 MZBlazer: SultaiSnow (UBG)
#11 DreamsOfAshiok: ETron (C)
#12 Mcleskey: Burn (WR)
#13 killersuv: SnowReclamation (UBG)
#14 Papelucho10: Infect (UG)
#15 tkphi: Burn (WR)
#16 eggybenny: ETron (C)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_04_postcompanionchange
{
    public class EventTest_modern_preliminary_2020_06_25 : EventTest
    {
        [Test]
        public void Deck01_Icteridae_Devoted_HeliodDevoted_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-25",0),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(Devoted),
                typeof(HeliodDevoted),
                null
            );
        }

        [Test]
        public void Deck02_rastaf_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-25",1),
                new PostCompanionChange(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck03_FrankEGMTG_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-25",2),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck04_fpawlusz_PrimevalTitan_AmuletTitan_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-25",3),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck05_Laplasjan_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-25",4),
                new PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_BSKhercules_Ponza_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-25",5),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck07_mariogomes097_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-25",6),
                new PostCompanionChange(),
                ArchetypeColor.UBR,
                typeof(DeathsShadow),
                typeof(GrixisShadow),
                null
            );
        }

        [Test]
        public void Deck08_TubbyBatman_NarsetsUndoing_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-25",7),
                new PostCompanionChange(),
                ArchetypeColor.UB,
                typeof(NarsetsUndoing),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Boland_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-25",8),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck10_MZBlazer_SnowControl_SultaiSnow_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-25",9),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck11_DreamsOfAshiok_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-25",10),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Mcleskey_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-25",11),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck13_killersuv_SnowControl_SnowReclamation_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-25",12),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SnowReclamation),
                null
            );
        }

        [Test]
        public void Deck14_Papelucho10_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-25",13),
                new PostCompanionChange(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck15_tkphi_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-25",14),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck16_eggybenny_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-25",15),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }


    }
}

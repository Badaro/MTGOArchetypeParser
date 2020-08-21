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
#01 Mordeka1ser: BringToNiv (WUBRG, Yorion)
#02 kthanakit26: Burn (WR)
#03 SebastianStueckl: Ponza (RG)
#04 azatoyellow: GruulProwess (RG, Jegantha)
#05 Niedzwiedz: SnoopGoblins (BR)
#06 gyyby297: ThopterUrza (WU)
#07 tia05: TitanShift (RG)
#08 Ganksyou: AzoriusStoneblade (WU)
#09 Cherryxman: Scapeshift (URG)
#10 Lukas261997: AzoriusStoneblade (WU)
#11 JustBurn420: Slivers (WUBRG)
#12 Healer: IncineratorBurn (R)
#13 Toastxp: TraverseShadow (UBRG)
#14 Hyeri0418: Dredge (WBRG)
#15 sff_mtg: KGCTron (G)
#16 siomomi: ETron (C)
#17 otakkun: KGCTron (G)
#18 _INF_: GiftsStorm (UR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_07_24 : EventTest
    {
        [Test]
        public void Deck01_Mordeka1ser_BringToNiv_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-24",0),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck02_kthanakit26_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-24",1),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck03_SebastianStueckl_Ponza_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-24",2),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck04_azatoyellow_Prowess_GruulProwess_RG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-24",3),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Prowess),
                typeof(GruulProwess),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck05_Niedzwiedz_Goblins_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-24",4),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck06_gyyby297_ThopterUrza_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-24",5),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck07_tia05_PrimevalTitan_TitanShift_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-24",6),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck08_Ganksyou_AzoriusControl_AzoriusStoneblade_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-24",7),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                typeof(AzoriusStoneblade),
                null
            );
        }

        [Test]
        public void Deck09_Cherryxman_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-24",8),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Lukas261997_AzoriusControl_AzoriusStoneblade_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-24",9),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                typeof(AzoriusStoneblade),
                null
            );
        }

        [Test]
        public void Deck11_JustBurn420_Slivers_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-24",10),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Slivers),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Healer_Burn_IncineratorBurn_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-24",11),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(Burn),
                typeof(IncineratorBurn),
                null
            );
        }

        [Test]
        public void Deck13_Toastxp_DeathsShadow_TraverseShadow_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-24",12),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(DeathsShadow),
                typeof(TraverseShadow),
                null
            );
        }

        [Test]
        public void Deck14_Hyeri0418_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-24",13),
                new PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck15_sffmtg_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-24",14),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck16_siomomi_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-24",15),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck17_otakkun_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-24",16),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck18_INF_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-24",17),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }


    }
}

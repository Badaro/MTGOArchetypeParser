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
#01 Mordeka1ser: Niv To Light (WUBRG, Yorion)
#02 kthanakit26: Burn (WR)
#03 SebastianStueckl: Gruul Midrange (RG)
#04 azatoyellow: Gruul Prowess (RG, Jegantha)
#05 Niedzwiedz: Goblins (BR)
#06 gyyby297: Thopter Urza (WU)
#07 tia05: Titan Shift (RG)
#08 Ganksyou: Azorius Control (WU)
#09 Cherryxman: Scapeshift (URG)
#10 Lukas261997: Azorius Control (WU)
#11 JustBurn420: Slivers (WUBRG)
#12 Healer: Burn (R)
#13 Toastxp: UBRG Shadow (UBRG)
#14 Hyeri0418: Dredge (WBRG)
#15 sff_mtg: Green Tron (G)
#16 siomomi: Eldrazi Tron (C)
#17 otakkun: Green Tron (G)
#18 _INF_: Gifts Storm (UR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_07_24 : EventTest
    {
        [Test]
        public void Deck01_Mordeka1ser_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-24",0),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
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
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck03_SebastianStueckl_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-24",2),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck04_azatoyellow_GruulProwess_RG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-24",3),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(RedAggro),
                typeof(Prowess),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck05_Niedzwiedz_Goblins_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-24",4),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                null,
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
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck07_tia05_TitanShift_RG()
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
        public void Deck08_Ganksyou_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-24",7),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
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
        public void Deck10_Lukas261997_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-24",9),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
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
        public void Deck12_Healer_Burn_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-24",11),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck13_Toastxp_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-24",12),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(Shadow),
                null,
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
        public void Deck15_sffmtg_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-24",14),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck16_siomomi_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-24",15),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck17_otakkun_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-24",16),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
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

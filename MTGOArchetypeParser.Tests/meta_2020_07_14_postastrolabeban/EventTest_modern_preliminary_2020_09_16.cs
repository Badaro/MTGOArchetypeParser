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
#01 __matsugan: Ad Nauseam (WUB)
#02 m-boy: Merfolk (UG)
#03 Violent_Outburst: Scapeshift (URG)
#04 kbzx: Dredge (WBRG)
#05 Mikhathara1994: Izzet Prowess (UR)
#06 moyashi0904: Reclamation (URG)
#07 felider: Eldrazi Tron (C)
#08 otakkun: Green Tron (G)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_09_16 : EventTest
    {
        [Test]
        public void Deck01_matsugan_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-16",0),
                "PostAstrolabeBan",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck02_mboy_Merfolk_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-16",1),
                "PostAstrolabeBan",
                ArchetypeColor.UG,
                "Merfolk",
                null,
                null
            );
        }

        [Test]
        public void Deck03_ViolentOutburst_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-16",2),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                null
            );
        }

        [Test]
        public void Deck04_kbzx_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-16",3),
                "PostAstrolabeBan",
                ArchetypeColor.WBRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck05_Mikhathara1994_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-16",4),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck06_moyashi0904_Reclamation_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-16",5),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck07_felider_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-16",6),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck08_otakkun_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-16",7),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }


    }
}

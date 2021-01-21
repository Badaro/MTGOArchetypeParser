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
#01 Blade400: Eldrazi Tron (C)
#02 xfile: Heliod Combo (WG)
#03 rinazina: Green Tron (G)
#04 Violent_Outburst: Scapeshift (URG)
#05 JakeHelms: Dimir Control (UB)
#06 Iburakema: Izzet Control (UR)
#07 mhskou: Obosh Aggro (R, Obosh)
#08 bigkahuna512: Mill (WUB)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_11_20 : EventTest
    {
        [Test]
        public void Deck01_Blade400_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-20",0),
                "PostZendikarRising",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck02_xfile_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-20",1),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck03_rinazina_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-20",2),
                "PostZendikarRising",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck04_ViolentOutburst_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-20",3),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                null
            );
        }

        [Test]
        public void Deck05_JakeHelms_DimirControl_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-20",4),
                "PostZendikarRising",
                ArchetypeColor.UB,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck06_Iburakema_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-20",5),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck07_mhskou_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-20",6),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck08_bigkahuna512_Mill_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-20",7),
                "PostZendikarRising",
                ArchetypeColor.WUB,
                "Mill",
                null,
                null
            );
        }


    }
}

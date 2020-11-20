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
#01 Blade400: E Tron (C)
#02 xfile: Heliod Combo (WG)
#03 rinazina: KGC Tron (G)
#04 Violent_Outburst: Scapeshift (URG)
#05 JakeHelms: Dimir Control (UB)
#06 Iburakema: Grixis Control (UBR)
#07 mhskou: Obosh Aggro (R, Obosh)
#08 bigkahuna512: Mill (WUB)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_11_20 : EventTest
    {
        [Test]
        public void Deck01_Blade400_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-20",0),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck02_xfile_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-20",1),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck03_rinazina_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-20",2),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck04_ViolentOutburst_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-20",3),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck05_JakeHelms_DimirControl_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-20",4),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Iburakema_GrixisControl_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-20",5),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_mhskou_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-20",6),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck08_bigkahuna512_Mill_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-20",7),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(Mill),
                null,
                null
            );
        }


    }
}

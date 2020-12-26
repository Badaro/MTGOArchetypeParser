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
#01 Violent_Outburst: Temur Control (URG)
#02 ZYX_Jerry: Belcher (URG)
#03 Bullwinkkle6705: UBRG Control (UBRG)
#04 Nammersquats: Infect (UG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_12_25 : EventTest
    {
        [Test]
        public void Deck01_ViolentOutburst_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-25",0),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_ZYXJerry_Belcher_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-25",1),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Bullwinkkle6705_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-25",2),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Nammersquats_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-25",3),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }


    }
}

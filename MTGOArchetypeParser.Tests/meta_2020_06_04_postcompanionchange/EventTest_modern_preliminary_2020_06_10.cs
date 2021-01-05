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
#01 signblindman: Gruul Midrange (RG)
#02 GedionRavenor: Bant Control (WUG)
#03 _Shatun_: Gruul Midrange (RG)
#04 TSPJendrek: WUBG Control (WUBG)
#05 Janh: Temur Control (URG)
#06 _INF_: Gifts Storm (UR)
#07 alemilan19: Bant Control (WUG)
#08 Fabrice_K: Ninja Faeries (UB)
#09 DylanGregory: Humans (WUBRG)
#10 Mcleskey: Burn (WR)
#11 DavidDPanda: E Tron (C)
#12 ZYURYO: WUBG Control (WUBG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_04_postcompanionchange
{
    public class EventTest_modern_preliminary_2020_06_10 : EventTest
    {
        [Test]
        public void Deck01_signblindman_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-10",0),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck02_GedionRavenor_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-10",1),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Shatun_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-10",2),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck04_TSPJendrek_WUBGControl_WUBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-10",3),
                new PostCompanionChange(),
                ArchetypeColor.WUBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Janh_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-10",4),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck06_INF_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-10",5),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck07_alemilan19_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-10",6),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_FabriceK_NinjaFaeries_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-10",7),
                new PostCompanionChange(),
                ArchetypeColor.UB,
                typeof(Ninjas),
                null,
                null
            );
        }

        [Test]
        public void Deck09_DylanGregory_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-10",8),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Mcleskey_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-10",9),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck11_DavidDPanda_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-10",10),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck12_ZYURYO_WUBGControl_WUBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-10",11),
                new PostCompanionChange(),
                ArchetypeColor.WUBG,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}

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
#01 Kofurea: KGC Amulet Titan (WUBRG)
#02 otakkun: KGC Tron (G)
#03 gyyby297: Thopter Urza (UB)
#04 siomomi: KGC Tron (G)
#05 _INF_: Gifts Storm (UR)
#06 Wolfie98: Temur Control (URG)
#07 JV_7777: Humans (WUBRG)
#08 Archgaze: Winota (WRG)
#09 cjucjujp: Bushwhacker Zoo (RG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_25_postm21
{
    public class EventTest_modern_preliminary_2020_06_27 : EventTest
    {
        [Test]
        public void Deck01_Kofurea_KGCAmuletTitan_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-27",0),
                new PostM21(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck02_otakkun_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-27",1),
                new PostM21(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck03_gyyby297_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-27",2),
                new PostM21(),
                ArchetypeColor.UB,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck04_siomomi_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-27",3),
                new PostM21(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck05_INF_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-27",4),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Wolfie98_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-27",5),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_JV7777_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-27",6),
                new PostM21(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Archgaze_Winota_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-27",7),
                new PostM21(),
                ArchetypeColor.WRG,
                typeof(Winota),
                null,
                null
            );
        }

        [Test]
        public void Deck09_cjucjujp_BushwhackerZoo_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-27",8),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(BushwhackerZoo),
                null,
                null
            );
        }


    }
}

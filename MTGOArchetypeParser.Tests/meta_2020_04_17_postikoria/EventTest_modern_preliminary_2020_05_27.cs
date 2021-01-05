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
#01 MissTrigger: Eldrazi Tron (C)
#02 Ennuixd: Ad Nauseam (WUB)
#03 Wolfie98: Niv To Light (WUBRG, Yorion)
#04 Simarisu: Devoted (WBG, Lurrus)
#05 Gigy: Gruul Midrange (RG, Obosh)
#06 Olivetti: Rakdos Prowess (BR, Lurrus)
#07 trunks132: Rakdos Prowess (BR, Lurrus)
#08 alemilan19: Scapeshift (WURG, Yorion)
#09 litianshuo670: Electro Balance (UR)
#10 _INF_: Gifts Storm (UR, Jegantha)
#11 ACG88: Gyruda Reanimator (BRG, Gyruda)
#12 oskiyaa: Devoted (WG, Lurrus)
#13 matyo804: Bogles (WG, Lurrus)
#14 nikumaster: Eldrazi Tron (C)
#15 SlashMash: Humans (WUBRG, Jegantha)
#16 Tiemuuu: Izzet Control (UR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_preliminary_2020_05_27 : EventTest
    {
        [Test]
        public void Deck01_MissTrigger_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-27",0),
                new PostIkoria(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck02_Ennuixd_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-27",1),
                new PostIkoria(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Wolfie98_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-27",2),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck04_Simarisu_Devoted_WBG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-27",3),
                new PostIkoria(),
                ArchetypeColor.WBG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_Gigy_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-27",4),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck06_Olivetti_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-27",5),
                new PostIkoria(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_trunks132_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-27",6),
                new PostIkoria(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_alemilan19_Scapeshift_WURG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-27",7),
                new PostIkoria(),
                ArchetypeColor.WURG,
                typeof(Scapeshift),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck09_litianshuo670_ElectroBalance_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-27",8),
                new PostIkoria(),
                ArchetypeColor.UR,
                typeof(FreeSpells),
                typeof(ElectroBalance),
                null
            );
        }

        [Test]
        public void Deck10_INF_GiftsStorm_UR_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-27",9),
                new PostIkoria(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck11_ACG88_GyrudaReanimator_BRG_Gyruda()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-27",10),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GyrudaReanimator),
                null,
                ArchetypeCompanion.Gyruda
            );
        }

        [Test]
        public void Deck12_oskiyaa_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-27",11),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_matyo804_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-27",12),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_nikumaster_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-27",13),
                new PostIkoria(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck15_SlashMash_Humans_WUBRG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-27",14),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck16_Tiemuuu_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-27",15),
                new PostIkoria(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}

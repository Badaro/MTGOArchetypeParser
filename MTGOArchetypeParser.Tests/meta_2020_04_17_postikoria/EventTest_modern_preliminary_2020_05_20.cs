using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Patxi: Rakdos Prowess (BR, Lurrus)
#02 in5ano: Scapeshift (URG, Yorion)
#03 signblindman: Mardu Prowess (WBR, Lurrus)
#04 selbstdenker: Amulet Titan (UG)
#05 Lavaridge: UBRG Control (UBRG, Lurrus)
#06 meanfannypack: Devoted (WG, Lurrus)
#07 alemilan19: Golgari Midrange (BG, Lurrus)
#08 kanister: Rakdos Prowess (BR, Lurrus)
#09 Chipsoss: UBRG Shadow (UBRG, Lurrus)
#10 Larry11: Gruul Midrange (RG, Obosh)
#11 DDMeelow: Uroza (URG, Yorion)
#12 Fabrice_K: Eldrazi Tron (C)
#13 oskiyaa: Humans (WUBRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_preliminary_2020_05_20 : EventTest
    {
        [Test]
        public void Deck01_Patxi_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-20",0),
                "PostIkoria",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_in5ano_Scapeshift_URG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-20",1),
                "PostIkoria",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck03_signblindman_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-20",2),
                "PostIkoria",
                ArchetypeColor.WBR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_selbstdenker_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-20",3),
                "PostIkoria",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck05_Lavaridge_UBRGControl_UBRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-20",4),
                "PostIkoria",
                ArchetypeColor.UBRG,
                "GenericControl",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_meanfannypack_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-20",5),
                "PostIkoria",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_alemilan19_GolgariMidrange_BG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-20",6),
                "PostIkoria",
                ArchetypeColor.BG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_kanister_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-20",7),
                "PostIkoria",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_Chipsoss_UBRGShadow_UBRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-20",8),
                "PostIkoria",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_Larry11_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-20",9),
                "PostIkoria",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck11_DDMeelow_Uroza_URG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-20",10),
                "PostIkoria",
                ArchetypeColor.URG,
                "Uroza",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck12_FabriceK_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-20",11),
                "PostIkoria",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck13_oskiyaa_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-20",12),
                "PostIkoria",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }


    }
}

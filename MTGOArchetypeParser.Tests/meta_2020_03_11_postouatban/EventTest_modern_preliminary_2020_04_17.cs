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
#01 Kazuga: Bant Control (WUG)
#02 _Batutinha_: Bant Control (WUG)
#03 Violent_Outburst: Reclamation (URG)
#04 felider: Gruul Midrange (RG)
#05 selbstdenker: Amulet Titan (UG)
#06 Fnoop: Neobrand (UG)
#07 Savok: Blue Tron (U)
#08 coert: Burn (WR)
#09 fradev1988: Reclamation (UG)
#10 David1987: Niv To Light (WUBRG)
#11 hwagner43: Ad Nauseam (WUB)
#12 DreamsOfAshiok: Eldrazi Tron (C)
#13 nahuel10: Burn (WR)
#14 gabrialfo: Burn (WR)
#15 Trid0n: Humans (WUBRG)
#16 HannoLee: Uroza (URG)
#17 sydneydude: Naya Midrange (WRG)
#18 signblindman: Naya Midrange (WRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_03_11_postouatban
{
    public class EventTest_modern_preliminary_2020_04_17 : EventTest
    {
        [Test]
        public void Deck01_Kazuga_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17",0),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck02_Batutinha_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17",1),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck03_ViolentOutburst_Reclamation_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17",2),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck04_felider_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17",3),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck05_selbstdenker_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17",4),
                "PostOuatBan",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck06_Fnoop_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17",5),
                "PostOuatBan",
                ArchetypeColor.UG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Savok_BlueTron_U()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17",6),
                "PostOuatBan",
                ArchetypeColor.U,
                "Tron",
                "BlueTron",
                null
            );
        }

        [Test]
        public void Deck08_coert_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17",7),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck09_fradev1988_Reclamation_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17",8),
                "PostOuatBan",
                ArchetypeColor.UG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck10_David1987_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17",9),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                null
            );
        }

        [Test]
        public void Deck11_hwagner43_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17",10),
                "PostOuatBan",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck12_DreamsOfAshiok_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17",11),
                "PostOuatBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck13_nahuel10_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17",12),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck14_gabrialfo_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17",13),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck15_Trid0n_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17",14),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck16_HannoLee_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17",15),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck17_sydneydude_NayaMidrange_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17",16),
                "PostOuatBan",
                ArchetypeColor.WRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck18_signblindman_NayaMidrange_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17",17),
                "PostOuatBan",
                ArchetypeColor.WRG,
                "GenericMidrange",
                null,
                null
            );
        }


    }
}

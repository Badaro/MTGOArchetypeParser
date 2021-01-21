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
#03 Violent_Outburst: Temur Reclamation (URG)
#04 felider: Gruul Midrange (RG)
#05 selbstdenker: Amulet Titan (UG)
#06 Fnoop: Neobrand (UG)
#07 Savok: Blue Tron (U)
#08 coert: Burn (WR)
#09 fradev1988: Simic Reclamation (UG)
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
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Batutinha_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17",1),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_ViolentOutburst_TemurReclamation_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17",2),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(Reclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck04_felider_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17",3),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck05_selbstdenker_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17",4),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck06_Fnoop_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17",5),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Savok_BlueTron_U()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17",6),
                new PostOuatBan(),
                ArchetypeColor.U,
                typeof(Tron),
                typeof(BlueTron),
                null
            );
        }

        [Test]
        public void Deck08_coert_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17",7),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck09_fradev1988_SimicReclamation_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17",8),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Reclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck10_David1987_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17",9),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck11_hwagner43_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17",10),
                new PostOuatBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck12_DreamsOfAshiok_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17",11),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck13_nahuel10_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17",12),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck14_gabrialfo_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17",13),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck15_Trid0n_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17",14),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck16_HannoLee_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17",15),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck17_sydneydude_NayaMidrange_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17",16),
                new PostOuatBan(),
                ArchetypeColor.WRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck18_signblindman_NayaMidrange_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17",17),
                new PostOuatBan(),
                ArchetypeColor.WRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }


    }
}

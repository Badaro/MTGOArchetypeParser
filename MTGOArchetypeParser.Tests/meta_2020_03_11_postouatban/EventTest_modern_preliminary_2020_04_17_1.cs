using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 triosk: Infect (UG)
#02 Dazai: Temur Control (URG)
#03 MlckyB: Bogles (WG)
#04 Violent_Outburst: Reclamation (URG)
#05 Stabilo: Infect (UG)
#06 Gerardo94: Bant Control (WUG)
#07 Toastxp: Uroza (URG)
#08 katoken: Mardu Shadow (WBR)
#09 kasa: Amulet Titan (UG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_03_11_postouatban
{
    public class EventTest_modern_preliminary_2020_04_17_1 : EventTest
    {
        [Test]
        public void Deck01_triosk_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-1",0),
                "PostOuatBan",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck02_Dazai_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-1",1),
                "PostOuatBan",
                ArchetypeColor.URG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck03_MlckyB_Bogles_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-1",2),
                "PostOuatBan",
                ArchetypeColor.WG,
                "Bogles",
                null,
                null
            );
        }

        [Test]
        public void Deck04_ViolentOutburst_Reclamation_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-1",3),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck05_Stabilo_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-1",4),
                "PostOuatBan",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck06_Gerardo94_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-1",5),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Toastxp_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-1",6),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck08_katoken_MarduShadow_WBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-1",7),
                "PostOuatBan",
                ArchetypeColor.WBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck09_kasa_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-1",8),
                "PostOuatBan",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }


    }
}

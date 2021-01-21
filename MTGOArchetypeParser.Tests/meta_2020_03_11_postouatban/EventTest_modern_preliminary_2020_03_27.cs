using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Fluorspar: Humans (WUBRG)
#02 VampireGodric: Gruul Midrange (RG)
#03 straca3: Primeval Titan (WUG)
#04 __matsugan: Neobrand (UG)
#05 turnipturnip: Grixis Shadow (UBR)
#06 Bomboleriot: Dredge (BRG)
#07 Mistakenn: Amulet Titan (UG)
#08 TennTyou: Niv To Light (WUBRG)
#09 ArchaeusDota: Eldrazi Tron (C)
#10 bant_is_love: Niv To Light (WUBRG)
#11 Mordeka1ser: Niv To Light (WUBRG)
#12 _Antoniou_: Bushwhacker Zoo (WRG)
#13 Gerschi: Temur Control (URG)
#14 kthanakit26: Burn (WR)
#15 Ozfan6: Devoted (WBG)
#16 AshawXL: Infect (UG)
#17 Playmobil: Titan Shift (RG)
#18 swff: Bant Control (WUG)
#19 Dafne17: Jund Midrange (BRG)
#20 Sonic_Smasher: Bant Control (WUG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_03_11_postouatban
{
    public class EventTest_modern_preliminary_2020_03_27 : EventTest
    {
        [Test]
        public void Deck01_Fluorspar_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-27",0),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck02_VampireGodric_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-27",1),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck03_straca3_PrimevalTitan_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-27",2),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck04_matsugan_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-27",3),
                "PostOuatBan",
                ArchetypeColor.UG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck05_turnipturnip_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-27",4),
                "PostOuatBan",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck06_Bomboleriot_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-27",5),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Mistakenn_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-27",6),
                "PostOuatBan",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck08_TennTyou_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-27",7),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                null
            );
        }

        [Test]
        public void Deck09_ArchaeusDota_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-27",8),
                "PostOuatBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck10_bantislove_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-27",9),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                null
            );
        }

        [Test]
        public void Deck11_Mordeka1ser_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-27",10),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                null
            );
        }

        [Test]
        public void Deck12_Antoniou_BushwhackerZoo_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-27",11),
                "PostOuatBan",
                ArchetypeColor.WRG,
                "BushwhackerZoo",
                null,
                null
            );
        }

        [Test]
        public void Deck13_Gerschi_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-27",12),
                "PostOuatBan",
                ArchetypeColor.URG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck14_kthanakit26_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-27",13),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck15_Ozfan6_Devoted_WBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-27",14),
                "PostOuatBan",
                ArchetypeColor.WBG,
                "Devoted",
                null,
                null
            );
        }

        [Test]
        public void Deck16_AshawXL_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-27",15),
                "PostOuatBan",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck17_Playmobil_TitanShift_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-27",16),
                "PostOuatBan",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "TitanShift",
                null
            );
        }

        [Test]
        public void Deck18_swff_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-27",17),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck19_Dafne17_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-27",18),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck20_SonicSmasher_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-27",19),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }


    }
}

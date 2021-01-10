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
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck02_VampireGodric_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-27",1),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck03_straca3_PrimevalTitan_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-27",2),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck04_matsugan_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-27",3),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck05_turnipturnip_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-27",4),
                new PostOuatBan(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Bomboleriot_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-27",5),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Mistakenn_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-27",6),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck08_TennTyou_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-27",7),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck09_ArchaeusDota_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-27",8),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck10_bantislove_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-27",9),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Mordeka1ser_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-27",10),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Antoniou_BushwhackerZoo_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-27",11),
                new PostOuatBan(),
                ArchetypeColor.WRG,
                typeof(BushwhackerZoo),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Gerschi_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-27",12),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck14_kthanakit26_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-27",13),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Ozfan6_Devoted_WBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-27",14),
                new PostOuatBan(),
                ArchetypeColor.WBG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck16_AshawXL_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-27",15),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Playmobil_TitanShift_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-27",16),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck18_swff_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-27",17),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck19_Dafne17_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-27",18),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck20_SonicSmasher_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-27",19),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}

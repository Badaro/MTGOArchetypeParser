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
#01 rn17: Thopter Urza (UB)
#02 _Batutinha_: Bant Control (WUG)
#03 GiestOfIWin: Primeval Titan (UG)
#04 HarlanMTG: Azorius Control (WU)
#05 scenekiid: Amulet Titan (G)
#06 BaronOfBacon: Naya Midrange (WRG)
#07 zdb: Mono Red Prowess (R)
#08 quinniac: Burn (WR)
#09 Fluorspar: Humans (WUBRG)
#10 Laurentt: Crabvine (UBG)
#11 hikid: Amulet Titan (G)
#12 _Tim: Grinding Breach (WUBR)
#13 zMunkeyXz: Mill (UBG)
#14 Appoggiatura: Bogles (WG)
#15 el-pollo-lolo: Rakdos Midrange (BR)
#16 MinT_: Inverter Combo (WUB)
#17 LalauWBA: Gruul Midrange (RG)
#18 grahams: Green Tron (G)
#19 Mistakenn: Amulet Titan (RG)
#20 Fixit89: Infect (UG)
#21 SvenSveeterSven: Mardu Midrange (WBR)
#22 Snapcaster-Bolt: Niv To Light (WUBRG)
#23 AvocadoToast: Burn (WR)
#24 603Leb: Green Tron (G)
#25 jvidarte: Mono Red Prowess (R)
#26 wordy333: Boros Taxes (WR)
#27 MTG-Maestro: Naya Midrange (WRG)
#28 signblindman: Gruul Midrange (RG)
#29 negusen: Elves (BG)
#30 Tarmofir3: Jund Midrange (BRG)
#31 StormlightReaper: Gruul Midrange (RG)
#32 l337erhosen: Elementals (WUBRG)
#33 bobjackson: Burn (WR)
#34 Artyom76: Gifts Storm (UR)
#35 Bugsy69: Uroza (UG)
#36 untiltedmtg: Gruul Midrange (RG)
#37 NAP_DARKMAGE_MJM: Humans (WUBRG)
#38 eclipse4343: Azorius Control (WU)
#39 Bullwinkkle6705: Green Tron (G)
#40 GrilledCheese: Smallpox (BRG)
#41 Icteridae: Dice Factory Tron (C)
#42 nahuel10: Burn (WR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_03_11_postouatban
{
    public class EventTest_modern_preliminary_2020_04_04 : EventTest
    {
        [Test]
        public void Deck01_rn17_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-04",0),
                new PostOuatBan(),
                ArchetypeColor.UB,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck02_Batutinha_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-04",1),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_GiestOfIWin_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-04",2),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck04_HarlanMTG_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-04",3),
                new PostOuatBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_scenekiid_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-04",4),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck06_BaronOfBacon_NayaMidrange_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-04",5),
                new PostOuatBan(),
                ArchetypeColor.WRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck07_zdb_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-04",6),
                new PostOuatBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck08_quinniac_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-04",7),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Fluorspar_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-04",8),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Laurentt_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-04",9),
                new PostOuatBan(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck11_hikid_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-04",10),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck12_Tim_GrindingBreach_WUBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-04",11),
                new PostOuatBan(),
                ArchetypeColor.WUBR,
                typeof(GrindingBreach),
                null,
                null
            );
        }

        [Test]
        public void Deck13_zMunkeyXz_Mill_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-04",12),
                new PostOuatBan(),
                ArchetypeColor.UBG,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Appoggiatura_Bogles_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-04",13),
                new PostOuatBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck15_elpollololo_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-04",14),
                new PostOuatBan(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck16_MinT_InverterCombo_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-04",15),
                new PostOuatBan(),
                ArchetypeColor.WUB,
                typeof(InverterCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck17_LalauWBA_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-04",16),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck18_grahams_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-04",17),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck19_Mistakenn_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-04",18),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck20_Fixit89_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-04",19),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck21_SvenSveeterSven_MarduMidrange_WBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-04",20),
                new PostOuatBan(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck22_SnapcasterBolt_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-04",21),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck23_AvocadoToast_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-04",22),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck24_603Leb_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-04",23),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck25_jvidarte_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-04",24),
                new PostOuatBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck26_wordy333_BorosTaxes_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-04",25),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck27_MTGMaestro_NayaMidrange_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-04",26),
                new PostOuatBan(),
                ArchetypeColor.WRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck28_signblindman_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-04",27),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck29_negusen_Elves_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-04",28),
                new PostOuatBan(),
                ArchetypeColor.BG,
                typeof(Elves),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Tarmofir3_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-04",29),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck31_StormlightReaper_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-04",30),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck32_l337erhosen_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-04",31),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck33_bobjackson_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-04",32),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck34_Artyom76_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-04",33),
                new PostOuatBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck35_Bugsy69_Uroza_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-04",34),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck36_untiltedmtg_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-04",35),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck37_NAPDARKMAGEMJM_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-04",36),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck38_eclipse4343_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-04",37),
                new PostOuatBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck39_Bullwinkkle6705_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-04",38),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck40_GrilledCheese_Smallpox_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-04",39),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Smallpox),
                null,
                null
            );
        }

        [Test]
        public void Deck41_Icteridae_DiceFactoryTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-04",40),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(DiceFactoryTron),
                null
            );
        }

        [Test]
        public void Deck42_nahuel10_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-04",41),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }


    }
}

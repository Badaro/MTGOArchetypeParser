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
#01 J000111: Dredge (BRG)
#02 matyo804: Titan Shift (RG)
#03 mikeleee: Humans (WUBRG)
#04 Darkiundsa: Bant Control (WUG)
#05 Bomboleriot: Dredge (BRG)
#06 ecobaronen: Bant Control (WUG)
#07 Misterkle: Ad Nauseam (WUB)
#08 joker10289: Gruul Midrange (RG)
#09 Erik157751: Dredge (UBRG)
#10 manoah: Jund Midrange (BRG)
#11 Darthkid: Gruul Midrange (RG)
#12 Heibing: Green Eldrazi (WUG)
#13 Laplasjan: Eldrazi Tron (C)
#14 Albimtg: Jund Shadow (BRG)
#15 ArchaeusDota: Eldrazi Tron (C)
#16 Sonic_Smasher: Bant Control (WUG)
#17 TaviGhindea: Burn (WBR)
#18 PRGJJAR: Dredge (BRG)
#19 lukystrike: Burn (WR)
#20 toondoslav: Mono Red Prowess (R)
#21 gyyby297: Thopter Urza (UB)
#22 bomberboss: Humans (WUBRG)
#23 Braiden: Eldrazi Tron (C)
#24 envizz: Mono Red Prowess (R)
#25 Bayesta_93: Green Tron (G)
#26 alemilan19: Dredge (UBRG)
#27 AlerionONE: Humans (WUBRG)
#28 ACG88: Green Tron (G)
#29 lighdar: Humans (WUBRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_03_11_postouatban
{
    public class EventTest_modern_preliminary_2020_03_25 : EventTest
    {
        [Test]
        public void Deck01_J000111_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",0),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck02_matyo804_TitanShift_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",1),
                "PostOuatBan",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "TitanShift",
                null
            );
        }

        [Test]
        public void Deck03_mikeleee_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",2),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck04_Darkiundsa_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",3),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck05_Bomboleriot_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",4),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck06_ecobaronen_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",5),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Misterkle_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",6),
                "PostOuatBan",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck08_joker10289_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",7),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck09_Erik157751_Dredge_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",8),
                "PostOuatBan",
                ArchetypeColor.UBRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck10_manoah_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",9),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck11_Darthkid_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",10),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck12_Heibing_GreenEldrazi_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",11),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GreenEldrazi",
                null,
                null
            );
        }

        [Test]
        public void Deck13_Laplasjan_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",12),
                "PostOuatBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck14_Albimtg_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",13),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck15_ArchaeusDota_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",14),
                "PostOuatBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck16_SonicSmasher_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",15),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck17_TaviGhindea_Burn_WBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",16),
                "PostOuatBan",
                ArchetypeColor.WBR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck18_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",17),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck19_lukystrike_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",18),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck20_toondoslav_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",19),
                "PostOuatBan",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck21_gyyby297_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",20),
                "PostOuatBan",
                ArchetypeColor.UB,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck22_bomberboss_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",21),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck23_Braiden_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",22),
                "PostOuatBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck24_envizz_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",23),
                "PostOuatBan",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck25_Bayesta93_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",24),
                "PostOuatBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck26_alemilan19_Dredge_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",25),
                "PostOuatBan",
                ArchetypeColor.UBRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck27_AlerionONE_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",26),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck28_ACG88_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",27),
                "PostOuatBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck29_lighdar_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",28),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }


    }
}

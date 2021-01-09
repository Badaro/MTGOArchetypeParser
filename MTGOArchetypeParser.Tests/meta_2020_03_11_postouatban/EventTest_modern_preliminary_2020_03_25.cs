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
#09 Erik157751: Dredge (BRG)
#10 manoah: Jund Midrange (BRG)
#11 Darthkid: Gruul Midrange (RG)
#12 Heibing: Green Eldrazi (WUG)
#13 Laplasjan: Eldrazi Tron (C)
#14 Albimtg: Jund Shadow (BRG)
#15 ArchaeusDota: Eldrazi Tron (C)
#16 Sonic_Smasher: Bant Control (WUG)
#17 TaviGhindea: Burn (WR)
#18 PRGJJAR: Dredge (BRG)
#19 lukystrike: Burn (WR)
#20 toondoslav: Mono Red Prowess (R)
#21 gyyby297: Thopter Urza (UB)
#22 bomberboss: Humans (WUBRG)
#23 Braiden: Eldrazi Tron (C)
#24 envizz: Mono Red Prowess (R)
#25 Bayesta_93: Green Tron (G)
#26 alemilan19: Dredge (BRG)
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
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck02_matyo804_TitanShift_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",1),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck03_mikeleee_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",2),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Darkiundsa_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",3),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Bomboleriot_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",4),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck06_ecobaronen_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",5),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Misterkle_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",6),
                new PostOuatBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck08_joker10289_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",7),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Erik157751_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",8),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck10_manoah_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",9),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Darthkid_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",10),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Heibing_GreenEldrazi_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",11),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GreenEldrazi),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Laplasjan_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",12),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck14_Albimtg_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",13),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck15_ArchaeusDota_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",14),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck16_SonicSmasher_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",15),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck17_TaviGhindea_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",16),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck18_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",17),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck19_lukystrike_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",18),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck20_toondoslav_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",19),
                new PostOuatBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck21_gyyby297_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",20),
                new PostOuatBan(),
                ArchetypeColor.UB,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck22_bomberboss_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",21),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Braiden_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",22),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck24_envizz_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",23),
                new PostOuatBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Bayesta93_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",24),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck26_alemilan19_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",25),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck27_AlerionONE_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",26),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck28_ACG88_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",27),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck29_lighdar_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-25",28),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }


    }
}

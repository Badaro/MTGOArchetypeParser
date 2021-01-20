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
#01 Gigy: Gruul Midrange (RG)
#02 maximusdee: Gifts Storm (UR)
#03 leclairandy: Bant Control (WUG)
#04 SunofNothing: Uroza (URG)
#05 Toastxp: Uroza (URG, Yorion)
#06 jessy_samek: Infect (UG)
#07 hugo87: Gifts Storm (UR)
#08 qbturtle15: Gruul Midrange (RG, Obosh)
#09 fried-liver-attack: Eldrazi Tron (C)
#10 D00mwake: Humans (WUBRG)
#11 alemilan19: Humans (WUBRG)
#12 ContraEgo: Thopter Urza (UBR)
#13 Icteridae: Devoted (WUG)
#14 PRGJJAR: Dredge (BRG)
#15 Lord_Beerus: Burn (WR, Lurrus)
#16 retiredcapivara: Dredge (BRG)
#17 Laplasjan: Devoted (WG, Lurrus)
#18 Add1ct3d: Bant Control (WUG)
#19 joetru: Niv To Light (WUBRG)
#20 ilsecco14: Golgari Midrange (BG)
#21 _goblinlackey: Green Tron (G, Jegantha)
#22 Ryan100495: Dredge (BRG)
#23 KeeperX: Naya Midrange (WRG)
#24 PietroSas: Devoted (WG, Lurrus)
#25 Lord_of_Puntlantis: Inverter Combo (UB)
#26 cftsoc3: Bant Blink (WUG, Yorion)
#27 _LSN_: Burn (WR)
#28 nathansteuer: Uroza (URG)
#29 pokerswizard: Eldrazi Tron (C)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_preliminary_2020_06_04 : EventTest
    {
        [Test]
        public void Deck01_Gigy_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",0),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck02_maximusdee_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",1),
                new PostIkoria(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck03_leclairandy_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",2),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_SunofNothing_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",3),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Toastxp_Uroza_URG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",4),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck06_jessysamek_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",5),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck07_hugo87_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",6),
                new PostIkoria(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck08_qbturtle15_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",7),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck09_friedliverattack_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",8),
                new PostIkoria(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck10_D00mwake_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",9),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck11_alemilan19_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",10),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck12_ContraEgo_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",11),
                new PostIkoria(),
                ArchetypeColor.UBR,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck13_Icteridae_Devoted_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",12),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck14_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",13),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck15_LordBeerus_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",14),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_retiredcapivara_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",15),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Laplasjan_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",16),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_Add1ct3d_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",17),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck19_joetru_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",18),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck20_ilsecco14_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",19),
                new PostIkoria(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck21_goblinlackey_GreenTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",20),
                new PostIkoria(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck22_Ryan100495_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",21),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck23_KeeperX_NayaMidrange_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",22),
                new PostIkoria(),
                ArchetypeColor.WRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck24_PietroSas_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",23),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_LordofPuntlantis_InverterCombo_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",24),
                new PostIkoria(),
                ArchetypeColor.UB,
                typeof(InverterCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck26_cftsoc3_BantBlink_WUG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",25),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck27_LSN_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",26),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck28_nathansteuer_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",27),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck29_pokerswizard_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",28),
                new PostIkoria(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }


    }
}

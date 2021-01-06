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
#01 ZYURYO: Bant Control (WUG)
#02 _Batutinha_: Bant Control (WUG)
#03 Tiemuuu: Izzet Control (UR)
#04 SakeIzumo: Mono Red Prowess (R)
#05 h8cUn: Bant Control (WUG)
#06 jled: UBRG Shadow (UBRG)
#07 Theflotist: Bant Control (WUG)
#08 Cherryxman: Eldrazi Tron (C)
#09 Veronkierto: Dredge (BRG)
#10 TBagTom: Sultai Control (UBG)
#11 D00mwake: Green Tron (G)
#12 uaedoliB: Humans (WUBRG)
#13 negusen: Elves (BG)
#14 bolov0: Humans (WUBRG)
#15 Danny_Bambino: Grinding Breach (WUBR)
#16 BReal2: Rakdos Midrange (BR)
#17 McWinSauce: WURG Control (WURG)
#18 BlueLips: Dredge (BRG)
#19 joker10289: Bant Control (WUG)
#20 NorrathDecay: Green Tron (G)
#21 Lucabireskusku: Uroza (UG)
#22 Graciasportanto: Bant Control (WUG)
#23 Do0mSwitch: Bant Control (WUG)
#24 Riickitun: Mono Red Prowess (R)
#25 jessy_samek: Uroza (UG)
#26 Edel: Jund Midrange (BRG)
#27 J000111: Dredge (BRG)
#28 Dawnelemental: Mono Red Prowess (R)
#29 Folero: Jund Midrange (BRG)
#30 exoticherman: Gruul Midrange (RG)
#31 im2g00t4ubarn: Bant Control (WUG)
#32 Antillectual: Azorius Control (WU)
#33 _Carter_: Grixis Shadow (UBR)
#34 pepeisra: Uroza (UG)
#35 Mou: Bant Control (WUG)
#36 kiethverin: Mono Red Prowess (R)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_03_11_postouatban
{
    public class EventTest_modern_preliminary_2020_03_12 : EventTest
    {
        [Test]
        public void Deck01_ZYURYO_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-12",0),
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
                GetDeck("modern-preliminary-2020-03-12",1),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Tiemuuu_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-12",2),
                new PostOuatBan(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_SakeIzumo_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-12",3),
                new PostOuatBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck05_h8cUn_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-12",4),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck06_jled_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-12",5),
                new PostOuatBan(),
                ArchetypeColor.UBRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Theflotist_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-12",6),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Cherryxman_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-12",7),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck09_Veronkierto_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-12",8),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck10_TBagTom_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-12",9),
                new PostOuatBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck11_D00mwake_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-12",10),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck12_uaedoliB_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-12",11),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck13_negusen_Elves_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-12",12),
                new PostOuatBan(),
                ArchetypeColor.BG,
                typeof(Elves),
                null,
                null
            );
        }

        [Test]
        public void Deck14_bolov0_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-12",13),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck15_DannyBambino_GrindingBreach_WUBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-12",14),
                new PostOuatBan(),
                ArchetypeColor.WUBR,
                typeof(GrindingBreach),
                null,
                null
            );
        }

        [Test]
        public void Deck16_BReal2_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-12",15),
                new PostOuatBan(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck17_McWinSauce_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-12",16),
                new PostOuatBan(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck18_BlueLips_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-12",17),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck19_joker10289_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-12",18),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck20_NorrathDecay_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-12",19),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck21_Lucabireskusku_Uroza_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-12",20),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Graciasportanto_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-12",21),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Do0mSwitch_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-12",22),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Riickitun_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-12",23),
                new PostOuatBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck25_jessysamek_Uroza_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-12",24),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck26_Edel_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-12",25),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck27_J000111_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-12",26),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Dawnelemental_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-12",27),
                new PostOuatBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Folero_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-12",28),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck30_exoticherman_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-12",29),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck31_im2g00t4ubarn_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-12",30),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck32_Antillectual_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-12",31),
                new PostOuatBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck33_Carter_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-12",32),
                new PostOuatBan(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck34_pepeisra_Uroza_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-12",33),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck35_Mou_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-12",34),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck36_kiethverin_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-12",35),
                new PostOuatBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }


    }
}

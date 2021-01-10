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
#01 azureu09: Ad Nauseam (WUB)
#02 jhk_: Jund Midrange (BRG)
#03 Freyja: Living End (URG)
#04 johnyvolta: Kiki Chord (WURG)
#05 SourceOdin: Thopter Urza (WU)
#06 coert: Green Tron (G)
#07 Granham: Green Tron (G)
#08 Heibing: Eldrazi Tron (C)
#09 im2g00t4ubarn: Uroza (URG)
#10 Jenara19: Uroza (URG)
#11 MATTOMARINAIO: Uroza (URG)
#12 MATTHEWFOULKES: Grinding Breach (WUBR)
#13 Predicted: Yawgmoth (BG)
#14 Mou: Jund Midrange (BRG)
#15 RNGspecialist: Saheeli Combo (WUR)
#16 UmekawaneikU: Jund Midrange (BRG)
#17 kefka27: Dredge (UBRG)
#18 Drakanar: Merfolk (UG)
#19 _Antoniou_: Green Eldrazi (RG)
#20 ACG88: Green Tron (G)
#21 Playmobil: Bant Control (WUG)
#22 NosonosaN: Bant Control (WUG)
#23 fradev1988: Electro Balance (UR)
#24 Treno: Green Tron (G)
#25 Olivetti: Mono White Taxes (W)
#26 Genxim: Green Tron (G)
#27 medvedev: Mono White Taxes (W)
#28 instantQ: Burn (WR)
#29 Dazai: Bant Control (WUG)
#30 Rooney56: Jund Midrange (BRG)
#31 Phill_Hellmuth: Humans (WUBRG)
#32 G0NZO: Eldrazi Tron (C)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_03_11_postouatban
{
    public class EventTest_modern_preliminary_2020_03_18 : EventTest
    {
        [Test]
        public void Deck01_azureu09_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",0),
                new PostOuatBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck02_jhk_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",1),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Freyja_LivingEnd_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",2),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(LivingEnd),
                null,
                null
            );
        }

        [Test]
        public void Deck04_johnyvolta_KikiChord_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",3),
                new PostOuatBan(),
                ArchetypeColor.WURG,
                typeof(KikiChord),
                null,
                null
            );
        }

        [Test]
        public void Deck05_SourceOdin_ThopterUrza_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",4),
                new PostOuatBan(),
                ArchetypeColor.WU,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck06_coert_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",5),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck07_Granham_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",6),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck08_Heibing_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",7),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck09_im2g00t4ubarn_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",8),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Jenara19_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",9),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck11_MATTOMARINAIO_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",10),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck12_MATTHEWFOULKES_GrindingBreach_WUBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",11),
                new PostOuatBan(),
                ArchetypeColor.WUBR,
                typeof(GrindingBreach),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Predicted_Yawgmoth_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",12),
                new PostOuatBan(),
                ArchetypeColor.BG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Mou_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",13),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck15_RNGspecialist_SaheeliCombo_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",14),
                new PostOuatBan(),
                ArchetypeColor.WUR,
                typeof(SaheeliCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck16_UmekawaneikU_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",15),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck17_kefka27_Dredge_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",16),
                new PostOuatBan(),
                ArchetypeColor.UBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Drakanar_Merfolk_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",17),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck19_Antoniou_GreenEldrazi_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",18),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GreenEldrazi),
                null,
                null
            );
        }

        [Test]
        public void Deck20_ACG88_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",19),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck21_Playmobil_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",20),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck22_NosonosaN_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",21),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck23_fradev1988_ElectroBalance_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",22),
                new PostOuatBan(),
                ArchetypeColor.UR,
                typeof(FreeSpells),
                typeof(ElectroBalance),
                null
            );
        }

        [Test]
        public void Deck24_Treno_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",23),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck25_Olivetti_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",24),
                new PostOuatBan(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck26_Genxim_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",25),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck27_medvedev_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",26),
                new PostOuatBan(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck28_instantQ_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",27),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Dazai_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",28),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Rooney56_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",29),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck31_PhillHellmuth_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",30),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck32_G0NZO_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",31),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }


    }
}

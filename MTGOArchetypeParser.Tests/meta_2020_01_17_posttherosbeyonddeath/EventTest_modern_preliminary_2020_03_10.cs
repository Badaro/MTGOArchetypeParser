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
#01 in5ano: Thopter Urza (WUR)
#02 qbturtle15: Gruul Midrange (RG)
#03 FunkiMunki: Temur Control (URG)
#04 Lord_Beerus: Burn (WR)
#05 pootisgodsamongus: Crabvine (UBG)
#06 lwdgg: Thopter Urza (UB)
#07 Theo_Jung: Bant Control (WUG)
#08 PRGJJAR: Dredge (BRG)
#09 Gitaxian11: Thopter Urza (UBG)
#10 bobthedog: Uroza (UG)
#11 romanmy: Thopter Urza (UBR)
#12 drew3141: Amulet Titan (UG)
#13 A22en: Sultai Midrange (UBG)
#14 SoulStrong: Thopter Urza (UB)
#15 sandydogmtg: Burn (R)
#16 Giaws: Grixis Shadow (UBR)
#17 asnook: Jund Midrange (BRG)
#18 MentalMisstep: Bant Control (WUG)
#19 WingedHussar: Neobrand (UG)
#20 SrTortinha: Bant Control (WUG)
#21 Toastxp: Uroza (URG)
#22 xfile: Sultai Midrange (UBG)
#23 rileydk: Amulet Titan (UG)
#24 t1griselbrand: Neobrand (WUG)
#25 TheTunnelingCat: Eldrazi Tron (C)
#26 D00mwake: Humans (WUBRG)
#27 AbelMolto: Burn (WRG)
#28 Graciasportanto: Jund Midrange (BRG)
#29 coert: Devoted (WBG)
#30 MikeEgan: Grinding Breach (WUBR)
#31 starfall: Humans (WUBRG)
#32 VampireGodric: Eldrazi Tron (C)
#33 Aardos: Neobrand (UG)
#34 Mistakenn: Amulet Titan (UG)
#35 im2g00t4ubarn: Grinding Breach (WUBR)
#36 Dia83: Amulet Titan (UG)
#37 tanisong1221: Rakdos Midrange (BR)
#38 yamakiller: Eldrazi Tron (C)
#39 Airvent: Eldrazi Tron (C)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_preliminary_2020_03_10 : EventTest
    {
        [Test]
        public void Deck01_in5ano_ThopterUrza_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-10",0),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUR,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck02_qbturtle15_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-10",1),
                new PostTherosBeyondDeath(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck03_FunkiMunki_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-10",2),
                new PostTherosBeyondDeath(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_LordBeerus_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-10",3),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck05_pootisgodsamongus_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-10",4),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck06_lwdgg_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-10",5),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UB,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck07_TheoJung_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-10",6),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-10",7),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Gitaxian11_ThopterUrza_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-10",8),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UBG,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck10_bobthedog_Uroza_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-10",9),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck11_romanmy_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-10",10),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UBR,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck12_drew3141_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-10",11),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck13_A22en_SultaiMidrange_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-10",12),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UBG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck14_SoulStrong_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-10",13),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UB,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck15_sandydogmtg_Burn_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-10",14),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck16_Giaws_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-10",15),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UBR,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck17_asnook_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-10",16),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck18_MentalMisstep_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-10",17),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck19_WingedHussar_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-10",18),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck20_SrTortinha_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-10",19),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck21_Toastxp_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-10",20),
                new PostTherosBeyondDeath(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck22_xfile_SultaiMidrange_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-10",21),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UBG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck23_rileydk_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-10",22),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck24_t1griselbrand_Neobrand_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-10",23),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck25_TheTunnelingCat_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-10",24),
                new PostTherosBeyondDeath(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck26_D00mwake_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-10",25),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck27_AbelMolto_Burn_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-10",26),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WRG,
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck28_Graciasportanto_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-10",27),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck29_coert_Devoted_WBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-10",28),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WBG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck30_MikeEgan_GrindingBreach_WUBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-10",29),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUBR,
                typeof(GrindingBreach),
                null,
                null
            );
        }

        [Test]
        public void Deck31_starfall_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-10",30),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck32_VampireGodric_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-10",31),
                new PostTherosBeyondDeath(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck33_Aardos_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-10",32),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck34_Mistakenn_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-10",33),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck35_im2g00t4ubarn_GrindingBreach_WUBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-10",34),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUBR,
                typeof(GrindingBreach),
                null,
                null
            );
        }

        [Test]
        public void Deck36_Dia83_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-10",35),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck37_tanisong1221_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-10",36),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck38_yamakiller_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-10",37),
                new PostTherosBeyondDeath(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck39_Airvent_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-10",38),
                new PostTherosBeyondDeath(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }


    }
}

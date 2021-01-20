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
#01 hodortimebaby: Gruul Midrange (RG)
#02 Berserker_BOB: Primeval Titan (BG)
#03 jmd037: Amulet Titan (UG)
#04 Dia83: Amulet Titan (UG)
#05 1yo2yo: Thopter Urza (WU)
#06 jled: Amulet Titan (G)
#07 2radMTG: Infect (UG)
#08 GedionRavenor: Azorius Control (WU)
#09 Pollu: Bant Control (WUG)
#10 sheastrausman: Eldrazi Tron (G)
#11 Sideshowsc: Scapeshift (WURG)
#12 Parrotlet: Grinding Breach (WUBR)
#13 BladeofIce: Grinding Breach (WUR)
#14 Jazza: Eldrazi Tron (G)
#15 Toastxp: Uroza (URG)
#16 _LSN_: Burn (WR)
#17 sickospence: Thopter Urza (UB)
#18 SrTortinha: Domain Zoo (WURG)
#19 PTarts2win: Eldrazi Tron (G)
#20 __matsugan: Neobrand (UG)
#21 t_k_h_r: Thopter Urza (UB)
#22 TheTunnelingCat: Eldrazi Tron (C)
#23 xfile: Gruul Prowess (RG)
#24 .//Automaton: Green Tron (G)
#25 AndyGrey: Green Devotion (RG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_preliminary_2020_03_07 : EventTest
    {
        [Test]
        public void Deck01_hodortimebaby_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-07",0),
                new PostTherosBeyondDeath(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck02_BerserkerBOB_PrimevalTitan_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-07",1),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck03_jmd037_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-07",2),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck04_Dia83_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-07",3),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck05_1yo2yo_ThopterUrza_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-07",4),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WU,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck06_jled_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-07",5),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck07_2radMTG_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-07",6),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck08_GedionRavenor_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-07",7),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Pollu_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-07",8),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck10_sheastrausman_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-07",9),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck11_Sideshowsc_Scapeshift_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-07",10),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WURG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Parrotlet_GrindingBreach_WUBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-07",11),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUBR,
                typeof(GrindingBreach),
                null,
                null
            );
        }

        [Test]
        public void Deck13_BladeofIce_GrindingBreach_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-07",12),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUR,
                typeof(GrindingBreach),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Jazza_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-07",13),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck15_Toastxp_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-07",14),
                new PostTherosBeyondDeath(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck16_LSN_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-07",15),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck17_sickospence_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-07",16),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UB,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck18_SrTortinha_DomainZoo_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-07",17),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WURG,
                typeof(DomainZoo),
                null,
                null
            );
        }

        [Test]
        public void Deck19_PTarts2win_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-07",18),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck20_matsugan_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-07",19),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck21_tkhr_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-07",20),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UB,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck22_TheTunnelingCat_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-07",21),
                new PostTherosBeyondDeath(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck23_xfile_GruulProwess_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-07",22),
                new PostTherosBeyondDeath(),
                ArchetypeColor.RG,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck24_Automaton_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-07",23),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck25_AndyGrey_GreenDevotion_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-07",24),
                new PostTherosBeyondDeath(),
                ArchetypeColor.RG,
                typeof(GreenDevotion),
                null,
                null
            );
        }


    }
}

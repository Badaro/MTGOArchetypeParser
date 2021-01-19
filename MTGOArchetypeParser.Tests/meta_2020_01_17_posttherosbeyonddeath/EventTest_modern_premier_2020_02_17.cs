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
#01 Violent_Outburst: Amulet Titan (UG)
#02 Lord_Beerus: Burn (WR)
#03 EduFonseca: Eldrazi Tron (C)
#04 in5ano: Thopter Urza (UB)
#05 angelsjeffrey: Mono Red Prowess (R)
#06 al8ert.dk: Eldrazi Tron (G)
#07 ivanguille: Azorius Control (WU)
#08 medvedev: Mono Red Prowess (R)
#09 CharLy: Azorius Control (WU)
#10 albert62: Jund Midrange (BRG)
#11 LordEgg: Eldrazi Tron (G)
#12 SoulStrong: Bant Control (WUG)
#13 cha21: Azorius Control (WU)
#14 didoguidotti1: UBRG Shadow (UBRG)
#15 jessy_samek: Jund Midrange (BRG)
#16 qbturtle15: Azorius Control (WU)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_premier_2020_02_17 : EventTest
    {
        [Test]
        public void Deck01_ViolentOutburst_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-premier-2020-02-17",0),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck02_LordBeerus_Burn_WR()
        {
            Test(
                GetDeck("modern-premier-2020-02-17",1),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck03_EduFonseca_EldraziTron_C()
        {
            Test(
                GetDeck("modern-premier-2020-02-17",2),
                new PostTherosBeyondDeath(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck04_in5ano_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-premier-2020-02-17",3),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UB,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck05_angelsjeffrey_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-premier-2020-02-17",4),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck06_al8ertdk_EldraziTron_G()
        {
            Test(
                GetDeck("modern-premier-2020-02-17",5),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck07_ivanguille_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-premier-2020-02-17",6),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_medvedev_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-premier-2020-02-17",7),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck09_CharLy_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-premier-2020-02-17",8),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck10_albert62_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-premier-2020-02-17",9),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck11_LordEgg_EldraziTron_G()
        {
            Test(
                GetDeck("modern-premier-2020-02-17",10),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck12_SoulStrong_BantControl_WUG()
        {
            Test(
                GetDeck("modern-premier-2020-02-17",11),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck13_cha21_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-premier-2020-02-17",12),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck14_didoguidotti1_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-premier-2020-02-17",13),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UBRG,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck15_jessysamek_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-premier-2020-02-17",14),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck16_qbturtle15_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-premier-2020-02-17",15),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}

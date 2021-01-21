using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Nammersquats: Devoted (WG, Lurrus)
#02 wambocombo2020: Humans (WUBRG)
#03 Bullwinkkle6705: Temur Control (URG)
#04 SCJ: WURG Control (WURG)
#05 SKK: Belcher (RG)
#06 Bedell: Shadow Prowess (BR, Lurrus)
#07 pokerswizard: Gruul Midrange (RG)
#08 SpikeYou: Reclamation (UBG)
#09 swana422: Spirits (WUG)
#10 Fatcaster_Mage: Temur Control (URG)
#11 MZBlazer: Shadow Prowess (BR, Lurrus)
#12 qbturtle15: Mono White Taxes (W)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_09_24 : EventTest
    {
        [Test]
        public void Deck01_Nammersquats_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-24",0),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_wambocombo2020_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-24",1),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck03_Bullwinkkle6705_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-24",2),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck04_SCJ_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-24",3),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck05_SKK_Belcher_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-24",4),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "Belcher",
                null,
                null
            );
        }

        [Test]
        public void Deck06_Bedell_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-24",5),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_pokerswizard_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-24",6),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck08_SpikeYou_Reclamation_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-24",7),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck09_swana422_Spirits_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-24",8),
                "PostZendikarRising",
                ArchetypeColor.WUG,
                "Spirits",
                null,
                null
            );
        }

        [Test]
        public void Deck10_FatcasterMage_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-24",9),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck11_MZBlazer_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-24",10),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_qbturtle15_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-24",11),
                "PostZendikarRising",
                ArchetypeColor.W,
                "GenericTaxes",
                null,
                null
            );
        }


    }
}

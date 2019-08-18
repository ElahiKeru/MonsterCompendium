using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MonsterLibrary;

namespace MonsterCompendium
{
    public partial class DetailView : Form
    {
        Monster target;

        public DetailView()
        {
            InitializeComponent();
        }

        public DetailView(Monster input)
        {
            target = input;
            InitializeComponent();
        }

        private void DetailView_Load(object sender, EventArgs e)
        {
            //populate data from the monster object into controls here
            TXTName.Text = target.Name;
            ResizeText(TXTName);

            TXTSTST.Text = $"{target.Size} {target.Type} ({target.SubType})";
            ResizeText(TXTSTST);

            TXTAlignment.Text = target.Alignment;
            ResizeText(TXTAlignment);

            TXTAcHpHd.Text = $"AC: {target.ArmorClass} HP: {target.HitPoints} ({target.HitDice}d{target.DiceType}+{target.ConstitutionMod * target.HitDice})";
            ResizeText(TXTAcHpHd);

            TXTSpeed.Text = target.Speed;
            ResizeText(TXTSpeed);

            TXTStrScr.Text = target.Strength.ToString();
            TXTStrMod.Text = target.StrengthMod.ToString();
            TXTDexScr.Text = target.Dexterity.ToString();
            TXTDexMod.Text = target.DexterityMod.ToString();
            TXTConScr.Text = target.Constitution.ToString();
            TXTConMod.Text = target.ConstitutionMod.ToString();
            TXTIntScr.Text = target.Intelligence.ToString();
            TXTIntMod.Text = target.IntelligenceMod.ToString();
            TXTWisScr.Text = target.Wisdom.ToString();
            TXTWisMod.Text = target.WisdomMod.ToString();
            TXTChaScr.Text = target.Charisma.ToString();
            TXTChaMod.Text = target.CharismaMod.ToString();

            TXTSave.Text = target.Saves;
            ResizeText(TXTSave);

            TXTSkill.Text = target.Skills;
            ResizeText(TXTSkill);

            TXTDamVuln.Text = target.DamageVuln;
            ResizeText(TXTDamVuln);

            TXTDamRes.Text = target.DamageRes;
            ResizeText(TXTDamRes);

            TXTDamImn.Text = target.DamageImmune;
            ResizeText(TXTDamImn);

            TXTCondImn.Text = target.ConditionImmune;
            ResizeText(TXTCondImn);

            TXTSenses.Text = target.Senses;
            ResizeText(TXTSenses);

            TXTLanguages.Text = target.Languages;
            ResizeText(TXTLanguages);

            TXTChallenge.Text = target.Challenge;
            ResizeText(TXTChallenge);

            TXTXP.Text = target.XP;
            ResizeText(TXTXP);

            TXTFeatures.Text = target.Features;
            TXTActions.Text = target.Actions;
            TXTNotes.Text = target.Notes;

            this.Text = $"Monster Details: {target.Name}";
        }

        private void ResizeText(TextBox target)
        {
            Size targetSize = TextRenderer.MeasureText(target.Text, target.Font);
            target.ClientSize = new Size(targetSize.Width, targetSize.Height + 2);
        }
    }
}

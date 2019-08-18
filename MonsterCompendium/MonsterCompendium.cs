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
    public partial class MonsterCompendium : Form
    {
        //properties and links to external library
        private MonsterContainer fullMonsterContainer;
        private List<string> sizeFilter;
        private List<string> typeFilter;
        private List<string> alignmentFilter;
        private List<string> challengeFilter;
        private MonsterContainer filteredMonsters;

        public MonsterCompendium()
        {
            //initialize filters here
            sizeFilter = new List<string>();
            typeFilter = new List<string>();
            alignmentFilter = new List<string>();
            challengeFilter = new List<string>();
            InitializeComponent();
        }

        private void DGVMonsterList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            DetailView dv = new DetailView((Monster)dgv.CurrentCell.OwningRow.DataBoundItem);
            dv.Show();
        }

        private void MonsterCompendium_Load(object sender, EventArgs e)
        {
            //fill the monster list
            fullMonsterContainer = new MonsterContainer(@"MonsterList.xml");

            //populate the controls
            DGVMonsterList.DataSource = fullMonsterContainer.Monsters;
            DGVMonsterList.Columns.OfType<DataGridViewColumn>().ToList().ForEach(col => col.Visible = false);
            DGVMonsterList.Columns["Name"].Visible = true;
            DGVMonsterList.Columns["Size"].Visible = true;
            DGVMonsterList.Columns["Type"].Visible = true;
            DGVMonsterList.Columns["Alignment"].Visible = true;
            DGVMonsterList.Columns["Challenge"].Visible = true;
            DGVMonsterList.Columns["XP"].Visible = true;
            //size type tags alignment challenge environment source
            //name size type alignment challenge xp
        }

        private void ApplyFilters()
        {
            filteredMonsters = new MonsterContainer();
            var filtered = fullMonsterContainer.Monsters.Where(p => !string.IsNullOrEmpty(p.Name));

            //apply size filter if applicable
            if (sizeFilter.Count > 0)
            {
                filtered = filtered.Where(p => sizeFilter.Contains(p.Size));
            }

            //apply type filter if applicable
            if(typeFilter.Count > 0)
            {
                filtered = filtered.Where(p => typeFilter.Contains(p.Type));
            }
            
            //apply alignment filter if applicable
            if(alignmentFilter.Count > 0)
            {
                filtered = filtered.Where(p => alignmentFilter.Contains(p.Alignment));
            }
            
            //apply challenge filter if applicable
            if(challengeFilter.Count > 0)
            {
                filtered = filtered.Where(p => challengeFilter.Contains(p.Challenge));
            }

            //populate the filtered monster list for binding to the Data Grid View

            foreach(Monster m in filtered)
            {
                filteredMonsters.Add(m);
            }

            DGVMonsterList.DataSource = filteredMonsters.Monsters;
        }

        private decimal ParseChallenge(string input)
        {
            //this method is janky af, but to be fair my input file is self policed.
            decimal firstAttempt;
            bool firstAttemptRes;
            decimal leftSide;
            decimal rightSide;
            decimal finalResult = 0.0m;

            firstAttemptRes = decimal.TryParse(input, out firstAttempt);

            if(firstAttemptRes)
            {
                finalResult = firstAttempt;
            }
            else if(input.Contains("/"))
            {
                string[] fract = input.Split('/');
                if(fract.Length == 2 || fract.Length ==3)
                {
                    leftSide = decimal.Parse(fract[0]);
                    rightSide = decimal.Parse(fract[1]);

                    finalResult = leftSide / rightSide;
                }
            }
            else
            {
                finalResult = 0.0m;
            }

            return finalResult;
        }

        private void CLBSize_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox clb = (CheckedListBox)sender;
            string entry = clb.Items[e.Index].ToString();

            if(e.NewValue == CheckState.Checked && !sizeFilter.Contains(entry))
            {
                //apply fiter
                sizeFilter.Add(entry);
            }
            else
            {
                //remove filter
                sizeFilter.Remove(entry);
            }

            ApplyFilters();
        }

        private void CLBType_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox clb = (CheckedListBox)sender;
            string entry = clb.Items[e.Index].ToString();

            if (e.NewValue == CheckState.Checked && !typeFilter.Contains(entry))
            {
                //apply fiter
                typeFilter.Add(entry);
            }
            else
            {
                //remove filter
                typeFilter.Remove(entry);
            }

            ApplyFilters();
        }

        private void CLBAlignment_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox clb = (CheckedListBox)sender;
            string entry = clb.Items[e.Index].ToString();

            if (e.NewValue == CheckState.Checked && !alignmentFilter.Contains(entry))
            {
                //apply fiter
                alignmentFilter.Add(entry);
            }
            else
            {
                //remove filter
                alignmentFilter.Remove(entry);
            }

            ApplyFilters();
        }

        private void CLBChallenge_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox clb = (CheckedListBox)sender;
            string entry = clb.Items[e.Index].ToString();

            if (e.NewValue == CheckState.Checked && !challengeFilter.Contains(entry))
            {
                //apply fiter
                challengeFilter.Add(entry);
            }
            else
            {
                //remove filter
                challengeFilter.Remove(entry);
            }

            ApplyFilters();
        }

        private void DGVMonsterList_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            List<Monster> output = (List<Monster>)DGVMonsterList.DataSource;

            switch(dgv.Columns[e.ColumnIndex].Name)
            {
                case "Name":
                    DGVMonsterList.DataSource = output.OrderBy(x => x.Name).ToList();
                    break;
                case "Size":
                    DGVMonsterList.DataSource = output.OrderBy(x => x.Size).ToList();
                    break;
                case "Type":
                    DGVMonsterList.DataSource = output.OrderBy(x => x.Type).ToList();
                    break;
                case "Alignment":
                    DGVMonsterList.DataSource = output.OrderBy(x => x.Alignment).ToList();
                    break;
                case "Challenge":
                    DGVMonsterList.DataSource = output.OrderBy(x => ParseChallenge(x.Challenge)).ToList();
                    break;
                case "XP":
                    DGVMonsterList.DataSource = output.OrderBy(x => int.Parse(x.XP)).ToList();
                    break;
            }
        }
    }
}

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Units
{
    public partial class UnitSelection : Form
    {
        public Units.UnitNamesEnum Unit { get; private set; }

        public UnitSelection(Units.UnitNamesEnum Unit)
        {
            this.Unit = Unit;

            InitializeComponent();

            setAutocompleteForTextBox();
        }

        public UnitSelection(string Unit)
        {
            this.Unit = Unit.GetUnitNameEnumerator();

            InitializeComponent();

            setAutocompleteForTextBox();
        }

        private void setAutocompleteForTextBox()
        {
            string[] categories = Units.GetAllCategoriesDescription();
            listViewCategory.Clear();
            foreach (string s in categories)
                listViewCategory.Items.Add(s);

            AutoCompleteStringCollection source = new AutoCompleteStringCollection();

            Array Values = System.Enum.GetValues(typeof(Units.UnitNamesEnum));
            foreach (Units.UnitNamesEnum value in Values)
                source.Add(Units.GetUnitSymbol(value));

            textBoxUnit.AutoCompleteCustomSource = source;
        }

        private void UnitSelection_Shown(object sender, EventArgs e)
        {
            textBoxUnit.Text = Units.GetUnitSymbol(Unit);
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        internal bool suppress = false;
        
        private void listViewCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!suppress)
            {
                if (listViewCategory.SelectedItems.Count > 0)
                {
                    for (int i = 0; i < listViewCategory.Items.Count; i++)
                    {
                        ListViewItem li = listViewCategory.Items[i];
                        li.UseItemStyleForSubItems = false;
                        li.ForeColor = SystemColors.WindowText;
                    }

                    ListViewItem item = listViewCategory.SelectedItems[0];
                    item.UseItemStyleForSubItems = false;
                    item.ForeColor = Color.Blue;
                    textBoxUnit.Text = "";
                    fillListViewUnit(item.Text);
                    this.listViewUnit.Select();
                }
            }
        }

        private void listViewUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!suppress)
            {
                if (listViewUnit.SelectedItems.Count > 0)
                {
                    for (int i = 0; i < listViewUnit.Items.Count; i++)
                    {
                        ListViewItem li = listViewUnit.Items[i];
                        li.UseItemStyleForSubItems = false;
                        li.ForeColor = SystemColors.WindowText;
                    }

                    ListViewItem item = listViewUnit.SelectedItems[0];
                    item.UseItemStyleForSubItems = false;
                    item.ForeColor = Color.Blue;

                    Unit = item.Text.GetUnitNameEnumerator();
                    if (!suppress)
                    {
                        suppress = true;
                        textBoxUnit.Text = item.Text;
                        suppress = false;
                        setUnitInformation(Unit);
                    }
                }
            }
        }

        private void textBoxUnit_TextChanged(object sender, EventArgs e)
        {
            if (suppress)
                return;

            Unit = textBoxUnit.Text.GetUnitNameEnumerator();
            setUnitInformation(Unit);
            suppress = true;
            string category = Units.GetUnitCategoryDescriprion(Unit);
            int selectionIndex = -1;
            for (int i = 0; i < listViewCategory.Items.Count; i++)
            {
                ListViewItem li = listViewCategory.Items[i];
                li.UseItemStyleForSubItems = false;
                if (li.Text == category)
                {
                    li.ForeColor = Color.Blue;
                    selectionIndex = i;
                }
                else
                    li.ForeColor = SystemColors.WindowText;
            }

            listViewCategory.Items[selectionIndex].Selected = true;
            fillListViewUnit(category);

            string symbol = Units.GetUnitSymbol(Unit);
            selectionIndex = -1;
            for (int i = 0; i < listViewUnit.Items.Count; i++)
            {
                ListViewItem li = listViewUnit.Items[i];
                li.UseItemStyleForSubItems = false;
                if (li.Text == symbol)
                {
                    li.ForeColor = Color.Blue;
                    selectionIndex = i;
                }
                else
                    li.ForeColor = SystemColors.WindowText;
            }

            suppress = false;
        }

        private void fillListViewUnit(string catogory)
        {
            string[] symbols = Units.GetUnitSymbolByCatogry(catogory, Units.UnitSystem.All | Units.UnitSystem.None);

            listViewUnit.Clear();
            foreach (string s in symbols)
                listViewUnit.Items.Add(s);
        }

        private void setUnitInformation(Units.UnitNamesEnum unit)
        {
            labelLongName.Text = Units.GetUnitLongName(unit);
            Units.UnitSystem s = Units.GetUnitSystem(unit);
            string system = null;

            if ((s & Units.UnitSystem.SI) == Units.UnitSystem.SI)
                system = "SI";
            if ((s & Units.UnitSystem.SI_Derived) == Units.UnitSystem.SI_Derived)
                system = "SI - derived";
            if ((s & Units.UnitSystem.CGS) == Units.UnitSystem.CGS)
                system = "CGS";
            if ((s & Units.UnitSystem.US) == Units.UnitSystem.US)
                system = "US";
            if ((s & Units.UnitSystem.Imperial) == Units.UnitSystem.Imperial)
                system = "Imperial";
            if ((s & Units.UnitSystem.US_Imperial) == Units.UnitSystem.US_Imperial)
                system = "US / Imperial";
            if ((s & Units.UnitSystem.Historic) == Units.UnitSystem.Historic)
                system = "historic";

            labelSystem.Text = system;

            textBoxAlternativeSymbol.Clear();
            string[] gg = Units.GetAlternativeUnitSymbol(unit);
            if (gg != null)
                for (int i = 0; i < gg.Length; i++)
                    textBoxAlternativeSymbol.Text += (gg[i] + Environment.NewLine); 
        }
    }
}

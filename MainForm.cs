using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;

namespace DVCalc
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            PopulateComboBox();

            //make Pokemon searchable
            pokemonSelector.TextChanged += PokemonSelector_TextChanged;
            pokemonSelector.AutoCompleteMode = AutoCompleteMode.Suggest;
            pokemonSelector.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection autoCompleteSource = new AutoCompleteStringCollection();
            foreach (KeyValuePair<int, string> item in pokemonSelector.Items)
            {
                autoCompleteSource.Add(item.Value);
            }

            pokemonSelector.AutoCompleteCustomSource = autoCompleteSource;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            poke_label = new Label();
            trainerClassIdx_label = new Label();
            trainerIdx_label = new Label();
            pokeLVL_label = new Label();
            pokeLevel = new NumericUpDown();
            trainerClassIdx = new NumericUpDown();
            trainerIdx = new NumericUpDown();
            natureSelect = new ComboBox();
            nature_label = new Label();
            DV_label = new Label();
            calcButton = new Button();
            maleCheck = new CheckBox();
            maxDVNature_label = new Label();
            IV_label = new Label();
            pokemonSelector = new ComboBox();
            showAllButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pokeLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trainerClassIdx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trainerIdx).BeginInit();
            SuspendLayout();
            // 
            // poke_label
            // 
            poke_label.AutoSize = true;
            poke_label.Location = new Point(28, 154);
            poke_label.Name = "poke_label";
            poke_label.Size = new Size(58, 15);
            poke_label.TabIndex = 3;
            poke_label.Text = "Pokémon";
            // 
            // trainerClassIdx_label
            // 
            trainerClassIdx_label.AutoSize = true;
            trainerClassIdx_label.Location = new Point(28, 87);
            trainerClassIdx_label.Name = "trainerClassIdx_label";
            trainerClassIdx_label.Size = new Size(104, 15);
            trainerClassIdx_label.TabIndex = 4;
            trainerClassIdx_label.Text = "Trainer Class Index";
            // 
            // trainerIdx_label
            // 
            trainerIdx_label.AutoSize = true;
            trainerIdx_label.Location = new Point(28, 21);
            trainerIdx_label.Name = "trainerIdx_label";
            trainerIdx_label.Size = new Size(74, 15);
            trainerIdx_label.TabIndex = 5;
            trainerIdx_label.Text = "Trainer Index";
            // 
            // pokeLVL_label
            // 
            pokeLVL_label.AutoSize = true;
            pokeLVL_label.Location = new Point(278, 179);
            pokeLVL_label.Name = "pokeLVL_label";
            pokeLVL_label.Size = new Size(28, 15);
            pokeLVL_label.TabIndex = 6;
            pokeLVL_label.Text = "LVL.";
            // 
            // pokeLevel
            // 
            pokeLevel.Location = new Point(318, 177);
            pokeLevel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            pokeLevel.Name = "pokeLevel";
            pokeLevel.Size = new Size(46, 23);
            pokeLevel.TabIndex = 7;
            pokeLevel.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // trainerClassIdx
            // 
            trainerClassIdx.Location = new Point(28, 110);
            trainerClassIdx.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            trainerClassIdx.Name = "trainerClassIdx";
            trainerClassIdx.Size = new Size(125, 23);
            trainerClassIdx.TabIndex = 9;
            // 
            // trainerIdx
            // 
            trainerIdx.Location = new Point(28, 44);
            trainerIdx.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            trainerIdx.Name = "trainerIdx";
            trainerIdx.Size = new Size(125, 23);
            trainerIdx.TabIndex = 10;
            // 
            // natureSelect
            // 
            natureSelect.FormattingEnabled = true;
            natureSelect.Location = new Point(192, 44);
            natureSelect.Name = "natureSelect";
            natureSelect.Size = new Size(207, 23);
            natureSelect.TabIndex = 11;
            // 
            // nature_label
            // 
            nature_label.AutoSize = true;
            nature_label.Location = new Point(192, 21);
            nature_label.Name = "nature_label";
            nature_label.Size = new Size(43, 15);
            nature_label.TabIndex = 12;
            nature_label.Text = "Nature";
            // 
            // DV_label
            // 
            DV_label.AutoSize = true;
            DV_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DV_label.Location = new Point(443, 44);
            DV_label.Name = "DV_label";
            DV_label.Size = new Size(130, 21);
            DV_label.TabIndex = 13;
            DV_label.Text = "Difficulty Value: 0";
            // 
            // calcButton
            // 
            calcButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            calcButton.Location = new Point(491, 179);
            calcButton.Name = "calcButton";
            calcButton.Size = new Size(114, 51);
            calcButton.TabIndex = 14;
            calcButton.Text = "Calculate";
            calcButton.UseVisualStyleBackColor = true;
            calcButton.Click += CalcButton_Click;
            // 
            // maleCheck
            // 
            maleCheck.AutoSize = true;
            maleCheck.Checked = true;
            maleCheck.CheckState = CheckState.Checked;
            maleCheck.Location = new Point(192, 111);
            maleCheck.Name = "maleCheck";
            maleCheck.Size = new Size(95, 19);
            maleCheck.TabIndex = 15;
            maleCheck.Text = "Trainer Male?";
            maleCheck.UseVisualStyleBackColor = true;
            // 
            // maxDVNature_label
            // 
            maxDVNature_label.AutoSize = true;
            maxDVNature_label.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maxDVNature_label.Location = new Point(323, 127);
            maxDVNature_label.Name = "maxDVNature_label";
            maxDVNature_label.Size = new Size(109, 20);
            maxDVNature_label.TabIndex = 16;
            maxDVNature_label.Text = "DV 255 Nature:";
            // 
            // IV_label
            // 
            IV_label.AutoSize = true;
            IV_label.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IV_label.Location = new Point(323, 87);
            IV_label.Name = "IV_label";
            IV_label.Size = new Size(96, 20);
            IV_label.TabIndex = 17;
            IV_label.Text = "Resulting IVs:";
            // 
            // pokemonSelector
            // 
            pokemonSelector.FormattingEnabled = true;
            pokemonSelector.Location = new Point(28, 176);
            pokemonSelector.Name = "pokemonSelector";
            pokemonSelector.Size = new Size(244, 23);
            pokemonSelector.TabIndex = 18;
            // 
            // showAllButton
            // 
            showAllButton.Location = new Point(391, 192);
            showAllButton.Name = "showAllButton";
            showAllButton.Size = new Size(94, 29);
            showAllButton.TabIndex = 19;
            showAllButton.Text = "Show All";
            showAllButton.UseVisualStyleBackColor = true;
            showAllButton.Click += ShowAllButton_Click;
            // 
            // MainForm
            // 
            ClientSize = new Size(628, 242);
            Controls.Add(showAllButton);
            Controls.Add(pokemonSelector);
            Controls.Add(IV_label);
            Controls.Add(maxDVNature_label);
            Controls.Add(maleCheck);
            Controls.Add(calcButton);
            Controls.Add(DV_label);
            Controls.Add(nature_label);
            Controls.Add(natureSelect);
            Controls.Add(trainerIdx);
            Controls.Add(trainerClassIdx);
            Controls.Add(pokeLevel);
            Controls.Add(pokeLVL_label);
            Controls.Add(trainerIdx_label);
            Controls.Add(trainerClassIdx_label);
            Controls.Add(poke_label);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DVCalc";
            ((System.ComponentModel.ISupportInitialize)pokeLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)trainerClassIdx).EndInit();
            ((System.ComponentModel.ISupportInitialize)trainerIdx).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void PopulateComboBox()
        {
            natureSelect.DataSource = Calculator.Natures;

            pokemonSelector.Items.Clear();

            Stream? stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("DVCalc.pokemon_ids.csv");
            if (stream != null)
            {
                using (stream)
                using (StreamReader reader = new StreamReader(stream))
                {
                    string? line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] fields = line.Split(',');

                        if (fields.Length >= 2 && int.TryParse(fields[0], out int id))
                        {
                            string name = fields[1];
                            pokemonSelector.Items.Add(new KeyValuePair<int, string>(id, name));
                        }
                    }
                }
            }
            else
            {
                //If this code path is ever reached I goofed
                MessageBox.Show("Error: Unable to load Pokémon data from embedded resource.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            pokemonSelector.SelectedIndex = 0;

        }

        private void CalcButton_Click(object? sender, EventArgs e)
        {

            uint nature = (uint)natureSelect.SelectedIndex;

            int pokemonIndex = 1;

            if (pokemonSelector.SelectedItem != null)
            {
                KeyValuePair<int, string> selectedPokemon = (KeyValuePair<int, string>)pokemonSelector.SelectedItem;

                pokemonIndex = (int)selectedPokemon.Key;
            }

            int DV = Calculator.findHighestDV((int)trainerIdx.Value, (int)trainerClassIdx.Value, maleCheck.Checked, pokemonIndex, (int)pokeLevel.Value, nature);

            uint maxDVNature = Calculator.getNatureFromPID(Calculator.generatePID((int)trainerIdx.Value, (int)trainerClassIdx.Value, maleCheck.Checked, pokemonIndex, (int)pokeLevel.Value, 255));

            DV_label.Text = "Difficulty Value: " + DV;


            IV_label.Text = "Resulting IVs: " + (DV * 31 / 255);
            maxDVNature_label.Text = "DV 255 Nature: " + Calculator.Natures[(int)maxDVNature];


        }

        private void ShowAllButton_Click(object? sender, EventArgs e)
        {
            int pokemonIndex = 1;

            if (pokemonSelector.SelectedItem != null)
            {
                KeyValuePair<int, string> selectedPokemon = (KeyValuePair<int, string>)pokemonSelector.SelectedItem;

                pokemonIndex = (int)selectedPokemon.Key;

            }

            // Create a list of DV-IV-Nature Triplets
            List<DVIVNatureTriplet> natureDict = Calculator.getAllNatures((int)trainerIdx.Value, (int)trainerClassIdx.Value, maleCheck.Checked, pokemonIndex, (int)pokeLevel.Value);

            // Create an instance of the view form and pass the data
            // There might be a better way to do this?
            NatureViewerForm natureViewer = new NatureViewerForm(natureDict);
            natureViewer.ShowDialog();
        }

        private void PokemonSelector_TextChanged(object? sender, EventArgs e)
        {
            if (sender == null || !(sender is ComboBox)) { return; }

            ComboBox comboBox = (ComboBox)sender;
            string enteredText = comboBox.Text.ToLower();

            // If name of pokemon is typed select that item
            foreach (KeyValuePair<int, string> item in comboBox.Items)
            {
                if (item.Value.ToLower().Equals(enteredText))
                {
                    comboBox.SelectedItem = item;
                    return;
                }
            }
        }

    }
}

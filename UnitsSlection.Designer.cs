namespace Units
{
    partial class UnitSelection
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxUnit = new System.Windows.Forms.TextBox();
            this.listViewCategory = new System.Windows.Forms.ListView();
            this.listViewUnit = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelLongName = new System.Windows.Forms.Label();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelSystem = new System.Windows.Forms.Label();
            this.labelAlternativeSymbol = new System.Windows.Forms.Label();
            this.textBoxAlternativeSymbol = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxUnit
            // 
            this.textBoxUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxUnit.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnit.Location = new System.Drawing.Point(296, 41);
            this.textBoxUnit.Name = "textBoxUnit";
            this.textBoxUnit.Size = new System.Drawing.Size(195, 21);
            this.textBoxUnit.TabIndex = 3;
            this.textBoxUnit.TextChanged += new System.EventHandler(this.textBoxUnit_TextChanged);
            // 
            // listViewCategory
            // 
            this.listViewCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewCategory.FullRowSelect = true;
            this.listViewCategory.Location = new System.Drawing.Point(12, 25);
            this.listViewCategory.MultiSelect = false;
            this.listViewCategory.Name = "listViewCategory";
            this.listViewCategory.ShowGroups = false;
            this.listViewCategory.Size = new System.Drawing.Size(178, 492);
            this.listViewCategory.TabIndex = 1;
            this.listViewCategory.UseCompatibleStateImageBehavior = false;
            this.listViewCategory.View = System.Windows.Forms.View.List;
            this.listViewCategory.SelectedIndexChanged += new System.EventHandler(this.listViewCategory_SelectedIndexChanged);
            // 
            // listViewUnit
            // 
            this.listViewUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewUnit.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewUnit.Location = new System.Drawing.Point(196, 25);
            this.listViewUnit.Name = "listViewUnit";
            this.listViewUnit.ShowGroups = false;
            this.listViewUnit.Size = new System.Drawing.Size(94, 492);
            this.listViewUnit.TabIndex = 2;
            this.listViewUnit.UseCompatibleStateImageBehavior = false;
            this.listViewUnit.View = System.Windows.Forms.View.List;
            this.listViewUnit.SelectedIndexChanged += new System.EventHandler(this.listViewUnit_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Unit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Search for unit";
            // 
            // labelLongName
            // 
            this.labelLongName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLongName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLongName.Location = new System.Drawing.Point(296, 174);
            this.labelLongName.Name = "labelLongName";
            this.labelLongName.Size = new System.Drawing.Size(195, 40);
            this.labelLongName.TabIndex = 6;
            this.labelLongName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonContinue
            // 
            this.buttonContinue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonContinue.Location = new System.Drawing.Point(416, 494);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(75, 23);
            this.buttonContinue.TabIndex = 0;
            this.buttonContinue.Text = "Continue ...";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(335, 494);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Name:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "System:";
            // 
            // labelSystem
            // 
            this.labelSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSystem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSystem.Location = new System.Drawing.Point(296, 227);
            this.labelSystem.Name = "labelSystem";
            this.labelSystem.Size = new System.Drawing.Size(195, 20);
            this.labelSystem.TabIndex = 13;
            this.labelSystem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAlternativeSymbol
            // 
            this.labelAlternativeSymbol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAlternativeSymbol.AutoSize = true;
            this.labelAlternativeSymbol.Location = new System.Drawing.Point(296, 267);
            this.labelAlternativeSymbol.Name = "labelAlternativeSymbol";
            this.labelAlternativeSymbol.Size = new System.Drawing.Size(92, 13);
            this.labelAlternativeSymbol.TabIndex = 15;
            this.labelAlternativeSymbol.Text = "Alternative symbol";
            // 
            // textBoxAlternativeSymbol
            // 
            this.textBoxAlternativeSymbol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAlternativeSymbol.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxAlternativeSymbol.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAlternativeSymbol.Location = new System.Drawing.Point(296, 283);
            this.textBoxAlternativeSymbol.Multiline = true;
            this.textBoxAlternativeSymbol.Name = "textBoxAlternativeSymbol";
            this.textBoxAlternativeSymbol.Size = new System.Drawing.Size(195, 188);
            this.textBoxAlternativeSymbol.TabIndex = 16;
            // 
            // UnitSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 531);
            this.Controls.Add(this.textBoxAlternativeSymbol);
            this.Controls.Add(this.labelAlternativeSymbol);
            this.Controls.Add(this.labelSystem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.labelLongName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewUnit);
            this.Controls.Add(this.listViewCategory);
            this.Controls.Add(this.textBoxUnit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UnitSelection";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PreAnalyseExtended - Unit selection";
            this.Shown += new System.EventHandler(this.UnitSelection_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUnit;
        private System.Windows.Forms.ListView listViewCategory;
        private System.Windows.Forms.ListView listViewUnit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelLongName;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelSystem;
        private System.Windows.Forms.Label labelAlternativeSymbol;
        private System.Windows.Forms.TextBox textBoxAlternativeSymbol;
    }
}


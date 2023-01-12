namespace СourseWork_SecondRealization
{
    partial class NewCharacter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCharacter));
            this.comboBoxage = new System.Windows.Forms.ComboBox();
            this.checkBoxwoman = new System.Windows.Forms.CheckBox();
            this.checkBoxman = new System.Windows.Forms.CheckBox();
            this.numericUpDownheight = new System.Windows.Forms.NumericUpDown();
            this.labelheight = new System.Windows.Forms.Label();
            this.numericUpDownweight = new System.Windows.Forms.NumericUpDown();
            this.labelweight = new System.Windows.Forms.Label();
            this.labelage = new System.Windows.Forms.Label();
            this.labelsex = new System.Windows.Forms.Label();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.labelname = new System.Windows.Forms.Label();
            this.createbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownheight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownweight)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxage
            // 
            this.comboBoxage.BackColor = System.Drawing.Color.Cornsilk;
            this.comboBoxage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxage.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxage.FormattingEnabled = true;
            this.comboBoxage.Items.AddRange(new object[] {
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50"});
            this.comboBoxage.Location = new System.Drawing.Point(156, 225);
            this.comboBoxage.MaxDropDownItems = 6;
            this.comboBoxage.MaxLength = 2;
            this.comboBoxage.Name = "comboBoxage";
            this.comboBoxage.Size = new System.Drawing.Size(68, 28);
            this.comboBoxage.TabIndex = 25;
            // 
            // checkBoxwoman
            // 
            this.checkBoxwoman.AutoSize = true;
            this.checkBoxwoman.BackColor = System.Drawing.Color.Cornsilk;
            this.checkBoxwoman.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxwoman.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxwoman.Location = new System.Drawing.Point(182, 162);
            this.checkBoxwoman.Name = "checkBoxwoman";
            this.checkBoxwoman.Size = new System.Drawing.Size(42, 25);
            this.checkBoxwoman.TabIndex = 24;
            this.checkBoxwoman.Text = "Ж";
            this.checkBoxwoman.UseVisualStyleBackColor = false;
            this.checkBoxwoman.CheckedChanged += new System.EventHandler(this.checkBoxwoman_CheckedChanged);
            // 
            // checkBoxman
            // 
            this.checkBoxman.AutoSize = true;
            this.checkBoxman.BackColor = System.Drawing.Color.Cornsilk;
            this.checkBoxman.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxman.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxman.Location = new System.Drawing.Point(124, 162);
            this.checkBoxman.Name = "checkBoxman";
            this.checkBoxman.Size = new System.Drawing.Size(42, 25);
            this.checkBoxman.TabIndex = 23;
            this.checkBoxman.Text = "M";
            this.checkBoxman.UseVisualStyleBackColor = false;
            this.checkBoxman.CheckedChanged += new System.EventHandler(this.checkBoxman_CheckedChanged);
            // 
            // numericUpDownheight
            // 
            this.numericUpDownheight.BackColor = System.Drawing.Color.Cornsilk;
            this.numericUpDownheight.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownheight.Location = new System.Drawing.Point(430, 163);
            this.numericUpDownheight.Maximum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.numericUpDownheight.Minimum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numericUpDownheight.Name = "numericUpDownheight";
            this.numericUpDownheight.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownheight.TabIndex = 22;
            this.numericUpDownheight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownheight.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // labelheight
            // 
            this.labelheight.AutoSize = true;
            this.labelheight.BackColor = System.Drawing.SystemColors.Info;
            this.labelheight.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelheight.Location = new System.Drawing.Point(378, 163);
            this.labelheight.Name = "labelheight";
            this.labelheight.Size = new System.Drawing.Size(52, 24);
            this.labelheight.TabIndex = 21;
            this.labelheight.Text = "Рост:";
            // 
            // numericUpDownweight
            // 
            this.numericUpDownweight.BackColor = System.Drawing.Color.Cornsilk;
            this.numericUpDownweight.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownweight.Location = new System.Drawing.Point(430, 95);
            this.numericUpDownweight.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownweight.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownweight.Name = "numericUpDownweight";
            this.numericUpDownweight.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownweight.TabIndex = 20;
            this.numericUpDownweight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownweight.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // labelweight
            // 
            this.labelweight.AutoSize = true;
            this.labelweight.BackColor = System.Drawing.SystemColors.Info;
            this.labelweight.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelweight.Location = new System.Drawing.Point(378, 95);
            this.labelweight.Name = "labelweight";
            this.labelweight.Size = new System.Drawing.Size(46, 24);
            this.labelweight.TabIndex = 19;
            this.labelweight.Text = "Вес:";
            // 
            // labelage
            // 
            this.labelage.AutoSize = true;
            this.labelage.BackColor = System.Drawing.SystemColors.Info;
            this.labelage.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelage.Location = new System.Drawing.Point(66, 225);
            this.labelage.Name = "labelage";
            this.labelage.Size = new System.Drawing.Size(82, 24);
            this.labelage.TabIndex = 18;
            this.labelage.Text = "Возраст:";
            // 
            // labelsex
            // 
            this.labelsex.AutoSize = true;
            this.labelsex.BackColor = System.Drawing.SystemColors.Info;
            this.labelsex.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelsex.Location = new System.Drawing.Point(66, 163);
            this.labelsex.Name = "labelsex";
            this.labelsex.Size = new System.Drawing.Size(45, 24);
            this.labelsex.TabIndex = 17;
            this.labelsex.Text = "Пол:";
            // 
            // textBoxname
            // 
            this.textBoxname.BackColor = System.Drawing.Color.Cornsilk;
            this.textBoxname.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxname.Location = new System.Drawing.Point(124, 90);
            this.textBoxname.MaxLength = 20;
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(169, 29);
            this.textBoxname.TabIndex = 16;
            this.textBoxname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxname_KeyPress);
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.BackColor = System.Drawing.SystemColors.Info;
            this.labelname.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelname.Location = new System.Drawing.Point(66, 95);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(52, 24);
            this.labelname.TabIndex = 15;
            this.labelname.Text = "Имя:";
            // 
            // createbutton
            // 
            this.createbutton.BackColor = System.Drawing.Color.Goldenrod;
            this.createbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createbutton.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.createbutton.Location = new System.Drawing.Point(294, 408);
            this.createbutton.Name = "createbutton";
            this.createbutton.Size = new System.Drawing.Size(156, 45);
            this.createbutton.TabIndex = 14;
            this.createbutton.Text = "Создать персонажа";
            this.createbutton.UseVisualStyleBackColor = false;
            this.createbutton.Click += new System.EventHandler(this.createbutton_Click);
            // 
            // NewCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::СourseWork_SecondRealization.Properties.Resources.backforgame;
            this.ClientSize = new System.Drawing.Size(755, 525);
            this.Controls.Add(this.comboBoxage);
            this.Controls.Add(this.checkBoxwoman);
            this.Controls.Add(this.checkBoxman);
            this.Controls.Add(this.numericUpDownheight);
            this.Controls.Add(this.labelheight);
            this.Controls.Add(this.numericUpDownweight);
            this.Controls.Add(this.labelweight);
            this.Controls.Add(this.labelage);
            this.Controls.Add(this.labelsex);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.createbutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(771, 564);
            this.MinimumSize = new System.Drawing.Size(771, 564);
            this.Name = "NewCharacter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание нового персонажа";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewCharacter_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownheight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownweight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxage;
        private System.Windows.Forms.CheckBox checkBoxwoman;
        private System.Windows.Forms.CheckBox checkBoxman;
        private System.Windows.Forms.NumericUpDown numericUpDownheight;
        private System.Windows.Forms.Label labelheight;
        private System.Windows.Forms.NumericUpDown numericUpDownweight;
        private System.Windows.Forms.Label labelweight;
        private System.Windows.Forms.Label labelage;
        private System.Windows.Forms.Label labelsex;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Button createbutton;
    }
}
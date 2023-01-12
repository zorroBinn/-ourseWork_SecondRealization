namespace СourseWork_SecondRealization
{
    partial class Main_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.SaveDeleteButton = new System.Windows.Forms.Button();
            this.AboutGameButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.GameStartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveDeleteButton
            // 
            this.SaveDeleteButton.BackColor = System.Drawing.Color.Goldenrod;
            this.SaveDeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveDeleteButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveDeleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SaveDeleteButton.Location = new System.Drawing.Point(276, 213);
            this.SaveDeleteButton.Name = "SaveDeleteButton";
            this.SaveDeleteButton.Size = new System.Drawing.Size(171, 53);
            this.SaveDeleteButton.TabIndex = 22;
            this.SaveDeleteButton.Text = "Удалить сохранение";
            this.SaveDeleteButton.UseVisualStyleBackColor = false;
            this.SaveDeleteButton.Click += new System.EventHandler(this.SaveDeleteButton_Click);
            // 
            // AboutGameButton
            // 
            this.AboutGameButton.BackColor = System.Drawing.Color.Goldenrod;
            this.AboutGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AboutGameButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AboutGameButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AboutGameButton.Location = new System.Drawing.Point(276, 292);
            this.AboutGameButton.Name = "AboutGameButton";
            this.AboutGameButton.Size = new System.Drawing.Size(171, 53);
            this.AboutGameButton.TabIndex = 21;
            this.AboutGameButton.Text = "Об игре";
            this.AboutGameButton.UseVisualStyleBackColor = false;
            this.AboutGameButton.Click += new System.EventHandler(this.AboutGameButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Goldenrod;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExitButton.Location = new System.Drawing.Point(276, 369);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(171, 53);
            this.ExitButton.TabIndex = 20;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // GameStartButton
            // 
            this.GameStartButton.BackColor = System.Drawing.Color.Goldenrod;
            this.GameStartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GameStartButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameStartButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GameStartButton.Location = new System.Drawing.Point(276, 128);
            this.GameStartButton.Name = "GameStartButton";
            this.GameStartButton.Size = new System.Drawing.Size(171, 53);
            this.GameStartButton.TabIndex = 19;
            this.GameStartButton.Text = "Начать игру";
            this.GameStartButton.UseVisualStyleBackColor = false;
            this.GameStartButton.Click += new System.EventHandler(this.GameStartButton_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::СourseWork_SecondRealization.Properties.Resources.backforgame;
            this.ClientSize = new System.Drawing.Size(755, 525);
            this.Controls.Add(this.SaveDeleteButton);
            this.Controls.Add(this.AboutGameButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.GameStartButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(771, 564);
            this.MinimumSize = new System.Drawing.Size(771, 564);
            this.Name = "Main_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.Activated += new System.EventHandler(this.Main_Menu_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SaveDeleteButton;
        private System.Windows.Forms.Button AboutGameButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button GameStartButton;
    }
}
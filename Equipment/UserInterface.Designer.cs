namespace Equipment
{
    partial class UserInterface
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
            this.button1 = new System.Windows.Forms.Button();
            this.tempConsole = new System.Windows.Forms.RichTextBox();
            this.ComboAvailableEquip = new System.Windows.Forms.ComboBox();
            this.ButtonCheckEquip = new System.Windows.Forms.Button();
            this.ComboReturnEquip = new System.Windows.Forms.ComboBox();
            this.ButtonReturnEquip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show current equipment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.testbutton);
            // 
            // tempConsole
            // 
            this.tempConsole.Location = new System.Drawing.Point(12, 318);
            this.tempConsole.Name = "tempConsole";
            this.tempConsole.Size = new System.Drawing.Size(776, 120);
            this.tempConsole.TabIndex = 1;
            this.tempConsole.Text = "";
            this.tempConsole.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // ComboAvailableEquip
            // 
            this.ComboAvailableEquip.FormattingEnabled = true;
            this.ComboAvailableEquip.Location = new System.Drawing.Point(39, 47);
            this.ComboAvailableEquip.Name = "ComboAvailableEquip";
            this.ComboAvailableEquip.Size = new System.Drawing.Size(171, 28);
            this.ComboAvailableEquip.TabIndex = 2;
            this.ComboAvailableEquip.SelectedIndexChanged += new System.EventHandler(this.ComboAvailableEquip_SelectedIndexChanged);
            foreach (Equipment individual in this.Equipments)
            {
                if (individual.IsEquipped == false)
                {
                    this.ComboAvailableEquip.Items.Add(individual.Name);
                }
            }
            // 
            // ButtonCheckEquip
            // 
            this.ButtonCheckEquip.Location = new System.Drawing.Point(39, 81);
            this.ButtonCheckEquip.Name = "ButtonCheckEquip";
            this.ButtonCheckEquip.Size = new System.Drawing.Size(171, 29);
            this.ButtonCheckEquip.TabIndex = 3;
            this.ButtonCheckEquip.Text = "Check Out Equipment\r\n";
            this.ButtonCheckEquip.UseVisualStyleBackColor = true;
            this.ButtonCheckEquip.Click += new System.EventHandler(this.Check_Click);
            // 
            // ComboReturnEquip
            // 
            this.ComboReturnEquip.FormattingEnabled = true;
            this.ComboReturnEquip.Location = new System.Drawing.Point(230, 47);
            this.ComboReturnEquip.Name = "ComboReturnEquip";
            this.ComboReturnEquip.Size = new System.Drawing.Size(171, 28);
            this.ComboReturnEquip.TabIndex = 4;
            foreach (Equipment individual in CurrentUser.EquipmentCheckedOut)
            {
                this.ComboReturnEquip.Items.Add(individual.Name);
            }
            // 
            // ButtonReturnEquip
            // 
            this.ButtonReturnEquip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonReturnEquip.Location = new System.Drawing.Point(230, 81);
            this.ButtonReturnEquip.Name = "ButtonReturnEquip";
            this.ButtonReturnEquip.Size = new System.Drawing.Size(171, 29);
            this.ButtonReturnEquip.TabIndex = 5;
            this.ButtonReturnEquip.Text = "Return Equipment";
            this.ButtonReturnEquip.UseVisualStyleBackColor = true;
            this.ButtonReturnEquip.Click += new System.EventHandler(this.Return_Click);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonReturnEquip);
            this.Controls.Add(this.ComboReturnEquip);
            this.Controls.Add(this.ButtonCheckEquip);
            this.Controls.Add(this.ComboAvailableEquip);
            this.Controls.Add(this.tempConsole);
            this.Controls.Add(this.button1);
            this.Name = "UserInterface";
            this.Text = "EquipmentManager";
            this.Load += new System.EventHandler(this.UserInterface_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private RichTextBox tempConsole;
        private ComboBox ComboAvailableEquip;
        private Button ButtonCheckEquip;
        private ComboBox ComboReturnEquip;
        private Button ButtonReturnEquip;
    }
}
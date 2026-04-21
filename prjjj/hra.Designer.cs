namespace prjjj
{
    partial class hra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hra));
            labelOtazka = new Label();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            nápovědaToolStripMenuItem = new ToolStripMenuItem();
            ukončitAplikaciToolStripMenuItem = new ToolStripMenuItem();
            buttonA = new Button();
            buttonB = new Button();
            buttonC = new Button();
            buttonD = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // labelOtazka
            // 
            labelOtazka.BackColor = Color.Transparent;
            labelOtazka.ForeColor = SystemColors.Control;
            labelOtazka.Location = new Point(225, 383);
            labelOtazka.Name = "labelOtazka";
            labelOtazka.Size = new Size(570, 62);
            labelOtazka.TabIndex = 0;
            labelOtazka.Text = "Otázka";
            labelOtazka.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ButtonShadow;
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1014, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, nápovědaToolStripMenuItem, ukončitAplikaciToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(50, 20);
            toolStripMenuItem1.Text = "Menu";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(160, 22);
            toolStripMenuItem2.Text = "Hlavní menu";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // nápovědaToolStripMenuItem
            // 
            nápovědaToolStripMenuItem.Name = "nápovědaToolStripMenuItem";
            nápovědaToolStripMenuItem.Size = new Size(160, 22);
            nápovědaToolStripMenuItem.Text = "Nápověda";
            nápovědaToolStripMenuItem.Click += nápovědaToolStripMenuItem_Click;
            // 
            // ukončitAplikaciToolStripMenuItem
            // 
            ukončitAplikaciToolStripMenuItem.Name = "ukončitAplikaciToolStripMenuItem";
            ukončitAplikaciToolStripMenuItem.Size = new Size(160, 22);
            ukončitAplikaciToolStripMenuItem.Text = "Ukončit Aplikaci";
            ukončitAplikaciToolStripMenuItem.Click += ukončitAplikaciToolStripMenuItem_Click;
            // 
            // buttonA
            // 
            buttonA.BackColor = Color.Transparent;
            buttonA.Location = new Point(224, 457);
            buttonA.Name = "buttonA";
            buttonA.Size = new Size(270, 30);
            buttonA.TabIndex = 2;
            buttonA.Text = "A";
            buttonA.UseVisualStyleBackColor = false;
            buttonA.Click += buttonA_Click;
            // 
            // buttonB
            // 
            buttonB.BackColor = Color.Transparent;
            buttonB.ForeColor = SystemColors.ControlText;
            buttonB.Location = new Point(525, 459);
            buttonB.Name = "buttonB";
            buttonB.Size = new Size(270, 30);
            buttonB.TabIndex = 2;
            buttonB.Text = "B";
            buttonB.UseVisualStyleBackColor = false;
            buttonB.Click += buttonB_Click;
            // 
            // buttonC
            // 
            buttonC.BackColor = Color.Transparent;
            buttonC.Location = new Point(225, 500);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(270, 30);
            buttonC.TabIndex = 2;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = false;
            buttonC.Click += buttonC_Click;
            // 
            // buttonD
            // 
            buttonD.BackColor = Color.Transparent;
            buttonD.Location = new Point(525, 501);
            buttonD.Name = "buttonD";
            buttonD.Size = new Size(270, 30);
            buttonD.TabIndex = 2;
            buttonD.Text = "D";
            buttonD.UseVisualStyleBackColor = false;
            buttonD.Click += buttonD_Click;
            // 
            // hra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = Properties.Resources.Gemini_Generated_Image_8i2opa8i2opa8i2o;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1014, 560);
            Controls.Add(buttonD);
            Controls.Add(buttonC);
            Controls.Add(buttonB);
            Controls.Add(buttonA);
            Controls.Add(labelOtazka);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "hra";
            Text = "Milionář";
            Load += hra_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelOtazka;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem nápovědaToolStripMenuItem;
        private Button buttonA;
        private Button buttonB;
        private Button buttonC;
        private Button buttonD;
        private ToolStripMenuItem ukončitAplikaciToolStripMenuItem;
    }
}
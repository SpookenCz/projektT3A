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
            buttonA = new Button();
            buttonB = new Button();
            buttonC = new Button();
            buttonD = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // labelOtazka
            // 
            labelOtazka.AutoSize = true;
            labelOtazka.Location = new Point(334, 105);
            labelOtazka.Name = "labelOtazka";
            labelOtazka.Size = new Size(43, 15);
            labelOtazka.TabIndex = 0;
            labelOtazka.Text = "Otázka";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, nápovědaToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(50, 20);
            toolStripMenuItem1.Text = "Menu";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(142, 22);
            toolStripMenuItem2.Text = "Hlavní menu";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // nápovědaToolStripMenuItem
            // 
            nápovědaToolStripMenuItem.Name = "nápovědaToolStripMenuItem";
            nápovědaToolStripMenuItem.Size = new Size(142, 22);
            nápovědaToolStripMenuItem.Text = "Nápověda";
            nápovědaToolStripMenuItem.Click += nápovědaToolStripMenuItem_Click;
            // 
            // buttonA
            // 
            buttonA.Location = new Point(133, 274);
            buttonA.Name = "buttonA";
            buttonA.Size = new Size(75, 23);
            buttonA.TabIndex = 2;
            buttonA.Text = "A";
            buttonA.UseVisualStyleBackColor = true;
            buttonA.Click += buttonA_Click;
            // 
            // buttonB
            // 
            buttonB.Location = new Point(527, 274);
            buttonB.Name = "buttonB";
            buttonB.Size = new Size(75, 23);
            buttonB.TabIndex = 2;
            buttonB.Text = "B";
            buttonB.UseVisualStyleBackColor = true;
            buttonB.Click += buttonB_Click;
            // 
            // buttonC
            // 
            buttonC.Location = new Point(133, 360);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(75, 23);
            buttonC.TabIndex = 2;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = true;
            buttonC.Click += buttonC_Click;
            // 
            // buttonD
            // 
            buttonD.Location = new Point(527, 360);
            buttonD.Name = "buttonD";
            buttonD.Size = new Size(75, 23);
            buttonD.TabIndex = 2;
            buttonD.Text = "D";
            buttonD.UseVisualStyleBackColor = true;
            buttonD.Click += buttonD_Click;
            // 
            // hra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonD);
            Controls.Add(buttonC);
            Controls.Add(buttonB);
            Controls.Add(buttonA);
            Controls.Add(labelOtazka);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
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
    }
}
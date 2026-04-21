namespace prjjj
{
    partial class napoveda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(napoveda));
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(252, 156);
            label1.Name = "label1";
            label1.Size = new Size(218, 120);
            label1.TabIndex = 0;
            label1.Text = "Vítejte ve hře Chcete se stát milionářem!\r\n\r\n- Vyber správnou odpověď A/B/C/D\r\n- Máš k dispozici nápovědy\r\n- Každá správná odpověď tě posune dál\r\n- Když odpovíš špatně, končíš\r\n\r\nHodně štěstí!";
            // 
            // button1
            // 
            button1.Location = new Point(252, 336);
            button1.Name = "button1";
            button1.Size = new Size(218, 65);
            button1.TabIndex = 1;
            button1.Text = "Zavřít nápovědu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // napoveda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "napoveda";
            Text = "Milionář";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
    }
}
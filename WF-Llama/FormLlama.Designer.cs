namespace WF_Llama
{
    partial class FormLlama
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerApp = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbLC = new System.Windows.Forms.CheckBox();
            this.cbDC = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbCoord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timerApp
            // 
            this.timerApp.Interval = 5500;
            this.timerApp.Tick += new System.EventHandler(this.timerApp_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 44);
            this.label1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::WF_Llama.Properties.Resources.menuIconS;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 44);
            this.button1.TabIndex = 1;
            this.button1.Tag = "!Active";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // cbLC
            // 
            this.cbLC.AutoSize = true;
            this.cbLC.BackColor = System.Drawing.Color.White;
            this.cbLC.Font = new System.Drawing.Font("MS PGothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLC.Location = new System.Drawing.Point(23, 64);
            this.cbLC.Name = "cbLC";
            this.cbLC.Padding = new System.Windows.Forms.Padding(10, 10, 50, 5);
            this.cbLC.Size = new System.Drawing.Size(212, 33);
            this.cbLC.TabIndex = 2;
            this.cbLC.Text = "Llama Coordinates";
            this.cbLC.UseVisualStyleBackColor = false;
            this.cbLC.Visible = false;
            this.cbLC.CheckedChanged += new System.EventHandler(this.cbLC_CheckedChanged);
            // 
            // cbDC
            // 
            this.cbDC.AutoSize = true;
            this.cbDC.BackColor = System.Drawing.Color.White;
            this.cbDC.Font = new System.Drawing.Font("MS PGothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDC.Location = new System.Drawing.Point(23, 90);
            this.cbDC.Name = "cbDC";
            this.cbDC.Padding = new System.Windows.Forms.Padding(10, 10, 13, 5);
            this.cbDC.Size = new System.Drawing.Size(212, 33);
            this.cbDC.TabIndex = 3;
            this.cbDC.Text = "Destination Coordinates";
            this.cbDC.UseVisualStyleBackColor = false;
            this.cbDC.Visible = false;
            this.cbDC.CheckedChanged += new System.EventHandler(this.cbDC_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(23, 123);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(212, 32);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbCoord
            // 
            this.lbCoord.AutoSize = true;
            this.lbCoord.Font = new System.Drawing.Font("MS PGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCoord.ForeColor = System.Drawing.Color.White;
            this.lbCoord.Location = new System.Drawing.Point(63, 27);
            this.lbCoord.Name = "lbCoord";
            this.lbCoord.Size = new System.Drawing.Size(0, 11);
            this.lbCoord.TabIndex = 5;
            // 
            // FormLlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbCoord);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cbDC);
            this.Controls.Add(this.cbLC);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "FormLlama";
            this.Text = "Llama v.0.1.2";
            this.Load += new System.EventHandler(this.FormLlama_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormLlama_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timerApp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbLC;
        private System.Windows.Forms.CheckBox cbDC;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbCoord;
    }
}


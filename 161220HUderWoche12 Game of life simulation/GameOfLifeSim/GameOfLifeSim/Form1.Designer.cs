namespace GameOfLifeSim
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.startbutton = new System.Windows.Forms.Button();
            this.tickbutton = new System.Windows.Forms.Button();
            this.timerzeitbox = new System.Windows.Forms.TextBox();
            this.zeitlabel = new System.Windows.Forms.Label();
            this.startimerbutton = new System.Windows.Forms.Button();
            this.stoptimerbutton = new System.Windows.Forms.Button();
            this.ticktimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // startbutton
            // 
            this.startbutton.Location = new System.Drawing.Point(12, 838);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(75, 23);
            this.startbutton.TabIndex = 0;
            this.startbutton.Text = "Start";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // tickbutton
            // 
            this.tickbutton.Location = new System.Drawing.Point(126, 838);
            this.tickbutton.Name = "tickbutton";
            this.tickbutton.Size = new System.Drawing.Size(75, 23);
            this.tickbutton.TabIndex = 1;
            this.tickbutton.Text = "Manual Tick";
            this.tickbutton.UseVisualStyleBackColor = true;
            this.tickbutton.Click += new System.EventHandler(this.tickbutton_Click);
            // 
            // timerzeitbox
            // 
            this.timerzeitbox.Location = new System.Drawing.Point(711, 812);
            this.timerzeitbox.Name = "timerzeitbox";
            this.timerzeitbox.Size = new System.Drawing.Size(100, 20);
            this.timerzeitbox.TabIndex = 2;
            this.timerzeitbox.TextChanged += new System.EventHandler(this.timerzeitbox_TextChanged);
            // 
            // zeitlabel
            // 
            this.zeitlabel.AutoSize = true;
            this.zeitlabel.Location = new System.Drawing.Point(654, 815);
            this.zeitlabel.Name = "zeitlabel";
            this.zeitlabel.Size = new System.Drawing.Size(57, 13);
            this.zeitlabel.TabIndex = 3;
            this.zeitlabel.Text = "Timer Zeit:";
            // 
            // startimerbutton
            // 
            this.startimerbutton.Location = new System.Drawing.Point(655, 838);
            this.startimerbutton.Name = "startimerbutton";
            this.startimerbutton.Size = new System.Drawing.Size(75, 23);
            this.startimerbutton.TabIndex = 4;
            this.startimerbutton.Text = "Timer start";
            this.startimerbutton.UseVisualStyleBackColor = true;
            this.startimerbutton.Click += new System.EventHandler(this.startimerbutton_Click);
            // 
            // stoptimerbutton
            // 
            this.stoptimerbutton.Location = new System.Drawing.Point(736, 838);
            this.stoptimerbutton.Name = "stoptimerbutton";
            this.stoptimerbutton.Size = new System.Drawing.Size(75, 23);
            this.stoptimerbutton.TabIndex = 5;
            this.stoptimerbutton.Text = "Timer stop";
            this.stoptimerbutton.UseVisualStyleBackColor = true;
            this.stoptimerbutton.Click += new System.EventHandler(this.stoptimerbutton_Click);
            // 
            // ticktimer
            // 
            this.ticktimer.Tick += new System.EventHandler(this.ticktimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(826, 873);
            this.Controls.Add(this.stoptimerbutton);
            this.Controls.Add(this.startimerbutton);
            this.Controls.Add(this.zeitlabel);
            this.Controls.Add(this.timerzeitbox);
            this.Controls.Add(this.tickbutton);
            this.Controls.Add(this.startbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Button tickbutton;
        private System.Windows.Forms.TextBox timerzeitbox;
        private System.Windows.Forms.Label zeitlabel;
        private System.Windows.Forms.Button startimerbutton;
        private System.Windows.Forms.Button stoptimerbutton;
        private System.Windows.Forms.Timer ticktimer;
    }
}


namespace DinamikButon
{
    partial class Form1
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
            this._btnButonOlustur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _btnButonOlustur
            // 
            this._btnButonOlustur.Location = new System.Drawing.Point(97, 72);
            this._btnButonOlustur.Name = "_btnButonOlustur";
            this._btnButonOlustur.Size = new System.Drawing.Size(90, 23);
            this._btnButonOlustur.TabIndex = 0;
            this._btnButonOlustur.Text = "Buton Oluştur";
            this._btnButonOlustur.UseVisualStyleBackColor = true;
            this._btnButonOlustur.Click += new System.EventHandler(this._btnButonOlustur_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 357);
            this.Controls.Add(this._btnButonOlustur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btnButonOlustur;
    }
}


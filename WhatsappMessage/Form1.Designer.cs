namespace WhatsappMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxIcerik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGonder = new System.Windows.Forms.Button();
            this.dgvNumara = new System.Windows.Forms.DataGridView();
            this.buttonKapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumara)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxIcerik
            // 
            this.textBoxIcerik.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxIcerik.Location = new System.Drawing.Point(110, 15);
            this.textBoxIcerik.Multiline = true;
            this.textBoxIcerik.Name = "textBoxIcerik";
            this.textBoxIcerik.Size = new System.Drawing.Size(274, 103);
            this.textBoxIcerik.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 58);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mesaj \r\nİçeriği";
            // 
            // buttonGonder
            // 
            this.buttonGonder.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGonder.Location = new System.Drawing.Point(405, 15);
            this.buttonGonder.Name = "buttonGonder";
            this.buttonGonder.Size = new System.Drawing.Size(100, 50);
            this.buttonGonder.TabIndex = 4;
            this.buttonGonder.Text = "Gönder";
            this.buttonGonder.UseVisualStyleBackColor = true;
            this.buttonGonder.Click += new System.EventHandler(this.buttonGonder_Click);
            // 
            // dgvNumara
            // 
            this.dgvNumara.AllowUserToAddRows = false;
            this.dgvNumara.AllowUserToDeleteRows = false;
            this.dgvNumara.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNumara.Location = new System.Drawing.Point(17, 134);
            this.dgvNumara.Name = "dgvNumara";
            this.dgvNumara.ReadOnly = true;
            this.dgvNumara.RowTemplate.Height = 24;
            this.dgvNumara.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNumara.Size = new System.Drawing.Size(488, 150);
            this.dgvNumara.TabIndex = 5;
            // 
            // buttonKapat
            // 
            this.buttonKapat.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKapat.Location = new System.Drawing.Point(405, 68);
            this.buttonKapat.Name = "buttonKapat";
            this.buttonKapat.Size = new System.Drawing.Size(100, 50);
            this.buttonKapat.TabIndex = 6;
            this.buttonKapat.Text = "Kapat";
            this.buttonKapat.UseVisualStyleBackColor = true;
            this.buttonKapat.Click += new System.EventHandler(this.buttonKapat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 295);
            this.ControlBox = false;
            this.Controls.Add(this.buttonKapat);
            this.Controls.Add(this.dgvNumara);
            this.Controls.Add(this.buttonGonder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIcerik);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "WhatsApp Mesaj";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxIcerik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGonder;
        private System.Windows.Forms.DataGridView dgvNumara;
        private System.Windows.Forms.Button buttonKapat;
    }
}


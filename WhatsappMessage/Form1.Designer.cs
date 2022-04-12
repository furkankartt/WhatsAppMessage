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
            this.dgvNumara = new System.Windows.Forms.DataGridView();
            this.buttonKapat = new System.Windows.Forms.Button();
            this.buttonGonder = new System.Windows.Forms.Button();
            this.textBoxIcerik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumara)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNumara
            // 
            this.dgvNumara.AllowUserToAddRows = false;
            this.dgvNumara.AllowUserToDeleteRows = false;
            this.dgvNumara.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNumara.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNumara.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNumara.Location = new System.Drawing.Point(17, 196);
            this.dgvNumara.Name = "dgvNumara";
            this.dgvNumara.ReadOnly = true;
            this.dgvNumara.RowTemplate.Height = 24;
            this.dgvNumara.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNumara.Size = new System.Drawing.Size(788, 217);
            this.dgvNumara.TabIndex = 5;
            // 
            // buttonKapat
            // 
            this.buttonKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonKapat.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKapat.Location = new System.Drawing.Point(653, 100);
            this.buttonKapat.Name = "buttonKapat";
            this.buttonKapat.Size = new System.Drawing.Size(152, 75);
            this.buttonKapat.TabIndex = 6;
            this.buttonKapat.Text = "Kapat";
            this.buttonKapat.UseVisualStyleBackColor = true;
            this.buttonKapat.Click += new System.EventHandler(this.buttonKapat_Click);
            // 
            // buttonGonder
            // 
            this.buttonGonder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGonder.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGonder.Location = new System.Drawing.Point(653, 19);
            this.buttonGonder.Name = "buttonGonder";
            this.buttonGonder.Size = new System.Drawing.Size(152, 75);
            this.buttonGonder.TabIndex = 4;
            this.buttonGonder.Text = "Gönder";
            this.buttonGonder.UseVisualStyleBackColor = true;
            this.buttonGonder.Click += new System.EventHandler(this.buttonGonder_Click);
            // 
            // textBoxIcerik
            // 
            this.textBoxIcerik.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIcerik.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxIcerik.Location = new System.Drawing.Point(163, 20);
            this.textBoxIcerik.Multiline = true;
            this.textBoxIcerik.Name = "textBoxIcerik";
            this.textBoxIcerik.Size = new System.Drawing.Size(470, 155);
            this.textBoxIcerik.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mesaj İçeriği";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 425);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIcerik);
            this.Controls.Add(this.buttonGonder);
            this.Controls.Add(this.dgvNumara);
            this.Controls.Add(this.buttonKapat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "WhatsApp Mesaj";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvNumara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIcerik;
        private System.Windows.Forms.Button buttonGonder;
        private System.Windows.Forms.Button buttonKapat;
    }
}


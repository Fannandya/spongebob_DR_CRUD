namespace CRUDMahasiswaADO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLoad = new Button();
            btnConnect = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNIM = new TextBox();
            txtAlamat = new TextBox();
            txtKodeProdi = new TextBox();
            txtNama = new TextBox();
            cmbJK = new ComboBox();
            dtpTanggalLahir = new DateTimePicker();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(498, 88);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(112, 33);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(498, 36);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(112, 34);
            btnConnect.TabIndex = 1;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 50);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 2;
            label1.Text = "NIM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 94);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 3;
            label2.Text = "Nama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 245);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 4;
            label3.Text = "Alamat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 135);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 5;
            label4.Text = "Jenis Kelamin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 172);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 6;
            label5.Text = "Tanggal Lahir";
            // 
            // txtNIM
            // 
            txtNIM.Location = new Point(178, 47);
            txtNIM.Name = "txtNIM";
            txtNIM.Size = new Size(125, 27);
            txtNIM.TabIndex = 7;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(178, 238);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(125, 27);
            txtAlamat.TabIndex = 8;
            // 
            // txtKodeProdi
            // 
            txtKodeProdi.Location = new Point(178, 205);
            txtKodeProdi.Name = "txtKodeProdi";
            txtKodeProdi.Size = new Size(125, 27);
            txtKodeProdi.TabIndex = 9;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(178, 87);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(125, 27);
            txtNama.TabIndex = 10;
            // 
            // cmbJK
            // 
            cmbJK.FormattingEnabled = true;
            cmbJK.Location = new Point(178, 127);
            cmbJK.Name = "cmbJK";
            cmbJK.Size = new Size(151, 28);
            cmbJK.TabIndex = 11;
            // 
            // dtpTanggalLahir
            // 
            dtpTanggalLahir.Location = new Point(178, 172);
            dtpTanggalLahir.Name = "dtpTanggalLahir";
            dtpTanggalLahir.Size = new Size(250, 27);
            dtpTanggalLahir.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 212);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(83, 20);
            label6.TabIndex = 13;
            label6.Text = "Kode Prodi";
            // 
            // button1
            // 
            button1.Location = new Point(498, 135);
            button1.Name = "button1";
            button1.Size = new Size(112, 30);
            button1.TabIndex = 14;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(498, 185);
            button2.Name = "button2";
            button2.Size = new Size(112, 30);
            button2.TabIndex = 15;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(498, 236);
            button3.Name = "button3";
            button3.Size = new Size(112, 29);
            button3.TabIndex = 16;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(dtpTanggalLahir);
            Controls.Add(cmbJK);
            Controls.Add(txtNama);
            Controls.Add(txtKodeProdi);
            Controls.Add(txtAlamat);
            Controls.Add(txtNIM);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnConnect);
            Controls.Add(btnLoad);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoad;
        private Button btnConnect;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNIM;
        private TextBox txtAlamat;
        private TextBox txtKodeProdi;
        private TextBox txtNama;
        private ComboBox cmbJK;
        private DateTimePicker dtpTanggalLahir;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}

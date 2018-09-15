namespace AndrianAlexanderPutraCodingTest2
{
    partial class frmAreaParkir
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxJenis = new System.Windows.Forms.TextBox();
            this.tbxOutput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlHomepage = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxJenisK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkbxBus = new System.Windows.Forms.CheckBox();
            this.chkbxMobil = new System.Windows.Forms.CheckBox();
            this.chkbxMotor = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnAddK = new System.Windows.Forms.Button();
            this.pnlHomepage.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(186, 145);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mengetahui Area Parkir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jenis Kendaraan";
            // 
            // tbxJenis
            // 
            this.tbxJenis.Location = new System.Drawing.Point(186, 101);
            this.tbxJenis.Name = "tbxJenis";
            this.tbxJenis.Size = new System.Drawing.Size(100, 22);
            this.tbxJenis.TabIndex = 3;
            // 
            // tbxOutput
            // 
            this.tbxOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbxOutput.Location = new System.Drawing.Point(0, 239);
            this.tbxOutput.Multiline = true;
            this.tbxOutput.Name = "tbxOutput";
            this.tbxOutput.ReadOnly = true;
            this.tbxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxOutput.Size = new System.Drawing.Size(359, 211);
            this.tbxOutput.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-3, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Output";
            // 
            // pnlHomepage
            // 
            this.pnlHomepage.Controls.Add(this.btnCheck);
            this.pnlHomepage.Controls.Add(this.label6);
            this.pnlHomepage.Controls.Add(this.label5);
            this.pnlHomepage.Controls.Add(this.chkbxMotor);
            this.pnlHomepage.Controls.Add(this.chkbxMobil);
            this.pnlHomepage.Controls.Add(this.chkbxBus);
            this.pnlHomepage.Controls.Add(this.label4);
            this.pnlHomepage.Controls.Add(this.tbxJenisK);
            this.pnlHomepage.Controls.Add(this.btnAdd);
            this.pnlHomepage.Location = new System.Drawing.Point(0, -2);
            this.pnlHomepage.Name = "pnlHomepage";
            this.pnlHomepage.Size = new System.Drawing.Size(359, 243);
            this.pnlHomepage.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(48, 175);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(265, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxJenisK
            // 
            this.tbxJenisK.Location = new System.Drawing.Point(183, 58);
            this.tbxJenisK.Name = "tbxJenisK";
            this.tbxJenisK.Size = new System.Drawing.Size(140, 22);
            this.tbxJenisK.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Jenis Kendaraan";
            // 
            // chkbxBus
            // 
            this.chkbxBus.AutoSize = true;
            this.chkbxBus.Location = new System.Drawing.Point(41, 118);
            this.chkbxBus.Name = "chkbxBus";
            this.chkbxBus.Size = new System.Drawing.Size(127, 21);
            this.chkbxBus.TabIndex = 3;
            this.chkbxBus.Text = "Area parkir bus";
            this.chkbxBus.UseVisualStyleBackColor = true;
            // 
            // chkbxMobil
            // 
            this.chkbxMobil.AutoSize = true;
            this.chkbxMobil.Location = new System.Drawing.Point(41, 145);
            this.chkbxMobil.Name = "chkbxMobil";
            this.chkbxMobil.Size = new System.Drawing.Size(137, 21);
            this.chkbxMobil.TabIndex = 4;
            this.chkbxMobil.Text = "Area parkir mobil";
            this.chkbxMobil.UseVisualStyleBackColor = true;
            // 
            // chkbxMotor
            // 
            this.chkbxMotor.AutoSize = true;
            this.chkbxMotor.Location = new System.Drawing.Point(182, 118);
            this.chkbxMotor.Name = "chkbxMotor";
            this.chkbxMotor.Size = new System.Drawing.Size(140, 21);
            this.chkbxMotor.TabIndex = 5;
            this.chkbxMotor.Text = "Area parkir motor";
            this.chkbxMotor.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Lot parkir yang diperbolehkan: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(288, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tambah Jenis Kendaraan";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(48, 204);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(265, 23);
            this.btnCheck.TabIndex = 8;
            this.btnCheck.Text = "Periksa Tempat Parkir Kendaraan";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnAddK
            // 
            this.btnAddK.Location = new System.Drawing.Point(186, 175);
            this.btnAddK.Name = "btnAddK";
            this.btnAddK.Size = new System.Drawing.Size(75, 23);
            this.btnAddK.TabIndex = 7;
            this.btnAddK.Text = "Add";
            this.btnAddK.UseVisualStyleBackColor = true;
            this.btnAddK.Click += new System.EventHandler(this.btnAddK_Click);
            // 
            // frmAreaParkir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 450);
            this.Controls.Add(this.pnlHomepage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxOutput);
            this.Controls.Add(this.tbxJenis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnAddK);
            this.Name = "frmAreaParkir";
            this.Text = "Area Parkir";
            this.pnlHomepage.ResumeLayout(false);
            this.pnlHomepage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxJenis;
        private System.Windows.Forms.TextBox tbxOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlHomepage;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkbxMotor;
        private System.Windows.Forms.CheckBox chkbxMobil;
        private System.Windows.Forms.CheckBox chkbxBus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxJenisK;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddK;
    }
}


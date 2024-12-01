namespace CSharpEgitimKampi301.EFProject
{
    partial class FrmNewLocation
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
            this.cmbGuide = new System.Windows.Forms.ComboBox();
            this.nudCapacity = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDayNight = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnGetByID = new System.Windows.Forms.Button();
            this.btnUptade = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnList = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbGuide
            // 
            this.cmbGuide.FormattingEnabled = true;
            this.cmbGuide.Location = new System.Drawing.Point(130, 298);
            this.cmbGuide.Name = "cmbGuide";
            this.cmbGuide.Size = new System.Drawing.Size(204, 24);
            this.cmbGuide.TabIndex = 55;
            // 
            // nudCapacity
            // 
            this.nudCapacity.Location = new System.Drawing.Point(130, 177);
            this.nudCapacity.Name = "nudCapacity";
            this.nudCapacity.Size = new System.Drawing.Size(204, 22);
            this.nudCapacity.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 53;
            this.label7.Text = "Rehber:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 52;
            this.label6.Text = "Gün Gece:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 51;
            this.label5.Text = "Kapasite:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 50;
            this.label4.Text = "Fiyat:";
            // 
            // txtDayNight
            // 
            this.txtDayNight.Location = new System.Drawing.Point(130, 260);
            this.txtDayNight.Name = "txtDayNight";
            this.txtDayNight.Size = new System.Drawing.Size(204, 22);
            this.txtDayNight.TabIndex = 49;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(130, 216);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(204, 22);
            this.txtPrice.TabIndex = 48;
            // 
            // btnGetByID
            // 
            this.btnGetByID.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGetByID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetByID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGetByID.Location = new System.Drawing.Point(130, 532);
            this.btnGetByID.Name = "btnGetByID";
            this.btnGetByID.Size = new System.Drawing.Size(204, 39);
            this.btnGetByID.TabIndex = 47;
            this.btnGetByID.Text = "Id ye göre getir";
            this.btnGetByID.UseVisualStyleBackColor = false;
            // 
            // btnUptade
            // 
            this.btnUptade.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUptade.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUptade.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUptade.Location = new System.Drawing.Point(130, 487);
            this.btnUptade.Name = "btnUptade";
            this.btnUptade.Size = new System.Drawing.Size(204, 39);
            this.btnUptade.TabIndex = 46;
            this.btnUptade.Text = "Güncelle";
            this.btnUptade.UseVisualStyleBackColor = false;
            this.btnUptade.Click += new System.EventHandler(this.btnUptade_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(130, 442);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(204, 39);
            this.btnDelete.TabIndex = 45;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(130, 397);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(204, 39);
            this.btnAdd.TabIndex = 44;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(130, 143);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(204, 22);
            this.txtCountry.TabIndex = 43;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(130, 110);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(204, 22);
            this.txtCity.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "Ülke:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "Şehir:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(377, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(794, 553);
            this.dataGridView1.TabIndex = 39;
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnList.Location = new System.Drawing.Point(130, 353);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(204, 38);
            this.btnList.TabIndex = 38;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(130, 75);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(204, 22);
            this.txtId.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Lokasyon ID:";
            // 
            // FrmNewLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 584);
            this.Controls.Add(this.cmbGuide);
            this.Controls.Add(this.nudCapacity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDayNight);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnGetByID);
            this.Controls.Add(this.btnUptade);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Name = "FrmNewLocation";
            this.Text = "FrmNewLocation";
            this.Load += new System.EventHandler(this.FrmNewLocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGuide;
        private System.Windows.Forms.NumericUpDown nudCapacity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDayNight;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnGetByID;
        private System.Windows.Forms.Button btnUptade;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
    }
}
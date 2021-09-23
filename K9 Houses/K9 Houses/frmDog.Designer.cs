
namespace K9_Houses
{
    partial class frmDog
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
            this.title = new System.Windows.Forms.Label();
            this.tabCustomer = new System.Windows.Forms.TabControl();
            this.displayBackground = new System.Windows.Forms.TabPage();
            this.dogDisplayDelete = new System.Windows.Forms.Button();
            this.dogDisplayEdit = new System.Windows.Forms.Button();
            this.dogDisplayAdd = new System.Windows.Forms.Button();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.tapPage2 = new System.Windows.Forms.TabPage();
            this.editBreed = new System.Windows.Forms.TextBox();
            this.lblAddCustNo = new System.Windows.Forms.Label();
            this.dogCancel = new System.Windows.Forms.Button();
            this.dogAddAdd = new System.Windows.Forms.Button();
            this.foreName = new System.Windows.Forms.Label();
            this.surName = new System.Windows.Forms.Label();
            this.customerNo = new System.Windows.Forms.Label();
            this.txtAddSize = new System.Windows.Forms.TextBox();
            this.txtBreedName = new System.Windows.Forms.TextBox();
            this.dogImage = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dogCancelCancel = new System.Windows.Forms.Button();
            this.dogEditEdit = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEditBreedSize = new System.Windows.Forms.TextBox();
            this.txtEditBreedName = new System.Windows.Forms.TextBox();
            this.lblEditBreed = new System.Windows.Forms.Label();
            this.tabCustomer.SuspendLayout();
            this.displayBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.tapPage2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Script MT Bold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Gold;
            this.title.Location = new System.Drawing.Point(105, -113);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(573, 70);
            this.title.TabIndex = 2;
            this.title.Text = "K9 Houses";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabCustomer
            // 
            this.tabCustomer.Controls.Add(this.displayBackground);
            this.tabCustomer.Controls.Add(this.tapPage2);
            this.tabCustomer.Controls.Add(this.tabPage2);
            this.tabCustomer.Location = new System.Drawing.Point(61, 77);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.SelectedIndex = 0;
            this.tabCustomer.Size = new System.Drawing.Size(704, 589);
            this.tabCustomer.TabIndex = 4;
            // 
            // displayBackground
            // 
            this.displayBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.displayBackground.Controls.Add(this.dogDisplayDelete);
            this.displayBackground.Controls.Add(this.dogDisplayEdit);
            this.displayBackground.Controls.Add(this.dogDisplayAdd);
            this.displayBackground.Controls.Add(this.dgvCustomers);
            this.displayBackground.Location = new System.Drawing.Point(4, 22);
            this.displayBackground.Name = "displayBackground";
            this.displayBackground.Padding = new System.Windows.Forms.Padding(3);
            this.displayBackground.Size = new System.Drawing.Size(696, 563);
            this.displayBackground.TabIndex = 0;
            this.displayBackground.Text = "Display";
            // 
            // dogDisplayDelete
            // 
            this.dogDisplayDelete.BackColor = System.Drawing.Color.Red;
            this.dogDisplayDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogDisplayDelete.Location = new System.Drawing.Point(570, 129);
            this.dogDisplayDelete.Name = "dogDisplayDelete";
            this.dogDisplayDelete.Size = new System.Drawing.Size(106, 51);
            this.dogDisplayDelete.TabIndex = 5;
            this.dogDisplayDelete.Text = "Delete";
            this.dogDisplayDelete.UseVisualStyleBackColor = false;
            // 
            // dogDisplayEdit
            // 
            this.dogDisplayEdit.BackColor = System.Drawing.Color.Lime;
            this.dogDisplayEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogDisplayEdit.Location = new System.Drawing.Point(570, 72);
            this.dogDisplayEdit.Name = "dogDisplayEdit";
            this.dogDisplayEdit.Size = new System.Drawing.Size(106, 51);
            this.dogDisplayEdit.TabIndex = 4;
            this.dogDisplayEdit.Text = "Edit";
            this.dogDisplayEdit.UseVisualStyleBackColor = false;
            // 
            // dogDisplayAdd
            // 
            this.dogDisplayAdd.BackColor = System.Drawing.Color.Lime;
            this.dogDisplayAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogDisplayAdd.Location = new System.Drawing.Point(570, 15);
            this.dogDisplayAdd.Name = "dogDisplayAdd";
            this.dogDisplayAdd.Size = new System.Drawing.Size(106, 51);
            this.dogDisplayAdd.TabIndex = 3;
            this.dogDisplayAdd.Text = "Add";
            this.dogDisplayAdd.UseVisualStyleBackColor = false;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(15, 15);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.Size = new System.Drawing.Size(539, 525);
            this.dgvCustomers.TabIndex = 2;
            // 
            // tapPage2
            // 
            this.tapPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tapPage2.Controls.Add(this.editBreed);
            this.tapPage2.Controls.Add(this.lblAddCustNo);
            this.tapPage2.Controls.Add(this.dogCancel);
            this.tapPage2.Controls.Add(this.dogAddAdd);
            this.tapPage2.Controls.Add(this.foreName);
            this.tapPage2.Controls.Add(this.surName);
            this.tapPage2.Controls.Add(this.customerNo);
            this.tapPage2.Controls.Add(this.txtAddSize);
            this.tapPage2.Controls.Add(this.txtBreedName);
            this.tapPage2.Controls.Add(this.dogImage);
            this.tapPage2.Location = new System.Drawing.Point(4, 22);
            this.tapPage2.Name = "tapPage2";
            this.tapPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tapPage2.Size = new System.Drawing.Size(696, 563);
            this.tapPage2.TabIndex = 1;
            this.tapPage2.Text = "Add";
            // 
            // editBreed
            // 
            this.editBreed.Location = new System.Drawing.Point(151, 44);
            this.editBreed.Name = "editBreed";
            this.editBreed.Size = new System.Drawing.Size(327, 20);
            this.editBreed.TabIndex = 22;
            // 
            // lblAddCustNo
            // 
            this.lblAddCustNo.AutoSize = true;
            this.lblAddCustNo.Location = new System.Drawing.Point(151, 28);
            this.lblAddCustNo.Name = "lblAddCustNo";
            this.lblAddCustNo.Size = new System.Drawing.Size(13, 13);
            this.lblAddCustNo.TabIndex = 21;
            this.lblAddCustNo.Text = "L";
            // 
            // dogCancel
            // 
            this.dogCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dogCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogCancel.ForeColor = System.Drawing.Color.Blue;
            this.dogCancel.Location = new System.Drawing.Point(538, 108);
            this.dogCancel.Name = "dogCancel";
            this.dogCancel.Size = new System.Drawing.Size(120, 53);
            this.dogCancel.TabIndex = 19;
            this.dogCancel.Text = "Cancel";
            this.dogCancel.UseVisualStyleBackColor = false;
            // 
            // dogAddAdd
            // 
            this.dogAddAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dogAddAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogAddAdd.ForeColor = System.Drawing.Color.Blue;
            this.dogAddAdd.Location = new System.Drawing.Point(538, 28);
            this.dogAddAdd.Name = "dogAddAdd";
            this.dogAddAdd.Size = new System.Drawing.Size(120, 53);
            this.dogAddAdd.TabIndex = 18;
            this.dogAddAdd.Text = "Add";
            this.dogAddAdd.UseVisualStyleBackColor = false;
            // 
            // foreName
            // 
            this.foreName.AutoSize = true;
            this.foreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreName.Location = new System.Drawing.Point(31, 124);
            this.foreName.Name = "foreName";
            this.foreName.Size = new System.Drawing.Size(90, 18);
            this.foreName.TabIndex = 16;
            this.foreName.Text = "Breed Size";
            // 
            // surName
            // 
            this.surName.AutoSize = true;
            this.surName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surName.Location = new System.Drawing.Point(31, 84);
            this.surName.Name = "surName";
            this.surName.Size = new System.Drawing.Size(110, 18);
            this.surName.TabIndex = 15;
            this.surName.Text = "Breeds Name";
            // 
            // customerNo
            // 
            this.customerNo.AutoSize = true;
            this.customerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNo.Location = new System.Drawing.Point(31, 44);
            this.customerNo.Name = "customerNo";
            this.customerNo.Size = new System.Drawing.Size(79, 18);
            this.customerNo.TabIndex = 9;
            this.customerNo.Text = "Breed No";
            // 
            // txtAddSize
            // 
            this.txtAddSize.Location = new System.Drawing.Point(151, 125);
            this.txtAddSize.Name = "txtAddSize";
            this.txtAddSize.Size = new System.Drawing.Size(327, 20);
            this.txtAddSize.TabIndex = 8;
            // 
            // txtBreedName
            // 
            this.txtBreedName.Location = new System.Drawing.Point(151, 85);
            this.txtBreedName.Name = "txtBreedName";
            this.txtBreedName.Size = new System.Drawing.Size(327, 20);
            this.txtBreedName.TabIndex = 2;
            // 
            // dogImage
            // 
            this.dogImage.Image = global::K9_Houses.Properties.Resources.IrishWolfhound;
            this.dogImage.Location = new System.Drawing.Point(228, 163);
            this.dogImage.Name = "dogImage";
            this.dogImage.Size = new System.Drawing.Size(203, 383);
            this.dogImage.TabIndex = 20;
            this.dogImage.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tabPage2.Controls.Add(this.lblEditBreed);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtEditBreedSize);
            this.tabPage2.Controls.Add(this.txtEditBreedName);
            this.tabPage2.Controls.Add(this.dogCancelCancel);
            this.tabPage2.Controls.Add(this.dogEditEdit);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(696, 563);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Edit";
            // 
            // dogCancelCancel
            // 
            this.dogCancelCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dogCancelCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogCancelCancel.ForeColor = System.Drawing.Color.Blue;
            this.dogCancelCancel.Location = new System.Drawing.Point(535, 124);
            this.dogCancelCancel.Name = "dogCancelCancel";
            this.dogCancelCancel.Size = new System.Drawing.Size(120, 53);
            this.dogCancelCancel.TabIndex = 41;
            this.dogCancelCancel.Text = "Cancel";
            this.dogCancelCancel.UseVisualStyleBackColor = false;
            // 
            // dogEditEdit
            // 
            this.dogEditEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dogEditEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogEditEdit.ForeColor = System.Drawing.Color.Blue;
            this.dogEditEdit.Location = new System.Drawing.Point(535, 49);
            this.dogEditEdit.Name = "dogEditEdit";
            this.dogEditEdit.Size = new System.Drawing.Size(120, 53);
            this.dogEditEdit.TabIndex = 40;
            this.dogEditEdit.Text = "Edit";
            this.dogEditEdit.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Script MT Bold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gold;
            this.label11.Location = new System.Drawing.Point(118, -10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(573, 70);
            this.label11.TabIndex = 3;
            this.label11.Text = "K9 Houses";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 46;
            this.label1.Text = "Breed Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 45;
            this.label2.Text = "Breeds Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 44;
            this.label3.Text = "Breed No";
            // 
            // txtEditBreedSize
            // 
            this.txtEditBreedSize.Location = new System.Drawing.Point(144, 130);
            this.txtEditBreedSize.Name = "txtEditBreedSize";
            this.txtEditBreedSize.Size = new System.Drawing.Size(327, 20);
            this.txtEditBreedSize.TabIndex = 43;
            // 
            // txtEditBreedName
            // 
            this.txtEditBreedName.Location = new System.Drawing.Point(144, 90);
            this.txtEditBreedName.Name = "txtEditBreedName";
            this.txtEditBreedName.Size = new System.Drawing.Size(327, 20);
            this.txtEditBreedName.TabIndex = 42;
            // 
            // lblEditBreed
            // 
            this.lblEditBreed.AutoSize = true;
            this.lblEditBreed.Location = new System.Drawing.Point(158, 54);
            this.lblEditBreed.Name = "lblEditBreed";
            this.lblEditBreed.Size = new System.Drawing.Size(13, 13);
            this.lblEditBreed.TabIndex = 47;
            this.lblEditBreed.Text = "L";
            // 
            // frmDog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(826, 657);
            this.Controls.Add(this.tabCustomer);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.title);
            this.Name = "frmDog";
            this.Text = "frmDog";
            this.tabCustomer.ResumeLayout(false);
            this.displayBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.tapPage2.ResumeLayout(false);
            this.tapPage2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TabControl tabCustomer;
        private System.Windows.Forms.TabPage displayBackground;
        private System.Windows.Forms.Button dogDisplayDelete;
        private System.Windows.Forms.Button dogDisplayEdit;
        private System.Windows.Forms.Button dogDisplayAdd;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.TabPage tapPage2;
        private System.Windows.Forms.TextBox editBreed;
        private System.Windows.Forms.Label lblAddCustNo;
        private System.Windows.Forms.Button dogCancel;
        private System.Windows.Forms.Button dogAddAdd;
        private System.Windows.Forms.Label foreName;
        private System.Windows.Forms.Label surName;
        private System.Windows.Forms.Label customerNo;
        private System.Windows.Forms.TextBox txtAddSize;
        private System.Windows.Forms.TextBox txtBreedName;
        private System.Windows.Forms.Button dogImage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button dogCancelCancel;
        private System.Windows.Forms.Button dogEditEdit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEditBreedSize;
        private System.Windows.Forms.TextBox txtEditBreedName;
        private System.Windows.Forms.Label lblEditBreed;
    }
}
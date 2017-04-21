namespace DatabaseServer
{
    partial class Client
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabCraete = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCdept = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCsem = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCid = new System.Windows.Forms.TextBox();
            this.tabDelete = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDId = new System.Windows.Forms.TextBox();
            this.tabUpdate = new System.Windows.Forms.TabPage();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUDepart = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUSemis = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUId = new System.Windows.Forms.TextBox();
            this.tabReport = new System.Windows.Forms.TabPage();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenarate = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlAuthonication = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUMPassword = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl.SuspendLayout();
            this.tabCraete.SuspendLayout();
            this.tabDelete.SuspendLayout();
            this.tabUpdate.SuspendLayout();
            this.tabReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.pnlAuthonication.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabCraete);
            this.tabControl.Controls.Add(this.tabDelete);
            this.tabControl.Controls.Add(this.tabUpdate);
            this.tabControl.Controls.Add(this.tabReport);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(632, 528);
            this.tabControl.TabIndex = 0;
            // 
            // tabCraete
            // 
            this.tabCraete.Controls.Add(this.label4);
            this.tabCraete.Controls.Add(this.txtCdept);
            this.tabCraete.Controls.Add(this.label5);
            this.tabCraete.Controls.Add(this.txtCsem);
            this.tabCraete.Controls.Add(this.btnCreate);
            this.tabCraete.Controls.Add(this.label3);
            this.tabCraete.Controls.Add(this.label2);
            this.tabCraete.Controls.Add(this.txtCname);
            this.tabCraete.Controls.Add(this.label1);
            this.tabCraete.Controls.Add(this.txtCid);
            this.tabCraete.Location = new System.Drawing.Point(4, 22);
            this.tabCraete.Name = "tabCraete";
            this.tabCraete.Padding = new System.Windows.Forms.Padding(3);
            this.tabCraete.Size = new System.Drawing.Size(624, 502);
            this.tabCraete.TabIndex = 0;
            this.tabCraete.Text = "Create";
            this.tabCraete.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(138, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "Department";
            // 
            // txtCdept
            // 
            this.txtCdept.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCdept.Location = new System.Drawing.Point(267, 253);
            this.txtCdept.Name = "txtCdept";
            this.txtCdept.Size = new System.Drawing.Size(179, 27);
            this.txtCdept.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(138, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Semister";
            // 
            // txtCsem
            // 
            this.txtCsem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCsem.Location = new System.Drawing.Point(268, 218);
            this.txtCsem.Name = "txtCsem";
            this.txtCsem.Size = new System.Drawing.Size(179, 27);
            this.txtCsem.TabIndex = 12;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(339, 301);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(107, 38);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(210, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Create A New Student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name";
            // 
            // txtCname
            // 
            this.txtCname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCname.Location = new System.Drawing.Point(267, 176);
            this.txtCname.Name = "txtCname";
            this.txtCname.Size = new System.Drawing.Size(179, 27);
            this.txtCname.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // txtCid
            // 
            this.txtCid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCid.Location = new System.Drawing.Point(268, 141);
            this.txtCid.Name = "txtCid";
            this.txtCid.Size = new System.Drawing.Size(179, 27);
            this.txtCid.TabIndex = 6;
            // 
            // tabDelete
            // 
            this.tabDelete.Controls.Add(this.btnDelete);
            this.tabDelete.Controls.Add(this.label6);
            this.tabDelete.Controls.Add(this.txtDId);
            this.tabDelete.Location = new System.Drawing.Point(4, 22);
            this.tabDelete.Name = "tabDelete";
            this.tabDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabDelete.Size = new System.Drawing.Size(624, 502);
            this.tabDelete.TabIndex = 1;
            this.tabDelete.Text = "Delete";
            this.tabDelete.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(278, 134);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 38);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(127, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "ID";
            // 
            // txtDId
            // 
            this.txtDId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDId.Location = new System.Drawing.Point(206, 84);
            this.txtDId.Name = "txtDId";
            this.txtDId.Size = new System.Drawing.Size(179, 27);
            this.txtDId.TabIndex = 8;
            // 
            // tabUpdate
            // 
            this.tabUpdate.Controls.Add(this.btnLoad);
            this.tabUpdate.Controls.Add(this.label7);
            this.tabUpdate.Controls.Add(this.txtUDepart);
            this.tabUpdate.Controls.Add(this.label8);
            this.tabUpdate.Controls.Add(this.txtUSemis);
            this.tabUpdate.Controls.Add(this.btnUpdate);
            this.tabUpdate.Controls.Add(this.label9);
            this.tabUpdate.Controls.Add(this.label10);
            this.tabUpdate.Controls.Add(this.txtUName);
            this.tabUpdate.Controls.Add(this.label11);
            this.tabUpdate.Controls.Add(this.txtUId);
            this.tabUpdate.Location = new System.Drawing.Point(4, 22);
            this.tabUpdate.Name = "tabUpdate";
            this.tabUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpdate.Size = new System.Drawing.Size(624, 502);
            this.tabUpdate.TabIndex = 3;
            this.tabUpdate.Text = "Update";
            this.tabUpdate.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(398, 148);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(69, 29);
            this.btnLoad.TabIndex = 26;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(158, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 22);
            this.label7.TabIndex = 25;
            this.label7.Text = "Department";
            // 
            // txtUDepart
            // 
            this.txtUDepart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUDepart.Location = new System.Drawing.Point(287, 301);
            this.txtUDepart.Name = "txtUDepart";
            this.txtUDepart.Size = new System.Drawing.Size(179, 27);
            this.txtUDepart.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(158, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 22);
            this.label8.TabIndex = 23;
            this.label8.Text = "Semister";
            // 
            // txtUSemis
            // 
            this.txtUSemis.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUSemis.Location = new System.Drawing.Point(288, 266);
            this.txtUSemis.Name = "txtUSemis";
            this.txtUSemis.Size = new System.Drawing.Size(179, 27);
            this.txtUSemis.TabIndex = 22;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(359, 349);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(107, 38);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(224, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 22);
            this.label9.TabIndex = 20;
            this.label9.Text = "Update Student Info";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(158, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 22);
            this.label10.TabIndex = 19;
            this.label10.Text = "Name";
            // 
            // txtUName
            // 
            this.txtUName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUName.Location = new System.Drawing.Point(287, 224);
            this.txtUName.Name = "txtUName";
            this.txtUName.Size = new System.Drawing.Size(179, 27);
            this.txtUName.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(158, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 22);
            this.label11.TabIndex = 17;
            this.label11.Text = "ID";
            // 
            // txtUId
            // 
            this.txtUId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUId.Location = new System.Drawing.Point(288, 115);
            this.txtUId.Name = "txtUId";
            this.txtUId.Size = new System.Drawing.Size(179, 27);
            this.txtUId.TabIndex = 16;
            // 
            // tabReport
            // 
            this.tabReport.Controls.Add(this.dataGridView);
            this.tabReport.Controls.Add(this.btnGenarate);
            this.tabReport.Location = new System.Drawing.Point(4, 22);
            this.tabReport.Name = "tabReport";
            this.tabReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabReport.Size = new System.Drawing.Size(624, 502);
            this.tabReport.TabIndex = 4;
            this.tabReport.Text = "Report";
            this.tabReport.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView.Location = new System.Drawing.Point(8, 76);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(610, 418);
            this.dataGridView.TabIndex = 23;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column3.HeaderText = "Semister";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 72;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Department";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // btnGenarate
            // 
            this.btnGenarate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenarate.Location = new System.Drawing.Point(273, 18);
            this.btnGenarate.Name = "btnGenarate";
            this.btnGenarate.Size = new System.Drawing.Size(107, 38);
            this.btnGenarate.TabIndex = 22;
            this.btnGenarate.Text = "Genarate";
            this.btnGenarate.UseVisualStyleBackColor = true;
            this.btnGenarate.Click += new System.EventHandler(this.btnGenarate_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlAuthonication);
            this.tabPage1.Controls.Add(this.btnLogout);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(624, 502);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Usser Management";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlAuthonication
            // 
            this.pnlAuthonication.Controls.Add(this.lblUsername);
            this.pnlAuthonication.Controls.Add(this.btnUpdateProfile);
            this.pnlAuthonication.Controls.Add(this.label12);
            this.pnlAuthonication.Controls.Add(this.txtUMPassword);
            this.pnlAuthonication.Controls.Add(this.label13);
            this.pnlAuthonication.Location = new System.Drawing.Point(79, 158);
            this.pnlAuthonication.Name = "pnlAuthonication";
            this.pnlAuthonication.Size = new System.Drawing.Size(403, 148);
            this.pnlAuthonication.TabIndex = 24;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(178, 15);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(100, 22);
            this.lblUsername.TabIndex = 25;
            this.lblUsername.Text = "Username";
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProfile.Location = new System.Drawing.Point(216, 96);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(182, 38);
            this.btnUpdateProfile.TabIndex = 10;
            this.btnUpdateProfile.Text = "Update Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = true;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(76, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 22);
            this.label12.TabIndex = 9;
            this.label12.Text = "Password";
            // 
            // txtUMPassword
            // 
            this.txtUMPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUMPassword.Location = new System.Drawing.Point(179, 50);
            this.txtUMPassword.Name = "txtUMPassword";
            this.txtUMPassword.PasswordChar = '*';
            this.txtUMPassword.Size = new System.Drawing.Size(218, 27);
            this.txtUMPassword.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(72, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 22);
            this.label13.TabIndex = 7;
            this.label13.Text = "Username";
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(509, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(107, 38);
            this.btnLogout.TabIndex = 23;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 528);
            this.Controls.Add(this.tabControl);
            this.Name = "Client";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.tabControl.ResumeLayout(false);
            this.tabCraete.ResumeLayout(false);
            this.tabCraete.PerformLayout();
            this.tabDelete.ResumeLayout(false);
            this.tabDelete.PerformLayout();
            this.tabUpdate.ResumeLayout(false);
            this.tabUpdate.PerformLayout();
            this.tabReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.pnlAuthonication.ResumeLayout(false);
            this.pnlAuthonication.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabCraete;
        private System.Windows.Forms.TabPage tabDelete;
        private System.Windows.Forms.TabPage tabUpdate;
        private System.Windows.Forms.TabPage tabReport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCdept;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCsem;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCid;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUDepart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUSemis;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUId;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnGenarate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnLoad;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlAuthonication;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUMPassword;
        private System.Windows.Forms.Label label13;
    }
}
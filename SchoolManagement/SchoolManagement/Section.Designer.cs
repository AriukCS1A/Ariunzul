namespace SchoolManagement
{
    partial class Section
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Section));
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            btnDisplay = new Button();
            btnNew = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnUpdate = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 128);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 53);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(322, 9);
            label1.Name = "label1";
            label1.Size = new Size(101, 32);
            label1.TabIndex = 0;
            label1.Text = "Section";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(btnDisplay);
            groupBox1.Controls.Add(btnNew);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 300);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Section Information";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(135, 118);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(243, 27);
            textBox3.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 128);
            label4.Name = "label4";
            label4.Size = new Size(56, 17);
            label4.TabIndex = 23;
            label4.Text = "Section";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(135, 70);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(243, 27);
            textBox2.TabIndex = 22;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(437, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(311, 231);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // btnDisplay
            // 
            btnDisplay.BackColor = Color.FromArgb(255, 128, 128);
            btnDisplay.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDisplay.ForeColor = SystemColors.ControlLight;
            btnDisplay.Location = new Point(268, 218);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(108, 40);
            btnDisplay.TabIndex = 20;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = false;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.FromArgb(255, 128, 128);
            btnNew.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.ForeColor = SystemColors.ControlLight;
            btnNew.Location = new Point(146, 218);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(108, 40);
            btnNew.TabIndex = 19;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 128, 128);
            btnAdd.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ControlLight;
            btnAdd.Location = new Point(146, 172);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(108, 40);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 128, 128);
            btnDelete.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.ControlLight;
            btnDelete.Location = new Point(17, 218);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(108, 40);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(255, 128, 128);
            btnSave.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ControlLight;
            btnSave.Location = new Point(17, 172);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(108, 40);
            btnSave.TabIndex = 16;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 128, 128);
            btnUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = SystemColors.ControlLight;
            btnUpdate.Location = new Point(268, 172);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(108, 40);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(135, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 28);
            textBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 80);
            label3.Name = "label3";
            label3.Size = new Size(100, 17);
            label3.TabIndex = 1;
            label3.Text = "Student Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 32);
            label2.Name = "label2";
            label2.Size = new Size(74, 17);
            label2.TabIndex = 0;
            label2.Text = "Section Id";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 370);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(770, 254);
            dataGridView1.TabIndex = 4;
            // 
            // Section
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 636);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Section";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Section";
            Load += Section_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private Button btnDisplay;
        private Button btnNew;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnSave;
        private Button btnUpdate;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private TextBox textBox3;
        private Label label4;
        private DataGridView dataGridView1;
    }
}
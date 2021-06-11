namespace kettlerepoquery
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox_source_step_attribute_code = new System.Windows.Forms.ComboBox();
            this.button_query = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_source_username = new System.Windows.Forms.TextBox();
            this.textBox_source_tablename = new System.Windows.Forms.TextBox();
            this.textBox_tran_name = new System.Windows.Forms.TextBox();
            this.textBox_target_username = new System.Windows.Forms.TextBox();
            this.comboBox_enabled = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_hostname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_job_name = new System.Windows.Forms.TextBox();
            this.comboBox_job_status = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_job_version = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_target_textBox_hostname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_target_tablename = new System.Windows.Forms.TextBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_job_deployed = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_find_ktr_job = new System.Windows.Forms.Button();
            this.dataSet_kettle_job_and_trans = new kettlerepoquery.DataSet_kettle_job_and_trans();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_kettle_job_and_trans)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_source_step_attribute_code
            // 
            this.comboBox_source_step_attribute_code.FormattingEnabled = true;
            this.comboBox_source_step_attribute_code.Items.AddRange(new object[] {
            "sql",
            ""});
            this.comboBox_source_step_attribute_code.Location = new System.Drawing.Point(241, 33);
            this.comboBox_source_step_attribute_code.Name = "comboBox_source_step_attribute_code";
            this.comboBox_source_step_attribute_code.Size = new System.Drawing.Size(121, 20);
            this.comboBox_source_step_attribute_code.TabIndex = 0;
            this.comboBox_source_step_attribute_code.Text = "sql";
            // 
            // button_query
            // 
            this.button_query.Location = new System.Drawing.Point(1215, 496);
            this.button_query.Name = "button_query";
            this.button_query.Size = new System.Drawing.Size(75, 23);
            this.button_query.TabIndex = 1;
            this.button_query.Text = "query";
            this.button_query.UseVisualStyleBackColor = true;
            this.button_query.Click += new System.EventHandler(this.button_query_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(29, 153);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1204, 337);
            this.dataGridView1.TabIndex = 2;
            // 
            // textBox_source_username
            // 
            this.textBox_source_username.Location = new System.Drawing.Point(6, 33);
            this.textBox_source_username.Name = "textBox_source_username";
            this.textBox_source_username.Size = new System.Drawing.Size(100, 21);
            this.textBox_source_username.TabIndex = 3;
            // 
            // textBox_source_tablename
            // 
            this.textBox_source_tablename.Location = new System.Drawing.Point(120, 33);
            this.textBox_source_tablename.Name = "textBox_source_tablename";
            this.textBox_source_tablename.Size = new System.Drawing.Size(100, 21);
            this.textBox_source_tablename.TabIndex = 4;
            // 
            // textBox_tran_name
            // 
            this.textBox_tran_name.Location = new System.Drawing.Point(3, 37);
            this.textBox_tran_name.Name = "textBox_tran_name";
            this.textBox_tran_name.Size = new System.Drawing.Size(100, 21);
            this.textBox_tran_name.TabIndex = 4;
            // 
            // textBox_target_username
            // 
            this.textBox_target_username.Location = new System.Drawing.Point(6, 28);
            this.textBox_target_username.Name = "textBox_target_username";
            this.textBox_target_username.Size = new System.Drawing.Size(100, 21);
            this.textBox_target_username.TabIndex = 4;
            // 
            // comboBox_enabled
            // 
            this.comboBox_enabled.FormattingEnabled = true;
            this.comboBox_enabled.Items.AddRange(new object[] {
            "\'1\'",
            "\'Y\'",
            "\'Y\',\'1\'",
            "",
            "\'0\'",
            "\'N\'",
            "\'0\',\'N\'"});
            this.comboBox_enabled.Location = new System.Drawing.Point(109, 37);
            this.comboBox_enabled.Name = "comboBox_enabled";
            this.comboBox_enabled.Size = new System.Drawing.Size(121, 20);
            this.comboBox_enabled.TabIndex = 0;
            this.comboBox_enabled.Text = "\'Y\',\'1\'";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_hostname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox_source_step_attribute_code);
            this.groupBox1.Controls.Add(this.textBox_source_tablename);
            this.groupBox1.Controls.Add(this.textBox_source_username);
            this.groupBox1.Location = new System.Drawing.Point(41, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 110);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "source";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 12;
            this.label10.Text = "hostname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "step_attribute_code";
            // 
            // textBox_hostname
            // 
            this.textBox_hostname.Location = new System.Drawing.Point(5, 71);
            this.textBox_hostname.Name = "textBox_hostname";
            this.textBox_hostname.Size = new System.Drawing.Size(100, 21);
            this.textBox_hostname.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "table name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "username";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_find_ktr_job);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textBox_job_name);
            this.groupBox2.Controls.Add(this.comboBox_job_status);
            this.groupBox2.Controls.Add(this.textBox_tran_name);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.comboBox_enabled);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox_job_version);
            this.groupBox2.Location = new System.Drawing.Point(431, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 110);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Job and trans";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(122, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 15;
            this.label11.Text = "job stauts";
            // 
            // textBox_job_name
            // 
            this.textBox_job_name.Location = new System.Drawing.Point(236, 37);
            this.textBox_job_name.Name = "textBox_job_name";
            this.textBox_job_name.Size = new System.Drawing.Size(116, 21);
            this.textBox_job_name.TabIndex = 1;
            // 
            // comboBox_job_status
            // 
            this.comboBox_job_status.FormattingEnabled = true;
            this.comboBox_job_status.Items.AddRange(new object[] {
            "is not null",
            "is null",
            "",
            ""});
            this.comboBox_job_status.Location = new System.Drawing.Point(109, 74);
            this.comboBox_job_status.Name = "comboBox_job_status";
            this.comboBox_job_status.Size = new System.Drawing.Size(121, 20);
            this.comboBox_job_status.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "enabled";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(234, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "job_name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 12);
            this.label9.TabIndex = 10;
            this.label9.Text = "job version";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "tran_name";
            // 
            // textBox_job_version
            // 
            this.textBox_job_version.Location = new System.Drawing.Point(3, 74);
            this.textBox_job_version.Name = "textBox_job_version";
            this.textBox_job_version.Size = new System.Drawing.Size(100, 21);
            this.textBox_job_version.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBox_target_username);
            this.groupBox3.Controls.Add(this.textBox_target_textBox_hostname);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBox_target_tablename);
            this.groupBox3.Location = new System.Drawing.Point(803, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 106);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "target";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 14;
            this.label12.Text = "hostname";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "tablename";
            // 
            // textBox_target_textBox_hostname
            // 
            this.textBox_target_textBox_hostname.Location = new System.Drawing.Point(6, 66);
            this.textBox_target_textBox_hostname.Name = "textBox_target_textBox_hostname";
            this.textBox_target_textBox_hostname.Size = new System.Drawing.Size(100, 21);
            this.textBox_target_textBox_hostname.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "username";
            // 
            // textBox_target_tablename
            // 
            this.textBox_target_tablename.Location = new System.Drawing.Point(115, 28);
            this.textBox_target_tablename.Name = "textBox_target_tablename";
            this.textBox_target_tablename.Size = new System.Drawing.Size(100, 21);
            this.textBox_target_tablename.TabIndex = 4;
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(1185, 50);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 23);
            this.button_clear.TabIndex = 8;
            this.button_clear.Text = "clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_job_deployed
            // 
            this.button_job_deployed.Location = new System.Drawing.Point(1076, 50);
            this.button_job_deployed.Name = "button_job_deployed";
            this.button_job_deployed.Size = new System.Drawing.Size(103, 23);
            this.button_job_deployed.TabIndex = 9;
            this.button_job_deployed.Text = "job deployed";
            this.button_job_deployed.UseVisualStyleBackColor = true;
            this.button_job_deployed.Click += new System.EventHandler(this.button_job_deployed_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1302, 25);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(54, 21);
            this.aboutToolStripMenuItem.Text = "about";
            // 
            // btn_find_ktr_job
            // 
            this.btn_find_ktr_job.Location = new System.Drawing.Point(236, 72);
            this.btn_find_ktr_job.Name = "btn_find_ktr_job";
            this.btn_find_ktr_job.Size = new System.Drawing.Size(123, 23);
            this.btn_find_ktr_job.TabIndex = 16;
            this.btn_find_ktr_job.Text = "find job in job";
            this.btn_find_ktr_job.UseVisualStyleBackColor = true;
            this.btn_find_ktr_job.Click += new System.EventHandler(this.btn_find_ktr_job_Click);
            // 
            // dataSet_kettle_job_and_trans
            // 
            this.dataSet_kettle_job_and_trans.DataSetName = "DataSet_kettle_job_and_trans";
            this.dataSet_kettle_job_and_trans.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AcceptButton = this.button_job_deployed;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 531);
            this.Controls.Add(this.button_job_deployed);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_query);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "kettle repo query";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_kettle_job_and_trans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_source_step_attribute_code;
        private System.Windows.Forms.Button button_query;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet_kettle_job_and_trans dataSet_kettle_job_and_trans;
        private System.Windows.Forms.TextBox textBox_source_username;
        private System.Windows.Forms.TextBox textBox_source_tablename;
        private System.Windows.Forms.TextBox textBox_tran_name;
        private System.Windows.Forms.TextBox textBox_target_username;
        private System.Windows.Forms.ComboBox comboBox_enabled;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_target_tablename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_job_deployed;
        private System.Windows.Forms.TextBox textBox_job_version;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_hostname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_job_status;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_target_textBox_hostname;
        private System.Windows.Forms.Button btn_find_ktr_job;
        private System.Windows.Forms.TextBox textBox_job_name;
    }
}


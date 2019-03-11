namespace WindowsFormsApp1
{
    partial class dashboard
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dashboard_brand = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dashboard_panel_dropdown = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.dashboard_btn_user = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.user_Analytics = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dashboard_dropdown_Timer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.dashboard_brand.SuspendLayout();
            this.dashboard_panel_dropdown.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_Analytics)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Teal;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.55556F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.44444F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(752, 448);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 105);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dashboard_brand, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dashboard_panel_dropdown, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(746, 86);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dashboard_brand
            // 
            this.dashboard_brand.BackColor = System.Drawing.Color.LightSlateGray;
            this.dashboard_brand.Controls.Add(this.label1);
            this.dashboard_brand.ForeColor = System.Drawing.Color.White;
            this.dashboard_brand.Location = new System.Drawing.Point(3, 3);
            this.dashboard_brand.Name = "dashboard_brand";
            this.dashboard_brand.Size = new System.Drawing.Size(200, 80);
            this.dashboard_brand.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Location = new System.Drawing.Point(33, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "BRAND";
            // 
            // dashboard_panel_dropdown
            // 
            this.dashboard_panel_dropdown.BackColor = System.Drawing.Color.Transparent;
            this.dashboard_panel_dropdown.Controls.Add(this.button2);
            this.dashboard_panel_dropdown.Controls.Add(this.dashboard_btn_user);
            this.dashboard_panel_dropdown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dashboard_panel_dropdown.Location = new System.Drawing.Point(376, 49);
            this.dashboard_panel_dropdown.MaximumSize = new System.Drawing.Size(137, 80);
            this.dashboard_panel_dropdown.MinimumSize = new System.Drawing.Size(137, 34);
            this.dashboard_panel_dropdown.Name = "dashboard_panel_dropdown";
            this.dashboard_panel_dropdown.Size = new System.Drawing.Size(137, 34);
            this.dashboard_panel_dropdown.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Brown;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(0, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // dashboard_btn_user
            // 
            this.dashboard_btn_user.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dashboard_btn_user.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.up_arrow;
            this.dashboard_btn_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dashboard_btn_user.Dock = System.Windows.Forms.DockStyle.Right;
            this.dashboard_btn_user.FlatAppearance.BorderSize = 0;
            this.dashboard_btn_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn_user.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn_user.ForeColor = System.Drawing.Color.White;
            this.dashboard_btn_user.Location = new System.Drawing.Point(0, 0);
            this.dashboard_btn_user.Name = "dashboard_btn_user";
            this.dashboard_btn_user.Size = new System.Drawing.Size(137, 34);
            this.dashboard_btn_user.TabIndex = 0;
            this.dashboard_btn_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard_btn_user.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.dashboard_btn_user.UseVisualStyleBackColor = false;
            this.dashboard_btn_user.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Controls.Add(this.panel7);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 108);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(50);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(746, 337);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Wheat;
            this.panel2.Controls.Add(this.user_Analytics);
            this.panel2.Location = new System.Drawing.Point(53, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            // 
            // user_Analytics
            // 
            this.user_Analytics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.user_Analytics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.user_Analytics.Image = global::WindowsFormsApp1.Properties.Resources.analytics;
            this.user_Analytics.Location = new System.Drawing.Point(0, 0);
            this.user_Analytics.Name = "user_Analytics";
            this.user_Analytics.Size = new System.Drawing.Size(200, 100);
            this.user_Analytics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.user_Analytics.TabIndex = 0;
            this.user_Analytics.TabStop = false;
            this.toolTip1.SetToolTip(this.user_Analytics, "User Analytics\r\n");
            this.user_Analytics.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Tomato;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(259, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.creative;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Turquoise;
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Location = new System.Drawing.Point(465, 53);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.worlwide;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Yellow;
            this.panel5.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.placeholder;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel5.ForeColor = System.Drawing.Color.Coral;
            this.panel5.Location = new System.Drawing.Point(53, 159);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 100);
            this.panel5.TabIndex = 3;
            this.toolTip1.SetToolTip(this.panel5, "locations");
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.YellowGreen;
            this.panel6.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.project;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel6.Location = new System.Drawing.Point(259, 159);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 100);
            this.panel6.TabIndex = 4;
            this.toolTip1.SetToolTip(this.panel6, "Settings");
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Aqua;
            this.panel7.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.logout;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel7.Location = new System.Drawing.Point(465, 159);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 100);
            this.panel7.TabIndex = 5;
            this.toolTip1.SetToolTip(this.panel7, "Logout");
            this.panel7.Click += new System.EventHandler(this.panel7_Click);
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.dashboard_logout);
            // 
            // dashboard_dropdown_Timer
            // 
            this.dashboard_dropdown_Timer.Interval = 15;
            this.dashboard_dropdown_Timer.Tick += new System.EventHandler(this.dashboard_dropdown_Timer_Tick);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 448);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account - Dashboard";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.dashboard_brand.ResumeLayout(false);
            this.dashboard_brand.PerformLayout();
            this.dashboard_panel_dropdown.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.user_Analytics)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox user_Analytics;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel dashboard_panel_dropdown;
        private System.Windows.Forms.Panel dashboard_brand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button dashboard_btn_user;
        private System.Windows.Forms.Timer dashboard_dropdown_Timer;
    }
}


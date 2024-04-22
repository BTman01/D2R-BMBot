﻿namespace app
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.richTextBoxErrorLogs = new System.Windows.Forms.RichTextBox();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.richTextBoxGamesLogs = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.richTextBoxDebugItems = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.richTextBoxDebugMobs = new System.Windows.Forms.RichTextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.richTextBoxDebugObjects = new System.Windows.Forms.RichTextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.richTextBoxDebugMapData = new System.Windows.Forms.RichTextBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.richTextBoxDebugMapCollision = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelGameName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.labelGames = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.labelGameTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.LabelChickenCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.LabelDeadCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonD2LOD = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(5, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "START";
            this.toolTip1.SetToolTip(this.button1, "Start or Stop the Bot");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(342, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(207, 376);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Descriptions";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 95;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Values";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.DetectUrls = false;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.Size = new System.Drawing.Size(317, 318);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.DetectUrls = false;
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Location = new System.Drawing.Point(3, 3);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox2.Size = new System.Drawing.Size(317, 318);
            this.richTextBox2.TabIndex = 7;
            this.richTextBox2.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Location = new System.Drawing.Point(5, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(331, 350);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(323, 324);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Logs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(323, 324);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Items Logs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.richTextBoxErrorLogs);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(323, 324);
            this.tabPage8.TabIndex = 2;
            this.tabPage8.Text = "Errors Logs";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // richTextBoxErrorLogs
            // 
            this.richTextBoxErrorLogs.DetectUrls = false;
            this.richTextBoxErrorLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxErrorLogs.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxErrorLogs.Name = "richTextBoxErrorLogs";
            this.richTextBoxErrorLogs.ReadOnly = true;
            this.richTextBoxErrorLogs.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBoxErrorLogs.Size = new System.Drawing.Size(323, 324);
            this.richTextBoxErrorLogs.TabIndex = 8;
            this.richTextBoxErrorLogs.Text = "";
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.richTextBoxGamesLogs);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(323, 324);
            this.tabPage9.TabIndex = 3;
            this.tabPage9.Text = "Games Logs";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // richTextBoxGamesLogs
            // 
            this.richTextBoxGamesLogs.DetectUrls = false;
            this.richTextBoxGamesLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxGamesLogs.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxGamesLogs.Name = "richTextBoxGamesLogs";
            this.richTextBoxGamesLogs.ReadOnly = true;
            this.richTextBoxGamesLogs.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBoxGamesLogs.Size = new System.Drawing.Size(323, 324);
            this.richTextBoxGamesLogs.TabIndex = 8;
            this.richTextBoxGamesLogs.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(249, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 25);
            this.button2.TabIndex = 18;
            this.button2.Text = "Debug Menu";
            this.toolTip1.SetToolTip(this.button2, "Open the Debug menu\'s");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Location = new System.Drawing.Point(5, 385);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(544, 228);
            this.tabControl2.TabIndex = 19;
            this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.richTextBoxDebugItems);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(536, 202);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Items";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // richTextBoxDebugItems
            // 
            this.richTextBoxDebugItems.DetectUrls = false;
            this.richTextBoxDebugItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxDebugItems.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxDebugItems.Name = "richTextBoxDebugItems";
            this.richTextBoxDebugItems.ReadOnly = true;
            this.richTextBoxDebugItems.Size = new System.Drawing.Size(530, 196);
            this.richTextBoxDebugItems.TabIndex = 20;
            this.richTextBoxDebugItems.Text = "";
            this.richTextBoxDebugItems.WordWrap = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.richTextBoxDebugMobs);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(536, 202);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Mobs/NPC";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // richTextBoxDebugMobs
            // 
            this.richTextBoxDebugMobs.DetectUrls = false;
            this.richTextBoxDebugMobs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxDebugMobs.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxDebugMobs.Name = "richTextBoxDebugMobs";
            this.richTextBoxDebugMobs.ReadOnly = true;
            this.richTextBoxDebugMobs.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBoxDebugMobs.Size = new System.Drawing.Size(530, 196);
            this.richTextBoxDebugMobs.TabIndex = 21;
            this.richTextBoxDebugMobs.Text = "";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.richTextBoxDebugObjects);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(536, 202);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "Objects";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // richTextBoxDebugObjects
            // 
            this.richTextBoxDebugObjects.DetectUrls = false;
            this.richTextBoxDebugObjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxDebugObjects.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxDebugObjects.Name = "richTextBoxDebugObjects";
            this.richTextBoxDebugObjects.ReadOnly = true;
            this.richTextBoxDebugObjects.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBoxDebugObjects.Size = new System.Drawing.Size(536, 202);
            this.richTextBoxDebugObjects.TabIndex = 22;
            this.richTextBoxDebugObjects.Text = "";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.richTextBoxDebugMapData);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(536, 202);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "Map Data";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // richTextBoxDebugMapData
            // 
            this.richTextBoxDebugMapData.DetectUrls = false;
            this.richTextBoxDebugMapData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxDebugMapData.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxDebugMapData.Name = "richTextBoxDebugMapData";
            this.richTextBoxDebugMapData.ReadOnly = true;
            this.richTextBoxDebugMapData.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBoxDebugMapData.Size = new System.Drawing.Size(536, 202);
            this.richTextBoxDebugMapData.TabIndex = 21;
            this.richTextBoxDebugMapData.Text = "";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.richTextBoxDebugMapCollision);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(536, 202);
            this.tabPage7.TabIndex = 4;
            this.tabPage7.Text = "Map Collisions";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // richTextBoxDebugMapCollision
            // 
            this.richTextBoxDebugMapCollision.DetectUrls = false;
            this.richTextBoxDebugMapCollision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxDebugMapCollision.Font = new System.Drawing.Font("Courier New", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxDebugMapCollision.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxDebugMapCollision.Name = "richTextBoxDebugMapCollision";
            this.richTextBoxDebugMapCollision.ReadOnly = true;
            this.richTextBoxDebugMapCollision.Size = new System.Drawing.Size(536, 202);
            this.richTextBoxDebugMapCollision.TabIndex = 21;
            this.richTextBoxDebugMapCollision.Text = "";
            this.richTextBoxDebugMapCollision.WordWrap = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelGameName,
            this.toolStripSeparator2,
            this.labelGames,
            this.toolStripSeparator3,
            this.labelGameTime,
            this.toolStripSeparator4,
            this.LabelChickenCount,
            this.toolStripSeparator5,
            this.LabelDeadCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 616);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(552, 23);
            this.statusStrip1.TabIndex = 101;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelGameName
            // 
            this.labelGameName.BackColor = System.Drawing.SystemColors.Control;
            this.labelGameName.Name = "labelGameName";
            this.labelGameName.Size = new System.Drawing.Size(70, 18);
            this.labelGameName.Text = "GameName";
            this.labelGameName.ToolTipText = "Game Name";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // labelGames
            // 
            this.labelGames.BackColor = System.Drawing.SystemColors.Control;
            this.labelGames.Name = "labelGames";
            this.labelGames.Size = new System.Drawing.Size(78, 18);
            this.labelGames.Text = "GameEntered";
            this.labelGames.ToolTipText = "Game Entered";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // labelGameTime
            // 
            this.labelGameTime.BackColor = System.Drawing.SystemColors.Control;
            this.labelGameTime.Name = "labelGameTime";
            this.labelGameTime.Size = new System.Drawing.Size(55, 18);
            this.labelGameTime.Text = "00:00.000";
            this.labelGameTime.ToolTipText = "Game Timer";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
            // 
            // LabelChickenCount
            // 
            this.LabelChickenCount.BackColor = System.Drawing.SystemColors.Control;
            this.LabelChickenCount.Name = "LabelChickenCount";
            this.LabelChickenCount.Size = new System.Drawing.Size(55, 18);
            this.LabelChickenCount.Text = "Chickens";
            this.LabelChickenCount.ToolTipText = "Chickens Count";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 23);
            // 
            // LabelDeadCount
            // 
            this.LabelDeadCount.BackColor = System.Drawing.SystemColors.Control;
            this.LabelDeadCount.Name = "LabelDeadCount";
            this.LabelDeadCount.Size = new System.Drawing.Size(34, 18);
            this.LabelDeadCount.Text = "Dead";
            this.LabelDeadCount.ToolTipText = "Deads Count";
            // 
            // buttonD2LOD
            // 
            this.buttonD2LOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonD2LOD.ForeColor = System.Drawing.Color.Blue;
            this.buttonD2LOD.Image = global::app.Properties.Resources.Error;
            this.buttonD2LOD.Location = new System.Drawing.Point(171, 3);
            this.buttonD2LOD.Name = "buttonD2LOD";
            this.buttonD2LOD.Size = new System.Drawing.Size(26, 25);
            this.buttonD2LOD.TabIndex = 105;
            this.toolTip1.SetToolTip(this.buttonD2LOD, "Diablo2 LOD - 1.13C Help Tool");
            this.buttonD2LOD.UseVisualStyleBackColor = true;
            this.buttonD2LOD.Visible = false;
            this.buttonD2LOD.Click += new System.EventHandler(this.buttonD2LOD_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Blue;
            this.button5.Image = global::app.Properties.Resources.Person;
            this.button5.Location = new System.Drawing.Point(107, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(26, 25);
            this.button5.TabIndex = 104;
            this.toolTip1.SetToolTip(this.button5, "Char Settings");
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Blue;
            this.button4.Image = global::app.Properties.Resources.Equipment;
            this.button4.Location = new System.Drawing.Point(139, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(26, 25);
            this.button4.TabIndex = 103;
            this.toolTip1.SetToolTip(this.button4, "Items + Cubing Settings");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Blue;
            this.button3.Image = global::app.Properties.Resources.Application;
            this.button3.Location = new System.Drawing.Point(75, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 25);
            this.button3.TabIndex = 102;
            this.toolTip1.SetToolTip(this.button3, "Bot Settings");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(552, 639);
            this.Controls.Add(this.buttonD2LOD);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "D2R - BMBot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabPage9.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        public System.Windows.Forms.RichTextBox richTextBoxDebugMobs;
        private System.Windows.Forms.TabPage tabPage5;
        public System.Windows.Forms.RichTextBox richTextBoxDebugMapData;
        public System.Windows.Forms.RichTextBox richTextBoxDebugMapCollision;
        public System.Windows.Forms.RichTextBox richTextBoxDebugObjects;
        public System.Windows.Forms.RichTextBox richTextBoxDebugItems;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel labelGameName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripStatusLabel labelGames;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripStatusLabel labelGameTime;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        public System.Windows.Forms.ToolStripStatusLabel LabelChickenCount;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        public System.Windows.Forms.ToolStripStatusLabel LabelDeadCount;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.RichTextBox richTextBoxErrorLogs;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.RichTextBox richTextBoxGamesLogs;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonD2LOD;
    }
}


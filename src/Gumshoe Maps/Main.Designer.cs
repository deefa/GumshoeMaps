﻿namespace Gumshoe_Maps
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelDgv = new System.Windows.Forms.Panel();
            this.dgvMaps = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mapColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evenColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCurrentMap = new System.Windows.Forms.Panel();
            this.labelDurationValue = new System.Windows.Forms.Label();
            this.labelDuration = new System.Windows.Forms.Label();
            this.labelMapValue = new System.Windows.Forms.Label();
            this.labelCurrentMap = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelStatusValue = new System.Windows.Forms.Label();
            this.panelDgvExtra = new System.Windows.Forms.Panel();
            this.dgvDrops = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDrops = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericZana = new System.Windows.Forms.NumericUpDown();
            this.labelZana = new System.Windows.Forms.Label();
            this.timerMap = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuDgvMaps = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelDgvRight = new System.Windows.Forms.Panel();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleBar = new Gumshoe_Maps.TitleBar();
            this.panelDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaps)).BeginInit();
            this.panelCurrentMap.SuspendLayout();
            this.panelDgvExtra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericZana)).BeginInit();
            this.contextMenuDgvMaps.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDgv
            // 
            this.panelDgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDgv.Controls.Add(this.dgvMaps);
            this.panelDgv.Location = new System.Drawing.Point(9, 113);
            this.panelDgv.Margin = new System.Windows.Forms.Padding(2);
            this.panelDgv.Name = "panelDgv";
            this.panelDgv.Size = new System.Drawing.Size(480, 260);
            this.panelDgv.TabIndex = 5;
            this.panelDgv.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDgv_Paint);
            // 
            // dgvMaps
            // 
            this.dgvMaps.AllowUserToAddRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvMaps.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvMaps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMaps.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.dgvMaps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMaps.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMaps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvMaps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.mapColumn,
            this.levelColumn,
            this.quantityColumn,
            this.qualityColumn,
            this.minusColumn,
            this.evenColumn,
            this.plusColumn});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMaps.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvMaps.EnableHeadersVisualStyles = false;
            this.dgvMaps.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.dgvMaps.Location = new System.Drawing.Point(1, 1);
            this.dgvMaps.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMaps.Name = "dgvMaps";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMaps.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvMaps.RowHeadersVisible = false;
            this.dgvMaps.RowTemplate.Height = 24;
            this.dgvMaps.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvMaps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaps.Size = new System.Drawing.Size(499, 258);
            this.dgvMaps.TabIndex = 5;
            this.dgvMaps.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMaps_CellMouseDown);
            this.dgvMaps.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaps_CellMouseEnter);
            this.dgvMaps.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaps_RowEnter);
            this.dgvMaps.SelectionChanged += new System.EventHandler(this.dgvMaps_SelectionChanged);
            this.dgvMaps.MouseEnter += new System.EventHandler(this.dgvMaps_MouseEnter);
            this.dgvMaps.MouseLeave += new System.EventHandler(this.dgvMaps_MouseLeave);
            // 
            // idColumn
            // 
            this.idColumn.DataPropertyName = "id";
            this.idColumn.HeaderText = "ID";
            this.idColumn.Name = "idColumn";
            this.idColumn.Visible = false;
            // 
            // mapColumn
            // 
            this.mapColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.mapColumn.DataPropertyName = "name";
            this.mapColumn.HeaderText = "";
            this.mapColumn.MinimumWidth = 225;
            this.mapColumn.Name = "mapColumn";
            this.mapColumn.Width = 250;
            // 
            // levelColumn
            // 
            this.levelColumn.DataPropertyName = "level";
            this.levelColumn.HeaderText = "Level";
            this.levelColumn.Name = "levelColumn";
            this.levelColumn.Width = 35;
            // 
            // quantityColumn
            // 
            this.quantityColumn.DataPropertyName = "quantity";
            this.quantityColumn.HeaderText = "Quantity";
            this.quantityColumn.Name = "quantityColumn";
            this.quantityColumn.Width = 50;
            // 
            // qualityColumn
            // 
            this.qualityColumn.DataPropertyName = "quality";
            this.qualityColumn.HeaderText = "Quality";
            this.qualityColumn.Name = "qualityColumn";
            this.qualityColumn.Width = 50;
            // 
            // minusColumn
            // 
            this.minusColumn.DataPropertyName = "-";
            this.minusColumn.HeaderText = "-";
            this.minusColumn.Name = "minusColumn";
            this.minusColumn.Width = 30;
            // 
            // evenColumn
            // 
            this.evenColumn.DataPropertyName = " ";
            this.evenColumn.HeaderText = " ";
            this.evenColumn.Name = "evenColumn";
            this.evenColumn.Width = 30;
            // 
            // plusColumn
            // 
            this.plusColumn.DataPropertyName = "+";
            this.plusColumn.HeaderText = "+";
            this.plusColumn.Name = "plusColumn";
            this.plusColumn.Width = 30;
            // 
            // panelCurrentMap
            // 
            this.panelCurrentMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCurrentMap.Controls.Add(this.labelDurationValue);
            this.panelCurrentMap.Controls.Add(this.labelDuration);
            this.panelCurrentMap.Controls.Add(this.labelMapValue);
            this.panelCurrentMap.Controls.Add(this.labelCurrentMap);
            this.panelCurrentMap.Location = new System.Drawing.Point(9, 59);
            this.panelCurrentMap.Name = "panelCurrentMap";
            this.panelCurrentMap.Size = new System.Drawing.Size(188, 49);
            this.panelCurrentMap.TabIndex = 4;
            this.panelCurrentMap.Visible = false;
            // 
            // labelDurationValue
            // 
            this.labelDurationValue.AutoSize = true;
            this.labelDurationValue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDurationValue.Location = new System.Drawing.Point(75, 24);
            this.labelDurationValue.Name = "labelDurationValue";
            this.labelDurationValue.Size = new System.Drawing.Size(49, 13);
            this.labelDurationValue.TabIndex = 4;
            this.labelDurationValue.Text = "00:00:00";
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDuration.Location = new System.Drawing.Point(24, 24);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(50, 13);
            this.labelDuration.TabIndex = 2;
            this.labelDuration.Text = "Duration:";
            // 
            // labelMapValue
            // 
            this.labelMapValue.AutoSize = true;
            this.labelMapValue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelMapValue.Location = new System.Drawing.Point(75, 6);
            this.labelMapValue.Name = "labelMapValue";
            this.labelMapValue.Size = new System.Drawing.Size(0, 13);
            this.labelMapValue.TabIndex = 1;
            // 
            // labelCurrentMap
            // 
            this.labelCurrentMap.AutoSize = true;
            this.labelCurrentMap.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCurrentMap.Location = new System.Drawing.Point(6, 5);
            this.labelCurrentMap.Name = "labelCurrentMap";
            this.labelCurrentMap.Size = new System.Drawing.Size(68, 13);
            this.labelCurrentMap.TabIndex = 0;
            this.labelCurrentMap.Text = "Current Map:";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Enabled = false;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelId.Location = new System.Drawing.Point(477, 95);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(0, 13);
            this.labelId.TabIndex = 3;
            this.labelId.Visible = false;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelStatus.Location = new System.Drawing.Point(17, 35);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(40, 13);
            this.labelStatus.TabIndex = 2;
            this.labelStatus.Text = "Status:";
            // 
            // labelStatusValue
            // 
            this.labelStatusValue.AutoSize = true;
            this.labelStatusValue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelStatusValue.Location = new System.Drawing.Point(54, 35);
            this.labelStatusValue.Name = "labelStatusValue";
            this.labelStatusValue.Size = new System.Drawing.Size(188, 13);
            this.labelStatusValue.TabIndex = 5;
            this.labelStatusValue.Text = "Awaiting a map to be selected to run...";
            // 
            // panelDgvExtra
            // 
            this.panelDgvExtra.Controls.Add(this.dgvDrops);
            this.panelDgvExtra.Location = new System.Drawing.Point(9, 377);
            this.panelDgvExtra.Name = "panelDgvExtra";
            this.panelDgvExtra.Size = new System.Drawing.Size(479, 79);
            this.panelDgvExtra.TabIndex = 6;
            this.panelDgvExtra.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDgvExtra_Paint);
            // 
            // dgvDrops
            // 
            this.dgvDrops.AllowUserToAddRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDrops.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvDrops.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDrops.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.dgvDrops.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDrops.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDrops.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvDrops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrops.ColumnHeadersVisible = false;
            this.dgvDrops.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.columnDrops});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDrops.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvDrops.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.dgvDrops.Location = new System.Drawing.Point(1, 1);
            this.dgvDrops.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDrops.Name = "dgvDrops";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDrops.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvDrops.RowHeadersVisible = false;
            this.dgvDrops.RowTemplate.Height = 24;
            this.dgvDrops.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvDrops.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDrops.Size = new System.Drawing.Size(477, 77);
            this.dgvDrops.TabIndex = 6;
            this.dgvDrops.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDrops_CellMouseEnter);
            this.dgvDrops.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDrops_RowEnter);
            this.dgvDrops.MouseEnter += new System.EventHandler(this.dgvDrops_MouseEnter);
            this.dgvDrops.MouseLeave += new System.EventHandler(this.dgvDrops_MouseLeave);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "title";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 75;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 75;
            // 
            // columnDrops
            // 
            this.columnDrops.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnDrops.DataPropertyName = "drops";
            this.columnDrops.FillWeight = 200F;
            this.columnDrops.HeaderText = "Drops";
            this.columnDrops.MinimumWidth = 401;
            this.columnDrops.Name = "columnDrops";
            // 
            // numericZana
            // 
            this.numericZana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.numericZana.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericZana.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.numericZana.Location = new System.Drawing.Point(446, 36);
            this.numericZana.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericZana.Name = "numericZana";
            this.numericZana.Size = new System.Drawing.Size(31, 16);
            this.numericZana.TabIndex = 23;
            this.numericZana.ValueChanged += new System.EventHandler(this.numericZana_ValueChanged);
            // 
            // labelZana
            // 
            this.labelZana.AutoSize = true;
            this.labelZana.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelZana.Location = new System.Drawing.Point(368, 36);
            this.labelZana.Name = "labelZana";
            this.labelZana.Size = new System.Drawing.Size(75, 13);
            this.labelZana.TabIndex = 22;
            this.labelZana.Text = "Zana quantity:";
            // 
            // timerMap
            // 
            this.timerMap.Interval = 1000;
            this.timerMap.Tick += new System.EventHandler(this.timerMap_Tick);
            // 
            // toolTip
            // 
            this.toolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            // 
            // contextMenuDgvMaps
            // 
            this.contextMenuDgvMaps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.contextMenuDgvMaps.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailsToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuDgvMaps.Name = "contextMenuDgvMaps";
            this.contextMenuDgvMaps.Size = new System.Drawing.Size(153, 70);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // panelDgvRight
            // 
            this.panelDgvRight.Location = new System.Drawing.Point(485, 113);
            this.panelDgvRight.Name = "panelDgvRight";
            this.panelDgvRight.Size = new System.Drawing.Size(10, 260);
            this.panelDgvRight.TabIndex = 24;
            this.panelDgvRight.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDgvRight_Paint);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.detailsToolStripMenuItem.Text = "Details";
            // 
            // titleBar
            // 
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Margin = new System.Windows.Forms.Padding(4);
            this.titleBar.Name = "titleBar";
            this.titleBar.SettingsVisible = true;
            this.titleBar.Size = new System.Drawing.Size(496, 22);
            this.titleBar.TabIndex = 2;
            this.titleBar.Title = "Gumshoe Maps v0.1";
            this.titleBar.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(496, 471);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.panelDgvRight);
            this.Controls.Add(this.numericZana);
            this.Controls.Add(this.labelZana);
            this.Controls.Add(this.panelDgv);
            this.Controls.Add(this.panelDgvExtra);
            this.Controls.Add(this.labelStatusValue);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.panelCurrentMap);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Gumshoe Maps v0.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.panelDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaps)).EndInit();
            this.panelCurrentMap.ResumeLayout(false);
            this.panelCurrentMap.PerformLayout();
            this.panelDgvExtra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrops)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericZana)).EndInit();
            this.contextMenuDgvMaps.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDgv;
        private System.Windows.Forms.Panel panelCurrentMap;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Label labelMapValue;
        private System.Windows.Forms.Label labelCurrentMap;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelStatusValue;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelDurationValue;
        private System.Windows.Forms.Panel panelDgvExtra;
        private System.Windows.Forms.DataGridView dgvDrops;
        internal TitleBar titleBar;
        private System.Windows.Forms.Label labelZana;
        private System.Windows.Forms.Timer timerMap;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evenColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plusColumn;
        public System.Windows.Forms.NumericUpDown numericZana;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ContextMenuStrip contextMenuDgvMaps;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Panel panelDgvRight;
        internal System.Windows.Forms.DataGridView dgvMaps;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDrops;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
    }
}


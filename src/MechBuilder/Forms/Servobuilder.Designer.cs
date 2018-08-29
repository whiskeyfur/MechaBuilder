using System;
using System.Collections;
using System.Collections.Generic;

namespace MZCore.Forms
{
    partial class Servobuilder
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
            this.ServoEditTable = new System.Windows.Forms.TableLayoutPanel();
            this.ServoCostLabel = new System.Windows.Forms.Label();
            this.ServoSpacesLabel = new System.Windows.Forms.Label();
            this.ServoClassLabel = new System.Windows.Forms.Label();
            this.ServoKillsLabel = new System.Windows.Forms.Label();
            this.ServoWeightLabel = new System.Windows.Forms.Label();
            this.ServoSpacesValue = new System.Windows.Forms.TextBox();
            this.ServoKillsValue = new System.Windows.Forms.TextBox();
            this.ServoWeightValue = new System.Windows.Forms.TextBox();
            this.EditServoLabel = new System.Windows.Forms.Label();
            this.ServoTypeValue = new System.Windows.Forms.ComboBox();
            this.ServoTypeLabel = new System.Windows.Forms.Label();
            this.ServoClassValue = new System.Windows.Forms.ComboBox();
            this.ServoExtraSpacesLabel = new System.Windows.Forms.Label();
            this.ServoExtraSpacesValue = new System.Windows.Forms.NumericUpDown();
            this.ServoExtraKillsLabel = new System.Windows.Forms.Label();
            this.ServoExtraKillsValue = new System.Windows.Forms.NumericUpDown();
            this.ServoCostValue = new System.Windows.Forms.TextBox();
            this.ServoArmorLabel = new System.Windows.Forms.Label();
            this.ArmorEditTable = new System.Windows.Forms.TableLayoutPanel();
            this.ArmorClassLabel = new System.Windows.Forms.Label();
            this.ArmorTypeLabel = new System.Windows.Forms.Label();
            this.ArmorClassValue = new System.Windows.Forms.ComboBox();
            this.SPValue = new System.Windows.Forms.TextBox();
            this.SPLabel = new System.Windows.Forms.Label();
            this.RAMLabel = new System.Windows.Forms.Label();
            this.ArmorTypeValue = new System.Windows.Forms.ComboBox();
            this.RAMValue = new System.Windows.Forms.ComboBox();
            this.SPPenaltyLabel = new System.Windows.Forms.Label();
            this.RAMPenaltyValue = new System.Windows.Forms.TextBox();
            this.DCLabel = new System.Windows.Forms.Label();
            this.DCValue = new System.Windows.Forms.TextBox();
            this.ArmorWeightLabel = new System.Windows.Forms.Label();
            this.ArmorCostLabel = new System.Windows.Forms.Label();
            this.ArmorWeightValue = new System.Windows.Forms.TextBox();
            this.ArmorCostValue = new System.Windows.Forms.TextBox();
            this.CancelChangesButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.TrueSPValue = new System.Windows.Forms.TextBox();
            this.TrueSPLabel = new System.Windows.Forms.Label();
            this.ServoEditTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServoExtraSpacesValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServoExtraKillsValue)).BeginInit();
            this.ArmorEditTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServoEditTable
            // 
            this.ServoEditTable.ColumnCount = 14;
            this.ServoEditTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.ServoEditTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.ServoEditTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.ServoEditTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.ServoEditTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.ServoEditTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ServoEditTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.ServoEditTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ServoEditTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.ServoEditTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.ServoEditTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.ServoEditTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.ServoEditTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.ServoEditTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.ServoEditTable.Controls.Add(this.ServoCostLabel, 12, 1);
            this.ServoEditTable.Controls.Add(this.ServoSpacesLabel, 4, 1);
            this.ServoEditTable.Controls.Add(this.ServoClassLabel, 2, 1);
            this.ServoEditTable.Controls.Add(this.ServoKillsLabel, 6, 1);
            this.ServoEditTable.Controls.Add(this.ServoWeightLabel, 10, 1);
            this.ServoEditTable.Controls.Add(this.ServoSpacesValue, 5, 1);
            this.ServoEditTable.Controls.Add(this.ServoKillsValue, 7, 1);
            this.ServoEditTable.Controls.Add(this.ServoWeightValue, 11, 1);
            this.ServoEditTable.Controls.Add(this.EditServoLabel, 0, 0);
            this.ServoEditTable.Controls.Add(this.ServoTypeValue, 1, 1);
            this.ServoEditTable.Controls.Add(this.ServoTypeLabel, 0, 1);
            this.ServoEditTable.Controls.Add(this.ServoClassValue, 3, 1);
            this.ServoEditTable.Controls.Add(this.ServoExtraSpacesLabel, 8, 0);
            this.ServoEditTable.Controls.Add(this.ServoExtraSpacesValue, 8, 1);
            this.ServoEditTable.Controls.Add(this.ServoExtraKillsLabel, 9, 0);
            this.ServoEditTable.Controls.Add(this.ServoExtraKillsValue, 9, 1);
            this.ServoEditTable.Controls.Add(this.ServoCostValue, 13, 1);
            this.ServoEditTable.Controls.Add(this.ServoArmorLabel, 0, 2);
            this.ServoEditTable.Location = new System.Drawing.Point(12, 12);
            this.ServoEditTable.Name = "ServoEditTable";
            this.ServoEditTable.RowCount = 4;
            this.ServoEditTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.ServoEditTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ServoEditTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.ServoEditTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ServoEditTable.Size = new System.Drawing.Size(831, 107);
            this.ServoEditTable.TabIndex = 4;
            // 
            // ServoCostLabel
            // 
            this.ServoCostLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ServoCostLabel.AutoSize = true;
            this.ServoCostLabel.Location = new System.Drawing.Point(719, 45);
            this.ServoCostLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.ServoCostLabel.Name = "ServoCostLabel";
            this.ServoCostLabel.Size = new System.Drawing.Size(59, 13);
            this.ServoCostLabel.TabIndex = 2;
            this.ServoCostLabel.Text = "Cost (CPs):";
            this.ServoCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ServoSpacesLabel
            // 
            this.ServoSpacesLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ServoSpacesLabel.AutoSize = true;
            this.ServoSpacesLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ServoSpacesLabel.Location = new System.Drawing.Point(318, 45);
            this.ServoSpacesLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.ServoSpacesLabel.Name = "ServoSpacesLabel";
            this.ServoSpacesLabel.Size = new System.Drawing.Size(46, 13);
            this.ServoSpacesLabel.TabIndex = 2;
            this.ServoSpacesLabel.Text = "Spaces:";
            this.ServoSpacesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ServoClassLabel
            // 
            this.ServoClassLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ServoClassLabel.AutoSize = true;
            this.ServoClassLabel.Location = new System.Drawing.Point(159, 45);
            this.ServoClassLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.ServoClassLabel.Name = "ServoClassLabel";
            this.ServoClassLabel.Size = new System.Drawing.Size(35, 13);
            this.ServoClassLabel.TabIndex = 4;
            this.ServoClassLabel.Text = "Class:";
            this.ServoClassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ServoKillsLabel
            // 
            this.ServoKillsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ServoKillsLabel.AutoSize = true;
            this.ServoKillsLabel.Location = new System.Drawing.Point(400, 45);
            this.ServoKillsLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.ServoKillsLabel.Name = "ServoKillsLabel";
            this.ServoKillsLabel.Size = new System.Drawing.Size(28, 13);
            this.ServoKillsLabel.TabIndex = 5;
            this.ServoKillsLabel.Text = "Kills:";
            this.ServoKillsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ServoWeightLabel
            // 
            this.ServoWeightLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ServoWeightLabel.AutoSize = true;
            this.ServoWeightLabel.Location = new System.Drawing.Point(624, 45);
            this.ServoWeightLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.ServoWeightLabel.Name = "ServoWeightLabel";
            this.ServoWeightLabel.Size = new System.Drawing.Size(44, 13);
            this.ServoWeightLabel.TabIndex = 9;
            this.ServoWeightLabel.Text = "Weight:";
            this.ServoWeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ServoSpacesValue
            // 
            this.ServoSpacesValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ServoSpacesValue.Location = new System.Drawing.Point(368, 42);
            this.ServoSpacesValue.Name = "ServoSpacesValue";
            this.ServoSpacesValue.ReadOnly = true;
            this.ServoSpacesValue.Size = new System.Drawing.Size(24, 20);
            this.ServoSpacesValue.TabIndex = 10;
            this.ServoSpacesValue.Text = "2";
            // 
            // ServoKillsValue
            // 
            this.ServoKillsValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ServoKillsValue.Location = new System.Drawing.Point(433, 42);
            this.ServoKillsValue.Name = "ServoKillsValue";
            this.ServoKillsValue.ReadOnly = true;
            this.ServoKillsValue.Size = new System.Drawing.Size(24, 20);
            this.ServoKillsValue.TabIndex = 11;
            this.ServoKillsValue.Text = "2";
            // 
            // ServoWeightValue
            // 
            this.ServoWeightValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ServoWeightValue.Location = new System.Drawing.Point(673, 42);
            this.ServoWeightValue.Name = "ServoWeightValue";
            this.ServoWeightValue.ReadOnly = true;
            this.ServoWeightValue.Size = new System.Drawing.Size(39, 20);
            this.ServoWeightValue.TabIndex = 12;
            // 
            // EditServoLabel
            // 
            this.EditServoLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EditServoLabel.AutoSize = true;
            this.EditServoLabel.Location = new System.Drawing.Point(3, 12);
            this.EditServoLabel.Name = "EditServoLabel";
            this.EditServoLabel.Size = new System.Drawing.Size(56, 13);
            this.EditServoLabel.TabIndex = 0;
            this.EditServoLabel.Text = "Edit Servo";
            // 
            // ServoTypeValue
            // 
            this.ServoTypeValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ServoTypeValue.AutoCompleteCustomSource.AddRange(new string[] {
            "Head",
            "Torso",
            "Wing",
            "Arm",
            "Leg",
            "Tail",
            "Pod"});
            this.ServoTypeValue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.ServoTypeValue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ServoTypeValue.FormattingEnabled = true;
            this.ServoTypeValue.Items.AddRange(new object[] {
            "Head",
            "Torso",
            "Wing",
            "Arm",
            "Leg",
            "Tail",
            "Pod"});
            this.ServoTypeValue.Location = new System.Drawing.Point(79, 41);
            this.ServoTypeValue.Name = "ServoTypeValue";
            this.ServoTypeValue.Size = new System.Drawing.Size(72, 21);
            this.ServoTypeValue.TabIndex = 15;
            // 
            // ServoTypeLabel
            // 
            this.ServoTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ServoTypeLabel.AutoSize = true;
            this.ServoTypeLabel.Location = new System.Drawing.Point(3, 45);
            this.ServoTypeLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.ServoTypeLabel.Name = "ServoTypeLabel";
            this.ServoTypeLabel.Size = new System.Drawing.Size(65, 13);
            this.ServoTypeLabel.TabIndex = 16;
            this.ServoTypeLabel.Text = "Servo Type:";
            this.ServoTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ServoClassValue
            // 
            this.ServoClassValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ServoClassValue.AutoCompleteCustomSource.AddRange(new string[] {
            "None",
            "Superlight",
            "Lightweight",
            "Striker",
            "Medium_Striker",
            "Heavy_Striker",
            "Mediumweight",
            "Light_Heavy",
            "Medium_Heavy",
            "Armored_Heavy",
            "Super_Heavy",
            "Mega_Heavy"});
            this.ServoClassValue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.ServoClassValue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ServoClassValue.FormattingEnabled = true;
            this.ServoClassValue.Items.AddRange(new object[] {
            "None",
            "Superlight",
            "Lightweight",
            "Striker",
            "Medium_Striker",
            "Heavy_Striker",
            "Mediumweight",
            "Light_Heavy",
            "Medium_Heavy",
            "Armored_Heavy",
            "Super_Heavy",
            "Mega_Heavy"});
            this.ServoClassValue.Location = new System.Drawing.Point(198, 41);
            this.ServoClassValue.Name = "ServoClassValue";
            this.ServoClassValue.Size = new System.Drawing.Size(114, 21);
            this.ServoClassValue.TabIndex = 1;
            // 
            // ServoExtraSpacesLabel
            // 
            this.ServoExtraSpacesLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ServoExtraSpacesLabel.AutoSize = true;
            this.ServoExtraSpacesLabel.Location = new System.Drawing.Point(463, 5);
            this.ServoExtraSpacesLabel.Name = "ServoExtraSpacesLabel";
            this.ServoExtraSpacesLabel.Size = new System.Drawing.Size(74, 26);
            this.ServoExtraSpacesLabel.TabIndex = 7;
            this.ServoExtraSpacesLabel.Text = "Trade Kills for Space:";
            this.ServoExtraSpacesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ServoExtraSpacesValue
            // 
            this.ServoExtraSpacesValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ServoExtraSpacesValue.Location = new System.Drawing.Point(463, 42);
            this.ServoExtraSpacesValue.Maximum = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.ServoExtraSpacesValue.Name = "ServoExtraSpacesValue";
            this.ServoExtraSpacesValue.Size = new System.Drawing.Size(73, 20);
            this.ServoExtraSpacesValue.TabIndex = 8;
            // 
            // ServoExtraKillsLabel
            // 
            this.ServoExtraKillsLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ServoExtraKillsLabel.AutoSize = true;
            this.ServoExtraKillsLabel.Location = new System.Drawing.Point(543, 5);
            this.ServoExtraKillsLabel.Name = "ServoExtraKillsLabel";
            this.ServoExtraKillsLabel.Size = new System.Drawing.Size(74, 26);
            this.ServoExtraKillsLabel.TabIndex = 17;
            this.ServoExtraKillsLabel.Text = "Trade Spaces for Kills:";
            this.ServoExtraKillsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ServoExtraKillsValue
            // 
            this.ServoExtraKillsValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ServoExtraKillsValue.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ServoExtraKillsValue.Location = new System.Drawing.Point(543, 42);
            this.ServoExtraKillsValue.Maximum = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.ServoExtraKillsValue.Name = "ServoExtraKillsValue";
            this.ServoExtraKillsValue.Size = new System.Drawing.Size(74, 20);
            this.ServoExtraKillsValue.TabIndex = 18;
            // 
            // ServoCostValue
            // 
            this.ServoCostValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ServoCostValue.Location = new System.Drawing.Point(783, 42);
            this.ServoCostValue.Name = "ServoCostValue";
            this.ServoCostValue.ReadOnly = true;
            this.ServoCostValue.Size = new System.Drawing.Size(45, 20);
            this.ServoCostValue.TabIndex = 14;
            // 
            // ServoArmorLabel
            // 
            this.ServoArmorLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ServoArmorLabel.AutoSize = true;
            this.ServoEditTable.SetColumnSpan(this.ServoArmorLabel, 2);
            this.ServoArmorLabel.Location = new System.Drawing.Point(3, 79);
            this.ServoArmorLabel.Name = "ServoArmorLabel";
            this.ServoArmorLabel.Size = new System.Drawing.Size(86, 13);
            this.ServoArmorLabel.TabIndex = 19;
            this.ServoArmorLabel.Text = "Edit Servo Armor";
            // 
            // ArmorEditTable
            // 
            this.ArmorEditTable.ColumnCount = 15;
            this.ArmorEditTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.ArmorEditTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.ArmorEditTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.ArmorEditTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.ArmorEditTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.ArmorEditTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.ArmorEditTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ArmorEditTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ArmorEditTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.ArmorEditTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.ArmorEditTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.ArmorEditTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.ArmorEditTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.ArmorEditTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.ArmorEditTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.ArmorEditTable.Controls.Add(this.ArmorClassLabel, 0, 0);
            this.ArmorEditTable.Controls.Add(this.ArmorTypeLabel, 2, 0);
            this.ArmorEditTable.Controls.Add(this.ArmorClassValue, 1, 0);
            this.ArmorEditTable.Controls.Add(this.SPValue, 6, 0);
            this.ArmorEditTable.Controls.Add(this.SPLabel, 5, 0);
            this.ArmorEditTable.Controls.Add(this.RAMLabel, 1, 1);
            this.ArmorEditTable.Controls.Add(this.ArmorTypeValue, 3, 0);
            this.ArmorEditTable.Controls.Add(this.RAMValue, 3, 1);
            this.ArmorEditTable.Controls.Add(this.SPPenaltyLabel, 4, 1);
            this.ArmorEditTable.Controls.Add(this.RAMPenaltyValue, 6, 1);
            this.ArmorEditTable.Controls.Add(this.DCLabel, 7, 0);
            this.ArmorEditTable.Controls.Add(this.DCValue, 9, 0);
            this.ArmorEditTable.Controls.Add(this.ArmorWeightLabel, 11, 0);
            this.ArmorEditTable.Controls.Add(this.ArmorCostLabel, 13, 0);
            this.ArmorEditTable.Controls.Add(this.ArmorWeightValue, 12, 0);
            this.ArmorEditTable.Controls.Add(this.ArmorCostValue, 14, 0);
            this.ArmorEditTable.Controls.Add(this.CancelChangesButton, 13, 2);
            this.ArmorEditTable.Controls.Add(this.SaveButton, 10, 2);
            this.ArmorEditTable.Controls.Add(this.TrueSPValue, 9, 1);
            this.ArmorEditTable.Controls.Add(this.TrueSPLabel, 8, 1);
            this.ArmorEditTable.Location = new System.Drawing.Point(12, 113);
            this.ArmorEditTable.Name = "ArmorEditTable";
            this.ArmorEditTable.RowCount = 3;
            this.ArmorEditTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ArmorEditTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ArmorEditTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.ArmorEditTable.Size = new System.Drawing.Size(831, 89);
            this.ArmorEditTable.TabIndex = 5;
            // 
            // ArmorClassLabel
            // 
            this.ArmorClassLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ArmorClassLabel.AutoSize = true;
            this.ArmorClassLabel.Location = new System.Drawing.Point(3, 8);
            this.ArmorClassLabel.Name = "ArmorClassLabel";
            this.ArmorClassLabel.Size = new System.Drawing.Size(65, 13);
            this.ArmorClassLabel.TabIndex = 0;
            this.ArmorClassLabel.Text = "Armor Class:";
            // 
            // ArmorTypeLabel
            // 
            this.ArmorTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ArmorTypeLabel.AutoSize = true;
            this.ArmorTypeLabel.Location = new System.Drawing.Point(198, 8);
            this.ArmorTypeLabel.Name = "ArmorTypeLabel";
            this.ArmorTypeLabel.Size = new System.Drawing.Size(61, 13);
            this.ArmorTypeLabel.TabIndex = 4;
            this.ArmorTypeLabel.Text = "Armor Type";
            // 
            // ArmorClassValue
            // 
            this.ArmorClassValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ArmorClassValue.AutoCompleteCustomSource.AddRange(new string[] {
            "None",
            "Superlight",
            "Lightweight",
            "Striker",
            "Medium_Striker",
            "Heavy_Striker",
            "Mediumweight",
            "Light_Heavy",
            "Medium_Heavy",
            "Armored_Heavy",
            "Super_Heavy",
            "Mega_Heavy"});
            this.ArmorClassValue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.ArmorClassValue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ArmorClassValue.FormattingEnabled = true;
            this.ArmorClassValue.Items.AddRange(new object[] {
            "None",
            "Superlight",
            "Lightweight",
            "Striker",
            "Medium_Striker",
            "Heavy_Striker",
            "Mediumweight",
            "Light_Heavy",
            "Medium_Heavy",
            "Armored_Heavy",
            "Super_Heavy",
            "Mega_Heavy"});
            this.ArmorClassValue.Location = new System.Drawing.Point(78, 4);
            this.ArmorClassValue.Name = "ArmorClassValue";
            this.ArmorClassValue.Size = new System.Drawing.Size(114, 21);
            this.ArmorClassValue.TabIndex = 2;
            // 
            // SPValue
            // 
            this.SPValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SPValue.Location = new System.Drawing.Point(433, 5);
            this.SPValue.Name = "SPValue";
            this.SPValue.ReadOnly = true;
            this.SPValue.Size = new System.Drawing.Size(24, 20);
            this.SPValue.TabIndex = 6;
            this.SPValue.Text = "0";
            // 
            // SPLabel
            // 
            this.SPLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SPLabel.AutoSize = true;
            this.SPLabel.Location = new System.Drawing.Point(373, 8);
            this.SPLabel.Name = "SPLabel";
            this.SPLabel.Size = new System.Drawing.Size(54, 13);
            this.SPLabel.TabIndex = 7;
            this.SPLabel.Text = "Armor SP:";
            // 
            // RAMLabel
            // 
            this.RAMLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RAMLabel.AutoSize = true;
            this.ArmorEditTable.SetColumnSpan(this.RAMLabel, 2);
            this.RAMLabel.Location = new System.Drawing.Point(149, 38);
            this.RAMLabel.Name = "RAMLabel";
            this.RAMLabel.Size = new System.Drawing.Size(123, 13);
            this.RAMLabel.TabIndex = 8;
            this.RAMLabel.Text = "Energy Absorbing Armor:";
            // 
            // ArmorTypeValue
            // 
            this.ArmorTypeValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ArmorTypeValue.AutoCompleteCustomSource.AddRange(new string[] {
            "Ablative",
            "Standard",
            "Alpha",
            "Beta",
            "Gamma"});
            this.ArmorTypeValue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.ArmorTypeValue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ArmorEditTable.SetColumnSpan(this.ArmorTypeValue, 2);
            this.ArmorTypeValue.FormattingEnabled = true;
            this.ArmorTypeValue.Items.AddRange(new object[] {
            "Ablative",
            "Standard",
            "Alpha",
            "Beta",
            "Gamma"});
            this.ArmorTypeValue.Location = new System.Drawing.Point(278, 4);
            this.ArmorTypeValue.Name = "ArmorTypeValue";
            this.ArmorTypeValue.Size = new System.Drawing.Size(84, 21);
            this.ArmorTypeValue.TabIndex = 5;
            // 
            // RAMValue
            // 
            this.RAMValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RAMValue.FormattingEnabled = true;
            this.RAMValue.Items.AddRange(new object[] {
            "None",
            "1/5",
            "1/4",
            "1/3",
            "1/2"});
            this.RAMValue.Location = new System.Drawing.Point(278, 34);
            this.RAMValue.Name = "RAMValue";
            this.RAMValue.Size = new System.Drawing.Size(44, 21);
            this.RAMValue.TabIndex = 9;
            // 
            // SPPenaltyLabel
            // 
            this.SPPenaltyLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SPPenaltyLabel.AutoSize = true;
            this.ArmorEditTable.SetColumnSpan(this.SPPenaltyLabel, 2);
            this.SPPenaltyLabel.Location = new System.Drawing.Point(365, 38);
            this.SPPenaltyLabel.Name = "SPPenaltyLabel";
            this.SPPenaltyLabel.Size = new System.Drawing.Size(62, 13);
            this.SPPenaltyLabel.TabIndex = 10;
            this.SPPenaltyLabel.Text = "SP Penalty:";
            // 
            // RAMPenaltyValue
            // 
            this.RAMPenaltyValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ArmorEditTable.SetColumnSpan(this.RAMPenaltyValue, 2);
            this.RAMPenaltyValue.Location = new System.Drawing.Point(433, 35);
            this.RAMPenaltyValue.Name = "RAMPenaltyValue";
            this.RAMPenaltyValue.ReadOnly = true;
            this.RAMPenaltyValue.Size = new System.Drawing.Size(44, 20);
            this.RAMPenaltyValue.TabIndex = 11;
            // 
            // DCLabel
            // 
            this.DCLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DCLabel.AutoSize = true;
            this.ArmorEditTable.SetColumnSpan(this.DCLabel, 2);
            this.DCLabel.Location = new System.Drawing.Point(469, 8);
            this.DCLabel.Name = "DCLabel";
            this.DCLabel.Size = new System.Drawing.Size(78, 13);
            this.DCLabel.TabIndex = 12;
            this.DCLabel.Text = "Damage Coeff:";
            // 
            // DCValue
            // 
            this.DCValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DCValue.Location = new System.Drawing.Point(553, 5);
            this.DCValue.Name = "DCValue";
            this.DCValue.ReadOnly = true;
            this.DCValue.Size = new System.Drawing.Size(29, 20);
            this.DCValue.TabIndex = 13;
            // 
            // ArmorWeightLabel
            // 
            this.ArmorWeightLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ArmorWeightLabel.AutoSize = true;
            this.ArmorWeightLabel.Location = new System.Drawing.Point(624, 8);
            this.ArmorWeightLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.ArmorWeightLabel.Name = "ArmorWeightLabel";
            this.ArmorWeightLabel.Size = new System.Drawing.Size(44, 13);
            this.ArmorWeightLabel.TabIndex = 14;
            this.ArmorWeightLabel.Text = "Weight:";
            this.ArmorWeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ArmorCostLabel
            // 
            this.ArmorCostLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ArmorCostLabel.AutoSize = true;
            this.ArmorCostLabel.Location = new System.Drawing.Point(719, 8);
            this.ArmorCostLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.ArmorCostLabel.Name = "ArmorCostLabel";
            this.ArmorCostLabel.Size = new System.Drawing.Size(59, 13);
            this.ArmorCostLabel.TabIndex = 15;
            this.ArmorCostLabel.Text = "Cost (CPs):";
            this.ArmorCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ArmorWeightValue
            // 
            this.ArmorWeightValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ArmorWeightValue.Location = new System.Drawing.Point(673, 5);
            this.ArmorWeightValue.Name = "ArmorWeightValue";
            this.ArmorWeightValue.ReadOnly = true;
            this.ArmorWeightValue.Size = new System.Drawing.Size(39, 20);
            this.ArmorWeightValue.TabIndex = 16;
            // 
            // ArmorCostValue
            // 
            this.ArmorCostValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ArmorCostValue.Location = new System.Drawing.Point(783, 5);
            this.ArmorCostValue.Name = "ArmorCostValue";
            this.ArmorCostValue.ReadOnly = true;
            this.ArmorCostValue.Size = new System.Drawing.Size(45, 20);
            this.ArmorCostValue.TabIndex = 17;
            // 
            // CancelChangesButton
            // 
            this.ArmorEditTable.SetColumnSpan(this.CancelChangesButton, 2);
            this.CancelChangesButton.Location = new System.Drawing.Point(718, 63);
            this.CancelChangesButton.Name = "CancelChangesButton";
            this.CancelChangesButton.Size = new System.Drawing.Size(110, 23);
            this.CancelChangesButton.TabIndex = 19;
            this.CancelChangesButton.Text = "Cancel Changes";
            this.CancelChangesButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ArmorEditTable.SetColumnSpan(this.SaveButton, 3);
            this.SaveButton.Location = new System.Drawing.Point(602, 63);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(110, 23);
            this.SaveButton.TabIndex = 18;
            this.SaveButton.Text = "Save Changes";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // TrueSPValue
            // 
            this.TrueSPValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TrueSPValue.Location = new System.Drawing.Point(553, 35);
            this.TrueSPValue.Name = "TrueSPValue";
            this.TrueSPValue.ReadOnly = true;
            this.TrueSPValue.Size = new System.Drawing.Size(29, 20);
            this.TrueSPValue.TabIndex = 20;
            // 
            // TrueSPLabel
            // 
            this.TrueSPLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TrueSPLabel.AutoSize = true;
            this.TrueSPLabel.Location = new System.Drawing.Point(498, 38);
            this.TrueSPLabel.Name = "TrueSPLabel";
            this.TrueSPLabel.Size = new System.Drawing.Size(49, 13);
            this.TrueSPLabel.TabIndex = 21;
            this.TrueSPLabel.Text = "Final SP:";
            // 
            // Servobuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 292);
            this.Controls.Add(this.ArmorEditTable);
            this.Controls.Add(this.ServoEditTable);
            this.Name = "Servobuilder";
            this.Text = "Servobuilder";
            this.ServoEditTable.ResumeLayout(false);
            this.ServoEditTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServoExtraSpacesValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServoExtraKillsValue)).EndInit();
            this.ArmorEditTable.ResumeLayout(false);
            this.ArmorEditTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel ServoEditTable;
        private System.Windows.Forms.Label ServoCostLabel;
        private System.Windows.Forms.Label ServoSpacesLabel;
        private System.Windows.Forms.Label ServoClassLabel;
        private System.Windows.Forms.Label ServoKillsLabel;
        private System.Windows.Forms.Label ServoWeightLabel;
        private System.Windows.Forms.TextBox ServoSpacesValue;
        private System.Windows.Forms.TextBox ServoKillsValue;
        private System.Windows.Forms.TextBox ServoWeightValue;
        private System.Windows.Forms.Label EditServoLabel;
        private System.Windows.Forms.ComboBox ServoTypeValue;
        private System.Windows.Forms.Label ServoTypeLabel;
        private System.Windows.Forms.ComboBox ServoClassValue;
        private System.Windows.Forms.TextBox ServoCostValue;
        private System.Windows.Forms.Label ServoExtraSpacesLabel;
        private System.Windows.Forms.NumericUpDown ServoExtraSpacesValue;
        private System.Windows.Forms.Label ServoExtraKillsLabel;
        private System.Windows.Forms.NumericUpDown ServoExtraKillsValue;
        private System.Windows.Forms.Label ServoArmorLabel;
        private System.Windows.Forms.TableLayoutPanel ArmorEditTable;
        private System.Windows.Forms.Label ArmorClassLabel;
        private System.Windows.Forms.Label ArmorTypeLabel;
        private System.Windows.Forms.ComboBox ArmorClassValue;
        private System.Windows.Forms.TextBox SPValue;
        private System.Windows.Forms.Label SPLabel;
        private System.Windows.Forms.Label RAMLabel;
        private System.Windows.Forms.ComboBox ArmorTypeValue;
        private System.Windows.Forms.ComboBox RAMValue;
        private System.Windows.Forms.Label SPPenaltyLabel;
        private System.Windows.Forms.TextBox RAMPenaltyValue;
        private System.Windows.Forms.Label DCLabel;
        private System.Windows.Forms.TextBox DCValue;
        private System.Windows.Forms.Label ArmorWeightLabel;
        private System.Windows.Forms.Label ArmorCostLabel;
        private System.Windows.Forms.TextBox ArmorWeightValue;
        private System.Windows.Forms.TextBox ArmorCostValue;
        private System.Windows.Forms.Button CancelChangesButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox TrueSPValue;
        private System.Windows.Forms.Label TrueSPLabel;
    }
}
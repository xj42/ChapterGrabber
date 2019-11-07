/********************************************************************************
*
*    Copyright(C) 2003-2008 Jarrett Vance http://jvance.com
*
*    This file is part of ChapterGrabber
*
*	 ChapterGrabber is free software; you can redistribute it and/or modify
*    it under the terms of the GNU General Public License as published by
*    the Free Software Foundation; either version 2 of the License, or
*    (at your option) any later version.
*
*    ChapterGrabber is distributed in the hope that it will be useful,
*    but WITHOUT ANY WARRANTY; without even the implied warranty of
*    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
*    GNU General Public License for more details.
*
*    You should have received a copy of the GNU General Public License
*    along with this program; if not, write to the Free Software
*    Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
*
********************************************************************************/
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using JarrettVance.ChapterTools;
using System.IO;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;
using System.Net;
using System.Web;
using System.Threading;
using System.Diagnostics;
using JarrettVance.ChapterTools.Extractors;
using System.Collections.Specialized;
namespace JarrettVance.ChapterTools
{
  /// <summary>
  /// Summary description for frmMain.
  /// </summary>
  public partial class MainForm : System.Windows.Forms.Form
  {
    public System.Windows.Forms.MainMenu mainMenu;
    private System.Windows.Forms.MenuItem menuFile;
    private System.Windows.Forms.MenuItem menuEdit;
    private System.Windows.Forms.MenuItem menuEditClipboardImport;
    private System.Windows.Forms.MenuItem miSearch;
    private System.Windows.Forms.OpenFileDialog openFileDialog;
    private System.Windows.Forms.SaveFileDialog saveFileDialog;
    private System.Windows.Forms.MenuItem menuFileSave;
    private System.Windows.Forms.MenuItem menuItem1;
    private System.Windows.Forms.MenuItem menuFileExit;
    private System.Windows.Forms.MenuItem menuFileNew;
    private System.Windows.Forms.MenuItem menuItem4;
    private System.Windows.Forms.MenuItem miImportDurations;

    private System.Windows.Forms.MenuItem menuHelp;
    private System.Windows.Forms.MenuItem menuHelpAbout;
    private SplitContainer splitContainer1;
    private GroupBox grpResults;
    private MenuItem menuResetNames;
    private MenuItem menuItem2;
    private MenuItem miOpenFile;
    private MenuItem miOpenDisc;
    private MenuItem miIgnoreShortLastChapter;
    private MenuItem menuChangeFps;
    private MenuItem menuRecentFiles;
    private MenuItem menuItem13;
    private IContainer components;

    public MainForm()
    {
      //
      // Required for Windows Form Designer support
      //
      InitializeComponent();
    }

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    protected override void Dispose(bool disposing)
    {
      if (disposing)
      {
        if (components != null)
        {
          components.Dispose();
        }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.menuFile = new System.Windows.Forms.MenuItem();
            this.menuFileNew = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.miOpenFile = new System.Windows.Forms.MenuItem();
            this.miOpenDisc = new System.Windows.Forms.MenuItem();
            this.menuQuickOpen = new System.Windows.Forms.MenuItem();
            this.menuFileSave = new System.Windows.Forms.MenuItem();
            this.menuQuickSave = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.menuRecentFiles = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuFileExit = new System.Windows.Forms.MenuItem();
            this.menuEdit = new System.Windows.Forms.MenuItem();
            this.menuResetNames = new System.Windows.Forms.MenuItem();
            this.menuChangeFps = new System.Windows.Forms.MenuItem();
            this.miDelay = new System.Windows.Forms.MenuItem();
            this.menuEditClipboardImport = new System.Windows.Forms.MenuItem();
            this.miSearch = new System.Windows.Forms.MenuItem();
            this.menuCurrentFps = new System.Windows.Forms.MenuItem();
            this.menuLang = new System.Windows.Forms.MenuItem();
            this.miDatabaseCredentials = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.miImportDurations = new System.Windows.Forms.MenuItem();
            this.miIgnoreShortLastChapter = new System.Windows.Forms.MenuItem();
            this.miAutoUseDb = new System.Windows.Forms.MenuItem();
            this.miWarnInvalidTitle = new System.Windows.Forms.MenuItem();
            this.menuHelp = new System.Windows.Forms.MenuItem();
            this.miAutoCheck = new System.Windows.Forms.MenuItem();
            this.miUpdate = new System.Windows.Forms.MenuItem();
            this.menuHelpAbout = new System.Windows.Forms.MenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuTitles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDuration = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslFps = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsslLang = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.picDb = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDn = new System.Windows.Forms.Button();
            this.toolTipTitle = new System.Windows.Forms.ToolTip(this.components);
            this.btnTitles = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkDatabase = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.flowResults = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listChapters = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChapterTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtChapterName = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDb)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpResults.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuHelp});
            // 
            // menuFile
            // 
            this.menuFile.Index = 0;
            this.menuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuFileNew,
            this.menuItem4,
            this.miOpenFile,
            this.miOpenDisc,
            this.menuQuickOpen,
            this.menuFileSave,
            this.menuQuickSave,
            this.menuItem13,
            this.menuRecentFiles,
            this.menuItem1,
            this.menuFileExit});
            this.menuFile.MergeType = System.Windows.Forms.MenuMerge.Replace;
            this.menuFile.Text = "File";
            // 
            // menuFileNew
            // 
            this.menuFileNew.Index = 0;
            this.menuFileNew.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.menuFileNew.Text = "New";
            this.menuFileNew.Click += new System.EventHandler(this.menuFileNew_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 1;
            this.menuItem4.Text = "-";
            // 
            // miOpenFile
            // 
            this.miOpenFile.Index = 2;
            this.miOpenFile.Text = "Open File";
            this.miOpenFile.Click += new System.EventHandler(this.menuFileOpen_Click);
            // 
            // miOpenDisc
            // 
            this.miOpenDisc.Index = 3;
            this.miOpenDisc.Text = "Open Disc";
            this.miOpenDisc.Click += new System.EventHandler(this.miOpenDisc_Click);
            // 
            // menuQuickOpen
            // 
            this.menuQuickOpen.Index = 4;
            this.menuQuickOpen.Text = "Quick Open";
            this.menuQuickOpen.Click += new System.EventHandler(this.menuQuickOpen_Click);
            // 
            // menuFileSave
            // 
            this.menuFileSave.Index = 5;
            this.menuFileSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.menuFileSave.Text = "Save";
            this.menuFileSave.Click += new System.EventHandler(this.menuFileSave_Click);
            // 
            // menuQuickSave
            // 
            this.menuQuickSave.Index = 6;
            this.menuQuickSave.Text = "Quick Multi Save";
            this.menuQuickSave.Click += new System.EventHandler(this.menuQuickSave_Click);
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 7;
            this.menuItem13.Text = "-";
            // 
            // menuRecentFiles
            // 
            this.menuRecentFiles.Index = 8;
            this.menuRecentFiles.Text = "Recent Files";
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 9;
            this.menuItem1.Text = "-";
            // 
            // menuFileExit
            // 
            this.menuFileExit.Index = 10;
            this.menuFileExit.Shortcut = System.Windows.Forms.Shortcut.AltF4;
            this.menuFileExit.Text = "Exit";
            this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
            // 
            // menuEdit
            // 
            this.menuEdit.Index = 1;
            this.menuEdit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuResetNames,
            this.menuChangeFps,
            this.miDelay,
            this.menuEditClipboardImport,
            this.miSearch,
            this.menuCurrentFps,
            this.menuLang,
            this.miDatabaseCredentials,
            this.menuItem2,
            this.miImportDurations,
            this.miIgnoreShortLastChapter,
            this.miAutoUseDb,
            this.miWarnInvalidTitle});
            this.menuEdit.Text = "Edit";
            // 
            // menuResetNames
            // 
            this.menuResetNames.Index = 0;
            this.menuResetNames.Text = "Reset Chapter Names";
            this.menuResetNames.Click += new System.EventHandler(this.menuResetNames_Click);
            // 
            // menuChangeFps
            // 
            this.menuChangeFps.Index = 1;
            this.menuChangeFps.Text = "Convert Chapter Times by FPS";
            // 
            // miDelay
            // 
            this.miDelay.Index = 2;
            this.miDelay.Text = "Add Delay (shift)";
            this.miDelay.Click += new System.EventHandler(this.miDelay_Click);
            // 
            // menuEditClipboardImport
            // 
            this.menuEditClipboardImport.Index = 3;
            this.menuEditClipboardImport.Shortcut = System.Windows.Forms.Shortcut.F2;
            this.menuEditClipboardImport.Text = "Import Names from Clipboard";
            this.menuEditClipboardImport.Click += new System.EventHandler(this.menuEditClipboardImport_Click);
            // 
            // miSearch
            // 
            this.miSearch.Enabled = false;
            this.miSearch.Index = 4;
            this.miSearch.Shortcut = System.Windows.Forms.Shortcut.F3;
            this.miSearch.Text = "Search Names on Internet";
            this.miSearch.Visible = false;
            this.miSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // menuCurrentFps
            // 
            this.menuCurrentFps.Index = 5;
            this.menuCurrentFps.Text = "Current FPS";
            // 
            // menuLang
            // 
            this.menuLang.Index = 6;
            this.menuLang.Text = "Current Language";
            // 
            // miDatabaseCredentials
            // 
            this.miDatabaseCredentials.Enabled = false;
            this.miDatabaseCredentials.Index = 7;
            this.miDatabaseCredentials.Text = "Database Credentials";
            this.miDatabaseCredentials.Visible = false;
            this.miDatabaseCredentials.Click += new System.EventHandler(this.miDatabaseCredentials_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 8;
            this.menuItem2.Text = "-";
            // 
            // miImportDurations
            // 
            this.miImportDurations.Index = 9;
            this.miImportDurations.Text = "Import Duration with Names";
            this.miImportDurations.Click += new System.EventHandler(this.menuEditTimesImport_Click);
            // 
            // miIgnoreShortLastChapter
            // 
            this.miIgnoreShortLastChapter.Checked = true;
            this.miIgnoreShortLastChapter.Index = 10;
            this.miIgnoreShortLastChapter.Text = "Ignore Short Last Chapter";
            this.miIgnoreShortLastChapter.Click += new System.EventHandler(this.miIgnoreShortLastChapter_Click);
            // 
            // miAutoUseDb
            // 
            this.miAutoUseDb.Checked = true;
            this.miAutoUseDb.Enabled = false;
            this.miAutoUseDb.Index = 11;
            this.miAutoUseDb.Text = "Sync Online Database";
            this.miAutoUseDb.Visible = false;
            this.miAutoUseDb.Click += new System.EventHandler(this.miAutoUseDb_Click);
            // 
            // miWarnInvalidTitle
            // 
            this.miWarnInvalidTitle.Checked = true;
            this.miWarnInvalidTitle.Index = 12;
            this.miWarnInvalidTitle.Text = "Check Valid Title Upon Save";
            // 
            // menuHelp
            // 
            this.menuHelp.Index = 2;
            this.menuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.miAutoCheck,
            this.miUpdate,
            this.menuHelpAbout});
            this.menuHelp.Text = "Help";
            // 
            // miAutoCheck
            // 
            this.miAutoCheck.Checked = true;
            this.miAutoCheck.Enabled = false;
            this.miAutoCheck.Index = 0;
            this.miAutoCheck.Text = "Check for Update on Startup";
            this.miAutoCheck.Visible = false;
            this.miAutoCheck.Click += new System.EventHandler(this.miAutoCheck_Click);
            // 
            // miUpdate
            // 
            this.miUpdate.Enabled = false;
            this.miUpdate.Index = 1;
            this.miUpdate.Text = "Check for Update Now";
            this.miUpdate.Visible = false;
            this.miUpdate.Click += new System.EventHandler(this.miUpdate_Click);
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Index = 2;
            this.menuHelpAbout.Shortcut = System.Windows.Forms.Shortcut.F1;
            this.menuHelpAbout.Text = "About";
            this.menuHelpAbout.Click += new System.EventHandler(this.menuHelpAbout_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "doc1";
            // 
            // menuTitles
            // 
            this.menuTitles.Name = "menuTitles";
            this.menuTitles.Size = new System.Drawing.Size(61, 4);
            // 
            // tsslStatus
            // 
            this.tsslStatus.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(189, 17);
            this.tsslStatus.Spring = true;
            this.tsslStatus.Text = "Ready";
            this.tsslStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsslDuration
            // 
            this.tsslDuration.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.tsslDuration.Name = "tsslDuration";
            this.tsslDuration.Size = new System.Drawing.Size(122, 17);
            this.tsslDuration.Text = "Duration: 00:00:00.000";
            // 
            // statusStrip1
            // 
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus,
            this.tsslDuration,
            this.tsslFps,
            this.tsslLang});
            this.statusStrip1.Location = new System.Drawing.Point(0, 318);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(484, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslFps
            // 
            this.tsslFps.Name = "tsslFps";
            this.tsslFps.Size = new System.Drawing.Size(69, 20);
            this.tsslFps.Text = "29.970fps";
            // 
            // tsslLang
            // 
            this.tsslLang.Name = "tsslLang";
            this.tsslLang.Size = new System.Drawing.Size(89, 20);
            this.tsslLang.Text = "eng (English)";
            // 
            // picSearch
            // 
            this.picSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picSearch.Image = ((System.Drawing.Image)(resources.GetObject("picSearch.Image")));
            this.picSearch.Location = new System.Drawing.Point(-21, 1);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(16, 11);
            this.picSearch.TabIndex = 10;
            this.picSearch.TabStop = false;
            this.toolTip1.SetToolTip(this.picSearch, "Searching...");
            this.picSearch.Visible = false;
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.Location = new System.Drawing.Point(72, 7);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(25, 23);
            this.txtTitle.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtTitle, "Please enter the title of your movie.");
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // picDb
            // 
            this.picDb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picDb.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picDb.Location = new System.Drawing.Point(-64, 9);
            this.picDb.Name = "picDb";
            this.picDb.Size = new System.Drawing.Size(16, 16);
            this.picDb.TabIndex = 8;
            this.picDb.TabStop = false;
            this.toolTip1.SetToolTip(this.picDb, "Database syncing...");
            this.picDb.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Image = global::JarrettVance.ChapterTools.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(419, 253);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(26, 26);
            this.btnAdd.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnAdd, "Add chapter");
            this.btnAdd.Click += new System.EventHandler(this.ChapterControls_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Image = global::JarrettVance.ChapterTools.Properties.Resources.delete;
            this.btnDelete.Location = new System.Drawing.Point(449, 253);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(26, 26);
            this.btnDelete.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnDelete, "Remove chapter");
            this.btnDelete.Click += new System.EventHandler(this.ChapterControls_Click);
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUp.Image = global::JarrettVance.ChapterTools.Properties.Resources.arrow_up;
            this.btnUp.Location = new System.Drawing.Point(359, 253);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(26, 26);
            this.btnUp.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnUp, "Move name up");
            this.btnUp.Click += new System.EventHandler(this.ChapterControls_Click);
            // 
            // btnDn
            // 
            this.btnDn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDn.Image = global::JarrettVance.ChapterTools.Properties.Resources.arrow_down;
            this.btnDn.Location = new System.Drawing.Point(389, 253);
            this.btnDn.Name = "btnDn";
            this.btnDn.Size = new System.Drawing.Size(26, 26);
            this.btnDn.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnDn, "Move name down");
            this.btnDn.Click += new System.EventHandler(this.ChapterControls_Click);
            // 
            // toolTipTitle
            // 
            this.toolTipTitle.ToolTipTitle = "Title Invalid";
            // 
            // btnTitles
            // 
            this.btnTitles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTitles.ContextMenuStrip = this.menuTitles;
            this.btnTitles.Image = global::JarrettVance.ChapterTools.Properties.Resources.apply_bad;
            this.btnTitles.Location = new System.Drawing.Point(-285, 5);
            this.btnTitles.Name = "btnTitles";
            this.btnTitles.Size = new System.Drawing.Size(24, 24);
            this.btnTitles.TabIndex = 8;
            this.toolTipTitle.SetToolTip(this.btnTitles, "Choose a suggested title.");
            this.btnTitles.UseVisualStyleBackColor = true;
            this.btnTitles.Click += new System.EventHandler(this.btnTitles_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(390, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(54, 0);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 8;
            this.splitContainer1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkDatabase);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(9, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 26);
            this.panel1.TabIndex = 14;
            this.panel1.Visible = false;
            // 
            // linkDatabase
            // 
            this.linkDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkDatabase.AutoSize = true;
            this.linkDatabase.Location = new System.Drawing.Point(226, 6);
            this.linkDatabase.Name = "linkDatabase";
            this.linkDatabase.Size = new System.Drawing.Size(85, 15);
            this.linkDatabase.TabIndex = 12;
            this.linkDatabase.TabStop = true;
            this.linkDatabase.Text = "ChapterDb.org";
            this.linkDatabase.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDatabase_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(26, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Database updated!";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JarrettVance.ChapterTools.Properties.Resources.attn;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 26);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // grpResults
            // 
            this.grpResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpResults.Controls.Add(this.picSearch);
            this.grpResults.Controls.Add(this.flowResults);
            this.grpResults.Location = new System.Drawing.Point(384, 12);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(0, 0);
            this.grpResults.TabIndex = 0;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Database";
            this.grpResults.Visible = false;
            // 
            // flowResults
            // 
            this.flowResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowResults.AutoScroll = true;
            this.flowResults.AutoScrollMargin = new System.Drawing.Size(5, 10);
            this.flowResults.AutoScrollMinSize = new System.Drawing.Size(30, 30);
            this.flowResults.BackColor = System.Drawing.SystemColors.Window;
            this.flowResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowResults.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowResults.Location = new System.Drawing.Point(6, 16);
            this.flowResults.Name = "flowResults";
            this.flowResults.Size = new System.Drawing.Size(0, 2);
            this.flowResults.TabIndex = 14;
            this.flowResults.WrapContents = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.listChapters);
            this.panel3.Controls.Add(this.btnDn);
            this.panel3.Controls.Add(this.btnUp);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.txtChapterTime);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtChapterName);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(484, 315);
            this.panel3.TabIndex = 13;
            // 
            // listChapters
            // 
            this.listChapters.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listChapters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listChapters.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.listChapters.FullRowSelect = true;
            this.listChapters.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listChapters.HideSelection = false;
            this.listChapters.LabelWrap = false;
            this.listChapters.Location = new System.Drawing.Point(10, 8);
            this.listChapters.MultiSelect = false;
            this.listChapters.Name = "listChapters";
            this.listChapters.Size = new System.Drawing.Size(464, 240);
            this.listChapters.TabIndex = 10;
            this.listChapters.UseCompatibleStateImageBehavior = false;
            this.listChapters.View = System.Windows.Forms.View.Details;
            this.listChapters.SelectedIndexChanged += new System.EventHandler(this.listChapters_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.Location = new System.Drawing.Point(10, 259);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Time";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtChapterTime
            // 
            this.txtChapterTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChapterTime.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtChapterTime.Location = new System.Drawing.Point(58, 254);
            this.txtChapterTime.MaxLength = 12;
            this.txtChapterTime.Name = "txtChapterTime";
            this.txtChapterTime.Size = new System.Drawing.Size(82, 24);
            this.txtChapterTime.TabIndex = 2;
            this.txtChapterTime.Text = "00:00:00.000";
            this.txtChapterTime.TextChanged += new System.EventHandler(this.txtChapter_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.Location = new System.Drawing.Point(10, 289);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtChapterName
            // 
            this.txtChapterName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChapterName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtChapterName.Location = new System.Drawing.Point(58, 284);
            this.txtChapterName.MaxLength = 300;
            this.txtChapterName.Name = "txtChapterName";
            this.txtChapterName.Size = new System.Drawing.Size(416, 24);
            this.txtChapterName.TabIndex = 4;
            this.txtChapterName.Text = "Chapter 0";
            this.txtChapterName.TextChanged += new System.EventHandler(this.txtChapter_TextChanged);
            this.txtChapterName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtChapterName_KeyDown);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(39, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(29, 15);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.AutoSize = true;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(106, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(68, 27);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picDb);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.btnTitles);
            this.panel2.Controls.Add(this.txtTitle);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Location = new System.Drawing.Point(354, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(35, 60);
            this.panel2.TabIndex = 12;
            this.panel2.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.ClientSize = new System.Drawing.Size(484, 340);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "ChapterGrabber";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmMain_Closing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDb)).EndInit();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpResults.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }
    #endregion

    private MenuItem menuLang;
    private ToolStripStatusLabel tsslStatus;
    private ToolStripStatusLabel tsslDuration;
    private StatusStrip statusStrip1;
    private MenuItem menuCurrentFps;
    private ToolStripDropDownButton tsslFps;
    private ToolStripDropDownButton tsslLang;
    private MenuItem miAutoCheck;
    private MenuItem miAutoUseDb;
    private MenuItem miDatabaseCredentials;
    private ToolTip toolTip1;
    private PictureBox picSearch;
    private ToolTip toolTipTitle;
    private ContextMenuStrip menuTitles;
    private MenuItem miWarnInvalidTitle;
    private MenuItem menuQuickSave;
    private MenuItem menuQuickOpen;
    private LinkLabel linkDatabase;
    private Label label1;
    private PictureBox pictureBox1;
    private MenuItem miDelay;
    private FlowLayoutPanel flowResults;
    private Panel panel1;
    private SearchResultItem searchResultItem1;
    private SearchResultItem searchResultItem2;
    private SearchResultItem searchResultItem3;
        private Panel panel3;
        private Label lblTitle;
        private TextBox txtTitle;
        private Button btnTitles;
        private Button btnSearch;
        private PictureBox picDb;
        private Panel panel2;
        private ListView listChapters;
        private Button btnDn;
        private Button btnUp;
        private Label label3;
        private Button btnDelete;
        private TextBox txtChapterTime;
        private Button btnAdd;
        private Label label6;
        private TextBox txtChapterName;
        private MenuItem miUpdate;
    }
}


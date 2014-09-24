using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Text;

namespace didoClient
{
	/// <summary>
	/// Summary description for frmSample9.
	/// </summary>
	public class TermNCodeMainForm : System.Windows.Forms.Form
	{
        private SourceGrid.DataGrid dataGrid;

		private System.Windows.Forms.Button btLoadXml;
		private System.Windows.Forms.Button btSaveXml;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private TabPage tabPage2;
        private Button button3;
        private Button button2;
        private Button button4;
        private CheckBox chkReadOnly;
        private Button button6;
        private Button button5;
        private Button button7;
        private TextBox textBox1;
        private SplitContainer splitContainer2;
        private GroupBox groupBox2;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private SourceGrid.DataGrid dataGrid1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public TermNCodeMainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.dataGrid = new SourceGrid.DataGrid();
            this.btLoadXml = new System.Windows.Forms.Button();
            this.btSaveXml = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkReadOnly = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.dataGrid1 = new SourceGrid.DataGrid();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AutoSize = true;
            this.dataGrid.AutoStretchColumnsToFitWidth = true;
            this.dataGrid.AutoStretchRowsToFitHeight = true;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataGrid.DefaultHeight = 25;
            this.dataGrid.DefaultWidth = 25;
            this.dataGrid.DeleteQuestionMessage = "Are you sure to delete all the selected rows?";
            this.dataGrid.EnableSort = false;
            this.dataGrid.FixedRows = 1;
            this.dataGrid.Location = new System.Drawing.Point(0, 62);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.SelectionMode = SourceGrid.GridSelectionMode.Row;
            this.dataGrid.Size = new System.Drawing.Size(921, 218);
            this.dataGrid.TabIndex = 15;
            this.dataGrid.TabStop = true;
            this.dataGrid.ToolTipText = "";
            // 
            // btLoadXml
            // 
            this.btLoadXml.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btLoadXml.Location = new System.Drawing.Point(241, 12);
            this.btLoadXml.Name = "btLoadXml";
            this.btLoadXml.Size = new System.Drawing.Size(90, 25);
            this.btLoadXml.TabIndex = 16;
            this.btLoadXml.Text = "조회";
            this.btLoadXml.Click += new System.EventHandler(this.btLoadXml_Click);
            // 
            // btSaveXml
            // 
            this.btSaveXml.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btSaveXml.Location = new System.Drawing.Point(337, 12);
            this.btSaveXml.Name = "btSaveXml";
            this.btSaveXml.Size = new System.Drawing.Size(90, 25);
            this.btSaveXml.TabIndex = 17;
            this.btSaveXml.Text = "저장";
            this.btSaveXml.Click += new System.EventHandler(this.btSaveXml_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(433, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 25);
            this.button1.TabIndex = 17;
            this.button1.Text = "프린트";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(935, 429);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(927, 403);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "용어정의";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.dataGrid);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button6);
            this.splitContainer1.Panel2.Controls.Add(this.button5);
            this.splitContainer1.Panel2.Controls.Add(this.button7);
            this.splitContainer1.Size = new System.Drawing.Size(921, 397);
            this.splitContainer1.SplitterDistance = 283;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.chkReadOnly);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btLoadXml);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btSaveXml);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(921, 43);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // chkReadOnly
            // 
            this.chkReadOnly.AutoSize = true;
            this.chkReadOnly.Location = new System.Drawing.Point(828, 17);
            this.chkReadOnly.Name = "chkReadOnly";
            this.chkReadOnly.Size = new System.Drawing.Size(77, 16);
            this.chkReadOnly.TabIndex = 21;
            this.chkReadOnly.Text = "read only";
            this.chkReadOnly.UseVisualStyleBackColor = true;
            this.chkReadOnly.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Location = new System.Drawing.Point(721, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 25);
            this.button4.TabIndex = 20;
            this.button4.Text = "엑셀저장";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Location = new System.Drawing.Point(625, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 25);
            this.button3.TabIndex = 19;
            this.button3.Text = "이미지저장";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(529, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 25);
            this.button2.TabIndex = 18;
            this.button2.Text = "HTML보기";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button6.Location = new System.Drawing.Point(828, 45);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 25);
            this.button6.TabIndex = 22;
            this.button6.Text = "저장";
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button5.Location = new System.Drawing.Point(828, 14);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 25);
            this.button5.TabIndex = 22;
            this.button5.Text = "초기화";
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button7.Location = new System.Drawing.Point(828, 76);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(90, 25);
            this.button7.TabIndex = 17;
            this.button7.Text = "삭제";
            this.button7.Click += new System.EventHandler(this.btSaveXml_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(927, 403);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "코드정의";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 21);
            this.textBox1.TabIndex = 22;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGrid1);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.button14);
            this.splitContainer2.Panel2.Controls.Add(this.button15);
            this.splitContainer2.Panel2.Controls.Add(this.button16);
            this.splitContainer2.Size = new System.Drawing.Size(921, 397);
            this.splitContainer2.SplitterDistance = 293;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.button10);
            this.groupBox2.Controls.Add(this.button11);
            this.groupBox2.Controls.Add(this.button12);
            this.groupBox2.Controls.Add(this.button13);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(921, 43);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(7, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(228, 21);
            this.textBox2.TabIndex = 22;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(828, 17);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 16);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "read only";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button8.Location = new System.Drawing.Point(721, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(90, 25);
            this.button8.TabIndex = 20;
            this.button8.Text = "엑셀저장";
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button9.Location = new System.Drawing.Point(625, 12);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(90, 25);
            this.button9.TabIndex = 19;
            this.button9.Text = "이미지저장";
            // 
            // button10
            // 
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button10.Location = new System.Drawing.Point(529, 12);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(90, 25);
            this.button10.TabIndex = 18;
            this.button10.Text = "HTML보기";
            // 
            // button11
            // 
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button11.Location = new System.Drawing.Point(241, 12);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(90, 25);
            this.button11.TabIndex = 16;
            this.button11.Text = "조회";
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button12.Location = new System.Drawing.Point(433, 12);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(90, 25);
            this.button12.TabIndex = 17;
            this.button12.Text = "프린트";
            // 
            // button13
            // 
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button13.Location = new System.Drawing.Point(337, 12);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(90, 25);
            this.button13.TabIndex = 17;
            this.button13.Text = "저장";
            // 
            // button14
            // 
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button14.Location = new System.Drawing.Point(826, 34);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(90, 25);
            this.button14.TabIndex = 25;
            this.button14.Text = "저장";
            // 
            // button15
            // 
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button15.Location = new System.Drawing.Point(826, 3);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(90, 25);
            this.button15.TabIndex = 24;
            this.button15.Text = "초기화";
            // 
            // button16
            // 
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button16.Location = new System.Drawing.Point(826, 65);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(90, 25);
            this.button16.TabIndex = 23;
            this.button16.Text = "삭제";
            // 
            // dataGrid1
            // 
            this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid1.AutoSize = true;
            this.dataGrid1.AutoStretchColumnsToFitWidth = true;
            this.dataGrid1.AutoStretchRowsToFitHeight = true;
            this.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataGrid1.DefaultHeight = 25;
            this.dataGrid1.DefaultWidth = 25;
            this.dataGrid1.DeleteQuestionMessage = "Are you sure to delete all the selected rows?";
            this.dataGrid1.EnableSort = false;
            this.dataGrid1.FixedRows = 1;
            this.dataGrid1.Location = new System.Drawing.Point(0, 43);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.SelectionMode = SourceGrid.GridSelectionMode.Row;
            this.dataGrid1.Size = new System.Drawing.Size(921, 247);
            this.dataGrid1.TabIndex = 18;
            this.dataGrid1.TabStop = true;
            this.dataGrid1.ToolTipText = "";
            // 
            // TermNCodeMainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(935, 429);
            this.Controls.Add(this.tabControl1);
            this.Name = "TermNCodeMainForm";
            this.Text = "용어 및 코드정의";
            this.Load += new System.EventHandler(this.TermNCodeMainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.Button button1;
		#endregion

		private DataView mView;
        private void TermNCodeMainForm_Load(object sender, System.EventArgs e)
		{
			//Read Data From xml
			DataSet ds = new DataSet();
			//ds.ReadXml(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("WindowsFormsSample.GridSamples.SampleData2.xml"));

            ds = this.GetRESTData("http://localhost:8080/svr/term/getList");
            mView = ds.Tables[0].DefaultView;


			dataGrid.FixedRows = 1;
			dataGrid.FixedColumns = 1;

			//Header row
			dataGrid.Columns.Insert(0, SourceGrid.DataGridColumn.CreateRowHeader(dataGrid));

			DevAge.ComponentModel.IBoundList bindList = new DevAge.ComponentModel.BoundDataView(mView);

			//Create default columns
			CreateColumns(dataGrid.Columns, bindList);

			dataGrid.DataSource = bindList;

			dataGrid.AutoSizeCells();
		}

		private void CreateColumns(SourceGrid.DataGridColumns columns,
		                           DevAge.ComponentModel.IBoundList bindList)
		{
			SourceGrid.Cells.Editors.TextBoxNumeric numericEditor = new SourceGrid.Cells.Editors.TextBoxNumeric(typeof(decimal));
			numericEditor.TypeConverter = new DevAge.ComponentModel.Converter.NumberTypeConverter(typeof(decimal), "N");
			numericEditor.AllowNull = true;

			//Borders
			DevAge.Drawing.RectangleBorder border = new DevAge.Drawing.RectangleBorder(new DevAge.Drawing.BorderLine(Color.ForestGreen), new DevAge.Drawing.BorderLine(Color.ForestGreen));

			//Standard Views
			SourceGrid.Cells.Views.Link viewLink = new SourceGrid.Cells.Views.Link();
			viewLink.BackColor = Color.DarkSeaGreen;
			viewLink.Border = border;
			viewLink.ImageAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
			viewLink.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;

			SourceGrid.Cells.Views.Cell viewString = new SourceGrid.Cells.Views.Cell();
			viewString.BackColor = Color.DarkSeaGreen;
			viewString.Border = border;
			viewString.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleLeft;
			SourceGrid.Cells.Views.Cell viewNumeric = new SourceGrid.Cells.Views.Cell();
			viewNumeric.BackColor = Color.DarkSeaGreen;
			viewNumeric.Border = border;
			viewNumeric.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleRight;
			SourceGrid.Cells.Views.Cell viewImage = new SourceGrid.Cells.Views.Cell();
			viewImage.BackColor = Color.DarkSeaGreen;
			viewImage.Border = border;
			viewImage.ImageStretch = false;
			viewImage.ImageAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;

			//Create columns
			SourceGrid.DataGridColumn gridColumn;

			gridColumn = dataGrid.Columns.Add(null, "", new SourceGrid.Cells.Link());
			gridColumn.DataCell.AddController(new LinkClickDelete());
			gridColumn.DataCell.View = viewLink;
			((SourceGrid.Cells.Link)gridColumn.DataCell).Image = didoClient.Properties.Resources.trash;//.ToBitmap();

            gridColumn = dataGrid.Columns.Add("wordId", "id", typeof(string));
            gridColumn.DataCell.View = viewString;
            gridColumn = dataGrid.Columns.Add("wordNm", "용어명칭", typeof(string));
			gridColumn.DataCell.View = viewString;
            gridColumn = dataGrid.Columns.Add("wordDfn", "용어정의", typeof(string));
            gridColumn.DataCell.View = viewString;
            gridColumn = dataGrid.Columns.Add("krNm", "한글명", typeof(string));
            gridColumn.DataCell.View = viewString;
            gridColumn = dataGrid.Columns.Add("enNm", "영문명", typeof(string));
            gridColumn.DataCell.View = viewString;
            gridColumn = dataGrid.Columns.Add("krAbrv", "한글약어", typeof(string));
            gridColumn.DataCell.View = viewString;
            gridColumn = dataGrid.Columns.Add("enAbrv", "영문약어", typeof(string));
			gridColumn.DataCell.View = viewString;
            gridColumn = dataGrid.Columns.Add("wordApplcScope", "용어적용범위", typeof(string));
			gridColumn.DataCell.View = viewString;
            gridColumn = dataGrid.Columns.Add("etcMatterDc", "기타사항", typeof(string));
			gridColumn.DataCell.View = viewString;
            gridColumn = dataGrid.Columns.Add("statusYn", "crud여부", typeof(string));
			gridColumn.DataCell.View = viewString;

			//Create a conditional view
			foreach (SourceGrid.DataGridColumn col in columns)
			{
				SourceGrid.Conditions.ICondition condition =
					SourceGrid.Conditions.ConditionBuilder.AlternateView(col.DataCell.View,
					                                                     Color.LightGray, Color.Black);
				col.Conditions.Add(condition);
			}
		}

		private void btLoadXml_Click(object sender, System.EventArgs e)
		{
            dataGrid.Columns.Clear();
            
            //Read Data From xml
            DataSet ds = new DataSet();

            if (this.textBox1.ToString().Equals("") || this.textBox1.ToString() != null)
            {
                Console.WriteLine("222222-------------");
                ds = this.GetRESTData(String.Format("http://localhost:8080/svr/term/get?key={0}", this.textBox1.ToString()));
            }
            else
            {
                Console.WriteLine("111111-------------");
                ds = this.GetRESTData("http://localhost:8080/svr/term/getList");
            }
            mView = ds.Tables[0].DefaultView;

            dataGrid.FixedRows = 1;
            dataGrid.FixedColumns = 1;

            //Header row
            dataGrid.Columns.Insert(0, SourceGrid.DataGridColumn.CreateRowHeader(dataGrid));

            DevAge.ComponentModel.IBoundList bindList = new DevAge.ComponentModel.BoundDataView(mView);

            //Create default columns
            CreateColumns(dataGrid.Columns, bindList);

            dataGrid.DataSource = bindList;

            dataGrid.AutoSizeCells();

		}


        private void btSaveXml_Click(object sender, System.EventArgs e)
        {
            DataTable dataTable = new DataTable();
            DataSet dataSet = new DataSet();
            dataTable = mView.ToTable();
            dataTable.TableName = "termListDS";
            dataSet.Tables.Add(dataTable);
            try
            {
                var request = (HttpWebRequest)WebRequest.Create("http://localhost:8080/svr/term/saveList");
                request.ContentType = "application/json";
                request.Method = "POST";

                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    string json = JsonConvert.SerializeObject(dataSet);
                    streamWriter.Write(json);
                }

                var response = (HttpWebResponse)request.GetResponse();
                using (var streamReader = new StreamReader(response.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                }
            }
            catch (WebException ex)
            {
                using (WebResponse response = ex.Response)
                {
                    HttpWebResponse httpResponse = (HttpWebResponse)response;
                    Console.WriteLine("Error code: {0}", ex);//httpResponse.StatusCode);
                    using (Stream data = response.GetResponseStream())
                    {
                        string text = new StreamReader(data).ReadToEnd();
                        Console.WriteLine(text);
                    }
                }
            }
        }

            /*
                        string Url = "https://api.imgur.com/oauth2/token/";
                        string DataTemplate = "client_id={0}&client_secret={1}&grant_type=pin&pin={2}";
                        string Data = String.Format(DataTemplate, clientId, clientSecret, pin);
            */
        
		private class LinkClickDelete : SourceGrid.Cells.Controllers.ControllerBase
		{
			public override void OnClick(SourceGrid.CellContext sender, EventArgs e)
			{
				base.OnClick(sender, e);

				SourceGrid.DataGrid grid = (SourceGrid.DataGrid)sender.Grid;
				grid.DeleteSelectedRows();
			}


		}


        private DataSet GetRESTData(string uri)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            var webResponse = (HttpWebResponse)webRequest.GetResponse();
            var reader = new StreamReader(webResponse.GetResponseStream());
            string json = reader.ReadToEnd();

            DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(json);

            DataTable dataTable = dataSet.Tables["termListDS"];

            Console.WriteLine(dataTable.Rows.Count);
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine(row["wordId"] + " - " + row["wordNm"]);
            }


            return dataSet; //JsonConvert.DeserializeObject<jarray>(s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string l_Path = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "tmpSourceGridExport.htm");

                using (System.IO.FileStream l_Stream = new System.IO.FileStream(l_Path, System.IO.FileMode.Create, System.IO.FileAccess.Write))
                {
                    SourceGrid.Exporter.HTML html = new SourceGrid.Exporter.HTML(SourceGrid.Exporter.ExportHTMLMode.Default, System.IO.Path.GetTempPath(), "", l_Stream);
                    html.Export(dataGrid);
                    l_Stream.Close();
                }

                DevAge.Shell.Utilities.OpenFile(l_Path);
            }
            catch (Exception err)
            {
                DevAge.Windows.Forms.ErrorDialog.Show(this, err, "HTML Export Error");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string l_Path = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "CsvFile.csv");

                using (System.IO.StreamWriter writer = new System.IO.StreamWriter(l_Path, false, System.Text.Encoding.Default))
                {
                    SourceGrid.Exporter.CSV csv = new SourceGrid.Exporter.CSV();
                    csv.Export(dataGrid, writer);
                    writer.Close();
                }

                DevAge.Shell.Utilities.OpenFile(l_Path);
            }
            catch (Exception err)
            {
                DevAge.Windows.Forms.ErrorDialog.Show(this, err, "CSV Export Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string l_Path = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "ImageFile.bmp");

                SourceGrid.Exporter.Image image = new SourceGrid.Exporter.Image();

                using (System.Drawing.Bitmap bitmap = image.Export(dataGrid, dataGrid.CompleteRange))
                {
                    bitmap.Save(l_Path);
                }

                DevAge.Shell.Utilities.OpenFile(l_Path);
            }
            catch (Exception err)
            {
                DevAge.Windows.Forms.ErrorDialog.Show(this, err, "BITMAP Export Error");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {   
            dataGrid.Enabled = !chkReadOnly.Checked;
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        /*
try
{
    dataGridView1.DataSource = GetRESTData("http://localhost:28642/api/inventoryitems/1/10");
}
catch (WebException webex)
{
    MessageBox.Show("Es gab so ein Schlamassel! ({0})", webex.Message);
}

         */
	}
}
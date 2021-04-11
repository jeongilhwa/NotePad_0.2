
namespace NotePad_0._1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새로만들기NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새창WToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.다른이름으로저장AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.끝내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.실행취소ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.붙여넣기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.BingSearchToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.FindToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.NextFindToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.PreviousToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.바꾸기RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.시간날짜DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.서식OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WordWrapToolMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FontToolMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.보기VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewSatusBar = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.LabelLineColumn = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.FormatFontDialog = new System.Windows.Forms.FontDialog();
            this.이동ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.모두선택ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "*.txt";
            this.OpenFileDialog1.Filter = "txt files (*.txt) |*.txt|All files(*.*)|*.*";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TextBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(914, 562);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.편집EToolStripMenuItem,
            this.서식OToolStripMenuItem,
            this.보기VToolStripMenuItem,
            this.도움말HToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(914, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DoubleClickEnabled = true;
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새로만들기NToolStripMenuItem,
            this.새창WToolStripMenuItem,
            this.열기OToolStripMenuItem,
            this.저장SToolStripMenuItem,
            this.다른이름으로저장AToolStripMenuItem,
            this.끝내기ToolStripMenuItem});
            this.파일FToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.파일FToolStripMenuItem.Text = "파일(&F)";
            // 
            // 새로만들기NToolStripMenuItem
            // 
            this.새로만들기NToolStripMenuItem.Name = "새로만들기NToolStripMenuItem";
            this.새로만들기NToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.새로만들기NToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.새로만들기NToolStripMenuItem.Text = "새로 만들기(&N)";
            this.새로만들기NToolStripMenuItem.Click += new System.EventHandler(this.새로만들기NToolStripMenuItem_Click);
            // 
            // 새창WToolStripMenuItem
            // 
            this.새창WToolStripMenuItem.Name = "새창WToolStripMenuItem";
            this.새창WToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.새창WToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.새창WToolStripMenuItem.Text = "새 창(&W)";
            this.새창WToolStripMenuItem.Click += new System.EventHandler(this.새창WToolStripMenuItem_Click);
            // 
            // 열기OToolStripMenuItem
            // 
            this.열기OToolStripMenuItem.Name = "열기OToolStripMenuItem";
            this.열기OToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.열기OToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.열기OToolStripMenuItem.Text = "열기(&O)";
            this.열기OToolStripMenuItem.Click += new System.EventHandler(this.열기OToolStripMenuItem_Click);
            // 
            // 저장SToolStripMenuItem
            // 
            this.저장SToolStripMenuItem.Name = "저장SToolStripMenuItem";
            this.저장SToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.저장SToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.저장SToolStripMenuItem.Text = "저장(&S)";
            this.저장SToolStripMenuItem.Click += new System.EventHandler(this.저장SToolStripMenuItem_Click);
            // 
            // 다른이름으로저장AToolStripMenuItem
            // 
            this.다른이름으로저장AToolStripMenuItem.Name = "다른이름으로저장AToolStripMenuItem";
            this.다른이름으로저장AToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.다른이름으로저장AToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.다른이름으로저장AToolStripMenuItem.Text = "다른이름으로 저장(&A)";
            this.다른이름으로저장AToolStripMenuItem.Click += new System.EventHandler(this.다른이름으로저장AToolStripMenuItem_Click);
            // 
            // 끝내기ToolStripMenuItem
            // 
            this.끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
            this.끝내기ToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.끝내기ToolStripMenuItem.Text = "끝내기(&X)";
            this.끝내기ToolStripMenuItem.Click += new System.EventHandler(this.끝내기ToolStripMenuItem_Click);
            // 
            // 편집EToolStripMenuItem
            // 
            this.편집EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.실행취소ToolStripMenuItem,
            this.CutToolStrip,
            this.CopyToolStrip,
            this.붙여넣기ToolStripMenuItem,
            this.DeleteToolStrip,
            this.BingSearchToolStrip,
            this.FindToolStrip,
            this.NextFindToolStrip,
            this.PreviousToolStrip,
            this.바꾸기RToolStripMenuItem,
            this.이동ToolStripMenuItem,
            this.모두선택ToolStripMenuItem,
            this.시간날짜DToolStripMenuItem});
            this.편집EToolStripMenuItem.Name = "편집EToolStripMenuItem";
            this.편집EToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.편집EToolStripMenuItem.Text = "편집(&E)";
            // 
            // 실행취소ToolStripMenuItem
            // 
            this.실행취소ToolStripMenuItem.Name = "실행취소ToolStripMenuItem";
            this.실행취소ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.실행취소ToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.실행취소ToolStripMenuItem.Tag = "Undo";
            this.실행취소ToolStripMenuItem.Text = "실행 취소(&U)";
            this.실행취소ToolStripMenuItem.Click += new System.EventHandler(this.EditMenu_Click);
            // 
            // CutToolStrip
            // 
            this.CutToolStrip.Name = "CutToolStrip";
            this.CutToolStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.CutToolStrip.Size = new System.Drawing.Size(245, 26);
            this.CutToolStrip.Tag = "Cut";
            this.CutToolStrip.Text = "잘라내기(&T)";
            this.CutToolStrip.Click += new System.EventHandler(this.EditMenu_Click);
            // 
            // CopyToolStrip
            // 
            this.CopyToolStrip.Name = "CopyToolStrip";
            this.CopyToolStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyToolStrip.Size = new System.Drawing.Size(245, 26);
            this.CopyToolStrip.Tag = "Copy";
            this.CopyToolStrip.Text = "복사(&C)";
            this.CopyToolStrip.Click += new System.EventHandler(this.EditMenu_Click);
            // 
            // 붙여넣기ToolStripMenuItem
            // 
            this.붙여넣기ToolStripMenuItem.Name = "붙여넣기ToolStripMenuItem";
            this.붙여넣기ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.붙여넣기ToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.붙여넣기ToolStripMenuItem.Tag = "Paste";
            this.붙여넣기ToolStripMenuItem.Text = "붙여넣기(&P)";
            this.붙여넣기ToolStripMenuItem.Click += new System.EventHandler(this.EditMenu_Click);
            // 
            // DeleteToolStrip
            // 
            this.DeleteToolStrip.Name = "DeleteToolStrip";
            this.DeleteToolStrip.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.DeleteToolStrip.Size = new System.Drawing.Size(245, 26);
            this.DeleteToolStrip.Tag = "Delete";
            this.DeleteToolStrip.Text = "삭제(&L)";
            this.DeleteToolStrip.Click += new System.EventHandler(this.EditMenu_Click);
            // 
            // BingSearchToolStrip
            // 
            this.BingSearchToolStrip.Name = "BingSearchToolStrip";
            this.BingSearchToolStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.BingSearchToolStrip.Size = new System.Drawing.Size(245, 26);
            this.BingSearchToolStrip.Tag = "BingSearch";
            this.BingSearchToolStrip.Text = "Bing으로검색(&S)";
            this.BingSearchToolStrip.Click += new System.EventHandler(this.EditMenu_Click);
            // 
            // FindToolStrip
            // 
            this.FindToolStrip.Name = "FindToolStrip";
            this.FindToolStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.FindToolStrip.Size = new System.Drawing.Size(245, 26);
            this.FindToolStrip.Text = "찾기(&F)";
            this.FindToolStrip.Click += new System.EventHandler(this.찾기FToolStripMenuItem_Click);
            // 
            // NextFindToolStrip
            // 
            this.NextFindToolStrip.Name = "NextFindToolStrip";
            this.NextFindToolStrip.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.NextFindToolStrip.Size = new System.Drawing.Size(245, 26);
            this.NextFindToolStrip.Text = "다음찾기(&N)";
            this.NextFindToolStrip.Click += new System.EventHandler(this.다음찾기NToolStripMenuItem_Click);
            // 
            // PreviousToolStrip
            // 
            this.PreviousToolStrip.Name = "PreviousToolStrip";
            this.PreviousToolStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F3)));
            this.PreviousToolStrip.Size = new System.Drawing.Size(245, 26);
            this.PreviousToolStrip.Text = "이전찾기(&V)";
            this.PreviousToolStrip.Click += new System.EventHandler(this.이전찾기VToolStripMenuItem_Click);
            // 
            // 바꾸기RToolStripMenuItem
            // 
            this.바꾸기RToolStripMenuItem.Name = "바꾸기RToolStripMenuItem";
            this.바꾸기RToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.바꾸기RToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.바꾸기RToolStripMenuItem.Text = "바꾸기(&R)";
            this.바꾸기RToolStripMenuItem.Click += new System.EventHandler(this.바꾸기RToolStripMenuItem_Click);
            // 
            // 시간날짜DToolStripMenuItem
            // 
            this.시간날짜DToolStripMenuItem.Name = "시간날짜DToolStripMenuItem";
            this.시간날짜DToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.시간날짜DToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.시간날짜DToolStripMenuItem.Text = "시간/날짜(&D)";
            this.시간날짜DToolStripMenuItem.Click += new System.EventHandler(this.시간날짜DToolStripMenuItem_Click);
            // 
            // 서식OToolStripMenuItem
            // 
            this.서식OToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WordWrapToolMenu,
            this.FontToolMenu});
            this.서식OToolStripMenuItem.Name = "서식OToolStripMenuItem";
            this.서식OToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.서식OToolStripMenuItem.Text = "서식(O)";
            // 
            // WordWrapToolMenu
            // 
            this.WordWrapToolMenu.Checked = true;
            this.WordWrapToolMenu.CheckOnClick = true;
            this.WordWrapToolMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WordWrapToolMenu.Name = "WordWrapToolMenu";
            this.WordWrapToolMenu.Size = new System.Drawing.Size(216, 26);
            this.WordWrapToolMenu.Tag = "WordWrap";
            this.WordWrapToolMenu.Text = "자동 줄 바꿈(&W)";
            this.WordWrapToolMenu.Click += new System.EventHandler(this.Format_Click);
            // 
            // FontToolMenu
            // 
            this.FontToolMenu.Name = "FontToolMenu";
            this.FontToolMenu.Size = new System.Drawing.Size(216, 26);
            this.FontToolMenu.Tag = "Font";
            this.FontToolMenu.Text = "글꼴";
            this.FontToolMenu.Click += new System.EventHandler(this.Format_Click);
            // 
            // 보기VToolStripMenuItem
            // 
            this.보기VToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewSatusBar});
            this.보기VToolStripMenuItem.Name = "보기VToolStripMenuItem";
            this.보기VToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.보기VToolStripMenuItem.Text = "보기(V)";
            // 
            // ViewSatusBar
            // 
            this.ViewSatusBar.Checked = true;
            this.ViewSatusBar.CheckOnClick = true;
            this.ViewSatusBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ViewSatusBar.Name = "ViewSatusBar";
            this.ViewSatusBar.Size = new System.Drawing.Size(216, 26);
            this.ViewSatusBar.Text = "상태 표시줄(&S)";
            this.ViewSatusBar.Click += new System.EventHandler(this.상태표시줄SToolStripMenuItem_Click);
            // 
            // 도움말HToolStripMenuItem
            // 
            this.도움말HToolStripMenuItem.Name = "도움말HToolStripMenuItem";
            this.도움말HToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.도움말HToolStripMenuItem.Text = "도움말(H)";
            // 
            // TextBox1
            // 
            this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox1.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.TextBox1.HideSelection = false;
            this.TextBox1.Location = new System.Drawing.Point(0, 32);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBox1.Size = new System.Drawing.Size(914, 503);
            this.TextBox1.TabIndex = 5;
            this.TextBox1.TabStop = false;
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.TextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyDown);
            this.TextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyUp);
            this.TextBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TextBox1_MouseUp);
            // 
            // statusStrip2
            // 
            this.statusStrip2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statusStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabelLineColumn,
            this.toolStripStatusLabel5});
            this.statusStrip2.Location = new System.Drawing.Point(595, 537);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip2.Size = new System.Drawing.Size(319, 25);
            this.statusStrip2.TabIndex = 11;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // LabelLineColumn
            // 
            this.LabelLineColumn.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.LabelLineColumn.Name = "LabelLineColumn";
            this.LabelLineColumn.Size = new System.Drawing.Size(152, 20);
            this.LabelLineColumn.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel5.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.toolStripStatusLabel5.Margin = new System.Windows.Forms.Padding(0, 3, 10, 2);
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(138, 20);
            this.toolStripStatusLabel5.Text = "Windows(CRLF)";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "제목 없음.txt";
            this.saveFileDialog1.Filter = "txt files (*.txt) |*.txt|All files(*.*)|*.*";
            this.saveFileDialog1.InitialDirectory = "Application.StartupPath;";
            // 
            // 이동ToolStripMenuItem
            // 
            this.이동ToolStripMenuItem.Name = "이동ToolStripMenuItem";
            this.이동ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.이동ToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.이동ToolStripMenuItem.Text = "이동(&G)";
            this.이동ToolStripMenuItem.Click += new System.EventHandler(this.이동ToolStripMenuItem_Click);
            // 
            // 모두선택ToolStripMenuItem
            // 
            this.모두선택ToolStripMenuItem.Name = "모두선택ToolStripMenuItem";
            this.모두선택ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.모두선택ToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.모두선택ToolStripMenuItem.Text = "모두선택(&A)";
            this.모두선택ToolStripMenuItem.Click += new System.EventHandler(this.모두선택ToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "fileName";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새로만들기NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새창WToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 다른이름으로저장AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 편집EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 서식OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 보기VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStrip;
        private System.Windows.Forms.ToolStripMenuItem BingSearchToolStrip;
        private System.Windows.Forms.ToolStripMenuItem FindToolStrip;
        private System.Windows.Forms.ToolStripMenuItem NextFindToolStrip;
        private System.Windows.Forms.ToolStripMenuItem PreviousToolStrip;
        private System.Windows.Forms.ToolStripMenuItem 바꾸기RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 끝내기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 실행취소ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CutToolStrip;
        private System.Windows.Forms.ToolStripMenuItem CopyToolStrip;
        private System.Windows.Forms.ToolStripMenuItem 붙여넣기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WordWrapToolMenu;
        private System.Windows.Forms.ToolStripMenuItem FontToolMenu;
        private System.Windows.Forms.FontDialog FormatFontDialog;
        private System.Windows.Forms.ToolStripMenuItem ViewSatusBar;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel LabelLineColumn;
        private System.Windows.Forms.ToolStripMenuItem 시간날짜DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 이동ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 모두선택ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}


namespace CW_File_Viewer_3._0
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.filev = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewfile = new System.Windows.Forms.Button();
            this.folderbroser = new System.Windows.Forms.FolderBrowserDialog();
            this.sfpath = new System.Windows.Forms.Label();
            this.recover = new System.Windows.Forms.Button();
            this.write = new System.Windows.Forms.Button();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.del = new System.Windows.Forms.Button();
            this.cut = new System.Windows.Forms.Button();
            this.filename = new System.Windows.Forms.TextBox();
            this.rename = new System.Windows.Forms.Button();
            this.newfile = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.lrcv = new System.Windows.Forms.TextBox();
            this.copy = new System.Windows.Forms.Button();
            this.past = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cutch = new System.Windows.Forms.TextBox();
            this.delc = new System.Windows.Forms.Button();
            this.dele = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.wtsize = new System.Windows.Forms.TextBox();
            this.cutadd = new System.Windows.Forms.TextBox();
            this.small = new System.Windows.Forms.Button();
            this.big = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.sort1 = new System.Windows.Forms.RadioButton();
            this.sort2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // filev
            // 
            this.filev.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.filev.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filev.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.filev.Font = new System.Drawing.Font("宋体", 10F);
            this.filev.GridLines = true;
            this.filev.Location = new System.Drawing.Point(13, 46);
            this.filev.Margin = new System.Windows.Forms.Padding(4);
            this.filev.Name = "filev";
            this.filev.Size = new System.Drawing.Size(367, 591);
            this.filev.TabIndex = 21;
            this.filev.UseCompatibleStateImageBehavior = false;
            this.filev.View = System.Windows.Forms.View.Details;
            this.filev.SelectedIndexChanged += new System.EventHandler(this.filev_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "文件名";
            this.columnHeader1.Width = 549;
            // 
            // viewfile
            // 
            this.viewfile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.viewfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewfile.ForeColor = System.Drawing.Color.Black;
            this.viewfile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.viewfile.Location = new System.Drawing.Point(13, 12);
            this.viewfile.Margin = new System.Windows.Forms.Padding(4);
            this.viewfile.Name = "viewfile";
            this.viewfile.Size = new System.Drawing.Size(71, 25);
            this.viewfile.TabIndex = 20;
            this.viewfile.Text = "浏览";
            this.viewfile.UseVisualStyleBackColor = false;
            this.viewfile.Click += new System.EventHandler(this.viewfile_Click);
            // 
            // sfpath
            // 
            this.sfpath.AutoSize = true;
            this.sfpath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sfpath.Location = new System.Drawing.Point(232, 17);
            this.sfpath.Name = "sfpath";
            this.sfpath.Size = new System.Drawing.Size(39, 15);
            this.sfpath.TabIndex = 23;
            this.sfpath.Text = "None";
            // 
            // recover
            // 
            this.recover.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.recover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(14)))));
            this.recover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recover.Location = new System.Drawing.Point(677, 643);
            this.recover.Name = "recover";
            this.recover.Size = new System.Drawing.Size(70, 40);
            this.recover.TabIndex = 26;
            this.recover.Text = "还原";
            this.recover.UseVisualStyleBackColor = false;
            this.recover.Click += new System.EventHandler(this.recover_Click);
            // 
            // write
            // 
            this.write.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.write.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(80)))));
            this.write.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.write.ForeColor = System.Drawing.Color.Black;
            this.write.Location = new System.Drawing.Point(387, 643);
            this.write.Name = "write";
            this.write.Size = new System.Drawing.Size(70, 40);
            this.write.TabIndex = 27;
            this.write.Text = "保存";
            this.write.UseVisualStyleBackColor = false;
            this.write.Click += new System.EventHandler(this.write_Click);
            // 
            // player
            // 
            this.player.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(387, 46);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(943, 62);
            this.player.TabIndex = 28;
            this.player.Enter += new System.EventHandler(this.player_StatusChange);
            // 
            // del
            // 
            this.del.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del.Location = new System.Drawing.Point(859, 643);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(70, 40);
            this.del.TabIndex = 27;
            this.del.Text = "删除";
            this.del.UseVisualStyleBackColor = false;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // cut
            // 
            this.cut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cut.ForeColor = System.Drawing.Color.Black;
            this.cut.Location = new System.Drawing.Point(463, 643);
            this.cut.Name = "cut";
            this.cut.Size = new System.Drawing.Size(70, 40);
            this.cut.TabIndex = 27;
            this.cut.Text = "分割";
            this.cut.UseVisualStyleBackColor = false;
            this.cut.Click += new System.EventHandler(this.cut_Click);
            // 
            // filename
            // 
            this.filename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filename.Font = new System.Drawing.Font("宋体", 10F);
            this.filename.Location = new System.Drawing.Point(387, 110);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(771, 27);
            this.filename.TabIndex = 29;
            this.filename.TextChanged += new System.EventHandler(this.filename_TextChanged);
            // 
            // rename
            // 
            this.rename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rename.Location = new System.Drawing.Point(1250, 108);
            this.rename.Name = "rename";
            this.rename.Size = new System.Drawing.Size(80, 30);
            this.rename.TabIndex = 30;
            this.rename.Text = "重命名";
            this.rename.UseVisualStyleBackColor = true;
            this.rename.Click += new System.EventHandler(this.rename_Click);
            // 
            // newfile
            // 
            this.newfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newfile.Location = new System.Drawing.Point(1164, 108);
            this.newfile.Name = "newfile";
            this.newfile.Size = new System.Drawing.Size(80, 30);
            this.newfile.TabIndex = 31;
            this.newfile.Text = "新建";
            this.newfile.UseVisualStyleBackColor = true;
            this.newfile.Click += new System.EventHandler(this.newfile_Click);
            // 
            // refresh
            // 
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Location = new System.Drawing.Point(91, 12);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(71, 25);
            this.refresh.TabIndex = 32;
            this.refresh.Text = "刷新";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // lrcv
            // 
            this.lrcv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lrcv.BackColor = System.Drawing.Color.White;
            this.lrcv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lrcv.Font = new System.Drawing.Font("宋体", 12F);
            this.lrcv.ForeColor = System.Drawing.Color.Black;
            this.lrcv.Location = new System.Drawing.Point(387, 138);
            this.lrcv.Multiline = true;
            this.lrcv.Name = "lrcv";
            this.lrcv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lrcv.Size = new System.Drawing.Size(943, 499);
            this.lrcv.TabIndex = 33;
            this.lrcv.TextChanged += new System.EventHandler(this.lrcv_TextChanged);
            // 
            // copy
            // 
            this.copy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copy.Location = new System.Drawing.Point(753, 643);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(47, 40);
            this.copy.TabIndex = 34;
            this.copy.Text = "复制";
            this.copy.UseVisualStyleBackColor = true;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // past
            // 
            this.past.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.past.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.past.Location = new System.Drawing.Point(804, 643);
            this.past.Name = "past";
            this.past.Size = new System.Drawing.Size(47, 40);
            this.past.TabIndex = 35;
            this.past.Text = "粘贴";
            this.past.UseVisualStyleBackColor = true;
            this.past.Click += new System.EventHandler(this.past_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1084, 643);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 36;
            this.label1.Text = "分割字符：";
            // 
            // cutch
            // 
            this.cutch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cutch.Location = new System.Drawing.Point(1087, 658);
            this.cutch.Name = "cutch";
            this.cutch.Size = new System.Drawing.Size(162, 25);
            this.cutch.TabIndex = 37;
            this.cutch.Text = ".!?;:。！？";
            this.cutch.TextChanged += new System.EventHandler(this.cutch_TextChanged);
            // 
            // delc
            // 
            this.delc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.delc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.delc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delc.Location = new System.Drawing.Point(935, 643);
            this.delc.Name = "delc";
            this.delc.Size = new System.Drawing.Size(70, 40);
            this.delc.TabIndex = 38;
            this.delc.Text = "去中文";
            this.delc.UseVisualStyleBackColor = false;
            this.delc.Click += new System.EventHandler(this.delc_Click);
            // 
            // dele
            // 
            this.dele.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.dele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dele.Location = new System.Drawing.Point(1011, 643);
            this.dele.Name = "dele";
            this.dele.Size = new System.Drawing.Size(70, 40);
            this.dele.TabIndex = 39;
            this.dele.Text = "去英文";
            this.dele.UseVisualStyleBackColor = false;
            this.dele.Click += new System.EventHandler(this.dele_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(536, 643);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 42;
            this.label2.Text = "文件夹名：";
            // 
            // wtsize
            // 
            this.wtsize.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.wtsize.Location = new System.Drawing.Point(1281, 658);
            this.wtsize.Name = "wtsize";
            this.wtsize.Size = new System.Drawing.Size(23, 25);
            this.wtsize.TabIndex = 44;
            this.wtsize.Text = "12";
            this.wtsize.TextChanged += new System.EventHandler(this.wtsize_TextChanged);
            // 
            // cutadd
            // 
            this.cutadd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cutadd.Location = new System.Drawing.Point(539, 658);
            this.cutadd.Name = "cutadd";
            this.cutadd.Size = new System.Drawing.Size(132, 25);
            this.cutadd.TabIndex = 45;
            this.cutadd.Text = " - cut";
            this.cutadd.TextChanged += new System.EventHandler(this.cutadd_TextChanged);
            // 
            // small
            // 
            this.small.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.small.BackgroundImage = global::CW_File_Viewer_3._0.Properties.Resources.down;
            this.small.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.small.Location = new System.Drawing.Point(1305, 658);
            this.small.Name = "small";
            this.small.Size = new System.Drawing.Size(25, 25);
            this.small.TabIndex = 41;
            this.small.UseVisualStyleBackColor = true;
            this.small.Click += new System.EventHandler(this.small_Click);
            // 
            // big
            // 
            this.big.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.big.BackgroundImage = global::CW_File_Viewer_3._0.Properties.Resources.up;
            this.big.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.big.Location = new System.Drawing.Point(1255, 658);
            this.big.Name = "big";
            this.big.Size = new System.Drawing.Size(25, 25);
            this.big.TabIndex = 40;
            this.big.UseVisualStyleBackColor = true;
            this.big.Click += new System.EventHandler(this.big_Click);
            // 
            // next
            // 
            this.next.BackgroundImage = global::CW_File_Viewer_3._0.Properties.Resources.next;
            this.next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.next.Location = new System.Drawing.Point(201, 12);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(25, 25);
            this.next.TabIndex = 25;
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // back
            // 
            this.back.BackgroundImage = global::CW_File_Viewer_3._0.Properties.Resources.back;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Location = new System.Drawing.Point(170, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(25, 25);
            this.back.TabIndex = 24;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // sort1
            // 
            this.sort1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sort1.AutoSize = true;
            this.sort1.Checked = true;
            this.sort1.Location = new System.Drawing.Point(12, 644);
            this.sort1.Name = "sort1";
            this.sort1.Size = new System.Drawing.Size(118, 19);
            this.sort1.TabIndex = 46;
            this.sort1.TabStop = true;
            this.sort1.Tag = "";
            this.sort1.Text = "按文件名排序";
            this.sort1.UseVisualStyleBackColor = true;
            this.sort1.CheckedChanged += new System.EventHandler(this.sort1_CheckedChanged);
            // 
            // sort2
            // 
            this.sort2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sort2.AutoSize = true;
            this.sort2.Location = new System.Drawing.Point(12, 666);
            this.sort2.Name = "sort2";
            this.sort2.Size = new System.Drawing.Size(118, 19);
            this.sort2.TabIndex = 47;
            this.sort2.TabStop = true;
            this.sort2.Text = "按后缀名排序";
            this.sort2.UseVisualStyleBackColor = true;
            this.sort2.CheckedChanged += new System.EventHandler(this.sort2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 695);
            this.Controls.Add(this.filev);
            this.Controls.Add(this.sort2);
            this.Controls.Add(this.sort1);
            this.Controls.Add(this.cutadd);
            this.Controls.Add(this.wtsize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.small);
            this.Controls.Add(this.big);
            this.Controls.Add(this.dele);
            this.Controls.Add(this.delc);
            this.Controls.Add(this.cutch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.past);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.lrcv);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.newfile);
            this.Controls.Add(this.rename);
            this.Controls.Add(this.filename);
            this.Controls.Add(this.player);
            this.Controls.Add(this.viewfile);
            this.Controls.Add(this.next);
            this.Controls.Add(this.back);
            this.Controls.Add(this.sfpath);
            this.Controls.Add(this.recover);
            this.Controls.Add(this.cut);
            this.Controls.Add(this.del);
            this.Controls.Add(this.write);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CW File Viewer 3.0.4";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView filev;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button viewfile;
        private System.Windows.Forms.FolderBrowserDialog folderbroser;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label sfpath;
        private System.Windows.Forms.Button recover;
        private System.Windows.Forms.Button write;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button cut;
        private System.Windows.Forms.TextBox filename;
        private System.Windows.Forms.Button rename;
        private System.Windows.Forms.Button newfile;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.TextBox lrcv;
        private System.Windows.Forms.Button copy;
        private System.Windows.Forms.Button past;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cutch;
        private System.Windows.Forms.Button delc;
        private System.Windows.Forms.Button dele;
        private System.Windows.Forms.Button big;
        private System.Windows.Forms.Button small;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox wtsize;
        private System.Windows.Forms.TextBox cutadd;
        private System.Windows.Forms.RadioButton sort1;
        private System.Windows.Forms.RadioButton sort2;
    }
}


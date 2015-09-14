using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CW_File_Viewer_3._0
{

    public partial class Form1 : Form
    {
        /*
         * c : class
         * f : place
        */
        // fpath = folderbroser.ShowDialog;
        string fname, nfname, last, infile, backup, filepath, lfile, ntfile, copypath, copyfn, cuts,cuta;
        string[] fpos = new string[1000];

        string[] cname = new string[100000];
        string[] cpath = new string[100000];
        string[] clast = new string[100000];
        int[] cmode = new int[100000];//1:file  2:folder

        bool firsto = false;
        int nowp = 0, maxn;

        int i, j, p = 0, l, js, cutn = 8,wsize=12,fsum,smode=1;

        char[] cutc = new char[20];
        char[] a = new char[100000];
        char[] ls1 = new char[1];
        char[] ls2 = new char[1];

        //string lins;
        public Form1()
        {
            InitializeComponent();
        }
        bool pd()
        {
            if (j < l)
            {
                ls1[0] = a[j];
                string lins1 = new string(ls1);
                /*
                if (a[k] == '.')
                {
                    MessageBox.Show(lins, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                    if (lins == ".")
                        MessageBox.Show(lins, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
                */
                int lsi;
                for (lsi = 0; lsi < cutn; ++lsi)
                {
                    //ls2[0] = cutc[lsi];
                    //string lins2 = new string(ls2);

                    //string baga = new string(ls1);
                    if (cutc[lsi] == '段')
                    {
                        if (a[j] == '\n')
                            return true;
                    }
                    else
                    {
                        //MessageBox.Show("j : " + j.ToString() + "\n" + "lins1 : " + lins1 + "\n" + "lins2 : " + lins2, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                        //MessageBox.Show("lsi : " + lsi.ToString() + "\n" + "lins1 : " + lins1 + "\n" + "lins2 : " + lins2, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                        //MessageBox.Show(lsi.ToString(), "提示", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                        //MessageBox.Show(infile, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                        //MessageBox.Show(baga, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        //MessageBox.Show("a[j] : " + a[j].ToString() + "\n" + "cutc[lsi] : " + cutc[lsi].ToString() + "\n" + "lsi : " + lsi.ToString() + "\n" + "lins1 : " + lins1 + "\n" + "lins2 : " + lins2, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (a[j] == cutc[lsi])
                        {
                            //MessageBox.Show(infile, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                            if (j < l - 1)
                            {
                                //ls2[0] = a[j + 1];
                                //lins2 = new string(ls2);
                                while (i < l - 1 && (a[j + 1] == '\"' || a[j + 1] == '”' || a[j + 1] == '\''))
                                {
                                    ++j;
                                }
                            }
                            return true;
                        }
                    }
                }
                /*
            else
            {
                ls[0] = a[k];
                ls[1] = a[k + 1];
                ls[2] = '\0';
                string lins = new string(ls);
                MessageBox.Show(lins, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (lins=="。" || lins=="！" || lins=="？")
                {
                    ++j;
                    p = 1;
                    ls[0] = a[k + 2];
                    ls[1] = a[k + 3];
                    ls[2] = '\0';
                    if (lins=="”")
                        j += 2;
                    return true;
                }
            }
                 * */
            }
            return false;
        }
        int pdc(char px)
        {
            /*
             * English : 1
             * Number  : 2
             * symbol  : 3
             * Chinese : 4
             * Other   : 5
            */
            if ((px >= 'a' && px <= 'z') || (px >= 'A' && px <= 'Z'))
                return 1;
            if (px >= '0' && px <= '9')
                return 2;
            if (px == '@' || px == '#' || px == '$' || px == '%' || px == '^' || px == '&' || px == '*' || px == '+' || px == '[' || px == ']' || px == '<' || px == '>' || px == '=' || px == '_' || px == '`' || px == '~' || px == ',' || px == ' ' || px == '.' || px == '?' || px == '!' || px == '(' || px == ')' || px == '\"' || px == '\'' || px == ';' || px == ':' || px == '-')
                return 3;
            ls1[0]=px;
            string lins1=new string(ls1);
            //code = Char.ConvertToUtf32(px, px);    //获得字符串input中指定索引index处字符unicode编码
            if (px>128)
                return 4;
            return 5;
        }
        void reffile(string path, int mode)
        {
            filev.Items.Clear();
            fsum = 0;
            DirectoryInfo dinfo = new DirectoryInfo(path);
            //获取指定目录下的所有子目录及文件类型
            FileSystemInfo[] fsinfos = dinfo.GetFileSystemInfos();
            foreach (FileSystemInfo fsinfo in fsinfos)
            {
                if (fsinfo is DirectoryInfo)
                {
                    DirectoryInfo dirinfo = new DirectoryInfo(fsinfo.FullName);
                    cname[fsum] = dirinfo.Name;
                    cpath[fsum] = path + '\\' + cname[fsum];
                    cmode[fsum] = 2;
                }
                else
                {
                    //使用获取的文件名称实例化FileInfo对象
                    FileInfo finfo = new FileInfo(fsinfo.FullName);
                    cname[fsum] = fsinfo.Name;
                    cpath[fsum] = path + '\\' + cname[fsum];
                    clast[fsum] = Path.GetExtension(cpath[fsum]);
                    cmode[fsum] = 1;
                }
                ++fsum;
            }
            string lins;
            int ils;
            if (mode == 1)
            {
                for (i = 1; i < fsum; ++i)
                    for (j = i + 1; j <= fsum; ++j)
                        if (String.Compare(cname[i], cname[j]) > 0)
                        {
                            lins = cname[i];
                            cname[i] = cname[j];
                            cname[j] = lins;

                            lins = cpath[i];
                            cpath[i] = cpath[j];
                            cpath[j] = lins;

                            lins = clast[i];
                            clast[i] = clast[j];
                            clast[j] = lins;

                            ils = cmode[i];
                            cmode[i] = cmode[j];
                            cmode[j] = ils;
                        }
            }
            else if (mode == 2)
            {
                for (i = 1; i < fsum; ++i)
                    for (j = i + 1; j <= fsum; ++j)
                        if (String.Compare(clast[i], clast[j]) > 0)
                        {
                            lins = cname[i];
                            cname[i] = cname[j];
                            cname[j] = lins;

                            lins = cpath[i];
                            cpath[i] = cpath[j];
                            cpath[j] = lins;

                            lins = clast[i];
                            clast[i] = clast[j];
                            clast[j] = lins;

                            ils = cmode[i];
                            cmode[i] = cmode[j];
                            cmode[j] = ils;
                        }
            }
            filev.Items.Clear();
            for (i=0;i<fsum;++i)
            {
                filev.Items.Add(cname[i]);
                //filev.Items[filev.Items.Count - 1].SubItems.Add(cname[i]);
            }
        }

        private void filev_SelectedIndexChanged(object sender, EventArgs e)
        {
            // MessageBox.Show(path, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (this.filev.SelectedItems.Count > 0)
            {
                fname = this.filev.SelectedItems[0].Text;
                fpos[nowp + 1] = fpos[nowp] + '\\' + fname;
                //MessageBox.Show(path, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //folderbroser.SelectedPath = folderbroser.SelectedPath;
                //实例化DirectoryInfo对象

                last = Path.GetExtension(fpos[nowp + 1]);

                this.sfpath.Text = fpos[nowp + 1];
                //获取指定目录下的所有子目录及文件类型
                if (Directory.Exists(fpos[nowp + 1]))
                {
                    ++nowp;
                    maxn = maxn > nowp ? maxn : nowp;
                    //MessageBox.Show(fpos[nowp], "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    reffile(fpos[nowp],smode);
                }
                else
                {
                    lfile = fpos[nowp + 1];
                    //MessageBox.Show(cfile, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    filename.Text = fname;
                    //last;
                    if (last == ".lrc" || last == ".txt" || last == ".LRC" || last == ".TXT")
                    {
                        ntfile = lfile;
                        if (firsto == true)
                        {
                            if (backup != infile)
                            {
                                if (MessageBox.Show("文件已更改，是否保存", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    if (last == ".txt" || last == ".TXT")
                                        File.WriteAllText(filepath, infile, Encoding.GetEncoding("GB2312"));
                                    else
                                        File.WriteAllText(filepath, infile);
                                    backup = infile;
                                }
                            }
                        }
                        else
                            firsto = true;
                        if (last == ".lrc" || last == ".LRC")
                        {
                            //lrcv.Text = System.IO.File.ReadAllText(path);
                            StreamReader fileread = new StreamReader(fpos[nowp + 1]);//StreamReader sr = new StreamReader("TestFile.txt",Encoding.GetEncoding("GB2312"))
                            //StreamReader fileread = new StreamReader(path, Encoding.Default);
                            //StreamReader fileread = new StreamReader(path, Encoding.UTF8);
                            //StreamReader fileread = new StreamReader(path, Encoding.GetEncoding("gb2312"));
                            infile = fileread.ReadToEnd();
                            lrcv.Text = infile;
                            backup = infile;
                            filepath = fpos[nowp + 1];
                            fileread.Close();
                            //MessageBox.Show(infile, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        }
                        else if (last == ".txt" || last == ".TXT")
                        {
                            //lrcv.Text = System.IO.File.ReadAllText(path);
                            //StreamReader fileread = new StreamReader(fpos[nowp + 1]);
                            StreamReader fileread = new StreamReader(fpos[nowp + 1], Encoding.GetEncoding("GB2312"));
                            //StreamReader fileread = new StreamReader(path, Encoding.Default);
                            //StreamReader fileread = new StreamReader(path, Encoding.UTF8);
                            //StreamReader fileread = new StreamReader(path, Encoding.GetEncoding("gb2312"));
                            infile = fileread.ReadToEnd();
                            lrcv.Text = infile;
                            backup = infile;
                            filepath = fpos[nowp + 1];
                            fileread.Close();
                            //MessageBox.Show(infile, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        }
                        a = infile.ToCharArray();
                        l = infile.Length;
                    }
                    else if (last == ".mp3")
                    {
                        this.player.URL = fpos[nowp + 1];
                    }
                    else//if(last==".doc" || last==".docx" || last==".ppt" || last==".pptx" || last==".xls" || last==".xlsx")
                        System.Diagnostics.Process.Start(fpos[nowp + 1]);
                }
            }
        }

        private void viewfile_Click(object sender, EventArgs e)
        {
            if (folderbroser.ShowDialog() == DialogResult.OK)
            {
                folderbroser.SelectedPath = folderbroser.SelectedPath;
                fpos[++nowp] = folderbroser.SelectedPath;
                maxn = maxn > nowp ? maxn : nowp;
                sfpath.Text = fpos[nowp];
                //实例化DirectoryInfo对象
                reffile(fpos[nowp],smode);
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void lrcv_TextChanged(object sender, EventArgs e)
        {
            infile = lrcv.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filepath = "Null";
            lfile = "Null";
            copypath = "Null";
            cuts = ".!?;:。！？";
            cuta = " - cut";
            wtsize.Text = wsize.ToString();
            cutc = cuts.ToCharArray();
            //this.lrcv.Text = System.IO.File.ReadAllText("C:\\Users\\david\\Desktop\\superbaga.lrc");
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (nowp > 1)
            {
                --nowp;
                sfpath.Text = fpos[nowp];
                reffile(fpos[nowp],smode);
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (nowp < maxn)
            {
                ++nowp;
                sfpath.Text = fpos[nowp];
                reffile(fpos[nowp],smode);
            }
        }

        private void write_Click(object sender, EventArgs e)
        {
            /*
            FileStream clear = File.Create(filepath);
            clear.Close();
            FileInfo files = new FileInfo(filepath);
            StreamWriter save = files.CreateText();
            save.Write(infile);
            save.Close();
             */
            if (nowp > 0)
            {
                if (filepath != "")
                {
                    if (last == ".txt" || last == ".TXT")
                        File.WriteAllText(filepath, infile, Encoding.GetEncoding("GB2312"));
                    else
                        File.WriteAllText(filepath, infile);
                    backup = infile;
                }
                else
                    MessageBox.Show("未选择文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("未选择目录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void recover_Click(object sender, EventArgs e)
        {
            infile = backup;
            lrcv.Text = infile;
        }

        private void rename_Click(object sender, EventArgs e)
        {
            if (filepath != "Null")
            {
                if (MessageBox.Show("确定重命名？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    File.Move(fpos[nowp + 1], fpos[nowp] + '\\' + nfname);
                    fname = nfname;

                    reffile(fpos[nowp],smode);
                }
            }
            else
                MessageBox.Show("未选中文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void filename_TextChanged(object sender, EventArgs e)
        {
            nfname = filename.Text;
        }

        private void del_Click(object sender, EventArgs e)
        {
            if (filepath != "Null")
            {
                File.Delete(lfile);
                reffile(fpos[nowp], smode);
            }
            else
                MessageBox.Show("未选中文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void newfile_Click(object sender, EventArgs e)
        {
            if (File.Exists(fpos[nowp] + '\\' + filename.Text) == true)
                MessageBox.Show("文件已存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (filename.Text == "")
                MessageBox.Show("文件名不得为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (nowp <= 0)
                MessageBox.Show("未选择目录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string lsl = Path.GetExtension(fpos[nowp] + '\\' + filename.Text);
                if (lsl == "")
                    Directory.CreateDirectory(fpos[nowp] + '\\' + filename.Text);
                else
                {
                    if (lsl == ".txt" || lsl == ".TXT")
                        File.WriteAllText(fpos[nowp] + '\\' + filename.Text, infile, Encoding.GetEncoding("GB2312"));
                    else
                        File.WriteAllText(fpos[nowp] + '\\' + filename.Text, infile);
                }
                reffile(fpos[nowp], smode);
            }
        }

        private void cut_Click(object sender, EventArgs e)
        {
            if (filepath != "Null")
            {
                if (cuta != "")
                {
                    js = 0;
                    bool reald = false;
                    string llast = Path.GetExtension(fpos[nowp + 1]);
                    Directory.CreateDirectory(filepath + cuta);
                    infile = "";
                    string fn, word = "";
                    //l = infile.Length;
                    for (i = 0; i < l; ++i)
                    {
                        ++js;
                        fn = filepath + cuta + "\\";
                        if (js < 100)
                            fn = fn + '0';
                        if (js < 10)
                            fn = fn + '0';
                        fn = fn + js.ToString() + llast;

                        //MessageBox.Show(fn, "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                        for (j = i; j < l; ++j)
                        {
                            if (a[j] != '\n')
                                reald = true;
                            //if(j<l)
                            //MessageBox.Show(infile+' '+j.ToString()+' '+a[j]+' '+l.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                            //cout<<a[j];
                            if (j < l && reald == true)
                            {
                                word = word + a[j];
                                infile = infile + a[j];
                            }
                            //fout<<a[j];
                            if (pd() == true)
                            {
                                if (p == 1)
                                {
                                    //fout<<a[j];
                                    //fout<<a[j]<<' '<<i<<' '<<j<<' '<<x<<' '<<y<<' '<<js<<endl;
                                    //cout<<a[j];
                                    infile = infile + a[j];
                                    p = 0;
                                }
                                //MessageBox.Show(i.ToString() + ' ' + j.ToString() + ' ' + a[j] + ' ' + l.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                                if (reald == true)
                                {
                                    infile = infile + "\r\n";
                                    word = word + "\r\n";
                                }
                                //cout<<endl;
                                break;
                            }

                        }
                        //MessageBox.Show(word+"\n"+js.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.None);


                        if (llast == ".txt" || llast == ".TXT")
                            File.WriteAllText(fn, word, Encoding.GetEncoding("GB2312"));
                        else
                            File.WriteAllText(fn, word);
                        word = "";

                        i = j;
                    }
                    //MessageBox.Show(infile, "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                    lrcv.Text = infile;
                    //lrcv.Text = "123";
                    //sfpath.Text = infile;
                    //cout<<js-1<<endl;
                    reffile(fpos[nowp], smode);
                }
                else
                    MessageBox.Show("分割后文件夹添加名不得为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("未选中文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            if (nowp > 0)
                reffile(fpos[nowp], smode);
            else
                MessageBox.Show("未选中路径！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void player_StatusChange(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
        }

        private void copy_Click(object sender, EventArgs e)
        {
            if (nowp > 0)
            {
                copypath = fpos[nowp + 1];
                copyfn = fname;
            }
            else
                MessageBox.Show("未选择文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //sfpath.Text = copypath;
        }

        private void past_Click(object sender, EventArgs e)
        {
            if (copypath == "Null")
                MessageBox.Show("未选择要复制的文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (nowp <= 0)
                MessageBox.Show("未选择目录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (File.Exists(fpos[nowp] + '\\' + copyfn) == true)
                {
                    if (MessageBox.Show("文件已存在，是否替换？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        File.Copy(copypath, fpos[nowp] + '\\' + copyfn, true);
                }
                else
                    File.Copy(copypath, fpos[nowp] + '\\' + copyfn, true);
                reffile(fpos[nowp], smode);
            }
        }

        private void cutch_TextChanged(object sender, EventArgs e)
        {
            cuts = cutch.Text;
            cutc = cuts.ToCharArray();
            cutn = cuts.Length;
        }

        private void delc_Click(object sender, EventArgs e)
        {
            infile="";
            for(i=0;i<l;++i)
                if (pdc(a[i]) != 2 && pdc(a[i]) != 4)
                {
                    infile = infile + a[i];
                    //MessageBox.Show(infile, "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            lrcv.Text = infile;
        }

        private void dele_Click(object sender, EventArgs e)
        {
            infile = "";
            for (i = 0; i < l; ++i)
                if (pdc(a[i]) != 1 && pdc(a[i]) != 3)
                {
                    infile = infile + a[i];
                    //MessageBox.Show(infile, "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            lrcv.Text = infile;
        }

        private void big_Click(object sender, EventArgs e)
        {
            ++wsize;
            wtsize.Text = wsize.ToString();
            lrcv.Font = new Font(lrcv.Font.Name, wsize);
        }

        private void small_Click(object sender, EventArgs e)
        {
            --wsize;
            wtsize.Text = wsize.ToString();
            lrcv.Font = new Font(lrcv.Font.Name, wsize);
        }

        private void wtsize_TextChanged(object sender, EventArgs e)
        {
            if (wtsize.Text != "")
            {
                wsize = Convert.ToInt32(wtsize.Text);
                if (wsize > 48)
                {
                    wsize = 48;
                    wtsize.Text = "48";
                }
            }
            else
            {
                wsize = 1;
                wtsize.Text = "1";
            }
            lrcv.Font = new Font(lrcv.Font.Name, wsize);
        }

        private void cutadd_TextChanged(object sender, EventArgs e)
        {
            cuta = cutadd.Text;
        }

        private void sort1_CheckedChanged(object sender, EventArgs e)
        {
            smode = 1;
            if (nowp > 0)
                reffile(fpos[nowp],smode);
        }

        private void sort2_CheckedChanged(object sender, EventArgs e)
        {
            smode = 2;
            if (nowp > 0)
                reffile(fpos[nowp], smode);
        }

    }
}
/*
 char[] cs = yourstring.ToCharArray();
StreamReader sr = new StreamReader("TestFile.txt")//StreamReader sr = new StreamReader("TestFile.txt",Encoding.GetEncoding("GB2312"))
///GBK
String line;
while ((line = sr.ReadLine()) != null)
{
   textBox1 .Text +=ii.ToString ()+" -"+line.ToString()+"\r\n";

}
加入引用：System.IO
StreamReader objReader = new StreamReader("c:\\test.txt");
     System.IO 命名空间中的对象，尤其是 System.IO.StreamReader 类。

\r\n一般一起用,用来表示键盘上的回车键.也可只用\n.\t表示键盘上的“TAB
*/
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace WinFormLogExample
{
    public partial class Form1 : Form
    {
        private readonly string _localDir = @"C:\Users\Koreasoft\Desktop\project\Examples\WinFormLogExample\WinFormLogExample\bin\Debug";

        public Form1()
        {
            InitializeComponent();

            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            Log_Info("Log 프로그램 예제를 시작 합니다.");

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Log_Info("Log 프로그램 예제를 종료 합니다.");
        }
        
        public bool Log_Info(string strMsg)
        {
            try
            {
                //현재 exe 파일이 위치하고 있는 폴더를 가져옴
                //var localDir = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\\"));

                //로그 폴더가 없으면 생성
                var logDir = Path.Combine(_localDir, "Log");
                if (!Directory.Exists(logDir))
                {
                    Directory.CreateDirectory(logDir);
                }
                
                //로그 폴더에 로그파일 저장
                var logFileName = DateTime.Now.ToString("yyyyMMdd") + ".txt";
                var fileWriter = new StreamWriter(Path.Combine(logDir, logFileName), true);
                var logDatum = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + " => " + strMsg + "\r\n";
                fileWriter.Write(logDatum);
                fileWriter.Flush();
                fileWriter.Close();
                
                //리스트뷰에 로그 내용 보여주기
                var lvi = new ListViewItem();
                var currentItemCount = listView1.Items.Count + 1; //현재 아이템의 순번 =  리스트뷰에 존재하는 아이템 개수 + 1
                lvi.Text = currentItemCount.ToString(); 
                lvi.SubItems.Add(logDatum);
                listView1.Items.Add(lvi);
                
            }
            catch
            {
                return false; 
            }
            
            return true;
        }

        // 로그 남기기 버튼 클릭 시 동작
        private void writeLog_Click(object sender, EventArgs e)
        {
            Log_Info("로그 남기기 버튼을 클릭 하였습니다.");
            
        }

        // 로그 불러오기 버튼 클릭 시 동작
        // 로그 저장 폴더가 지정된 파일 탐색기 띄움. txt 파일만 필터링해서 보여줌.
        private void loadLog_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = @"TXT 파일(*.txt) | *.txt";
            ofd.InitialDirectory = Path.Combine(_localDir, "Log");

            if (ofd.ShowDialog() == DialogResult.OK) //로그파일 1개를 선택하여 파일 탐색기가 닫힌 경우
            {
                listView1.Items.Clear(); // 프로그램 실행 후 작성되고 있던 로그 지우기
                var logFile = ofd.FileName;
                
                Debug.WriteLine("logFile: " + logFile);
                
                if (!File.Exists(logFile)) //로그파일이 존재하지 않는 경우 or 선택된 파일이 없는 경우
                {
                    MessageBox.Show(@"해당 파일이 없거나 선택된 파일이 없습니다.", "확 인", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    //리스트 뷰에 로그파일 내용 보여주기
                    var logData = File.ReadAllLines(logFile);
                    for (var cnt = 0; cnt < logData.Length; cnt++)
                    {
                        var lvi = new ListViewItem();
                        lvi.Text = (cnt + 1).ToString();
                        lvi.SubItems.Add(logData[cnt]);
                        listView1.Items.Add(lvi);
                    }
                }
            }
        }
        
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<string> MemberID;
        MySqlConnection conn;//DB 연동을 위한 객체 생성
        private bool sw = false;//클릭 이벤트 토글 점검용 객체
        public Form1()
        {
            InitializeComponent();
            this.Text = "테스트폼";//폼 타이틀 변경
            Btn_OK.Text = "누르시오";//버튼 텍스트 변경

            #region DB연결 확인
            bool db = DBconnection();
            if (db)
                DB_Read();
            else
                this.Close();//DB 연결 실패시 프로그램 종료
            #endregion
        }

        #region DB부

        #region DB 연결
        private bool DBconnection()
        {
            try
            {
                string strConn = "Server=localhost;Database=membermanage;Uid=root;Pwd=456123;";
                conn = new MySqlConnection(strConn);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("오류발생\n" + e.Message, "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        #endregion

        #region DB 쓰기
        private void DB_Write(string ID, string PW)
        {
            //DB관련 작업 이후 구현예정
        }
        #endregion

        #region DB 읽기
        private void DB_Read()
        {
            MemberID = new List<string>();
            conn.Open();
            string qry = "SELECT * From membermanage.member";

            MySqlCommand cmd = new MySqlCommand(qry, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    MemberID.Add(rdr.GetString(0));
                }
                rdr.Close();
            }
        }
        #endregion

        #endregion

        #region 이벤트 핸들러
        private void Event(object sender, EventArgs e)
        {
            //object sender에 할당된 컨트롤의 종류를 검사
            if (sender is Button)//버튼일경우
            {
                Button seledBtn = sender as Button;

                if (seledBtn.Name == "BTN_Close")
                {
                    //Form1_FormClosing(null, null);
                    this.Close();
                }                   

                if (!sw)
                {
                    MessageBox.Show("버튼이구만~!!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    seledBtn.Text = "누르면터짐";
                    sw = true;
                }
                else
                {
                    this.WindowState = FormWindowState.Maximized;
                    sw = false;
                    this.Text = "뻥~! X.X";
                    MessageBox.Show("엌!!", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
            }
            else if(sender is CheckBox)//체크박스일 경우
            {
                CheckBox selectedCB = sender as CheckBox;
                if (selectedCB.Name == "checkBox1")
                {
                    if (selectedCB.Checked)
                        TB_Password.PasswordChar = '\0';
                    else
                        TB_Password.PasswordChar = '★';                    
                }
            }
            else if (sender is TextBox)//텍스트박스일 경우
            {
                TextBox SeledTB = sender as TextBox;
                if (SeledTB.TextLength == 0)
                {
                    MessageBox.Show(SeledTB.Name.ToString() + "입력안됨요", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else//그 외 사실 필요 없지만(폼에 컨트롤이 버튼, 텍스트박스, 체크박스만 사용했으므로)예외처리를 위하여 추가.
            {
                string type = sender.GetType().ToString();
                MessageBox.Show("이거슨 " + type + "군!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();//DB연결 해제
        }
        #endregion
    }
}

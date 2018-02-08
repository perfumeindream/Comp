namespace WindowsFormsApp1
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
            this.Btn_OK = new System.Windows.Forms.Button();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.CB_Password = new System.Windows.Forms.CheckBox();
            this.BTN_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_OK
            // 
            this.Btn_OK.Location = new System.Drawing.Point(48, 97);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(75, 23);
            this.Btn_OK.TabIndex = 0;
            this.Btn_OK.Text = "확인";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Event);
            // 
            // TB_Password
            // 
            this.TB_Password.Location = new System.Drawing.Point(84, 53);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.PasswordChar = '★';
            this.TB_Password.Size = new System.Drawing.Size(100, 21);
            this.TB_Password.TabIndex = 1;
            this.TB_Password.Leave += new System.EventHandler(this.Event);
            // 
            // CB_Password
            // 
            this.CB_Password.AutoSize = true;
            this.CB_Password.Location = new System.Drawing.Point(190, 55);
            this.CB_Password.Name = "CB_Password";
            this.CB_Password.Size = new System.Drawing.Size(60, 16);
            this.CB_Password.TabIndex = 2;
            this.CB_Password.Text = "보이기";
            this.CB_Password.UseVisualStyleBackColor = true;
            this.CB_Password.CheckedChanged += new System.EventHandler(this.Event);
            // 
            // BTN_Close
            // 
            this.BTN_Close.Location = new System.Drawing.Point(154, 97);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.Size = new System.Drawing.Size(75, 23);
            this.BTN_Close.TabIndex = 3;
            this.BTN_Close.Text = "종료";
            this.BTN_Close.UseVisualStyleBackColor = true;
            this.BTN_Close.Click += new System.EventHandler(this.Event);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "계정";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "비밀번호";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '★';
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(269, 133);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Close);
            this.Controls.Add(this.CB_Password);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.Btn_OK);
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.CheckBox CB_Password;
        private System.Windows.Forms.Button BTN_Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}


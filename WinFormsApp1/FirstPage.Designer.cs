using Bibliotektemp;
using Newtonsoft.Json;

namespace WinFormsApp1
{
    partial class FirstPage
    {

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginButton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.passwordLoginButton = new System.Windows.Forms.TextBox();
            this.nummerLoginBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.passwordRegisterButton = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.nummerRegisterButton = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.Choosebook = new System.Windows.Forms.TextBox();
            this.ListofBooksbox = new System.Windows.Forms.ListBox();
            this.listofbooks = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(359, 259);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(94, 29);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "logga in";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(360, 301);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(94, 29);
            this.RegisterButton.TabIndex = 1;
            this.RegisterButton.Text = "skapa konto";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(369, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bibliotek";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.passwordLoginButton);
            this.panel1.Controls.Add(this.nummerLoginBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 453);
            this.panel1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Lösenord";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Personnummer";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(347, 276);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 3;
            this.button3.Text = "Logga in";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // passwordLoginButton
            // 
            this.passwordLoginButton.Location = new System.Drawing.Point(329, 227);
            this.passwordLoginButton.Name = "passwordLoginButton";
            this.passwordLoginButton.Size = new System.Drawing.Size(125, 27);
            this.passwordLoginButton.TabIndex = 2;
            // 
            // nummerLoginBox
            // 
            this.nummerLoginBox.Location = new System.Drawing.Point(329, 167);
            this.nummerLoginBox.Name = "nummerLoginBox";
            this.nummerLoginBox.Size = new System.Drawing.Size(125, 27);
            this.nummerLoginBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Logga in";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.passwordRegisterButton);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.nummerRegisterButton);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 451);
            this.panel2.TabIndex = 1;
            // 
            // passwordRegisterButton
            // 
            this.passwordRegisterButton.Location = new System.Drawing.Point(315, 227);
            this.passwordRegisterButton.Name = "passwordRegisterButton";
            this.passwordRegisterButton.Size = new System.Drawing.Size(125, 27);
            this.passwordRegisterButton.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(240, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Lösenord";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Personnummer";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(329, 293);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 1;
            this.button4.Text = "Registrering";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // nummerRegisterButton
            // 
            this.nummerRegisterButton.Location = new System.Drawing.Point(315, 167);
            this.nummerRegisterButton.Name = "nummerRegisterButton";
            this.nummerRegisterButton.Size = new System.Drawing.Size(125, 27);
            this.nummerRegisterButton.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Registrering";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.LoginButton);
            this.panel3.Controls.Add(this.RegisterButton);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(798, 453);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(801, 453);
            this.panel4.TabIndex = 2;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(357, 249);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(86, 31);
            this.button6.TabIndex = 5;
            this.button6.Text = "Logga ut";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(357, 211);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 31);
            this.button5.TabIndex = 4;
            this.button5.Text = "Konto ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(355, 171);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "Söka bok";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 131);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Lista bok";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(347, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "vad vill du göra";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(362, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Bibliotek";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.button7);
            this.panel5.Controls.Add(this.Choosebook);
            this.panel5.Controls.Add(this.ListofBooksbox);
            this.panel5.Controls.Add(this.listofbooks);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(801, 449);
            this.panel5.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(315, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(189, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Välj bok via nummer, 1-100";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(476, 287);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(94, 29);
            this.button7.TabIndex = 3;
            this.button7.Text = "Gå vidare";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // Choosebook
            // 
            this.Choosebook.Location = new System.Drawing.Point(345, 287);
            this.Choosebook.Name = "Choosebook";
            this.Choosebook.Size = new System.Drawing.Size(125, 27);
            this.Choosebook.TabIndex = 2;
            // 
            // ListofBooksbox
            // 
            this.ListofBooksbox.FormattingEnabled = true;
            this.ListofBooksbox.ItemHeight = 20;
            this.ListofBooksbox.Location = new System.Drawing.Point(75, 88);
            this.ListofBooksbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ListofBooksbox.Name = "ListofBooksbox";
            this.ListofBooksbox.Size = new System.Drawing.Size(671, 164);
            this.ListofBooksbox.TabIndex = 1;
            // 
            // listofbooks
            // 
            this.listofbooks.Location = new System.Drawing.Point(347, 243);
            this.listofbooks.Name = "listofbooks";
            this.listofbooks.Size = new System.Drawing.Size(114, 31);
            this.listofbooks.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(360, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "alla böcker";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button9);
            this.panel6.Controls.Add(this.button8);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(798, 453);
            this.panel6.TabIndex = 2;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(430, 195);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(94, 29);
            this.button9.TabIndex = 2;
            this.button9.Text = "Lämna tillbaka";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(259, 195);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(94, 29);
            this.button8.TabIndex = 1;
            this.button8.Text = "Låna";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(318, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "ska bli vald bok";
            // 
            // FirstPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Name = "FirstPage";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button LoginButton;
        private Button RegisterButton;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private Panel panel3;
        private Label label5;
        private Label label4;
        private Button button3;
        private TextBox passwordLoginButton;
        private TextBox nummerLoginBox;
        private TextBox passwordRegisterButton;
        private Label label7;
        private Label label6;
        private TextBox nummerRegisterButton;
        private Button button4;
        private Panel panel4;
        private Label label8;
        private Button button6;
        private Button button5;
        private Button button2;
        private Button button1;
        private Label label9;
        private Panel panel5;
        private Label listofbooks;
        private Label label10;
        private ListBox ListofBooksbox;
        private Label label11;
        private Button button7;
        private TextBox Choosebook;
        private Panel panel6;
        private Button button9;
        private Button button8;
        private Label label12;
    }
}
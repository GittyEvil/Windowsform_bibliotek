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
            this.panel10 = new System.Windows.Forms.Panel();
            this.button20 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.Choosebook = new System.Windows.Forms.TextBox();
            this.ListofBooksbox = new System.Windows.Forms.ListBox();
            this.listofbooks = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
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
            // panel10
            // 
            this.panel10.Controls.Add(this.label20);
            this.panel10.Controls.Add(this.button20);
            this.panel10.Controls.Add(this.textBox2);
            this.panel10.Controls.Add(this.label19);
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(801, 454);
            this.panel10.TabIndex = 2;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(345, 244);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(94, 29);
            this.button20.TabIndex = 2;
            this.button20.Text = "Redigera";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(332, 161);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(278, 89);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(226, 20);
            this.label19.TabIndex = 0;
            this.label19.Text = "Vilken användare vill du redigera";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.textBox3);
            this.panel9.Controls.Add(this.button19);
            this.panel9.Controls.Add(this.button18);
            this.panel9.Controls.Add(this.listBox1);
            this.panel9.Controls.Add(this.label18);
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(798, 453);
            this.panel9.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(349, 261);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 27);
            this.textBox3.TabIndex = 4;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(485, 312);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(94, 29);
            this.button19.TabIndex = 3;
            this.button19.Text = "ta bort användare";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(239, 313);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(94, 29);
            this.button18.TabIndex = 2;
            this.button18.Text = "Redigera användare";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(172, 149);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(491, 104);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(348, 88);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(109, 20);
            this.label18.TabIndex = 0;
            this.label18.Text = "Visa användare";
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
            // panel7
            // 
            this.panel7.Controls.Add(this.textBox1);
            this.panel7.Controls.Add(this.button10);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(801, 453);
            this.panel7.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(323, 215);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(336, 274);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(94, 29);
            this.button10.TabIndex = 2;
            this.button10.Text = "byt lösenord";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(300, 166);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(170, 20);
            this.label15.TabIndex = 1;
            this.label15.Text = "skriv in ditt nya lösenord";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(315, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(153, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Ändra kontouppgifter";
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
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.button9);
            this.panel6.Controls.Add(this.button8);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(798, 453);
            this.panel6.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(346, 278);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "label13";
            this.label13.Click += new System.EventHandler(this.label13_Click);
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
            // panel8
            // 
            this.panel8.Controls.Add(this.button17);
            this.panel8.Controls.Add(this.button16);
            this.panel8.Controls.Add(this.button15);
            this.panel8.Controls.Add(this.button11);
            this.panel8.Controls.Add(this.button12);
            this.panel8.Controls.Add(this.button13);
            this.panel8.Controls.Add(this.button14);
            this.panel8.Controls.Add(this.label16);
            this.panel8.Controls.Add(this.label17);
            this.panel8.Location = new System.Drawing.Point(0, -1);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(801, 453);
            this.panel8.TabIndex = 7;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(349, 275);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(94, 29);
            this.button17.TabIndex = 8;
            this.button17.Text = "ta bort bok";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(347, 244);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(94, 29);
            this.button16.TabIndex = 7;
            this.button16.Text = "lägga till bok";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(349, 209);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(94, 29);
            this.button15.TabIndex = 6;
            this.button15.Text = "visa användare";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(354, 350);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(86, 31);
            this.button11.TabIndex = 5;
            this.button11.Text = "Logga ut";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(354, 311);
            this.button12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(86, 31);
            this.button12.TabIndex = 4;
            this.button12.Text = "Konto ";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(355, 171);
            this.button13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(86, 31);
            this.button13.TabIndex = 3;
            this.button13.Text = "Söka bok";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(355, 131);
            this.button14.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(86, 31);
            this.button14.TabIndex = 2;
            this.button14.Text = "Lista bok";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(347, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 20);
            this.label16.TabIndex = 1;
            this.label16.Text = "vad vill du göra";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(323, 53);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(155, 20);
            this.label17.TabIndex = 0;
            this.label17.Text = "Bibliotek, Bibliotikarie";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(347, 126);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(86, 20);
            this.label20.TabIndex = 3;
            this.label20.Text = "ändra lösen";
            // 
            // FirstPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel10);
            this.Name = "FirstPage";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
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
        private Label label13;
        private Panel panel7;
        private Label label14;
        private TextBox textBox1;
        private Button button10;
        private Label label15;
        private Panel panel8;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Label label16;
        private Label label17;
        private Button button17;
        private Button button16;
        private Button button15;
        private Panel panel9;
        private ListBox listBox1;
        private Label label18;
        private Button button19;
        private Button button18;
        private Panel panel10;
        private Label label19;
        private TextBox textBox2;
        private Button button20;
        private TextBox textBox3;
        private Label label20;
    }
}
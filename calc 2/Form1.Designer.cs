
namespace calc_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.op_lable = new System.Windows.Forms.Label();
            this.lable = new System.Windows.Forms.Label();
            this.result_txt = new System.Windows.Forms.TextBox();
            this.num0_but = new System.Windows.Forms.Button();
            this.dot_but = new System.Windows.Forms.Button();
            this.equal_but = new System.Windows.Forms.Button();
            this.num1_but = new System.Windows.Forms.Button();
            this.num2_but = new System.Windows.Forms.Button();
            this.num3_but = new System.Windows.Forms.Button();
            this.plus_but = new System.Windows.Forms.Button();
            this.num4_but = new System.Windows.Forms.Button();
            this.num5_but = new System.Windows.Forms.Button();
            this.num6_but = new System.Windows.Forms.Button();
            this.minus_but = new System.Windows.Forms.Button();
            this.num7_but = new System.Windows.Forms.Button();
            this.num8_but = new System.Windows.Forms.Button();
            this.num9_but = new System.Windows.Forms.Button();
            this.mult_but = new System.Windows.Forms.Button();
            this.clear_but = new System.Windows.Forms.Button();
            this.backspace_but = new System.Windows.Forms.Button();
            this.percent_but = new System.Windows.Forms.Button();
            this.div_but = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.op_lable);
            this.panel1.Controls.Add(this.lable);
            this.panel1.Controls.Add(this.result_txt);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 229);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(391, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // op_lable
            // 
            this.op_lable.AutoSize = true;
            this.op_lable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.op_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op_lable.ForeColor = System.Drawing.Color.White;
            this.op_lable.Location = new System.Drawing.Point(386, 191);
            this.op_lable.Name = "op_lable";
            this.op_lable.Size = new System.Drawing.Size(0, 25);
            this.op_lable.TabIndex = 2;
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.ForeColor = System.Drawing.Color.White;
            this.lable.Location = new System.Drawing.Point(3, 139);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(0, 39);
            this.lable.TabIndex = 3;
            // 
            // result_txt
            // 
            this.result_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.result_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.result_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_txt.ForeColor = System.Drawing.Color.White;
            this.result_txt.Location = new System.Drawing.Point(0, 184);
            this.result_txt.Name = "result_txt";
            this.result_txt.ReadOnly = true;
            this.result_txt.Size = new System.Drawing.Size(427, 38);
            this.result_txt.TabIndex = 1;
            this.result_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.result_txt_KeyDown);
            // 
            // num0_but
            // 
            this.num0_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(18)))), ((int)(((byte)(29)))));
            this.num0_but.FlatAppearance.BorderSize = 0;
            this.num0_but.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num0_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num0_but.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.num0_but.Location = new System.Drawing.Point(108, 550);
            this.num0_but.Name = "num0_but";
            this.num0_but.Size = new System.Drawing.Size(105, 74);
            this.num0_but.TabIndex = 1;
            this.num0_but.Text = "0";
            this.num0_but.UseVisualStyleBackColor = false;
            this.num0_but.Click += new System.EventHandler(this.num0_but_Click);
            // 
            // dot_but
            // 
            this.dot_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(18)))), ((int)(((byte)(29)))));
            this.dot_but.FlatAppearance.BorderSize = 0;
            this.dot_but.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dot_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dot_but.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dot_but.Location = new System.Drawing.Point(215, 550);
            this.dot_but.Name = "dot_but";
            this.dot_but.Size = new System.Drawing.Size(105, 74);
            this.dot_but.TabIndex = 2;
            this.dot_but.Text = ".";
            this.dot_but.UseVisualStyleBackColor = false;
            this.dot_but.Click += new System.EventHandler(this.dot_but_Click);
            // 
            // equal_but
            // 
            this.equal_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(0)))));
            this.equal_but.FlatAppearance.BorderSize = 0;
            this.equal_but.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.equal_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal_but.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.equal_but.Location = new System.Drawing.Point(322, 470);
            this.equal_but.Name = "equal_but";
            this.equal_but.Size = new System.Drawing.Size(105, 154);
            this.equal_but.TabIndex = 3;
            this.equal_but.Text = "=";
            this.equal_but.UseVisualStyleBackColor = false;
            this.equal_but.Click += new System.EventHandler(this.equal_but_Click);
            // 
            // num1_but
            // 
            this.num1_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(18)))), ((int)(((byte)(29)))));
            this.num1_but.FlatAppearance.BorderSize = 0;
            this.num1_but.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num1_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1_but.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.num1_but.Location = new System.Drawing.Point(1, 470);
            this.num1_but.Name = "num1_but";
            this.num1_but.Size = new System.Drawing.Size(105, 74);
            this.num1_but.TabIndex = 5;
            this.num1_but.Text = "1";
            this.num1_but.UseVisualStyleBackColor = false;
            this.num1_but.Click += new System.EventHandler(this.num1_but_Click);
            // 
            // num2_but
            // 
            this.num2_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(18)))), ((int)(((byte)(29)))));
            this.num2_but.FlatAppearance.BorderSize = 0;
            this.num2_but.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num2_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2_but.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.num2_but.Location = new System.Drawing.Point(108, 470);
            this.num2_but.Name = "num2_but";
            this.num2_but.Size = new System.Drawing.Size(105, 74);
            this.num2_but.TabIndex = 6;
            this.num2_but.Text = "2";
            this.num2_but.UseVisualStyleBackColor = false;
            this.num2_but.Click += new System.EventHandler(this.num2_but_Click);
            // 
            // num3_but
            // 
            this.num3_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(18)))), ((int)(((byte)(29)))));
            this.num3_but.FlatAppearance.BorderSize = 0;
            this.num3_but.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num3_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3_but.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.num3_but.Location = new System.Drawing.Point(215, 470);
            this.num3_but.Name = "num3_but";
            this.num3_but.Size = new System.Drawing.Size(105, 74);
            this.num3_but.TabIndex = 7;
            this.num3_but.Text = "3";
            this.num3_but.UseVisualStyleBackColor = false;
            this.num3_but.Click += new System.EventHandler(this.num3_but_Click);
            // 
            // plus_but
            // 
            this.plus_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.plus_but.FlatAppearance.BorderSize = 0;
            this.plus_but.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.plus_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(0)))));
            this.plus_but.Location = new System.Drawing.Point(322, 390);
            this.plus_but.Name = "plus_but";
            this.plus_but.Size = new System.Drawing.Size(105, 74);
            this.plus_but.TabIndex = 8;
            this.plus_but.Text = "+";
            this.plus_but.UseVisualStyleBackColor = false;
            this.plus_but.Click += new System.EventHandler(this.plus_but_Click);
            // 
            // num4_but
            // 
            this.num4_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(18)))), ((int)(((byte)(29)))));
            this.num4_but.FlatAppearance.BorderSize = 0;
            this.num4_but.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num4_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4_but.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.num4_but.Location = new System.Drawing.Point(1, 390);
            this.num4_but.Name = "num4_but";
            this.num4_but.Size = new System.Drawing.Size(105, 74);
            this.num4_but.TabIndex = 9;
            this.num4_but.Text = "4";
            this.num4_but.UseVisualStyleBackColor = false;
            this.num4_but.Click += new System.EventHandler(this.num4_but_Click);
            // 
            // num5_but
            // 
            this.num5_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(18)))), ((int)(((byte)(29)))));
            this.num5_but.FlatAppearance.BorderSize = 0;
            this.num5_but.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num5_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5_but.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.num5_but.Location = new System.Drawing.Point(108, 390);
            this.num5_but.Name = "num5_but";
            this.num5_but.Size = new System.Drawing.Size(105, 74);
            this.num5_but.TabIndex = 10;
            this.num5_but.Text = "5";
            this.num5_but.UseVisualStyleBackColor = false;
            this.num5_but.Click += new System.EventHandler(this.num5_but_Click);
            // 
            // num6_but
            // 
            this.num6_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(18)))), ((int)(((byte)(29)))));
            this.num6_but.FlatAppearance.BorderSize = 0;
            this.num6_but.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num6_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6_but.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.num6_but.Location = new System.Drawing.Point(215, 390);
            this.num6_but.Name = "num6_but";
            this.num6_but.Size = new System.Drawing.Size(105, 74);
            this.num6_but.TabIndex = 11;
            this.num6_but.Text = "6";
            this.num6_but.UseVisualStyleBackColor = false;
            this.num6_but.Click += new System.EventHandler(this.num6_but_Click);
            // 
            // minus_but
            // 
            this.minus_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.minus_but.FlatAppearance.BorderSize = 0;
            this.minus_but.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minus_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(0)))));
            this.minus_but.Location = new System.Drawing.Point(322, 310);
            this.minus_but.Name = "minus_but";
            this.minus_but.Size = new System.Drawing.Size(105, 74);
            this.minus_but.TabIndex = 12;
            this.minus_but.Text = "-";
            this.minus_but.UseVisualStyleBackColor = false;
            this.minus_but.Click += new System.EventHandler(this.minus_but_Click);
            // 
            // num7_but
            // 
            this.num7_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(18)))), ((int)(((byte)(29)))));
            this.num7_but.FlatAppearance.BorderSize = 0;
            this.num7_but.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num7_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7_but.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.num7_but.Location = new System.Drawing.Point(1, 310);
            this.num7_but.Name = "num7_but";
            this.num7_but.Size = new System.Drawing.Size(105, 74);
            this.num7_but.TabIndex = 13;
            this.num7_but.Text = "7";
            this.num7_but.UseVisualStyleBackColor = false;
            this.num7_but.Click += new System.EventHandler(this.num7_but_Click);
            // 
            // num8_but
            // 
            this.num8_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(18)))), ((int)(((byte)(29)))));
            this.num8_but.FlatAppearance.BorderSize = 0;
            this.num8_but.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num8_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8_but.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.num8_but.Location = new System.Drawing.Point(108, 310);
            this.num8_but.Name = "num8_but";
            this.num8_but.Size = new System.Drawing.Size(105, 74);
            this.num8_but.TabIndex = 14;
            this.num8_but.Text = "8";
            this.num8_but.UseVisualStyleBackColor = false;
            this.num8_but.Click += new System.EventHandler(this.num8_but_Click);
            // 
            // num9_but
            // 
            this.num9_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(18)))), ((int)(((byte)(29)))));
            this.num9_but.FlatAppearance.BorderSize = 0;
            this.num9_but.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num9_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9_but.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.num9_but.Location = new System.Drawing.Point(215, 310);
            this.num9_but.Name = "num9_but";
            this.num9_but.Size = new System.Drawing.Size(105, 74);
            this.num9_but.TabIndex = 15;
            this.num9_but.Text = "9";
            this.num9_but.UseVisualStyleBackColor = false;
            this.num9_but.Click += new System.EventHandler(this.num9_but_Click);
            // 
            // mult_but
            // 
            this.mult_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.mult_but.FlatAppearance.BorderSize = 0;
            this.mult_but.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mult_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mult_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(0)))));
            this.mult_but.Location = new System.Drawing.Point(322, 230);
            this.mult_but.Name = "mult_but";
            this.mult_but.Size = new System.Drawing.Size(105, 74);
            this.mult_but.TabIndex = 16;
            this.mult_but.Text = "X";
            this.mult_but.UseVisualStyleBackColor = false;
            this.mult_but.Click += new System.EventHandler(this.mult_but_Click);
            // 
            // clear_but
            // 
            this.clear_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.clear_but.FlatAppearance.BorderSize = 0;
            this.clear_but.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clear_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_but.ForeColor = System.Drawing.Color.White;
            this.clear_but.Location = new System.Drawing.Point(1, 230);
            this.clear_but.Name = "clear_but";
            this.clear_but.Size = new System.Drawing.Size(105, 74);
            this.clear_but.TabIndex = 17;
            this.clear_but.Text = "C";
            this.clear_but.UseVisualStyleBackColor = false;
            this.clear_but.Click += new System.EventHandler(this.clear_but_Click);
            // 
            // backspace_but
            // 
            this.backspace_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.backspace_but.FlatAppearance.BorderSize = 0;
            this.backspace_but.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backspace_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backspace_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(0)))));
            this.backspace_but.Location = new System.Drawing.Point(108, 230);
            this.backspace_but.Name = "backspace_but";
            this.backspace_but.Size = new System.Drawing.Size(105, 74);
            this.backspace_but.TabIndex = 18;
            this.backspace_but.Text = "→";
            this.backspace_but.UseVisualStyleBackColor = false;
            this.backspace_but.Click += new System.EventHandler(this.backspace_but_Click);
            // 
            // percent_but
            // 
            this.percent_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(18)))), ((int)(((byte)(29)))));
            this.percent_but.FlatAppearance.BorderSize = 0;
            this.percent_but.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.percent_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percent_but.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.percent_but.Location = new System.Drawing.Point(1, 550);
            this.percent_but.Name = "percent_but";
            this.percent_but.Size = new System.Drawing.Size(105, 74);
            this.percent_but.TabIndex = 19;
            this.percent_but.Text = "%";
            this.percent_but.UseVisualStyleBackColor = false;
            this.percent_but.Click += new System.EventHandler(this.percent_but_Click);
            // 
            // div_but
            // 
            this.div_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.div_but.FlatAppearance.BorderSize = 0;
            this.div_but.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.div_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(0)))));
            this.div_but.Location = new System.Drawing.Point(215, 230);
            this.div_but.Name = "div_but";
            this.div_but.Size = new System.Drawing.Size(105, 74);
            this.div_but.TabIndex = 20;
            this.div_but.Text = "÷";
            this.div_but.UseVisualStyleBackColor = false;
            this.div_but.Click += new System.EventHandler(this.div_but_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(427, 623);
            this.Controls.Add(this.div_but);
            this.Controls.Add(this.percent_but);
            this.Controls.Add(this.backspace_but);
            this.Controls.Add(this.clear_but);
            this.Controls.Add(this.plus_but);
            this.Controls.Add(this.mult_but);
            this.Controls.Add(this.num9_but);
            this.Controls.Add(this.num8_but);
            this.Controls.Add(this.num7_but);
            this.Controls.Add(this.minus_but);
            this.Controls.Add(this.num6_but);
            this.Controls.Add(this.num5_but);
            this.Controls.Add(this.num4_but);
            this.Controls.Add(this.num3_but);
            this.Controls.Add(this.num2_but);
            this.Controls.Add(this.num1_but);
            this.Controls.Add(this.equal_but);
            this.Controls.Add(this.dot_but);
            this.Controls.Add(this.num0_but);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcul";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button num0_but;
        private System.Windows.Forms.Button dot_but;
        private System.Windows.Forms.Button equal_but;
        private System.Windows.Forms.Button num1_but;
        private System.Windows.Forms.Button num2_but;
        private System.Windows.Forms.Button num3_but;
        private System.Windows.Forms.Button plus_but;
        private System.Windows.Forms.Button num4_but;
        private System.Windows.Forms.Button num5_but;
        private System.Windows.Forms.Button num6_but;
        private System.Windows.Forms.Button minus_but;
        private System.Windows.Forms.Button num7_but;
        private System.Windows.Forms.Button num8_but;
        private System.Windows.Forms.Button num9_but;
        private System.Windows.Forms.Button mult_but;
        private System.Windows.Forms.Button clear_but;
        private System.Windows.Forms.Button backspace_but;
        private System.Windows.Forms.Button percent_but;
        private System.Windows.Forms.Button div_but;
        private System.Windows.Forms.TextBox result_txt;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Label op_lable;
        
    }
}


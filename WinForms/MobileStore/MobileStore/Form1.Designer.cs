﻿using System.Collections.Generic;

namespace MobileStore
{
   partial class Form1 {
      private List<Phone> _PhoneList;
      private List<string> _OptionsList; 
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
      private void InitializeComponent() {
         System.Windows.Forms.TabPage tabPage1;
         this.label6 = new System.Windows.Forms.Label();
         this.listBox2 = new System.Windows.Forms.ListBox();
         this.textBox4 = new System.Windows.Forms.TextBox();
         this.textBox3 = new System.Windows.Forms.TextBox();
         this.textBox2 = new System.Windows.Forms.TextBox();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.label5 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.listBox1 = new System.Windows.Forms.ListBox();
         this.label1 = new System.Windows.Forms.Label();
         this.button1 = new System.Windows.Forms.Button();
         this.button2 = new System.Windows.Forms.Button();
         this.button3 = new System.Windows.Forms.Button();
         this.button4 = new System.Windows.Forms.Button();
         this.tabControl1 = new System.Windows.Forms.TabControl();
         this.tabPage2 = new System.Windows.Forms.TabPage();
         this.button10 = new System.Windows.Forms.Button();
         this.comboBox1 = new System.Windows.Forms.ComboBox();
         this.textBox10 = new System.Windows.Forms.TextBox();
         this.label12 = new System.Windows.Forms.Label();
         this.button9 = new System.Windows.Forms.Button();
         this.button8 = new System.Windows.Forms.Button();
         this.button7 = new System.Windows.Forms.Button();
         this.button6 = new System.Windows.Forms.Button();
         this.textBox9 = new System.Windows.Forms.TextBox();
         this.label11 = new System.Windows.Forms.Label();
         this.button5 = new System.Windows.Forms.Button();
         this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
         this.textBox5 = new System.Windows.Forms.TextBox();
         this.textBox6 = new System.Windows.Forms.TextBox();
         this.textBox8 = new System.Windows.Forms.TextBox();
         this.label7 = new System.Windows.Forms.Label();
         this.label8 = new System.Windows.Forms.Label();
         this.label9 = new System.Windows.Forms.Label();
         this.label10 = new System.Windows.Forms.Label();
         tabPage1 = new System.Windows.Forms.TabPage();
         tabPage1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.tabControl1.SuspendLayout();
         this.tabPage2.SuspendLayout();
         this.SuspendLayout();
         // 
         // tabPage1
         // 
         tabPage1.Controls.Add(this.label6);
         tabPage1.Controls.Add(this.listBox2);
         tabPage1.Controls.Add(this.textBox4);
         tabPage1.Controls.Add(this.textBox3);
         tabPage1.Controls.Add(this.textBox2);
         tabPage1.Controls.Add(this.textBox1);
         tabPage1.Controls.Add(this.label5);
         tabPage1.Controls.Add(this.label4);
         tabPage1.Controls.Add(this.label3);
         tabPage1.Controls.Add(this.label2);
         tabPage1.Controls.Add(this.pictureBox1);
         tabPage1.Location = new System.Drawing.Point(4, 22);
         tabPage1.Name = "tabPage1";
         tabPage1.Padding = new System.Windows.Forms.Padding(3);
         tabPage1.Size = new System.Drawing.Size(386, 585);
         tabPage1.TabIndex = 0;
         tabPage1.Text = "Информация о телефоне";
         tabPage1.UseVisualStyleBackColor = true;
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label6.Location = new System.Drawing.Point(12, 436);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(50, 16);
         this.label6.TabIndex = 10;
         this.label6.Text = "Опции";
         // 
         // listBox2
         // 
         this.listBox2.FormattingEnabled = true;
         this.listBox2.Location = new System.Drawing.Point(9, 459);
         this.listBox2.Name = "listBox2";
         this.listBox2.Size = new System.Drawing.Size(360, 121);
         this.listBox2.TabIndex = 9;
         // 
         // textBox4
         // 
         this.textBox4.Location = new System.Drawing.Point(237, 401);
         this.textBox4.Name = "textBox4";
         this.textBox4.ReadOnly = true;
         this.textBox4.Size = new System.Drawing.Size(132, 20);
         this.textBox4.TabIndex = 8;
         // 
         // textBox3
         // 
         this.textBox3.Location = new System.Drawing.Point(237, 364);
         this.textBox3.Name = "textBox3";
         this.textBox3.ReadOnly = true;
         this.textBox3.Size = new System.Drawing.Size(132, 20);
         this.textBox3.TabIndex = 7;
         // 
         // textBox2
         // 
         this.textBox2.Location = new System.Drawing.Point(237, 331);
         this.textBox2.Name = "textBox2";
         this.textBox2.ReadOnly = true;
         this.textBox2.Size = new System.Drawing.Size(132, 20);
         this.textBox2.TabIndex = 6;
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(237, 301);
         this.textBox1.Name = "textBox1";
         this.textBox1.ReadOnly = true;
         this.textBox1.Size = new System.Drawing.Size(132, 20);
         this.textBox1.TabIndex = 5;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label5.ForeColor = System.Drawing.Color.Red;
         this.label5.Location = new System.Drawing.Point(6, 405);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(45, 16);
         this.label5.TabIndex = 4;
         this.label5.Text = "Цена";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label4.ForeColor = System.Drawing.Color.Blue;
         this.label4.Location = new System.Drawing.Point(6, 368);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(39, 16);
         this.label4.TabIndex = 3;
         this.label4.Text = "CPU";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label3.ForeColor = System.Drawing.Color.Blue;
         this.label3.Location = new System.Drawing.Point(6, 335);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(29, 16);
         this.label3.TabIndex = 2;
         this.label3.Text = "OS";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label2.ForeColor = System.Drawing.Color.Blue;
         this.label2.Location = new System.Drawing.Point(6, 305);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(64, 16);
         this.label2.TabIndex = 1;
         this.label2.Text = "Модель";
         // 
         // pictureBox1
         // 
         this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
         this.pictureBox1.Location = new System.Drawing.Point(6, 6);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(363, 276);
         this.pictureBox1.TabIndex = 0;
         this.pictureBox1.TabStop = false;
         // 
         // listBox1
         // 
         this.listBox1.FormattingEnabled = true;
         this.listBox1.Location = new System.Drawing.Point(27, 50);
         this.listBox1.Name = "listBox1";
         this.listBox1.Size = new System.Drawing.Size(248, 459);
         this.listBox1.TabIndex = 0;
         this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(24, 20);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(154, 13);
         this.label1.TabIndex = 1;
         this.label1.Text = "Список телефонов магазина";
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(27, 527);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(115, 45);
         this.button1.TabIndex = 2;
         this.button1.Text = "Удалить текущую";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // button2
         // 
         this.button2.Location = new System.Drawing.Point(148, 527);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(127, 45);
         this.button2.TabIndex = 3;
         this.button2.Text = "Очистить список";
         this.button2.UseVisualStyleBackColor = true;
         this.button2.Click += new System.EventHandler(this.button2_Click);
         // 
         // button3
         // 
         this.button3.Location = new System.Drawing.Point(148, 594);
         this.button3.Name = "button3";
         this.button3.Size = new System.Drawing.Size(127, 45);
         this.button3.TabIndex = 4;
         this.button3.Text = "Сохранить в файл";
         this.button3.UseVisualStyleBackColor = true;
         this.button3.Click += new System.EventHandler(this.button3_Click);
         // 
         // button4
         // 
         this.button4.Location = new System.Drawing.Point(27, 594);
         this.button4.Name = "button4";
         this.button4.Size = new System.Drawing.Size(115, 45);
         this.button4.TabIndex = 5;
         this.button4.Text = "Прочитать из файла";
         this.button4.UseVisualStyleBackColor = true;
         this.button4.Click += new System.EventHandler(this.button4_Click);
         // 
         // tabControl1
         // 
         this.tabControl1.Controls.Add(tabPage1);
         this.tabControl1.Controls.Add(this.tabPage2);
         this.tabControl1.Location = new System.Drawing.Point(307, 38);
         this.tabControl1.Name = "tabControl1";
         this.tabControl1.SelectedIndex = 0;
         this.tabControl1.Size = new System.Drawing.Size(394, 611);
         this.tabControl1.TabIndex = 6;
         // 
         // tabPage2
         // 
         this.tabPage2.Controls.Add(this.button10);
         this.tabPage2.Controls.Add(this.comboBox1);
         this.tabPage2.Controls.Add(this.textBox10);
         this.tabPage2.Controls.Add(this.label12);
         this.tabPage2.Controls.Add(this.button9);
         this.tabPage2.Controls.Add(this.button8);
         this.tabPage2.Controls.Add(this.button7);
         this.tabPage2.Controls.Add(this.button6);
         this.tabPage2.Controls.Add(this.textBox9);
         this.tabPage2.Controls.Add(this.label11);
         this.tabPage2.Controls.Add(this.button5);
         this.tabPage2.Controls.Add(this.checkedListBox1);
         this.tabPage2.Controls.Add(this.textBox5);
         this.tabPage2.Controls.Add(this.textBox6);
         this.tabPage2.Controls.Add(this.textBox8);
         this.tabPage2.Controls.Add(this.label7);
         this.tabPage2.Controls.Add(this.label8);
         this.tabPage2.Controls.Add(this.label9);
         this.tabPage2.Controls.Add(this.label10);
         this.tabPage2.Location = new System.Drawing.Point(4, 22);
         this.tabPage2.Name = "tabPage2";
         this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage2.Size = new System.Drawing.Size(386, 585);
         this.tabPage2.TabIndex = 1;
         this.tabPage2.Text = "Редактирование информации";
         this.tabPage2.UseVisualStyleBackColor = true;
         // 
         // button10
         // 
         this.button10.Location = new System.Drawing.Point(339, 106);
         this.button10.Name = "button10";
         this.button10.Size = new System.Drawing.Size(24, 21);
         this.button10.TabIndex = 29;
         this.button10.Text = "...";
         this.button10.UseVisualStyleBackColor = true;
         this.button10.Click += new System.EventHandler(this.button10_Click);
         // 
         // comboBox1
         // 
         this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.comboBox1.FormattingEnabled = true;
         this.comboBox1.Items.AddRange(new object[] {
            "Android 2.0",
            "Android 4.0",
            "Android 5.0",
            "Windows Phone 8.0",
            "Windows Phone 8.1",
            "Windows Phone 10.0",
            "iOS"});
         this.comboBox1.Location = new System.Drawing.Point(220, 39);
         this.comboBox1.Name = "comboBox1";
         this.comboBox1.Size = new System.Drawing.Size(143, 21);
         this.comboBox1.TabIndex = 28;
         // 
         // textBox10
         // 
         this.textBox10.Location = new System.Drawing.Point(220, 107);
         this.textBox10.Name = "textBox10";
         this.textBox10.ReadOnly = true;
         this.textBox10.Size = new System.Drawing.Size(120, 20);
         this.textBox10.TabIndex = 26;
         // 
         // label12
         // 
         this.label12.AutoSize = true;
         this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label12.ForeColor = System.Drawing.Color.Blue;
         this.label12.Location = new System.Drawing.Point(32, 111);
         this.label12.Name = "label12";
         this.label12.Size = new System.Drawing.Size(78, 16);
         this.label12.TabIndex = 25;
         this.label12.Text = "Картинка";
         // 
         // button9
         // 
         this.button9.Location = new System.Drawing.Point(220, 534);
         this.button9.Name = "button9";
         this.button9.Size = new System.Drawing.Size(143, 43);
         this.button9.TabIndex = 24;
         this.button9.Text = "Добавить новый телефон";
         this.button9.UseVisualStyleBackColor = true;
         this.button9.Click += new System.EventHandler(this.button9_Click);
         // 
         // button8
         // 
         this.button8.Location = new System.Drawing.Point(38, 534);
         this.button8.Name = "button8";
         this.button8.Size = new System.Drawing.Size(141, 43);
         this.button8.TabIndex = 23;
         this.button8.Text = "Очистить поля";
         this.button8.UseVisualStyleBackColor = true;
         this.button8.Click += new System.EventHandler(this.button8_Click);
         // 
         // button7
         // 
         this.button7.Location = new System.Drawing.Point(38, 467);
         this.button7.Name = "button7";
         this.button7.Size = new System.Drawing.Size(141, 43);
         this.button7.TabIndex = 22;
         this.button7.Text = "Удалить опцию";
         this.button7.UseVisualStyleBackColor = true;
         this.button7.Click += new System.EventHandler(this.button7_Click);
         // 
         // button6
         // 
         this.button6.Location = new System.Drawing.Point(220, 467);
         this.button6.Name = "button6";
         this.button6.Size = new System.Drawing.Size(143, 43);
         this.button6.TabIndex = 21;
         this.button6.Text = "Добавить опцию";
         this.button6.UseVisualStyleBackColor = true;
         this.button6.Click += new System.EventHandler(this.button6_Click);
         // 
         // textBox9
         // 
         this.textBox9.Location = new System.Drawing.Point(220, 420);
         this.textBox9.Name = "textBox9";
         this.textBox9.Size = new System.Drawing.Size(143, 20);
         this.textBox9.TabIndex = 20;
         // 
         // label11
         // 
         this.label11.AutoSize = true;
         this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label11.ForeColor = System.Drawing.Color.Red;
         this.label11.Location = new System.Drawing.Point(35, 421);
         this.label11.Name = "label11";
         this.label11.Size = new System.Drawing.Size(131, 16);
         this.label11.TabIndex = 19;
         this.label11.Text = "Название опции";
         // 
         // button5
         // 
         this.button5.Location = new System.Drawing.Point(35, 351);
         this.button5.Name = "button5";
         this.button5.Size = new System.Drawing.Size(328, 49);
         this.button5.TabIndex = 18;
         this.button5.Text = "Сохранить изменения";
         this.button5.UseVisualStyleBackColor = true;
         this.button5.Click += new System.EventHandler(this.button5_Click);
         // 
         // checkedListBox1
         // 
         this.checkedListBox1.CheckOnClick = true;
         this.checkedListBox1.FormattingEnabled = true;
         this.checkedListBox1.Location = new System.Drawing.Point(35, 182);
         this.checkedListBox1.Name = "checkedListBox1";
         this.checkedListBox1.Size = new System.Drawing.Size(328, 154);
         this.checkedListBox1.TabIndex = 17;
         // 
         // textBox5
         // 
         this.textBox5.Location = new System.Drawing.Point(220, 147);
         this.textBox5.Name = "textBox5";
         this.textBox5.Size = new System.Drawing.Size(143, 20);
         this.textBox5.TabIndex = 16;
         // 
         // textBox6
         // 
         this.textBox6.Location = new System.Drawing.Point(220, 72);
         this.textBox6.Name = "textBox6";
         this.textBox6.Size = new System.Drawing.Size(143, 20);
         this.textBox6.TabIndex = 15;
         // 
         // textBox8
         // 
         this.textBox8.Location = new System.Drawing.Point(220, 6);
         this.textBox8.Name = "textBox8";
         this.textBox8.Size = new System.Drawing.Size(143, 20);
         this.textBox8.TabIndex = 13;
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label7.ForeColor = System.Drawing.Color.Red;
         this.label7.Location = new System.Drawing.Point(35, 147);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(45, 16);
         this.label7.TabIndex = 12;
         this.label7.Text = "Цена";
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label8.ForeColor = System.Drawing.Color.Blue;
         this.label8.Location = new System.Drawing.Point(32, 73);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(39, 16);
         this.label8.TabIndex = 11;
         this.label8.Text = "CPU";
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label9.ForeColor = System.Drawing.Color.Blue;
         this.label9.Location = new System.Drawing.Point(32, 40);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(29, 16);
         this.label9.TabIndex = 10;
         this.label9.Text = "OS";
         // 
         // label10
         // 
         this.label10.AutoSize = true;
         this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label10.ForeColor = System.Drawing.Color.Blue;
         this.label10.Location = new System.Drawing.Point(32, 10);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(64, 16);
         this.label10.TabIndex = 9;
         this.label10.Text = "Модель";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(735, 656);
         this.Controls.Add(this.tabControl1);
         this.Controls.Add(this.button4);
         this.Controls.Add(this.button3);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.listBox1);
         this.Name = "Form1";
         this.Text = "Mobile Store";
         tabPage1.ResumeLayout(false);
         tabPage1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.tabControl1.ResumeLayout(false);
         this.tabPage2.ResumeLayout(false);
         this.tabPage2.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.ListBox listBox1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.Button button3;
      private System.Windows.Forms.Button button4;
      private System.Windows.Forms.TabControl tabControl1;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.ListBox listBox2;
      private System.Windows.Forms.TextBox textBox4;
      private System.Windows.Forms.TextBox textBox3;
      private System.Windows.Forms.TextBox textBox2;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.TabPage tabPage2;
      private System.Windows.Forms.Button button9;
      private System.Windows.Forms.Button button8;
      private System.Windows.Forms.Button button7;
      private System.Windows.Forms.Button button6;
      private System.Windows.Forms.TextBox textBox9;
      private System.Windows.Forms.Label label11;
      private System.Windows.Forms.Button button5;
      private System.Windows.Forms.CheckedListBox checkedListBox1;
      private System.Windows.Forms.TextBox textBox5;
      private System.Windows.Forms.TextBox textBox6;
      private System.Windows.Forms.TextBox textBox8;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.Label label10;
      private System.Windows.Forms.Label label12;
      private System.Windows.Forms.ComboBox comboBox1;
      private System.Windows.Forms.TextBox textBox10;
      private System.Windows.Forms.Button button10;
   }
}


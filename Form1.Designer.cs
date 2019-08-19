namespace animation_object
{
    partial class Form_Animation_text
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_stop_animation = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button_Back = new System.Windows.Forms.Button();
            this.button_Print = new System.Windows.Forms.Button();
            this.button_Cansel = new System.Windows.Forms.Button();
            this.button_help = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.button_draw_variant = new System.Windows.Forms.Button();
            this.label_size_text = new System.Windows.Forms.Label();
            this.textBox_size_text = new System.Windows.Forms.TextBox();
            this.listBox_index_text_animation = new System.Windows.Forms.ListBox();
            this.label_animation = new System.Windows.Forms.Label();
            this.panel_options = new System.Windows.Forms.Panel();
            this.label_panel_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel_options.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_stop_animation
            // 
            this.button_stop_animation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_stop_animation.BackColor = System.Drawing.SystemColors.Control;
            this.button_stop_animation.Location = new System.Drawing.Point(57, 343);
            this.button_stop_animation.Name = "button_stop_animation";
            this.button_stop_animation.Size = new System.Drawing.Size(394, 35);
            this.button_stop_animation.TabIndex = 0;
            this.button_stop_animation.Text = "Остановить анимацию";
            this.button_stop_animation.UseVisualStyleBackColor = false;
            this.button_stop_animation.Click += new System.EventHandler(this.button_stop_animation_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.BackColor = System.Drawing.Color.Black;
            this.trackBar1.Location = new System.Drawing.Point(67, 405);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(384, 45);
            this.trackBar1.SmallChange = 10;
            this.trackBar1.TabIndex = 1;
            this.trackBar1.TickFrequency = 100;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // button_Back
            // 
            this.button_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Back.BackColor = System.Drawing.SystemColors.Control;
            this.button_Back.Location = new System.Drawing.Point(9, 473);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(129, 33);
            this.button_Back.TabIndex = 2;
            this.button_Back.Text = "Дублировать";
            this.button_Back.UseVisualStyleBackColor = false;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // button_Print
            // 
            this.button_Print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Print.BackColor = System.Drawing.SystemColors.Control;
            this.button_Print.Location = new System.Drawing.Point(144, 473);
            this.button_Print.Name = "button_Print";
            this.button_Print.Size = new System.Drawing.Size(129, 33);
            this.button_Print.TabIndex = 2;
            this.button_Print.Text = "Печать";
            this.button_Print.UseVisualStyleBackColor = false;
            this.button_Print.Click += new System.EventHandler(this.button_Print_Click);
            // 
            // button_Cansel
            // 
            this.button_Cansel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Cansel.BackColor = System.Drawing.SystemColors.Control;
            this.button_Cansel.Location = new System.Drawing.Point(279, 473);
            this.button_Cansel.Name = "button_Cansel";
            this.button_Cansel.Size = new System.Drawing.Size(129, 33);
            this.button_Cansel.TabIndex = 2;
            this.button_Cansel.Text = "Выход";
            this.button_Cansel.UseVisualStyleBackColor = false;
            this.button_Cansel.Click += new System.EventHandler(this.button_Cansel_Click);
            // 
            // button_help
            // 
            this.button_help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_help.BackColor = System.Drawing.SystemColors.Control;
            this.button_help.Location = new System.Drawing.Point(414, 473);
            this.button_help.Name = "button_help";
            this.button_help.Size = new System.Drawing.Size(129, 33);
            this.button_help.TabIndex = 2;
            this.button_help.Text = "Помощь";
            this.button_help.UseVisualStyleBackColor = false;
            this.button_help.Click += new System.EventHandler(this.button_help_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // printDocument1
            // 
           // this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(558, 362);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(108, 25);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Вариант 1";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(558, 393);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(108, 25);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Вариант 2";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.Color.White;
            this.radioButton3.Location = new System.Drawing.Point(558, 424);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(138, 25);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Свой вариант";
            this.radioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton3.UseVisualStyleBackColor = false;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // button_draw_variant
            // 
            this.button_draw_variant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_draw_variant.Location = new System.Drawing.Point(558, 458);
            this.button_draw_variant.Margin = new System.Windows.Forms.Padding(0);
            this.button_draw_variant.Name = "button_draw_variant";
            this.button_draw_variant.Size = new System.Drawing.Size(143, 51);
            this.button_draw_variant.TabIndex = 5;
            this.button_draw_variant.Text = "Нарисовать\r\nсвой вариант";
            this.button_draw_variant.UseVisualStyleBackColor = true;
            this.button_draw_variant.Visible = false;
            this.button_draw_variant.Click += new System.EventHandler(this.button_draw_variant_Click);
            // 
            // label_size_text
            // 
            this.label_size_text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_size_text.AutoSize = true;
            this.label_size_text.ForeColor = System.Drawing.Color.White;
            this.label_size_text.Location = new System.Drawing.Point(10, 35);
            this.label_size_text.Name = "label_size_text";
            this.label_size_text.Size = new System.Drawing.Size(67, 42);
            this.label_size_text.TabIndex = 6;
            this.label_size_text.Text = "Размер\r\nтекста";
            this.label_size_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_size_text
            // 
            this.textBox_size_text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_size_text.Location = new System.Drawing.Point(83, 43);
            this.textBox_size_text.Name = "textBox_size_text";
            this.textBox_size_text.Size = new System.Drawing.Size(74, 29);
            this.textBox_size_text.TabIndex = 7;
            this.textBox_size_text.Text = "200";
            this.textBox_size_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_size_text.TextChanged += new System.EventHandler(this.textBox_size_text_TextChanged);
            // 
            // listBox_index_text_animation
            // 
            this.listBox_index_text_animation.FormattingEnabled = true;
            this.listBox_index_text_animation.ItemHeight = 21;
            this.listBox_index_text_animation.Items.AddRange(new object[] {
            "По умолчанию",
            "Слева направо",
            "Сверху вниз"});
            this.listBox_index_text_animation.Location = new System.Drawing.Point(15, 120);
            this.listBox_index_text_animation.Name = "listBox_index_text_animation";
            this.listBox_index_text_animation.Size = new System.Drawing.Size(143, 25);
            this.listBox_index_text_animation.TabIndex = 8;
            this.listBox_index_text_animation.SelectedIndexChanged += new System.EventHandler(this.listBox_index_text_animation_SelectedIndexChanged);
            // 
            // label_animation
            // 
            this.label_animation.AutoSize = true;
            this.label_animation.ForeColor = System.Drawing.Color.White;
            this.label_animation.Location = new System.Drawing.Point(13, 96);
            this.label_animation.Name = "label_animation";
            this.label_animation.Size = new System.Drawing.Size(147, 21);
            this.label_animation.TabIndex = 9;
            this.label_animation.Text = "Режим анимации";
            this.label_animation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_options
            // 
            this.panel_options.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_options.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_options.Controls.Add(this.label_panel_name);
            this.panel_options.Controls.Add(this.label_animation);
            this.panel_options.Controls.Add(this.textBox_size_text);
            this.panel_options.Controls.Add(this.label_size_text);
            this.panel_options.Controls.Add(this.listBox_index_text_animation);
            this.panel_options.Location = new System.Drawing.Point(712, 351);
            this.panel_options.Name = "panel_options";
            this.panel_options.Size = new System.Drawing.Size(170, 152);
            this.panel_options.TabIndex = 10;
            this.panel_options.Visible = false;
            // 
            // label_panel_name
            // 
            this.label_panel_name.AutoSize = true;
            this.label_panel_name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_panel_name.ForeColor = System.Drawing.Color.White;
            this.label_panel_name.Location = new System.Drawing.Point(6, 5);
            this.label_panel_name.Name = "label_panel_name";
            this.label_panel_name.Size = new System.Drawing.Size(159, 22);
            this.label_panel_name.TabIndex = 10;
            this.label_panel_name.Text = "Панель настроек";
            // 
            // Form_Animation_text
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(894, 519);
            this.Controls.Add(this.panel_options);
            this.Controls.Add(this.button_draw_variant);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button_help);
            this.Controls.Add(this.button_Cansel);
            this.Controls.Add(this.button_Print);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button_stop_animation);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_Animation_text";
            this.Text = "Анимация текста";
            this.Load += new System.EventHandler(this.Form_Animation_text_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel_options.ResumeLayout(false);
            this.panel_options.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_stop_animation;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Button button_Print;
        private System.Windows.Forms.Button button_Cansel;
        private System.Windows.Forms.Button button_help;
        private System.Windows.Forms.Timer timer1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button button_draw_variant;
        private System.Windows.Forms.Label label_size_text;
        private System.Windows.Forms.TextBox textBox_size_text;
        private System.Windows.Forms.ListBox listBox_index_text_animation;
        private System.Windows.Forms.Label label_animation;
        private System.Windows.Forms.Panel panel_options;
        private System.Windows.Forms.Label label_panel_name;
    }
}


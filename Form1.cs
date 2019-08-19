using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace animation_object
{
    public partial class Form_Animation_text : Form
    {

        //верхняя прямоугольная линия  прямоугольника отстоит от оси Ох на расстояние boundary_of_rectangle_y
        int boundary_of_rectangle_y = 15;
        //левая вертикальная линия прямоугольника отстоит от Оу
        int boundary_of_rectangle_x = 15;
        //целочисленые переменные
        int Shift_of_Gradient = 10;
        int Step_of_Gradient = 5;
        //цвет фона и заливки
        Color _backgraund, _color_text;

        //переменные обновления
        int test_width = 0;
        int test_height = 0;
        //метод анимации
        int index=0;
      
        //размер текста
        int _w_text;
        int _h_text;
      /*  //точка рисования надпии по центру
        int Point_width_center;
        int Point_height_center;*/
        
        int _size_text=200;//размер текста
        string _str_size_text; //содержимое текст бокса



        public Form_Animation_text()
        {
            InitializeComponent();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Form_Animation_text myForm_animation = new Form_Animation_text();
            myForm_animation.Show();
        }

        private void button_Cansel_Click(object sender, EventArgs e)
        {
            Close();
        }
        //открытие формы "помощь"
        private void button_help_Click(object sender, EventArgs e)
        {
            Form_Animation_help myForm_help = new Form_Animation_help();
            myForm_help.Show();
            myForm_help.BackColor = _backgraund;
            myForm_help.ForeColor = _color_text;
        }

        private void Form_Animation_text_Load(object sender, EventArgs e)
        {
            //создаём объект и стираем другие изображения
            Graphics myGraphics = CreateGraphics();
            myGraphics.Clear(BackColor);


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //создаём объект myGraphis 
            
            Graphics myGraphics = CreateGraphics();
            //задаём тип шрифта, размер, стиль
            Font drawFont = new Font("Times New Roman", _size_text, FontStyle.Bold, GraphicsUnit.Point);
            string drawText = "56527";
            
            //задаём меру строки текста при помощи MeasureString:
            SizeF SizeF_of_Text = new SizeF(myGraphics.MeasureString(drawText, drawFont));
             _w_text= (int)SizeF_of_Text.Width;
             _h_text = (int)SizeF_of_Text.Height;
            //место начала рисования
             PointF Star_of_drawPointF = new PointF((this.Width - _w_text) / 2, (this.Height - _h_text - 200) / 2);
            //задаём координаты начальной и конечной точки градиента зиливки
            //изменяя координаты изменяется и анимационный эффект
             PointF Star_of_Gradient_of_drawPointerF = new PointF(0,0);
             PointF End_of_Gradient_of_drawPointerF = end_point();
            //создаём объект drawBrush класса LinearGradientBrush и задаём параметры для заливки
            LinearGradientBrush drawBrush = new 
                LinearGradientBrush(Star_of_Gradient_of_drawPointerF, End_of_Gradient_of_drawPointerF, _color_text, BackColor);
            //рисуем текст в центре прямоугольника
            myGraphics.DrawString(drawText, drawFont, drawBrush, Star_of_drawPointF);
            //сдвигаем градиент заливки текста на шаг shift_of_Gradient
            //заного начинаем цикл градиентной заливки
            //когда велечина Shift_of_Gradient досигает заданного значения
            Shift_of_Gradient = Shift_of_Gradient + Step_of_Gradient;
            if (Shift_of_Gradient >= this.Height)
                Step_of_Gradient = -5;
            else
                if (Shift_of_Gradient <= 5)
                    Step_of_Gradient = 5;

            //проверка на изменение размеров окна 
            if (test_height != (this.Height - _h_text - 200) / 2 || test_width != (this.Width - _w_text) / 2)
            {//если размер изменён, чситим фоновые рисунки
                myGraphics.Clear(BackColor);
                test_width = (this.Width - _w_text) / 2;
                test_height = (this.Height - _h_text - 200) / 2;
            }
            //высвобождаем ресурсы, выделенные объекту myGraphics;
            myGraphics.Dispose();

        }

        //определения точки конца и метода рисования градиента
        private PointF end_point()
        {
            PointF End_point_draw = new PointF(Shift_of_Gradient, 350);  //значение по умолчанию
            switch(index)
            {
                case 1:
                    {
                        End_point_draw = new PointF(Shift_of_Gradient, 0);
                        break;
                    }
                case 2:
                    {
                        End_point_draw = new PointF(0, Shift_of_Gradient);
                        break;
                    }
                case 3:
                    {
                        End_point_draw = new PointF(Shift_of_Gradient, Shift_of_Gradient);
                        break;
                    }
            }
            return End_point_draw;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = trackBar1.Value;

        }
        //пуск/пауза анимации
        bool OffOn = false; 
        private void button_stop_animation_Click(object sender, EventArgs e)
        {
            //задаём чередование остановки и возобновления анимации после каждого щелчка кнопки
            if (OffOn == false)
            {
                //останавливаем анимацию
                timer1.Enabled = false;
                //меняем значение OffOn на противоположное
                OffOn = true; // можно OffOn =! OffOn
            }
            else
            {
                //Возобновляем анимацию
                timer1.Enabled = true;
                OffOn = false; //возможность отключения анимации

            }

        }
        //////////////////////////////////////////////////////////////////////////////////////////////
        /*ВАРИАНТЫ RadioButton*/
        /////////////////////////////////////////////////////////////////////////////////////////////
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) 
            {
                _backgraund = Color.Black;
                 _color_text = Color.White;
                 filter_color(_backgraund, _color_text);

            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
             if (radioButton2.Checked == true) 
            {
                 _backgraund = Color.White;
                 
                 _color_text = Color.Red;
                 filter_color(_backgraund, _color_text);
                 
            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {

                button_draw_variant.Visible = true;
                panel_options.Visible = true;
                
            }
            else
            {
                button_draw_variant.Visible = false;
                panel_options.Visible = false;
                _size_text = 200;//устанавливаем исходный размер текста
            }
            
        }


        //////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////

        //ЦВЕТ ФОНА, ТЕКСТА И КОНТРОЛОВ
        private void filter_color(Color _color_contorl, Color color_text) //, Color _background_form
        {
            this.BackColor = _color_contorl;
            this.ForeColor = _color_text;


            button_stop_animation.BackColor = _color_contorl;
           
            trackBar1.BackColor = _color_contorl;

            button_Back.BackColor = _color_contorl;
           
            button_Print.BackColor = _color_contorl;
          
            button_Cansel.BackColor = _color_contorl;

            button_help.BackColor = _color_contorl;

            radioButton1.ForeColor = _color_text;
            radioButton2.ForeColor = _color_text;
            radioButton3.ForeColor = _color_text;

            label_panel_name.ForeColor = _color_text;
            label_size_text.ForeColor = _color_text;
            label_animation.ForeColor = _color_text;


            button_draw_variant.BackColor = _color_contorl;
        }

        //кнопка рисования своего варианта
        private void button_draw_variant_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Выберите цвета: \n 1.Цвет фона \n 2.Цвет текста");
            ColorDialog color_background = new ColorDialog();
            if (color_background.ShowDialog() == DialogResult.OK)
                _backgraund = color_background.Color;
            ColorDialog color_text = new ColorDialog();
            if (color_text.ShowDialog() == DialogResult.OK)
                _color_text = color_text.Color;
            Int32.TryParse(_str_size_text, out _size_text); //изменение размеров текста
            filter_color(_backgraund, _color_text); //установка цветовых значений формы/контролов/текста

        }

        //метод рисования по центру
        /*private void Point_draw()
        {
            int  _w_form = this.Width;
             int _h_form = this.Height;
            

              Point_width_center = (_w_form - _w_text)/2;
              Point_height_center = (_h_form -_h_text-200)/2;
             //Point_center_text = new Point(Point_width_center, Point_height_center);
              //MessageBox.Show(_w_form.ToString() + " " + _h_form.ToString() + " " + _w_text.ToString() + " " + _h_text.ToString());
           

        }*/

        private void textBox_size_text_TextChanged(object sender, EventArgs e)
        {
             _str_size_text = textBox_size_text.Text;
        }




        private void button_Print_Click(object sender, EventArgs e)
        {
            //передаём объекту printDialog1
            //информацию об объекте 
            //припомощи свойства
            //Document: 
            printDialog1.Document = printDocument1;
            //выводим стандартную панель Print при помощи метода ShowDialog() дл задания
            //параметров печати и после щелчка ОК на панели Print записываем документ 
            //при помощи метода Print
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }
        //печать текущего изображения.
        //НУЖНО ПРАВИТЬ
      /*          private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //создаём объект myGraphis 
            Graphics myGraphics = CreateGraphics();
            //связываем объект myGraphics с текущем принтером:
            myGraphics = e.Graphics;
            //рисуем линии прямоугольни, внутри него будет текст
 
            //задаём тип шрифта, размер, стиль
            Font drawFont = new Font("Times New Roman", 100, FontStyle.Bold, GraphicsUnit.Point);
            string drawText = "Visual";
            
            //задаём меру строки текста при помощи MeasureString:
            SizeF SizeF_of_Text = new SizeF(myGraphics.MeasureString(drawText, drawFont));
            
            //место начала рисования
            PointF Star_of_drawPointF = new PointF(Convert.ToSingle((width_of_rectangle - SizeF_of_Text.Width) / 2),
                Convert.ToSingle((height_of_rectangle - SizeF_of_Text.Width) / 2));
            //задаём координаты начальной и конечной точки градиента зиливки
            //изменяя координаты изменяется и анимационный эффект
            PointF Star_of_Gradient_of_drawPointerF = new PointF(0, 0);
            PointF End_of_Gradient_of_drawPointerF = new PointF(Shift_of_Gradient, 200);
            //создаём объект drawBrush класса LinearGradientBrush и задаём параметры для заливки
            LinearGradientBrush drawBrush = new
                LinearGradientBrush(Star_of_Gradient_of_drawPointerF, End_of_Gradient_of_drawPointerF, _color_text, BackColor);
            //рисуем текст в центре прямоугольника
            myGraphics.DrawString(drawText, drawFont, drawBrush, Star_of_Gradient_of_drawPointerF);
            //высвобождаем ресурсы, выделенные объекту myGraphics;
            myGraphics.Dispose();
            //сдвигаем градиент заливки текста на шаг shift_of_Gradient
            //заного начинаем цикл градиентной заливки
            //когда велечина Shift_of_Gradient досигает заданного значения
            Shift_of_Gradient = Shift_of_Gradient + Step_of_Gradient;
            if (Shift_of_Gradient == 500)
                Step_of_Gradient = -5;
            else
                if (Shift_of_Gradient == -50)
                    Step_of_Gradient = 5;



        }*/

                private void listBox_index_text_animation_SelectedIndexChanged(object sender, EventArgs e)
                {
                    index = listBox_index_text_animation.SelectedIndex;
                }
    }
}

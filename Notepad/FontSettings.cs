using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Notepad
    //прописать исключения для комбобокса
    //при изменении шрифта ранее утсановненный цвет сбрасывается 
    //цвет в шрифте а не в основной форме 
{
    public partial class FontSettings : Form
    {
        public int fontSize = 0;
        public System.Drawing.FontStyle fintFont = FontStyle.Regular;
        public System.Drawing.Color fontColor;
       
       
        public FontSettings()
        {
            InitializeComponent();
            fontBox.SelectedItem = fontBox.Items[0];
            styleBox.SelectedItem = styleBox.Items[0];
            colorClick.Select();
        }



        private void OnFontChanged(object sender, EventArgs e)
        {
          
                ExapleText.Font = new Font(ExapleText.Font.FontFamily, int.Parse(fontBox.SelectedItem.ToString()), ExapleText.Font.Style);
                fontSize = int.Parse(fontBox.SelectedItem.ToString());
            
                   
        }

        private void OnStyleChanged(object sender, EventArgs e)
        {
            switch (styleBox.SelectedItem.ToString())
            {
                case "Regular":
                    ExapleText.Font = new Font(ExapleText.Font.FontFamily, int.Parse(fontBox.SelectedItem.ToString()), FontStyle.Regular);
                    break;
                case "Italics":
                    ExapleText.Font = new Font(ExapleText.Font.FontFamily, int.Parse(fontBox.SelectedItem.ToString()), FontStyle.Italic);
                    break;
                case "Bold":
                    ExapleText.Font = new Font(ExapleText.Font.FontFamily, int.Parse(fontBox.SelectedItem.ToString()), FontStyle.Bold);
                    break;


            }
            fintFont = ExapleText.Font.Style;
        }

        private void ClickOk_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void OnColorChanged(object sender, EventArgs e)
        {

            colorDialog1.ShowDialog();
            ExapleText.ForeColor = colorDialog1.Color;
            fontColor = colorDialog1.Color;
          
        }

     
    }
}

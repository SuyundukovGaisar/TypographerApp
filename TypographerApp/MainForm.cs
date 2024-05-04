using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TypographerApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void StarttextBox_TextChanged(object sender, EventArgs e)
        {
            ResulttextBox.Text = FormatText(StarttextBox.Text);
        }
        public string FormatText(string text)
        {
            text = Replacingpoints(text);
            text = ReplacePlusMinus(text);
            text = ReplaceHyphen(text);
            text = ReplaceQuotationMarks(text);
            text = ReplaceWord(text);
            text = ReplacingExpression(text);
            text = LimitPunctuationMarks(text);
            text = RemoveExtraSpaces(text);

            return text;
        }
        //2 правило
        public string RemoveExtraSpaces(string text)
        {
            return Regex.Replace(text, @"\s+", " ");
        }
        //3 правило
        public string ReplaceQuotationMarks(string text)
        {
            StringBuilder builder = new StringBuilder();
            bool isOpeningQuote = true;

            foreach (char c in text)
            {
                if (c == '"')
                {
                    if (isOpeningQuote)
                    {
                        builder.Append('«');
                    }
                    else
                    {
                        builder.Append('»');
                    }

                    isOpeningQuote = !isOpeningQuote;
                }
                else
                {
                    builder.Append(c);
                }
            }

            return builder.ToString();
        }
        //6 правило
        public string ReplaceHyphen(string text)
        {
            return Regex.Replace(text, " - ", " — ");
        }
        //14 правило
        public string Replacingpoints(string text)
        {
            return Regex.Replace(text, @"\b([а-яё]\.|[А-ЯЁ]\.)", "$1 ", RegexOptions.IgnoreCase);
        }
        //9 правило
        public string ReplacePlusMinus(string text)
        {
            StringBuilder builder = new StringBuilder();
            bool isPlusMinus = false;

            foreach (char c in text)
            {
                if (c == '+')
                {
                    isPlusMinus = true;
                }
                else if (c == '-' && isPlusMinus)
                {
                    builder.Append('±');
                    isPlusMinus = false;
                }
                else
                {
                    if (isPlusMinus)
                    {
                        builder.Append('+');
                        isPlusMinus = false;
                    }
                    builder.Append(c);
                }
            }

            if (isPlusMinus)
            {
                builder.Append('+');
            }

            return builder.ToString();
        }
        public string ReplacingExpression(string text)
        {
            return Regex.Replace(text, "хахаха", "=)", RegexOptions.IgnoreCase);
        }
        public string ReplaceWord(string text)
        {
            return Regex.Replace(text, "стыд", "кринж", RegexOptions.IgnoreCase);
        }
        public string LimitPunctuationMarks(string text)
        {
            int exclamationCount = 0;
            int questionCount = 0;
            int pointsCount = 0;
            int commaCount = 0;

            StringBuilder newtext = new StringBuilder();

            foreach (char c in text)
            {
                if (c == '!')
                {
                    if (exclamationCount < 3)
                    {
                        newtext.Append(c);
                        exclamationCount++;
                    }
                }
                else if (c == '?')
                {
                    if (questionCount < 3)
                    {
                        newtext.Append(c);
                        questionCount++;
                    }
                }
                else if (c == '.')
                {
                    if (pointsCount < 3)
                    {
                        newtext.Append(c);
                        pointsCount++;
                    }
                }
                else if (c == ',')
                {
                    if (commaCount < 3)
                    {
                        newtext.Append(c);
                        commaCount++;
                    }
                }
                else
                {
                    exclamationCount = 0;
                    questionCount = 0;
                    pointsCount = 0;
                    commaCount = 0;
                    newtext.Append(c);
                }
            }
            
            return newtext.ToString();
        }
        private void Deletebutton_Click(object sender, EventArgs e)
        {
            StarttextBox.Clear();
        }

        private void Copybutton_Click(object sender, EventArgs e)
        {
            string textToCopy = ResulttextBox.Text;
            Clipboard.SetText(textToCopy);
        }
    }
}

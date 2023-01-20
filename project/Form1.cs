using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        class Global
        {
            public static string CompareText;
            public static string FirstReference;
            public static string SecondReference;
            public static string ThirdReference;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonLoad1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                ofd1.Filter = "Text Files |*.txt|Word Documents |*.doc; *.docx|" + "All Files |*.*";
                ofd1.FilterIndex = 0;
                label_mainFileName.Text = ofd1.FileName;
                Global.CompareText = File.ReadAllText(ofd1.FileName);
                richTextBox_textMain.Text = File.ReadAllText(ofd1.FileName);
            }
        }

        private void btn_chooseReference1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd2 = new OpenFileDialog();
            if ( ofd2.ShowDialog() == DialogResult.OK)
            {
                ofd2.Filter = "Text Files |*.txt|Word Documents |*.doc; *.docx|" + "All Files |*.*";
                ofd2.FilterIndex = 0;
                label_referenceName1.Text = ofd2.FileName;
                Global.FirstReference = File.ReadAllText(ofd2.FileName);
            }
        }

        private void btn_chooseReference2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd3 = new OpenFileDialog();
            if ( ofd3.ShowDialog() == DialogResult.OK)
            {
                ofd3.Filter = "Text Files |*.txt|Word Documents |*.doc; *.docx|" + "All Files |*.*";
                ofd3.FilterIndex = 0;
                label_referenceName2.Text = ofd3.FileName;
                Global.SecondReference = File.ReadAllText(ofd3.FileName);
            }
        }

        private void btn_chooseReference3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd4 = new OpenFileDialog();
            if ( ofd4.ShowDialog() == DialogResult.OK)
            {
                ofd4.Filter = "Text Files |*.txt|Word Documents |*.doc; *.docx|" + "All Files |*.*";
                ofd4.FilterIndex = 0;
                label_referenceName3.Text = ofd4.FileName;
                Global.ThirdReference = File.ReadAllText(ofd4.FileName);
            }
        }

        private static int CalcLevenshteinDistance(string source, string target)
        {
            if ((source == null) || (target == null)) return 0;
            if ((source.Length == 0) || (target.Length == 0)) return 0;
            if (source == target) return source.Length;

            int sourceWordCount = source.Length;
            int targetWordCount = target.Length;

            if (sourceWordCount == 0)
                return targetWordCount;

            if (targetWordCount == 0)
                return sourceWordCount;

            int[,] distance = new int[sourceWordCount + 1, targetWordCount + 1];

            for (int i = 0; i <= sourceWordCount; distance[i, 0] = i++) ;
            for (int j = 0; j <= targetWordCount; distance[0, j] = j++) ;

            for (int i = 1; i <= sourceWordCount; i++)
            {
                for (int j = 1; j <= targetWordCount; j++)
                {
                    int cost = (target[j - 1] == source[i - 1]) ? 0 : 1;
                    distance[i, j] = Math.Min(Math.Min(distance[i - 1, j] + 1, distance[i, j - 1] + 1), distance[i - 1, j - 1] + cost);
                }
            }

            return distance[sourceWordCount, targetWordCount];
        }

        double CalculateSimilarity(string source, string target)
        {
            if ((source == null) || (target == null)) return 0.0;
            if ((source.Length == 0) || (target.Length == 0)) return 0.0;
            if (source == target) return 1.0;

            int stepsToSame = CalcLevenshteinDistance(source, target);
            return (1.0 - ((double)stepsToSame / (double)Math.Max(source.Length, target.Length)));
        }

        public string GetPercentFormat(CultureInfo culture)
        {
            if (culture == null)
            {
                culture = CultureInfo.CurrentCulture;
            }
            NumberFormatInfo nfi = culture.NumberFormat;
            var baseFormat = "0.################";
            var percentSymbol = "%";
            var negativeSign = nfi.NegativeSign;
            string customFormat = string.Empty;
            switch (nfi.PercentPositivePattern)
            {
                case 1:
                    customFormat += baseFormat + percentSymbol;
                    break;
                case 2:
                    customFormat += percentSymbol + baseFormat;
                    break;
                case 3:
                    customFormat += percentSymbol + " " + baseFormat;
                    break;
                case 0:
                default:
                    customFormat += baseFormat + " " + percentSymbol;
                    break;
            }
            customFormat += ";";
            switch (nfi.PercentNegativePattern)
            {
                case 1:
                    customFormat += negativeSign + baseFormat + percentSymbol;
                    break;
                case 2:
                    customFormat += negativeSign + percentSymbol + baseFormat;
                    break;
                case 3:
                    customFormat += percentSymbol + negativeSign + baseFormat;
                    break;
                case 4:
                    customFormat += percentSymbol + baseFormat + negativeSign;
                    break;
                case 5:
                    customFormat += baseFormat + negativeSign + percentSymbol;
                    break;
                case 6:
                    customFormat += baseFormat + percentSymbol + negativeSign;
                    break;
                case 7:
                    customFormat += negativeSign + percentSymbol + " " + baseFormat;
                    break;
                case 8:
                    customFormat += baseFormat + " " + percentSymbol + negativeSign;
                    break;
                case 9:
                    customFormat += percentSymbol + " " + baseFormat + negativeSign;
                    break;
                case 10:
                    customFormat += percentSymbol + " " + negativeSign + baseFormat;
                    break;
                case 11:
                    customFormat += baseFormat + negativeSign + " " + percentSymbol;
                    break;
                case 0:
                default:
                    customFormat += negativeSign + baseFormat + " " + percentSymbol;
                    break;
            }
            return customFormat;
        }

        private void btn_SplitAndCount_Click(object sender, EventArgs e)
        {
           string calcResults1 = CalculateSimilarity(Global.CompareText, Global.FirstReference).ToString("P", CultureInfo.InvariantCulture);
           labelResult1.Text = calcResults1;
           string calcResults2 = CalculateSimilarity(Global.CompareText, Global.SecondReference).ToString("P", CultureInfo.InvariantCulture);
           labelResult2.Text = calcResults2;
           string calcResults3 = CalculateSimilarity(Global.CompareText, Global.ThirdReference).ToString("P", CultureInfo.InvariantCulture);
           labelResult3.Text = calcResults3;
        }

        private void btn_clearMain_Click(object sender, EventArgs e)
        {
            label_mainFileName.Text = "Название файла...";
            richTextBox_textMain.Clear();
            Global.CompareText = null;
        }

        private void btn_clearReference1_Click(object sender, EventArgs e)
        {
            label_referenceName1.Text = "Название файла...";
            Global.FirstReference = null;
        }

        private void btn_clearReference2_Click(object sender, EventArgs e)
        {
            label_referenceName2.Text = "Название файла...";
            Global.SecondReference = null;
        }

        private void btn_clearReference3_Click(object sender, EventArgs e)
        {
            label_referenceName3.Text = "Название файла...";
            Global.ThirdReference = null;
        }
    }
}

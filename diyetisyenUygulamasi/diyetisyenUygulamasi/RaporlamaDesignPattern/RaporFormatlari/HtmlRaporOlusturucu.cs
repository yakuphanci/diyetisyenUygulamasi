using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diyetisyenUygulamasi.RaporlamaDesignPattern.RaporFormatlari
{
    class HtmlRaporOlusturucu : RaporImplementor
    {
        public HtmlRaporOlusturucu(RaporBilgi _raporBilgi) : base(_raporBilgi) { }

        private string getHastaBilgileri()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("<table>"));
            sb.AppendLine(string.Format("\t<tr>"));
            sb.AppendLine(string.Format("\t\t <td style=\"width:200px;\"><b>Ad:</b></td>"));
            sb.AppendLine(string.Format("\t\t <td> {0} </td>", raporBilgi.ad));
            sb.AppendLine(string.Format("\t</tr>"));
            sb.AppendLine(string.Format("\t<tr>"));
            sb.AppendLine(string.Format("\t\t <td style=\"width:200px;\"><b>Soyad:</b></td>"));
            sb.AppendLine(string.Format("\t\t <td> {0} </td>", raporBilgi.soyad));
            sb.AppendLine(string.Format("\t</tr>"));
            sb.AppendLine(string.Format("\t<tr>"));
            sb.AppendLine(string.Format("\t\t <td style=\"width:200px;\"><b>TCKNO:</b></td>"));
            sb.AppendLine(string.Format("\t\t <td> {0} </td>", raporBilgi.tckno));
            sb.AppendLine(string.Format("\t</tr>"));
            sb.AppendLine(string.Format("</table>"));
            return sb.ToString();
        }

        private string getTedaviBilgileri()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("<table>"));
            sb.AppendLine(string.Format("\t<tr>"));
            sb.AppendLine(string.Format("\t\t <td style=\"width:200px;\"><b>Hastalık:</b></td>"));
            sb.AppendLine(string.Format("\t\t <td> {0} </td>", raporBilgi.hastalikTuru));
            sb.AppendLine(string.Format("\t</tr>"));
            sb.AppendLine(string.Format("\t<tr>"));
            sb.AppendLine(string.Format("\t\t <td style=\"width:200px;\"><b>Diyet Yöntemi:</b></td>"));
            sb.AppendLine(string.Format("\t\t <td> {0} </td>", raporBilgi.diyetTuru));
            sb.AppendLine(string.Format("\t</tr>"));
            sb.AppendLine(string.Format("\t<tr>"));
            sb.AppendLine(string.Format("\t\t <td style=\"width:200px;\"><b>Diyet Açıklama:</b></td>"));
            sb.AppendLine(string.Format("\t\t <td> {0} </td>", raporBilgi.diyetBilgi.Replace("\n", "<br>")));
            sb.AppendLine(string.Format("\t</tr>"));
            sb.AppendLine(string.Format("</table>"));
            return sb.ToString();
        }

        private string getHtmlStyle()
        {
            StringBuilder sb = new StringBuilder();


            sb.AppendLine("<style>" +
                        "table {" +
                         " font-family: arial, sans-serif;" +
                          "border-collapse: collapse;" +
                         " width: 100%;" +
                        "}" +

                        "td, th {" +
                          "border: 1px solid #cccccc;" +
                          "text-align: left;" +
                         " padding: 8px;" +
                        "}" +

                        "tr:nth-child(even) {" +
                         " background-color: #dddddd;" +
                        "}" +
                        "</style>");
            return sb.ToString();
        }

        private void SaveFile(string path, string text)
        {
            FileStream fParameter = new FileStream(path, FileMode.Create, FileAccess.Write);
            StreamWriter m_WriterParameter = new StreamWriter(fParameter);
            m_WriterParameter.BaseStream.Seek(0, SeekOrigin.End);
            m_WriterParameter.Write(text);
            m_WriterParameter.Flush();
            m_WriterParameter.Close();
        }

        public override void RaporOlustur()
        {
            string outputName = "rapor_" + raporBilgi.ad + raporBilgi.soyad + "_" + DateTime.Now.ToString("ddMMyyyy") + ".html";
            string dirParameter = AppDomain.CurrentDomain.BaseDirectory + @"\HTML Raporlar\" + outputName;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(getHtmlStyle());
            sb.AppendLine(string.Format("<h3>Hasta Bilgileri:</h3>"));
            sb.AppendLine(getHastaBilgileri());
            sb.AppendLine(string.Format("<hr>"));
            sb.AppendLine(string.Format("<h3>Tedavi Bilgileri:</h3>"));
            sb.Append(getTedaviBilgileri());
            SaveFile(dirParameter, sb.ToString());
            System.Windows.Forms.MessageBox.Show(dirParameter + "\nKonumuna rapor oluşturulmuştur.");


        }

        public override void RaporOlusturTers()
        {
            string outputName = "rapor_Ters_" + raporBilgi.ad + raporBilgi.soyad + "_" + DateTime.Now.ToString("ddMMyyyy") + ".html";
            string dirParameter = AppDomain.CurrentDomain.BaseDirectory + @"\HTML Raporlar\" + outputName;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(getHtmlStyle());
            sb.AppendLine(string.Format("<h3>Tedavi Bilgileri:</h3>"));
            sb.Append(getTedaviBilgileri());
            sb.AppendLine(string.Format("<hr>"));
            sb.AppendLine(string.Format("<h3>Hasta Bilgileri:</h3>"));
            sb.AppendLine(getHastaBilgileri());
            SaveFile(dirParameter, sb.ToString());
            System.Windows.Forms.MessageBox.Show(dirParameter + "\nKonumuna rapor oluşturulmuştur.");
        }
    }
}

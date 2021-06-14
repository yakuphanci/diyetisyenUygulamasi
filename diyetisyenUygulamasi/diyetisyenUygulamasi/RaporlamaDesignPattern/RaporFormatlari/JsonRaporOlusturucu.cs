using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diyetisyenUygulamasi.RaporlamaDesignPattern.RaporFormatlari
{
    public class JsonRaporOlusturucu : RaporImplementor
    {
        public JsonRaporOlusturucu(RaporBilgi _raporBilgi) : base(_raporBilgi)
        {
        }

        private string getHastaBilgileri()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("{");
            sb.AppendLine(string.Format("\"hastaAdi\": \"{0}\",", raporBilgi.ad));
            sb.AppendLine(string.Format("\"hastaSoyadi\": \"{0}\",", raporBilgi.soyad));
            sb.AppendLine(string.Format("\"hastaTckno\": \"{0}\"", raporBilgi.tckno));
            sb.Append("}");
            return sb.ToString();
        }

        private string getTedaviBilgileri()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("{");
            sb.AppendLine(string.Format("\"hastalik\": \"{0}\",", raporBilgi.hastalikTuru));
            sb.AppendLine(string.Format("\"diyetYontemi\": \"{0}\",", raporBilgi.diyetTuru));
            sb.AppendLine(string.Format("\"diyetBilgi\": \"{0}\"", raporBilgi.diyetBilgi.Replace(Environment.NewLine, "\\n")));
            sb.Append("}");

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
            string outputName = "rapor_"+ raporBilgi.ad+raporBilgi.soyad + "_" + DateTime.Now.ToString("ddMMyyyy")+ ".json";
            string dirParameter = AppDomain.CurrentDomain.BaseDirectory + @"\JSON Raporlar\" + outputName;

            StringBuilder sb = new StringBuilder();
           
            sb.Append("[");
            sb.Append(getHastaBilgileri());
            sb.AppendLine(",");
            sb.Append(getTedaviBilgileri());
            sb.AppendLine("]");

            SaveFile(dirParameter, sb.ToString());


            System.Windows.Forms.MessageBox.Show(dirParameter + "\nKonumuna rapor oluşturulmuştur.");


        }

        public override void RaporOlusturTers()
        {
            string outputName = "rapor_Ters_" + raporBilgi.ad + raporBilgi.soyad + "_" + DateTime.Now.ToString("ddMMyyyy") + ".json";
            string dirParameter = AppDomain.CurrentDomain.BaseDirectory + @"\JSON Raporlar\" + outputName;

            StringBuilder sb = new StringBuilder();

            sb.Append("[");
            sb.Append(getTedaviBilgileri());
            sb.AppendLine(",");
            sb.Append(getHastaBilgileri());
            sb.AppendLine("]");

            SaveFile(dirParameter, sb.ToString());
            System.Windows.Forms.MessageBox.Show(dirParameter + "\nKonumuna rapor oluşturulmuştur.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace lab1builder
{
    public partial class ArticleBuilder : Form
    {
        ArticleBuilderC ABC = new ArticleBuilderC();

        string filepath,filename;
        public ArticleBuilder()
        {
            InitializeComponent();
            filepath = "";
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (ofdFile.ShowDialog() == DialogResult.OK)
            {
                filepath = ofdFile.FileName;
                if (filepath == "" || !(string.Equals(Path.GetExtension(filepath), ".txt", StringComparison.OrdinalIgnoreCase))){
                    lblRes.Text = "Ошибка загрузки файла!";
                    return;
                }
                filename = Path.GetFileNameWithoutExtension(filepath);
                ArticleBuilderC.Article article = ABC.ReadFile(filepath);
                if (article != null)
                {
                    ABC.WriteFile(Path.GetFullPath(filepath), filename, article);
                    lblRes.Text = "Успешно Преобразовал файл в json";
                }
                else
                    lblRes.Text = "Ошибка: Хеш хеш они курят хеш не соотвествуют!";
            }

        }
    }
}

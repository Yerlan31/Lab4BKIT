using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> list = new List<string>();
        private void buttonReadFile_Click(object sender, EventArgs e)
        {
            //выбираем файл через стандартное диалоговое окно
            OpenFileDialog txt = new OpenFileDialog();
            //Фильтр на TXT файлы
            txt.Filter = "Только текстовые файлы|*.txt";
            //если пользователь не выбрал файл
            if (txt.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Необходимо выбрать файл");
                return;
            }
            //разделители слов
            char[] separators = { '?', '.', ',', '!', '*','/', ' ', '\t', '\n'};
            Stopwatch timer = new Stopwatch();
            timer.Start();
            //считывание текста из файла
            string text = File.ReadAllText(txt.FileName);
            //удаление ненужных символов в начале и конце текста
            text = text.Trim(separators);
            //разделение строки на слова
            string[] textArray = text.Split(separators);
            //Запись слов в список
            foreach (string word in textArray)
            {
                if (!word.Contains("-"))
                //проверка на неповторяющиеся слова
                    if (!list.Contains(word))
                        list.Add(word);
            }
            timer.Stop();
            //запись даных из таймера
            this.textBoxReadTime.Text = timer.Elapsed.ToString();
            //this.listBoxFile.BeginUpdate();
            //this.listBoxFile.Items.Clear();
            //foreach (string word in list)
            //{
            //    this.listBoxFile.Items.Add(word);
            //}
            //this.listBoxFile.EndUpdate();

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //запись слова и его очистка
            string word = this.textBoxWord.Text.Trim();
            //Подтягиваем буквы вверх, чтобы не было проблем с регистром
            word = word.ToUpper();
            //запуск листбокса
            this.listBoxResults.BeginUpdate();
            this.listBoxResults.Items.Clear();
            Stopwatch timer = new Stopwatch();
            if (!string.IsNullOrWhiteSpace(word) && list.Count > 0)
            {
                //Проверка на случай отсутствия совпадений
                bool NoMatches = true;
                //запуск таймера
                timer.Start();
                foreach (string w in list)
                {
                    //идёт проверка слов в верхнем регистре
                    if (w.ToUpper().Contains(word))
                    {
                        this.listBoxResults.Items.Add(w);
                        NoMatches = false;
                    }
                }
                //остановка таймера
                timer.Stop();
                //Если совпадений всё же не нашлось
                if (NoMatches) this.listBoxResults.Items.Add("Нет сопадений");
            }
            else
            {
                MessageBox.Show("Необходимо отрыть файл и выбрать слово для поиска");
            }
            this.listBoxResults.EndUpdate();
            //запись даных из таймера
            this.textBoxSearchTime.Text = timer.Elapsed.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labelReadTime_Click(object sender, EventArgs e)
        {

        }
    }
}

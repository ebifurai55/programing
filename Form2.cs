using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Wpf;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AmaterasuVer1
{
    public partial class Form2 : Form
    {
        Form1 f1;
        private object webView21;

        public Form2(Form1 f)
        {
            f1 = f;
            InitializeComponent();
            listView1.View = View.Details;
            listView1.Columns.Add("名前", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("ページ", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("コメント", 100, HorizontalAlignment.Left);
            //listView1.Items.Add("FUJITSU").SubItems.Add("FMTOWNS");
            //listView1.Items.Add("Panasonic").SubItems.Add("calm");
            //listView1.Items.Add("Lenovo").SubItems.Add("Yoga710");
            //listView1.Items.Add("NEC").SubItems.Add("ValueStar");
            //listView1.Items.Add("NINTENDO").SubItems.Add("NintendoSwitch");
            //listView1.Items.Add("DELL").SubItems.Add("Precision");
        }
        //private void button1_Click(object sender, EventArgs e)
        //{

        //}
        //private void listView1_ListviewItemChlicked(object sender, EventArgs e)
        //{

        //}

        //private void listView1_MouseDown(object sender, MouseEventArgs e)
        //{
        //    MessageBox.Show("important");
        //}

        public void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string secondColumnValue = listView1.SelectedItems[0].SubItems[1].Text;
                string truncatedValue = secondColumnValue.Substring(0);

                //MessageBox.Show("選択した文字列は " + truncatedValue + " です。");


                ((f1)).webView21.CoreWebView2.Navigate(truncatedValue);
                //"https://www.google.com/search?q=" +

            }




            // ボタンのClickイベント・ハンドラ


        }

        private void button1_Click(object sender, EventArgs e)
        {
            FavoriteData data = new FavoriteData();
            listView1.Items.Add((f1).webView21.CoreWebView2.DocumentTitle).SubItems.Add((f1).webView21.CoreWebView2.Source);


        }
        public class FavoriteData
        {
            public string tiltle = "";
            public string url = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selcted = listView1.SelectedItems[0];
                listView1.Items.Remove(selcted);
            }
        }

        public void Form2_Load(object sender, EventArgs e)
        {
            var filePath = "list.csv";
            LoadCsvFile(filePath);
        }
        public void LoadCsvFile(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var fields = line.Split(',');

                    // Listview1にフィールドを追加する
                    var item = new ListViewItem(fields[0]);
                    for (int i = 1; i < fields.Length; i++)
                    {
                        item.SubItems.Add(fields[i]);
                    }

                    listView1.Items.Add(item);
                }
            }
        }
        private void SaveCsvFile(string filePath)
        {
            using (var writer = new StreamWriter(filePath))
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    var fields = new List<string>();
                    foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                    {
                        fields.Add(subItem.Text);
                    }
                    var line = string.Join(",", fields);
                    writer.WriteLine(line);
                }
            }
        }

        public void form2_closed(object sender, FormClosingEventArgs e)
        {
            var filePath = "list.csv";
            SaveCsvFile(filePath);
        }







    }
}

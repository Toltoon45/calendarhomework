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
using System.Xml;
using System.Xml.Serialization;


namespace the_calendar
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            labelTime.Text = DateTime.Now.ToLongTimeString();
            labelTimeYear.Text = DateTime.Now.ToLongDateString();
        }
        private void buttonAddCelebration_Click(object sender, EventArgs e)
        {
            //Добавить праздник
            Celebration celeb = new Celebration(dateTimePicker1.Text, textBox1.Text);

            celeb.date = dateTimePicker1.Text;
            celeb.name = textBox1.Text;

            listBox1.Items.Add(celeb);

        }
        //Путь к xml файлу
        string xmlPath_celeb = "celebrs.xml";
        string xmlPath_remind = "remind.xml";
        string title = "ListBoxContent";
        string itemTitle = "Item";
        string itemValue = "Value";
        private void button_save_celebrations_Click(object sender, EventArgs e)
        {
            try
            {
                //Создаём файл
                XmlDocument document = new XmlDocument();
                //Создание главного узла XML документа
                XmlNode rootNode = document.CreateElement(title);
                //Добавление узла в документ
                document.AppendChild(rootNode);

                //Пройтись по всем элементам ListDates
                foreach(var item in listBox1.Items)
                {
                    //Дочерний для rootNode узла
                    XmlNode itemNode = document.CreateElement(itemTitle);
                    //атрибут
                    XmlAttribute attribute = document.CreateAttribute(itemValue);
                    attribute.Value = item.ToString();
                    // Запись в itemNode созданного атрибута
                    itemNode.Attributes.Append(attribute);
                    //Запись в rootNode узла itemNode
                    rootNode.AppendChild(itemNode);
                }
                document.Save(xmlPath_celeb);
            }
            catch(Exception)
            {

            }
        }

        private void buttonShowCelebs_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlDocument document = new XmlDocument();
            document.Load(xmlPath_celeb);
            XmlNodeList ListBoxNodes = document.SelectNodes("//" + title + "/" + itemTitle);
            foreach (XmlNode ListBoxNode in ListBoxNodes)
            {
                listBox1.Items.Add(ListBoxNode.Attributes[itemValue].Value);
            }
        }


        private void buttonAddReminder_Click(object sender, EventArgs e)
        {
            Remind remind = new Remind(dateTimePicker2.Text, dateTimePicker2.Text, textBox1.Text);

            remind.date = dateTimePicker2.Text;
            remind.date_end = dateTimePicker3.Text;
            remind.name = textBox1.Text;

            listBox2.Items.Add(remind);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                //Создаём файл
                XmlDocument document = new XmlDocument();
                //Создание главного узла XML документа
                XmlNode rootNode = document.CreateElement(title);
                //Добавление узла в документ
                document.AppendChild(rootNode);

                //Пройтись по всем элементам ListDates
                foreach (var item in listBox2.Items)
                {
                    //Дочерний для rootNode узла
                    XmlNode itemNode = document.CreateElement(itemTitle);
                    //атрибут
                    XmlAttribute attribute = document.CreateAttribute(itemValue);
                    attribute.Value = item.ToString();
                    // Запись в itemNode созданного атрибута
                    itemNode.Attributes.Append(attribute);
                    //Запись в rootNode узла itemNode
                    rootNode.AppendChild(itemNode);
                }
                document.Save(xmlPath_remind);
            }
            catch (Exception)
            {

            }
        }
        private void buttonSaveReminds_Click(object sender, EventArgs e)
        {
            try
            {
                //Создаём файл
                XmlDocument document = new XmlDocument();
                //Создание главного узла XML документа
                XmlNode rootNode = document.CreateElement(title);
                //Добавление узла в документ
                document.AppendChild(rootNode);

                //Пройтись по всем элементам ListDates
                foreach (var item in listBox2.Items)
                {
                    //Дочерний для rootNode узла
                    XmlNode itemNode = document.CreateElement(itemTitle);
                    //атрибут
                    XmlAttribute attribute = document.CreateAttribute(itemValue);
                    attribute.Value = item.ToString();
                    // Запись в itemNode созданного атрибута
                    itemNode.Attributes.Append(attribute);
                    //Запись в rootNode узла itemNode
                    rootNode.AppendChild(itemNode);
                }
                document.Save(xmlPath_remind);
            }
            catch (Exception)
            {

            }
        }
        private void buttonShowRemind_Click(object sender, EventArgs e)
        {
            //Показать все напоминания
            listBox2.Items.Clear();
            XmlDocument document = new XmlDocument();
            document.Load(xmlPath_remind);
            XmlNodeList ListBoxNodes = document.SelectNodes("//" + title + "/" + itemTitle);
            foreach (XmlNode ListBoxNode in ListBoxNodes)
            {
                listBox2.Items.Add(ListBoxNode.Attributes[itemValue].Value);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Вкл/Выкл кнопок
            if(checkBox1.Checked == true)
            {
                buttonAddReminder.Enabled = true;
                buttonSaveReminds.Enabled = true;
                buttonDeleteReminder.Enabled = true;
                buttonShowRemind.Enabled = true;

                buttonSaveEditRemind.Enabled = true;

                listBox2.Enabled = true;

                buttonAddCelebration.Enabled = false;
                buttonSaveCelebrations.Enabled = false;
                buttonDeleteCeleb.Enabled = false;
                buttonShowCelebs.Enabled = false;

                buttonSaveEditCeleb.Enabled = false;

                listBox1.Enabled = false;

            }
            else
            {
                buttonAddReminder.Enabled = false;
                buttonSaveReminds.Enabled = false;
                buttonDeleteReminder.Enabled = false;
                buttonShowRemind.Enabled = false;

                buttonSaveEditRemind.Enabled = false;

                listBox2.Enabled = false;

                buttonAddCelebration.Enabled = true;
                buttonSaveCelebrations.Enabled = true;
                buttonDeleteCeleb.Enabled = true;
                buttonShowCelebs.Enabled = true;

                buttonSaveEditCeleb.Enabled = true;

                listBox1.Enabled = true;
            }

        }

        private void buttonDeleteCeleb_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void buttonDeleteReminder_Click(object sender, EventArgs e)
        {
            listBox2.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void buttonSaveEditRemind_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox2.Text);
            textBox2.Clear();
        }

        private void buttonSaveEditCeleb_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
            textBox2.Clear();
        }

        private void buttonAddToEdit_Click(object sender, EventArgs e)
        {           
            textBox2.Text = Convert.ToString(listBox1.SelectedItem);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }


}

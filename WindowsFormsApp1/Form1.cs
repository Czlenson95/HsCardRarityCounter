using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace HearthstoneCardRarityCounter
{
   
    public partial class Form1 : Form
    {
        [Serializable]
        public class DataToSerialize
        {
            public int commonCount;
            public int rareCount;
            public int epicCount;
            public int legendCount;
            public int cardOpenedSum;
        }

        DataToSerialize dataObj = new DataToSerialize();

        public static void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false)
        {
            using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, objectToWrite);
            }
        }

        public static T ReadFromBinaryFile<T>(string filePath)
        {
            using (Stream stream = File.Open(filePath, FileMode.Open))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                return (T)binaryFormatter.Deserialize(stream);
            }
        }

        public static void WriteToXmlFile<T>(string filePath, T objectToWrite, bool append = false) where T : new()
        {
            TextWriter writer = null;
            try
            {
                var serializer = new XmlSerializer(typeof(T));
                writer = new StreamWriter(filePath, append);
                serializer.Serialize(writer, objectToWrite);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }

        public static T ReadFromXmlFile<T>(string filePath) where T : new()
        {
            TextReader reader = null;
            try
            {
                var serializer = new XmlSerializer(typeof(T));
                reader = new StreamReader(filePath);
                return (T)serializer.Deserialize(reader);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }

        public Form1()
        {
            InitializeComponent();
            dataObj.commonCount = 0;
            dataObj.rareCount = 0;
            dataObj.epicCount = 0;
            dataObj.legendCount = 0;
            dataObj.cardOpenedSum = 0;
        }

        private void btnCommon_Click(object sender, EventArgs e)
        {
            dataObj.commonCount++;
            dataObj.cardOpenedSum++;
            lblCommon.Text = "Common: " + dataObj.commonCount;
            lblPacksSumCount.Text = "Packs Summary: " + dataObj.cardOpenedSum / 5;
        }

        private void btnRare_Click(object sender, EventArgs e)
        {
            dataObj.rareCount++;
            dataObj.cardOpenedSum++;
            lblRare.Text = "Rare: " + dataObj.rareCount;
            lblPacksSumCount.Text = "Packs Summary: " + dataObj.cardOpenedSum / 5;
        }

        private void btnEpic_Click(object sender, EventArgs e)
        {
            dataObj.epicCount++;
            dataObj.cardOpenedSum++;
            lblEpic.Text = "Epic: " + dataObj.epicCount;
            lblPacksSumCount.Text = "Packs Summary: " + dataObj.cardOpenedSum / 5;
        }

        private void btnLegend_Click(object sender, EventArgs e)
        {
            dataObj.legendCount++;
            dataObj.cardOpenedSum++;
            lblLegend.Text = "Legendary: " + dataObj.legendCount;
            lblPacksSumCount.Text = "Packs Summary: " + dataObj.cardOpenedSum / 5;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //WriteToBinaryFile<DataToSerialize>("file", dataObj);
            WriteToXmlFile<DataToSerialize>("data.xml", dataObj);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //dataObj = ReadFromBinaryFile<DataToSerialize>("file");
            dataObj = ReadFromXmlFile<DataToSerialize>("data.xml");
            lblCommon.Text = "Common: " + dataObj.commonCount;
            lblRare.Text = "Rare: " + dataObj.rareCount;
            lblEpic.Text = "Epic: " + dataObj.epicCount;
            lblLegend.Text = "Legendary: " + dataObj.legendCount;
            lblPacksSumCount.Text = "Packs Summary: " + dataObj.cardOpenedSum / 5;
        }
    }
}

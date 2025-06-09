using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Xml;
namespace Procesamiento_de_archivos
{
    public partial class Form1 : Form
    {
        private string currentCsvPath = "";
        private string currentXmlPath = "";
        private string currentJsonPath = "";
        public Form1()
        {
            InitializeComponent();


        }

        private void btnBrowsecsv_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
                ofd.Title = "Select CSV File";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    currentCsvPath = ofd.FileName;
                    btnLoadcsv.Enabled = true;
                }
            }
        }

        private void btnLoadcsv_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentCsvPath))
            {
                MessageBox.Show("Please select a file first", "Warning",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                dataGridViewCsv.DataSource = LoadCsvData(currentCsvPath);
                MessageBox.Show("CSV loaded successfully!", "Success",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading CSV: {ex.Message}", "Error",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable LoadCsvData(string filePath)
        {
            DataTable dt = new DataTable();

            using (StreamReader sr = new StreamReader(filePath))
            {
                string[] headers = sr.ReadLine().Split(',');
                foreach (string header in headers)
                {
                    dt.Columns.Add(header.Trim());
                }

                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(',');
                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < headers.Length && i < rows.Length; i++)
                    {
                        dr[i] = rows[i].Trim();
                    }
                    dt.Rows.Add(dr);
                }
            }

            return dt;
        }

        private void btnBrowsexml_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
                ofd.Title = "Select XML File";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    currentXmlPath = ofd.FileName;
                    btnLoadxml.Enabled = true;
                }
            }
        }

        private void btnLoadxml_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentXmlPath))
            {
                MessageBox.Show("Please select a file first", "Warning",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                dataGridViewXml.DataSource = LoadXmlData(currentXmlPath);
                MessageBox.Show("XML loaded successfully!", "Success",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading XML: {ex.Message}", "Error",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private DataTable LoadXmlData(string filePath)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Node Name");
            dt.Columns.Add("Node Value");
            dt.Columns.Add("Attributes");

            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);

            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                DataRow row = dt.NewRow();
                row["Node Name"] = node.Name;
                row["Node Value"] = node.InnerText;

                if (node.Attributes != null && node.Attributes.Count > 0)
                {
                    string attributes = "";
                    foreach (XmlAttribute attr in node.Attributes)
                    {
                        attributes += $"{attr.Name}={attr.Value}; ";
                    }
                    row["Attributes"] = attributes.Trim();
                }

                dt.Rows.Add(row);
            }

            return dt;
        }

        private void btnBrowsejson_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "JSON Files (*.json)|*.json|All Files (*.*)|*.*";
                ofd.Title = "Select JSON File";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    currentJsonPath = ofd.FileName;
                    btnLoadjson.Enabled = true;
                }
            }

        }

        private void btnLoadjson_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentJsonPath))
            {
                MessageBox.Show("Please select a JSON file first", "Warning",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                dataGridViewJson.DataSource = LoadJsonData(currentJsonPath);
                MessageBox.Show("JSON file loaded successfully", "Success",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading JSON: {ex.Message}", "Error",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private DataTable LoadJsonData(string filePath)
        {
            string jsonContent = File.ReadAllText(filePath);

            // Manejar tanto arrays como objetos individuales
            if (jsonContent.Trim().StartsWith("["))
            {
                // Es un array JSON
                JArray jsonArray = JArray.Parse(jsonContent);
                return JsonArrayToDataTable(jsonArray);
            }
            else
            {
                // Es un objeto JSON individual
                JObject jsonObject = JObject.Parse(jsonContent);
                return JsonObjectToDataTable(jsonObject);
            }
        }

        private DataTable JsonArrayToDataTable(JArray jsonArray)
        {
            DataTable dt = new DataTable();

            // Crear columnas basadas en las propiedades del primer elemento
            if (jsonArray.Count > 0)
            {
                JObject firstItem = (JObject)jsonArray[0];
                foreach (JProperty prop in firstItem.Properties())
                {
                    dt.Columns.Add(prop.Name);
                }
            }

            // Llenar datos
            foreach (JObject item in jsonArray)
            {
                DataRow row = dt.NewRow();
                foreach (JProperty prop in item.Properties())
                {
                    row[prop.Name] = prop.Value.ToString();
                }
                dt.Rows.Add(row);
            }

            return dt;
        }

        private DataTable JsonObjectToDataTable(JObject jsonObject)
        {
            DataTable dt = new DataTable();

            // Crear columnas
            dt.Columns.Add("Property");
            dt.Columns.Add("Value");

            // Llenar datos
            foreach (JProperty prop in jsonObject.Properties())
            {
                DataRow row = dt.NewRow();
                row["Property"] = prop.Name;
                row["Value"] = prop.Value.ToString();
                dt.Rows.Add(row);
            }

            return dt;
        }

    }
}

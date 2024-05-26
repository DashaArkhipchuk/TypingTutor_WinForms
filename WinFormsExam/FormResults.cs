using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace WinFormsExam
{
    public partial class FormResults : Form
    {
        private BindingList<Result> results;
        public FormResults()
        {
            InitializeComponent();
            LoadResults();
            InitializeDataBindings();
            nametb.ReadOnly = true;
            speedtb.ReadOnly = true;
            failstb.ReadOnly = true;
            timetb.ReadOnly = true;
            dp.Enabled = false;

            speedtb.KeyPress += textBox_KeyPress;
            failstb.KeyPress += textBox_KeyPress;
            timetb.KeyPress += textBox_KeyPress;
        }
        public FormResults(int speed, int numberfails, int timeSec, DateTime dt)
        {
            InitializeComponent();
            LoadResults();
            InitializeDataBindings();
            speedtb.Text = "" + speed;
            failstb.Text = "" + numberfails;
            timetb.Text = "" + timeSec;
            dp.Value = dt;

            speedtb.KeyPress += textBox_KeyPress;
            failstb.KeyPress += textBox_KeyPress;
            timetb.KeyPress += textBox_KeyPress;
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Suppress the key press
            }
        }

        private void InitializeDataBindings()
        {
            // Binding DataGridView
            datagrid.DataSource = results;

            // Button Click Events
            addButton.Click += AddButton_Click;
            saveButton.Click += SaveButton_Click;

            // FilterBox TextChanged Event
            FilterBox.TextChanged += FilterBox_TextChanged;
        }

        private void LoadResults()
        {
            results = new BindingList<Result>();

            if (File.Exists("Serialization.bin"))
            {
                BindingList<Result> loadedResults = BinaryLoad("Serialization.bin");
                if (loadedResults.Count == 0)
                {
                    results.Add(new Result { Name = "Default", NumberFails = 0, Speed = 55, TimeSeconds = 60 });
                }
                else
                {
                    foreach (var item in loadedResults)
                    {
                        results.Add(item);
                    }
                }
            }
            else
            {
                results.Add(new Result { Name = "Default", NumberFails = 0, Speed = 55, TimeSeconds = 60 });
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nametb.Text))
            {
                MessageBox.Show("Cannot add a record without a name");
                return;
            }

            var result = new Result
            {
                Name = nametb.Text,
                Speed = int.Parse(speedtb.Text),
                NumberFails = int.Parse(failstb.Text),
                TimeSeconds = int.Parse(timetb.Text),
                DateTime = dp.Value
            };
            results.Add(result);
            datagrid.DataSource = new BindingList<Result>(results.ToList());
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            BinarySave(results, "Serialization.bin");
            MessageBox.Show("Results saved!");
        }

        private void FilterBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter(FilterBox.Text);
        }

        private void ApplyFilter(string filter)
        {
            var filteredList = results.Where(r =>
                r.Name.Contains(filter) ||
                r.Speed.ToString().Contains(filter) ||
                r.NumberFails.ToString().Contains(filter) ||
                r.TimeSeconds.ToString().Contains(filter) ||
                r.DateTime.ToString("dd/MM/yyyy").Contains(filter)
            ).ToList();

            datagrid.DataSource = new BindingList<Result>(filteredList);
        }

        public static void BinarySave<T>(T obj, string file)
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (Stream stream = File.Create(file))
                {
                    formatter.Serialize(stream, obj);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static BindingList<Result> BinaryLoad(string file)
        {
            BindingList<Result> l = new BindingList<Result>();
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (Stream stream = File.OpenRead(file))
                {
                    l = (BindingList<Result>)(formatter.Deserialize(stream));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return l;
        }
    }

    [Serializable]
    public class Result
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int NumberFails { get; set; }
        public int TimeSeconds { get; set; }
        public DateTime DateTime { get; set; }


    }
}

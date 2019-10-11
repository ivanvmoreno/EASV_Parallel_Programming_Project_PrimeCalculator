using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeGeneratorGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClearGUI()
        {
            listBox.Items.Clear();
            stopWatchTime.Text = "0s";
        }

        private void AddToListBox(List<long> elements)
        {
            listBox.BeginUpdate();
            elements.ForEach(element => listBox.Items.Add(element));
            listBox.EndUpdate();
        }

        private void PerformCalculation(String type)
        {
            long start = Convert.ToInt64(startRange.Text);
            long end = Convert.ToInt64(endRange.Text);
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();

            Task.Factory
               .StartNew(
                    () => {
                        while (sw.IsRunning) {
                            stopWatchTime.Invoke(new Action(() => stopWatchTime.Text = $"{sw.ElapsedMilliseconds / 1000d:f3} sec."));
                            Task.Delay(100);
                        }
                    });

            Task.Factory
                .StartNew(() =>
                {
                    return type == "parallel"
                        ? PrimeGenerator.PrimeGenerator.GetPrimesParallel(start, end)
                        : PrimeGenerator.PrimeGenerator.GetPrimesSequential(start, end);
                })
                .ContinueWith((t) => {
                    sw.Stop();
                    AddToListBox(t.Result);
                }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void CalculateParallel_Click(object sender, EventArgs e)
        {
            ClearGUI();
            PerformCalculation("parallel");
        }

        private void CalculateSequential_Click(object sender, EventArgs e)
        {
            ClearGUI();
            PerformCalculation("sequential");
        }
    }
}

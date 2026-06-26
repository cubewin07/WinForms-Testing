using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Learning_GUI
{
    public partial class Form1 : Form
    {
        public PerformanceCounter CpuCounter { get; set; } = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        public PerformanceCounter ramCounter { get; set; } = new PerformanceCounter("Memory", "Available MBytes");
        public Form1()
        {
            InitializeComponent();
            poller.Start();
        }

        
        public void UpdatingMetrics(object source, EventArgs e)
        {
            Process[] current = Process.GetProcesses();
            List<ProcessSnapshot> snapshots = current.Select(p => new ProcessSnapshot()
            {
                Name = p.ProcessName,
                PID = p.Id,
                MemoryMB = p.WorkingSet64 / 1024 / 1024,
                RawProcess = p
            }).ToList();

            RefreshDgv(dataGridView1, snapshots);

            float cpu = CpuCounter.NextValue();
            float ram = ramCounter.NextValue();

            label1.Text = cpu.ToString();
            label2.Text = ram.ToString();
        }

        private void RefreshListBox<T>(ListBox listBox, List<T> list)
        {
            listBox.DataSource = null;
            listBox.DataSource = list;
        }

        private void RefreshDgv<T>(DataGridView view, List<T> list)
        {
            view.DataSource = null;
            view.DataSource = list;
        }
    }

    public class ProcessSnapshot
    {
        public string Name { get; set; }
        public int PID {  get; set; }

        public float MemoryMB { get; set; }

        public Process RawProcess { get; set; }

        private Button _killProcess;

        public ProcessSnapshot()
        {
            _killProcess = new Button()
            {


            };
        }
    }

}

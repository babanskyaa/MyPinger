using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;


namespace MyPinger
{

    public partial class FormMain : Form
    {
        Worker _worker = new Worker();
        List<HostTime> hosts = new List<HostTime>();
        List<Thread> threads = new List<Thread>();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void cbHosts_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btnEditHost.Enabled = true;
            btnDeleteHost.Enabled = true;
            tbEditHost.ReadOnly = false;
            tbEditTimeout.ReadOnly = false;
        }

        private void btnAddHost_Click(object sender, EventArgs e)
        {
            if (tbAddHost.Text != "" && tbAddTimeout.Text != "")
            {
                try
                {
                    IPHostEntry ip = Dns.GetHostEntry(tbAddHost.Text);
                    dgvHosts.Rows.Add();
                    dgvHosts.Rows[dgvHosts.RowCount - 1].Cells[0].Value = tbAddHost.Text;
                    dgvHosts.Rows[dgvHosts.RowCount - 1].Cells[1].Value = Int32.Parse(tbAddTimeout.Text);
                    dgvHosts.Rows[dgvHosts.RowCount - 1].Cells[2].Value = "...";
                    cbHosts.Items.Add(tbAddHost.Text);
                    tbAddHost.Clear();
                    tbAddTimeout.Clear();
                    start();
                }
                catch (SocketException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (FormatException ex)
                {
                    dgvHosts.Rows.RemoveAt(dgvHosts.RowCount - 1);
                    MessageBox.Show("timeout: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
            }
        }

        private void btnEditHost_Click(object sender, EventArgs e)
        {
            if (tbEditHost.Text != "" && tbEditTimeout.Text != "")
            {
                try
                {
                    IPHostEntry ip = Dns.GetHostEntry(tbEditHost.Text);
                    hosts[cbHosts.SelectedIndex].host = ip.AddressList[0].ToString();
                    hosts[cbHosts.SelectedIndex].timeout = Int32.Parse(tbEditTimeout.Text);
                    dgvHosts.Rows[cbHosts.SelectedIndex].Cells[0].Value = tbEditHost.Text;
                    dgvHosts.Rows[cbHosts.SelectedIndex].Cells[1].Value = tbEditTimeout.Text;
                    dgvHosts.Rows[cbHosts.SelectedIndex].Cells[2].Value = "...";
                    cbHosts.Items[cbHosts.SelectedIndex] = tbEditHost.Text;
                    tbEditHost.Clear();
                    tbEditTimeout.Clear();
                    start();
                }
                catch (SocketException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("timeout: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
            }
        }

        private void btnDeleteHost_Click(object sender, EventArgs e)
        {
            try
            {
                hosts.RemoveAt(cbHosts.SelectedIndex);
                dgvHosts.Rows.RemoveAt(cbHosts.SelectedIndex);
                cbHosts.Items.RemoveAt(cbHosts.SelectedIndex);
                btnEditHost.Enabled = false;
                btnDeleteHost.Enabled = false;
                tbEditHost.ReadOnly = true;
                tbEditTimeout.ReadOnly = true;
                start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void start()
        {
            if (threads.Count > 0)
            {
                foreach (Thread t in threads)
                    t.Abort();
            }

            threads = new List<Thread>();
            hosts.Clear();

            foreach (DataGridViewRow row in dgvHosts.Rows)
            {
                try
                {
                    IPHostEntry ip = Dns.GetHostEntry(row.Cells[0].Value.ToString());
                    hosts.Add(new HostTime(ip.AddressList[0].ToString(), Int32.Parse(row.Cells[1].Value.ToString()), hosts.Count));
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
            for (int i = 0; i < hosts.Count; i++)
            {
                threads.Add(new Thread(_worker.work));
            }

            for (int i = 0; i < threads.Count; i++)
            {
                threads[i].IsBackground = true;
                threads[i].Start(hosts[i]);
            }
            _worker.ProcessChanged += worker_ProcessChanged;
            _worker.ProcessError += worker_ProcessError;
        }

        private void worker_ProcessChanged(int index, string status)
        {
            Action action = () => { dgvHosts.Rows[index].Cells[2].Value = status; };
            if (InvokeRequired)
                Invoke(action);
            else
                action();
        }

        private void worker_ProcessError(string error)
        {
            Action action = () => { MessageBox.Show(error); };
            if (InvokeRequired)
                Invoke(action);
            else
                action();
        }
    }
}
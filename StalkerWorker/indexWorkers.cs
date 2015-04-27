using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StalkerWorker
{
    public partial class indexWorkers : Form
    {
        public ManagerRedis redis = new ManagerRedis();
        public BindingList<Worker> listWorker = new BindingList<Worker>();
        public indexWorkers()
        {
            this.listWorker.Add(new WorkerTwitter(TypeSocialNetwork.Twitter));
            InitializeComponent();
            this.dataGridView1.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn statutColumn = new DataGridViewTextBoxColumn();
            statutColumn.DataPropertyName = "statut";
            statutColumn.HeaderText = "Statut";

            DataGridViewTextBoxColumn errorColumn = new DataGridViewTextBoxColumn();
            errorColumn.DataPropertyName = "error";
            errorColumn.HeaderText = "Erreur";

            DataGridViewTextBoxColumn pauseColumn = new DataGridViewTextBoxColumn();
            pauseColumn.DataPropertyName = "pause";
            pauseColumn.HeaderText = "En pause";

             DataGridViewTextBoxColumn type = new DataGridViewTextBoxColumn();
             type.DataPropertyName = "typeSocialNetwork";
             type.HeaderText = "Network";

             dataGridView1.Columns.Add(type);
             dataGridView1.Columns.Add(pauseColumn);
            dataGridView1.Columns.Add(statutColumn);
            dataGridView1.Columns.Add(errorColumn);
           
         
            this.dataGridView1.DataSource = this.listWorker;
        }

        private void buttonRedisStart_Click(object sender, EventArgs e)
        {
           
            Thread RedisThread = new Thread(redis.ThreadAddUserToQuery);
            RedisThread.Start();

        }

        private void timerRefreshRedisEntry_Tick(object sender, EventArgs e)
        {
            try
            {
                this.labelNumberEntryRedis.Text = this.redis.GetAll().Count().ToString();
            }
            catch (Exception)
            {
                
                
            }
        }

        private void indexWorkers_Load(object sender, EventArgs e)
        {
          
            
      //      dataGridView1.Refresh();
          
                       
        }

        private void buttonAddFacebook_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonAddTwitterCrawler_Click(object sender, EventArgs e)
        {
            WorkerTwitter workerTW = new WorkerTwitter(TypeSocialNetwork.Twitter);
            Thread threadWorker = new Thread(workerTW.work);
            threadWorker.Start();
            this.listWorker.Add(workerTW);
        }
    }
}

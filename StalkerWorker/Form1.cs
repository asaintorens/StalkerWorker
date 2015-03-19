using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StalkerWorker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.managerMongo = new ManagerMongo();
        }

        public StalkerFacebook stalkerFacebook;
        public ManagerMongo managerMongo;
        public int NumberThread;
        public List<StalkerFacebook> listStalker = new List<StalkerFacebook>();
        long lastNumberInMongo = 0;

        private void buttonStart_Click(object sender, EventArgs e)
            
        {
            Config.TOKEN_FB = this.textBoxToken.Text;
            try
            {

           
            this.NumberThread = int.Parse( this.LabelNumberThread.Text);

            for (int indexThread = 0; indexThread < this.NumberThread; indexThread++)
            {
                listStalker.Add(new StalkerFacebook(this.NumberThread, indexThread));
            }

            this.SetItem();

            foreach (StalkerFacebook stalk in listStalker)
            {
                System.Threading.Thread oneThreadWalker = new System.Threading.Thread(stalk.LunchWorker);
                oneThreadWalker.Start();
            }

            }
            catch (Exception ex)
            {

                this.labelError.Text = ex.Message;
            }
        }


        private void backgroundWorkerWalker_DoWork(object sender, DoWorkEventArgs e)
        {

           

         

         
        }

        private void addItem(ListViewItem item)
        {
            MethodInvoker invoke = delegate{

                this.listView1.Items.Add(item);
            };

            this.Invoke(invoke);
        }

        private void backgroundWorkerWalker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            StalkerFacebook stalk = (from x in this.listStalker where x.indexThread == e.ProgressPercentage select x).First();

           
          

          

        }

        private void timerDatabase_Tick(object sender, EventArgs e)
        {    
                this.SetItem();
        }

        public void SetItem()
        {
            this.listView1.Items.Clear();
            ListViewItem[] listView = new  ListViewItem[listStalker.Count];
            foreach (StalkerFacebook stalk in this.listStalker)
            {
                ListViewItem item = new ListViewItem();
              
                    item.Name = this.listView1.Columns[0].Name;
                    item.Text = stalk.indexThread.ToString();
                    ListViewItem.ListViewSubItem subItemProgression = new ListViewItem.ListViewSubItem();
                    subItemProgression.Name = this.listView1.Columns[1].Name;
                    subItemProgression.Text = stalk.progression.ToString();

                    ListViewItem.ListViewSubItem subItemProgressionPrenom = new ListViewItem.ListViewSubItem();
                    subItemProgressionPrenom.Name = this.listView1.Columns[2].Name;
                    subItemProgressionPrenom.Text = stalk.ProgressionDetailPrenom.ToString();

                    ListViewItem.ListViewSubItem subItemCurrentPrenom = new ListViewItem.ListViewSubItem();
                    subItemCurrentPrenom.Name = this.listView1.Columns[3].Name;
                    subItemCurrentPrenom.Text = stalk.currentPrenom.ToString();

                    item.SubItems.Add(subItemProgression);
                    item.SubItems.Add(subItemProgressionPrenom);
                    item.SubItems.Add(subItemCurrentPrenom);

                    listView[stalk.indexThread] = item;
                   
                 
            }
            MethodInvoker invoke = delegate
             {
                        this.listView1.Items.AddRange(listView);
                };

                this.Invoke(invoke);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timerDatabase_Tick_1(object sender, EventArgs e)
        {
            try
            {


            this.labelInputInMongo.Text = this.managerMongo.CountEntryInMongo().ToString();
            long numberInMongo = this.managerMongo.CountEntryInMongo();
            long numberAddedInTimeLaps = numberInMongo - this.lastNumberInMongo;

            this.labelInputSecond.Text = (numberAddedInTimeLaps).ToString();

            this.lastNumberInMongo = numberInMongo;
            }
            catch (Exception ex)
            {

                this.labelError.Text = ex.Message;
            }
        }
    }
}

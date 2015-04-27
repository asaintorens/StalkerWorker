namespace StalkerWorker
{
    partial class indexWorkers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonAddFacebook = new System.Windows.Forms.Button();
            this.buttonAddTwitterCrawler = new System.Windows.Forms.Button();
            this.buttonAddGoogle = new System.Windows.Forms.Button();
            this.buttonRedisStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNumberEntryRedis = new System.Windows.Forms.Label();
            this.timerRefreshRedisEntry = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSourceWorker = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceWorker)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddFacebook
            // 
            this.buttonAddFacebook.Location = new System.Drawing.Point(746, 12);
            this.buttonAddFacebook.Name = "buttonAddFacebook";
            this.buttonAddFacebook.Size = new System.Drawing.Size(137, 23);
            this.buttonAddFacebook.TabIndex = 0;
            this.buttonAddFacebook.Text = "Add FB Crawler";
            this.buttonAddFacebook.UseVisualStyleBackColor = true;
            this.buttonAddFacebook.Click += new System.EventHandler(this.buttonAddFacebook_Click);
            // 
            // buttonAddTwitterCrawler
            // 
            this.buttonAddTwitterCrawler.Location = new System.Drawing.Point(889, 12);
            this.buttonAddTwitterCrawler.Name = "buttonAddTwitterCrawler";
            this.buttonAddTwitterCrawler.Size = new System.Drawing.Size(137, 23);
            this.buttonAddTwitterCrawler.TabIndex = 1;
            this.buttonAddTwitterCrawler.Text = "Add TWITTER Crawler";
            this.buttonAddTwitterCrawler.UseVisualStyleBackColor = true;
            this.buttonAddTwitterCrawler.Click += new System.EventHandler(this.buttonAddTwitterCrawler_Click);
            // 
            // buttonAddGoogle
            // 
            this.buttonAddGoogle.Location = new System.Drawing.Point(1032, 12);
            this.buttonAddGoogle.Name = "buttonAddGoogle";
            this.buttonAddGoogle.Size = new System.Drawing.Size(137, 23);
            this.buttonAddGoogle.TabIndex = 2;
            this.buttonAddGoogle.Text = "Add G+ Crawler";
            this.buttonAddGoogle.UseVisualStyleBackColor = true;
            // 
            // buttonRedisStart
            // 
            this.buttonRedisStart.Location = new System.Drawing.Point(1032, 72);
            this.buttonRedisStart.Name = "buttonRedisStart";
            this.buttonRedisStart.Size = new System.Drawing.Size(137, 48);
            this.buttonRedisStart.TabIndex = 3;
            this.buttonRedisStart.Text = "Insert in redis";
            this.buttonRedisStart.UseVisualStyleBackColor = true;
            this.buttonRedisStart.Click += new System.EventHandler(this.buttonRedisStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1038, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Entry in REDIS :";
            // 
            // labelNumberEntryRedis
            // 
            this.labelNumberEntryRedis.AutoSize = true;
            this.labelNumberEntryRedis.Location = new System.Drawing.Point(1129, 182);
            this.labelNumberEntryRedis.Name = "labelNumberEntryRedis";
            this.labelNumberEntryRedis.Size = new System.Drawing.Size(13, 13);
            this.labelNumberEntryRedis.TabIndex = 5;
            this.labelNumberEntryRedis.Text = "0";
            // 
            // timerRefreshRedisEntry
            // 
            this.timerRefreshRedisEntry.Enabled = true;
            this.timerRefreshRedisEntry.Interval = 300;
            this.timerRefreshRedisEntry.Tick += new System.EventHandler(this.timerRefreshRedisEntry_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.bindingSourceWorker;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(619, 437);
            this.dataGridView1.TabIndex = 6;
            // 
            // indexWorkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 461);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelNumberEntryRedis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRedisStart);
            this.Controls.Add(this.buttonAddGoogle);
            this.Controls.Add(this.buttonAddTwitterCrawler);
            this.Controls.Add(this.buttonAddFacebook);
            this.Name = "indexWorkers";
            this.Text = "indexWorkers";
            this.Load += new System.EventHandler(this.indexWorkers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceWorker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddFacebook;
        private System.Windows.Forms.Button buttonAddTwitterCrawler;
        private System.Windows.Forms.Button buttonAddGoogle;
        private System.Windows.Forms.Button buttonRedisStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNumberEntryRedis;
        private System.Windows.Forms.Timer timerRefreshRedisEntry;
        private System.Windows.Forms.BindingSource bindingSourceWorker;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
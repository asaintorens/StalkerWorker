namespace StalkerWorker
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelCurrentName = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.button = new System.Windows.Forms.Button();
            this.timerRefreshUI = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.labelInputInMongo = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.indexWorker = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalProgression = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstNameProgression = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CurrentFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LabelNumberThread = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelInputSecond = new System.Windows.Forms.Label();
            this.timerDatabase = new System.Windows.Forms.Timer(this.components);
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCurrentName
            // 
            this.labelCurrentName.AutoSize = true;
            this.labelCurrentName.Location = new System.Drawing.Point(182, 152);
            this.labelCurrentName.Name = "labelCurrentName";
            this.labelCurrentName.Size = new System.Drawing.Size(0, 13);
            this.labelCurrentName.TabIndex = 3;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(545, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(189, 81);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "StartWalkerFB";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(877, 12);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(119, 47);
            this.button.TabIndex = 5;
            this.button.Text = "Pause";
            this.button.UseVisualStyleBackColor = true;
            // 
            // timerRefreshUI
            // 
            this.timerRefreshUI.Enabled = true;
            this.timerRefreshUI.Tick += new System.EventHandler(this.timerDatabase_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(543, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Input in Mongo DB :";
            // 
            // labelInputInMongo
            // 
            this.labelInputInMongo.AutoSize = true;
            this.labelInputInMongo.Location = new System.Drawing.Point(660, 184);
            this.labelInputInMongo.Name = "labelInputInMongo";
            this.labelInputInMongo.Size = new System.Drawing.Size(13, 13);
            this.labelInputInMongo.TabIndex = 7;
            this.labelInputInMongo.Text = "0";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.indexWorker,
            this.TotalProgression,
            this.FirstNameProgression,
            this.CurrentFirstName});
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(509, 600);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // indexWorker
            // 
            this.indexWorker.Text = "IndexWorker";
            this.indexWorker.Width = 94;
            // 
            // TotalProgression
            // 
            this.TotalProgression.Text = "TotalProgression";
            this.TotalProgression.Width = 149;
            // 
            // FirstNameProgression
            // 
            this.FirstNameProgression.Text = "FirstNameProgression";
            this.FirstNameProgression.Width = 144;
            // 
            // CurrentFirstName
            // 
            this.CurrentFirstName.Text = "CurrentFirstName";
            this.CurrentFirstName.Width = 136;
            // 
            // LabelNumberThread
            // 
            this.LabelNumberThread.Location = new System.Drawing.Point(545, 109);
            this.LabelNumberThread.Name = "LabelNumberThread";
            this.LabelNumberThread.Size = new System.Drawing.Size(100, 20);
            this.LabelNumberThread.TabIndex = 9;
            this.LabelNumberThread.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(546, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Input / sec :";
            // 
            // labelInputSecond
            // 
            this.labelInputSecond.AutoSize = true;
            this.labelInputSecond.Location = new System.Drawing.Point(609, 216);
            this.labelInputSecond.Name = "labelInputSecond";
            this.labelInputSecond.Size = new System.Drawing.Size(13, 13);
            this.labelInputSecond.TabIndex = 11;
            this.labelInputSecond.Text = "0";
            // 
            // timerDatabase
            // 
            this.timerDatabase.Enabled = true;
            this.timerDatabase.Interval = 1000;
            this.timerDatabase.Tick += new System.EventHandler(this.timerDatabase_Tick_1);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.DarkRed;
            this.labelError.Location = new System.Drawing.Point(545, 306);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 624);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelInputSecond);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelNumberThread);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.labelInputInMongo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelCurrentName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCurrentName;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Timer timerRefreshUI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelInputInMongo;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader indexWorker;
        private System.Windows.Forms.ColumnHeader TotalProgression;
        private System.Windows.Forms.ColumnHeader FirstNameProgression;
        private System.Windows.Forms.ColumnHeader CurrentFirstName;
        private System.Windows.Forms.TextBox LabelNumberThread;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelInputSecond;
        private System.Windows.Forms.Timer timerDatabase;
        private System.Windows.Forms.Label labelError;
    }
}


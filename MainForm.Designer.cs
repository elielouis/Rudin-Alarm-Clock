namespace Rudin
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.enableButton = new System.Windows.Forms.Button();
            this.comboPlugins = new System.Windows.Forms.ComboBox();
            this.groupTasks = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboDifficulty = new System.Windows.Forms.ComboBox();
            this.listViewTasks = new System.Windows.Forms.ListView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonSong = new System.Windows.Forms.Button();
            this.labelSongName = new System.Windows.Forms.Label();
            this.columnTaskName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDifficulty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.openSong = new System.Windows.Forms.OpenFileDialog();
            this.groupTasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(15, 89);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(152, 22);
            this.timePicker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wake up time:";
            // 
            // enableButton
            // 
            this.enableButton.Location = new System.Drawing.Point(261, 342);
            this.enableButton.Name = "enableButton";
            this.enableButton.Size = new System.Drawing.Size(216, 41);
            this.enableButton.TabIndex = 2;
            this.enableButton.Text = "Enable";
            this.enableButton.UseVisualStyleBackColor = true;
            this.enableButton.Click += new System.EventHandler(this.enableButton_Click);
            // 
            // comboPlugins
            // 
            this.comboPlugins.FormattingEnabled = true;
            this.comboPlugins.Location = new System.Drawing.Point(64, 39);
            this.comboPlugins.Name = "comboPlugins";
            this.comboPlugins.Size = new System.Drawing.Size(184, 24);
            this.comboPlugins.TabIndex = 3;
            // 
            // groupTasks
            // 
            this.groupTasks.Controls.Add(this.buttonRemove);
            this.groupTasks.Controls.Add(this.buttonAdd);
            this.groupTasks.Controls.Add(this.listViewTasks);
            this.groupTasks.Controls.Add(this.comboDifficulty);
            this.groupTasks.Controls.Add(this.label3);
            this.groupTasks.Controls.Add(this.label2);
            this.groupTasks.Controls.Add(this.comboPlugins);
            this.groupTasks.Location = new System.Drawing.Point(229, 35);
            this.groupTasks.Name = "groupTasks";
            this.groupTasks.Size = new System.Drawing.Size(541, 283);
            this.groupTasks.TabIndex = 4;
            this.groupTasks.TabStop = false;
            this.groupTasks.Text = "Task Selection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Task:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Difficulty:";
            // 
            // comboDifficulty
            // 
            this.comboDifficulty.FormattingEnabled = true;
            this.comboDifficulty.Location = new System.Drawing.Point(341, 39);
            this.comboDifficulty.Name = "comboDifficulty";
            this.comboDifficulty.Size = new System.Drawing.Size(183, 24);
            this.comboDifficulty.TabIndex = 6;
            // 
            // listViewTasks
            // 
            this.listViewTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTaskName,
            this.columnDifficulty});
            this.listViewTasks.FullRowSelect = true;
            this.listViewTasks.GridLines = true;
            this.listViewTasks.HideSelection = false;
            this.listViewTasks.Location = new System.Drawing.Point(18, 72);
            this.listViewTasks.Name = "listViewTasks";
            this.listViewTasks.Size = new System.Drawing.Size(506, 162);
            this.listViewTasks.TabIndex = 7;
            this.listViewTasks.UseCompatibleStateImageBehavior = false;
            this.listViewTasks.View = System.Windows.Forms.View.Details;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(88, 240);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(129, 37);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(305, 240);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(135, 37);
            this.buttonRemove.TabIndex = 9;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonSong
            // 
            this.buttonSong.Location = new System.Drawing.Point(15, 173);
            this.buttonSong.Name = "buttonSong";
            this.buttonSong.Size = new System.Drawing.Size(152, 30);
            this.buttonSong.TabIndex = 5;
            this.buttonSong.Text = "Browse";
            this.buttonSong.UseVisualStyleBackColor = true;
            this.buttonSong.Click += new System.EventHandler(this.buttonSong_Click);
            // 
            // labelSongName
            // 
            this.labelSongName.AutoSize = true;
            this.labelSongName.Location = new System.Drawing.Point(12, 233);
            this.labelSongName.Name = "labelSongName";
            this.labelSongName.Size = new System.Drawing.Size(0, 17);
            this.labelSongName.TabIndex = 6;
            // 
            // columnTaskName
            // 
            this.columnTaskName.Text = "Task";
            // 
            // columnDifficulty
            // 
            this.columnDifficulty.Text = "Difficulty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Song:";
            // 
            // openSong
            // 
            this.openSong.FileName = "openFileDialog1";
            this.openSong.Filter = resources.GetString("openSong.Filter");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 395);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelSongName);
            this.Controls.Add(this.buttonSong);
            this.Controls.Add(this.groupTasks);
            this.Controls.Add(this.enableButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Rudin Alarm Clock";
            this.groupTasks.ResumeLayout(false);
            this.groupTasks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button enableButton;
        private System.Windows.Forms.ComboBox comboPlugins;
        private System.Windows.Forms.GroupBox groupTasks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListView listViewTasks;
        private System.Windows.Forms.ComboBox comboDifficulty;
        private System.Windows.Forms.Button buttonSong;
        private System.Windows.Forms.Label labelSongName;
        private System.Windows.Forms.ColumnHeader columnTaskName;
        private System.Windows.Forms.ColumnHeader columnDifficulty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openSong;
    }
}


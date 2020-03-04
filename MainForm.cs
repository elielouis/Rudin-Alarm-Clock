using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using CaptchaPluginsFramework;
using Rudin.AlarmClock;



namespace Rudin
{
    public struct CaptchaTask
    {
        public CaptchaPluginBase captcha;
        public int difficulty;

        public CaptchaTask(CaptchaPluginBase c, int d)
        {
            captcha = c;
            difficulty = d;
        }
    }

    public partial class MainForm : Form, TAlarmObserver
    {
        private Dictionary<string, CaptchaPluginBase> _plugins;
        public static Dictionary<String, int> difficulties = new Dictionary<String, int>
        {
            { "Easy", 1},
            { "Medium", 2},
            { "Hard", 3},
            { "Very Hard", 4}
        };
        private AlarmHandler _alarmHandler;
        private bool _alarmEnabled;
        private string _songLocation;

        public MainForm(Dictionary<string, CaptchaPluginBase> plugins)
        {
            _plugins = plugins;
            _alarmEnabled = false;
            _songLocation = "";
            InitializeComponent();

            comboPlugins.DataSource = new BindingSource(_plugins, null);
            comboPlugins.DisplayMember = "Key";
            comboPlugins.ValueMember = "Value";

            comboDifficulty.DataSource = new BindingSource(difficulties, null);
            comboDifficulty.DisplayMember = "Key";
            comboDifficulty.ValueMember = "Value";

            labelSongName.Text = "";

            ResizeListView();  
        }

        void TAlarmObserver.Update()
        {
            MessageBox.Show("Test!!");
            List<CaptchaTask> captchaTasks = new List<CaptchaTask>();
            foreach (ListViewItem item in listViewTasks.Items)
            {
                captchaTasks.Add((CaptchaTask)item.Tag);
            }

        }

        private void ResizeListView()
        {
            listViewTasks.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewTasks.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void enableButton_Click(object sender, EventArgs e)
        {
            if (!_alarmEnabled)
            {
                DateTime time = timePicker.Value;
                Alarm alarm = new Alarm(time);
                _alarmHandler = new AlarmHandler(alarm);
                _alarmHandler.Attach(this);
                _alarmHandler.StartClock();

                if(_songLocation != "")
                {

                }

                enableButton.Text = "Disable";
                _alarmEnabled = true;
                MessageBox.Show("Alarm started!");
                
            }
            else
            {
                if(_alarmHandler != null)
                {
                    _alarmHandler.StopClock();
                }
                _alarmEnabled = false;
                enableButton.Text = "Enable";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(comboDifficulty.SelectedIndex == -1 )
            {
                MessageBox.Show("You must select at least one difficulty!");
                return;
            }
            if(comboPlugins.SelectedIndex == -1)
            {
                MessageBox.Show("You must select at least one task!");
                return;
            }
            KeyValuePair<string, int> chosen_difficulty = (KeyValuePair<string, int>)comboDifficulty.SelectedItem;
            KeyValuePair<string, CaptchaPluginBase> chosen_task = (KeyValuePair<string, CaptchaPluginBase>)comboPlugins.SelectedItem;
            string[] row = { chosen_task.Key, chosen_difficulty.Key};
            var item = new ListViewItem(row);
            item.Tag = new CaptchaTask(chosen_task.Value, chosen_difficulty.Value);
            listViewTasks.Items.Add(item);
            ResizeListView();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itemSelected in listViewTasks.SelectedItems)
            {
                listViewTasks.Items.Remove(itemSelected);
            }
            ResizeListView();
        }

        private void buttonSong_Click(object sender, EventArgs e)
        {
            DialogResult result = openSong.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openSong.FileName;
                _songLocation = file;
                string fileName = Path.GetFileName(file);
                if(fileName.Length > 24)
                    fileName = fileName.Substring(0, Math.Min(fileName.Length, 24)) + "...";
                labelSongName.Text = fileName;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using CaptchaPluginsFramework;
using Rudin.AlarmClock;
using Rudin.MusicMethods;
using AudioSwitcher.AudioApi.CoreAudio;

namespace Rudin
{
   
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
        private Logger.Logger _logger;

        public MainForm(Dictionary<string, CaptchaPluginBase> plugins)
        {
            _plugins = plugins;
            _alarmEnabled = false;
            _songLocation = "";
            _logger = Logger.Logger.Instance;
            InitializeComponent();

            comboPlugins.DataSource = new BindingSource(_plugins, null);
            comboPlugins.DisplayMember = "Key";
            comboPlugins.ValueMember = "Value";

            comboDifficulty.DataSource = new BindingSource(difficulties, null);
            comboDifficulty.DisplayMember = "Key";
            comboDifficulty.ValueMember = "Value";

            labelSongName.Text = "";
            labelEnabled.Text = "";

            ResizeListView();  
        }

        delegate void UpdateCallBack();

        void AlarmProcedure()
        {
            if (listViewTasks.InvokeRequired)
            {
                UpdateCallBack d = new UpdateCallBack(this.AlarmProcedure);
                this.Invoke(d);
            }
            else
            {
                List<CaptchaTask> captchaTasks = new List<CaptchaTask>();
                foreach (ListViewItem item in listViewTasks.Items)
                {
                    captchaTasks.Add((CaptchaTask)item.Tag);
                }
               
                MusicHandler musicHandler = MusicHandler.Instance;
                if (_songLocation != "")
                {
                    CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
                    _logger.LogMessage("Current Volume:" + defaultPlaybackDevice.Volume);
                    defaultPlaybackDevice.Volume = 20; // To change eventually... Make a configs file
                    musicHandler.PlaySong(_songLocation);
                }
                QuestionsForm questionsForm = new QuestionsForm(captchaTasks);
                this.Hide();
                questionsForm.ShowDialog();
                this.Show();

                _alarmEnabled = false;
                enableButton.Text = "Enable";
                labelEnabled.Text = "";
                timePicker.Enabled = true;
                musicHandler.StopSong();                
            }

        }

        void TAlarmObserver.UpdateAfterAlarm()
        {
            AlarmProcedure();
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
                if(listViewTasks.Items.Count == 0)
                {
                    MessageBox.Show("You need at least one task!");
                    return;
                }
                DateTime time = timePicker.Value;
                Alarm alarm = new Alarm(time);
                _alarmHandler = new AlarmHandler(alarm);
                _alarmHandler.Attach(this);
                _alarmHandler.StartClock();

                enableButton.Text = "Disable";
                timePicker.Enabled = false;
                _alarmEnabled = true;
                labelEnabled.Text = "ALARM ENABLED";
            }
            else
            {
                if(_alarmHandler != null)
                {
                    _alarmHandler.StopClock();
                }
                _alarmEnabled = false;
                enableButton.Text = "Enable";
                labelEnabled.Text = "";
                timePicker.Enabled = true;
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
                _logger.LogMessage(Path.GetExtension(file));
                IMusicPlayer musicPlayer = (new MusicPlayerCreator()).FactoryMethod(Path.GetExtension(file));
                MusicHandler.MusicPlayer = musicPlayer;
            }
        }
    }
}
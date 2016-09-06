using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using WMPLib;

namespace GtaV_Radio
{
    public partial class RadioPlayer : Form
    {
        private bool musicEmpty = true;
        private bool musicG = true;

        private string pathGtaV = (@"C:\Users\" + Environment.UserName + @"\Documents\Rockstar Games\GTA V\User Music\");
        private string pathSave = (@"C:\Users\" + Environment.UserName + @"\Music\Musics for gta v\");
        private string currentMusic = "";
        private string currentPath = "";

        private WindowsMediaPlayer Player;

        public RadioPlayer()
        {
            InitializeComponent();
            InitializeFolder();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void InitializeFolder()
        {
            Func<string, string, string> func = delegate (string before, string folderPath)
            {
                string str = "";
                for (int j = folderPath.Length; j < before.Length; j++)                
                    str = str + before[j];              
                return str;
            };
            list_gtav.Items.Clear();
            list_saved.Items.Clear();
            try
            {
                string[] files = Directory.GetFiles(pathGtaV, "*.mp3");
                foreach (string str in files)
                    list_gtav.Items.Add(Path.GetFileNameWithoutExtension(func(str, pathGtaV)));
            }
            catch
            {
                Directory.CreateDirectory(pathGtaV);
            }
            try
            {
                string[] strArray2 = Directory.GetFiles(pathSave, "*.mp3");
                foreach (string str in strArray2)
                    list_saved.Items.Add(Path.GetFileNameWithoutExtension(func(str, pathSave)));
            }
            catch
            {
                Directory.CreateDirectory(pathSave);
            }
            if (list_gtav.Items.Count < 4)
            {
                graphic_output.Text = "Warning : You have less than 4 music in gtaV songs, radio can't work !";
                graphic_output.ForeColor = Color.Red;
            }
            else if (!musicEmpty)
            {
                graphic_output.Text = "Current music : " + currentMusic;
                graphic_output.ForeColor = Color.Blue;
            }
            else
            {
                graphic_output.Text = "Select a music to listen !";
                graphic_output.ForeColor = Color.Green;
            }
        }

        private void trackbar_song_Scroll(object sender, EventArgs e)
        {
            if (!musicEmpty)
                Player.controls.currentPosition = trackbar_song.Value / 100.0 * Player.currentMedia.duration;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!musicEmpty)
            {
                if (Player.controls.currentPosition == Player.currentMedia.duration)                
                    button_reset_Click(new object(), new EventArgs());             
                try
                {
                    trackbar_song.Value = (int)((Player.controls.currentPosition / Player.currentMedia.duration) * 100.0);
                }
                catch
                {
                }
            }
        }

        private void StopMusic()
        {
            timer1.Enabled = false;
            try
            {
                this.Player.controls.stop();
            }
            catch
            {
            }
            Player = (WindowsMediaPlayer)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("6BF52A52-394A-11D3-B153-00C04F79FAA6")));
            button_play.Text = "Play";
            currentMusic = "";
            currentPath = "";
            musicEmpty = true;
            Text = "GTA V MUSIC";
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "mp3|*.mp3";
            dialog.Title = "Select a music";
            try
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                    File.Copy(dialog.FileName, pathGtaV + Path.GetFileName(dialog.FileName));
            }
            catch
            {
                MessageBox.Show("The music << \n" + Path.Combine(pathGtaV, dialog.FileName) + "\n >> already exist !", "ERROR");
            }
            Thread.Sleep(100);
            InitializeFolder();
        }

        private void button_gDelete_Click(object sender, EventArgs e)
        {
            if (list_gtav.SelectedItem != null)
            {
                if (((string)list_gtav.SelectedItem) == currentMusic)
                    StopMusic();

                if (MessageBox.Show("You want to delete : << \n" + this.list_gtav.SelectedItem + "\n >> From GTA V ?", "Are you sure ?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    File.Delete(pathGtaV + list_gtav.SelectedItem + ".mp3");
                    Thread.Sleep(100);
                    InitializeFolder();
                }
            }
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            if (musicEmpty)         
                MessageBox.Show("Select a music !");         
            else if (button_play.Text == "Play")
            {
                button_play.Text = "Pause";
                Player.controls.play();
            }
            else
            {
                button_play.Text = "Play";
                Player.controls.pause();
            }
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            this.InitializeFolder();
        }

        private void button_gmAll_Click(object sender, EventArgs e)
        {
            if (list_gtav.Items.Count != 0)
            {
                if (musicG)
                    StopMusic();
                foreach (string str in list_gtav.Items)
                {
                    try
                    {
                        File.Move(pathGtaV + str + ".mp3", pathSave + str + ".mp3");
                    }
                    catch
                    {
                        File.Delete(pathGtaV + str + ".mp3");
                    }
                }
                Thread.Sleep(100);
                InitializeFolder();
            }
        }

        private void button_gMove_Click(object sender, EventArgs e)
        {
            if (list_gtav.SelectedItem == null)           
                MessageBox.Show("You didn't select a music to move.", "ERROR");          
            else
            {
                if (currentMusic == ((string)list_gtav.SelectedItem))              
                    StopMusic();
                
                File.Move(pathGtaV + list_gtav.SelectedItem + ".mp3", pathSave + list_gtav.SelectedItem + ".mp3");
                Thread.Sleep(100);
                InitializeFolder();
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            if (!musicEmpty)
            {
                try
                {
                    Player.controls.stop();
                }
                catch
                {

                }
                Player = (WindowsMediaPlayer)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("6BF52A52-394A-11D3-B153-00C04F79FAA6")));
                Player.URL = currentPath;
                button_play.Text = "Pause";
                trackbar_song.Value = 0;
            }
        }

        private void button_sDelete_Click(object sender, EventArgs e)
        {
            if (this.list_saved.SelectedItem != null)
            {
                if (((string)this.list_saved.SelectedItem) == this.currentMusic)
                {
                    this.StopMusic();
                }
                if (MessageBox.Show("You want to delete : << \n" + this.list_saved.SelectedItem + "\n >> From music saved ?", "Are you sure ?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    File.Delete(this.pathSave + this.list_saved.SelectedItem + ".mp3");
                    Thread.Sleep(100);
                    this.InitializeFolder();
                }
            }
        }

        private void button_smAll_Click(object sender, EventArgs e)
        {
            if (this.list_saved.Items.Count != 0)
            {
                if (!this.musicG)
                {
                    this.StopMusic();
                }
                foreach (string str in this.list_saved.Items)
                {
                    try
                    {
                        File.Move(this.pathSave + str + ".mp3", this.pathGtaV + str + ".mp3");
                    }
                    catch
                    {
                        File.Delete(this.pathSave + str + ".mp3");
                    }
                }
                Thread.Sleep(100);
                this.InitializeFolder();
            }
        }

        private void button_sSelect_Click(object sender, EventArgs e)
        {
            if (list_saved.SelectedItem != null)
            {
                currentPath = pathSave + list_saved.SelectedItem + ".mp3";
                currentMusic = (string)list_saved.SelectedItem;
                musicEmpty = false;
                musicG = false;
                Text = "GTA V MUSIC - " + currentMusic;
                button_reset_Click(new object(), new EventArgs());
                timer1.Enabled = true;
                InitializeFolder();
            }
        }

        private void button_gSelect_Click(object sender, EventArgs e)
        {
            if (list_gtav.SelectedItem != null)
            {
                currentPath = pathGtaV + list_gtav.SelectedItem + ".mp3";
                currentMusic = (string)list_gtav.SelectedItem;
                musicEmpty = false;
                musicG = true;
                Text = "GTA V MUSIC - " + currentMusic;
                button_reset_Click(new object(), new EventArgs());
                timer1.Enabled = true;
                InitializeFolder();
            }
        }

        private void button_sMove_Click(object sender, EventArgs e)
        {
            if (list_saved.SelectedItem == null)           
                MessageBox.Show("You didn't select a music to move.", "ERROR");            
            else
            {
                if (currentMusic == ((string)list_saved.SelectedItem))                
                    StopMusic();               
                File.Move(pathSave + list_saved.SelectedItem + ".mp3", pathGtaV + list_saved.SelectedItem + ".mp3");
                Thread.Sleep(100);
                InitializeFolder();
            }
        }
    }
}

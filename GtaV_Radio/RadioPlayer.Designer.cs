namespace GtaV_Radio
{
    partial class RadioPlayer
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
            this.trackbar_song = new System.Windows.Forms.TrackBar();
            this.list_saved = new System.Windows.Forms.ListBox();
            this.list_gtav = new System.Windows.Forms.ListBox();
            this.button_refresh = new System.Windows.Forms.Button();
            this.button_play = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.graphic_output = new System.Windows.Forms.TextBox();
            this.graphic_saved = new System.Windows.Forms.TextBox();
            this.graphic_gtav = new System.Windows.Forms.TextBox();
            this.button_gmAll = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_gDelete = new System.Windows.Forms.Button();
            this.button_gMove = new System.Windows.Forms.Button();
            this.button_gSelect = new System.Windows.Forms.Button();
            this.button_sSelect = new System.Windows.Forms.Button();
            this.button_smAll = new System.Windows.Forms.Button();
            this.button_sDelete = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_sMove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_song)).BeginInit();
            this.SuspendLayout();
            // 
            // trackbar_song
            // 
            this.trackbar_song.Location = new System.Drawing.Point(36, 383);
            this.trackbar_song.Name = "trackbar_song";
            this.trackbar_song.Size = new System.Drawing.Size(453, 45);
            this.trackbar_song.TabIndex = 14;
            this.trackbar_song.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackbar_song.Scroll += new System.EventHandler(this.trackbar_song_Scroll);
            // 
            // list_saved
            // 
            this.list_saved.FormattingEnabled = true;
            this.list_saved.Location = new System.Drawing.Point(339, 35);
            this.list_saved.Name = "list_saved";
            this.list_saved.Size = new System.Drawing.Size(172, 342);
            this.list_saved.TabIndex = 13;
            // 
            // list_gtav
            // 
            this.list_gtav.FormattingEnabled = true;
            this.list_gtav.Location = new System.Drawing.Point(3, 35);
            this.list_gtav.Name = "list_gtav";
            this.list_gtav.Size = new System.Drawing.Size(181, 342);
            this.list_gtav.TabIndex = 12;
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(57, 463);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(75, 23);
            this.button_refresh.TabIndex = 11;
            this.button_refresh.Text = "refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // button_play
            // 
            this.button_play.Location = new System.Drawing.Point(57, 434);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(75, 23);
            this.button_play.TabIndex = 10;
            this.button_play.Text = "Play";
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // graphic_output
            // 
            this.graphic_output.Location = new System.Drawing.Point(77, 12);
            this.graphic_output.Name = "graphic_output";
            this.graphic_output.Size = new System.Drawing.Size(336, 20);
            this.graphic_output.TabIndex = 15;
            // 
            // graphic_saved
            // 
            this.graphic_saved.Location = new System.Drawing.Point(190, 357);
            this.graphic_saved.Name = "graphic_saved";
            this.graphic_saved.Size = new System.Drawing.Size(143, 20);
            this.graphic_saved.TabIndex = 16;
            // 
            // graphic_gtav
            // 
            this.graphic_gtav.Location = new System.Drawing.Point(190, 137);
            this.graphic_gtav.Name = "graphic_gtav";
            this.graphic_gtav.Size = new System.Drawing.Size(143, 20);
            this.graphic_gtav.TabIndex = 17;
            // 
            // button_gmAll
            // 
            this.button_gmAll.Location = new System.Drawing.Point(152, 463);
            this.button_gmAll.Name = "button_gmAll";
            this.button_gmAll.Size = new System.Drawing.Size(75, 23);
            this.button_gmAll.TabIndex = 18;
            this.button_gmAll.Text = "gmAll";
            this.button_gmAll.UseVisualStyleBackColor = true;
            this.button_gmAll.Click += new System.EventHandler(this.button_gmAll_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(57, 492);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 19;
            this.button_add.Text = "add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_gDelete
            // 
            this.button_gDelete.Location = new System.Drawing.Point(152, 434);
            this.button_gDelete.Name = "button_gDelete";
            this.button_gDelete.Size = new System.Drawing.Size(75, 23);
            this.button_gDelete.TabIndex = 20;
            this.button_gDelete.Text = "Delete";
            this.button_gDelete.UseVisualStyleBackColor = true;
            this.button_gDelete.Click += new System.EventHandler(this.button_gDelete_Click);
            // 
            // button_gMove
            // 
            this.button_gMove.Location = new System.Drawing.Point(152, 492);
            this.button_gMove.Name = "button_gMove";
            this.button_gMove.Size = new System.Drawing.Size(75, 23);
            this.button_gMove.TabIndex = 21;
            this.button_gMove.Text = "gMove";
            this.button_gMove.UseVisualStyleBackColor = true;
            this.button_gMove.Click += new System.EventHandler(this.button_gMove_Click);
            // 
            // button_gSelect
            // 
            this.button_gSelect.Location = new System.Drawing.Point(271, 434);
            this.button_gSelect.Name = "button_gSelect";
            this.button_gSelect.Size = new System.Drawing.Size(75, 23);
            this.button_gSelect.TabIndex = 22;
            this.button_gSelect.Text = "gSelect    ";
            this.button_gSelect.UseVisualStyleBackColor = true;
            this.button_gSelect.Click += new System.EventHandler(this.button_gSelect_Click);
            // 
            // button_sSelect
            // 
            this.button_sSelect.Location = new System.Drawing.Point(352, 434);
            this.button_sSelect.Name = "button_sSelect";
            this.button_sSelect.Size = new System.Drawing.Size(75, 23);
            this.button_sSelect.TabIndex = 23;
            this.button_sSelect.Text = "sSelect";
            this.button_sSelect.UseVisualStyleBackColor = true;
            this.button_sSelect.Click += new System.EventHandler(this.button_sSelect_Click);
            // 
            // button_smAll
            // 
            this.button_smAll.Location = new System.Drawing.Point(352, 463);
            this.button_smAll.Name = "button_smAll";
            this.button_smAll.Size = new System.Drawing.Size(75, 23);
            this.button_smAll.TabIndex = 24;
            this.button_smAll.Text = "smAll";
            this.button_smAll.UseVisualStyleBackColor = true;
            this.button_smAll.Click += new System.EventHandler(this.button_smAll_Click);
            // 
            // button_sDelete
            // 
            this.button_sDelete.Location = new System.Drawing.Point(352, 492);
            this.button_sDelete.Name = "button_sDelete";
            this.button_sDelete.Size = new System.Drawing.Size(75, 23);
            this.button_sDelete.TabIndex = 25;
            this.button_sDelete.Text = "sDelete";
            this.button_sDelete.UseVisualStyleBackColor = true;
            this.button_sDelete.Click += new System.EventHandler(this.button_sDelete_Click);
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(271, 463);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(75, 23);
            this.button_reset.TabIndex = 26;
            this.button_reset.Text = "reset";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_sMove
            // 
            this.button_sMove.Location = new System.Drawing.Point(271, 492);
            this.button_sMove.Name = "button_sMove";
            this.button_sMove.Size = new System.Drawing.Size(75, 23);
            this.button_sMove.TabIndex = 27;
            this.button_sMove.Text = "sMove";
            this.button_sMove.UseVisualStyleBackColor = true;
            this.button_sMove.Click += new System.EventHandler(this.button_sMove_Click);
            // 
            // RadioPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 525);
            this.Controls.Add(this.button_sMove);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_sDelete);
            this.Controls.Add(this.button_smAll);
            this.Controls.Add(this.button_sSelect);
            this.Controls.Add(this.button_gSelect);
            this.Controls.Add(this.button_gMove);
            this.Controls.Add(this.button_gDelete);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_gmAll);
            this.Controls.Add(this.graphic_gtav);
            this.Controls.Add(this.graphic_saved);
            this.Controls.Add(this.graphic_output);
            this.Controls.Add(this.trackbar_song);
            this.Controls.Add(this.list_saved);
            this.Controls.Add(this.list_gtav);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.button_play);
            this.Name = "RadioPlayer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_song)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackbar_song;
        private System.Windows.Forms.ListBox list_saved;
        private System.Windows.Forms.ListBox list_gtav;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox graphic_output;
        private System.Windows.Forms.TextBox graphic_saved;
        private System.Windows.Forms.TextBox graphic_gtav;
        private System.Windows.Forms.Button button_gmAll;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_gDelete;
        private System.Windows.Forms.Button button_gMove;
        private System.Windows.Forms.Button button_gSelect;
        private System.Windows.Forms.Button button_sSelect;
        private System.Windows.Forms.Button button_smAll;
        private System.Windows.Forms.Button button_sDelete;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_sMove;
    }
}


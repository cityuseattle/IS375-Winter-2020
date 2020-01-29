namespace AminElhamiPE04
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gloves = new System.Windows.Forms.CheckBox();
            this.skis = new System.Windows.Forms.CheckBox();
            this.goggles = new System.Windows.Forms.CheckBox();
            this.earmuffs = new System.Windows.Forms.CheckBox();
            this.helmet = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.display_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gloves
            // 
            this.gloves.AutoSize = true;
            this.gloves.Location = new System.Drawing.Point(18, 55);
            this.gloves.Name = "gloves";
            this.gloves.Size = new System.Drawing.Size(154, 29);
            this.gloves.TabIndex = 0;
            this.gloves.Text = "Snow Gloves";
            this.gloves.UseVisualStyleBackColor = true;
            this.gloves.CheckedChanged += new System.EventHandler(this.gloves_CheckedChanged);
            // 
            // skis
            // 
            this.skis.AutoSize = true;
            this.skis.Location = new System.Drawing.Point(18, 91);
            this.skis.Name = "skis";
            this.skis.Size = new System.Drawing.Size(76, 29);
            this.skis.TabIndex = 1;
            this.skis.Text = "Skis";
            this.skis.UseVisualStyleBackColor = true;
            this.skis.CheckedChanged += new System.EventHandler(this.skis_CheckedChanged);
            // 
            // goggles
            // 
            this.goggles.AutoSize = true;
            this.goggles.Location = new System.Drawing.Point(18, 127);
            this.goggles.Name = "goggles";
            this.goggles.Size = new System.Drawing.Size(111, 29);
            this.goggles.TabIndex = 2;
            this.goggles.Text = "Goggles";
            this.goggles.UseVisualStyleBackColor = true;
            this.goggles.CheckedChanged += new System.EventHandler(this.goggles_CheckedChanged);
            // 
            // earmuffs
            // 
            this.earmuffs.AutoSize = true;
            this.earmuffs.Location = new System.Drawing.Point(18, 162);
            this.earmuffs.Name = "earmuffs";
            this.earmuffs.Size = new System.Drawing.Size(115, 29);
            this.earmuffs.TabIndex = 3;
            this.earmuffs.Text = "Earmuffs";
            this.earmuffs.UseVisualStyleBackColor = true;
            this.earmuffs.CheckedChanged += new System.EventHandler(this.earmuffs_CheckedChanged);
            // 
            // helmet
            // 
            this.helmet.AutoSize = true;
            this.helmet.Location = new System.Drawing.Point(18, 198);
            this.helmet.Name = "helmet";
            this.helmet.Size = new System.Drawing.Size(99, 29);
            this.helmet.TabIndex = 4;
            this.helmet.Text = "Helmet";
            this.helmet.UseVisualStyleBackColor = true;
            this.helmet.CheckedChanged += new System.EventHandler(this.helmet_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(373, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(415, 401);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Please check items to purchase:";
            // 
            // display_button
            // 
            this.display_button.Location = new System.Drawing.Point(48, 276);
            this.display_button.Name = "display_button";
            this.display_button.Size = new System.Drawing.Size(106, 40);
            this.display_button.TabIndex = 7;
            this.display_button.Text = "Display";
            this.display_button.UseVisualStyleBackColor = true;
            this.display_button.Click += new System.EventHandler(this.display_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(200, 276);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(106, 40);
            this.clear_button.TabIndex = 8;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(48, 336);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(258, 40);
            this.exit_button.TabIndex = 9;
            this.exit_button.Text = "Exit Application";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.display_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.helmet);
            this.Controls.Add(this.earmuffs);
            this.Controls.Add(this.goggles);
            this.Controls.Add(this.skis);
            this.Controls.Add(this.gloves);
            this.Name = "Form1";
            this.Text = "Flyers Sports Club Sign-up Sheet";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox gloves;
        private System.Windows.Forms.CheckBox skis;
        private System.Windows.Forms.CheckBox goggles;
        private System.Windows.Forms.CheckBox earmuffs;
        private System.Windows.Forms.CheckBox helmet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button display_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button exit_button;
    }
}


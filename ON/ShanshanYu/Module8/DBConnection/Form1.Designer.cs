namespace DBConnection
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
         this.button1 = new System.Windows.Forms.Button();
         this.insert = new System.Windows.Forms.Button();
         this.update = new System.Windows.Forms.Button();
         this.delete = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // button1
         // 
         this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
         this.button1.Location = new System.Drawing.Point(58, 57);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(178, 91);
         this.button1.TabIndex = 0;
         this.button1.Text = "CONNECT";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // insert
         // 
         this.insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
         this.insert.Location = new System.Drawing.Point(58, 303);
         this.insert.Name = "insert";
         this.insert.Size = new System.Drawing.Size(178, 91);
         this.insert.TabIndex = 1;
         this.insert.Text = "INSERT";
         this.insert.UseVisualStyleBackColor = true;
         this.insert.Click += new System.EventHandler(this.insert_Click);
         // 
         // update
         // 
         this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
         this.update.Location = new System.Drawing.Point(565, 57);
         this.update.Name = "update";
         this.update.Size = new System.Drawing.Size(178, 91);
         this.update.TabIndex = 2;
         this.update.Text = "UPDATE";
         this.update.UseVisualStyleBackColor = true;
         this.update.Click += new System.EventHandler(this.update_Click);
         // 
         // delete
         // 
         this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
         this.delete.Location = new System.Drawing.Point(565, 303);
         this.delete.Name = "delete";
         this.delete.Size = new System.Drawing.Size(178, 91);
         this.delete.TabIndex = 3;
         this.delete.Text = "DELETE";
         this.delete.UseVisualStyleBackColor = true;
         this.delete.Click += new System.EventHandler(this.delete_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.delete);
         this.Controls.Add(this.update);
         this.Controls.Add(this.insert);
         this.Controls.Add(this.button1);
         this.Name = "Form1";
         this.Text = "Form1";
         this.ResumeLayout(false);

      }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
    }
}


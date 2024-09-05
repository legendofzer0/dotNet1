namespace GUI_LAB
{
    partial class NameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NameForm));
            LVLFirstName = new Label();
            LVLLastName = new Label();
            LVLSave = new Button();
            LVLExit = new Button();
            InputFirstName = new TextBox();
            InputLastName = new TextBox();
            textBox1 = new TextBox();
            InputAge = new TextBox();
            InputMobileNumber = new Label();
            LVLAge = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // LVLFirstName
            // 
            resources.ApplyResources(LVLFirstName, "LVLFirstName");
            LVLFirstName.Name = "LVLFirstName";
            LVLFirstName.Click += label1_Click;
            // 
            // LVLLastName
            // 
            resources.ApplyResources(LVLLastName, "LVLLastName");
            LVLLastName.Name = "LVLLastName";
            // 
            // LVLSave
            // 
            resources.ApplyResources(LVLSave, "LVLSave");
            LVLSave.BackColor = Color.Lime;
            LVLSave.ForeColor = SystemColors.HighlightText;
            LVLSave.Name = "LVLSave";
            LVLSave.UseVisualStyleBackColor = false;
            LVLSave.Click += button1_Click;
            // 
            // LVLExit
            // 
            resources.ApplyResources(LVLExit, "LVLExit");
            LVLExit.BackColor = Color.Red;
            LVLExit.ForeColor = Color.White;
            LVLExit.Name = "LVLExit";
            LVLExit.UseVisualStyleBackColor = false;
            // 
            // InputFirstName
            // 
            resources.ApplyResources(InputFirstName, "InputFirstName");
            InputFirstName.Name = "InputFirstName";
            // 
            // InputLastName
            // 
            resources.ApplyResources(InputLastName, "InputLastName");
            InputLastName.Name = "InputLastName";
            // 
            // textBox1
            // 
            resources.ApplyResources(textBox1, "textBox1");
            textBox1.Name = "textBox1";
            // 
            // InputAge
            // 
            resources.ApplyResources(InputAge, "InputAge");
            InputAge.Name = "InputAge";
            // 
            // InputMobileNumber
            // 
            resources.ApplyResources(InputMobileNumber, "InputMobileNumber");
            InputMobileNumber.Name = "InputMobileNumber";
            InputMobileNumber.Click += InputMobileNumber_Click;
            // 
            // LVLAge
            // 
            resources.ApplyResources(LVLAge, "LVLAge");
            LVLAge.Name = "LVLAge";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = SystemColors.Menu;
            label3.Name = "label3";
            label3.Click += label3_Click;
            // 
            // NameForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(InputAge);
            Controls.Add(InputMobileNumber);
            Controls.Add(LVLAge);
            Controls.Add(InputLastName);
            Controls.Add(InputFirstName);
            Controls.Add(LVLExit);
            Controls.Add(LVLSave);
            Controls.Add(LVLLastName);
            Controls.Add(LVLFirstName);
            ForeColor = SystemColors.MenuHighlight;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "NameForm";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LVLFirstName;
        private Label LVLLastName;
        private Button LVLSave;
        private Button LVLExit;
        private TextBox InputFirstName;
        private TextBox InputLastName;
        private TextBox textBox1;
        private TextBox InputAge;
        private Label InputMobileNumber;
        private Label LVLAge;
        private Label label3;
    }
}

namespace Analyzer
{
    partial class Form1_Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtCPU = new System.Windows.Forms.RichTextBox();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.ButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TabCPU = new System.Windows.Forms.TabPage();
            this.ButtonFocus = new System.Windows.Forms.Button();
            this.TabRAM = new System.Windows.Forms.TabPage();
            this.TxtRAM = new System.Windows.Forms.RichTextBox();
            this.TabGPU = new System.Windows.Forms.TabPage();
            this.TxtGPU = new System.Windows.Forms.RichTextBox();
            this.TabInterfaces = new System.Windows.Forms.TabPage();
            this.TxtInterfaces = new System.Windows.Forms.RichTextBox();
            this.TabHDD = new System.Windows.Forms.TabPage();
            this.TxtHDD = new System.Windows.Forms.RichTextBox();
            this.TabSystem = new System.Windows.Forms.TabPage();
            this.TxtSystem = new System.Windows.Forms.RichTextBox();
            this.TabServices = new System.Windows.Forms.TabPage();
            this.TxtServices = new System.Windows.Forms.RichTextBox();
            this.TabSoft = new System.Windows.Forms.TabPage();
            this.TxtSoft = new System.Windows.Forms.RichTextBox();
            this.TabProcesses = new System.Windows.Forms.TabPage();
            this.TxtProcesses = new System.Windows.Forms.RichTextBox();
            this.TabNetwork = new System.Windows.Forms.TabPage();
            this.TxtNetwork = new System.Windows.Forms.RichTextBox();
            this.TabOther = new System.Windows.Forms.TabPage();
            this.TxtOther = new System.Windows.Forms.RichTextBox();
            this.MenuStrip.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.TabCPU.SuspendLayout();
            this.TabRAM.SuspendLayout();
            this.TabGPU.SuspendLayout();
            this.TabInterfaces.SuspendLayout();
            this.TabHDD.SuspendLayout();
            this.TabSystem.SuspendLayout();
            this.TabServices.SuspendLayout();
            this.TabSoft.SuspendLayout();
            this.TabProcesses.SuspendLayout();
            this.TabNetwork.SuspendLayout();
            this.TabOther.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtCPU
            // 
            this.TxtCPU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCPU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtCPU.Location = new System.Drawing.Point(3, 3);
            this.TxtCPU.Name = "TxtCPU";
            this.TxtCPU.Size = new System.Drawing.Size(520, 305);
            this.TxtCPU.TabIndex = 3;
            this.TxtCPU.Text = "";
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MenuStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 337);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(534, 24);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // ButtonToolStripMenuItem
            // 
            this.ButtonToolStripMenuItem.Name = "ButtonToolStripMenuItem";
            this.ButtonToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.ButtonToolStripMenuItem.Text = "Button";
            this.ButtonToolStripMenuItem.Click += new System.EventHandler(this.ButtonToolStripMenuItem_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TabCPU);
            this.TabControl.Controls.Add(this.TabRAM);
            this.TabControl.Controls.Add(this.TabGPU);
            this.TabControl.Controls.Add(this.TabInterfaces);
            this.TabControl.Controls.Add(this.TabHDD);
            this.TabControl.Controls.Add(this.TabSystem);
            this.TabControl.Controls.Add(this.TabServices);
            this.TabControl.Controls.Add(this.TabSoft);
            this.TabControl.Controls.Add(this.TabProcesses);
            this.TabControl.Controls.Add(this.TabNetwork);
            this.TabControl.Controls.Add(this.TabOther);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(534, 337);
            this.TabControl.TabIndex = 3;
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // TabCPU
            // 
            this.TabCPU.Controls.Add(this.ButtonFocus);
            this.TabCPU.Controls.Add(this.TxtCPU);
            this.TabCPU.Location = new System.Drawing.Point(4, 22);
            this.TabCPU.Name = "TabCPU";
            this.TabCPU.Padding = new System.Windows.Forms.Padding(3);
            this.TabCPU.Size = new System.Drawing.Size(526, 311);
            this.TabCPU.TabIndex = 0;
            this.TabCPU.Text = "CPU";
            this.TabCPU.UseVisualStyleBackColor = true;
            // 
            // ButtonFocus
            // 
            this.ButtonFocus.Location = new System.Drawing.Point(-5, -40);
            this.ButtonFocus.Name = "ButtonFocus";
            this.ButtonFocus.Size = new System.Drawing.Size(0, 0);
            this.ButtonFocus.TabIndex = 0;
            this.ButtonFocus.UseVisualStyleBackColor = true;
            // 
            // TabRAM
            // 
            this.TabRAM.Controls.Add(this.TxtRAM);
            this.TabRAM.Location = new System.Drawing.Point(4, 22);
            this.TabRAM.Name = "TabRAM";
            this.TabRAM.Padding = new System.Windows.Forms.Padding(3);
            this.TabRAM.Size = new System.Drawing.Size(526, 311);
            this.TabRAM.TabIndex = 1;
            this.TabRAM.Text = "RAM";
            this.TabRAM.UseVisualStyleBackColor = true;
            // 
            // TxtRAM
            // 
            this.TxtRAM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtRAM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtRAM.Location = new System.Drawing.Point(3, 3);
            this.TxtRAM.Name = "TxtRAM";
            this.TxtRAM.Size = new System.Drawing.Size(520, 305);
            this.TxtRAM.TabIndex = 4;
            this.TxtRAM.Text = "";
            // 
            // TabGPU
            // 
            this.TabGPU.Controls.Add(this.TxtGPU);
            this.TabGPU.Location = new System.Drawing.Point(4, 22);
            this.TabGPU.Name = "TabGPU";
            this.TabGPU.Padding = new System.Windows.Forms.Padding(3);
            this.TabGPU.Size = new System.Drawing.Size(526, 311);
            this.TabGPU.TabIndex = 2;
            this.TabGPU.Text = "GPU";
            this.TabGPU.UseVisualStyleBackColor = true;
            // 
            // TxtGPU
            // 
            this.TxtGPU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtGPU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtGPU.Location = new System.Drawing.Point(3, 3);
            this.TxtGPU.Name = "TxtGPU";
            this.TxtGPU.Size = new System.Drawing.Size(520, 305);
            this.TxtGPU.TabIndex = 4;
            this.TxtGPU.Text = "";
            // 
            // TabInterfaces
            // 
            this.TabInterfaces.Controls.Add(this.TxtInterfaces);
            this.TabInterfaces.Location = new System.Drawing.Point(4, 22);
            this.TabInterfaces.Name = "TabInterfaces";
            this.TabInterfaces.Padding = new System.Windows.Forms.Padding(3);
            this.TabInterfaces.Size = new System.Drawing.Size(526, 311);
            this.TabInterfaces.TabIndex = 3;
            this.TabInterfaces.Text = "Interfaces";
            this.TabInterfaces.UseVisualStyleBackColor = true;
            // 
            // TxtInterfaces
            // 
            this.TxtInterfaces.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtInterfaces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtInterfaces.Location = new System.Drawing.Point(3, 3);
            this.TxtInterfaces.Name = "TxtInterfaces";
            this.TxtInterfaces.Size = new System.Drawing.Size(520, 305);
            this.TxtInterfaces.TabIndex = 4;
            this.TxtInterfaces.Text = "";
            // 
            // TabHDD
            // 
            this.TabHDD.Controls.Add(this.TxtHDD);
            this.TabHDD.Location = new System.Drawing.Point(4, 22);
            this.TabHDD.Name = "TabHDD";
            this.TabHDD.Padding = new System.Windows.Forms.Padding(3);
            this.TabHDD.Size = new System.Drawing.Size(526, 311);
            this.TabHDD.TabIndex = 4;
            this.TabHDD.Text = "HDD";
            this.TabHDD.UseVisualStyleBackColor = true;
            // 
            // TxtHDD
            // 
            this.TxtHDD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtHDD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtHDD.Location = new System.Drawing.Point(3, 3);
            this.TxtHDD.Name = "TxtHDD";
            this.TxtHDD.Size = new System.Drawing.Size(520, 305);
            this.TxtHDD.TabIndex = 4;
            this.TxtHDD.Text = "";
            // 
            // TabSystem
            // 
            this.TabSystem.Controls.Add(this.TxtSystem);
            this.TabSystem.Location = new System.Drawing.Point(4, 22);
            this.TabSystem.Name = "TabSystem";
            this.TabSystem.Padding = new System.Windows.Forms.Padding(3);
            this.TabSystem.Size = new System.Drawing.Size(526, 311);
            this.TabSystem.TabIndex = 5;
            this.TabSystem.Text = "System";
            this.TabSystem.UseVisualStyleBackColor = true;
            // 
            // TxtSystem
            // 
            this.TxtSystem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtSystem.Location = new System.Drawing.Point(3, 3);
            this.TxtSystem.Name = "TxtSystem";
            this.TxtSystem.Size = new System.Drawing.Size(520, 305);
            this.TxtSystem.TabIndex = 4;
            this.TxtSystem.Text = "";
            // 
            // TabServices
            // 
            this.TabServices.Controls.Add(this.TxtServices);
            this.TabServices.Location = new System.Drawing.Point(4, 22);
            this.TabServices.Name = "TabServices";
            this.TabServices.Padding = new System.Windows.Forms.Padding(3);
            this.TabServices.Size = new System.Drawing.Size(526, 311);
            this.TabServices.TabIndex = 6;
            this.TabServices.Text = "Services";
            this.TabServices.UseVisualStyleBackColor = true;
            // 
            // TxtServices
            // 
            this.TxtServices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtServices.Location = new System.Drawing.Point(3, 3);
            this.TxtServices.Name = "TxtServices";
            this.TxtServices.Size = new System.Drawing.Size(520, 305);
            this.TxtServices.TabIndex = 4;
            this.TxtServices.Text = "";
            // 
            // TabSoft
            // 
            this.TabSoft.Controls.Add(this.TxtSoft);
            this.TabSoft.Location = new System.Drawing.Point(4, 22);
            this.TabSoft.Name = "TabSoft";
            this.TabSoft.Padding = new System.Windows.Forms.Padding(3);
            this.TabSoft.Size = new System.Drawing.Size(526, 311);
            this.TabSoft.TabIndex = 7;
            this.TabSoft.Text = "Soft";
            this.TabSoft.UseVisualStyleBackColor = true;
            // 
            // TxtSoft
            // 
            this.TxtSoft.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSoft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtSoft.Location = new System.Drawing.Point(3, 3);
            this.TxtSoft.Name = "TxtSoft";
            this.TxtSoft.Size = new System.Drawing.Size(520, 305);
            this.TxtSoft.TabIndex = 4;
            this.TxtSoft.Text = "";
            // 
            // TabProcesses
            // 
            this.TabProcesses.Controls.Add(this.TxtProcesses);
            this.TabProcesses.Location = new System.Drawing.Point(4, 22);
            this.TabProcesses.Name = "TabProcesses";
            this.TabProcesses.Padding = new System.Windows.Forms.Padding(3);
            this.TabProcesses.Size = new System.Drawing.Size(526, 311);
            this.TabProcesses.TabIndex = 8;
            this.TabProcesses.Text = "Processes";
            this.TabProcesses.UseVisualStyleBackColor = true;
            // 
            // TxtProcesses
            // 
            this.TxtProcesses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtProcesses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtProcesses.Location = new System.Drawing.Point(3, 3);
            this.TxtProcesses.Name = "TxtProcesses";
            this.TxtProcesses.Size = new System.Drawing.Size(520, 305);
            this.TxtProcesses.TabIndex = 4;
            this.TxtProcesses.Text = "";
            // 
            // TabNetwork
            // 
            this.TabNetwork.Controls.Add(this.TxtNetwork);
            this.TabNetwork.Location = new System.Drawing.Point(4, 22);
            this.TabNetwork.Name = "TabNetwork";
            this.TabNetwork.Padding = new System.Windows.Forms.Padding(3);
            this.TabNetwork.Size = new System.Drawing.Size(526, 311);
            this.TabNetwork.TabIndex = 9;
            this.TabNetwork.Text = "Network";
            this.TabNetwork.UseVisualStyleBackColor = true;
            // 
            // TxtNetwork
            // 
            this.TxtNetwork.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNetwork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtNetwork.Location = new System.Drawing.Point(3, 3);
            this.TxtNetwork.Name = "TxtNetwork";
            this.TxtNetwork.Size = new System.Drawing.Size(520, 305);
            this.TxtNetwork.TabIndex = 4;
            this.TxtNetwork.Text = "";
            // 
            // TabOther
            // 
            this.TabOther.Controls.Add(this.TxtOther);
            this.TabOther.Location = new System.Drawing.Point(4, 22);
            this.TabOther.Name = "TabOther";
            this.TabOther.Padding = new System.Windows.Forms.Padding(3);
            this.TabOther.Size = new System.Drawing.Size(526, 311);
            this.TabOther.TabIndex = 10;
            this.TabOther.Text = "Other";
            this.TabOther.UseVisualStyleBackColor = true;
            // 
            // TxtOther
            // 
            this.TxtOther.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtOther.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtOther.Location = new System.Drawing.Point(3, 3);
            this.TxtOther.Name = "TxtOther";
            this.TxtOther.Size = new System.Drawing.Size(520, 305);
            this.TxtOther.TabIndex = 5;
            this.TxtOther.Text = "";
            // 
            // Form1_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.MenuStrip);
            this.KeyPreview = true;
            this.MainMenuStrip = this.MenuStrip;
            this.MinimumSize = new System.Drawing.Size(550, 400);
            this.Name = "Form1_Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analyzer";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_Main_KeyDown);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.TabCPU.ResumeLayout(false);
            this.TabRAM.ResumeLayout(false);
            this.TabGPU.ResumeLayout(false);
            this.TabInterfaces.ResumeLayout(false);
            this.TabHDD.ResumeLayout(false);
            this.TabSystem.ResumeLayout(false);
            this.TabServices.ResumeLayout(false);
            this.TabSoft.ResumeLayout(false);
            this.TabProcesses.ResumeLayout(false);
            this.TabNetwork.ResumeLayout(false);
            this.TabOther.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ButtonToolStripMenuItem;
        private System.Windows.Forms.TabPage TabCPU;
        private System.Windows.Forms.TabPage TabRAM;
        private System.Windows.Forms.Button ButtonFocus;
        private System.Windows.Forms.TabPage TabGPU;
        private System.Windows.Forms.TabPage TabInterfaces;
        private System.Windows.Forms.TabPage TabHDD;
        private System.Windows.Forms.TabPage TabSystem;
        private System.Windows.Forms.TabPage TabServices;
        private System.Windows.Forms.TabPage TabSoft;
        private System.Windows.Forms.TabPage TabProcesses;
        private System.Windows.Forms.TabPage TabNetwork;
        private System.Windows.Forms.TabPage TabOther;
        private System.Windows.Forms.TabControl TabControl;
        protected internal System.Windows.Forms.RichTextBox TxtCPU;
        protected internal System.Windows.Forms.RichTextBox TxtRAM;
        protected internal System.Windows.Forms.RichTextBox TxtGPU;
        protected internal System.Windows.Forms.RichTextBox TxtInterfaces;
        protected internal System.Windows.Forms.RichTextBox TxtHDD;
        protected internal System.Windows.Forms.RichTextBox TxtSystem;
        protected internal System.Windows.Forms.RichTextBox TxtServices;
        protected internal System.Windows.Forms.RichTextBox TxtSoft;
        protected internal System.Windows.Forms.RichTextBox TxtProcesses;
        protected internal System.Windows.Forms.RichTextBox TxtNetwork;
        protected internal System.Windows.Forms.RichTextBox TxtOther;
    }
}


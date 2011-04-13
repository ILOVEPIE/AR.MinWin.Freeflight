namespace AR.DroneWorkstation
{
    partial class InstrumentPanel
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addInstrumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.InstrumentHolder = new System.Windows.Forms.FlowLayoutPanel();
            this.verticalSpeedIndicator = new AviationInstruments.VerticalSpeedIndicatorInstrumentControl();
            this.altimeter = new AviationInstruments.AltimeterInstrumentControl();
            this.airSpeedIndicator = new AviationInstruments.AirSpeedIndicatorInstrumentControl();
            this.attitudeIndicator = new AviationInstruments.AttitudeIndicatorInstrumentControl();
            this.turnCoordinator = new AviationInstruments.TurnCoordinatorInstrumentControl();
            this.headingIndicator = new AviationInstruments.HeadingIndicatorInstrumentControl();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.InstrumentHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Enabled = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addInstrumentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(202, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // addInstrumentToolStripMenuItem
            // 
            this.addInstrumentToolStripMenuItem.Enabled = false;
            this.addInstrumentToolStripMenuItem.Name = "addInstrumentToolStripMenuItem";
            this.addInstrumentToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.addInstrumentToolStripMenuItem.Text = "Add Instrument";
            this.addInstrumentToolStripMenuItem.Visible = false;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.InstrumentHolder);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(488, 80);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(488, 80);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // InstrumentHolder
            // 
            this.InstrumentHolder.Controls.Add(this.verticalSpeedIndicator);
            this.InstrumentHolder.Controls.Add(this.altimeter);
            this.InstrumentHolder.Controls.Add(this.airSpeedIndicator);
            this.InstrumentHolder.Controls.Add(this.attitudeIndicator);
            this.InstrumentHolder.Controls.Add(this.turnCoordinator);
            this.InstrumentHolder.Controls.Add(this.headingIndicator);
            this.InstrumentHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InstrumentHolder.Location = new System.Drawing.Point(0, 0);
            this.InstrumentHolder.Name = "InstrumentHolder";
            this.InstrumentHolder.Size = new System.Drawing.Size(488, 80);
            this.InstrumentHolder.TabIndex = 0;
            // 
            // verticalSpeedIndicator
            // 
            this.verticalSpeedIndicator.Location = new System.Drawing.Point(3, 3);
            this.verticalSpeedIndicator.Name = "verticalSpeedIndicator";
            this.verticalSpeedIndicator.Size = new System.Drawing.Size(75, 75);
            this.verticalSpeedIndicator.TabIndex = 5;
            this.verticalSpeedIndicator.Text = "verticalSpeedIndicator";
            // 
            // altimeter
            // 
            this.altimeter.Location = new System.Drawing.Point(84, 3);
            this.altimeter.Name = "altimeter";
            this.altimeter.Size = new System.Drawing.Size(75, 75);
            this.altimeter.TabIndex = 4;
            this.altimeter.Text = "altimeter";
            // 
            // airSpeedIndicator
            // 
            this.airSpeedIndicator.Location = new System.Drawing.Point(165, 3);
            this.airSpeedIndicator.Name = "airSpeedIndicator";
            this.airSpeedIndicator.Size = new System.Drawing.Size(75, 75);
            this.airSpeedIndicator.TabIndex = 0;
            this.airSpeedIndicator.Text = "airSpeedIndicatorInstrumentControl1";
            // 
            // attitudeIndicator
            // 
            this.attitudeIndicator.Location = new System.Drawing.Point(246, 3);
            this.attitudeIndicator.Name = "attitudeIndicator";
            this.attitudeIndicator.Size = new System.Drawing.Size(75, 75);
            this.attitudeIndicator.TabIndex = 1;
            this.attitudeIndicator.Text = "attitudeIndicatorInstrumentControl1";
            // 
            // turnCoordinator
            // 
            this.turnCoordinator.Location = new System.Drawing.Point(327, 3);
            this.turnCoordinator.Name = "turnCoordinator";
            this.turnCoordinator.Size = new System.Drawing.Size(75, 75);
            this.turnCoordinator.TabIndex = 2;
            this.turnCoordinator.Text = "turnCoordinatorInstrumentControl1";
            // 
            // headingIndicator
            // 
            this.headingIndicator.Location = new System.Drawing.Point(408, 3);
            this.headingIndicator.Name = "headingIndicator";
            this.headingIndicator.Size = new System.Drawing.Size(75, 75);
            this.headingIndicator.TabIndex = 3;
            this.headingIndicator.Text = "headingIndicator";
            // 
            // InstrumentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(488, 80);
            this.Controls.Add(this.toolStripContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "InstrumentPanel";
            this.Opacity = 0.99D;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instruments";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.InstrumentPanel_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.InstrumentHolder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addInstrumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.FlowLayoutPanel InstrumentHolder;
        private AviationInstruments.AirSpeedIndicatorInstrumentControl airSpeedIndicator;
        private AviationInstruments.AttitudeIndicatorInstrumentControl attitudeIndicator;
        private AviationInstruments.TurnCoordinatorInstrumentControl turnCoordinator;
        private AviationInstruments.HeadingIndicatorInstrumentControl headingIndicator;
        private AviationInstruments.VerticalSpeedIndicatorInstrumentControl verticalSpeedIndicator;
        private AviationInstruments.AltimeterInstrumentControl altimeter;
    }
}


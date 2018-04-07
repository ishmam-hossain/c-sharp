namespace CPU_and_RAM
{
    partial class CPU_RAM
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
            this.pcCPU = new System.Diagnostics.PerformanceCounter();
            this.pcRAM = new System.Diagnostics.PerformanceCounter();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcRAM)).BeginInit();
            this.SuspendLayout();
            // 
            // pcCPU
            // 
            this.pcCPU.CategoryName = "Processor";
            this.pcCPU.CounterName = "%Processor Time";
            this.pcCPU.InstanceName = "_Total";
            // 
            // pcRAM
            // 
            this.pcRAM.CategoryName = "% Commited Bytes in Use";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // CPU_RAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(597, 326);
            this.Name = "CPU_RAM";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPU & RAM";
            ((System.ComponentModel.ISupportInitialize)(this.pcCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcRAM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Diagnostics.PerformanceCounter pcCPU;
        private System.Diagnostics.PerformanceCounter pcRAM;
        private System.Windows.Forms.Timer timer;
    }
}


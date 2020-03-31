namespace WinNetworkMonitor {
	partial class Form1 {
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.TimerCounter = new System.Windows.Forms.Timer(this.components);
			this.LableDownloadValue = new System.Windows.Forms.Label();
			this.LabelUploadValue = new System.Windows.Forms.Label();
			this.ListAdapters = new System.Windows.Forms.ComboBox();
			this.ipAddress = new System.Windows.Forms.Label();
			this.MACAddress = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// TimerCounter
			// 
			this.TimerCounter.Tick += new System.EventHandler(this.TimerCounter_Tick);
			// 
			// LableDownloadValue
			// 
			this.LableDownloadValue.AutoSize = true;
			this.LableDownloadValue.Location = new System.Drawing.Point(7, 95);
			this.LableDownloadValue.Name = "LableDownloadValue";
			this.LableDownloadValue.Size = new System.Drawing.Size(17, 16);
			this.LableDownloadValue.TabIndex = 1;
			this.LableDownloadValue.Text = "...";
			// 
			// LabelUploadValue
			// 
			this.LabelUploadValue.AutoSize = true;
			this.LabelUploadValue.Location = new System.Drawing.Point(7, 119);
			this.LabelUploadValue.Name = "LabelUploadValue";
			this.LabelUploadValue.Size = new System.Drawing.Size(17, 16);
			this.LabelUploadValue.TabIndex = 2;
			this.LabelUploadValue.Text = "...";
			// 
			// ListAdapters
			// 
			this.ListAdapters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ListAdapters.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ListAdapters.FormattingEnabled = true;
			this.ListAdapters.IntegralHeight = false;
			this.ListAdapters.Location = new System.Drawing.Point(8, 16);
			this.ListAdapters.Name = "ListAdapters";
			this.ListAdapters.Size = new System.Drawing.Size(262, 24);
			this.ListAdapters.TabIndex = 3;
			this.ListAdapters.TabStop = false;
			this.ListAdapters.SelectedIndexChanged += new System.EventHandler(this.ListAdapters_SelectedIndexChanged_1);
			// 
			// ipAddress
			// 
			this.ipAddress.AutoSize = true;
			this.ipAddress.Location = new System.Drawing.Point(7, 71);
			this.ipAddress.Name = "ipAddress";
			this.ipAddress.Size = new System.Drawing.Size(17, 16);
			this.ipAddress.TabIndex = 4;
			this.ipAddress.Text = "...";
			// 
			// MACAddress
			// 
			this.MACAddress.AutoSize = true;
			this.MACAddress.Location = new System.Drawing.Point(7, 47);
			this.MACAddress.Name = "MACAddress";
			this.MACAddress.Size = new System.Drawing.Size(17, 16);
			this.MACAddress.TabIndex = 5;
			this.MACAddress.Text = "...";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(279, 146);
			this.Controls.Add(this.MACAddress);
			this.Controls.Add(this.ipAddress);
			this.Controls.Add(this.ListAdapters);
			this.Controls.Add(this.LabelUploadValue);
			this.Controls.Add(this.LableDownloadValue);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "WinNetworkMonitor";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Timer TimerCounter;
		private System.Windows.Forms.Label LableDownloadValue;
		private System.Windows.Forms.Label LabelUploadValue;
		private System.Windows.Forms.ComboBox ListAdapters;
		private System.Windows.Forms.Label ipAddress;
		private System.Windows.Forms.Label MACAddress;
	}
}


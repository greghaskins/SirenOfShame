﻿using SirenOfShame.Lib;

namespace SirenOfShame.Configuration {
	partial class ConfigureServer {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigureServer));
            this._serverType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this._cancel = new SosButton();
            this.panel1 = new System.Windows.Forms.FlowLayoutPanel();
            this._add = new SosButton();
            this._ciServerPanel = new System.Windows.Forms.Panel();
            this._configurationContainer = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this._ciServerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _serverType
            // 
            this._serverType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._serverType.DisplayMember = "DisplayName";
            this._serverType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._serverType.FormattingEnabled = true;
            this._serverType.Location = new System.Drawing.Point(63, 3);
            this._serverType.Name = "_serverType";
            this._serverType.Size = new System.Drawing.Size(419, 21);
            this._serverType.TabIndex = 30;
            this._serverType.SelectedIndexChanged += new System.EventHandler(this.ServerTypeSelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "CI Server:";
            // 
            // _cancel
            // 
            this._cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this._cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this._cancel.FlatAppearance.BorderSize = 0;
            this._cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(55)))), ((int)(((byte)(0)))));
            this._cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(65)))), ((int)(((byte)(0)))));
            this._cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._cancel.ForeColor = System.Drawing.Color.White;
            this._cancel.Location = new System.Drawing.Point(233, 3);
            this._cancel.Name = "_cancel";
            this._cancel.Size = new System.Drawing.Size(120, 20);
            this._cancel.TabIndex = 34;
            this._cancel.Text = "Cancel";
            this._cancel.UseVisualStyleBackColor = true;
            this._cancel.Click += new System.EventHandler(this.CloseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this._add);
            this.panel1.Controls.Add(this._cancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.panel1.Location = new System.Drawing.Point(0, 230);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 27);
            this.panel1.TabIndex = 35;
            // 
            // _add
            // 
            this._add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this._add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this._add.FlatAppearance.BorderSize = 0;
            this._add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(55)))), ((int)(((byte)(0)))));
            this._add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(65)))), ((int)(((byte)(0)))));
            this._add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._add.ForeColor = System.Drawing.Color.White;
            this._add.Location = new System.Drawing.Point(359, 3);
            this._add.Name = "_add";
            this._add.Size = new System.Drawing.Size(120, 20);
            this._add.TabIndex = 35;
            this._add.Text = "Add";
            this._add.UseVisualStyleBackColor = true;
            this._add.Click += new System.EventHandler(this.AddClick);
            // 
            // _ciServerPanel
            // 
            this._ciServerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this._ciServerPanel.Controls.Add(this._serverType);
            this._ciServerPanel.Controls.Add(this.label5);
            this._ciServerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._ciServerPanel.Location = new System.Drawing.Point(0, 0);
            this._ciServerPanel.Name = "_ciServerPanel";
            this._ciServerPanel.Size = new System.Drawing.Size(482, 28);
            this._ciServerPanel.TabIndex = 36;
            // 
            // _configurationContainer
            // 
            this._configurationContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this._configurationContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._configurationContainer.Location = new System.Drawing.Point(0, 28);
            this._configurationContainer.Name = "_configurationContainer";
            this._configurationContainer.Size = new System.Drawing.Size(482, 202);
            this._configurationContainer.TabIndex = 37;
            // 
            // ConfigureServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 257);
            this.Controls.Add(this._configurationContainer);
            this.Controls.Add(this._ciServerPanel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigureServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configure Server";
            this.panel1.ResumeLayout(false);
            this._ciServerPanel.ResumeLayout(false);
            this._ciServerPanel.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox _serverType;
        private System.Windows.Forms.Label label5;
        private SosButton _cancel;
		private System.Windows.Forms.FlowLayoutPanel panel1;
		private System.Windows.Forms.Panel _ciServerPanel;
		private System.Windows.Forms.Panel _configurationContainer;
        private SosButton _add;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
	}
}
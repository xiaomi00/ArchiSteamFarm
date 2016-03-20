﻿using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ConfigGenerator {
	public partial class MainForm : Form {
		public MainForm() {
			InitializeComponent();
		}

		private void BotMenuNew_Click(object sender, EventArgs e) {
			if (sender == null || e == null) {
				return;
			}

			Logging.LogGenericError("This option is not ready yet!");
		}

		private void BotMenuDelete_Click(object sender, EventArgs e) {
			if (sender == null || e == null) {
				return;
			}

			Logging.LogGenericError("This option is not ready yet!");
		}

		private void FileMenuHelp_Click(object sender, EventArgs e) {
			if (sender == null || e == null) {
				return;
			}

			Process.Start("https://github.com/JustArchi/ArchiSteamFarm/wiki/Configuration");
		}

		private void FileMenuExit_Click(object sender, EventArgs e) {
			if (sender == null || e == null) {
				return;
			}

			Application.Exit();
		}

		private void MainForm_Load(object sender, EventArgs e) {
			if (sender == null || e == null) {
				return;
			}

			MainTab.TabPages.Add(new GlobalConfigPage(Path.Combine(Program.ConfigDirectory, Program.GlobalConfigFile)));
		}
	}
}

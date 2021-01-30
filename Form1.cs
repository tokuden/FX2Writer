// EZ-USB FX2 EEPROM Programmer
// (C) Copyright 2021 Tokushu Denshi Kairo Inc.
// See http://github.jo/tokuden/FX2Writer

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CyUSB;

namespace FX2Writer
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			openFileDialog1.FileName = textBox1.Text;
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				textBox1.Text = openFileDialog1.FileName;
			}

		}

		private void Form1_Load(object sender, EventArgs e)
		{
		}

		private void buttonRefresh_Click(object sender, EventArgs e)
		{
			USBDeviceList usbDevices;
			byte DeviceMask = CyConst.DEVICES_CYUSB;// | CyConst.DEVICES_HID | CyConst.DEVICES_MSC;
			usbDevices = new USBDeviceList(DeviceMask);
			if (usbDevices.Count == 0)
			{
				MessageBox.Show("No CyUSB device found.");
				return;
			}
			foreach (USBDevice dev in usbDevices)
			{
				if ((dev.VendorID == 0x4b4) && (dev.ProductID == 0x8613))
				{
					if (!System.IO.File.Exists(textBox1.Text))
					{
						MessageBox.Show($"File '{textBox1.Text}' not found.");
						return;
					}

					CyFX2Device fx2 = dev as CyFX2Device;
					bool status = false;
					if (radioButtonEEPROM.Checked)
					{
						if (MessageBox.Show($"Program '{textBox1.Text}' to EEPROM OK?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
						{
							return;
						}
						status = fx2.LoadEEPROM(textBox1.Text);
						if(status) status = fx2.ReConnect();
					}
					if (radioButtonRAM.Checked)
					{
						if (MessageBox.Show($"Program '{textBox1.Text}' to RAM OK?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
						{
							return;
						}
						status = fx2.LoadRAM(textBox1.Text);
					}

					if (status)
					{
						MessageBox.Show($"Programming success.");
					}
					else
					{
						MessageBox.Show($"Programming Failed.");
					}
					return;
				}
			}
			if (usbDevices.Count == 0)
			{
				MessageBox.Show("No CyUSB device found.");
				return;
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			if (textBox1.Text == "")
			{
				buttonProgram.Enabled = false;
			}
			else
			{
				buttonProgram.Enabled = true;
			}
		}
	}
}

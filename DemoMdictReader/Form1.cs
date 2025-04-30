using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DemoMdictReader
{
    public partial class Form1 : Form
    {
        Mdx _dict;
        List<string> _list = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInitialize_Click(object sender, EventArgs e)
        {

			// 将键加载到ListBox中
			listBox1.Items.Clear();
			_list = new List<string>();

			_dict = new Mdx(txtDictFile.Text);
            _dict.GetStyleSheets();
            _dict.GetKeys();
            _dict.IgnoreKeys();
            _dict.GetRecordBlocksInfo();

			foreach (var key in _dict.IdxBlockInfoList)
			{
                foreach (var entry in key.Entries)
                {
                    _list.Add(entry.ToString());
				}
			}
			var first100Items = _list.Take(100).ToArray();

			// 将前 100 条数据显示到 ListBox
			listBox1.Items.Clear();
            listBox1.Items.AddRange(first100Items);

			MessageBox.Show(@"Ok well done!", @"Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtDictFile.Text = openFileDialog.FileName;
            }
        }

        private void btnGetValue_Click(object sender, EventArgs e)
        {
            GetValue();

		}
        private void GetValue()
        {
			wbResult.DocumentText = _dict.GetKeyValue(new MdictHelper.Tuple<long, long, string>(int.Parse(txtValue1.Text), int.Parse(txtValue2.Text), txtValue3.Text));
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			// 检查是否有选中项
			if (listBox1.SelectedItem != null)
			{
				// 获取选中的项
				string selectedKey = listBox1.SelectedItem.ToString();

				// 在这里执行你的动作
				//MessageBox.Show($"You selected: {selectedKey}", "Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var items = selectedKey.Split("Ⱨ".ToCharArray());
                if (items.Length == 3)
                {
                    txtValue1.Text = items[0];
                    txtValue2.Text = items[1];
                    txtValue3.Text = items[2];
					GetValue();

				}
                else
                {
                    MessageBox.Show("Invalid selection format. Please select a valid item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			var first100Items = _list.Where(x => x.Contains(textBox1.Text.Trim())).Take(100).ToArray();

			// 将前 100 条数据显示到 ListBox
			listBox1.Items.AddRange(first100Items);
		}
	}
}

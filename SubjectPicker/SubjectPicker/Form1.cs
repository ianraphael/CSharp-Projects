using System;
using System.Windows.Forms;

namespace SubjectPicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var selectedSubject = SubjectList.SelectedItem.ToString();
            if (!FavoriteList.Items.Contains(selectedSubject))
            {
                FavoriteList.Items.Add(selectedSubject);
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            
            FavoriteList.Items.Remove(FavoriteList.SelectedItem);
        }
    }
}

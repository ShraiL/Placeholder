using System;
using System.Windows.Forms;
using YourProjectName.Final.Models;

namespace YourProjectName.Final
{
    public partial class EntityNameDialog : Form
    {
        public Property1Type Property1Name { get; private set; }
        public Property2Type Property2Name { get; private set; }
        public Property3Type Property3Name { get; private set; }
        public int EntityId { get; private set; }

        public EntityNameDialog()
        {
            InitializeComponent();
            EntityId = 0;
        }

        public EntityNameDialog(EntityName entityNameToEdit) : this()
        {
            EntityId = entityNameToEdit.Id;
            Property1NameTxtBox.Text = entityNameToEdit.Property1Name.ToString();
            Property2NameTxtBox.Text = entityNameToEdit.Property2Name.ToString();
            Property3NameTxtBox.Text = entityNameToEdit.Property3Name.ToString();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            Property1Name = Property1NameTxtBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(Property1Name))
            {
                MessageBox.Show("Please enter a Property1Name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Property2Type.TryParse(Property2NameTxtBox.Text, out Property2Type property2Name))
            {
                MessageBox.Show("Please enter a valid Property2Name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Property2Name = property2Name;

            if (!Property3Type.TryParse(Property3NameTxtBox.Text, out Property3Type property3Name))
            {
                MessageBox.Show("Please enter a valid Property3Name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Property3Name = property3Name;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

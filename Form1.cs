using YourProjectName.Final.Models;
using YourProjectName.Final.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace YourProjectName.Final
{
    public partial class Form1 : Form
    {
        private SqlHelper _sqlHelper;

        public Form1()
        {
            InitializeComponent();
            _sqlHelper = new SqlHelper();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadEntityNamePlural();
        }

        private void LoadEntityNamePlural()
        {
            EntityNamePluralListBox.Items.Clear();
            List<EntityName> entityNamePlural = _sqlHelper.GetEntityNamePlural();
            foreach (EntityName entityName in entityNamePlural)
            {
                EntityNamePluralListBox.Items.Add(entityName);
            }
        }

        private void AddEntityNameButton_Click(object sender, EventArgs e)
        {
            using (EntityNameDialog dialog = new EntityNameDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    EntityName newEntityName = new EntityName(
                        dialog.Property1Name,
                        dialog.Property2Name,
                        dialog.Property3Name
                    );
                    _sqlHelper.AddEntityName(newEntityName);
                    LoadEntityNamePlural();
                }
            }
        }

        private void EditEntityNameButton_Click(object sender, EventArgs e)
        {
            if (EntityNamePluralListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a EntityName to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            EntityName selectedEntityName = EntityNamePluralListBox.SelectedItem as EntityName;

            if (selectedEntityName != null)
            {
                using (EntityNameDialog dialog = new EntityNameDialog(selectedEntityName))
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        EntityName updatedEntityName = new EntityName(
                            dialog.Property1Name,
                            dialog.Property2Name,
                            dialog.Property3Name
                        )
                        {
                            Id = dialog.EntityId
                        };

                        _sqlHelper.UpdateEntityName(updatedEntityName);
                        LoadEntityNamePlural();
                    }
                }
            }
        }

        private void DeleteEntityNameButton_Click(object sender, EventArgs e)
        {
            if (EntityNamePluralListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a EntityName to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            EntityName selectedEntityName = EntityNamePluralListBox.SelectedItem as EntityName;

            if (selectedEntityName != null)
            {
                DialogResult confirmResult = MessageBox.Show(
                    $"Are you sure you want to delete '{selectedEntityName.Property1Name}'?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmResult == DialogResult.Yes)
                {
                    _sqlHelper.DeleteEntityName(selectedEntityName.Id);
                    LoadEntityNamePlural();
                }
            }
        }
    }
}

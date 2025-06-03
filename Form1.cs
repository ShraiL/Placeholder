// IMPORTANT: Replace YourProjectName with your actual project's root namespace
using YourProjectName.Final.Models;
using YourProjectName.Final.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

// IMPORTANT: Replace YourProjectName with your actual project's root namespace
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
            Load{EntityNamePlural}(); // IMPORTANT: Change method call
        }

        // IMPORTANT: Change method name and types
        private void Load{EntityNamePlural}()
        {
            {EntityNamePlural}ListBox.Items.Clear(); // IMPORTANT: Change ListBox name
            List<{EntityName}> {EntityNamePlural.ToLower()} = _sqlHelper.Get{EntityNamePlural}(); // IMPORTANT: Change method call and list type
            foreach ({EntityName} {EntityName.ToLower()} in {EntityNamePlural.ToLower()}) // IMPORTANT: Change type and variable name
            {
                {EntityNamePlural}ListBox.Items.Add({EntityName.ToLower()}); // IMPORTANT: Change ListBox name
            }
        }

        // IMPORTANT: Change method name
        private void Add{EntityName}Button_Click(object sender, EventArgs e)
        {
            // IMPORTANT: Change dialog type
            using ({EntityName}Dialog dialog = new {EntityName}Dialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // IMPORTANT: Create new entity object with values from dialog
                    {EntityName} new{EntityName} = new {EntityName}(
                        dialog.{Property1Name},
                        dialog.{Property2Name},
                        dialog.{Property3Name}
                    );
                    _sqlHelper.Add{EntityName}(new{EntityName}); // IMPORTANT: Call Add method
                    Load{EntityNamePlural}(); // Refresh the list
                }
            }
        }

        // IMPORTANT: Change method name
        private void Edit{EntityName}Button_Click(object sender, EventArgs e)
        {
            // IMPORTANT: Change ListBox name
            if ({EntityNamePlural}ListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a {EntityName} to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // IMPORTANT: Get the selected entity
            {EntityName} selected{EntityName} = {EntityNamePlural}ListBox.SelectedItem as {EntityName};

            if (selected{EntityName} != null)
            {
                // IMPORTANT: Pass the selected entity to the dialog for editing
                using ({EntityName}Dialog dialog = new {EntityName}Dialog(selected{EntityName}))
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        // IMPORTANT: Create a new entity object with updated values and the original ID
                        {EntityName} updated{EntityName} = new {EntityName}(
                            dialog.{Property1Name},
                            dialog.{Property2Name},
                            dialog.{Property3Name}
                        )
                        {
                            Id = dialog.EntityId // Ensure the ID is maintained for the update
                        };

                        _sqlHelper.Update{EntityName}(updated{EntityName}); // IMPORTANT: Call Update method
                        Load{EntityNamePlural}(); // Refresh the list after update
                    }
                }
            }
        }

        // IMPORTANT: Change method name
        private void Delete{EntityName}Button_Click(object sender, EventArgs e)
        {
            // IMPORTANT: Change ListBox name
            if ({EntityNamePlural}ListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a {EntityName} to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // IMPORTANT: Get the selected entity
            {EntityName} selected{EntityName} = {EntityNamePlural}ListBox.SelectedItem as {EntityName};

            if (selected{EntityName} != null)
            {
                DialogResult confirmResult = MessageBox.Show(
                    // IMPORTANT: Change message
                    $"Are you sure you want to delete '{selected{EntityName}.{Property1Name}}'?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmResult == DialogResult.Yes)
                {
                    _sqlHelper.Delete{EntityName}(selected{EntityName}.Id); // IMPORTANT: Call Delete method
                    Load{EntityNamePlural}(); // Refresh the list after deleting
                }
            }
        }
    }
}

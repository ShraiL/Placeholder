// IMPORTANT: Replace YourProjectName with your actual project's root namespace
namespace YourProjectName.Final
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        // IMPORTANT: Rename ListBox and Buttons to match your entity
        private System.Windows.Forms.ListBox {EntityNamePlural}ListBox; // e.g., CarsListBox
        private System.Windows.Forms.Button Add{EntityName}Button;    // e.g., AddCarButton
        private System.Windows.Forms.Button Edit{EntityName}Button;   // e.g., EditCarButton
        private System.Windows.Forms.Button Delete{EntityName}Button; // e.g., DeleteCarButton

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            // IMPORTANT: Instantiate your new ListBox and Buttons
            this.{EntityNamePlural}ListBox = new ListBox();
            this.Add{EntityName}Button = new Button();
            this.Delete{EntityName}Button = new Button();
            this.Edit{EntityName}Button = new Button();
            this.{EntityNamePlural.ToLower()}Lbl = new Label(); // e.g., carslbl
            this.SuspendLayout();

            // {EntityNamePlural}ListBox
            this.{EntityNamePlural}ListBox.FormattingEnabled = true;
            this.{EntityNamePlural}ListBox.Location = new Point(12, 32);
            this.{EntityNamePlural}ListBox.Margin = new Padding(3, 2, 3, 2);
            this.{EntityNamePlural}ListBox.Name = "{EntityNamePlural}ListBox";
            this.{EntityNamePlural}ListBox.Size = new Size(307, 289);
            this.{EntityNamePlural}ListBox.TabIndex = 0;

            // Add{EntityName}Button
            this.Add{EntityName}Button.Location = new Point(332, 32);
            this.Add{EntityName}Button.Margin = new Padding(3, 2, 3, 2);
            this.Add{EntityName}Button.Name = "Add{EntityName}Button";
            this.Add{EntityName}Button.Size = new Size(131, 30);
            this.Add{EntityName}Button.TabIndex = 1;
            // IMPORTANT: Change button text
            this.Add{EntityName}Button.Text = "Add {EntityName}"; // e.g., "Add Car"
            this.Add{EntityName}Button.UseVisualStyleBackColor = true;
            // IMPORTANT: Change event handler name
            this.Add{EntityName}Button.Click += Add{EntityName}Button_Click;

            // Edit{EntityName}Button
            this.Edit{EntityName}Button.Location = new Point(332, 85);
            this.Edit{EntityName}Button.Margin = new Padding(3, 2, 3, 2);
            this.Edit{EntityName}Button.Name = "Edit{EntityName}Button";
            this.Edit{EntityName}Button.Size = new Size(131, 30);
            this.Edit{EntityName}Button.TabIndex = 2;
            // IMPORTANT: Change button text
            this.Edit{EntityName}Button.Text = "Edit {EntityName}"; // e.g., "Edit Car"
            this.Edit{EntityName}Button.UseVisualStyleBackColor = true;
            // IMPORTANT: Change event handler name
            this.Edit{EntityName}Button.Click += Edit{EntityName}Button_Click;

            // Delete{EntityName}Button
            this.Delete{EntityName}Button.Location = new Point(332, 138);
            this.Delete{EntityName}Button.Margin = new Padding(3, 2, 3, 2);
            this.Delete{EntityName}Button.Name = "Delete{EntityName}Button";
            this.Delete{EntityName}Button.Size = new Size(131, 30);
            this.Delete{EntityName}Button.TabIndex = 0;
            // IMPORTANT: Change button text
            this.Delete{EntityName}Button.Text = "Delete {EntityName}"; // e.g., "Delete Car"
            this.Delete{EntityName}Button.UseVisualStyleBackColor = true;
            // IMPORTANT: Change event handler name
            this.Delete{EntityName}Button.Click += Delete{EntityName}Button_Click;

            // {EntityNamePlural.ToLower()}Lbl
            this.{EntityNamePlural.ToLower()}Lbl.AutoSize = true;
            this.{EntityNamePlural.ToLower()}Lbl.Location = new Point(12, 9);
            this.{EntityNamePlural.ToLower()}Lbl.Name = "{EntityNamePlural.ToLower()}Lbl";
            this.{EntityNamePlural.ToLower()}Lbl.Size = new Size(68, 15);
            // IMPORTANT: Change label text
            this.{EntityNamePlural.ToLower()}Lbl.Text = "{EntityName} List:"; // e.g., "Car List:"

            // Form1
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(502, 343);
            this.Controls.Add(this.{EntityNamePlural.ToLower()}Lbl);
            this.Controls.Add(this.Delete{EntityName}Button);
            this.Controls.Add(this.Edit{EntityName}Button);
            this.Controls.Add(this.Add{EntityName}Button);
            this.Controls.Add(this.{EntityNamePlural}ListBox);
            this.Margin = new Padding(3, 2, 3, 2);
            this.Name = "Form1";
            // IMPORTANT: Change form title
            this.Text = "{EntityName} Management"; // e.g., "Car Management"
            this.Load += Form1_Load;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // IMPORTANT: Rename this label
        private Label {EntityNamePlural.ToLower()}Lbl;
    }
}

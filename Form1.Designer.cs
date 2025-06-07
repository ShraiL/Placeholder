namespace YourProjectName.Final
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox EntityNamePluralListBox;
        private System.Windows.Forms.Button AddEntityNameButton;
        private System.Windows.Forms.Button EditEntityNameButton;
        private System.Windows.Forms.Button DeleteEntityNameButton;
        private System.Windows.Forms.Label entityNamePluralLbl;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.EntityNamePluralListBox = new ListBox();
            this.AddEntityNameButton = new Button();
            this.DeleteEntityNameButton = new Button();
            this.EditEntityNameButton = new Button();
            this.entityNamePluralLbl = new Label();
            this.SuspendLayout();

            // EntityNamePluralListBox
            this.EntityNamePluralListBox.FormattingEnabled = true;
            this.EntityNamePluralListBox.Location = new System.Drawing.Point(12, 32);
            this.EntityNamePluralListBox.Name = "EntityNamePluralListBox";
            this.EntityNamePluralListBox.Size = new System.Drawing.Size(307, 289);
            this.EntityNamePluralListBox.TabIndex = 0;

            // AddEntityNameButton
            this.AddEntityNameButton.Location = new System.Drawing.Point(332, 32);
            this.AddEntityNameButton.Name = "AddEntityNameButton";
            this.AddEntityNameButton.Size = new System.Drawing.Size(131, 30);
            this.AddEntityNameButton.TabIndex = 1;
            this.AddEntityNameButton.Text = "Add EntityName";
            this.AddEntityNameButton.UseVisualStyleBackColor = true;
            this.AddEntityNameButton.Click += AddEntityNameButton_Click;

            // EditEntityNameButton
            this.EditEntityNameButton.Location = new System.Drawing.Point(332, 85);
            this.EditEntityNameButton.Name = "EditEntityNameButton";
            this.EditEntityNameButton.Size = new System.Drawing.Size(131, 30);
            this.EditEntityNameButton.TabIndex = 2;
            this.EditEntityNameButton.Text = "Edit EntityName";
            this.EditEntityNameButton.UseVisualStyleBackColor = true;
            this.EditEntityNameButton.Click += EditEntityNameButton_Click;

            // DeleteEntityNameButton
            this.DeleteEntityNameButton.Location = new System.Drawing.Point(332, 138);
            this.DeleteEntityNameButton.Name = "DeleteEntityNameButton";
            this.DeleteEntityNameButton.Size = new System.Drawing.Size(131, 30);
            this.DeleteEntityNameButton.TabIndex = 3;
            this.DeleteEntityNameButton.Text = "Delete EntityName";
            this.DeleteEntityNameButton.UseVisualStyleBackColor = true;
            this.DeleteEntityNameButton.Click += DeleteEntityNameButton_Click;

            // entityNamePluralLbl
            this.entityNamePluralLbl.AutoSize = true;
            this.entityNamePluralLbl.Location = new System.Drawing.Point(12, 9);
            this.entityNamePluralLbl.Name = "entityNamePluralLbl";
            this.entityNamePluralLbl.Size = new System.Drawing.Size(100, 15);
            this.entityNamePluralLbl.Text = "EntityName List:";

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 343);
            this.Controls.Add(this.entityNamePluralLbl);
            this.Controls.Add(this.DeleteEntityNameButton);
            this.Controls.Add(this.EditEntityNameButton);
            this.Controls.Add(this.AddEntityNameButton);
            this.Controls.Add(this.EntityNamePluralListBox);
            this.Name = "Form1";
            this.Text = "EntityName Management";
            this.Load += Form1_Load;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

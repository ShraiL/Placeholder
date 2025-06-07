namespace YourProjectName.Final
{
    partial class EntityNameDialog
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox Property1NameTxtBox;
        private TextBox Property2NameTxtBox;
        private TextBox Property3NameTxtBox;
        private Button DoneButton;
        private Label property1namelbl;
        private Label property2namelbl;
        private Label property3namelbl;

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
            Property1NameTxtBox = new TextBox();
            Property2NameTxtBox = new TextBox();
            Property3NameTxtBox = new TextBox();
            DoneButton = new Button();
            property1namelbl = new Label();
            property2namelbl = new Label();
            property3namelbl = new Label();
            SuspendLayout();
            // 
            // Property1NameTxtBox
            // 
            Property1NameTxtBox.Location = new System.Drawing.Point(12, 30);
            Property1NameTxtBox.Name = "Property1NameTxtBox";
            Property1NameTxtBox.Size = new System.Drawing.Size(222, 23);
            Property1NameTxtBox.TabIndex = 0;
            // 
            // Property2NameTxtBox
            // 
            Property2NameTxtBox.Location = new System.Drawing.Point(12, 80);
            Property2NameTxtBox.Name = "Property2NameTxtBox";
            Property2NameTxtBox.Size = new System.Drawing.Size(222, 23);
            Property2NameTxtBox.TabIndex = 1;
            // 
            // Property3NameTxtBox
            // 
            Property3NameTxtBox.Location = new System.Drawing.Point(12, 130);
            Property3NameTxtBox.Name = "Property3NameTxtBox";
            Property3NameTxtBox.Size = new System.Drawing.Size(222, 23);
            Property3NameTxtBox.TabIndex = 2;
            // 
            // DoneButton
            // 
            DoneButton.Location = new System.Drawing.Point(24, 180);
            DoneButton.Name = "DoneButton";
            DoneButton.Size = new System.Drawing.Size(200, 30);
            DoneButton.TabIndex = 3;
            DoneButton.Text = "Save";
            DoneButton.Click += DoneButton_Click;
            // 
            // property1namelbl
            // 
            property1namelbl.Location = new System.Drawing.Point(12, 10);
            property1namelbl.Name = "property1namelbl";
            property1namelbl.Size = new System.Drawing.Size(100, 23);
            property1namelbl.TabIndex = 4;
            property1namelbl.Text = "Property1Name:";
            // 
            // property2namelbl
            // 
            property2namelbl.Location = new System.Drawing.Point(12, 60);
            property2namelbl.Name = "property2namelbl";
            property2namelbl.Size = new System.Drawing.Size(100, 23);
            property2namelbl.TabIndex = 5;
            property2namelbl.Text = "Property2Name:";
            // 
            // property3namelbl
            // 
            property3namelbl.Location = new System.Drawing.Point(12, 110);
            property3namelbl.Name = "property3namelbl";
            property3namelbl.Size = new System.Drawing.Size(100, 23);
            property3namelbl.TabIndex = 6;
            property3namelbl.Text = "Property3Name:";
            // 
            // EntityNameDialog
            // 
            ClientSize = new System.Drawing.Size(256, 230);
            Controls.Add(DoneButton);
            Controls.Add(Property3NameTxtBox);
            Controls.Add(Property2NameTxtBox);
            Controls.Add(Property1NameTxtBox);
            Controls.Add(property1namelbl);
            Controls.Add(property2namelbl);
            Controls.Add(property3namelbl);
            Name = "EntityNameDialog";
            Text = "EntityName Details";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

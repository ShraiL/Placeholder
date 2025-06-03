// IMPORTANT: Replace YourProjectName with your actual project's root namespace
namespace YourProjectName.Final
{
    // IMPORTANT: Replace {EntityName} with the singular name of your entity
    partial class {EntityName}Dialog
    {
        private System.ComponentModel.IContainer components = null;
        // IMPORTANT: Rename these TextBoxes and Labels to match your new properties
        private TextBox {Property1Name}TxtBox; // e.g., ModelTxtBox
        private TextBox {Property2Name}TxtBox; // e.g., WeightTxtBox
        private TextBox {Property3Name}TxtBox; // e.g., SpeedTxtBox
        private Button DoneButton;
        private Label {Property1Name.ToLower()}Lbl; // e.g., modelLbl
        private Label {Property2Name.ToLower()}Lbl; // e.g., weightLbl
        private Label {Property3Name.ToLower()}Lbl; // e.g., speedLbl


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
            // IMPORTANT: Instantiate your new TextBoxes
            this.{Property1Name}TxtBox = new TextBox();
            this.{Property2Name}TxtBox = new TextBox();
            this.{Property3Name}TxtBox = new TextBox();
            this.DoneButton = new Button();
            // IMPORTANT: Instantiate your new Labels
            this.{Property1Name.ToLower()}Lbl = new Label();
            this.{Property2Name.ToLower()}Lbl = new Label();
            this.{Property3Name.ToLower()}Lbl = new Label();
            this.SuspendLayout();

            // {Property1Name}TxtBox
            this.{Property1Name}TxtBox.Location = new System.Drawing.Point(12, 30);
            this.{Property1Name}TxtBox.Name = "{Property1Name}TxtBox";
            this.{Property1Name}TxtBox.Size = new System.Drawing.Size(222, 23); // Adjust size as needed
            this.{Property1Name}TxtBox.TabIndex = 4;

            // {Property2Name}TxtBox
            this.{Property2Name}TxtBox.Location = new System.Drawing.Point(12, 80);
            this.{Property2Name}TxtBox.Name = "{Property2Name}TxtBox";
            this.{Property2Name}TxtBox.Size = new System.Drawing.Size(222, 23); // Adjust size as needed
            this.{Property2Name}TxtBox.TabIndex = 3;

            // {Property3Name}TxtBox
            this.{Property3Name}TxtBox.Location = new System.Drawing.Point(12, 130);
            this.{Property3Name}TxtBox.Name = "{Property3Name}TxtBox";
            this.{Property3Name}TxtBox.Size = new System.Drawing.Size(222, 23); // Adjust size as needed
            this.{Property3Name}TxtBox.TabIndex = 2;

            // DoneButton
            this.DoneButton.Location = new System.Drawing.Point(23, 175); // Adjusted position for 3 fields
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(200, 30);
            this.DoneButton.TabIndex = 0;
            this.DoneButton.Text = "Save";
            this.DoneButton.Click += DoneButton_Click;

            // {Property1Name.ToLower()}Lbl
            this.{Property1Name.ToLower()}Lbl.Location = new System.Drawing.Point(12, 10);
            this.{Property1Name.ToLower()}Lbl.Name = "{Property1Name.ToLower()}Lbl";
            this.{Property1Name.ToLower()}Lbl.Size = new System.Drawing.Size(100, 23);
            // IMPORTANT: Change label text
            this.{Property1Name.ToLower()}Lbl.Text = "{Property1Name}:"; // e.g., "Model:"

            // {Property2Name.ToLower()}Lbl
            this.{Property2Name.ToLower()}Lbl.Location = new System.Drawing.Point(12, 60);
            this.{Property2Name.ToLower()}Lbl.Name = "{Property2Name.ToLower()}Lbl";
            this.{Property2Name.ToLower()}Lbl.Size = new System.Drawing.Size(100, 23);
            // IMPORTANT: Change label text
            this.{Property2Name.ToLower()}Lbl.Text = "{Property2Name}:"; // e.g., "Weight (kg):"

            // {Property3Name.ToLower()}Lbl
            this.{Property3Name.ToLower()}Lbl.Location = new System.Drawing.Point(12, 110);
            this.{Property3Name.ToLower()}Lbl.Name = "{Property3Name.ToLower()}Lbl";
            this.{Property3Name.ToLower()}Lbl.Size = new System.Drawing.Size(100, 23);
            // IMPORTANT: Change label text
            this.{Property3Name.ToLower()}Lbl.Text = "{Property3Name}:"; // e.g., "Speed (km/h):"

            // {EntityName}Dialog
            // IMPORTANT: Adjust ClientSize based on your number of fields and layout
            this.ClientSize = new System.Drawing.Size(256, 220); // Adjusted size for 3 fields
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.{Property3Name}TxtBox);
            this.Controls.Add(this.{Property2Name}TxtBox);
            this.Controls.Add(this.{Property1Name}TxtBox);
            this.Controls.Add(this.{Property1Name.ToLower()}Lbl);
            this.Controls.Add(this.{Property2Name.ToLower()}Lbl);
            this.Controls.Add(this.{Property3Name.ToLower()}Lbl);
            // IMPORTANT: Change form title
            this.Text = "{EntityName} Details"; // e.g., "Car Details"
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

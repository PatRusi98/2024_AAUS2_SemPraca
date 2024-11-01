namespace AAUS2_SemPraca.Forms
{
    partial class GeneratorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            number = new Label();
            NumberInput = new NumericUpDown();
            IntersectionInput = new NumericUpDown();
            Intersection = new Label();
            GenerateButton = new Button();
            CancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)NumberInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IntersectionInput).BeginInit();
            SuspendLayout();
            // 
            // number
            // 
            number.AutoSize = true;
            number.Location = new Point(7, 14);
            number.Name = "number";
            number.Size = new Size(106, 15);
            number.TabIndex = 16;
            number.Text = "Number of entities";
            // 
            // NumberInput
            // 
            NumberInput.Location = new Point(137, 12);
            NumberInput.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            NumberInput.Name = "NumberInput";
            NumberInput.Size = new Size(120, 23);
            NumberInput.TabIndex = 15;
            // 
            // IntersectionInput
            // 
            IntersectionInput.Location = new Point(137, 41);
            IntersectionInput.Name = "IntersectionInput";
            IntersectionInput.Size = new Size(120, 23);
            IntersectionInput.TabIndex = 17;
            // 
            // Intersection
            // 
            Intersection.AutoSize = true;
            Intersection.Location = new Point(7, 43);
            Intersection.Name = "Intersection";
            Intersection.Size = new Size(90, 15);
            Intersection.TabIndex = 18;
            Intersection.Text = "Intersection (%)";
            // 
            // GenerateButton
            // 
            GenerateButton.DialogResult = DialogResult.OK;
            GenerateButton.Location = new Point(54, 77);
            GenerateButton.Name = "GenerateButton";
            GenerateButton.Size = new Size(75, 23);
            GenerateButton.TabIndex = 33;
            GenerateButton.Text = "Generate";
            GenerateButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            CancelButton.DialogResult = DialogResult.Cancel;
            CancelButton.Location = new Point(145, 77);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 32;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // GeneratorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 111);
            Controls.Add(GenerateButton);
            Controls.Add(CancelButton);
            Controls.Add(Intersection);
            Controls.Add(IntersectionInput);
            Controls.Add(number);
            Controls.Add(NumberInput);
            MaximizeBox = false;
            MaximumSize = new Size(285, 150);
            MinimizeBox = false;
            MinimumSize = new Size(285, 150);
            Name = "GeneratorForm";
            Text = "Generator";
            ((System.ComponentModel.ISupportInitialize)NumberInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)IntersectionInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label number;
        private NumericUpDown NumberInput;
        private NumericUpDown IntersectionInput;
        private Label Intersection;
        private Button GenerateButton;
        private Button CancelButton;
    }
}
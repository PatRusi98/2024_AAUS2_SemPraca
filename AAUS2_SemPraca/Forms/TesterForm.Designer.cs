namespace AAUS2_SemPraca.Forms
{
    partial class TesterForm
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
            insert = new Label();
            InsertInput = new NumericUpDown();
            search = new Label();
            delete = new Label();
            SearchInput = new NumericUpDown();
            DeleteInput = new NumericUpDown();
            TestButton = new Button();
            CancelButton = new Button();
            number = new Label();
            NumberInput = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)InsertInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SearchInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DeleteInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumberInput).BeginInit();
            SuspendLayout();
            // 
            // insert
            // 
            insert.AutoSize = true;
            insert.Location = new Point(13, 72);
            insert.Margin = new Padding(4, 0, 4, 0);
            insert.Name = "insert";
            insert.Size = new Size(147, 25);
            insert.TabIndex = 16;
            insert.Text = "Insert probability";
            // 
            // InsertInput
            // 
            InsertInput.DecimalPlaces = 2;
            InsertInput.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            InsertInput.Location = new Point(197, 68);
            InsertInput.Margin = new Padding(4, 5, 4, 5);
            InsertInput.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            InsertInput.Name = "InsertInput";
            InsertInput.Size = new Size(171, 31);
            InsertInput.TabIndex = 15;
            // 
            // search
            // 
            search.AutoSize = true;
            search.Location = new Point(13, 120);
            search.Margin = new Padding(4, 0, 4, 0);
            search.Name = "search";
            search.Size = new Size(155, 25);
            search.TabIndex = 18;
            search.Text = "Search probability";
            // 
            // delete
            // 
            delete.AutoSize = true;
            delete.Location = new Point(13, 168);
            delete.Margin = new Padding(4, 0, 4, 0);
            delete.Name = "delete";
            delete.Size = new Size(153, 25);
            delete.TabIndex = 20;
            delete.Text = "Delete probability";
            // 
            // SearchInput
            // 
            SearchInput.DecimalPlaces = 2;
            SearchInput.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            SearchInput.Location = new Point(197, 117);
            SearchInput.Margin = new Padding(4, 5, 4, 5);
            SearchInput.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            SearchInput.Name = "SearchInput";
            SearchInput.Size = new Size(171, 31);
            SearchInput.TabIndex = 21;
            // 
            // DeleteInput
            // 
            DeleteInput.DecimalPlaces = 2;
            DeleteInput.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            DeleteInput.Location = new Point(197, 165);
            DeleteInput.Margin = new Padding(4, 5, 4, 5);
            DeleteInput.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            DeleteInput.Name = "DeleteInput";
            DeleteInput.Size = new Size(171, 31);
            DeleteInput.TabIndex = 22;
            // 
            // TestButton
            // 
            TestButton.DialogResult = DialogResult.OK;
            TestButton.Location = new Point(67, 230);
            TestButton.Margin = new Padding(4, 5, 4, 5);
            TestButton.Name = "TestButton";
            TestButton.Size = new Size(107, 38);
            TestButton.TabIndex = 31;
            TestButton.Text = "Test";
            TestButton.UseVisualStyleBackColor = true;
            TestButton.Click += TestButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.DialogResult = DialogResult.Cancel;
            CancelButton.Location = new Point(197, 230);
            CancelButton.Margin = new Padding(4, 5, 4, 5);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(107, 38);
            CancelButton.TabIndex = 30;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // number
            // 
            number.AutoSize = true;
            number.Location = new Point(11, 23);
            number.Margin = new Padding(4, 0, 4, 0);
            number.Name = "number";
            number.Size = new Size(189, 25);
            number.TabIndex = 33;
            number.Text = "Number of operations";
            // 
            // NumberInput
            // 
            NumberInput.Location = new Point(197, 20);
            NumberInput.Margin = new Padding(4, 5, 4, 5);
            NumberInput.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            NumberInput.Name = "NumberInput";
            NumberInput.Size = new Size(171, 31);
            NumberInput.TabIndex = 32;
            // 
            // TesterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 278);
            Controls.Add(number);
            Controls.Add(NumberInput);
            Controls.Add(TestButton);
            Controls.Add(CancelButton);
            Controls.Add(DeleteInput);
            Controls.Add(SearchInput);
            Controls.Add(delete);
            Controls.Add(search);
            Controls.Add(insert);
            Controls.Add(InsertInput);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MaximumSize = new Size(399, 334);
            MinimizeBox = false;
            MinimumSize = new Size(399, 334);
            Name = "TesterForm";
            Text = "Tester";
            ((System.ComponentModel.ISupportInitialize)InsertInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)SearchInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)DeleteInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumberInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label insert;
        private NumericUpDown InsertInput;
        private Label search;
        private Label delete;
        private NumericUpDown SearchInput;
        private NumericUpDown DeleteInput;
        private Button TestButton;
        private Button CancelButton;
        private Label number;
        private NumericUpDown NumberInput;
    }
}
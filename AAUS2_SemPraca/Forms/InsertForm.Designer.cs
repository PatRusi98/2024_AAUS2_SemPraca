namespace AAUS2_SemPraca
{
    partial class InsertForm
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
            NumberInput = new NumericUpDown();
            DescriptionInput = new TextBox();
            Latitude1Input = new NumericUpDown();
            Longitude1Input = new NumericUpDown();
            Lat1CoordInput = new ComboBox();
            Long1CoordInput = new ComboBox();
            Long2CoordInput = new ComboBox();
            Lat2CoordInput = new ComboBox();
            Longitude2Input = new NumericUpDown();
            Latitude2Input = new NumericUpDown();
            CancelButton = new Button();
            InsertButton = new Button();
            number = new Label();
            description = new Label();
            latitude1 = new Label();
            latitudeCoord1 = new Label();
            longitude1 = new Label();
            longitudeCoord1 = new Label();
            latitude2 = new Label();
            latitudeCoord2 = new Label();
            longitude2 = new Label();
            longitudeCoord2 = new Label();
            point1 = new Label();
            point2 = new Label();
            ((System.ComponentModel.ISupportInitialize)NumberInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Latitude1Input).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Longitude1Input).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Longitude2Input).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Latitude2Input).BeginInit();
            SuspendLayout();
            // 
            // NumberInput
            // 
            NumberInput.Location = new Point(108, 12);
            NumberInput.Name = "NumberInput";
            NumberInput.Size = new Size(120, 23);
            NumberInput.TabIndex = 0;
            // 
            // DescriptionInput
            // 
            DescriptionInput.Location = new Point(108, 41);
            DescriptionInput.Name = "DescriptionInput";
            DescriptionInput.Size = new Size(120, 23);
            DescriptionInput.TabIndex = 1;
            // 
            // Latitude1Input
            // 
            Latitude1Input.DecimalPlaces = 4;
            Latitude1Input.Increment = new decimal(new int[] { 1, 0, 0, 262144 });
            Latitude1Input.Location = new Point(108, 101);
            Latitude1Input.Maximum = new decimal(new int[] { 90, 0, 0, 0 });
            Latitude1Input.Name = "Latitude1Input";
            Latitude1Input.Size = new Size(120, 23);
            Latitude1Input.TabIndex = 2;
            // 
            // Longitude1Input
            // 
            Longitude1Input.DecimalPlaces = 4;
            Longitude1Input.Increment = new decimal(new int[] { 1, 0, 0, 262144 });
            Longitude1Input.Location = new Point(108, 159);
            Longitude1Input.Maximum = new decimal(new int[] { 180, 0, 0, 0 });
            Longitude1Input.Name = "Longitude1Input";
            Longitude1Input.Size = new Size(120, 23);
            Longitude1Input.TabIndex = 3;
            // 
            // Lat1CoordInput
            // 
            Lat1CoordInput.FormattingEnabled = true;
            Lat1CoordInput.Location = new Point(107, 130);
            Lat1CoordInput.Name = "Lat1CoordInput";
            Lat1CoordInput.Size = new Size(121, 23);
            Lat1CoordInput.TabIndex = 6;
            // 
            // Long1CoordInput
            // 
            Long1CoordInput.FormattingEnabled = true;
            Long1CoordInput.Location = new Point(107, 188);
            Long1CoordInput.Name = "Long1CoordInput";
            Long1CoordInput.Size = new Size(121, 23);
            Long1CoordInput.TabIndex = 7;
            // 
            // Long2CoordInput
            // 
            Long2CoordInput.FormattingEnabled = true;
            Long2CoordInput.Location = new Point(107, 332);
            Long2CoordInput.Name = "Long2CoordInput";
            Long2CoordInput.Size = new Size(121, 23);
            Long2CoordInput.TabIndex = 11;
            // 
            // Lat2CoordInput
            // 
            Lat2CoordInput.FormattingEnabled = true;
            Lat2CoordInput.Location = new Point(106, 274);
            Lat2CoordInput.Name = "Lat2CoordInput";
            Lat2CoordInput.Size = new Size(121, 23);
            Lat2CoordInput.TabIndex = 10;
            // 
            // Longitude2Input
            // 
            Longitude2Input.DecimalPlaces = 4;
            Longitude2Input.Increment = new decimal(new int[] { 1, 0, 0, 262144 });
            Longitude2Input.Location = new Point(107, 303);
            Longitude2Input.Maximum = new decimal(new int[] { 180, 0, 0, 0 });
            Longitude2Input.Name = "Longitude2Input";
            Longitude2Input.Size = new Size(120, 23);
            Longitude2Input.TabIndex = 9;
            // 
            // Latitude2Input
            // 
            Latitude2Input.DecimalPlaces = 4;
            Latitude2Input.Increment = new decimal(new int[] { 1, 0, 0, 262144 });
            Latitude2Input.Location = new Point(107, 245);
            Latitude2Input.Maximum = new decimal(new int[] { 90, 0, 0, 0 });
            Latitude2Input.Name = "Latitude2Input";
            Latitude2Input.Size = new Size(120, 23);
            Latitude2Input.TabIndex = 8;
            // 
            // CancelButton
            // 
            CancelButton.DialogResult = DialogResult.Cancel;
            CancelButton.Location = new Point(129, 387);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 12;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // InsertButton
            // 
            InsertButton.DialogResult = DialogResult.OK;
            InsertButton.Location = new Point(38, 387);
            InsertButton.Name = "InsertButton";
            InsertButton.Size = new Size(75, 23);
            InsertButton.TabIndex = 13;
            InsertButton.Text = "Insert";
            InsertButton.UseVisualStyleBackColor = true;
            // 
            // number
            // 
            number.AutoSize = true;
            number.Location = new Point(4, 14);
            number.Name = "number";
            number.Size = new Size(51, 15);
            number.TabIndex = 14;
            number.Text = "Number";
            number.Click += label1_Click;
            // 
            // description
            // 
            description.AutoSize = true;
            description.Location = new Point(4, 44);
            description.Name = "description";
            description.Size = new Size(67, 15);
            description.TabIndex = 15;
            description.Text = "Description";
            // 
            // latitude1
            // 
            latitude1.AutoSize = true;
            latitude1.Location = new Point(4, 103);
            latitude1.Name = "latitude1";
            latitude1.Size = new Size(50, 15);
            latitude1.TabIndex = 16;
            latitude1.Text = "Latitude";
            latitude1.Click += latitude1_Click;
            // 
            // latitudeCoord1
            // 
            latitudeCoord1.AutoSize = true;
            latitudeCoord1.Location = new Point(4, 133);
            latitudeCoord1.Name = "latitudeCoord1";
            latitudeCoord1.Size = new Size(86, 15);
            latitudeCoord1.TabIndex = 17;
            latitudeCoord1.Text = "Latitude Coord";
            // 
            // longitude1
            // 
            longitude1.AutoSize = true;
            longitude1.Location = new Point(4, 161);
            longitude1.Name = "longitude1";
            longitude1.Size = new Size(61, 15);
            longitude1.TabIndex = 18;
            longitude1.Text = "Longitude";
            // 
            // longitudeCoord1
            // 
            longitudeCoord1.AutoSize = true;
            longitudeCoord1.Location = new Point(4, 191);
            longitudeCoord1.Name = "longitudeCoord1";
            longitudeCoord1.Size = new Size(97, 15);
            longitudeCoord1.TabIndex = 19;
            longitudeCoord1.Text = "Longitude Coord";
            // 
            // latitude2
            // 
            latitude2.AutoSize = true;
            latitude2.Location = new Point(4, 247);
            latitude2.Name = "latitude2";
            latitude2.Size = new Size(50, 15);
            latitude2.TabIndex = 20;
            latitude2.Text = "Latitude";
            // 
            // latitudeCoord2
            // 
            latitudeCoord2.AutoSize = true;
            latitudeCoord2.Location = new Point(4, 277);
            latitudeCoord2.Name = "latitudeCoord2";
            latitudeCoord2.Size = new Size(86, 15);
            latitudeCoord2.TabIndex = 21;
            latitudeCoord2.Text = "Latitude Coord";
            // 
            // longitude2
            // 
            longitude2.AutoSize = true;
            longitude2.Location = new Point(4, 305);
            longitude2.Name = "longitude2";
            longitude2.Size = new Size(61, 15);
            longitude2.TabIndex = 22;
            longitude2.Text = "Longitude";
            // 
            // longitudeCoord2
            // 
            longitudeCoord2.AutoSize = true;
            longitudeCoord2.Location = new Point(4, 335);
            longitudeCoord2.Name = "longitudeCoord2";
            longitudeCoord2.Size = new Size(97, 15);
            longitudeCoord2.TabIndex = 23;
            longitudeCoord2.Text = "Longitude Coord";
            // 
            // point1
            // 
            point1.AutoSize = true;
            point1.Location = new Point(99, 76);
            point1.Name = "point1";
            point1.Size = new Size(44, 15);
            point1.TabIndex = 24;
            point1.Text = "Point 1";
            // 
            // point2
            // 
            point2.AutoSize = true;
            point2.Location = new Point(99, 220);
            point2.Name = "point2";
            point2.Size = new Size(44, 15);
            point2.TabIndex = 25;
            point2.Text = "Point 2";
            // 
            // InsertForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(240, 421);
            Controls.Add(point2);
            Controls.Add(point1);
            Controls.Add(longitudeCoord2);
            Controls.Add(longitude2);
            Controls.Add(latitudeCoord2);
            Controls.Add(latitude2);
            Controls.Add(longitudeCoord1);
            Controls.Add(longitude1);
            Controls.Add(latitudeCoord1);
            Controls.Add(latitude1);
            Controls.Add(description);
            Controls.Add(number);
            Controls.Add(InsertButton);
            Controls.Add(CancelButton);
            Controls.Add(Long2CoordInput);
            Controls.Add(Lat2CoordInput);
            Controls.Add(Longitude2Input);
            Controls.Add(Latitude2Input);
            Controls.Add(Long1CoordInput);
            Controls.Add(Lat1CoordInput);
            Controls.Add(Longitude1Input);
            Controls.Add(Latitude1Input);
            Controls.Add(DescriptionInput);
            Controls.Add(NumberInput);
            MaximizeBox = false;
            MaximumSize = new Size(256, 460);
            MinimizeBox = false;
            MinimumSize = new Size(256, 460);
            Name = "InsertForm";
            Text = "Insert";
            Load += InsertForm_Load;
            ((System.ComponentModel.ISupportInitialize)NumberInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)Latitude1Input).EndInit();
            ((System.ComponentModel.ISupportInitialize)Longitude1Input).EndInit();
            ((System.ComponentModel.ISupportInitialize)Longitude2Input).EndInit();
            ((System.ComponentModel.ISupportInitialize)Latitude2Input).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown NumberInput;
        private TextBox DescriptionInput;
        private NumericUpDown Latitude1Input;
        private NumericUpDown Longitude1Input;
        private ComboBox Lat1CoordInput;
        private ComboBox Long1CoordInput;
        private ComboBox Long2CoordInput;
        private ComboBox Lat2CoordInput;
        private NumericUpDown Longitude2Input;
        private NumericUpDown Latitude2Input;
        private Button CancelButton;
        private Button InsertButton;
        private Label number;
        private Label description;
        private Label latitude1;
        private Label latitudeCoord1;
        private Label longitude1;
        private Label longitudeCoord1;
        private Label latitude2;
        private Label latitudeCoord2;
        private Label longitude2;
        private Label longitudeCoord2;
        private Label point1;
        private Label point2;
    }
}
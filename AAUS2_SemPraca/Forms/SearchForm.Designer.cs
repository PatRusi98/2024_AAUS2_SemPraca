namespace AAUS2_SemPraca.Forms
{
    partial class SearchForm
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
            longitudeCoord = new Label();
            longitude = new Label();
            latitudeCoord = new Label();
            latitude = new Label();
            LongCoordInput = new ComboBox();
            LatCoordInput = new ComboBox();
            LongitudeInput = new NumericUpDown();
            LatitudeInput = new NumericUpDown();
            SearchButton = new Button();
            CancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)LongitudeInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LatitudeInput).BeginInit();
            SuspendLayout();
            // 
            // longitudeCoord
            // 
            longitudeCoord.AutoSize = true;
            longitudeCoord.Location = new Point(7, 102);
            longitudeCoord.Name = "longitudeCoord";
            longitudeCoord.Size = new Size(97, 15);
            longitudeCoord.TabIndex = 27;
            longitudeCoord.Text = "Longitude Coord";
            // 
            // longitude
            // 
            longitude.AutoSize = true;
            longitude.Location = new Point(7, 72);
            longitude.Name = "longitude";
            longitude.Size = new Size(61, 15);
            longitude.TabIndex = 26;
            longitude.Text = "Longitude";
            // 
            // latitudeCoord
            // 
            latitudeCoord.AutoSize = true;
            latitudeCoord.Location = new Point(7, 44);
            latitudeCoord.Name = "latitudeCoord";
            latitudeCoord.Size = new Size(86, 15);
            latitudeCoord.TabIndex = 25;
            latitudeCoord.Text = "Latitude Coord";
            // 
            // latitude
            // 
            latitude.AutoSize = true;
            latitude.Location = new Point(7, 14);
            latitude.Name = "latitude";
            latitude.Size = new Size(50, 15);
            latitude.TabIndex = 24;
            latitude.Text = "Latitude";
            // 
            // LongCoordInput
            // 
            LongCoordInput.FormattingEnabled = true;
            LongCoordInput.Location = new Point(110, 99);
            LongCoordInput.Name = "LongCoordInput";
            LongCoordInput.Size = new Size(121, 23);
            LongCoordInput.TabIndex = 23;
            // 
            // LatCoordInput
            // 
            LatCoordInput.FormattingEnabled = true;
            LatCoordInput.Location = new Point(110, 41);
            LatCoordInput.Name = "LatCoordInput";
            LatCoordInput.Size = new Size(121, 23);
            LatCoordInput.TabIndex = 22;
            // 
            // LongitudeInput
            // 
            LongitudeInput.DecimalPlaces = 4;
            LongitudeInput.Increment = new decimal(new int[] { 1, 0, 0, 262144 });
            LongitudeInput.Location = new Point(111, 70);
            LongitudeInput.Maximum = new decimal(new int[] { 180, 0, 0, 0 });
            LongitudeInput.Name = "LongitudeInput";
            LongitudeInput.Size = new Size(120, 23);
            LongitudeInput.TabIndex = 21;
            // 
            // LatitudeInput
            // 
            LatitudeInput.DecimalPlaces = 4;
            LatitudeInput.Increment = new decimal(new int[] { 1, 0, 0, 262144 });
            LatitudeInput.Location = new Point(111, 12);
            LatitudeInput.Maximum = new decimal(new int[] { 90, 0, 0, 0 });
            LatitudeInput.Name = "LatitudeInput";
            LatitudeInput.Size = new Size(120, 23);
            LatitudeInput.TabIndex = 20;
            // 
            // SearchButton
            // 
            SearchButton.DialogResult = DialogResult.OK;
            SearchButton.Location = new Point(39, 139);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(75, 23);
            SearchButton.TabIndex = 29;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            CancelButton.DialogResult = DialogResult.Cancel;
            CancelButton.Location = new Point(130, 139);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 28;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(243, 173);
            Controls.Add(SearchButton);
            Controls.Add(CancelButton);
            Controls.Add(longitudeCoord);
            Controls.Add(longitude);
            Controls.Add(latitudeCoord);
            Controls.Add(latitude);
            Controls.Add(LongCoordInput);
            Controls.Add(LatCoordInput);
            Controls.Add(LongitudeInput);
            Controls.Add(LatitudeInput);
            MaximizeBox = false;
            MaximumSize = new Size(259, 212);
            MinimizeBox = false;
            MinimumSize = new Size(259, 212);
            Name = "SearchForm";
            Text = "Search";
            ((System.ComponentModel.ISupportInitialize)LongitudeInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)LatitudeInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label longitudeCoord;
        private Label longitude;
        private Label latitudeCoord;
        private Label latitude;
        private ComboBox LongCoordInput;
        private ComboBox LatCoordInput;
        private NumericUpDown LongitudeInput;
        private NumericUpDown LatitudeInput;
        private Button SearchButton;
        private Button CancelButton;
    }
}
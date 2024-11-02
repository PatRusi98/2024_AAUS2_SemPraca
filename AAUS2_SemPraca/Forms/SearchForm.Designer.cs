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
            longitudeCoord.Location = new Point(10, 170);
            longitudeCoord.Margin = new Padding(4, 0, 4, 0);
            longitudeCoord.Name = "longitudeCoord";
            longitudeCoord.Size = new Size(147, 25);
            longitudeCoord.TabIndex = 27;
            longitudeCoord.Text = "Longitude Coord";
            // 
            // longitude
            // 
            longitude.AutoSize = true;
            longitude.Location = new Point(10, 120);
            longitude.Margin = new Padding(4, 0, 4, 0);
            longitude.Name = "longitude";
            longitude.Size = new Size(92, 25);
            longitude.TabIndex = 26;
            longitude.Text = "Longitude";
            // 
            // latitudeCoord
            // 
            latitudeCoord.AutoSize = true;
            latitudeCoord.Location = new Point(10, 73);
            latitudeCoord.Margin = new Padding(4, 0, 4, 0);
            latitudeCoord.Name = "latitudeCoord";
            latitudeCoord.Size = new Size(130, 25);
            latitudeCoord.TabIndex = 25;
            latitudeCoord.Text = "Latitude Coord";
            // 
            // latitude
            // 
            latitude.AutoSize = true;
            latitude.Location = new Point(10, 23);
            latitude.Margin = new Padding(4, 0, 4, 0);
            latitude.Name = "latitude";
            latitude.Size = new Size(75, 25);
            latitude.TabIndex = 24;
            latitude.Text = "Latitude";
            // 
            // LongCoordInput
            // 
            LongCoordInput.FormattingEnabled = true;
            LongCoordInput.Location = new Point(157, 165);
            LongCoordInput.Margin = new Padding(4, 5, 4, 5);
            LongCoordInput.Name = "LongCoordInput";
            LongCoordInput.Size = new Size(171, 33);
            LongCoordInput.TabIndex = 23;
            // 
            // LatCoordInput
            // 
            LatCoordInput.FormattingEnabled = true;
            LatCoordInput.Location = new Point(157, 68);
            LatCoordInput.Margin = new Padding(4, 5, 4, 5);
            LatCoordInput.Name = "LatCoordInput";
            LatCoordInput.Size = new Size(171, 33);
            LatCoordInput.TabIndex = 22;
            // 
            // LongitudeInput
            // 
            LongitudeInput.DecimalPlaces = 4;
            LongitudeInput.Increment = new decimal(new int[] { 1, 0, 0, 262144 });
            LongitudeInput.Location = new Point(159, 117);
            LongitudeInput.Margin = new Padding(4, 5, 4, 5);
            LongitudeInput.Maximum = new decimal(new int[] { 180, 0, 0, 0 });
            LongitudeInput.Name = "LongitudeInput";
            LongitudeInput.Size = new Size(171, 31);
            LongitudeInput.TabIndex = 21;
            // 
            // LatitudeInput
            // 
            LatitudeInput.DecimalPlaces = 4;
            LatitudeInput.Increment = new decimal(new int[] { 1, 0, 0, 262144 });
            LatitudeInput.Location = new Point(159, 20);
            LatitudeInput.Margin = new Padding(4, 5, 4, 5);
            LatitudeInput.Maximum = new decimal(new int[] { 90, 0, 0, 0 });
            LatitudeInput.Name = "LatitudeInput";
            LatitudeInput.Size = new Size(171, 31);
            LatitudeInput.TabIndex = 20;
            // 
            // SearchButton
            // 
            SearchButton.DialogResult = DialogResult.OK;
            SearchButton.Location = new Point(56, 232);
            SearchButton.Margin = new Padding(4, 5, 4, 5);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(107, 38);
            SearchButton.TabIndex = 29;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.DialogResult = DialogResult.Cancel;
            CancelButton.Location = new Point(186, 232);
            CancelButton.Margin = new Padding(4, 5, 4, 5);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(107, 38);
            CancelButton.TabIndex = 28;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 283);
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
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MaximumSize = new Size(361, 339);
            MinimizeBox = false;
            MinimumSize = new Size(361, 339);
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
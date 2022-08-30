namespace BindingTest
{
    partial class Form2
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
            if (disposing && (components != null)) {
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
            this.lblGrid = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.lblAirplaneFilter = new System.Windows.Forms.Label();
            this.txtAirplaneFilter = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblList = new System.Windows.Forms.Label();
            this.lstPassengers = new System.Windows.Forms.ListBox();
            this.lblPassengerFilter = new System.Windows.Forms.Label();
            this.txtPassengerFilter = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGrid
            // 
            this.lblGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGrid.AutoSize = true;
            this.lblGrid.Location = new System.Drawing.Point(18, 14);
            this.lblGrid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrid.Name = "lblGrid";
            this.lblGrid.Size = new System.Drawing.Size(59, 15);
            this.lblGrid.TabIndex = 0;
            this.lblGrid.Text = "Airplanes:";
            // 
            // grid
            // 
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(18, 40);
            this.grid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(402, 171);
            this.grid.TabIndex = 3;
            // 
            // lblAirplaneFilter
            // 
            this.lblAirplaneFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAirplaneFilter.AutoSize = true;
            this.lblAirplaneFilter.Location = new System.Drawing.Point(229, 14);
            this.lblAirplaneFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAirplaneFilter.Name = "lblAirplaneFilter";
            this.lblAirplaneFilter.Size = new System.Drawing.Size(36, 15);
            this.lblAirplaneFilter.TabIndex = 0;
            this.lblAirplaneFilter.Text = "Filter:";
            // 
            // txtAirplaneFilter
            // 
            this.txtAirplaneFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAirplaneFilter.Location = new System.Drawing.Point(273, 10);
            this.txtAirplaneFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAirplaneFilter.Name = "txtAirplaneFilter";
            this.txtAirplaneFilter.Size = new System.Drawing.Size(146, 23);
            this.txtAirplaneFilter.TabIndex = 1;
            this.txtAirplaneFilter.TextChanged += new System.EventHandler(this.txtAirplaneFilter_TextChanged);
            // 
            // lblModel
            // 
            this.lblModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(14, 222);
            this.lblModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(44, 15);
            this.lblModel.TabIndex = 0;
            this.lblModel.Text = "Model:";
            // 
            // txtModel
            // 
            this.txtModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModel.Location = new System.Drawing.Point(66, 218);
            this.txtModel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(353, 23);
            this.txtModel.TabIndex = 5;
            this.txtModel.Text = "txtModel";
            // 
            // lblList
            // 
            this.lblList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(427, 10);
            this.lblList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(163, 15);
            this.lblList.TabIndex = 0;
            this.lblList.Text = "Passengers on selected plane:";
            // 
            // lstPassengers
            // 
            this.lstPassengers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPassengers.FormattingEnabled = true;
            this.lstPassengers.ItemHeight = 15;
            this.lstPassengers.Location = new System.Drawing.Point(430, 57);
            this.lstPassengers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstPassengers.Name = "lstPassengers";
            this.lstPassengers.Size = new System.Drawing.Size(170, 154);
            this.lstPassengers.TabIndex = 4;
            // 
            // lblPassengerFilter
            // 
            this.lblPassengerFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassengerFilter.AutoSize = true;
            this.lblPassengerFilter.Location = new System.Drawing.Point(427, 32);
            this.lblPassengerFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassengerFilter.Name = "lblPassengerFilter";
            this.lblPassengerFilter.Size = new System.Drawing.Size(36, 15);
            this.lblPassengerFilter.TabIndex = 0;
            this.lblPassengerFilter.Text = "Filter:";
            // 
            // txtPassengerFilter
            // 
            this.txtPassengerFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassengerFilter.Location = new System.Drawing.Point(471, 29);
            this.txtPassengerFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPassengerFilter.Name = "txtPassengerFilter";
            this.txtPassengerFilter.Size = new System.Drawing.Size(129, 23);
            this.txtPassengerFilter.TabIndex = 2;
            this.txtPassengerFilter.TextChanged += new System.EventHandler(this.txtPassengerFilter_TextChanged);
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(427, 222);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(475, 218);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 23);
            this.txtName.TabIndex = 6;
            this.txtName.Text = "txtName";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 247);
            this.Controls.Add(this.lblGrid);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.lblAirplaneFilter);
            this.Controls.Add(this.txtPassengerFilter);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.lstPassengers);
            this.Controls.Add(this.lblPassengerFilter);
            this.Controls.Add(this.txtAirplaneFilter);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblGrid;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label lblAirplaneFilter;
        private System.Windows.Forms.TextBox txtAirplaneFilter;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.ListBox lstPassengers;
        private System.Windows.Forms.Label lblPassengerFilter;
        private System.Windows.Forms.TextBox txtPassengerFilter;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
    }
}

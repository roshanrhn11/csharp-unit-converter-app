namespace UnitConverterApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtInput = new TextBox();
            cmbConversion = new ComboBox();
            btnConvert = new Button();
            btnClearConverter = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(277, 97);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(215, 27);
            txtInput.TabIndex = 0;
            // 
            // cmbConversion
            // 
            cmbConversion.FormattingEnabled = true;
            cmbConversion.Items.AddRange(new object[] { "Centimeters to Inches", "Inches to Centimeters", "Kilograms to Pounds", "Pounds to Kilograms", "Celsius to Fahrenheit", "Fahrenheit to Celsius" });
            cmbConversion.Location = new Point(277, 145);
            cmbConversion.Name = "cmbConversion";
            cmbConversion.Size = new Size(215, 28);
            cmbConversion.TabIndex = 1;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(277, 197);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(94, 29);
            btnConvert.TabIndex = 2;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // btnClearConverter
            // 
            btnClearConverter.Location = new Point(398, 197);
            btnClearConverter.Name = "btnClearConverter";
            btnClearConverter.Size = new Size(94, 29);
            btnClearConverter.TabIndex = 3;
            btnClearConverter.Text = "Clear";
            btnClearConverter.UseVisualStyleBackColor = true;
            btnClearConverter.Click += btnClearConverter_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(277, 247);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(76, 28);
            lblResult.TabIndex = 4;
            lblResult.Text = "Result:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnClearConverter);
            Controls.Add(btnConvert);
            Controls.Add(cmbConversion);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private ComboBox cmbConversion;
        private Button btnConvert;
        private Button btnClearConverter;
        private Label lblResult;
    }
}

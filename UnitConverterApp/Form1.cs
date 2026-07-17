namespace UnitConverterApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInput.Text) || cmbConversion.SelectedItem == null)
            {
                MessageBox.Show("Please enter a numeric value and select a conversion type.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double input = double.Parse(txtInput.Text);
            double result = 0;
            string selectedType = cmbConversion.SelectedItem.ToString();

            switch (selectedType)
            {
                case "Centimeters to Inches":
                    result = input / 2.54;
                    lblResult.Text = $"Result: {result:F2} Inches";
                    break;
                case "Inches to Centimeters":
                    result = input * 2.54;
                    lblResult.Text = $"Result: {result:F2} Cm";
                    break;
                case "Kilograms to Pounds":
                    result = input * 2.20462;
                    lblResult.Text = $"Result: {result:F2} Lbs";
                    break;
                case "Pounds to Kilograms":
                    result = input / 2.20462;
                    lblResult.Text = $"Result: {result:F2} Kg";
                    break;
                case "Celsius to Fahrenheit":
                    result = (input * 9 / 5) + 32;
                    lblResult.Text = $"Result: {result:F2} °F";
                    break;
                case "Fahrenheit to Celsius":
                    result = (input - 32) * 5 / 9;
                    lblResult.Text = $"Result: {result:F2} °C";
                    break;
            }
        }

        private void btnClearConverter_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            lblResult.Text = "Result: ";
            cmbConversion.SelectedIndex = -1;
        }
    }
}

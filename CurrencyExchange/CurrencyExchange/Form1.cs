using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyExchange
{
    public partial class Form1 : Form
    {
        private const string ApiKey = "2831fe0cea6f46d7bdc3c49720da637a"; // Replace with your Open Exchange Rates API key
        private const string ApiBaseUrl = "https://open.er-api.com/v6/latest/";

        private ComboBox cboSourceCurrency;
        private ComboBox cboTargetCurrency;
        private Label lblResult;
        private TextBox txtAmount;

        public Form1()
        {
            InitializeComponent();
            LoadCurrencies();
        }

        private async void btnConvert_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtAmount.Text, out double amount) && cboSourceCurrency.SelectedItem != null && cboTargetCurrency.SelectedItem != null)
            {
                string sourceCurrency = cboSourceCurrency.SelectedItem.ToString();
                string targetCurrency = cboTargetCurrency.SelectedItem.ToString();

                double exchangeRate = await GetExchangeRate(sourceCurrency, targetCurrency);
                double convertedAmount = ConvertCurrency(amount, exchangeRate);

                lblResult.Text = $"{amount} {sourceCurrency} is {convertedAmount} {targetCurrency}";
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric amount and select source/target currencies.");
            }
        }

        private async Task<double> GetExchangeRate(string sourceCurrency, string targetCurrency)
        {
            using (HttpClient client = new HttpClient())
            {
                string apiUrl = $"{ApiBaseUrl}{sourceCurrency}";
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    dynamic data = JsonConvert.DeserializeObject(content);
                    return data.rates[targetCurrency];
                }
                else
                {
                    MessageBox.Show("Failed to fetch exchange rates. Please try again later.");
                    return 0;
                }
            }
        }

        private double ConvertCurrency(double amount, double exchangeRate)
        {
            return amount * exchangeRate;
        }

        private void LoadCurrencies()
        {
            // You may customize this list based on the available currencies from the API
            List<string> currencies = new List<string> { "USD", "EUR", "GBP", "JPY", "AUD" };

            cboSourceCurrency.DataSource = currencies;
            cboTargetCurrency.DataSource = currencies;
        }
    }
}

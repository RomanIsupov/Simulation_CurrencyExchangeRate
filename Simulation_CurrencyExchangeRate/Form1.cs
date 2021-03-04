using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulation_CurrencyExchangeRate
{
    public partial class Form1 : Form
    {
        private const double K = 0.14;
        private Random randomGenerator = new Random(Guid.NewGuid().GetHashCode());

        private int day = 0;
        private double exchangeRate;
        private double roubles = 10000D;
        private double currency = 0D;

        public Form1()
        {
            InitializeComponent();
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            roubles = 10000D;
            currency = 0D;

            chart1.Series[0].Points.Clear();
            exchangeRate = (double)inputExchangeRate.Value;
            chart1.Series[0].Points.AddXY(0, exchangeRate);
            UpdateInterface();
            if (!timer1.Enabled)
            {
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            exchangeRate *= (1 + K * (randomGenerator.NextDouble() - 0.5));
            chart1.Series[0].Points.AddXY(day, exchangeRate);
        }

        private void btBuy_Click(object sender, EventArgs e)
        {
            double amount = (double)currencyAmount.Value;
            if (roubles >= amount * exchangeRate)
            {
                roubles -= amount * exchangeRate;
                currency += amount;
                UpdateInterface();
            }
        }

        private void btSell_Click(object sender, EventArgs e)
        {
            double amount = (double)currencyAmount.Value;
            if (currency >= amount)
            {
                currency -= amount;
                roubles += amount * exchangeRate;
                UpdateInterface();
            }
        }

        private void UpdateInterface()
        {
            labRoubles.Text = $"Roubles: {Math.Round(roubles, 2)}";
            labCurrency.Text = $"Currency: {Math.Round(currency, 2)}";
        }
    }
}

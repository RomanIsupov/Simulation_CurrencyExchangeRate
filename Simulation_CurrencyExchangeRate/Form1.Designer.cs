
namespace Simulation_CurrencyExchangeRate
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.currencyAmount = new System.Windows.Forms.NumericUpDown();
            this.labCurrency = new System.Windows.Forms.Label();
            this.labRoubles = new System.Windows.Forms.Label();
            this.btSell = new System.Windows.Forms.Button();
            this.btBuy = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.inputExchangeRate = new System.Windows.Forms.NumericUpDown();
            this.labInputExchangeRate = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencyAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputExchangeRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.currencyAmount);
            this.panel1.Controls.Add(this.labCurrency);
            this.panel1.Controls.Add(this.labRoubles);
            this.panel1.Controls.Add(this.btSell);
            this.panel1.Controls.Add(this.btBuy);
            this.panel1.Controls.Add(this.btStart);
            this.panel1.Controls.Add(this.inputExchangeRate);
            this.panel1.Controls.Add(this.labInputExchangeRate);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 95);
            this.panel1.TabIndex = 0;
            // 
            // currencyAmount
            // 
            this.currencyAmount.DecimalPlaces = 2;
            this.currencyAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currencyAmount.Location = new System.Drawing.Point(471, 25);
            this.currencyAmount.Margin = new System.Windows.Forms.Padding(2);
            this.currencyAmount.Name = "currencyAmount";
            this.currencyAmount.Size = new System.Drawing.Size(73, 22);
            this.currencyAmount.TabIndex = 11;
            this.currencyAmount.ThousandsSeparator = true;
            this.currencyAmount.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // labCurrency
            // 
            this.labCurrency.AutoSize = true;
            this.labCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labCurrency.Location = new System.Drawing.Point(181, 23);
            this.labCurrency.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labCurrency.Name = "labCurrency";
            this.labCurrency.Size = new System.Drawing.Size(105, 16);
            this.labCurrency.TabIndex = 9;
            this.labCurrency.Text = "Currency: 0.00";
            // 
            // labRoubles
            // 
            this.labRoubles.AutoSize = true;
            this.labRoubles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labRoubles.Location = new System.Drawing.Point(181, 7);
            this.labRoubles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labRoubles.Name = "labRoubles";
            this.labRoubles.Size = new System.Drawing.Size(134, 16);
            this.labRoubles.TabIndex = 7;
            this.labRoubles.Text = "Roubles: 10000.00";
            // 
            // btSell
            // 
            this.btSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSell.Location = new System.Drawing.Point(391, 39);
            this.btSell.Margin = new System.Windows.Forms.Padding(2);
            this.btSell.Name = "btSell";
            this.btSell.Size = new System.Drawing.Size(76, 28);
            this.btSell.TabIndex = 6;
            this.btSell.Text = "Sell";
            this.btSell.UseVisualStyleBackColor = true;
            this.btSell.Click += new System.EventHandler(this.btSell_Click);
            // 
            // btBuy
            // 
            this.btBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btBuy.Location = new System.Drawing.Point(391, 7);
            this.btBuy.Margin = new System.Windows.Forms.Padding(2);
            this.btBuy.Name = "btBuy";
            this.btBuy.Size = new System.Drawing.Size(76, 28);
            this.btBuy.TabIndex = 5;
            this.btBuy.Text = "Buy";
            this.btBuy.UseVisualStyleBackColor = true;
            this.btBuy.Click += new System.EventHandler(this.btBuy_Click);
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStart.Location = new System.Drawing.Point(12, 51);
            this.btStart.Margin = new System.Windows.Forms.Padding(2);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(76, 34);
            this.btStart.TabIndex = 4;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // inputExchangeRate
            // 
            this.inputExchangeRate.DecimalPlaces = 2;
            this.inputExchangeRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputExchangeRate.Location = new System.Drawing.Point(12, 25);
            this.inputExchangeRate.Margin = new System.Windows.Forms.Padding(2);
            this.inputExchangeRate.Name = "inputExchangeRate";
            this.inputExchangeRate.Size = new System.Drawing.Size(90, 22);
            this.inputExchangeRate.TabIndex = 2;
            this.inputExchangeRate.ThousandsSeparator = true;
            this.inputExchangeRate.Value = new decimal(new int[] {
            7394,
            0,
            0,
            131072});
            // 
            // labInputExchangeRate
            // 
            this.labInputExchangeRate.AutoSize = true;
            this.labInputExchangeRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labInputExchangeRate.Location = new System.Drawing.Point(9, 7);
            this.labInputExchangeRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labInputExchangeRate.Name = "labInputExchangeRate";
            this.labInputExchangeRate.Size = new System.Drawing.Size(147, 16);
            this.labInputExchangeRate.TabIndex = 0;
            this.labInputExchangeRate.Text = "Input exchange rate:";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 92);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsValueShownAsLabel = true;
            series2.LabelFormat = "f4";
            series2.Legend = "Legend1";
            series2.Name = "Currency";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(925, 377);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 468);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencyAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputExchangeRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown inputExchangeRate;
        private System.Windows.Forms.Label labInputExchangeRate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labCurrency;
        private System.Windows.Forms.Label labRoubles;
        private System.Windows.Forms.Button btSell;
        private System.Windows.Forms.Button btBuy;
        private System.Windows.Forms.NumericUpDown currencyAmount;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz_converter
{
    public partial class Form1 : Form
    {
        double usdToRub = 75.29;
        double euroToRub = 90.5;
        double usdToEuro = 0.83;
        double euroToUsd = 1.2;
        double balanceRub ;
        double balanceUsd ;
        double balanceEuro ;
        string inValue;
        string outValue;
        double countOfTransaction;
        string rub = "RUB";
        string usd = "USD";
        string euro = "EU";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Вы должны ввести баланс КАЖДОЙ валюты(баланс валюты может быть равен 0, но баланс хотя бы одной валюты должен составлять больше 0 чтобы вы могли конвертировать свои финансы)  , " +
                            "Чтобы запомнить баланс нажимте на кнопку  (Запомнить баланс) , " +
                            "программа предназначена для перевода из одной валюты в другую ваших финансов ");
        }

         private void button1_Click(object sender, EventArgs e)
        {
            if (balanceInRub.Text.Length != 0 && balanceInDollar.Text.Length != 0 && balanceInEuro.Text.Length != 0)
            {
                balanceEuro = int.Parse(balanceInEuro.Text);
                balanceUsd = int.Parse(balanceInDollar.Text);
                balanceRub = int.Parse(balanceInRub.Text);
                ButtonConvert.Enabled = true;
                button1.Enabled = false;
                balanceInRub.Enabled = false;
                balanceInEuro.Enabled = false;
                balanceInDollar.Enabled = false;
            }
            else if (balanceInRub.Text.Length == 0 || balanceInDollar.Text.Length == 0 || balanceInEuro.Text.Length != 0)   
            {
                MessageBox.Show("Все поля должны быть заполнены(хотя бы баланс одной валюты должен быть больше 0, если баланс каждой валюты будет равен 0 то это будет нецелесообразно)");
            }
        }

        private void ButtonConvert_Click(object sender, EventArgs e)
        {
            if (textBoxSummOfTransaction.Text.Length > 0 && TextBoxInValue.Text.Length > 0 && TextBoxExitValue.Text.Length > 0)
            {
                inValue = TextBoxInValue.Text.ToUpper();
                outValue = TextBoxExitValue.Text.ToUpper();
                countOfTransaction = double.Parse(textBoxSummOfTransaction.Text);
                if (inValue == euro)
                {
                    if (countOfTransaction <= balanceEuro)
                    {
                        if (balanceEuro > 0)
                        {
                            if (outValue == rub)
                            {
                                balanceEuro = balanceEuro - countOfTransaction;
                                balanceRub = (balanceRub + (countOfTransaction * euroToRub));
                                balanceInRub.Text = balanceRub.ToString();
                                balanceInEuro.Text = balanceEuro.ToString();
                                TextBoxInValue.Clear();
                                TextBoxExitValue.Clear();
                                textBoxSummOfTransaction.Clear();
                            }
                            else if (outValue == usd)
                            {
                                balanceEuro = balanceEuro - countOfTransaction;
                                balanceUsd = (balanceUsd + (countOfTransaction * euroToUsd));
                                balanceInDollar.Text = balanceUsd.ToString();
                                balanceInEuro.Text = balanceEuro.ToString();
                                TextBoxInValue.Clear();
                                TextBoxExitValue.Clear();
                                textBoxSummOfTransaction.Clear();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Баланс этой валюты недостаточен для перевода");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Сумма перевода превышает баланс");
                    }
                }
                if (inValue == usd)
                {
                    if (countOfTransaction <= balanceUsd)
                    {
                        if (balanceUsd > 0)
                        {

                            if (outValue == rub)
                            {
                                balanceUsd = balanceUsd - countOfTransaction;
                                balanceRub = (balanceRub + (countOfTransaction * usdToRub));
                                balanceInRub.Text = balanceRub.ToString();
                                balanceInDollar.Text = balanceUsd.ToString();
                                TextBoxInValue.Clear();
                                TextBoxExitValue.Clear();
                                textBoxSummOfTransaction.Clear();
                            }
                            else if (outValue == euro)
                            {
                                balanceUsd = balanceUsd - countOfTransaction;
                                balanceEuro = (balanceEuro + (countOfTransaction * usdToEuro));
                                balanceInDollar.Text = balanceUsd.ToString();
                                balanceInEuro.Text = balanceEuro.ToString();
                                TextBoxInValue.Clear();
                                TextBoxExitValue.Clear();
                                textBoxSummOfTransaction.Clear();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Баланс этой валюты недостаточен для перевода");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Сумма перевода превышает баланс");
                    }
                }
                if (inValue == rub)
                {
                    if (countOfTransaction <= balanceRub)
                    {
                        if (balanceRub > 0)
                        {
                            if (outValue == usd)
                            {
                                balanceRub = balanceRub - countOfTransaction;
                                balanceUsd = (balanceUsd + (countOfTransaction / usdToRub));
                                balanceInRub.Text = balanceRub.ToString();
                                balanceInDollar.Text = balanceUsd.ToString();
                                TextBoxInValue.Clear();
                                TextBoxExitValue.Clear();
                                textBoxSummOfTransaction.Clear();
                            }
                            if (outValue == euro)
                            {
                                balanceRub = balanceRub - countOfTransaction;
                                balanceEuro = (balanceEuro + (countOfTransaction / euroToRub));
                                balanceInRub.Text = balanceRub.ToString();
                                balanceInEuro.Text = balanceEuro.ToString();
                                TextBoxInValue.Clear();
                                TextBoxExitValue.Clear();
                                textBoxSummOfTransaction.Clear();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Баланс этой валюты недостаточен для превода");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Сумма перевода превышает баланс");
                    }
                }
            }
            else
            {
                MessageBox.Show("Поля не должны быть пустыми !!!");
                TextBoxInValue.Clear();
                TextBoxExitValue.Clear();
                textBoxSummOfTransaction.Clear();
            }

        }
    }
}


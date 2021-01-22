using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using davidMath;

namespace davidFractionalCalc
{
    public partial class Form1 : Form
    {
        davidFractionalNumber fract1 = new davidFractionalNumber();
        davidFractionalNumber fract2 = new davidFractionalNumber();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void CreateFractionalNumber(int jumlahPecahan)
        {
            try
            {
                if(jumlahPecahan == 2)
                {
                    fract1.Pembilang = int.Parse(textBoxFract1Num.Text);
                    fract1.Penyebut = int.Parse(textBoxFract1Denom.Text);

                    fract2.Pembilang = int.Parse(textBoxFract2Num.Text);
                    fract2.Penyebut = int.Parse(textBoxFract2Denom.Text);
                }
                else if(jumlahPecahan == 1)
                {
                    fract1.Pembilang = int.Parse(textBoxPerkalianPecahan.Text);
                    fract1.Penyebut = int.Parse(textBoxPerkalianPenyebut.Text);
                }
                else if(jumlahPecahan == 0)
                {
                    fract1.Pembilang = int.Parse(textBoxFractNum.Text);
                    fract1.Penyebut = int.Parse(textBoxFractDenum.Text);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (radioButtonOperasiPecahanDenganPecahan.Checked)
            {
                try
                {
                    CreateFractionalNumber(2);

                    // davidFractNumber hasil = fract1.Kali(fract2);
                    //listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " * " + fract2.Pembilang + " / " + fract2.Penyebut + " = " + hasil.Pembilang + " / " + hasil.Penyebut);

                    //// hasil konversi integer terdekat
                    //int output = hasil.Convert();
                    //listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " * " + fract2.Pembilang + " / " + fract2.Penyebut + " = " + output);

                    //// hasil konversi integer dengan tingkat ketelitian n digit
                    //double result = hasil.Convert(2);
                    //listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " * " + fract2.Pembilang + " / " + fract2.Penyebut + " = " + result);

                    // menggunakan operator overloading
                    davidFractionalNumber fractResult = fract1 * fract2;
                    listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " * " + fract2.Pembilang + " / " + fract2.Penyebut + " = " + fractResult.Pembilang + " / " + fractResult.Penyebut);

                    // hasil konversi integer terdekat
                    int output = fractResult.Convert();
                    listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " * " + fract2.Pembilang + " / " + fract2.Penyebut + " = " + output);

                    // hasil konversi integer dengan tingkat ketelitian n digit
                    double result = fractResult.Convert(2);
                    listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " * " + fract2.Pembilang + " / " + fract2.Penyebut + " = " + result);

                }
                catch (DivideByZeroException err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            else if (radioButtonOperasiPecahanDenganInteger.Checked)
            {
                    CreateFractionalNumber(1);

                //davidFractNumber result = fract1.Kali(int.Parse(textBoxPerkalianInteger.Text));
                //listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " * " + textBoxPerkalianInteger.Text + " = " + result.Pembilang + " / " + result.Penyebut);

                // menggunakan operator overloading
                davidFractionalNumber result = fract1 * (int.Parse(textBoxPerkalianInteger.Text));
                listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " * " + textBoxPerkalianInteger.Text + " = " + result.Pembilang + " / " + result.Penyebut);

                // hasil konversi integer terdekat 
                int hasil = result.Convert();
                listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " * " + textBoxPerkalianInteger.Text + " = " + hasil);

                // hasil konversi dengan tingkat ketelitian n digit
                double digit = result.Convert(2);
                listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " * " + textBoxPerkalianInteger.Text + " = " + digit);
            }
    }

        private void buttonAddition_Click(object sender, EventArgs e)
        {
            if (radioButtonOperasiPecahanDenganPecahan.Checked)
            {
                try
                {
                    CreateFractionalNumber(2);
                    //davidFractNumber hasil = fract1.Tambah(fract2);
                    //listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " + " + fract2.Pembilang + " / " + fract2.Penyebut + " = " + hasil.Pembilang + " / " + hasil.Penyebut);

                    //// hasil konversi integer terdekat
                    //int output = hasil.Convert();
                    //listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " + " + fract2.Pembilang + " / " + fract2.Penyebut + " = " + output);

                    //// hasil konversi integer dengan tingkat ketelitian n digit
                    //double result = hasil.Convert(2);
                    //listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " + " + fract2.Pembilang + " / " + fract2.Penyebut + " = " + result);

                    // menggunakan operator overload
                    davidFractionalNumber fractResult = fract1 + fract2;
                    listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " + " + fract2.Pembilang + " / " + fract2.Penyebut + " = " + fractResult.Pembilang + " / " + fractResult.Penyebut);

                    // hasil konversi integer terdekat
                    int output = fractResult.Convert();
                    listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " + " + fract2.Pembilang + " / " + fract2.Penyebut + " = " + output);

                    // hasil konversi integer dengan tingkat ketelitian n digit
                    double result = fractResult.Convert(2);
                    listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " + " + fract2.Pembilang + " / " + fract2.Penyebut + " = " + result);
                }
                catch (DivideByZeroException err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            else if (radioButtonOperasiPecahanDenganInteger.Checked)
            {
                CreateFractionalNumber(1);

                //davidFractNumber hasil = fract1.Tambah(int.Parse(textBoxPerkalianInteger.Text));

                //menggunakan operator overloading 
                davidFractionalNumber hasil = fract1 + (int.Parse(textBoxPerkalianInteger.Text));
                listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " + " + textBoxPerkalianInteger.Text +  " = " + hasil.Pembilang + " / " + hasil.Penyebut);

                // hasil konversi integer terdekat
                int output = hasil.Convert();
                listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " + " + textBoxPerkalianInteger.Text + " = " + output);

                // hasil konversi integer dengan tingkat ketelitian n digit
                double result = hasil.Convert(2);
                listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " + " + textBoxPerkalianInteger.Text + " = " + result);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            davidFractionalNumber fract1 = new davidFractionalNumber();
            textBoxFract1Num.Text = fract1.Pembilang.ToString();
            textBoxFract1Denom.Text = fract1.Penyebut.ToString();

            davidFractionalNumber fract2 = new davidFractionalNumber();
            textBoxFract2Num.Text = fract2.Pembilang.ToString();
            textBoxFract2Denom.Text = fract2.Penyebut.ToString();

            davidFractionalNumber fract3 = new davidFractionalNumber();
            textBoxFractNum.Text = fract3.Pembilang.ToString();
            textBoxFractDenum.Text = fract3.Penyebut.ToString();
        }

        private void buttonSubstraction_Click(object sender, EventArgs e)
        {
            if (radioButtonOperasiPecahanDenganPecahan.Checked)
            {
                try
                {
                    CreateFractionalNumber(2);

                    //davidFractNumber hasil = fract1.Kurang(fract2);
                    //listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " - " + fract2.Pembilang + " / " + fract2.Penyebut + " = " + hasil.Pembilang + " / " + hasil.Penyebut);

                    //// hasil konversi integer terdekat
                    //int output = hasil.Convert();
                    //listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " - " + fract2.Pembilang + " / " + fract2.Penyebut + " = " + output);

                    //// hasil konversi integer dengan tingkat ketelitian n digit
                    //double result = hasil.Convert(2);
                    //listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " - " + fract2.Pembilang + " / " + fract2.Penyebut + " = " + result);

                    // menggunakan operator overloading 
                    davidFractionalNumber fractResult = fract1 - fract2;
                    listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " - " + fract2.Pembilang + " / " + fract2.Penyebut + " = " + fractResult.Pembilang + " / " + fractResult.Penyebut);

                    // hasil konversi integer terdekat
                    int output = fractResult.Convert();
                    listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " - " + fract2.Pembilang + " / " + fract2.Penyebut + " = " + output);

                    // hasil konversi integer dengan tingkat ketelitian n digit
                    double result = fractResult.Convert(2);
                    listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " - " + fract2.Pembilang + " / " + fract2.Penyebut + " = " + result);
                }
                catch (DivideByZeroException err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            else if(radioButtonOperasiPecahanDenganInteger.Checked)
            {
                CreateFractionalNumber(1);

                //davidFractNumber hasil = fract1.Kurang(int.Parse(textBoxPerkalianInteger.Text));

                //menggunakan operator overloading
                davidFractionalNumber hasil = fract1 - (int.Parse(textBoxPerkalianInteger.Text));
                listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " - " + textBoxPerkalianInteger.Text + " = " + hasil.Pembilang + " / " + hasil.Penyebut);

                // hasil konversi integer terdekat
                int output = hasil.Convert();
                listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " - " + textBoxPerkalianInteger.Text + " = " + output);

                // hasil konversi integer dengan tingkat ketelitian n digit
                double result = hasil.Convert(2);
                listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " - " + textBoxPerkalianInteger.Text + " = " + result);
            }
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            if (radioButtonOperasiPecahanDenganPecahan.Checked)
            {
                try
                {
                    CreateFractionalNumber(2);

                    //davidFractNumber hasil = fract1.Bagi(fract2);
                    //listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " / " + fract2.Pembilang + " / " + fract2.Penyebut + " = " + hasil.Pembilang + " / " + hasil.Penyebut);

                    //// hasil konversi integer terdekat
                    //int output = hasil.Convert();
                    //listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " / " + fract2.Pembilang + " / " + fract2.Penyebut + " = " + output);

                    //// hasil konversi integer dengan tingkat ketelitian n digit
                    //double result = hasil.Convert(2);
                    //listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " / " + textBoxPerkalianInteger.Text+ " = " + result);

                    //menggunakan operator overloading
                    davidFractionalNumber fractResult = fract1 / fract2;
                    listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " / " + fract2.Pembilang + " / " + fract2.Penyebut + " = " + fractResult.Pembilang + " / " + fractResult.Penyebut);

                    // hasil konversi integer terdekat
                    int output = fractResult.Convert();
                    listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " / " + fract2.Pembilang + " / " + fract2.Penyebut + " = " + output);

                    // hasil konversi integer dengan tingkat ketelitian n digit
                    double result = fractResult.Convert(2);
                    listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " / " + fract2.Pembilang + " /  " + fract2.Penyebut  + " = " + result);


                }

                catch (DivideByZeroException err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            else if(radioButtonOperasiPecahanDenganInteger.Checked)
            {
                CreateFractionalNumber(1);

                //davidFractNumber fractNumber = fract1.Bagi(int.Parse(textBoxPerkalianInteger.Text));

                //menggunakan operator overloading
                davidFractionalNumber fractNumber = fract1 / (int.Parse(textBoxPerkalianInteger.Text));
                listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " / " + textBoxPerkalianInteger.Text + " = " + fractNumber.Pembilang + " / " + fractNumber.Penyebut);

                // hasil konversi integer terdekat
                int output = fractNumber.Convert();
                listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " / " + textBoxPerkalianInteger.Text + " = " + output);

                // hasil konversi integer dengan tingkat ketelitian n digit
                double result = fractNumber.Convert(2);
                listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " / " + textBoxPerkalianInteger.Text + " = " + result);

            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxFract1Num.Clear();
            textBoxFract2Num.Clear();
            textBoxFract1Denom.Clear();
            textBoxFract2Denom.Clear();
            listBoxInfo.Items.Clear();

            textBoxFract1Num.Text = "0";
            textBoxFract1Denom.Text = "1";

            textBoxFract2Num.Text = "0";
            textBoxFract2Denom.Text = "1";

            textBoxPerkalianInteger.Text = "";
            textBoxPerkalianPecahan.Text = "";
            textBoxPerkalianPenyebut.Text = "";

            textBoxFractNum.Text = "";
            textBoxFractDenum.Text = "";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxOperateTwoFractionalNumbers.Enabled = true;
            groupBoxOperasiFractionalNumberPecahanDenganInteger.Enabled = false;
            groupBoxOperasiPecahan.Enabled = false;
        }

        private void radioButtonPerkalianPecahanDenganInteger_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxOperateTwoFractionalNumbers.Enabled = false;
            groupBoxOperasiFractionalNumberPecahanDenganInteger.Enabled = true;
            groupBoxOperasiPecahan.Enabled = false;
        }

        //private void buttonCekKesamaan_Click(object sender, EventArgs e)
        //{
        //    if(radioButtonOperasiPecahanDenganPecahan.Checked)
        //    {
        //        CreateFractionalNumber(2);

        //        // membandingkan kedua pecahan dengan method IsEqual
        //        bool result = fract1.IsEqual(fract2);

        //        if(result == true)
        //        {
        //            listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " = " + fract2.Pembilang + " / " + fract2.Penyebut);
        //        }
        //        else
        //        {
        //            listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " = " + fract2.Pembilang + " / " + fract2.Penyebut);
        //        }
        //    }

        //    else if(radioButtonOperasiPecahanDenganInteger.Checked)
        //    {
        //        CreateFractionalNumber(1);

        //        bool result = fract1.IsEqual(int.Parse(textBoxPerkalianInteger.Text));

        //        if(result == true)
        //        {
        //            listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " = " + textBoxPerkalianInteger.Text );
        //        }
        //        else
        //        {
        //            listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " != " + textBoxPerkalianInteger.Text);
        //        }
        //    }
        //}

        private void buttonSamaDengan_Click(object sender, EventArgs e)
        {
           if(radioButtonOperasiPecahanDenganPecahan.Checked)
            {
                try
                {
                    CreateFractionalNumber(2);
                    listBoxInfo.Items.Clear();

                    if(fract1 == fract2)
                    {
                        listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " = " + fract2.Pembilang +" / " +  fract2.Penyebut);
                    }
                    else
                    {
                        listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " != " + fract2.Pembilang + " / " + fract2.Penyebut);
                    }
                }
                catch (DivideByZeroException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
           else if(radioButtonOperasiPecahanDenganInteger.Checked)
            {
                CreateFractionalNumber(1);
                listBoxInfo.Items.Clear();

                if (fract1 == int.Parse(textBoxPerkalianInteger.Text))
                {
                    listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " = " + textBoxPerkalianInteger.Text);
                }
                else
                {
                    listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " != " + textBoxPerkalianInteger.Text);
                }
            }
        }

        private void buttonTidakSamaDengan_Click(object sender, EventArgs e)
        {
            if(radioButtonOperasiPecahanDenganPecahan.Checked)
            {
                try
                {
                    CreateFractionalNumber(2);
                    listBoxInfo.Items.Clear();

                    if (fract1 != fract2)
                    {
                        listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " != " + fract2.Pembilang + " / " + fract2.Penyebut);
                    }
                    else
                    {
                        listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " = " + fract2.Pembilang + " / " + fract2.Penyebut);
                    }
                }
                catch(DivideByZeroException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if(radioButtonOperasiPecahanDenganInteger.Checked)
            {
                CreateFractionalNumber(1);

                if (fract1 != int.Parse(textBoxPerkalianInteger.Text))
                {
                    listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " != " + textBoxPerkalianInteger.Text);
                }
                else
                {
                    listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " = " + textBoxPerkalianInteger.Text);
                }
            }
        }

        private void buttonLebihKecil_Click(object sender, EventArgs e)
        {
            if(radioButtonOperasiPecahanDenganPecahan.Checked)
            {
                try
                {
                    CreateFractionalNumber(2);
                    listBoxInfo.Items.Clear();

                    if (fract1 < fract2)
                    {
                        listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " < " + fract2.Pembilang + " / " + fract2.Penyebut);
                    }
                    else
                    {
                        listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " !< " + fract2.Pembilang + " / " + fract2.Penyebut);
                    }
                }
                catch(DivideByZeroException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if(radioButtonOperasiPecahanDenganInteger.Checked)
            {
                CreateFractionalNumber(1);
                listBoxInfo.Items.Clear();

                if (fract1 < int.Parse(textBoxPerkalianInteger.Text))
                {
                    listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " < " + textBoxPerkalianInteger.Text);
                }
                else
                {
                    listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " !< " + textBoxPerkalianInteger.Text);
                }
            }
        }

        private void buttonLebihBesar_Click(object sender, EventArgs e)
        {
            if(radioButtonOperasiPecahanDenganPecahan.Checked)
            {
                try
                {
                    CreateFractionalNumber(2);
                    listBoxInfo.Items.Clear();

                    if (fract1 > fract2)
                    {
                        listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " > " + fract2.Pembilang + " / " + fract2.Penyebut);
                    }
                    else
                    {
                        listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " !> " + fract2.Pembilang + " / " + fract2.Penyebut);
                    }
                }
                catch(DivideByZeroException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (radioButtonOperasiPecahanDenganInteger.Checked)
            {
                CreateFractionalNumber(1);
                listBoxInfo.Items.Clear();

                if (fract1 > int.Parse(textBoxPerkalianInteger.Text))
                {
                    listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " > " + textBoxPerkalianInteger.Text);
                }
                else
                {
                    listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " !> " + textBoxPerkalianInteger.Text);
                }
            }
        }

        private void buttonLebihKecilSamaDengan_Click(object sender, EventArgs e)
        {
            if(radioButtonOperasiPecahanDenganPecahan.Checked)
            {
                try
                {
                    CreateFractionalNumber(2);
                    listBoxInfo.Items.Clear();

                    if (fract1 <= fract2)
                    {
                        listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " <= " + fract2.Pembilang + " / " + fract2.Penyebut);
                    }
                    else
                    {
                        listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " !<=" + fract2.Pembilang + " / " + fract2.Penyebut);
                    }
                }
                catch(DivideByZeroException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (radioButtonOperasiPecahanDenganInteger.Checked)
            {
                CreateFractionalNumber(1);
                listBoxInfo.Items.Clear();

                if (fract1 <= int.Parse(textBoxPerkalianInteger.Text))
                {
                    listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " <= " + textBoxPerkalianInteger.Text);
                }
                else
                {
                    listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " !< " + textBoxPerkalianInteger.Text);
                }
            }
        }

        private void buttonLebihBesarSamaDengan_Click(object sender, EventArgs e)
        {
            if(radioButtonOperasiPecahanDenganPecahan.Checked)
            {
                try
                {
                    CreateFractionalNumber(2);
                    listBoxInfo.Items.Clear();

                    if (fract1 >= fract2)
                    {
                        listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " >= " + fract2.Pembilang + " / " + fract2.Penyebut);
                    }
                    else
                    {
                        listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " !>= " + fract2.Pembilang + " / " + fract2.Penyebut);
                    }
                }
                catch(DivideByZeroException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (radioButtonOperasiPecahanDenganInteger.Checked)
            {
                CreateFractionalNumber(1);
                listBoxInfo.Items.Clear();

                if (fract1 >= int.Parse(textBoxPerkalianInteger.Text))
                {
                    listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " >= " + textBoxPerkalianInteger.Text);
                }
                else
                {
                    listBoxInfo.Items.Add(fract1.Pembilang + " / " + fract1.Penyebut + " !>= " + textBoxPerkalianInteger.Text);
                }
            }
        }

        private void buttonPlusPlus_Click(object sender, EventArgs e)
        {
            if(radioButtonOperasiPecahan.Checked)
            {
                try
                {
                    CreateFractionalNumber(0);

                    fract1++;
                    listBoxInfo.Items.Add("Hasil ++ " + fract1.Pembilang + " / " + fract1.Penyebut);
                }
                catch(DivideByZeroException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonMinusMinus_Click(object sender, EventArgs e)
        {
            if (radioButtonOperasiPecahan.Checked)
            {
                try
                {
                    CreateFractionalNumber(0);

                    fract1--;
                    listBoxInfo.Items.Add("Hasil -- " + fract1.Pembilang + " / " + fract1.Penyebut);
                }
                catch (DivideByZeroException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void radioButtonOperasiPecahan_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxOperasiPecahan.Enabled = true;
            groupBoxOperasiFractionalNumberPecahanDenganInteger.Enabled = false;
            groupBoxOperateTwoFractionalNumbers.Enabled = false;
        }
    }
}

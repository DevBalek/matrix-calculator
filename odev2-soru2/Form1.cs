/****************************************************************************
**					               SAKARYA ÜNİVERSİTESİ
**			             BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				                BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				                Nesneye Dayalı Programlama Dersi
**	
**				ÖDEV NUMARASI…...: 2nd  *Question 2* Homework
**				ÖĞRENCİ ADI...............: Muhammed Furkan BALEK
**				ÖĞRENCİ NUMARASI.:  G191210069
**				DERS GRUBU…………: Group 2D
****************************************************************************/

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev2_soru2
{
    public partial class Form1 : Form
    {
        List<int> matA = new List<int>();
        List<int> matB = new List<int>();

        //For Determinant
        List<int> abcd = new List<int>();
        float[,] matRes = new float[10, 10];
        string selection;

        public Form1()
        {

            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {


            // Since I will use the insert method, there must be data inside
            for (int i = 0; i < 100; i++)
            {
                matA.Add(0);
            }

            // Since I will use the insert method, there must be data inside
            for (int i = 0; i < 100; i++)
            {
                matB.Add(0);
            }

            string title = "Tanıtım";
            string message = "1- Matrisinizi değiştirmek istiyorsanız önceki matrisi silmelisiniz.\n\n" +
                "2- İşlemin yanlış olduğunu düşünüyorsanız aynı verileri tekrardan girip deneyin.\n\n" +
                "3- Arayüz Dolayısıyla Maximum satır ve sütun 9 ile sınırlandırılmıştır \n\n" +
                "4- Read Butonuyla .txt dosyalarınızı Zengin Yazı Formatı Ekranında görüntüleyebilirsiniz.\n\n" +
                "5- Save Butonunu kullanarak işlemlerinizi istediğiniz yere istediğiniz isimle kaydedebiliriniz.\n\n";
          
            MessageBox.Show(message, title);

        }

        //For Dynamicly access List element.
        private int ind(int row, int column)
        {

            string index = row + "" + column;

            int value = int.Parse(index);

            return value;
        }

        #region Create Dynamicly Text Box

        //Create Matrix A with using Text Box
        TextBox textb(char mat, int row, int column,int counter)
        {
            TextBox t = new TextBox();
            t.Name = mat + row.ToString() + column.ToString() ;
            t.Width = 30;
            t.Height = 30;
            t.Text =  "0";
            t.TextChanged += c_Changed;


            return t;
        }

        //Result
        TextBox textRes(int row, int column,float value)
        {
            TextBox c = new TextBox();
            c.Name = row.ToString() + column.ToString();
            c.Width = 30;
            c.Height = 30;
            c.Text = value + "";
            c.Enabled = false;
                        
            return c;
        }

        #endregion

        #region Create Matrix A
        private void createMatA_Click(object sender, EventArgs e)
        {

            int row = 1;
            int column = 1;

            try //Take numbers from Numeric Updown
            {

                row = int.Parse(ArowNum.Value.ToString());
                column = int.Parse(AcolumnNum.Value.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem Başarısız.");
            }
           


            flowLayoutPanel1.Width = column * 38;

            int counter = 0;

            //Create A Matrix using textb() method in flowlayoutpanel
            for (int i = 0; i < row; i++)
            {
                for(int j=0; j < column; j++)
                {
                    flowLayoutPanel1.Controls.Add(textb('a', i, j,counter));
                    counter++;
                }

            }

            

            
        }
        #endregion

        #region Create Matrix B
        private void createMatB_Click(object sender, EventArgs e)
        {
            
            int row = 1;
            int column = 1;

            try //Take numbers from Numeric Updown
            {
                 row = int.Parse(BrowNum.Text.ToString());
                 column = int.Parse(BcolumnNum.Text.ToString());
            }
            catch(Exception)
            {
                MessageBox.Show("İşlem Başarısız.");
            }



            flowLayoutPanel2.Width = column * 38;


            int counter = 0;

            //Create B Matrix using textb() method in flowlayoutpanel
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    flowLayoutPanel2.Controls.Add(textb('b', i, j, counter));
                    counter++;
                }

            }


        }
        #endregion

        #region Matrix A and B List
        // A and B changes situation
        private void c_Changed(object sender, EventArgs e)
        {

            TextBox t = (TextBox)sender;
            try
            {
                //if the created text have a or b keyword, the funciton will seperate two variants and puts true list.
                if (t.Name.Substring(0, 1) == "b")
                {
                    int value = int.Parse(t.Name.Substring(1, 2));

                    matB.Insert(value, int.Parse(t.Text));
                }
                else if (t.Name.Substring(0, 1) == "a")
                {
                    int value = int.Parse(t.Name.Substring(1, 2));

                    matA.Insert(value, int.Parse(t.Text));
                }

            }
            catch (Exception)
            {

            }

        }

        
        #endregion

        #region Clear

        //Clear Functions
        private void clearMatA_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            clearList('a');
        }
        private void clearMatB_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            clearList('b');
        }
        private void clearResult_Click(object sender, EventArgs e)
        {
            flowLayoutPanel3.Controls.Clear();
        }
        private void clearList(char whichOne)
        {
            if (whichOne == 'a')
            {
                matA.Clear();
                //Insert methodu kullanacağım için içeride önceden veri bulunması gerekiyor.
                //The function puts value in matA and matB because of i will use insert method that should already have value.
                for (int i = 0; i < 100; i++)
                {
                    matA.Add(0);
                }
            }       
            else if (whichOne == 'b')
            {
                matB.Clear();
                //Insert methodu kullanacağım için içeride önceden veri bulunması gerekiyor
                //The function puts value in matA and matB because of i will use insert method that should already have value.
                for (int i = 0; i < 100; i++)
                {
                    matB.Add(0);
                }
            }
              
        }

        #endregion

        #region Summation

        private void matSum_Click(object sender, EventArgs e)
        {
            selection = "Summation";

            flowLayoutPanel3.Controls.Clear();

            int row = 1;
            int column = 1;
            int rowB = 1;
            int columnB = 1;


            try
            { //Take numbers from Numeric Updown
                row = int.Parse(ArowNum.Value.ToString());
                column = int.Parse(AcolumnNum.Value.ToString());
                rowB = int.Parse(BrowNum.Value.ToString());
                columnB = int.Parse(BcolumnNum.Value.ToString());

            }
            catch (Exception)
            {
                MessageBox.Show("İşlem Başarısız.");
            }

            //Two Matrix should have same row and column value.
            if ((row != rowB) || (column!=columnB) ) {

                MessageBox.Show("Matrix A and Matrix B should same row and column.","İşlem Gerçekleştirilemez.");
                return;
            }

            flowLayoutPanel3.Width = column * 38;

            int counter = 0;

            //This loop find matrix value and addition same index value.
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    int val;

                    val = matA[ind(i, j)] + matB[ind(i, j)];

                    flowLayoutPanel3.Controls.Add(textRes(i, j, val));
                    matRes[i, j] = val;

                    counter++;
                }
            }

        

        }

        #endregion

        #region Multiplication
        private void matMult_Click(object sender, EventArgs e)
        {
            selection = "Multiplication";

            flowLayoutPanel3.Controls.Clear();

            int row = 1;
            int column = 1;
            int rowB = 1;
            int columnB = 1;

            


            try
            {  //Take numbers from Numeric Updown

                row = int.Parse(ArowNum.Value.ToString());
                column = int.Parse(AcolumnNum.Value.ToString());
                rowB = int.Parse(BrowNum.Value.ToString());
                columnB = int.Parse(BcolumnNum.Value.ToString());

            }
            catch (Exception)
            {
                MessageBox.Show("İşlem Başarısız.");
            }

            // To multiply two matrices, the column of matrix A must be equal to the row of matrix B.
            if ((column != rowB) )
            {
                MessageBox.Show("Matrix A [ij] x Matrix B [xy] should same j = x (Column A = Row B)","İşlem Gerçekleştirilemez.");
                return;
            }

            flowLayoutPanel3.Width = columnB * 38;

            int value = 0;

            for (int i = 0; i < row; i++)
            {
                for(int j = 0; j < columnB; j++)
                {
                    //Matrix cell to be calculated found

                    //Multiply step by step Matrix B Column members.
                    for (int k=0; k < column; k++)
                    {              
                        value += matA[ind(i,k)] * matB[ind(k,j)];
                    }

                    matRes[i, j] = value;
                    flowLayoutPanel3.Controls.Add(textRes(i, j, value));
                    value = 0;

                }
                    
            }

        }
        #endregion

        #region Inverse of Matrix
        private void matRev_Click(object sender, EventArgs e)
        {
            selection = "Reverse";
            flowLayoutPanel3.Controls.Clear();

            int row = 1;
            int column = 1;



            try
            { //Take numbers from Numeric Updown
                row = int.Parse(ArowNum.Value.ToString());
                column = int.Parse(AcolumnNum.Value.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem Başarısız.");
            }

            //The matrix type should be square.
            if ((column != row))
            {
                MessageBox.Show("Matrix A [] should be square matrix", "İşlem Gerçekleştirilemez.");
                return;
            }

            float[,] birimmatris = new float[100, 100];
            float[,] matAfloat = new float[100, 100];


            //Copying matA list element to matAfloat list
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matAfloat[i, j] = matA[ind(i, j)];
                }

            }

            flowLayoutPanel3.Width = column * 38;

            float d, k;

            //Create space for identity matrix
            for (int i = 0; i < row; i++)
            {
                for(int j = 0; j < column;j++)
                {
                    if (i == j)
                        birimmatris[i, j] = 1;
                    else
                        birimmatris[i, j] = 0;
                }
            }

            //The diagonal values ​​are divided by the diagonal values ​​of the original matrix.
            for (int i = 0; i < row; i++)
            {
                d = matAfloat[i, i]; 

                for(int j = 0; j < column; j++)
                {
                    matAfloat[i, j] = matAfloat[i, j] / d;                   
                    birimmatris[i, j] = birimmatris[i, j] / d;
                }
                //Then, for the non-diagonal values, the products that are not in the diagonal are subtracted by the return element and the second loop starting in row 450 with the element in the diagonal.
                for (int x = 0; x < column; x++)
                {
                    if (x != i)
                    {
                        k = matAfloat[x, i];
                        for(int j = 0; j < column; j++)
                        {
                            matAfloat[x, j] = matAfloat[x, j] - (matAfloat[i, j] * k);
                            birimmatris[x, j] = birimmatris[x, j] - (birimmatris[i, j] * k);  
                        }

                    }

                }

            }

            //Inverse of Matrix A = birimmatris[]
            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < column; j++)
                {

                    float value = birimmatris[i, j];

                    matRes[i, j] = value;
                    //printing values
                    flowLayoutPanel3.Controls.Add(textRes(i, j, value));

                }
            }

        }

        #endregion

        #region Trace of Matrix
        private void matTrac_Click(object sender, EventArgs e)
        {
            selection = "Trace";
            flowLayoutPanel3.Controls.Clear();

            int row = 1;
            int column = 1;

            try
            { //Take numbers from Numeric Updown
                row = int.Parse(ArowNum.Value.ToString());
                column = int.Parse(AcolumnNum.Value.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem Başarısız.");
            }

            //The matrix type should be square.
            if ((column != row))
            {
                MessageBox.Show("Matrix A [] should be square matrix", "İşlem Gerçekleştirilemez.");
                return;
            }

            int value=0;


            //Finding Matrix members
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    //Diagonal members gathering
                    if (i==j)
                    value += matA[ind(i,j)];

                }

            }

            matRes[0, 0] = value;
            //printing values
            flowLayoutPanel3.Controls.Add(textRes(0, 0, value));
        }
        #endregion
 
        #region Transpoze of Matrix
        private void matTrans_Click(object sender, EventArgs e)
        {
            selection = "Transpoze";

            flowLayoutPanel3.Controls.Clear();

            int row = 1;
            int column = 1;

            try
            { //Take numbers from Numeric Updown
                row = int.Parse(ArowNum.Value.ToString());
                column = int.Parse(AcolumnNum.Value.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem Başarısız.");
            }

            int value;

            int[,] matTranspoze = new int[10, 10];


            flowLayoutPanel3.Width = row * 38;


            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    //Swapping row and column members 

                    value = matA[ind(i, j)];

                    matTranspoze[j, i] = value;
                    
                }

            }

            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    //Printing new matrix
                    value = matTranspoze[i, j];
                    flowLayoutPanel3.Controls.Add(textRes(j, i, value));

                    matRes[j, i] = value;

                }

            }

        }

        #endregion

        #region Rich Text Box Procces
        private void saveRich_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";
            save.Title = "Save File";

            int row = 1;
            int column = 1;
            int rowB = 1;
            int columnB = 1;


            try
            { //Take numbers from Numeric Updown
                row = int.Parse(ArowNum.Value.ToString());
                column = int.Parse(AcolumnNum.Value.ToString());
                rowB = int.Parse(BrowNum.Value.ToString());
                columnB = int.Parse(BcolumnNum.Value.ToString());

            }
            catch (Exception)
            {
                MessageBox.Show("İşlem Başarısız.");
            }

            #region RichTextBox Write Calculations

            richTextBox1.AppendText("Matrix [A] ");
            richTextBox1.AppendText(Environment.NewLine);

            //Getting Matrix A values in list
            for (int i = 0; i < row; i++)
            {

                for(int j = 0; j < column; j++)
                {
                    richTextBox1.AppendText(matA[ind(i,j)].ToString() + "|");
                }

                richTextBox1.AppendText("\n");
            }

            richTextBox1.AppendText("\n");

            if (selection == "Summation")
            {
                #region Summation
                richTextBox1.AppendText("  +  \n\n");

                richTextBox1.AppendText("Matrix [B] \n");

                //Matrix B
                for (int i = 0; i < rowB; i++)
                {
                    for (int j = 0; j < columnB; j++)
                    {
                        richTextBox1.AppendText(matB[ind(i, j)].ToString()+"|");
                    }

                    richTextBox1.AppendText(Environment.NewLine);
                }

                richTextBox1.AppendText("\n = \n \n" );


                //Result
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        float val;

                        val = matRes[i, j];

                        richTextBox1.AppendText(val.ToString() + "|");
                    }

                    richTextBox1.AppendText(Environment.NewLine);
                }

                #endregion

            }
            else if(selection== "Multiplication")
            {
                #region Multiplication

                richTextBox1.AppendText("     *    \n\n ");


                richTextBox1.AppendText("Matrix [B] \n");

                //Matrix B
                for (int i = 0; i < rowB; i++)
                {
                    for (int j = 0; j < columnB; j++)
                    {
                        richTextBox1.AppendText(matB[ind(i, j)].ToString() + "|");
                    }

                    richTextBox1.AppendText(Environment.NewLine);
                }

                richTextBox1.AppendText("\n = \n\n");


                //Matrix Result
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < columnB; j++)
                    {
                        float val;

                        val = matRes[i, j];

                        richTextBox1.AppendText(val.ToString() + "|");
                    }

                    richTextBox1.AppendText(Environment.NewLine);
                }
                #endregion

            }
            else if (selection == "Reverse")
            {
                #region Reverse

                richTextBox1.AppendText("Matrix [A] Reverse \n\n");

                //Result
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        float val;

                        val = matRes[i, j];

                        richTextBox1.AppendText(val.ToString() + "|");
                    }

                    richTextBox1.AppendText(Environment.NewLine);
                }
                #endregion
            }
            else if (selection == "Trace")
            {
                #region Trace

                richTextBox1.AppendText("Matrix [A] Trace \n\n");

                richTextBox1.AppendText(matRes[0, 0].ToString());
                #endregion
            }
            else if (selection == "Transpoze")
            {
                #region Transpoze

                richTextBox1.AppendText("Matrix [A] Transpoze \n\n");

                //Result
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        float val;

                        val = matRes[i, j];

                        richTextBox1.AppendText(val.ToString() + "|");
                    }

                    richTextBox1.AppendText(Environment.NewLine);
                }
                #endregion
            }

            richTextBox1.AppendText("\n---------------------------\n");

            #endregion


            //Saving Location
            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(File.Create(save.FileName));

                write.Write(richTextBox1.Text);
                write.Dispose();
            }

        }
        

        private void readRich_Click(object sender, EventArgs e)
        {
            //Selecting which read file
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";
            open.Title = "Open File";

            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader read = new StreamReader(File.OpenRead(open.FileName));
                richTextBox1.Text = read.ReadToEnd();
                read.Dispose();
            }

        }

        #endregion

        //Not Used (For Developer)(Has some issue)
        #region DETERMİNANT

        private void addMember(int a)
        {
            abcd.Add(a);
        }


        private int det_2x2()
        {
            int result;


            result = (abcd[0] * abcd[3]) - (abcd[1] * abcd[2]);

            // ij 0 0     0 ij 0    0 0 ij
            // 0  a b     a  0 b    a b 0
            // 0  c d     c  0 d    c d 0

            return result;
        }

        private int determinant(int row, int column, List<int> oldmatrix)
        {
            int determinantResult = 0;

            if (row != column)
            {
                MessageBox.Show("Matrisiniz kare değil.");
                return 0;
            }


            List<int> newmatrix = detMatrix();

            for (int i = 0; i < 100; i++)
            {
                newmatrix.Add(0);
            }

            int det3 = 0;
            int detTempDet = 1;
            int artieksi = -1;

            int a = 0;
            int b = 0;


            if (row == 3)
            {
                #region 3 x 3 Matrix

                det3 = 0;
                detTempDet = 1;
                artieksi = -1;

                a = 0;
                b = 0;

                //3x3 matrix

                // ij 0 0     0 ij 0    0 0 ij
                // 0  a b     a  0 b    a b 0
                // 0  c d     c  0 d    c d 0

                //Row
                for (int i = 0; i < 3; i++)
                {
                    //Column
                    for (int j = 0; j < 3; j++)
                    {

                        if (i == 0)
                        {

                            a = i;
                            b = j;

                            for (int k = 0; k < 3; k++)
                            {
                                for (int l = 0; l < 3; l++)
                                {

                                    if ((k != a) && (l != b))
                                        addMember(oldmatrix[ind(k, l)]);

                                }



                            }

                            artieksi = artieksi * -1;

                            detTempDet = det_2x2();

                            det3 += artieksi * oldmatrix[ind(i, j)] * detTempDet;

                            detTempDet = 1;

                            abcd.Clear();
                        }

                    }
                }

                determinantResult = det3;

                return determinantResult;
                #endregion
            }


            #region n x n matrix

            det3 = 0;
            detTempDet = 1;
            artieksi = -1;

            a = 0;
            b = 0;

            //nxn matrix

            // ij 0 0     0 ij 0    0 0 ij
            // 0  a b     a  0 b    a b 0
            // 0  c d     c  0 d    c d 0

            //Row
            for (int i = 0; i < row; i++)
            {
                //Column
                for (int j = 0; j < column; j++)
                {

                    if (i == 0)
                    {

                        a = i;
                        b = j;

                        for (int k = 0; k < row; k++)
                        {
                            for (int l = 0; l < column; l++)
                            {

                                if ((k != a) && (l != b))
                                    newmatrix.Insert(ind(k, l), oldmatrix[ind(k, l)]);
                                //addMember(oldmatrix[ind(k, l)]);

                            }



                        }

                        artieksi = artieksi * -1;

                        detTempDet = determinant(row - 1, column - 1, newmatrix);

                        det3 += artieksi * oldmatrix[ind(i, j)] * detTempDet;

                        detTempDet = 1;

                        determinantResult = det3;

                    }

                }
            }

            //   label8.Text = det3.ToString();


            #endregion



            return determinantResult;
        }

        List<int> detMatrix()
        {
            List<int> b = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                b.Add(0);
            }


            return b;
        }


        #endregion //Not Used
    }
}


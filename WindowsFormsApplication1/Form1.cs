using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private DataTable m_GpsTable = new DataTable("控制点");
        private string m_strPointIdx = "点号";
        private string m_strSrcPointX = "源X";
        private string m_strSrcPointY = "源Y";
        private string m_strSrcPointZ = "源Z";
        private string m_strDesPointX = "目标X";
        private string m_strDesPointY = "目标Y";
        private string m_strDesPointZ = "目标Z";
        public Form1()
        {
            InitializeComponent();
            InitParams();
        }
        private void InitParams()
        {
            m_GpsTable.Columns.Add(m_strPointIdx, System.Type.GetType("System.Int32"));
            m_GpsTable.Columns.Add(m_strSrcPointX, System.Type.GetType("System.String"));
            m_GpsTable.Columns.Add(m_strSrcPointY, System.Type.GetType("System.String"));
            m_GpsTable.Columns.Add(m_strSrcPointZ, System.Type.GetType("System.String"));
            m_GpsTable.Columns.Add(m_strDesPointX, System.Type.GetType("System.String"));
            m_GpsTable.Columns.Add(m_strDesPointY, System.Type.GetType("System.String"));
            m_GpsTable.Columns.Add(m_strDesPointZ, System.Type.GetType("System.String"));
            gridControl1.DataSource=m_GpsTable;
        }
        ///// <summary>
        ///// 两个控制点计算
        ///// </summary>
        ///// <param name="dx1"></param>
        ///// <param name="dy1"></param>
        ///// <param name="dx1_1"></param>
        ///// <param name="dy1_1"></param>
        ///// <param name="dx2"></param>
        ///// <param name="dy2"></param>
        ///// <param name="dx2_2"></param>
        ///// <param name="dy2_2"></param>
        //public void Csjs4Param(double dx1, double dy1, double dx1_1, double dy1_1, double dx2, double dy2, double dx2_2, double dy2_2)
        //{
          
        //    double dxtemp = dx2 - dx1;
        //    double dyTemp = dy2 - dy1;
        //    double dxtemp_1 = dx2_2 - dx1_1;
        //    double dyTemp_1 = dy2_2 - dy1_1;
        //    double a =Math.Atan(dxtemp / dyTemp)-Math.Atan(dxtemp_1 / dyTemp_1) ;
        //    double k =Math.Sqrt(dxtemp_1 * dxtemp_1 + dyTemp_1 * dyTemp_1) / Math.Sqrt(dxtemp * dxtemp + dyTemp * dyTemp);
        //    double k1 = k * Math.Cos(a);
        //    double k2 = k * Math.Sin(a);
        //    double x = dx1_1 - dx1 * k1 + dy1 * k2;
        //    double y = dy1_1 - dy1 * k1 - dx1 * k2;

        //    //double x1 = dx2_2 - dx2 * k1 + dy2 * k2;
        //    //double y1 = dx2_2 - dx2 * k1 + dy2 * k2;
        //    //double x = dx1_1 / k - dx1 * Math.Cos(a1) + dy1 * Math.Sin(a1);
        //    //textBox1.Text = a.ToString();
        //    //textBox2.Text = k.ToString();
        //    //textBox3.Text = (x).ToString();
        //    //textBox4.Text = (y).ToString();
        //}
        public int maqr(double[] a, int m, int n, double[] q)
        {
            int i, j, k, l, nn, p, jj;
            double u, alpha, w, t;
            if (m < n)
            { 
                return 0;
            }
            for (i = 0; i <= m - 1; i++)
                for (j = 0; j <= m - 1; j++)
                {
                    l = i * m + j; q[l] = 0.0;
                    if (i == j) q[l] = 1.0;
                }
            nn = n;
            if (m == n) nn = m - 1;
            for (k = 0; k <= nn - 1; k++)
            {
                u = 0.0; l = k * n + k;
                for (i = k; i <= m - 1; i++)
                {
                    w = Math.Abs(a[i * n + k]);
                    if (w > u) u = w;
                }
                alpha = 0.0;
                for (i = k; i <= m - 1; i++)
                { t = a[i * n + k] / u; alpha = alpha + t * t; }
                if (a[l] > 0.0) u = -u;
                alpha = u * Math.Sqrt(alpha);
                if (Math.Abs(alpha) + 1.0 == 1.0)
                { //printf("fail\n"); return(0);
                    return 0;
                }
                u = Math.Sqrt(2.0 * alpha * (alpha - a[l]));
                if ((u + 1.0) != 1.0)
                {
                    a[l] = (a[l] - alpha) / u;
                    for (i = k + 1; i <= m - 1; i++)
                    { p = i * n + k; a[p] = a[p] / u; }
                    for (j = 0; j <= m - 1; j++)
                    {
                        t = 0.0;
                        for (jj = k; jj <= m - 1; jj++)
                            t = t + a[jj * n + k] * q[jj * m + j];
                        for (i = k; i <= m - 1; i++)
                        { p = i * m + j; q[p] = q[p] - 2.0 * t * a[i * n + k]; }
                    }
                    for (j = k + 1; j <= n - 1; j++)
                    {
                        t = 0.0;
                        for (jj = k; jj <= m - 1; jj++)
                            t = t + a[jj * n + k] * a[jj * n + j];
                        for (i = k; i <= m - 1; i++)
                        { p = i * n + j; a[p] = a[p] - 2.0 * t * a[i * n + k]; }
                    }
                    a[l] = alpha;
                    for (i = k + 1; i <= m - 1; i++)
                        a[i * n + k] = 0.0;
                }
            }
            for (i = 0; i <= m - 2; i++)
                for (j = i + 1; j <= m - 1; j++)
                {
                    p = i * m + j; l = j * m + i;
                    t = q[p]; q[p] = q[l]; q[l] = t;
                }
            return (1);
        }
        int gmqr(double[] a, int m, int n, double[] b, double[] q)
        {
            int i, j;
            double d;
            double[] c = new double[n];
            i = maqr(a, m, n, q);
            if (i == 0)
            { 
                return (0);
            }
            for (i = 0; i <= n - 1; i++)
            {
                d = 0.0;
                for (j = 0; j <= m - 1; j++)
                    d = d + q[j * m + i] * b[j];
                c[i] = d;
            }
            b[n - 1] = c[n - 1] / a[n * n - 1];
            for (i = n - 2; i >= 0; i--)
            {
                d = 0.0;
                for (j = i + 1; j <= n - 1; j++)
                    d = d + a[i * n + j] * b[j];
                b[i] = (c[i] - d) / a[i * n + i];
            }
            return (1);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow newRow = m_GpsTable.NewRow();
            newRow[m_strPointIdx] = m_GpsTable.Rows.Count + 1;
            m_GpsTable.Rows.Add(newRow);
            gridControl1.Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int Index=this.gridView1.GetSelectedRows()[0];
            if (Index == -1)
            {
                MessageBox.Show("请选择焦点行");
            }
            this.gridView1.DeleteRow(Index);
        }
        /// <summary>
        /// 计算参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (cmbSrcElipse.SelectedIndex == -1 || cmbDesElipse.SelectedIndex == 1)
            {
                MessageBox.Show("请选择需要转换的椭球基准！");
                return;
            }
            if (rdbtnFourParams.Checked)//计算四参数，四参数适合平面坐标系之间的转换
            {
                    
            }
            else //计算七参数
            {

            }
        }

        /// <summary>
        /// 计算四参数
        /// </summary>
        /// <param name="dsrcPoint"></param>
        /// <param name="dDesPoint"></param>
        /// <param name="pointCount"></param>
        private void CaluateFourParams(double []dsrcPoint,double []dDesPoint,int pointCount)
        {
            //转换公式
            //double d0 = dk * (x * Math.Cos(dt) - y * Math.Sin(dt) + dx);
            //double dy0 = dk * (x * Math.Sin(dt) + y * Math.Cos(dt) + dy);
            int m=pointCount*2;//行数
            int n=4; //列数，4个参数
            double[] a = new double[m * n]; //左边矩阵
            double[] b = new double[m];
            double[] q=new double[m*m];
            for (int i = 0; i < pointCount; i++) //初始化左边矩阵:一个坐标可以构建两行共8个参数
            {
                a[8 * i] = dsrcPoint[3 * i];
                a[8 * i+1] = -dsrcPoint[3 * i+1];
                a[8 * i + 2] = 1;
                a[8 * i + 3] = 0;
                a[8 * i+4] = dsrcPoint[3 * i+1];
                a[8 * i+5] = dsrcPoint[3 * i];
                a[8 * i+6] = 0;
                a[8 * i + 7] =1;
            }
            for (int i = 0; i < pointCount; i++)
            {
                b[2 * i] = dDesPoint[3 * i];
                b[2 * i + 1] = dDesPoint[3 * 1 + 1];
            }
            gmqr(a, m, n, b, q);
            //显示参数
            double dx = q[0];
            double dy = q[1];
            double dk = q[2];
            double dt = q[3];
        }
        private void CaluateSevenParams(double[] dsrcPoint, double[] dDesPoint, int pointCount)
        {

        }
    }
}

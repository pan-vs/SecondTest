using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace SecondTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal? o = 1;
            decimal? oo = 10;
            var dif = o ?? 0 - oo;

            //string tt = "12345678901";
            //var ttt = (tt.Length > 10) ? tt.Substring(0, 10) : tt;

            //string nazn = "НазначениеПлатежа=Оплата по договору ОФ-1П за автомобильные запасные части и принадлежности. Сумма 1 031 441-61. в т.ч. НДС (20%) 171 906-94";
            //nazn = nazn.Replace(" ", string.Empty);

            //string purposePayment = "Плата за пополнение по операции СБП 587209275. Договор 7021966473";
            //purposePayment = purposePayment.Substring(0, purposePayment.IndexOf("Договор")).Trim();

            //MessageBox.Show("purposePayment");
            //return;
            int ii;
            List<int> tt = new List<int> { 11, 22, 33 };
            if ((new List<int> { 11, 22, 33 }).Contains(1))
                ii = 1;
            else
                ii = 11;
            //string inn = "ijhyuytfytf";
            //string tt = @"У участника {inn} нет прав";
            //MessageBox.Show(tt);
            //bool? b;
            //bool? s = true;
            //b = s;

            List<int> rez = new List<int>();
            string str = "11";

            if (str.Trim().Length > 0)
            {
                var t = str.Split(new char[] { ',' }).ToList();

                foreach (var item in t)
                {
                    int i;
                    bool isInt = int.TryParse(item, out i);
                    if (isInt)
                        rez.Add(i);
                }
            }

            MessageBox.Show(GetMissInvoiceSFIdOnVerifyCZInDiadoc(1111).ToString());






        }

        public bool GetMissInvoiceSFIdOnVerifyCZInDiadoc(long invoiceSFId)
        {
            string str = "1111,11111,2222";

            if (str.Trim().Length > 0)
            {
                var t = str.Split(new char[] { ',' }).ToList();
                foreach (var item in t)
                {
                    if (item == invoiceSFId.ToString())
                        return true;
                }
            }
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<tt> o = new List<tt>();
            tt c = new tt();
            o.Add(c);
            tt cc = new tt() { id = 1, name = null };
            o.Add(cc);
            //tt ccc = new tt() { id = 2, name = string.Empty };
            //o.Add(ccc);
            //tt cccc = new tt() { id = 3, name = "name" };
            //o.Add(cccc);

            // var t = o.Where(x => ((x.name != null) && (x.name.Length > 0))).ToArray();
            var t = o.Where(x => ((x.name?? string.Empty).Length > 0)).ToArray();
            //var t = o.ItemTracingInfos.Where(x => x.RegNumberUnit.Length > 0).Select(x => x.RegNumberUnit).ToArray();
        }

        class tt
        {
            public int id;
            public string name;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> lst = new List<string>();
            lst.Add("111");
            lst.Add("222");
            lst.Add("333");
            var t = lst.ToArray();

            string[] k = null;

            if (k == null)
            {
                int i = 1;
            }

            var serializer = new JavaScriptSerializer();//Инициализация
            string jsonResult = serializer.Serialize(t);

            var listOfTinkoffPaymant = ParseResponse<string[]>(jsonResult);
        }



        public static T ParseResponse<T>(string data)
        {
            return new JavaScriptSerializer().Deserialize<T>(data);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Task<int> task1 = new Task<int>(() => Task_1());

            // задача продолжения
            Task task2 = task1.ContinueWith((t) => 
            {
                if (t.IsFaulted)
                    MessageBox.Show(t.Exception.InnerException.Message.ToString());
                else
                    Task_2(t.Result);
            });

            Task task3 = task2.ContinueWith((t) =>
            {
                if (t.IsFaulted)
                   MessageBox.Show("Error = " + t.Exception.InnerException.Message.ToString());
                else
                   Task_3();
            });

            task1.Start();
            //MessageBox.Show("Всё!");
        }

        private int Task_1()
        {
            try
            {
                ss.Items.Clear();
                ss.Items.Insert(0, new ToolStripLabel() { Text = "Task_1" });
                Thread.Sleep(3000);
                int i = 0;
                int ii = 1 / i;
                return 11;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Task_2(int t)
        {
            ss.Items.Clear();
            ss.Items.Insert(0, new ToolStripLabel() { Text = "Task_2_" + t.ToString() });
            Thread.Sleep(3000);
        }

        private void Task_3()
        {
            ss.Items.Clear();
            ss.Items.Insert(0, new ToolStripLabel() { Text = "Task_3_" });
            Thread.Sleep(3000);
        }

    }
}

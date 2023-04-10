using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prime_fibo
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			resultTxt.Enabled = false;
		}

		private void isPrimBtn_Click(object sender, EventArgs e)
		{
			int num;
			if (Int32.TryParse(numberTxt.Text, out num))
			{
				resultTxt.Text = IsPrime(num);
			}
			else
			{
				resultTxt.Text = "invalid number";
			}
		}

		static String IsPrime(int num)
		{
			if(num == 1 || num == 2)
				return "prime";
			for (int i = 2; i < Math.Sqrt(num); i++)
				if (num % i == 0)
					return "not prime";
			return "prim";
		}

		static int fibo(int num)
		{
			if (num == 0) return 0;

			int now = 0;
			int next = 1;
			for (int i = 1; i < num; i++)
			{
				int sum = now + next;
				now = next;
				next = sum;
			}
			return next;
		}

		private void fiboBtn_Click(object sender, EventArgs e)
		{
			int num;
			if (Int32.TryParse(numberTxt.Text, out num))
			{
				resultTxt.Text = Convert.ToString(fibo(num));
			}
			else
			{
				resultTxt.Text = "invalid number";
			}
		}

		private void clearBtn_Click(object sender, EventArgs e)
		{
			resultTxt.Text = "";
			//resultTxt.Clear();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int num;
			if (Int32.TryParse(numberTxt.Text, out num))
			{
				int fac = 1;
				for (int i = 2; i <= num; i++) {
					fac *= i;
				}
				resultTxt.Text = Convert.ToString(fac);
			}
			else
			{
				resultTxt.Text = "invalid number";
			}
		}

		
	}
}

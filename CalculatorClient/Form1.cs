using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CalculatorClient.CalculatorService;

namespace CalculatorClient
{
   public partial class Form1 : Form
   {
      private CalculatorClient.CalculatorService.CalculatorSessionClient _calcService = null;

      public Form1()
      {
         InitializeComponent();
      }

      private double GetInputValue()
      {
         double value;
         if (Double.TryParse(txtInput.Text, out value))
         {
            return value;
         }
         throw new Exception("Enter a number ...");
      }

      private void btnClear_Click(object sender, EventArgs e)
      {
         _calcService = new CalculatorSessionClient();
         _calcService.Clear();
      }

      private void btnPlus_Click(object sender, EventArgs e)
      {
         Wrapper(() => _calcService.AddTo(GetInputValue()));
      }

      private void Wrapper(Action someAction)
      {
         try
         {
            someAction.Invoke();
         }
         catch (Exception ex)
         {
            MessageBox.Show(String.Format("Error : {0}", ex.Message));
         }
      }

      private void btnMinus_Click(object sender, EventArgs e)
      {
         Wrapper(() => _calcService.SubtractFrom(GetInputValue()));
      }

      private void btnTimes_Click(object sender, EventArgs e)
      {
         Wrapper(() => _calcService.MultiplyBy(GetInputValue()));
      }

      private void btnDivide_Click(object sender, EventArgs e)
      {
         Wrapper(() => _calcService.DivideBy(GetInputValue()));
      }

      private void btnEquals_Click(object sender, EventArgs e)
      {
         Wrapper(() => lblAnswer.Text = _calcService.Equals().ToString());
      }
   }
}

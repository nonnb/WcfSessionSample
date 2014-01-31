using System.Diagnostics;
using System.ServiceModel;

namespace WcfLibrary1
{
   public class StackOverFlowStatefulCalculator : ICalculatorSession
   {
      private double _theCurrentValueOfTheCalculator;

      public StackOverFlowStatefulCalculator()
      {
         Debug.WriteLine("New Calculator Instance Started!");
      }

      public void Clear()
      {
         _theCurrentValueOfTheCalculator = 0;
         Debug.WriteLine(string.Format("Calculator Cleared. SessionId {0}", OperationContext.Current.SessionId));
      }

      public void AddTo(double n)
      {
         _theCurrentValueOfTheCalculator += n;
         Debug.WriteLine(string.Format("Added {0}. Total Now {1}. SessionId {2}", n, _theCurrentValueOfTheCalculator, OperationContext.Current.SessionId));
      }

      public void SubtractFrom(double n)
      {
         _theCurrentValueOfTheCalculator -= n;
         Debug.WriteLine(string.Format("Subtracted {0}. Total Now {1}. SessionId {2}", n, _theCurrentValueOfTheCalculator, OperationContext.Current.SessionId));
      }

      public void MultiplyBy(double n)
      {
         _theCurrentValueOfTheCalculator *= n;
         Debug.WriteLine(string.Format("Multipled by  {0}. Total Now {1}. SessionId {2}", n, _theCurrentValueOfTheCalculator, OperationContext.Current.SessionId));
      }

      public void DivideBy(double n)
      {
         // Contract.Assert(n != 0) Div Zero time
         _theCurrentValueOfTheCalculator /= n;
         Debug.WriteLine(string.Format("Divided by  {0}. Total Now {1}. SessionId {2}", n, _theCurrentValueOfTheCalculator, OperationContext.Current.SessionId));
      }

      public double Equals()
      {
         Debug.WriteLine(string.Format("Returned the final value of {0}. SessionId {1}", _theCurrentValueOfTheCalculator, OperationContext.Current.SessionId));
         return _theCurrentValueOfTheCalculator;
      }
   }
}

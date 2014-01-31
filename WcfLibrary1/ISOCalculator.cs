using System.ServiceModel;

namespace WcfLibrary1
{
   [ServiceContract(Namespace = "http://Microsoft.ServiceModel.Samples", SessionMode = SessionMode.Required)]
   public interface ICalculatorSession
   {
      [OperationContract(IsOneWay = true, IsInitiating = true, IsTerminating = false)]
      void Clear();
      [OperationContract(IsOneWay = true, IsInitiating = false, IsTerminating = false)]
      void AddTo(double n);
      [OperationContract(IsOneWay = true, IsInitiating = false, IsTerminating = false)]
      void SubtractFrom(double n);
      [OperationContract(IsOneWay = true, IsInitiating = false, IsTerminating = false)]
      void MultiplyBy(double n);
      [OperationContract(IsOneWay = true, IsInitiating = false, IsTerminating = false)]
      void DivideBy(double n);
      [OperationContract(IsInitiating = false, IsTerminating = true)]
      double Equals();
   }
}

// https://github.com/rachied/nunit-on-wasm
using System.Reflection;
using NUnit;
using NUnit.Framework.Api;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;

namespace NUnitOnWasm.TestRunner;

public class AssemblyTestListener : TestFilter, ITestListener
{
    private readonly Assembly _asm;

    public ITestResult? Result { get; set; }

    public AssemblyTestListener(Assembly asm)
    {
        _asm = asm;
    }

    public void Run()
    {
        Console.WriteLine("Starting tests");
        Console.WriteLine();

        var builder = new DefaultTestAssemblyBuilder();
        var runner = new NUnitTestAssemblyRunner(builder);

        runner.Load(_asm, new Dictionary<string, object>()
        {
            //https://github.com/nunit/nunit/issues/2922
            [FrameworkPackageSettings.NumberOfTestWorkers] = 0,
            [FrameworkPackageSettings.SynchronousEvents] = true,
            [FrameworkPackageSettings.RunOnMainThread] = true
        });
        runner.Run(this, this);
        Console.WriteLine();
        Console.WriteLine("Test run finished");
    }
    #region ITestListener
    public void TestStarted(ITest test) => Console.WriteLine("Running " + test.FullName);
    public void TestFinished(ITestResult result)
    {
        var symbol = result.FailCount > 0 ? "✖" : result.PassCount > 0 ? "✔" : "❓";
        Console.WriteLine($"\t{symbol}{result.PassCount} passed, {result.FailCount} failed, {result.SkipCount} skipped");
        Result = result;
    }
    public void TestOutput(TestOutput output) => Console.WriteLine("\t🖶" + output.Text);

    public void SendMessage(TestMessage message) => Console.WriteLine("\t🛈" + message.Message);
    #endregion

    #region TestFilter 
    //See NUnit.Framework.Internal.TestFilter+EmptyFilter
    public override bool Match(ITest test) => true;
    public override TNode AddToXml(TNode parentNode, bool recursive) => parentNode.AddElement("filter");
    public override bool Pass(ITest test) => true;
    public override bool IsExplicitMatch(ITest test) => false;
    #endregion
}
using System;
using NUnit.Framework;
using ProtoCore.DSASM.Mirror;
namespace ProtoTest
{
    [TestFixture]
    class MultiLanugageBasic : ProtoTestBase
    {
        [Test]
        public void TestSingleLanguageImperative()
        {
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            fsr.Execute(
@"
        }
        [Test]
        public void TestSingleLanguageAssociative()
        {
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            fsr.Execute(
@"
        }
        [Test]
        public void TestMultLanguageAssociativeImperative()
        {
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            fsr.Execute(
@"
        }
        [Test]
        public void TestMultLanguageImperativeAssociative()
        {
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            fsr.Execute(
@"
        }
        [Test]
        public void TestMultLanguageVariableUsage()
        {
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();

            fsr.Execute(
@"
        }
        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestClassUsageInImpeartive()
        {
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            ExecutionMirror mirror = fsr.Execute(
@"
import(""FFITarget.dll"");
    , core, out runtimeCore);
            Assert.IsTrue((Int64)mirror.GetValue("x", 0).Payload == 16);
            Assert.IsTrue((Int64)mirror.GetValue("y", 0).Payload == 32);
        }
    }
}
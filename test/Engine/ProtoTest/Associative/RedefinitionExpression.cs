using System;
using NUnit.Framework;
using ProtoCore.DSASM.Mirror;
using ProtoTest.TD;
using ProtoTestFx.TD;
namespace ProtoTest.Associative
{
    class RedefinitionExpression : ProtoTestBase
    {
        [Test]
        public void RedefineWithFunctions01()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            ExecutionMirror mirror = fsr.Execute(code, core, out runtimeCore);
            Assert.IsTrue((Int64)mirror.GetValue("x").Payload == 1001);
        }

        [Test]
        [Category("DSDefinedClass_Ported")]
        public void RedefineWithConstructor()
        {
            String code =
@"
import(""FFITarget.dll"");
            thisTest.RunScriptSource(code);
            thisTest.Verify("x", 11);
        }

        [Test]
        [Category("DSDefinedClass_Ignored")]
        public void RedefineWithFunctions03()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            ExecutionMirror mirror = fsr.Execute(code, core, out runtimeCore);
            Assert.IsTrue((Int64)mirror.GetValue("x").Payload == 11);
        }
        //TestCase from Mark//

        [Test]
        public void RedefineWithFunctions04()
        {
            String code =
@"def f1(i : int, k : int)
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            ExecutionMirror mirror = fsr.Execute(code, core, out runtimeCore);
            Assert.IsTrue((Int64)mirror.GetValue("x").Payload == 20);
        }

        [Test]
        public void RedefineWithFunctions05()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            ExecutionMirror mirror = fsr.Execute(code, core, out runtimeCore);
            Assert.IsTrue((Int64)mirror.GetValue("x").Payload == 36);
        }

        [Test]
        public void RedefineWithExpressionLists01()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            ExecutionMirror mirror = fsr.Execute(code, core, out runtimeCore);
            Assert.IsTrue((Int64)mirror.GetValue("x").Payload == 1);
            Assert.IsTrue((Int64)mirror.GetValue("y").Payload == 2);
        }

        [Test]
        public void RedefineWithExpressionLists02()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            ExecutionMirror mirror = fsr.Execute(code, core, out runtimeCore);
            Assert.IsTrue((Int64)mirror.GetValue("x").Payload == 1);
            Assert.IsTrue((Int64)mirror.GetValue("y").Payload == 2);
        }
        //Mark TestCases//

        [Test]
        [Category("ToFixJun")]
        public void RedefineWithExpressionLists03()
        {
            String code =
@"
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            ExecutionMirror mirror = fsr.Execute(code, core, out runtimeCore);
            Assert.IsTrue((Int64)mirror.GetValue("x").Payload == 7);
            Assert.IsTrue((Int64)mirror.GetValue("y").Payload == 3);
        }

        [Test]
        [Category("DSDefinedClass")]
        public void RedefineWithExpressionLists04()
        {
            String code =
@"
import(""FFITarget.dll"");
            thisTest.RunScriptSource(code);
            thisTest.Verify("a", new object[] {1.0, 2.0, 3.0});
        }
    }
}
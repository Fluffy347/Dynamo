using System;
using System.Collections.Generic;
using System.IO;
using NUnit.Framework;
using ProtoCore.DSASM.Mirror;
using ProtoCore.Lang;
using ProtoTest.TD;
using ProtoTestFx.TD;
namespace ProtoTest.Associative
{
    class ReferenceCount : ProtoTestBase
    {
        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount01_NoFunctionCall_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
        }


        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount02_FunctionNonArray_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
        }


        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount03_FunctionReplication_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
        }


        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount04_FunctionArray_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
        }


        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount05_StaticFunctionNonArray_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
        }


        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount06_StaticFunctionReplication_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
        }


        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount07_StaticFunctionArray_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
        }



        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount08_MemFunctionNonArray_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
        }



        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount09_MemFunctionReplication_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
        }



        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount10_MemFunctionArray_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
        }


        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount11_ReplicationNonArray_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
        }


        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount12_ReplicationReplication_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
        }


        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount13_ReplicationArray_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
        }



        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount14_GlobalFunctionTwoArguments_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
        }



        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount15_GlobalFunctionTwoArguments_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
        }



        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount16_GlobalFunctionTwoArguments_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
        }


        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount17_StaticFunctionTwoArguments_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
        }



        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount18_StaticFunctionTwoArguments_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
        }


        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount19_StaticFunctionTwoArguments_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
        }


        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount20_MemberFunctionTwoArguments_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
            thisTest.Verify("cDispose", 0);
        }



        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount21_MemberFunctionTwoArguments_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
            thisTest.Verify("cDispose", 0);
        }


        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount22_MemberFunctionTwoArguments_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
            thisTest.Verify("cDispose", 0);
        }



        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount23_MemberFunctionTwoArguments_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
            thisTest.Verify("cDispose", 0);
        }



        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount24_MemberFunctionTwoArguments_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
            thisTest.Verify("cDispose", 0);
        }


        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount25_MemberFunctionTwoArguments_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
            thisTest.Verify("cDispose", 0);
        }



        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount26_GlobalFunctionReturnArray_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
            thisTest.Verify("cDispose", 0);
        }



        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount27_GlobalFunctionReturnArray_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
            thisTest.Verify("cDispose", 0);
        }



        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount28_GlobalFunctionReturnArray_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
            thisTest.Verify("cDispose", 0);
        }



        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount29_MemberFunctionReturnArray_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
            thisTest.Verify("cDispose", 0);
        }



        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount30_MemberFunctionReturnArray_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
            thisTest.Verify("cDispose", 0);
        }



        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount31_MemberFunctionReturnArray_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
            thisTest.Verify("cDispose", 0);
        }



        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount32_StaticFunctionReturnArray_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
            thisTest.Verify("cDispose", 0);
        }



        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount33_StaticFunctionReturnArray_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
            thisTest.Verify("cDispose", 0);
        }



        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount34_StaticFunctionReturnArray_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
            thisTest.Verify("cDispose", 0);
        }



        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount35_StaticFunctionReturnObject_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
            thisTest.Verify("cDispose", 0);
        }



        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount36_StaticFunctionReturnObject_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
            thisTest.Verify("cDispose", 0);
        }



        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount37_MemberFunctionReturnObject_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
            thisTest.Verify("cDispose", 0);
        }


        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount38_MemberFunctionReturnObject_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
            thisTest.Verify("cDispose", 0);
        }



        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount39_GlobalFunctionReturnObject_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
            thisTest.Verify("cDispose", 0);
        }



        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount40_GlobalFunctionReturnObject_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
            thisTest.Verify("cDispose", 0);
        }



        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount41_MemberFunctionReturnArray_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
            thisTest.Verify("cDispose", 0);
        }



        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount42_MemberFunctionReturnArray_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
            thisTest.Verify("cDispose", 0);
        }


        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount43_MemberFunctionReturnArray_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
            thisTest.Verify("cDispose", 0);
        }



        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount44_MemberFunctionReturnObject_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
            thisTest.Verify("cDispose", 0);
        }



        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount45_MemberFunctionReturnObject_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
            thisTest.Verify("cDispose", 0);
        }



        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount46_GlobalFunctionReturnNewArray_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
            thisTest.Verify("cDispose", 0);
        }


        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount47_GlobalFunctionReturnNewArray_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
            thisTest.Verify("cDispose", 0);
        }



        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount48_GlobalFunctionReturnNewArray_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
            thisTest.Verify("cDispose", 0);
        }


        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount49_MemberFunctionReturnNewArray_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
            thisTest.Verify("cDispose", 0);
        }



        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount50_MemberFunctionReturnNewArray_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
            thisTest.Verify("cDispose", 0);
        }


        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount51_MemberFunctionReturnNewArray_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
            thisTest.Verify("cDispose", 0);
        }



        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount52_StaticFunctionReturnNewArray_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
            thisTest.Verify("cDispose", 0);
        }



        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount53_StaticFunctionReturnNewArray_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
            thisTest.Verify("cDispose", 0);
        }



        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount54_StaticFunctionReturnNewArray_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
            thisTest.Verify("cDispose", 0);
        }



        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount55_StaticFunctionReturnNewObject_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
            thisTest.Verify("cDispose", 0);
        }



        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount56_StaticFunctionReturnNewObject_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
            thisTest.Verify("cDispose", 0);
        }



        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount57_MemberFunctionReturnNewObject_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
            thisTest.Verify("cDispose", 0);
        }



        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount58_MemberFunctionReturnNewObject_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
            thisTest.Verify("cDispose", 0);
        }


        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount59_GlobalFunctionReturnNewObject_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
            thisTest.Verify("cDispose", 0);
        }



        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount60_GlobalFunctionReturnNewObject_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
            thisTest.Verify("cDispose", 0);
        }



        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount61_MemberFunctionReturnNewArray_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
            thisTest.Verify("cDispose", 0);
        }



        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount62_MemberFunctionReturnNewArray_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
            thisTest.Verify("cDispose", 0);
        }



        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount63_MemberFunctionReturnNewArray_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
            thisTest.Verify("cDispose", 0);
        }


        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount64_MemberFunctionReturnNewObject_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
            thisTest.Verify("cDispose", 0);
        }


        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount65_MemberFunctionReturnNewObject_Dispose()
        {
            string code =
                @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            thisTest.Verify("aDispose", 0);
            thisTest.Verify("bDispose", 0);
            thisTest.Verify("cDispose", 0);
        }

        [Test]
        [Category("DSDefinedClass_Ignore_DisposeWithinDSClass")]
        public void TestReferenceCount66_DID1467277()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            // SSA'd transforms will not GC the temps until end of block
            // However, they must be GC's after every line when in debug step over
            thisTest.Verify("t", 0);
        }

        [Test]
        [Category("DSDefinedClass_Ignored_Redundant")]
        public void TestReferenceCount67_DID1467277_02()
        {
            string code = @"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            // SSA'd transforms will not GC the temps until end of block
            // However, they must be GC's after every line when in debug setp over
            thisTest.Verify("t", 0);
        }

        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount68_TemporaryArrayIndexing01()
        {
            string code = @"
            string errorString = "";
            thisTest.RunScriptSource(code, errorString);
            thisTest.Verify("d", 3);
        }

        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount69_TemporaryArrayIndexing02()
        {
            string code = @"
";
            string errorString = "";
            thisTest.RunScriptSource(code, errorString);
            thisTest.Verify("d", 3);
        }

        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount70_TemporaryArrayIndexing03()
        {
            string code = @"
d = DisposeTestClassD.count;
";
            string errorString = "";
            thisTest.RunScriptSource(code, errorString);
            thisTest.Verify("d", 2);
        }

        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount71_TemporaryArrayIndexing04()
        {
            string code = @"
d = DisposeTestClassD.count;
";
            string errorString = "";
            thisTest.RunScriptSource(code, errorString);
            thisTest.Verify("d", 4);
        }

        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount72_TemporaryDefaultArgument()
        {
            string code = @"
d = DisposeTestClassD.count;
";
            string errorString = "";
            thisTest.RunScriptSource(code, errorString);
            thisTest.Verify("d", 1);
        }

        [Test]
        [Category("DSDefinedClass_Ported")]
        public void TestReferenceCount73_FunctionPointer()
        {
            string code = @"
            string errorString = "";
            thisTest.RunScriptSource(code, errorString);
            thisTest.Verify("d", 1);
        }

        [Test]
        [Category("DSDefinedClass_Ignored_Redundant")]
        public void T074_DG1465049()
        {
            string code = @"
            thisTest.RunScriptSource(code);

            // IT gc's the line where it calls translate when variable as is nullified
            // It disposes 3 ssa temporaries and 1 element in the array 'as'
            thisTest.Verify("d", 4);
        }

        [Test]
        [Category("DSDefinedClass_Ignored_Redundant")]
        public void TestReferenceCountForMembers()
        {
            string code = @"
            thisTest.RunScriptSource(code, "");
            thisTest.Verify("a_dispose", 1);
        }

        [Test]
        [Category("DSDefinedClass_Ignored_Redundant")]
        public void TestReferenceCountForStaticMembers()
        {
            string code = @"
            thisTest.RunScriptSource(code, "");
            thisTest.Verify("a_dispose", 1);
        }

        [Test]
        [Category("DSDefinedClass_Ignored_Redundant")]
        public void TestReferenceCountForStaticMembers2()
        {
            string code = @"
            thisTest.RunScriptSource(code, "");
            thisTest.Verify("a_dispose", 2);
        }
    }
}
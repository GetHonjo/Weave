// -----------------------------------------------------------------------
// <auto-generated>
//   This code was generated by Weave 1.2.0.0
//
//   Changes to this file may cause incorrect behavior and will be lost if
//   the code is regenerated.
// </auto-generated>
// -----------------------------------------------------------------------

namespace
    #line 1 "_config.weave"
           Weave.Compiler
    #line default
{
    using System;
    using System.IO;
    using
        #line 2 "_config.weave"
       Weave.Expressions
        #line default
        ;

    partial class
    Templates
    {
        [System.CodeDom.Compiler.GeneratedCode("Weave", "1.2.0.0")]
        public
        void
        RenderNewLineElement
            (
            #line 1 "NewLineElement.weave"
       NewLineElement
            #line default
            model, TextWriter writer, string indentation = null)
        {
            var __encode = new Func<object, string>(
                #line 4 "_config.weave"
        ToLiteral
                #line default
                );
            var __originalIndentation = indentation = indentation ?? string.Empty;
            writer.Write(indentation);
            writer.Write("writer.WriteLine();");
            writer.WriteLine();
        }
    }
}

// -----------------------------------------------------------------------
// <auto-generated>
//   This code was generated by Weave 1.0.0.0
//
//   Changes to this file may cause incorrect behavior and will be lost if
//   the code is regenerated.
// </auto-generated>
// -----------------------------------------------------------------------

namespace 
#line 1 "RenderElement.weave"
           Weave.Compiler
#line default


{
    using System.IO;
    using 
    #line 4 "RenderElement.weave"
       Weave.Expressions
    #line default

;

        
 partial class     Templates

    {
        [System.CodeDom.Compiler.GeneratedCode("Weave", "1.0.0.0")]
        public void 
        #line 2 "RenderElement.weave"
            RenderRenderElement
        #line default

(
        #line 3 "RenderElement.weave"
       RenderElement
        #line default

 model, TextWriter writer, string indentation = null)
        {
            var originalIndentation = indentation = indentation ?? string.Empty;
            var temp0 = indentation;

            #line 6 "RenderElement.weave"
   var newModel = this.CreateVariable("model"); 
            #line default

            indentation = temp0;
            writer.Write(indentation);
            writer.Write("var ");
            writer.Write(
            #line 7 "RenderElement.weave"
        newModel 
            #line default

);
            writer.Write(" = ");
            var model0 = 
            #line 7 "RenderElement.weave"
                                    model.Expression
            #line default

;
            
            #line 7 "RenderElement.weave"
                         RenderCode
            #line default

(model0, writer, indentation);
            writer.Write(";");
            writer.WriteLine();
            indentation = originalIndentation;
            writer.Write(indentation);
            var model1 = 
            #line 8 "RenderElement.weave"
              model.Method
            #line default

;
            
            #line 8 "RenderElement.weave"
   RenderCode
            #line default

(model1, writer, indentation);
            writer.Write("(");
            writer.Write(
            #line 8 "RenderElement.weave"
                                 newModel 
            #line default

);
            writer.Write(", writer, indentation);");
            writer.WriteLine();
        }
    }
}
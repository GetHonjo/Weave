
// -----------------------------------------------------------------------
// <auto-generated>
//   This code was generated by Weave 1.0.0.0
//
//   Changes to this file may cause incorrect behavior and will be lost if
//   the code is regenerated.
// </auto-generated>
// -----------------------------------------------------------------------

namespace 


#line 1 "TextElement.weave"
           Weave.Compiler
#line default


{
    using System.IO;
    
        using 


#line 4 "TextElement.weave"
       Weave.Expressions
#line default

;
    

    

    
 partial class 

    Templates

    {
        [System.CodeDom.Compiler.GeneratedCode("Weave", "1.0.0.0")]
        public void 


#line 2 "TextElement.weave"
            RenderTextElement
#line default

(


#line 3 "TextElement.weave"
       TextElement
#line default

 model, TextWriter writer)
        {
            writer.Write("writer.Write(");
writer.Write(


#line 6 "TextElement.weave"
                 ToLiteral(model.Value) 
#line default

);
writer.Write(");\r\n");

        }
    }
}
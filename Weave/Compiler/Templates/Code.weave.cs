
// -----------------------------------------------------------------------
// <auto-generated>
//   This code was generated by Weave 1.0.0.0
//
//   Changes to this file may cause incorrect behavior and will be lost if
//   the code is regenerated.
// </auto-generated>
// -----------------------------------------------------------------------

namespace 


#line 1 "Code.weave"
           Weave.Compiler
#line default


{
    using System.IO;
    
        using 


#line 4 "Code.weave"
       Weave.Expressions
#line default

;
    

    

    
 partial class 

    Templates

    {
        [System.CodeDom.Compiler.GeneratedCode("Weave", "1.0.0.0")]
        public void 


#line 2 "Code.weave"
            RenderCode
#line default

(


#line 3 "Code.weave"
       object
#line default

 model, TextWriter writer)
        {
            


#line 6 "Code.weave"
   var span = model as SourceSpan; 
#line default

writer.Write("\r\n");


    
    
    if (


#line 7 "Code.weave"
     span != null
#line default

)

{
    writer.Write("\r\n\r\n#line ");
writer.Write(


#line 9 "Code.weave"
          span.Start.Line 
#line default

);
writer.Write(" \"");
writer.Write(


#line 9 "Code.weave"
                                  Path.GetFileName(span.Start.FileName) 
#line default

);
writer.Write("\"\r\n");
writer.Write(


#line 10 "Code.weave"
    new string(' ', span.Start.Column - 1) 
#line default

);
writer.Write(


#line 10 "Code.weave"
                                                 span.Value 
#line default

);
writer.Write("\r\n#line default\r\n\r\n");

}
    

    
        else
    
    
{
    writer.Write("\r\n    ");
writer.Write(


#line 14 "Code.weave"
        model 
#line default

);
writer.Write("\r\n");

}
    

        }
    }
}
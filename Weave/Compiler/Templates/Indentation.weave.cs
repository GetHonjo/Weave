// -----------------------------------------------------------------------
// <auto-generated>
//   This code was generated by Weave 1.0.0.0
//
//   Changes to this file may cause incorrect behavior and will be lost if
//   the code is regenerated.
// </auto-generated>
// -----------------------------------------------------------------------

namespace 
#line 1 "Indentation.weave"
           Weave.Compiler
#line default


{
    using System.IO;
    using 
    #line 4 "Indentation.weave"
       Weave.Expressions
    #line default

;

        
 partial class     Templates

    {
        [System.CodeDom.Compiler.GeneratedCode("Weave", "1.0.0.0")]
        public void 
        #line 2 "Indentation.weave"
            UpdateIndentation
        #line default

(
        #line 3 "Indentation.weave"
       Element
        #line default

 model, TextWriter writer, string indentation = null)
        {
            var originalIndentation = indentation = indentation ?? string.Empty;
            indentation = originalIndentation;
            var temp0 = indentation;

            #line 6 "Indentation.weave"
  
    string indent;
    this.indentation.TryGetValue(model, out indent);

            #line default

            indentation = temp0;
            if (

                #line 10 "Indentation.weave"
     indent != null
                #line default

                )
            {
                indentation = originalIndentation;
                writer.Write(indentation);
                writer.Write("indentation = originalIndentation");
                if (

                    #line 11 "Indentation.weave"
                                          indent.Length > 0
                    #line default

                    )
                {
                    writer.Write(" + ");
                    writer.Write(
                    #line 11 "Indentation.weave"
                                                                    ToLiteral(indent) 
                    #line default

);
                }
                writer.Write(";");
                writer.WriteLine();
            }
        }
    }
}

// -----------------------------------------------------------------------
// <auto-generated>
//   This code was generated by Weave 1.0.0.0
//
//   Changes to this file may cause incorrect behavior and will be lost if
//   the code is regenerated.
// </auto-generated>
// -----------------------------------------------------------------------

namespace 


#line 1 "Branch.weave"
           Weave.Compiler
#line default


{
    using System.IO;
    
        using 


#line 4 "Branch.weave"
       Weave.Expressions
#line default

;
    

    

    
 partial class 

    Templates

    {
        [System.CodeDom.Compiler.GeneratedCode("Weave", "1.0.0.0")]
        public void 


#line 2 "Branch.weave"
            RenderBranch
#line default

(


#line 3 "Branch.weave"
       Branch
#line default

 model, TextWriter writer)
        {
            

    
    
    if (


#line 6 "Branch.weave"
     model.Expression != null
#line default

)

{
    writer.Write("\r\n    if (");



#line 7 "Branch.weave"
           this.RenderCode(model.Expression, writer); 
#line default

writer.Write(")\r\n");

}
    
writer.Write("\r\n{\r\n    ");



#line 10 "Branch.weave"
       this.WalkElements(model.Body); 
#line default

writer.Write("\r\n}");

        }
    }
}
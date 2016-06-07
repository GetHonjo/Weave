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
        #line 2 "Template.weave"
       System.Linq
        #line default
        ;
    using
        #line 3 "Template.weave"
       System.Reflection
        #line default
        ;
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
        RenderTemplate
            (
            #line 1 "Template.weave"
       Template
            #line default
            model, TextWriter writer, string indentation = null)
        {
            var __encode = new Func<object, string>(
                #line 4 "_config.weave"
        ToLiteral
                #line default
                );
            var __originalIndentation = indentation = indentation ?? string.Empty;
            var __temp0 = indentation;
            #line 5 "Template.weave"
  
    var settings = model.AllSettings.ToLookup(s => s.Key.Value, s => (object)s.Value);
    var accessibility = settings["accessibility"].FirstOrDefault() ?? "public";
    var className = settings["classname"].FirstOrDefault() ?? "Templates";
    var encode = settings["encode"].FirstOrDefault();
    var methodName = settings["methodname"].FirstOrDefault() ?? "Render" + Path.GetFileNameWithoutExtension(model.Start.FileName);
    var modelName = settings["model"].FirstOrDefault() ?? "dynamic";
    var @namespace = settings["namespace"].First();
    var @static = bool.Parse(settings["static"].Select(v => ((SourceSpan)v).Value).FirstOrDefault() ?? "true");
    var assemblyName = Assembly.GetExecutingAssembly().GetName();

    this.indentationBase = "__originalIndentation";

            #line default
            indentation = __temp0;
            writer.Write(indentation);
            writer.Write("// -----------------------------------------------------------------------");
            writer.WriteLine();
            writer.Write(indentation);
            writer.Write("// <auto-generated>");
            writer.WriteLine();
            writer.Write(indentation);
            writer.Write("//   This code was generated by ");
            writer.Write(
                #line 20 "Template.weave"
                                    assemblyName.Name 
                #line default
                );
            writer.Write(" ");
            writer.Write(
                #line 20 "Template.weave"
                                                             assemblyName.Version 
                #line default
                );
            writer.WriteLine();
            writer.Write(indentation);
            writer.Write("//");
            writer.WriteLine();
            writer.Write(indentation);
            writer.Write("//   Changes to this file may cause incorrect behavior and will be lost if");
            writer.WriteLine();
            writer.Write(indentation);
            writer.Write("//   the code is regenerated.");
            writer.WriteLine();
            writer.Write(indentation);
            writer.Write("// </auto-generated>");
            writer.WriteLine();
            writer.Write(indentation);
            writer.Write("// -----------------------------------------------------------------------");
            writer.WriteLine();
            writer.WriteLine();
            writer.Write(indentation);
            writer.Write("namespace");
            writer.WriteLine();
            indentation = __originalIndentation + "    ";
            var __model0 =
                #line 28 "Template.weave"
                  @namespace
                #line default
                ;
            RenderCode(__model0, writer, indentation);
            indentation = __originalIndentation;
            writer.Write(indentation);
            writer.Write("{");
            writer.WriteLine();
            indentation = __originalIndentation + "    ";
            writer.Write(indentation);
            writer.Write("using System;");
            writer.WriteLine();
            writer.Write(indentation);
            writer.Write("using System.IO;");
            writer.WriteLine();
            foreach (var
                #line 32 "Template.weave"
           @using in settings["using"]
                #line default
                )
            {
                indentation = __originalIndentation + "    ";
                writer.Write(indentation);
                writer.Write("using");
                writer.WriteLine();
                indentation = __originalIndentation + "        ";
                var __model1 =
                    #line 34 "Template.weave"
                          @using
                    #line default
                    ;
                RenderCode(__model1, writer, indentation);
                writer.Write(indentation);
                writer.Write(";");
                writer.WriteLine();
            }

            writer.WriteLine();
            indentation = __originalIndentation + "    ";
            writer.Write(indentation);
            writer.Write("partial class");
            writer.WriteLine();
            var __model2 =
                #line 39 "Template.weave"
                  className
                #line default
                ;
            RenderCode(__model2, writer, indentation);
            writer.Write(indentation);
            writer.Write("{");
            writer.WriteLine();
            indentation = __originalIndentation + "        ";
            writer.Write(indentation);
            writer.Write("[System.CodeDom.Compiler.GeneratedCode(\"");
            writer.Write(
                #line 41 "Template.weave"
                                                    assemblyName.Name 
                #line default
                );
            writer.Write("\", \"");
            writer.Write(
                #line 41 "Template.weave"
                                                                                assemblyName.Version 
                #line default
                );
            writer.Write("\")]");
            writer.WriteLine();
            var __model3 =
                #line 42 "Template.weave"
                      accessibility
                #line default
                ;
            RenderCode(__model3, writer, indentation);
            writer.Write(indentation);
            if (
                #line 43 "Template.weave"
             @static
                #line default
                )
            {
                writer.Write("static ");
            }
            writer.Write("void");
            writer.WriteLine();
            var __model4 =
                #line 44 "Template.weave"
                      methodName
                #line default
                ;
            RenderCode(__model4, writer, indentation);
            indentation = __originalIndentation + "            ";
            writer.Write(indentation);
            writer.Write("(");
            writer.WriteLine();
            var __model5 =
                #line 46 "Template.weave"
                          modelName
                #line default
                ;
            RenderCode(__model5, writer, indentation);
            writer.Write(indentation);
            writer.Write("model, TextWriter writer, string indentation = null)");
            writer.WriteLine();
            indentation = __originalIndentation + "        ";
            writer.Write(indentation);
            writer.Write("{");
            writer.WriteLine();
            if (
                #line 49 "Template.weave"
                 encode != null
                #line default
                )
            {
                indentation = __originalIndentation + "            ";
                writer.Write(indentation);
                writer.Write("var __encode = new Func<object, string>(");
                writer.WriteLine();
                indentation = __originalIndentation + "                ";
                var __model6 =
                    #line 51 "Template.weave"
                                  encode
                    #line default
                    ;
                RenderCode(__model6, writer, indentation);
                writer.Write(indentation);
                writer.Write(");");
                writer.WriteLine();
            }
            indentation = __originalIndentation + "            ";
            writer.Write(indentation);
            writer.Write("var ");
            writer.Write(
                #line 54 "Template.weave"
                    this.indentationBase 
                #line default
                );
            writer.Write(" = indentation = indentation ?? string.Empty;");
            writer.WriteLine();
            var __model7 =
                #line 55 "Template.weave"
                                model
                #line default
                ;
            BaseWalkTemplate(__model7, writer, indentation);
            indentation = __originalIndentation + "        ";
            writer.Write(indentation);
            writer.Write("}");
            writer.WriteLine();
            indentation = __originalIndentation + "    ";
            writer.Write(indentation);
            writer.Write("}");
            writer.WriteLine();
            indentation = __originalIndentation;
            writer.Write(indentation);
            writer.Write("}");
            writer.WriteLine();
        }
    }
}

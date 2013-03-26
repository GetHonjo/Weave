﻿// -----------------------------------------------------------------------
// <copyright file="IndentationAnalyzer.cs" company="(none)">
//   Copyright © 2013 John Gietzen.  All Rights Reserved.
//   This source is subject to the MIT license.
//   Please see license.txt for more information.
// </copyright>
// -----------------------------------------------------------------------

namespace Weave.Compiler
{
    using System.Collections.Generic;
    using System.Linq;
    using Weave.Expressions;

    /// <summary>
    /// Computes indentation for all nodes in a <see cref="Template"/>.
    /// </summary>
    public static class IndentationAnalyzer
    {
        /// <summary>
        /// Analyzes a <see cref="Template"/>'s indentation.
        /// </summary>
        /// <param name="template">The <see cref="Template"/> to analyze.</param>
        /// <returns>The indentation for the entire <see cref="Template"/>.</returns>
        public static Dictionary<Element, string> Analyze(Template template)
        {
            var walker = new MeasureIndentationWalker();
            walker.WalkTemplate(template);
            return walker.Results;
        }

        private class MeasureIndentationWalker : TemplateWalker
        {
            private Dictionary<Element, string> results = new Dictionary<Element, string>();
            private int amountToSubtract = 0;

            public Dictionary<Element, string> Results
            {
                get { return this.results; }
            }

            public override void WalkBranch(Branch branch)
            {
                var amount = GetIndentationOffset(branch.Indentation, branch.Body);
                this.amountToSubtract += amount;
                base.WalkBranch(branch);
                this.amountToSubtract -= amount;
            }

            public override void WalkCodeElement(CodeElement codeElement)
            {
                this.results[codeElement] = this.ComputeIndentation(codeElement.Indentation);
            }

            public override void WalkEachElement(EachElement eachElement)
            {
                var amount = GetIndentationOffset(eachElement.EachBody.Indentation, eachElement.EachBody.Body);
                this.amountToSubtract += amount;
                this.WalkElements(eachElement.EachBody.Body);
                this.amountToSubtract -= amount;

                if (eachElement.NoneBody != null)
                {
                    amount = GetIndentationOffset(eachElement.NoneBody.Indentation, eachElement.NoneBody.Body);
                    this.amountToSubtract += amount;
                    this.WalkElements(eachElement.NoneBody.Body);
                    this.amountToSubtract -= amount;
                }
            }

            public override void WalkIndentationElement(IndentationElement indentationElement)
            {
                this.results[indentationElement] = this.ComputeIndentation(indentationElement.Indentation);
            }

            public override void WalkRenderElement(RenderElement renderElement)
            {
                this.results[renderElement] = this.ComputeIndentation(renderElement.Indentation);
            }

            private static string FindIndentation(Element element)
            {
                CodeElement codeElement;
                EachElement eachElement;
                IfElement ifElement;
                IndentationElement indentationElement;
                RenderElement renderElement;

                if ((codeElement = element as CodeElement) != null)
                {
                    return codeElement.Indentation;
                }
                else if ((eachElement = element as EachElement) != null)
                {
                    return eachElement.EachBody.Indentation;
                }
                else if ((ifElement = element as IfElement) != null)
                {
                    return ifElement.Branches[0].Indentation;
                }
                else if ((indentationElement = element as IndentationElement) != null)
                {
                    return indentationElement.Indentation;
                }
                else if ((renderElement = element as RenderElement) != null)
                {
                    return renderElement.Indentation;
                }

                return null;
            }

            private static int GetIndentationOffset(string indentation, IEnumerable<Element> body)
            {
                if (indentation == null)
                {
                    return 0;
                }

                var ourIndentation = MeasureString(indentation);

                return (from element in body
                        let offset = MeasureString(FindIndentation(element)) - ourIndentation
                        where offset > 0
                        orderby offset
                        select (int?)offset).FirstOrDefault() ?? 0;
            }

            private static int MeasureString(string indentation, int tabWidth = 4)
            {
                var count = 0;

                if (indentation == null)
                {
                    return count;
                }

                for (var i = 0; i < indentation.Length; i++)
                {
                    if (indentation[i] == '\t')
                    {
                        count += tabWidth - (count % tabWidth);
                    }
                    else
                    {
                        count++;
                    }
                }

                return count;
            }

            private static string TrimIndentation(string indentation, int amoutToTrim, int tabWidth = 4)
            {
                var count = MeasureString(indentation, tabWidth);
                var desiredCount = count - amoutToTrim;

                if (desiredCount <= 0)
                {
                    return string.Empty;
                }

                var newCount = 0;
                var i = 0;

                for (i = 0; i < indentation.Length; i++)
                {
                    var previousCount = newCount;

                    if (indentation[i] == '\t')
                    {
                        newCount += tabWidth - (newCount % tabWidth);
                    }
                    else
                    {
                        newCount++;
                    }

                    if (newCount > desiredCount)
                    {
                        newCount = previousCount;
                        break;
                    }
                }

                return indentation.Substring(0, i) + new string(' ', desiredCount - newCount);
            }

            private string ComputeIndentation(string indentation)
            {
                if (indentation == null)
                {
                    return null;
                }

                if (this.amountToSubtract > 0)
                {
                    indentation = TrimIndentation(indentation, this.amountToSubtract);
                }

                return indentation;
            }
        }
    }
}
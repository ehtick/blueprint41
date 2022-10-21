﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 17.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Blueprint41.Neo4j.Refactoring.Templates
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System.Diagnostics;
    using Blueprint41;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\_CirclesArrows\blueprint41\Blueprint41\Neo4j\Refactoring\Templates\RenameProperty.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    internal partial class RenameProperty : RenamePropertyBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 7 "C:\_CirclesArrows\blueprint41\Blueprint41\Neo4j\Refactoring\Templates\RenameProperty.tt"


    Log("	executing {0} -> Rename property from {1} to {2}", this.GetType().Name, From.Name, To);

            
            #line default
            #line hidden
            this.Write("MATCH (node:");
            
            #line 11 "C:\_CirclesArrows\blueprint41\Blueprint41\Neo4j\Refactoring\Templates\RenameProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ConcreteParent.Label.Name));
            
            #line default
            #line hidden
            this.Write(") WHERE EXISTS(node.");
            
            #line 11 "C:\_CirclesArrows\blueprint41\Blueprint41\Neo4j\Refactoring\Templates\RenameProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(From.Name));
            
            #line default
            #line hidden
            this.Write(") \r\nWITH node LIMIT 10000 \r\nSET node.");
            
            #line 13 "C:\_CirclesArrows\blueprint41\Blueprint41\Neo4j\Refactoring\Templates\RenameProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(To));
            
            #line default
            #line hidden
            this.Write(" = node.");
            
            #line 13 "C:\_CirclesArrows\blueprint41\Blueprint41\Neo4j\Refactoring\Templates\RenameProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(From.Name));
            
            #line default
            #line hidden
            this.Write("\r\nSET node.");
            
            #line 14 "C:\_CirclesArrows\blueprint41\Blueprint41\Neo4j\Refactoring\Templates\RenameProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(From.Name));
            
            #line default
            #line hidden
            this.Write(" = NULL\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}

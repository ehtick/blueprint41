﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
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
    
    #line 1 "D:\_CirclesArrows\blueprint41\Blueprint41\Neo4j\Refactoring\Templates\SetLabel.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    internal partial class SetLabel : SetLabelBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 7 "D:\_CirclesArrows\blueprint41\Blueprint41\Neo4j\Refactoring\Templates\SetLabel.tt"


    Debug.WriteLine("	executing {0} -> {1} set label {2}", this.GetType().Name, Entity.Name, Label);


            
            #line default
            #line hidden
            this.Write("MATCH (node:");
            
            #line 12 "D:\_CirclesArrows\blueprint41\Blueprint41\Neo4j\Refactoring\Templates\SetLabel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Entity.Label.Name));
            
            #line default
            #line hidden
            this.Write(") WHERE NONE(label IN labels(node) WHERE label = \'");
            
            #line 12 "D:\_CirclesArrows\blueprint41\Blueprint41\Neo4j\Refactoring\Templates\SetLabel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Label));
            
            #line default
            #line hidden
            this.Write("\') WITH node LIMIT 10000 SET node:");
            
            #line 12 "D:\_CirclesArrows\blueprint41\Blueprint41\Neo4j\Refactoring\Templates\SetLabel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Label));
            
            #line default
            #line hidden
            this.Write("\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}

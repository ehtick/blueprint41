﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Blueprint41.Neo4j.Refactoring.Templates.v4
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System.Diagnostics;
    using Blueprint41;
    using Blueprint41.Neo4j.Refactoring.Templates;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\_CirclesArrows\blueprint41\Blueprint41\Neo4j\Refactoring\Templates\v4\SetDefaultConstantValue.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    internal partial class SetDefaultConstantValue : SetDefaultConstantValueBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 8 "D:\_CirclesArrows\blueprint41\Blueprint41\Neo4j\Refactoring\Templates\v4\SetDefaultConstantValue.tt"


    Debug.WriteLine("	executing {0} -> {1}.{2} = '{3}'", this.GetType().Name, Entity.Name, Property.Name, (Value is null) ? "<NULL>" : Value.ToString());

	// Setup Cypher Parameters
	OutputParameters.Add(Property.Name, Value);


            
            #line default
            #line hidden
            this.Write("MATCH (node:");
            
            #line 16 "D:\_CirclesArrows\blueprint41\Blueprint41\Neo4j\Refactoring\Templates\v4\SetDefaultConstantValue.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Entity.Label.Name));
            
            #line default
            #line hidden
            this.Write(") WHERE NOT EXISTS(node.");
            
            #line 16 "D:\_CirclesArrows\blueprint41\Blueprint41\Neo4j\Refactoring\Templates\v4\SetDefaultConstantValue.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Property.Name));
            
            #line default
            #line hidden
            this.Write(") WITH node LIMIT 10000 SET node.");
            
            #line 16 "D:\_CirclesArrows\blueprint41\Blueprint41\Neo4j\Refactoring\Templates\v4\SetDefaultConstantValue.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Property.Name));
            
            #line default
            #line hidden
            this.Write(" = $");
            
            #line 16 "D:\_CirclesArrows\blueprint41\Blueprint41\Neo4j\Refactoring\Templates\v4\SetDefaultConstantValue.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Property.Name));
            
            #line default
            #line hidden
            this.Write("\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}

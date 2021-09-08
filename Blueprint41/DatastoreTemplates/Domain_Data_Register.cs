﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Blueprint41.DatastoreTemplates
{
    using System.Linq;
    using System.Collections.Generic;
    using Blueprint41.Core;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\_CirclesArrows\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Register.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class Domain_Data_Register : GeneratorBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("using System;\r\nusing Blueprint41.Core;\r\n\r\nnamespace ");
            
            #line 8 "D:\_CirclesArrows\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Register.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Settings.FullCRUDNamespace));
            
            #line default
            #line hidden
            this.Write(@"
{
  internal class Register
	{
		private static bool isInitialized = false;

		public static void Types()
		{
			if (isInitialized)
				return;

			lock (typeof(Register))
			{
				if (isInitialized)
					return;

				isInitialized = true;

");
            
            #line 26 "D:\_CirclesArrows\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Register.tt"

foreach (var DALModel in Datastore.Entities.OrderBy(item => item.Name))
{	

            
            #line default
            #line hidden
            this.Write("\t\t\t\t((ISetRuntimeType)");
            
            #line 30 "D:\_CirclesArrows\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Register.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Datastore.GetType().FullName));
            
            #line default
            #line hidden
            this.Write(".Model.Entities[\"");
            
            #line 30 "D:\_CirclesArrows\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Register.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("\"]).SetRuntimeTypes(typeof(");
            
            #line 30 "D:\_CirclesArrows\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Register.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.ClassName));
            
            #line default
            #line hidden
            this.Write("), typeof(");
            
            #line 30 "D:\_CirclesArrows\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Register.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("));\r\n");
            
            #line 31 "D:\_CirclesArrows\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Register.tt"

}

            
            #line default
            #line hidden
            this.Write("\t\t\t}\r\n\t\t}\r\n\t}\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}

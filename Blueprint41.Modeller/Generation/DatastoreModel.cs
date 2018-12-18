﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Blueprint41.Modeller.Generation
{
    using System;
    using System.Text;
    using System.IO;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    using Blueprint41.Modeller.Schemas;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    internal partial class DatastoreModel : GenerationBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\n");
            
            #line 10 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
 foreach (var functionalId in FunctionalIds)
{

            
            #line default
            #line hidden
            
            #line 13 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

    if(functionalId.IsDefault == true)
    {

            
            #line default
            #line hidden
            this.Write("    FunctionalIds.Default = FunctionalIds.New(\"");
            
            #line 17 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(functionalId.Name));
            
            #line default
            #line hidden
            this.Write("\", \"");
            
            #line 17 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(functionalId.Value));
            
            #line default
            #line hidden
            this.Write("\", IdFormat.");
            
            #line 17 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(functionalId.Type));
            
            #line default
            #line hidden
            this.Write(", 0);\r\n");
            
            #line 18 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
 
    } else {

            
            #line default
            #line hidden
            this.Write("    FunctionalId ");
            
            #line 21 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(functionalId.Name.ToLower()));
            
            #line default
            #line hidden
            this.Write("Id = FunctionalIds.New(\"");
            
            #line 21 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(functionalId.Name));
            
            #line default
            #line hidden
            this.Write("\", \"");
            
            #line 21 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(functionalId.Value));
            
            #line default
            #line hidden
            this.Write("\", IdFormat.");
            
            #line 21 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(functionalId.Type));
            
            #line default
            #line hidden
            this.Write(", 0);\r\n");
            
            #line 22 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
        
   } // end of else

            
            #line default
            #line hidden
            
            #line 25 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
 
} // end of foreach functional id

            
            #line default
            #line hidden
            this.Write("\r\n\r\n");
            
            #line 30 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

foreach (var entity in Entities)
{
    if(string.IsNullOrEmpty(entity.Inherits))
    {
        if (string.IsNullOrEmpty(entity.FunctionalId))
        {

            
            #line default
            #line hidden
            this.Write("    Entities.New(\"");
            
            #line 38 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entity.Name));
            
            #line default
            #line hidden
            this.Write("\")\r\n");
            
            #line 39 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

        } 
        else 
        {
            var ids = FunctionalIds.Where(x => x.Guid == entity.FunctionalId && x.IsDefault == false).ToList();
            string entityFunctionalId = ids.Count > 0 ?  ", " + ids.First().Name.ToLower() + "Id": "";

            
            #line default
            #line hidden
            this.Write("    Entities.New(\"");
            
            #line 46 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entity.Name));
            
            #line default
            #line hidden
            this.Write("\"");
            
            #line 46 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entityFunctionalId));
            
            #line default
            #line hidden
            this.Write(")\r\n");
            
            #line 47 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

        }
    }
    else
    {
		Entity inheritedEntity = Modeller.Model.Entities.Entity.Where(x => x.Guid == entity.Inherits).First();
        string inheritedEntityName = inheritedEntity.Name;
        if(string.IsNullOrEmpty(entity.FunctionalId))
        {

            
            #line default
            #line hidden
            this.Write("    Entities.New(\"");
            
            #line 57 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entity.Name));
            
            #line default
            #line hidden
            this.Write("\", Entities[\"");
            
            #line 57 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(inheritedEntityName));
            
            #line default
            #line hidden
            this.Write("\"])\r\n");
            
            #line 58 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

        }
        else
        {
            var ids = FunctionalIds.Where(x => x.Guid == entity.FunctionalId && x.IsDefault == false).ToList();
            string entityFunctionalId = ids.Count > 0 ?  ids.First().Name.ToLower() + "Id, ": "";

			if(!string.IsNullOrEmpty(entity.FunctionalId) && !string.IsNullOrEmpty(inheritedEntity.FunctionalId))
			{
				if(entity.FunctionalId == inheritedEntity.FunctionalId)
				{
					entityFunctionalId = "";
				}
			}

            
            #line default
            #line hidden
            this.Write("    Entities.New(\"");
            
            #line 73 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entity.Name));
            
            #line default
            #line hidden
            this.Write("\", ");
            
            #line 73 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entityFunctionalId));
            
            #line default
            #line hidden
            this.Write("Entities[\"");
            
            #line 73 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(inheritedEntityName));
            
            #line default
            #line hidden
            this.Write("\"])\r\n");
            
            #line 74 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
				
        }
        if(!string.IsNullOrEmpty(entity.Summary))
        {

            
            #line default
            #line hidden
            this.Write("        .Summary(\"");
            
            #line 79 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entity.Summary.Replace("\"", "\\\"")));
            
            #line default
            #line hidden
            this.Write("\")\r\n");
            
            #line 80 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

        }
    }
    if(entity.Abstract)
    {

            
            #line default
            #line hidden
            this.Write("        .Abstract(true)\r\n");
            
            #line 87 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

    }
    if(entity.Virtual)
    {

            
            #line default
            #line hidden
            this.Write("        .Virtual(true)\r\n");
            
            #line 93 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

    }
	if (entity.StaticData != null)
	{

            
            #line default
            #line hidden
            this.Write("        .HasStaticData(true)\r\n");
            
            #line 99 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

	}
    foreach (var primitive in entity.Primitive)
    {
        if(!string.IsNullOrEmpty(primitive.Index) && !primitive.Index.Equals("None"))
        {

            
            #line default
            #line hidden
            this.Write("        .AddProperty(\"");
            
            #line 106 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(primitive.Name));
            
            #line default
            #line hidden
            this.Write("\", typeof(");
            
            #line 106 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(primitive.Type));
            
            #line default
            #line hidden
            this.Write("), ");
            
            #line 106 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(!primitive.Nullable?"false,":""));
            
            #line default
            #line hidden
            this.Write(" IndexType.");
            
            #line 106 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(primitive.Index));
            
            #line default
            #line hidden
            this.Write(")\r\n");
            
            #line 107 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

        }
        else
        {

            
            #line default
            #line hidden
            this.Write("        .AddProperty(\"");
            
            #line 112 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(primitive.Name));
            
            #line default
            #line hidden
            this.Write("\", typeof(");
            
            #line 112 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(primitive.Type ?? ""));
            
            #line default
            #line hidden
            this.Write(")");
            
            #line 112 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(!primitive.Nullable?", false":""));
            
            #line default
            #line hidden
            this.Write(")\r\n");
            
            #line 113 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

        }
        if(primitive.IsKey)
        {

            
            #line default
            #line hidden
            this.Write("        .SetKey(\"");
            
            #line 118 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(primitive.Name));
            
            #line default
            #line hidden
            this.Write("\", true)\r\n");
            
            #line 119 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

        }
    } // end of foreach primitive
    Write(string.Join($"{Environment.NewLine}", entity.Primitive.Where(x => x.IsFullTextProperty == true).Select(x =>".SetFullTextProperty(\""+ x.Name+"\")").ToList()));
    GenerationEnvironment = TrimEnd(GenerationEnvironment);
    Write(";\r\n\r\n");

            
            #line default
            #line hidden
            
            #line 126 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

} // end foreach entities
foreach (var relationship in Relationships)
{
    bool hasRelationshipSourceName = string.IsNullOrEmpty(relationship.Source.Name);
    bool hasRelationshipTargetName = string.IsNullOrEmpty(relationship.Target.Name);

    string postfix = hasRelationshipTargetName ? ";" : "";
    if(string.IsNullOrEmpty(relationship.Name))
    {

            
            #line default
            #line hidden
            this.Write("\r\n    Relations.New(Entities[\"");
            
            #line 138 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(relationship.Source.Label));
            
            #line default
            #line hidden
            this.Write("\"], ");
            
            #line 138 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(relationship.Target.Label != null ? $"Entities[\"{relationship.Target.Label}\"]" : "null"));
            
            #line default
            #line hidden
            this.Write(", ");
            
            #line 138 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(relationship.Type));
            
            #line default
            #line hidden
            this.Write(")\r\n");
            
            #line 139 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

    }
    else
    {

            
            #line default
            #line hidden
            this.Write("\r\n    Relations.New(Entities[\"");
            
            #line 145 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(relationship.Source.Label));
            
            #line default
            #line hidden
            this.Write("\"], ");
            
            #line 145 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(relationship.Target.Label != null ? $"Entities[\"{relationship.Target.Label}\"]" : "null"));
            
            #line default
            #line hidden
            this.Write(", \"");
            
            #line 145 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(relationship.Name));
            
            #line default
            #line hidden
            this.Write("\", \"");
            
            #line 145 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(relationship.Type));
            
            #line default
            #line hidden
            this.Write("\")\r\n");
            
            #line 146 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

    }
    if(!hasRelationshipSourceName)
    {
        if(relationship.Source.Nullable)
            {

            
            #line default
            #line hidden
            this.Write("        .SetInProperty(\"");
            
            #line 153 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(relationship.Source.Name));
            
            #line default
            #line hidden
            this.Write("\", PropertyType.");
            
            #line 153 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(relationship.Source.Type));
            
            #line default
            #line hidden
            this.Write(")");
            
            #line 153 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(postfix));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 154 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

			}
			else
            {

            
            #line default
            #line hidden
            this.Write("        .SetInProperty(\"");
            
            #line 159 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(relationship.Source.Name));
            
            #line default
            #line hidden
            this.Write("\", PropertyType.");
            
            #line 159 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(relationship.Source.Type));
            
            #line default
            #line hidden
            this.Write(", ");
            
            #line 159 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(relationship.Source.Nullable.ToString().ToLower()));
            
            #line default
            #line hidden
            this.Write(")");
            
            #line 159 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(postfix));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 160 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

            }
    }
    if(!hasRelationshipTargetName)
    {
        if(relationship.Target.Nullable)
        {

            
            #line default
            #line hidden
            this.Write("        .SetOutProperty(\"");
            
            #line 168 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(relationship.Target.Name));
            
            #line default
            #line hidden
            this.Write("\", PropertyType.");
            
            #line 168 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(relationship.Target.Type));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 169 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

        }
		else
        {

            
            #line default
            #line hidden
            this.Write("        .SetOutProperty(\"");
            
            #line 174 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(relationship.Target.Name));
            
            #line default
            #line hidden
            this.Write("\", PropertyType.");
            
            #line 174 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(relationship.Target.Type));
            
            #line default
            #line hidden
            this.Write(", ");
            
            #line 174 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(relationship.Target.Nullable.ToString().ToLower()));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 175 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

        }
    }
    else
    {
    }
} // end of foreach entities

            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 184 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

foreach (var entity in Entities)
{
	if (entity.StaticData != null)
	{
		foreach(var record in entity.StaticData.Records.Record)
		{
			var allProperties = new List<Primitive>();
            Entity current = entity;
            do
            {
               allProperties.AddRange(current.Primitive);
               current = current.ParentEntity;
            } while (current != null);
            var primitiveRecords = record.Property.Where(r => allProperties.Any(p => p.Guid == r.PropertyGuid));


            
            #line default
            #line hidden
            this.Write("    Entities[\"");
            
            #line 201 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entity.Name));
            
            #line default
            #line hidden
            this.Write("\"].Refactor.CreateNode(new {");
            
            #line 201 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

			for(int index = 0; index < primitiveRecords.Count(); index++)
			{
				var prop = primitiveRecords.ElementAt(index);
				string comma = index == primitiveRecords.Count() - 1 ? " " : ",";
				var primitive = allProperties.Where(p => p.Guid == prop.PropertyGuid).FirstOrDefault();
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 206 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(primitive.Name));
            
            #line default
            #line hidden
            this.Write(" = \"");
            
            #line 206 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.Value));
            
            #line default
            #line hidden
            this.Write("\"");
            
            #line 206 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(comma));
            
            #line default
            #line hidden
            
            #line 206 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

			}

            
            #line default
            #line hidden
            this.Write("});\r\n");
            
            #line 209 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

		}
	}

            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 214 "D:\_CirclesArrows\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

	
} // end foreach entities

            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}

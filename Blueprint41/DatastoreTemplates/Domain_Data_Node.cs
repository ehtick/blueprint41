﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Blueprint41.DatastoreTemplates
{
    using System.Linq;
    using System.Collections.Generic;
    using Blueprint41;
    using Blueprint41.Core;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class Domain_Data_Node : GeneratorBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("using System;\r\nusing System.Collections.Generic;\r\n\r\nusing Blueprint41;\r\nusing Blu" +
                    "eprint41.Core;\r\nusing Blueprint41.Query;\r\n\r\nnamespace ");
            
            #line 14 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Settings.FullQueryNamespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n\tpublic partial class Node\r\n\t{\r\n");
            
            #line 18 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"

	if(DALModel.IsVirtual)
    {

            
            #line default
            #line hidden
            this.Write("\t\t[Obsolete(\"This entity is virtual, consider making entity ");
            
            #line 22 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write(" concrete or use another entity as your starting point.\", true)]\r\n");
            
            #line 23 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"

    }

            
            #line default
            #line hidden
            this.Write("\t\tpublic static ");
            
            #line 26 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("Node ");
            
            #line 26 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write(" { get { return new ");
            
            #line 26 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("Node(); } }\r\n\t}\r\n\r\n\tpublic partial class ");
            
            #line 29 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("Node : Blueprint41.Query.Node\r\n\t{\r\n        protected override string GetNeo4jLabe" +
                    "l()\r\n        {\r\n");
            
            #line 33 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"

	if(DALModel.IsVirtual)
    {

            
            #line default
            #line hidden
            this.Write("\t\t\treturn null;\r\n");
            
            #line 38 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"

    }
	else
    {

            
            #line default
            #line hidden
            this.Write("\t\t\treturn \"");
            
            #line 43 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Label.Name));
            
            #line default
            #line hidden
            this.Write("\";\r\n");
            
            #line 44 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"

    }

            
            #line default
            #line hidden
            this.Write("        }\r\n\r\n\t\tinternal ");
            
            #line 49 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("Node() { }\r\n\t\tinternal ");
            
            #line 50 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("Node(");
            
            #line 50 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("Alias alias, bool isReference = false)\r\n\t\t{\r\n\t\t\tNodeAlias = alias;\r\n\t\t\tIsReferenc" +
                    "e = isReference;\r\n\t\t}\r\n\t\tinternal ");
            
            #line 55 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("Node(RELATIONSHIP relationship, DirectionEnum direction, string neo4jLabel = null" +
                    ") : base(relationship, direction, neo4jLabel) { }\r\n\r\n\t\tpublic ");
            
            #line 57 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("Node Alias(out ");
            
            #line 57 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("Alias alias)\r\n\t\t{\r\n\t\t\talias = new ");
            
            #line 59 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("Alias(this);\r\n            NodeAlias = alias;\r\n\t\t\treturn this;\r\n\t\t}\r\n\r\n\t\tpublic ");
            
            #line 64 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("Node UseExistingAlias(AliasResult alias)\r\n        {\r\n            NodeAlias = alia" +
                    "s;\r\n\t\t\treturn this;\r\n        }\r\n\r\n");
            
            #line 70 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"

	foreach(Entity subclass in DALModel.GetSubclasses())
    {

            
            #line default
            #line hidden
            this.Write("\t\tpublic ");
            
            #line 74 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(subclass.Name));
            
            #line default
            #line hidden
            this.Write("Node CastTo");
            
            #line 74 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(subclass.Name));
            
            #line default
            #line hidden
            this.Write(@"()
        {
			if (this.Neo4jLabel == null)
				throw new InvalidOperationException(""Casting is not supported for virtual entities."");

            if (FromRelationship == null)
                throw new InvalidOperationException(""Please use the right type immediately, casting is only support after you have match through a relationship."");

            return new ");
            
            #line 82 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(subclass.Name));
            
            #line default
            #line hidden
            this.Write("Node(FromRelationship, Direction, this.Neo4jLabel);\r\n        }\r\n\r\n");
            
            #line 85 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"

	}
	var inRelations =  Datastore.Relations.Where(item => DALModel.IsSelfOrSubclassOf(item.InEntity)).OrderBy(item => item.Name);
	var outRelations = Datastore.Relations.Where(item => DALModel.IsSelfOrSubclassOf(item.OutEntity)).OrderBy(item => item.Name);
	var anyRelations = Datastore.Relations.Where(item => DALModel.IsSelfOrSubclassOf(item.OutEntity) && item.InEntity == item.OutEntity).OrderBy(item => item.Name);

	if (inRelations.Any())
    {

            
            #line default
            #line hidden
            this.Write("\t\r\n\t\tpublic ");
            
            #line 94 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("In  In  { get { return new ");
            
            #line 94 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("In(this); } }\r\n\t\tpublic class ");
            
            #line 95 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("In\r\n\t\t{\r\n\t\t\tprivate ");
            
            #line 97 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("Node Parent;\r\n\t\t\tinternal ");
            
            #line 98 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("In(");
            
            #line 98 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("Node parent)\r\n\t\t\t{\r\n                Parent = parent;\r\n\t\t\t}\r\n");
            
            #line 102 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"

		foreach (Relationship rel in inRelations)
		{

            
            #line default
            #line hidden
            this.Write("\t\t\tpublic IFromIn_");
            
            #line 106 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(rel.Name));
            
            #line default
            #line hidden
            this.Write("_REL ");
            
            #line 106 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(rel.Name));
            
            #line default
            #line hidden
            this.Write(" { get { return new ");
            
            #line 106 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(rel.Name));
            
            #line default
            #line hidden
            this.Write("_REL(Parent, DirectionEnum.In); } }\r\n");
            
            #line 107 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"

		}

            
            #line default
            #line hidden
            this.Write("\r\n\t\t}\r\n");
            
            #line 112 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"

    }

	if (outRelations.Any())
    {

            
            #line default
            #line hidden
            this.Write("\r\n\t\tpublic ");
            
            #line 119 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("Out Out { get { return new ");
            
            #line 119 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("Out(this); } }\r\n\t\tpublic class ");
            
            #line 120 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("Out\r\n\t\t{\r\n\t\t\tprivate ");
            
            #line 122 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("Node Parent;\r\n\t\t\tinternal ");
            
            #line 123 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("Out(");
            
            #line 123 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("Node parent)\r\n\t\t\t{\r\n                Parent = parent;\r\n\t\t\t}\r\n");
            
            #line 127 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"

		foreach (Relationship rel in outRelations)
		{

            
            #line default
            #line hidden
            this.Write("\t\t\tpublic IFromOut_");
            
            #line 131 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(rel.Name));
            
            #line default
            #line hidden
            this.Write("_REL ");
            
            #line 131 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(rel.Name));
            
            #line default
            #line hidden
            this.Write(" { get { return new ");
            
            #line 131 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(rel.Name));
            
            #line default
            #line hidden
            this.Write("_REL(Parent, DirectionEnum.Out); } }\r\n");
            
            #line 132 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"

		}

            
            #line default
            #line hidden
            this.Write("\t\t}\r\n");
            
            #line 136 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"

    }

	if (anyRelations.Any())
    {

            
            #line default
            #line hidden
            this.Write("\r\n\t\tpublic ");
            
            #line 143 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("Any Any { get { return new ");
            
            #line 143 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("Any(this); } }\r\n\t\tpublic class ");
            
            #line 144 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("Any\r\n\t\t{\r\n\t\t\tprivate ");
            
            #line 146 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("Node Parent;\r\n\t\t\tinternal ");
            
            #line 147 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("Any(");
            
            #line 147 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("Node parent)\r\n\t\t\t{\r\n                Parent = parent;\r\n\t\t\t}\r\n");
            
            #line 151 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"

		foreach (Relationship rel in anyRelations)
		{

            
            #line default
            #line hidden
            this.Write("\t\t\tpublic IFromAny_");
            
            #line 155 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(rel.Name));
            
            #line default
            #line hidden
            this.Write("_REL ");
            
            #line 155 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(rel.Name));
            
            #line default
            #line hidden
            this.Write(" { get { return new ");
            
            #line 155 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(rel.Name));
            
            #line default
            #line hidden
            this.Write("_REL(Parent, DirectionEnum.None); } }\r\n");
            
            #line 156 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"

		}

            
            #line default
            #line hidden
            this.Write("\t\t}\r\n");
            
            #line 160 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"

    }

            
            #line default
            #line hidden
            this.Write("\t}\r\n\r\n    public class ");
            
            #line 165 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("Alias : AliasResult\r\n    {\r\n        internal ");
            
            #line 167 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("Alias(");
            
            #line 167 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write(@"Node parent)
        {
			Node = parent;
        }

        public override IReadOnlyDictionary<string, FieldResult> AliasFields
        {
            get
            {
                if (m_AliasFields == null)
                {
                    m_AliasFields = ");
            
            #line 178 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(string.IsNullOrEmpty(DALModel.UnidentifiedProperties) ? "" : "new UnidentifiedPropertiesAliasDictionary("));
            
            #line default
            #line hidden
            this.Write("new Dictionary<string, FieldResult>()\r\n                    {\r\n");
            
            #line 180 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"

	foreach (var property in DALModel.GetPropertiesOfBaseTypesAndSelf())
    {
		if (property.PropertyType != PropertyType.Attribute)
			continue;

            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t\t{ \"");
            
            #line 186 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name));
            
            #line default
            #line hidden
            this.Write("\", new ");
            
            #line 186 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetResultType(property.SystemReturnType)));
            
            #line default
            #line hidden
            this.Write("(this, \"");
            
            #line 186 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name));
            
            #line default
            #line hidden
            this.Write("\", ");
            
            #line 186 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Datastore.GetType().FullName));
            
            #line default
            #line hidden
            this.Write(".Model.Entities[\"");
            
            #line 186 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("\"], ");
            
            #line 186 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Datastore.GetType().FullName));
            
            #line default
            #line hidden
            this.Write(".Model.Entities[\"");
            
            #line 186 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Parent.Name));
            
            #line default
            #line hidden
            this.Write("\"].Properties[\"");
            
            #line 186 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name));
            
            #line default
            #line hidden
            this.Write("\"]) },\r\n");
            
            #line 187 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"

	}

            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t}");
            
            #line 190 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(string.IsNullOrEmpty(DALModel.UnidentifiedProperties) ? "" : string.Concat(", ", Settings.FullCRUDNamespace, ".", DALModel.Name ,".Entity, this)")));
            
            #line default
            #line hidden
            this.Write(";\r\n\t\t\t\t}\r\n\t\t\t\treturn m_AliasFields;\r\n\t\t\t}\r\n\t\t}\r\n        private IReadOnlyDictiona" +
                    "ry<string, FieldResult> m_AliasFields = null;\r\n\r\n");
            
            #line 197 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"

	if (inRelations.Any())
    {

            
            #line default
            #line hidden
            this.Write("        public ");
            
            #line 201 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("Node.");
            
            #line 201 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("In In { get { return new ");
            
            #line 201 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("Node.");
            
            #line 201 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("In(new ");
            
            #line 201 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("Node(this, true)); } }\r\n");
            
            #line 202 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"

	}
	if (outRelations.Any())
    {

            
            #line default
            #line hidden
            this.Write("        public ");
            
            #line 207 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("Node.");
            
            #line 207 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("Out Out { get { return new ");
            
            #line 207 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("Node.");
            
            #line 207 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("Out(new ");
            
            #line 207 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("Node(this, true)); } }\r\n");
            
            #line 208 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"

	}
	if (anyRelations.Any())
    {

            
            #line default
            #line hidden
            this.Write("        public ");
            
            #line 213 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("Node.");
            
            #line 213 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("Any Any { get { return new ");
            
            #line 213 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("Node.");
            
            #line 213 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("Any(new ");
            
            #line 213 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("Node(this, true)); } }\r\n");
            
            #line 214 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"

	}

            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 218 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"

	foreach (var property in DALModel.GetPropertiesOfBaseTypesAndSelf())
    {
		if (property.PropertyType != PropertyType.Attribute)
			continue;


            
            #line default
            #line hidden
            this.Write("        public ");
            
            #line 225 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetResultType(property.SystemReturnType)));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 225 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t{\r\n\t\t\tget\r\n\t\t\t{\r\n\t\t\t\tif ((object)m_");
            
            #line 229 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name));
            
            #line default
            #line hidden
            this.Write(" == null)\r\n\t\t\t\t\tm_");
            
            #line 230 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name));
            
            #line default
            #line hidden
            this.Write(" = (");
            
            #line 230 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetResultType(property.SystemReturnType)));
            
            #line default
            #line hidden
            this.Write(")AliasFields[\"");
            
            #line 230 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name));
            
            #line default
            #line hidden
            this.Write("\"];\r\n\r\n\t\t\t\treturn m_");
            
            #line 232 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name));
            
            #line default
            #line hidden
            this.Write(";\r\n\t\t\t}\r\n\t\t} \r\n        private ");
            
            #line 235 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetResultType(property.SystemReturnType)));
            
            #line default
            #line hidden
            this.Write(" m_");
            
            #line 235 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name));
            
            #line default
            #line hidden
            this.Write(" = null;\r\n");
            
            #line 236 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"

    }

	if (!string.IsNullOrEmpty(DALModel.UnidentifiedProperties))
    {

            
            #line default
            #line hidden
            this.Write("        public UnidentifiedProperties ");
            
            #line 242 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.UnidentifiedProperties));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t{\r\n\t\t\tget\r\n\t\t\t{\r\n\t\t\t\tif ((object)m_");
            
            #line 246 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.UnidentifiedProperties));
            
            #line default
            #line hidden
            this.Write(" == null)\r\n\t\t\t\t\tm_");
            
            #line 247 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.UnidentifiedProperties));
            
            #line default
            #line hidden
            this.Write(" = new UnidentifiedProperties(this, ");
            
            #line 247 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Datastore.GetType().FullName));
            
            #line default
            #line hidden
            this.Write(".Model.Entities[\"");
            
            #line 247 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("\"]);\r\n\r\n\t\t\t\treturn m_");
            
            #line 249 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.UnidentifiedProperties));
            
            #line default
            #line hidden
            this.Write(";\r\n\t\t\t}\r\n\t\t}\r\n\t\tprivate UnidentifiedProperties m_");
            
            #line 252 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.UnidentifiedProperties));
            
            #line default
            #line hidden
            this.Write(" = null;\r\n\r\n        public class UnidentifiedProperties\r\n        {\r\n            i" +
                    "nternal UnidentifiedProperties(");
            
            #line 256 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write("Alias alias, Entity entity)\r\n            {\r\n                Alias = alias;\r\n     " +
                    "           Entity = entity;\r\n            }\r\n            private ");
            
            #line 261 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DALModel.Name));
            
            #line default
            #line hidden
            this.Write(@"Alias Alias;
            private Entity Entity;

            public MiscResult Get(string fieldName) { return new MiscResult(Alias, fieldName, Entity, null); }
            public MiscResult this[string fieldName] { get { return Get(fieldName); } }

			public MiscResult Get(FieldResult result, bool withCoalesce = false, Type type = null)
            {
				if (withCoalesce)
					return new MiscResult(""{0}[COALESCE({1}, '')]"", new object[] { Alias, result }, type ?? typeof(object));
				else
					return new MiscResult(""{0}[{1}]"", new object[] { Alias, result }, type ?? typeof(object));
            }
        }
");
            
            #line 275 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"

    }

            
            #line default
            #line hidden
            this.Write("    }\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 280 "C:\_Xirqlz\blueprint41\Blueprint41\DatastoreTemplates\Domain_Data_Node.tt"


	private string GetResultType(Type type)
	{
		switch (type.Name)
		{
			case "Boolean":
				return "BooleanResult";
			case "Int16":
			case "Int32":
			case "Int64":
				return "NumericResult";
			case "Single":
			case "Double":
				return "FloatResult";
			case "Guid":
			case "String":
				return "StringResult";
			case "DateTime":
				return "DateTimeResult";
			case "List`1":
				if(type.GenericTypeArguments[0] == typeof(string))
					return "StringListResult";
				else
					return "ListResult";
			default:
				return "MiscResult";
		}
	}

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}

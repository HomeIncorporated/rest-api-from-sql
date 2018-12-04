﻿using Armsoft.RestApiFromSqlSchema.Components.Schema;

namespace Armsoft.RestApiFromSqlSchema.Components.Templates.Generators
{
    public class ClassTemplateGenerator
    {
        public ClassTemplate Generate(Table table, string typeName)
        {
            return new ClassTemplate
            {
                Namespace = table.SchemaName,
                TypeName = typeName,
                Properties = table.Columns
            };
        }
    }
}
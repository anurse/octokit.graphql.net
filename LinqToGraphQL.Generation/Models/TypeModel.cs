﻿using System;
using System.Collections.Generic;
using LinqToGraphQL.Introspection;

namespace LinqToGraphQL.Generation.Models
{
    public class TypeModel
    {
        public TypeKind Kind { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<FieldModel> Fields { get; set; }
        public IList<TypeModel> Interfaces { get; set; }
        public IList<TypeModel> PossibleTypes { get; set; }
        public IList<EnumValueModel> EnumValues { get; set; }
        public IList<InputValueModel> InputFields { get; set; }
        public TypeModel OfType { get; set; }
    }
}
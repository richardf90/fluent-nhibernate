using System;
using System.Reflection;
using FluentNHibernate.Conventions.DslImplementation;
using FluentNHibernate.MappingModel.Collections;

namespace FluentNHibernate.Conventions.Inspections
{
    public class CollectionInspector : ICollectionInspector
    {
        private readonly InspectorModelMapper<ICollectionInspector, ICollectionMapping> propertyMappings = new InspectorModelMapper<ICollectionInspector, ICollectionMapping>();
        private readonly ICollectionMapping mapping;

        public CollectionInspector(ICollectionMapping mapping)
        {
            this.mapping = mapping;

            propertyMappings.Map(x => x.TableName, x => x.TableName);
        }

        public Type EntityType
        {
            get { throw new NotImplementedException(); }
        }
        public string StringIdentifierForModel
        {
            get { throw new NotImplementedException(); }
        }
        public bool IsSet(PropertyInfo property)
        {
            throw new NotImplementedException();
        }

        public IKeyInspector Key
        {
            get { throw new NotImplementedException(); }
        }
        public string TableName
        {
            get { throw new NotImplementedException(); }
        }
        public bool IsMethodAccess
        {
            get { return mapping.MemberInfo is MethodInfo; }
        }
        public MemberInfo Member
        {
            get { return mapping.MemberInfo; }
        }
        public IRelationshipInspector Relationship
        {
            get { throw new NotImplementedException(); }
        }
    }
}
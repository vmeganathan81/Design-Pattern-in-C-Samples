using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.SwitchCaseReplacement
{
    public class EntityFactory
    {
        private Dictionary<EntityType, Func<Entity>> _entityTypeMapper;

        public EntityFactory()
        {
            _entityTypeMapper = new Dictionary<EntityType, Func<Entity>>();
            _entityTypeMapper.Add(EntityType.Type0, () => { return new Type0Entity(); });
            _entityTypeMapper.Add(EntityType.Type1, () => { return new Type1Entity(); });
            _entityTypeMapper.Add(EntityType.Type2, () => { return new Type2Entity(); });
        }

        public Entity GetEntityBasedOnType(EntityType entityType)
        {
            return _entityTypeMapper[entityType]();
        }
    }
}

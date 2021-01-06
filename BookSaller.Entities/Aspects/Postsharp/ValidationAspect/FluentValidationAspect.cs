using BookSaller.Entities.Utilities;
using FluentValidation;
using PostSharp.Aspects;
using PostSharp.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSaller.Entities.Aspects.Postsharp.FluentValidationAspect
{
    [PSerializable]
    public class FluentValidationAspect : OnMethodBoundaryAspect
    {
        Type _validationType;
        public FluentValidationAspect(Type validationType)
        {
            _validationType = validationType;
        }

        public override void OnEntry(MethodExecutionArgs args)
        {
            var validator = (IValidator)Activator.CreateInstance(_validationType);
            var entityType = _validationType.BaseType.GetGenericArguments()[0];
            var entities = args.Arguments.Where(t => t.GetType() == entityType);

            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator,entity);
            }
            
        }
    }
}

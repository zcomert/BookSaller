using PostSharp.Aspects;
using PostSharp.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSaller.Entities.Aspects.Postsharp.TransactionAspect
{
    [PSerializable]
    public class TransactionScopeAspect:OnMethodBoundaryAspect
    {
        public TransactionScopeAspect()
        {

        }


    }
}

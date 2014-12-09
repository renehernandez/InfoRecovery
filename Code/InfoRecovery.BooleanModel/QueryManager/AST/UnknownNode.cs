using Antlr.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfoRecovery.BooleanModel.QueryManager.AST
{
    public class UnknownNode : BooleanQueryNode
    {
        public UnknownNode() : base() { }

        public UnknownNode(UnknownNode node) : base(node) { }

        public UnknownNode(IToken token) : base(token) { }

        public override ISet<string> Execute()
        {
            throw new NotImplementedException();
        }
    }
}

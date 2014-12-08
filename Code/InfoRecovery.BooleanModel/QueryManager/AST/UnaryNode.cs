using Antlr.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfoRecovery.BooleanModel.QueryManager.AST
{
    public abstract class UnaryNode : BooleanQueryNode
    {
        protected UnaryNode() : base() { }

        protected UnaryNode(UnaryNode node) : base(node) { }

        protected UnaryNode(IToken token) : base(token) { }

        public override abstract ISet<string> Execute();
    }
}

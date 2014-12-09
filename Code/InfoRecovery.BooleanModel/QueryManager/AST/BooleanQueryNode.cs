using Antlr.Runtime;
using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfoRecovery.BooleanModel.QueryManager.AST
{
    public abstract class BooleanQueryNode : CommonTree
    {
        protected BooleanQueryNode() : base() { }

        protected BooleanQueryNode(BooleanQueryNode node) : base(node) { }

        protected BooleanQueryNode(IToken token) : base(token) { }

        public abstract ISet<string> Execute();
    }
}

using Antlr.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfoRecovery.BooleanModel.QueryManager.AST
{
    public class NotNode : UnaryNode
    {
        public NotNode() : base() { }

        public NotNode(NotNode node) : base(node) { }

        public NotNode(IToken token) : base(token) { }

        public override ISet<string> Execute()
        {
            // find all the documents in which `this.Text` doesn't appear and then...
            return new HashSet<string>();
        }
    }
}

using Antlr.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfoRecovery.BooleanModel.QueryManager.AST
{
    public class TermNode : UnaryNode
    {
        public TermNode() : base() { }

        public TermNode(TermNode node) : base(node) { }

        public TermNode(IToken token) : base(token) { }

        public override ISet<string> Execute()
        {
            var result = new HashSet<string>();
            result.Add(this.Text);
            return result;
        }
    }
}

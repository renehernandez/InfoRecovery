using Antlr.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfoRecovery.BooleanModel.QueryManager.AST
{
    public class OrNode : BinaryNode
    {
        public OrNode() : base() { }

        public OrNode(OrNode node) : base(node) { }

        public OrNode(IToken token) : base(token) { }

        public override ISet<string> Execute()
        {
            var resultsSet = this.LeftOperand.Execute();
            resultsSet.UnionWith(this.RightOperand.Execute());
            return resultsSet;
        }
    }
}

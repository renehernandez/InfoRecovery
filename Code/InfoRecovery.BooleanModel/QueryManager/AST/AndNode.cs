using Antlr.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfoRecovery.BooleanModel.QueryManager.AST
{
    public class AndNode : BinaryNode
    {
        public AndNode() : base() { }

        public AndNode(AndNode node) : base(node) { }

        public AndNode(IToken token) : base(token) { }

        public override ISet<string> Execute()
        {
            var resultsSet = this.LeftOperand.Execute();
            resultsSet.IntersectWith(this.RightOperand.Execute());
            return resultsSet;
        }
    }
}

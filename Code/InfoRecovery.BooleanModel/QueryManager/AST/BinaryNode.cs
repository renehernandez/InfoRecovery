using Antlr.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfoRecovery.BooleanModel.QueryManager.AST
{
    public abstract class BinaryNode : BooleanQueryNode
    {
        public BooleanQueryNode LeftOperand
        {
            get
            {
                return this.Children[0] as BooleanQueryNode;
            }
        }

        public BooleanQueryNode RightOperand
        {
            get
            {
                return this.Children[1] as BooleanQueryNode;
            }
        }

        protected BinaryNode() : base() { }

        protected BinaryNode(BinaryNode node) : base(node) { }

        protected BinaryNode(IToken token) : base(token) { }

        public override abstract ISet<string> Execute();
    }
}

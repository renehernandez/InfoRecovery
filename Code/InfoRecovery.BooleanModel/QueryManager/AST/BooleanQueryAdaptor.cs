using Antlr.Runtime;
using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfoRecovery.BooleanModel.QueryManager.AST
{
    public class BooleanQueryAdaptor : CommonTreeAdaptor
    {
        public override object Create(IToken payload)
        {
            if (payload == null)
                return new UnknownNode(payload);

            switch (payload.Type)
            {
                case BooleanQueryParser.AND:
                    return new AndNode(payload);
                case BooleanQueryParser.OR:
                    return new OrNode(payload);
                case BooleanQueryParser.NOT:
                    return new NotNode(payload);
                case BooleanQueryParser.TERM:
                    return new TermNode(payload);
                default:
                    return new UnknownNode(payload);
            }
        }
    }
}

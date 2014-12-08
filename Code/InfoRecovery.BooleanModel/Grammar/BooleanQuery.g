grammar BooleanQuery;

options {
	/* COMMENT FOR DEBUGGING */
	language=CSharp3;
	output=AST;
	/* UNCOMMENT FOR DEBUGGING */
	//language=Java;
}
	
// TOKENS
WS  :   ( ' ' | '\t' | '\r' | '\n' ) {$channel=Hidden;};
TERM : ~('&' | '|' | '!' | '(' | ')')+;
AND : '&';
OR : '|';
NOT : '!';
LPAR : '(';
RPAR : ')';

// PARSER
public query
	:	or EOF -> or;

or	:	(x=and -> $x)
	(
		(OR y=and -> ^(OR $or $y))
	)*;

and	:	(x=term -> $x)
	(
		(AND y=term -> ^(AND $and $y))
	)*;

term	: (x=TERM -> $x)
	| (NOT y=TERM -> ^(NOT $y) )
	| (LPAR or RPAR -> or);




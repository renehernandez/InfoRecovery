//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 3.4
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// $ANTLR 3.4 D:\\Eduar\\uh\\5to\\si\\InfoRecovery\\Code\\InfoRecovery.BooleanModel\\Grammar\\BooleanQuery.g 2014-12-08 10:37:17

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162
// Missing XML comment for publicly visible type or member 'Type_or_Member'
#pragma warning disable 1591
// CLS compliance checking will not be performed on 'type' because it is not visible from outside this assembly.
#pragma warning disable 3019


using System.Collections.Generic;
using Antlr.Runtime;
using Antlr.Runtime.Misc;


using Antlr.Runtime.Tree;
using RewriteRuleITokenStream = Antlr.Runtime.Tree.RewriteRuleTokenStream;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.4")]
[System.CLSCompliant(false)]
public partial class BooleanQueryParser : Antlr.Runtime.Parser
{
	internal static readonly string[] tokenNames = new string[] {
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "AND", "LPAR", "NOT", "OR", "RPAR", "TERM", "WS"
	};
	public const int EOF=-1;
	public const int AND=4;
	public const int LPAR=5;
	public const int NOT=6;
	public const int OR=7;
	public const int RPAR=8;
	public const int TERM=9;
	public const int WS=10;

	public BooleanQueryParser(ITokenStream input)
		: this(input, new RecognizerSharedState())
	{
	}
	public BooleanQueryParser(ITokenStream input, RecognizerSharedState state)
		: base(input, state)
	{
		ITreeAdaptor treeAdaptor = default(ITreeAdaptor);
		CreateTreeAdaptor(ref treeAdaptor);
		TreeAdaptor = treeAdaptor ?? new CommonTreeAdaptor();
		OnCreated();
	}
	// Implement this function in your helper file to use a custom tree adaptor
	partial void CreateTreeAdaptor(ref ITreeAdaptor adaptor);

	private ITreeAdaptor adaptor;

	public ITreeAdaptor TreeAdaptor
	{
		get
		{
			return adaptor;
		}

		set
		{
			this.adaptor = value;
		}
	}

	public override string[] TokenNames { get { return BooleanQueryParser.tokenNames; } }
	public override string GrammarFileName { get { return "D:\\Eduar\\uh\\5to\\si\\InfoRecovery\\Code\\InfoRecovery.BooleanModel\\Grammar\\BooleanQuery.g"; } }


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	#region Rules
	partial void EnterRule_query();
	partial void LeaveRule_query();

	// $ANTLR start "query"
	// D:\\Eduar\\uh\\5to\\si\\InfoRecovery\\Code\\InfoRecovery.BooleanModel\\Grammar\\BooleanQuery.g:21:8: public query : or EOF -> or ;
	[GrammarRule("query")]
	public AstParserRuleReturnScope<object, IToken> query()
	{
		EnterRule_query();
		EnterRule("query", 1);
		TraceIn("query", 1);
		AstParserRuleReturnScope<object, IToken> retval = new AstParserRuleReturnScope<object, IToken>();
		retval.Start = (IToken)input.LT(1);

		object root_0 = default(object);

		IToken EOF2 = default(IToken);
		AstParserRuleReturnScope<object, IToken> or1 = default(AstParserRuleReturnScope<object, IToken>);

		object EOF2_tree = default(object);
		RewriteRuleITokenStream stream_EOF=new RewriteRuleITokenStream(adaptor,"token EOF");
		RewriteRuleSubtreeStream stream_or=new RewriteRuleSubtreeStream(adaptor,"rule or");
		try { DebugEnterRule(GrammarFileName, "query");
		DebugLocation(21, 15);
		try
		{
			// D:\\Eduar\\uh\\5to\\si\\InfoRecovery\\Code\\InfoRecovery.BooleanModel\\Grammar\\BooleanQuery.g:22:2: ( or EOF -> or )
			DebugEnterAlt(1);
			// D:\\Eduar\\uh\\5to\\si\\InfoRecovery\\Code\\InfoRecovery.BooleanModel\\Grammar\\BooleanQuery.g:22:4: or EOF
			{
			DebugLocation(22, 4);
			PushFollow(Follow._or_in_query132);
			or1=or();
			PopFollow();

			stream_or.Add(or1.Tree);
			DebugLocation(22, 7);
			EOF2=(IToken)Match(input,EOF,Follow._EOF_in_query134);  
			stream_EOF.Add(EOF2);



			{
			// AST REWRITE
			// elements: or
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 22:11: -> or
			{
				DebugLocation(22, 14);
				adaptor.AddChild(root_0, stream_or.NextTree());

			}

			retval.Tree = root_0;
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("query", 1);
			LeaveRule("query", 1);
			LeaveRule_query();
		}
		DebugLocation(22, 15);
		} finally { DebugExitRule(GrammarFileName, "query"); }
		return retval;

	}
	// $ANTLR end "query"

	partial void EnterRule_or();
	partial void LeaveRule_or();

	// $ANTLR start "or"
	// D:\\Eduar\\uh\\5to\\si\\InfoRecovery\\Code\\InfoRecovery.BooleanModel\\Grammar\\BooleanQuery.g:24:1: or : (x= and -> $x) ( ( OR y= and -> ^( OR $or $y) ) )* ;
	[GrammarRule("or")]
	private AstParserRuleReturnScope<object, IToken> or()
	{
		EnterRule_or();
		EnterRule("or", 2);
		TraceIn("or", 2);
		AstParserRuleReturnScope<object, IToken> retval = new AstParserRuleReturnScope<object, IToken>();
		retval.Start = (IToken)input.LT(1);

		object root_0 = default(object);

		IToken OR3 = default(IToken);
		AstParserRuleReturnScope<object, IToken> x = default(AstParserRuleReturnScope<object, IToken>);
		AstParserRuleReturnScope<object, IToken> y = default(AstParserRuleReturnScope<object, IToken>);

		object OR3_tree = default(object);
		RewriteRuleITokenStream stream_OR=new RewriteRuleITokenStream(adaptor,"token OR");
		RewriteRuleSubtreeStream stream_and=new RewriteRuleSubtreeStream(adaptor,"rule and");
		try { DebugEnterRule(GrammarFileName, "or");
		DebugLocation(24, 3);
		try
		{
			// D:\\Eduar\\uh\\5to\\si\\InfoRecovery\\Code\\InfoRecovery.BooleanModel\\Grammar\\BooleanQuery.g:24:4: ( (x= and -> $x) ( ( OR y= and -> ^( OR $or $y) ) )* )
			DebugEnterAlt(1);
			// D:\\Eduar\\uh\\5to\\si\\InfoRecovery\\Code\\InfoRecovery.BooleanModel\\Grammar\\BooleanQuery.g:24:6: (x= and -> $x) ( ( OR y= and -> ^( OR $or $y) ) )*
			{
			DebugLocation(24, 6);
			// D:\\Eduar\\uh\\5to\\si\\InfoRecovery\\Code\\InfoRecovery.BooleanModel\\Grammar\\BooleanQuery.g:24:6: (x= and -> $x)
			DebugEnterAlt(1);
			// D:\\Eduar\\uh\\5to\\si\\InfoRecovery\\Code\\InfoRecovery.BooleanModel\\Grammar\\BooleanQuery.g:24:7: x= and
			{
			DebugLocation(24, 8);
			PushFollow(Follow._and_in_or149);
			x=and();
			PopFollow();

			stream_and.Add(x.Tree);


			{
			// AST REWRITE
			// elements: x
			// token labels: 
			// rule labels: x, retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_x=new RewriteRuleSubtreeStream(adaptor,"rule x",x!=null?x.Tree:null);
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 24:13: -> $x
			{
				DebugLocation(24, 17);
				adaptor.AddChild(root_0, stream_x.NextTree());

			}

			retval.Tree = root_0;
			}

			}

			DebugLocation(25, 2);
			// D:\\Eduar\\uh\\5to\\si\\InfoRecovery\\Code\\InfoRecovery.BooleanModel\\Grammar\\BooleanQuery.g:25:2: ( ( OR y= and -> ^( OR $or $y) ) )*
			try { DebugEnterSubRule(1);
			while (true)
			{
				int alt1=2;
				try { DebugEnterDecision(1, false);
				int LA1_0 = input.LA(1);

				if ((LA1_0==OR))
				{
					alt1 = 1;
				}


				} finally { DebugExitDecision(1); }
				switch ( alt1 )
				{
				case 1:
					DebugEnterAlt(1);
					// D:\\Eduar\\uh\\5to\\si\\InfoRecovery\\Code\\InfoRecovery.BooleanModel\\Grammar\\BooleanQuery.g:26:3: ( OR y= and -> ^( OR $or $y) )
					{
					DebugLocation(26, 3);
					// D:\\Eduar\\uh\\5to\\si\\InfoRecovery\\Code\\InfoRecovery.BooleanModel\\Grammar\\BooleanQuery.g:26:3: ( OR y= and -> ^( OR $or $y) )
					DebugEnterAlt(1);
					// D:\\Eduar\\uh\\5to\\si\\InfoRecovery\\Code\\InfoRecovery.BooleanModel\\Grammar\\BooleanQuery.g:26:4: OR y= and
					{
					DebugLocation(26, 4);
					OR3=(IToken)Match(input,OR,Follow._OR_in_or163);  
					stream_OR.Add(OR3);

					DebugLocation(26, 8);
					PushFollow(Follow._and_in_or167);
					y=and();
					PopFollow();

					stream_and.Add(y.Tree);


					{
					// AST REWRITE
					// elements: y, or, OR
					// token labels: 
					// rule labels: y, retval
					// token list labels: 
					// rule list labels: 
					// wildcard labels: 
					retval.Tree = root_0;
					RewriteRuleSubtreeStream stream_y=new RewriteRuleSubtreeStream(adaptor,"rule y",y!=null?y.Tree:null);
					RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

					root_0 = (object)adaptor.Nil();
					// 26:13: -> ^( OR $or $y)
					{
						DebugLocation(26, 16);
						// D:\\Eduar\\uh\\5to\\si\\InfoRecovery\\Code\\InfoRecovery.BooleanModel\\Grammar\\BooleanQuery.g:26:16: ^( OR $or $y)
						{
						object root_1 = (object)adaptor.Nil();
						DebugLocation(26, 18);
						root_1 = (object)adaptor.BecomeRoot(stream_OR.NextNode(), root_1);

						DebugLocation(26, 22);
						adaptor.AddChild(root_1, stream_retval.NextTree());
						DebugLocation(26, 26);
						adaptor.AddChild(root_1, stream_y.NextTree());

						adaptor.AddChild(root_0, root_1);
						}

					}

					retval.Tree = root_0;
					}

					}


					}
					break;

				default:
					goto loop1;
				}
			}

			loop1:
				;

			} finally { DebugExitSubRule(1); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("or", 2);
			LeaveRule("or", 2);
			LeaveRule_or();
		}
		DebugLocation(27, 3);
		} finally { DebugExitRule(GrammarFileName, "or"); }
		return retval;

	}
	// $ANTLR end "or"

	partial void EnterRule_and();
	partial void LeaveRule_and();

	// $ANTLR start "and"
	// D:\\Eduar\\uh\\5to\\si\\InfoRecovery\\Code\\InfoRecovery.BooleanModel\\Grammar\\BooleanQuery.g:29:1: and : (x= term -> $x) ( ( AND y= term -> ^( AND $and $y) ) )* ;
	[GrammarRule("and")]
	private AstParserRuleReturnScope<object, IToken> and()
	{
		EnterRule_and();
		EnterRule("and", 3);
		TraceIn("and", 3);
		AstParserRuleReturnScope<object, IToken> retval = new AstParserRuleReturnScope<object, IToken>();
		retval.Start = (IToken)input.LT(1);

		object root_0 = default(object);

		IToken AND4 = default(IToken);
		AstParserRuleReturnScope<object, IToken> x = default(AstParserRuleReturnScope<object, IToken>);
		AstParserRuleReturnScope<object, IToken> y = default(AstParserRuleReturnScope<object, IToken>);

		object AND4_tree = default(object);
		RewriteRuleITokenStream stream_AND=new RewriteRuleITokenStream(adaptor,"token AND");
		RewriteRuleSubtreeStream stream_term=new RewriteRuleSubtreeStream(adaptor,"rule term");
		try { DebugEnterRule(GrammarFileName, "and");
		DebugLocation(29, 3);
		try
		{
			// D:\\Eduar\\uh\\5to\\si\\InfoRecovery\\Code\\InfoRecovery.BooleanModel\\Grammar\\BooleanQuery.g:29:5: ( (x= term -> $x) ( ( AND y= term -> ^( AND $and $y) ) )* )
			DebugEnterAlt(1);
			// D:\\Eduar\\uh\\5to\\si\\InfoRecovery\\Code\\InfoRecovery.BooleanModel\\Grammar\\BooleanQuery.g:29:7: (x= term -> $x) ( ( AND y= term -> ^( AND $and $y) ) )*
			{
			DebugLocation(29, 7);
			// D:\\Eduar\\uh\\5to\\si\\InfoRecovery\\Code\\InfoRecovery.BooleanModel\\Grammar\\BooleanQuery.g:29:7: (x= term -> $x)
			DebugEnterAlt(1);
			// D:\\Eduar\\uh\\5to\\si\\InfoRecovery\\Code\\InfoRecovery.BooleanModel\\Grammar\\BooleanQuery.g:29:8: x= term
			{
			DebugLocation(29, 9);
			PushFollow(Follow._term_in_and195);
			x=term();
			PopFollow();

			stream_term.Add(x.Tree);


			{
			// AST REWRITE
			// elements: x
			// token labels: 
			// rule labels: x, retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_x=new RewriteRuleSubtreeStream(adaptor,"rule x",x!=null?x.Tree:null);
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 29:15: -> $x
			{
				DebugLocation(29, 19);
				adaptor.AddChild(root_0, stream_x.NextTree());

			}

			retval.Tree = root_0;
			}

			}

			DebugLocation(30, 2);
			// D:\\Eduar\\uh\\5to\\si\\InfoRecovery\\Code\\InfoRecovery.BooleanModel\\Grammar\\BooleanQuery.g:30:2: ( ( AND y= term -> ^( AND $and $y) ) )*
			try { DebugEnterSubRule(2);
			while (true)
			{
				int alt2=2;
				try { DebugEnterDecision(2, false);
				int LA2_0 = input.LA(1);

				if ((LA2_0==AND))
				{
					alt2 = 1;
				}


				} finally { DebugExitDecision(2); }
				switch ( alt2 )
				{
				case 1:
					DebugEnterAlt(1);
					// D:\\Eduar\\uh\\5to\\si\\InfoRecovery\\Code\\InfoRecovery.BooleanModel\\Grammar\\BooleanQuery.g:31:3: ( AND y= term -> ^( AND $and $y) )
					{
					DebugLocation(31, 3);
					// D:\\Eduar\\uh\\5to\\si\\InfoRecovery\\Code\\InfoRecovery.BooleanModel\\Grammar\\BooleanQuery.g:31:3: ( AND y= term -> ^( AND $and $y) )
					DebugEnterAlt(1);
					// D:\\Eduar\\uh\\5to\\si\\InfoRecovery\\Code\\InfoRecovery.BooleanModel\\Grammar\\BooleanQuery.g:31:4: AND y= term
					{
					DebugLocation(31, 4);
					AND4=(IToken)Match(input,AND,Follow._AND_in_and209);  
					stream_AND.Add(AND4);

					DebugLocation(31, 9);
					PushFollow(Follow._term_in_and213);
					y=term();
					PopFollow();

					stream_term.Add(y.Tree);


					{
					// AST REWRITE
					// elements: y, AND, and
					// token labels: 
					// rule labels: y, retval
					// token list labels: 
					// rule list labels: 
					// wildcard labels: 
					retval.Tree = root_0;
					RewriteRuleSubtreeStream stream_y=new RewriteRuleSubtreeStream(adaptor,"rule y",y!=null?y.Tree:null);
					RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

					root_0 = (object)adaptor.Nil();
					// 31:15: -> ^( AND $and $y)
					{
						DebugLocation(31, 18);
						// D:\\Eduar\\uh\\5to\\si\\InfoRecovery\\Code\\InfoRecovery.BooleanModel\\Grammar\\BooleanQuery.g:31:18: ^( AND $and $y)
						{
						object root_1 = (object)adaptor.Nil();
						DebugLocation(31, 20);
						root_1 = (object)adaptor.BecomeRoot(stream_AND.NextNode(), root_1);

						DebugLocation(31, 25);
						adaptor.AddChild(root_1, stream_retval.NextTree());
						DebugLocation(31, 30);
						adaptor.AddChild(root_1, stream_y.NextTree());

						adaptor.AddChild(root_0, root_1);
						}

					}

					retval.Tree = root_0;
					}

					}


					}
					break;

				default:
					goto loop2;
				}
			}

			loop2:
				;

			} finally { DebugExitSubRule(2); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("and", 3);
			LeaveRule("and", 3);
			LeaveRule_and();
		}
		DebugLocation(32, 3);
		} finally { DebugExitRule(GrammarFileName, "and"); }
		return retval;

	}
	// $ANTLR end "and"

	partial void EnterRule_term();
	partial void LeaveRule_term();

	// $ANTLR start "term"
	// D:\\Eduar\\uh\\5to\\si\\InfoRecovery\\Code\\InfoRecovery.BooleanModel\\Grammar\\BooleanQuery.g:34:1: term : ( (x= TERM -> $x) | ( NOT y= TERM -> ^( NOT $y) ) | ( LPAR or RPAR -> or ) );
	[GrammarRule("term")]
	private AstParserRuleReturnScope<object, IToken> term()
	{
		EnterRule_term();
		EnterRule("term", 4);
		TraceIn("term", 4);
		AstParserRuleReturnScope<object, IToken> retval = new AstParserRuleReturnScope<object, IToken>();
		retval.Start = (IToken)input.LT(1);

		object root_0 = default(object);

		IToken x = default(IToken);
		IToken y = default(IToken);
		IToken NOT5 = default(IToken);
		IToken LPAR6 = default(IToken);
		IToken RPAR8 = default(IToken);
		AstParserRuleReturnScope<object, IToken> or7 = default(AstParserRuleReturnScope<object, IToken>);

		object x_tree = default(object);
		object y_tree = default(object);
		object NOT5_tree = default(object);
		object LPAR6_tree = default(object);
		object RPAR8_tree = default(object);
		RewriteRuleITokenStream stream_NOT=new RewriteRuleITokenStream(adaptor,"token NOT");
		RewriteRuleITokenStream stream_LPAR=new RewriteRuleITokenStream(adaptor,"token LPAR");
		RewriteRuleITokenStream stream_RPAR=new RewriteRuleITokenStream(adaptor,"token RPAR");
		RewriteRuleITokenStream stream_TERM=new RewriteRuleITokenStream(adaptor,"token TERM");
		RewriteRuleSubtreeStream stream_or=new RewriteRuleSubtreeStream(adaptor,"rule or");
		try { DebugEnterRule(GrammarFileName, "term");
		DebugLocation(34, 23);
		try
		{
			// D:\\Eduar\\uh\\5to\\si\\InfoRecovery\\Code\\InfoRecovery.BooleanModel\\Grammar\\BooleanQuery.g:34:6: ( (x= TERM -> $x) | ( NOT y= TERM -> ^( NOT $y) ) | ( LPAR or RPAR -> or ) )
			int alt3=3;
			try { DebugEnterDecision(3, false);
			switch (input.LA(1))
			{
			case TERM:
				{
				alt3 = 1;
				}
				break;
			case NOT:
				{
				alt3 = 2;
				}
				break;
			case LPAR:
				{
				alt3 = 3;
				}
				break;
			default:
				{
					NoViableAltException nvae = new NoViableAltException("", 3, 0, input);
					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(3); }
			switch (alt3)
			{
			case 1:
				DebugEnterAlt(1);
				// D:\\Eduar\\uh\\5to\\si\\InfoRecovery\\Code\\InfoRecovery.BooleanModel\\Grammar\\BooleanQuery.g:34:8: (x= TERM -> $x)
				{
				DebugLocation(34, 8);
				// D:\\Eduar\\uh\\5to\\si\\InfoRecovery\\Code\\InfoRecovery.BooleanModel\\Grammar\\BooleanQuery.g:34:8: (x= TERM -> $x)
				DebugEnterAlt(1);
				// D:\\Eduar\\uh\\5to\\si\\InfoRecovery\\Code\\InfoRecovery.BooleanModel\\Grammar\\BooleanQuery.g:34:9: x= TERM
				{
				DebugLocation(34, 10);
				x=(IToken)Match(input,TERM,Follow._TERM_in_term241);  
				stream_TERM.Add(x);



				{
				// AST REWRITE
				// elements: x
				// token labels: x
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				retval.Tree = root_0;
				RewriteRuleITokenStream stream_x=new RewriteRuleITokenStream(adaptor,"token x",x);
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 34:16: -> $x
				{
					DebugLocation(34, 20);
					adaptor.AddChild(root_0, stream_x.NextNode());

				}

				retval.Tree = root_0;
				}

				}


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// D:\\Eduar\\uh\\5to\\si\\InfoRecovery\\Code\\InfoRecovery.BooleanModel\\Grammar\\BooleanQuery.g:35:4: ( NOT y= TERM -> ^( NOT $y) )
				{
				DebugLocation(35, 4);
				// D:\\Eduar\\uh\\5to\\si\\InfoRecovery\\Code\\InfoRecovery.BooleanModel\\Grammar\\BooleanQuery.g:35:4: ( NOT y= TERM -> ^( NOT $y) )
				DebugEnterAlt(1);
				// D:\\Eduar\\uh\\5to\\si\\InfoRecovery\\Code\\InfoRecovery.BooleanModel\\Grammar\\BooleanQuery.g:35:5: NOT y= TERM
				{
				DebugLocation(35, 5);
				NOT5=(IToken)Match(input,NOT,Follow._NOT_in_term253);  
				stream_NOT.Add(NOT5);

				DebugLocation(35, 10);
				y=(IToken)Match(input,TERM,Follow._TERM_in_term257);  
				stream_TERM.Add(y);



				{
				// AST REWRITE
				// elements: y, NOT
				// token labels: y
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				retval.Tree = root_0;
				RewriteRuleITokenStream stream_y=new RewriteRuleITokenStream(adaptor,"token y",y);
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 35:16: -> ^( NOT $y)
				{
					DebugLocation(35, 19);
					// D:\\Eduar\\uh\\5to\\si\\InfoRecovery\\Code\\InfoRecovery.BooleanModel\\Grammar\\BooleanQuery.g:35:19: ^( NOT $y)
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(35, 21);
					root_1 = (object)adaptor.BecomeRoot(stream_NOT.NextNode(), root_1);

					DebugLocation(35, 26);
					adaptor.AddChild(root_1, stream_y.NextNode());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}

				}


				}
				break;
			case 3:
				DebugEnterAlt(3);
				// D:\\Eduar\\uh\\5to\\si\\InfoRecovery\\Code\\InfoRecovery.BooleanModel\\Grammar\\BooleanQuery.g:36:4: ( LPAR or RPAR -> or )
				{
				DebugLocation(36, 4);
				// D:\\Eduar\\uh\\5to\\si\\InfoRecovery\\Code\\InfoRecovery.BooleanModel\\Grammar\\BooleanQuery.g:36:4: ( LPAR or RPAR -> or )
				DebugEnterAlt(1);
				// D:\\Eduar\\uh\\5to\\si\\InfoRecovery\\Code\\InfoRecovery.BooleanModel\\Grammar\\BooleanQuery.g:36:5: LPAR or RPAR
				{
				DebugLocation(36, 5);
				LPAR6=(IToken)Match(input,LPAR,Follow._LPAR_in_term274);  
				stream_LPAR.Add(LPAR6);

				DebugLocation(36, 10);
				PushFollow(Follow._or_in_term276);
				or7=or();
				PopFollow();

				stream_or.Add(or7.Tree);
				DebugLocation(36, 13);
				RPAR8=(IToken)Match(input,RPAR,Follow._RPAR_in_term278);  
				stream_RPAR.Add(RPAR8);



				{
				// AST REWRITE
				// elements: or
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 36:18: -> or
				{
					DebugLocation(36, 21);
					adaptor.AddChild(root_0, stream_or.NextTree());

				}

				retval.Tree = root_0;
				}

				}


				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("term", 4);
			LeaveRule("term", 4);
			LeaveRule_term();
		}
		DebugLocation(36, 23);
		} finally { DebugExitRule(GrammarFileName, "term"); }
		return retval;

	}
	// $ANTLR end "term"
	#endregion Rules


	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _or_in_query132 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _EOF_in_query134 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _and_in_or149 = new BitSet(new ulong[]{0x82UL});
		public static readonly BitSet _OR_in_or163 = new BitSet(new ulong[]{0x260UL});
		public static readonly BitSet _and_in_or167 = new BitSet(new ulong[]{0x82UL});
		public static readonly BitSet _term_in_and195 = new BitSet(new ulong[]{0x12UL});
		public static readonly BitSet _AND_in_and209 = new BitSet(new ulong[]{0x260UL});
		public static readonly BitSet _term_in_and213 = new BitSet(new ulong[]{0x12UL});
		public static readonly BitSet _TERM_in_term241 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NOT_in_term253 = new BitSet(new ulong[]{0x200UL});
		public static readonly BitSet _TERM_in_term257 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LPAR_in_term274 = new BitSet(new ulong[]{0x260UL});
		public static readonly BitSet _or_in_term276 = new BitSet(new ulong[]{0x100UL});
		public static readonly BitSet _RPAR_in_term278 = new BitSet(new ulong[]{0x2UL});
	}
	#endregion Follow sets
}

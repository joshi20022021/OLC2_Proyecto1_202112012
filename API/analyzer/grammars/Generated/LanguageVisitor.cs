//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Language.g4 by ANTLR 4.13.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="LanguageParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.2")]
[System.CLSCompliant(false)]
public interface ILanguageVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="LanguageParser.programa"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrograma([NotNull] LanguageParser.ProgramaContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LanguageParser.funcionMain"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFuncionMain([NotNull] LanguageParser.FuncionMainContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LanguageParser.breakStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBreakStmt([NotNull] LanguageParser.BreakStmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LanguageParser.continueStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitContinueStmt([NotNull] LanguageParser.ContinueStmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LanguageParser.returnStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReturnStmt([NotNull] LanguageParser.ReturnStmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LanguageParser.bloque"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBloque([NotNull] LanguageParser.BloqueContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LanguageParser.sentencia"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSentencia([NotNull] LanguageParser.SentenciaContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>IfElse</c>
	/// labeled alternative in <see cref="LanguageParser.ifStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfElse([NotNull] LanguageParser.IfElseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LanguageParser.declaracion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDeclaracion([NotNull] LanguageParser.DeclaracionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Asignar</c>
	/// labeled alternative in <see cref="LanguageParser.asignacion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAsignar([NotNull] LanguageParser.AsignarContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>AsignarSlice</c>
	/// labeled alternative in <see cref="LanguageParser.asignacion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAsignarSlice([NotNull] LanguageParser.AsignarSliceContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>AsignarMatriz</c>
	/// labeled alternative in <see cref="LanguageParser.asignacion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAsignarMatriz([NotNull] LanguageParser.AsignarMatrizContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LanguageParser.tipo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTipo([NotNull] LanguageParser.TipoContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Switch</c>
	/// labeled alternative in <see cref="LanguageParser.switchStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSwitch([NotNull] LanguageParser.SwitchContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LanguageParser.caseBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCaseBlock([NotNull] LanguageParser.CaseBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LanguageParser.defaultBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDefaultBlock([NotNull] LanguageParser.DefaultBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ForCondicion</c>
	/// labeled alternative in <see cref="LanguageParser.forStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForCondicion([NotNull] LanguageParser.ForCondicionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ForClasico</c>
	/// labeled alternative in <see cref="LanguageParser.forStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForClasico([NotNull] LanguageParser.ForClasicoContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ForRange</c>
	/// labeled alternative in <see cref="LanguageParser.forStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForRange([NotNull] LanguageParser.ForRangeContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Incremento</c>
	/// labeled alternative in <see cref="LanguageParser.contador"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIncremento([NotNull] LanguageParser.IncrementoContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Decremento</c>
	/// labeled alternative in <see cref="LanguageParser.contador"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDecremento([NotNull] LanguageParser.DecrementoContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LanguageParser.sliceLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSliceLiteral([NotNull] LanguageParser.SliceLiteralContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LanguageParser.listLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitListLiteral([NotNull] LanguageParser.ListLiteralContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LanguageParser.sliceElemento"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSliceElemento([NotNull] LanguageParser.SliceElementoContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LanguageParser.funcionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFuncionCall([NotNull] LanguageParser.FuncionCallContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LanguageParser.parametros"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParametros([NotNull] LanguageParser.ParametrosContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LanguageParser.parametro"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParametro([NotNull] LanguageParser.ParametroContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Imprime</c>
	/// labeled alternative in <see cref="LanguageParser.imprimir"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitImprime([NotNull] LanguageParser.ImprimeContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>StructDeclaracion</c>
	/// labeled alternative in <see cref="LanguageParser.declaracionStruct"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStructDeclaracion([NotNull] LanguageParser.StructDeclaracionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Atributo</c>
	/// labeled alternative in <see cref="LanguageParser.atributoStruct"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAtributo([NotNull] LanguageParser.AtributoContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>MetodoStruct</c>
	/// labeled alternative in <see cref="LanguageParser.funcionStruct"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMetodoStruct([NotNull] LanguageParser.MetodoStructContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LanguageParser.expresionLiteralStruct"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpresionLiteralStruct([NotNull] LanguageParser.ExpresionLiteralStructContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LanguageParser.atributosInicializacion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAtributosInicializacion([NotNull] LanguageParser.AtributosInicializacionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ComparacionIgual</c>
	/// labeled alternative in <see cref="LanguageParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComparacionIgual([NotNull] LanguageParser.ComparacionIgualContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Or</c>
	/// labeled alternative in <see cref="LanguageParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOr([NotNull] LanguageParser.OrContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>FuncionAppend</c>
	/// labeled alternative in <see cref="LanguageParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFuncionAppend([NotNull] LanguageParser.FuncionAppendContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>LiteralEntero</c>
	/// labeled alternative in <see cref="LanguageParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLiteralEntero([NotNull] LanguageParser.LiteralEnteroContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Multiplicacion</c>
	/// labeled alternative in <see cref="LanguageParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultiplicacion([NotNull] LanguageParser.MultiplicacionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>LiteralVerdadero</c>
	/// labeled alternative in <see cref="LanguageParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLiteralVerdadero([NotNull] LanguageParser.LiteralVerdaderoContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>AccesoSlice</c>
	/// labeled alternative in <see cref="LanguageParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAccesoSlice([NotNull] LanguageParser.AccesoSliceContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>MenorOIgual</c>
	/// labeled alternative in <see cref="LanguageParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMenorOIgual([NotNull] LanguageParser.MenorOIgualContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Division</c>
	/// labeled alternative in <see cref="LanguageParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDivision([NotNull] LanguageParser.DivisionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Resta</c>
	/// labeled alternative in <see cref="LanguageParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitResta([NotNull] LanguageParser.RestaContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ComparacionDiferente</c>
	/// labeled alternative in <see cref="LanguageParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComparacionDiferente([NotNull] LanguageParser.ComparacionDiferenteContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>LiteralCadena</c>
	/// labeled alternative in <see cref="LanguageParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLiteralCadena([NotNull] LanguageParser.LiteralCadenaContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Parentesis</c>
	/// labeled alternative in <see cref="LanguageParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParentesis([NotNull] LanguageParser.ParentesisContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Modulo</c>
	/// labeled alternative in <see cref="LanguageParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitModulo([NotNull] LanguageParser.ModuloContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>FuncionLlamada</c>
	/// labeled alternative in <see cref="LanguageParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFuncionLlamada([NotNull] LanguageParser.FuncionLlamadaContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>LiteralRune</c>
	/// labeled alternative in <see cref="LanguageParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLiteralRune([NotNull] LanguageParser.LiteralRuneContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>AccesoSlice2D</c>
	/// labeled alternative in <see cref="LanguageParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAccesoSlice2D([NotNull] LanguageParser.AccesoSlice2DContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>LiteralFlotante</c>
	/// labeled alternative in <see cref="LanguageParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLiteralFlotante([NotNull] LanguageParser.LiteralFlotanteContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>FuncionJoin</c>
	/// labeled alternative in <see cref="LanguageParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFuncionJoin([NotNull] LanguageParser.FuncionJoinContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Suma</c>
	/// labeled alternative in <see cref="LanguageParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSuma([NotNull] LanguageParser.SumaContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Not</c>
	/// labeled alternative in <see cref="LanguageParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNot([NotNull] LanguageParser.NotContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ExpresionAccesoAtributo</c>
	/// labeled alternative in <see cref="LanguageParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpresionAccesoAtributo([NotNull] LanguageParser.ExpresionAccesoAtributoContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>FuncionLen</c>
	/// labeled alternative in <see cref="LanguageParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFuncionLen([NotNull] LanguageParser.FuncionLenContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ExpresionStructLiteral</c>
	/// labeled alternative in <see cref="LanguageParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpresionStructLiteral([NotNull] LanguageParser.ExpresionStructLiteralContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>FuncionIndex</c>
	/// labeled alternative in <see cref="LanguageParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFuncionIndex([NotNull] LanguageParser.FuncionIndexContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Slice</c>
	/// labeled alternative in <see cref="LanguageParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSlice([NotNull] LanguageParser.SliceContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>And</c>
	/// labeled alternative in <see cref="LanguageParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAnd([NotNull] LanguageParser.AndContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>LiteralNulo</c>
	/// labeled alternative in <see cref="LanguageParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLiteralNulo([NotNull] LanguageParser.LiteralNuloContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>MayorOIgual</c>
	/// labeled alternative in <see cref="LanguageParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMayorOIgual([NotNull] LanguageParser.MayorOIgualContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>LiteralFalso</c>
	/// labeled alternative in <see cref="LanguageParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLiteralFalso([NotNull] LanguageParser.LiteralFalsoContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>MayorQue</c>
	/// labeled alternative in <see cref="LanguageParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMayorQue([NotNull] LanguageParser.MayorQueContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Identificador</c>
	/// labeled alternative in <see cref="LanguageParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentificador([NotNull] LanguageParser.IdentificadorContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>MenorQue</c>
	/// labeled alternative in <see cref="LanguageParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMenorQue([NotNull] LanguageParser.MenorQueContext context);
}

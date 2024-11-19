using Microsoft.CodeAnalysis;

namespace Vogen.Types;

internal class EscapedSymbolFullName
{
    public EscapedSymbolFullName(INamedTypeSymbol symbol) => Value = symbol.EscapedFullName();

    public string Value { get; }
    
    public static implicit operator string(EscapedSymbolFullName name) => name.Value;
    public override string ToString() => Value;
}
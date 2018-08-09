namespace Meziantou.Framework.CodeDom
{
    public class ClassDeclaration : TypeDeclaration, IParametrableType, IInheritanceParameters, ITypeDeclarationContainer, IMemberContainer
    {
        public ClassDeclaration()
            : this(null)
        {
        }

        public ClassDeclaration(string name)
        {
            Name = name;
            Implements = new CodeObjectCollection<TypeReference>(this);
            Parameters = new CodeObjectCollection<TypeParameter>(this);
            Members = new CodeObjectCollection<MemberDeclaration>(this);
            Types = new CodeObjectCollection<TypeDeclaration>(this);
        }

        public TypeReference BaseType { get; set; }
        public CodeObjectCollection<TypeReference> Implements { get; }
        public CodeObjectCollection<TypeParameter> Parameters { get; }
        public CodeObjectCollection<MemberDeclaration> Members { get; }
        public CodeObjectCollection<TypeDeclaration> Types { get; }
    }
}